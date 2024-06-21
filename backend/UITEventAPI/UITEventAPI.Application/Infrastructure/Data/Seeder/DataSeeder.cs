using Bogus;
using Microsoft.AspNetCore.Identity;
using System.Diagnostics;
using System.Globalization;
using UITEventAPI.Application.Domain.Events;
using UITEventAPI.Application.Domain.Students;
using UITEventAPI.Application.Domain.UniversityUnit;
using UITEventAPI.Application.Domain.Users;

namespace UITEventAPI.Application.Infrastructure.Data.Seeder;

public class DataSeeder
{
    private const string LOCALE = "vi";
    private const string DATETIMEREF = "2024-05-05";

    private readonly IPasswordHasher<User> _passwordHasher;

    public List<User> Users { get; set; }
    public List<IdentityUserRole<int>> IdentityUserRoles { get; set; }
    public List<Student> Students { get; set; }
    public List<UniversityUnit> UniversityUnits { get; set; }
    public List<Event> Events { get; set; }
    public List<EventRegistration> EventRegistrations { get; set; }
    public List<EventImage> EventImages { get; set; }


    public DataSeeder(
        IPasswordHasher<User> passwordHasher    
    )
    {
        _passwordHasher = passwordHasher;

        // number of users must be greater than 11
        Users = GenerateUsers(40);
        IdentityUserRoles = GenerateUserRoles(Users);
        Students = GenerateStudents(Users, IdentityUserRoles);
        UniversityUnits = GenerateUniversityUnits(Users, IdentityUserRoles);
        Events = GenerateEvents(5, UniversityUnits);
        EventRegistrations = GenerateEventRegistrations(50, Events, Students);
        EventImages = GenerateEventImages(20, Events);
    }

    public List<User> GenerateUsers(int amount)
    {
        var userId = 1;
        var usedUserName = new HashSet<string>();
        var userFaker = new Faker<User>(LOCALE)
            .RuleFor(u => u.Id, f => userId++)
            .RuleFor(u => u.UserName, f =>
            {
                var userName = "";
                do
                {
                    userName = f.Random.Number(100000, 300000).ToString();
                }
                while (usedUserName.Contains(userName));

                usedUserName.Add(userName);
                return userName;
            })
            .RuleFor(u => u.NormalizedUserName, (f, u) => u.UserName!.ToUpper())
            .RuleFor(u => u.Email, (f, u) => $"{u.UserName!}@gm.uit.edu.vn")
            .RuleFor(u => u.NormalizedEmail, (f,u) => u.Email!.ToUpper())
            .RuleFor(u => u.EmailConfirmed, f => true)
            .RuleFor(u => u.ConcurrencyStamp, f => f.Random.Guid().ToString())
            .RuleFor(u => u.SecurityStamp, f => f.Random.Guid().ToString())
            .RuleFor(u => u.PhoneNumber, f => f.Phone.PhoneNumber())
            .RuleFor(u => u.PasswordHash, (f,u) => _passwordHasher.HashPassword(u ,"Abc123@"))
            .RuleFor(u => u.PhoneNumberConfirmed, f => true)
            .RuleFor(u => u.IsActive, f => true)
            .RuleFor(u => u.AvatarUrl, f => f.Image.PicsumUrl())
            .UseDateTimeReference(DateTime.Parse(DATETIMEREF));

        var users = Enumerable.Range(1, amount)
            .Select(u => SeedRow(userFaker, u))
            .ToList();

        return users;
    }

    public List<IdentityUserRole<int>> GenerateUserRoles(
        IEnumerable<User> users
    )
    {
        var userRoles = new List<IdentityUserRole<int>>();
        var userRoleFaker = new Faker<IdentityUserRole<int>>(); // Move the faker declaration outside the loop

        for (int i = 0; i < users.Count(); i++)
        {
            var user = users.ElementAt(i);
            var roleId = i < 10 ? (int)UserRole.UnitAdmin :
                         i == 10 ? (int)UserRole.UniversityAdmin : (int)UserRole.Student;

            userRoles.Add(userRoleFaker.UseSeed(i)
                .RuleFor(ur => ur.UserId, _ => user.Id)
                .RuleFor(ur => ur.RoleId, _ => roleId)
                .Generate());
        }

        return userRoles;
    }

    public List<Student> GenerateStudents(
    IEnumerable<User> users,
    IEnumerable<IdentityUserRole<int>> userRoles
)
    {
        var studentId = 1;
        var userWhoIsStudent = userRoles
            .Where(ur => ur.RoleId == (int)UserRole.Student)
            .Select(ur => users.FirstOrDefault(u => u.Id == ur.UserId))
            .ToList();

        var availableStudentUsers = new List<User>(userWhoIsStudent);
        var usedStudentIds = new HashSet<int>();

        var studentFaker = new Faker<Student>(LOCALE)
            .RuleFor(s => s.Id, f => studentId++)
            .RuleFor(s => s.UserId, f =>
            {
                var user = f.PickRandom(availableStudentUsers);
                availableStudentUsers.Remove(user);
                return user.Id;
            })
            .RuleFor(s => s.FirstName, f => f.Person.FirstName)
            .RuleFor(s => s.LastName, f => f.Person.LastName)
            .RuleFor(s => s.DateOfBirth, f => f.Person.DateOfBirth)
            .RuleFor(s => s.StudentCode, (f, s) =>
            {
                var newStudentId = userWhoIsStudent.Where(u => u!.Id == s.UserId).Select(u => int.Parse(u!.UserName!)).First();
                return newStudentId;
            })
            .UseDateTimeReference(DateTime.Parse(DATETIMEREF));

        var students = Enumerable.Range(1, userWhoIsStudent.Count)
            .Select(s => SeedRow(studentFaker, s))
            .ToList();

        // update user's studentId for user who is student
        
        //foreach (var student in students)
        //{
        //    var user = Users.FirstOrDefault(u => u.Id == student.UserId);
        //    user.StudentId = student.Id;
        //}

        return students;
    }

    public List<UniversityUnit> GenerateUniversityUnits(
    IEnumerable<User> users,
    IEnumerable<IdentityUserRole<int>> userRoles
)
    {
        var unitId = 1;
        var userWithUnitAdminRoles = userRoles
            .Where(ur => ur.RoleId == (int)UserRole.UnitAdmin)
            .Select(ur => users.FirstOrDefault(u => u.Id == ur.UserId))
            .ToList();

        var availableUnitAdminUsers = new List<User>(userWithUnitAdminRoles);

        var unitFaker = new Faker<UniversityUnit>(LOCALE)
            .RuleFor(u => u.Id, f => unitId++)
            .RuleFor(u => u.Name, f => f.Company.CompanyName())
            .RuleFor(u => u.Description, f => f.Lorem.Sentence())
            .RuleFor(u => u.UserId, f =>
            {
                var user = f.PickRandom(availableUnitAdminUsers);
                availableUnitAdminUsers.Remove(user);
                return user.Id;
            });

        var units = Enumerable.Range(1, userWithUnitAdminRoles.Count)
            .Select(u => SeedRow(unitFaker, u))
            .ToList();

        // update user's studentId for user who is student
        //foreach (var unit in units)
        //{
        //    var user = Users.FirstOrDefault(u => u.Id == unit.UserId);
        //    user.UniversityUnitId = unit.Id;
        //}

        return units;
    }

    public List<Event> GenerateEvents(
        int amount,
        IEnumerable<UniversityUnit> universityUnits    
    )
    {
        var eventId = 1;
        var eventFaker = new Faker<Event>(LOCALE)
            .RuleFor(e => e.Id, f => eventId++)
            .RuleFor(e => e.Title, f => f.Lorem.Sentence())
            .RuleFor(e => e.Description, f => f.Lorem.Paragraph())
            .RuleFor(e => e.StartDate, f => f.Date.Past(2))
            .RuleFor(e => e.EndDate, (f, e) => f.Date.Between(e.StartDate, e.StartDate.AddMonths(1)))
            .RuleFor(e => e.Location, f => f.Address.FullAddress())
            .RuleFor(e => e.UniversityUnitId, f => f.PickRandom(universityUnits).Id)
            .RuleFor(e => e.IsPublished, f => f.Random.Bool())
            .RuleFor(e => e.FormUrl, f => "https://forms.gle/HkCD86Gc9UmTTZLP9")
            .RuleFor(e => e.Type, f => f.PickRandom<EventType>())
            .RuleFor(e => e.MaxAttendees, f => f.Random.Number(20, 100))
            .RuleFor(e => e.IsDeleted, f => false)
            .RuleFor(e => e.TrainingPoint, f => f.Random.Number(1, 6))
            .UseDateTimeReference(DateTime.Parse(DATETIMEREF));

        var events = Enumerable.Range(1, amount)
            .Select(e => SeedRow(eventFaker, e))
            .ToList();

        return events;
    }

    public List<EventRegistration> GenerateEventRegistrations(
        int amount,
        IEnumerable<Event> events,
        IEnumerable<Student> students
    )
    {
        var registrationId = 1;
        var eventRegistrationFaker = new Faker<EventRegistration>(LOCALE)
            .RuleFor(er => er.Id, f => registrationId++)
            .RuleFor(er => er.EventId, f => f.PickRandom(events).Id)
            .RuleFor(er => er.StudentId, f => f.PickRandom(students).Id)
            .RuleFor(er => er.IsRegistered, f => true)
            .RuleFor(er => er.RegisterDate, (f, er) =>
            {
                var eventObj = events.FirstOrDefault(e => e.Id == er.EventId);
                return f.Date.Between(eventObj.StartDate.AddMonths(-2), eventObj.StartDate.AddDays(-1));
            })
            .RuleFor(er => er.AttendedDate, (f, er) =>
            {
                var registerDate = er.RegisterDate;
                var eventObj = events.FirstOrDefault(e => e.Id == er.EventId);
                // 50% chance to have attended date
                return f.Random.Bool() ? f.Date.Between(registerDate, eventObj.StartDate) : null;
            })
            .RuleFor(er => er.IsAttended, (f, er) => er.AttendedDate.HasValue)
            .UseDateTimeReference(DateTime.Parse(DATETIMEREF));

        var eventRegistrations = Enumerable.Range(1, amount)
            .Select(er => SeedRow(eventRegistrationFaker, er))
            .ToList();

        return eventRegistrations;
    }

    public List<EventImage> GenerateEventImages(
        int amount,
        IEnumerable<Event> events    
    )
    {
        var imageId = 1;
        var eventImageFaker = new Faker<EventImage>(LOCALE)
            .RuleFor(ei => ei.Id, f => imageId++)
            .RuleFor(ei => ei.EventId, f => f.PickRandom(events).Id)
            .RuleFor(ei => ei.ImageUrl, f => f.Image.PicsumUrl());

        var eventImages = Enumerable.Range(1, amount)
            .Select(ei => SeedRow(eventImageFaker, ei))
            .ToList();

        return eventImages;
    }

    private static T SeedRow<T>(Faker<T> faker, int rowId) where T : class
    {
        var recordRow = faker.UseSeed(rowId).Generate();
        return recordRow;
    }
}
