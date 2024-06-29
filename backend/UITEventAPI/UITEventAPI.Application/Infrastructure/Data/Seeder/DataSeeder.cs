using Bogus;
using Microsoft.AspNetCore.Identity;
using UITEventAPI.Application.Domain.Events;
using UITEventAPI.Application.Domain.Students;
using UITEventAPI.Application.Domain.UniversityUnits;
using UITEventAPI.Application.Domain.Users;

namespace UITEventAPI.Application.Infrastructure.Data.Seeder;

public class DataSeeder
{
    private const string LOCALE = "vi";
    private const string DATETIMEREF = "2024-05-05";
    private const int YEARS_TO_GO_BACK_FOR_CREATED_DATE = 3;
    private readonly IPasswordHasher<User> _passwordHasher;

    public List<User> Users { get; set; }
    public List<IdentityUserRole<int>> IdentityUserRoles { get; set; }
    public List<Student> Students { get; set; }
    public List<UniversityUnit> UniversityUnits { get; set; }
    public List<UnitFollow> UnitFollows { get; set; }
    public List<Event> Events { get; set; }
    public List<EventRegistration> EventRegistrations { get; set; }
    public List<EventImage> EventImages { get; set; }

    private readonly List<UnitWithEvent> super = Data.data;

    private readonly List<dynamic> data = [
        new{
            Name = "Hoạt động Đoàn Hội - Hệ thống Thông tin",
            Description = "Fanpage chính thức cho các hoạt động, sự kiện do Đoàn Khoa - Liên chi Hội HTTT tổ chức.",
            FacebookUrl = "https://www.facebook.com/DoanHoiHTTT",
            Email = "httt.doanhoi@gmail.com",
            AvatarUrl = "https://tinyurl.com/dhhttt123",
        },
        new{
            Name = "Khoa Hệ Thống Thông Tin - Trường ĐH Công nghệ Thông tin",
            Description = "Khoa Hệ Thống Thông Tin - Trường ĐH Công nghệ Thông tin",
            FacebookUrl = "https://www.facebook.com/uit.khoahttt",
            Email = "info.httt@uit.edu.vn",
            AvatarUrl = "https://tinyurl.com/khoahttt",
        },
        new{
            Name = "Mạng máy tính và Truyền thông",
            Description = "Khoa Mạng máy tính và Truyền thông, Trường Đại học Công nghệ Thông tin - ĐHQG-HCM",
            FacebookUrl = "https://www.facebook.com/uit.nc",
            Email = "doanthanhnien@suctremmt.com",
            AvatarUrl = "https://tinyurl.com/khoammttt",
        },
        new{
            Name = "SeExpress - Kênh thông tin khoa Công Nghệ Phần Mềm, ĐH CNTT",
            Description = "Kênh thông tin chính thức của khoa Công Nghệ Phần Mềm, ĐH CNTT, được thành lập và quản lí bởi Đoàn khoa, Liên chi Hội khoa Công Nghệ Phần Mềm.",
            FacebookUrl = "https://www.facebook.com/CNPM.Fanpage",
            Email = "cnpm.fanpage@gmail.com",
            AvatarUrl = "https://tinyurl.com/khoacnpmuit",
        },
        new{
            Name = "Khoa Kỹ Thuật Máy Tính - CE.UIT",
            Description = "- Trang thông tin Đoàn - Hội khoa Kỹ thuật Máy tính. - Cập nhật các cuộc thi học thuật.",
            FacebookUrl = "https://www.facebook.com/ce.uit",
            Email = "tuoitre.ktmt@gm.uit.edu.vn",
            AvatarUrl = "https://tinyurl.com/khoaktmtuit",
        },
        new{
            Name = "Khoa Khoa học và Kỹ thuật Thông tin - UIT",
            Description = "Trang thông tin về các hoạt động, các chương trình từ khoa Khoa học và Kỹ thuật Thông tin - UIT",
            FacebookUrl = "https://www.facebook.com/UIT.ISE",
            Email = "bch.khkttt.uit@gmail.com",
            AvatarUrl = "https://tinyurl.com/khoaiseuit",
        },
        new{
            Name = "Khoa Khoa học Máy tính UIT",
            Description = "Page chính thức của Khoa Khoa Học Máy Tính - Trường Đại Học Công Nghệ Thông Tin, ĐHQG TP.HCM (CS-UIT)",
            FacebookUrl = "https://www.facebook.com/uit.cs",
            Email = "bch.cs.uit@gmail.com",
            AvatarUrl = "https://tinyurl.com/khoakhmtuit",
        },
        new{
            Name = "Đội Công Tác Xã Hội Trường ĐH Công Nghệ Thông Tin",
            Description = "Đội Công tác Xã hội Trường Đại học Công nghệ Thông tin, ĐHQG-HCM",
            FacebookUrl = "https://www.facebook.com/ctxh.uit",
            Email = "doictxh.uit@gmail.com",
            AvatarUrl = "https://tinyurl.com/doictxhuit",
        },
        new{
            Name = "Câu lạc bộ AI - khoa Khoa học Máy tính UIT",
            Description = "Là một diễn đàn cho các sinh viên đam mê Trí tuệ nhân tạo học hỏi và chia sẻ kiến thức.",
            FacebookUrl = "https://www.facebook.com/uit.cs.aiclub",
            Email = "aiclub@uit.edu.vn",
            AvatarUrl = "https://tinyurl.com/clbaiclub",
        },
        new{
            Name = "Thủ Lĩnh Sinh Viên - UIT",
            Description = "Hội thi Thủ lĩnh sinh viên - Đại học Công nghệ Thông tin - ĐHQG HCM",
            FacebookUrl = "https://www.facebook.com/uit.tlsv",
            Email = "hoisinhvien@uit.edu.vn",
            AvatarUrl = "https://tinyurl.com/uittlsv",
        },
        new{
            Name = "Taekwondo UIT",
            Description = "Là trang thông tin chính thức của CLB Taekwondo UIT - Đại học Công nghệ Thông tin - ĐHQG TP.HCM",
            FacebookUrl = "https://www.facebook.com/uittaekwondo",
            Email = "taekwondo.uit.vnu@gmail.com",
            AvatarUrl = "https://tinyurl.com/uittkd",
        },
        new{
            Name = "UIT Open English Club",
            Description = "𝐎𝐏𝐄𝐍 𝐄𝐍𝐆𝐋𝐈𝐒𝐇 𝐂𝐋𝐔𝐁 - 𝐎𝐏𝐄𝐑𝐀𝐓𝐄𝐃 𝐁𝐘 𝐒𝐓𝐔𝐃𝐄𝐍𝐓𝐒, 𝐅𝐎𝐑 𝐒𝐓𝐔𝐃𝐄𝐍𝐓𝐒",
            FacebookUrl = "https://www.facebook.com/oeclub.uit",
            Email = "oeclub.uit@gmail.com",
            AvatarUrl = "https://tinyurl.com/openengclub",
        },
        new{
            Name = "WebDev Studios",
            Description = "WebDev Studios xin chào!",
            FacebookUrl = "https://www.facebook.com/webdevstudios.org",
            Email = "webdevstudios.org@gmail.com",
            AvatarUrl = "https://tinyurl.com/webdevuit",
        },
        new{
            Name = "Ban học tập Công nghệ Phần mềm",
            Description = "Ban học tập Công nghệ Phần mềm là nơi chia sẻ tài liệu, kiến thức về CNTT dành cho các bạn sinh viên.",
            FacebookUrl = "https://www.facebook.com/bhtcnpm",
            Email = "bht.cnpm.uit@gmail.com",
            AvatarUrl = "https://tinyurl.com/bhtcnpmuit",
        },
        new{
            Name = "Ban Học Tập Khoa Hệ Thống Thông Tin",
            Description = "Đây là Fanpage chính thức của Ban học tập Khoa Hệ Thống Thông Tin trực thuộc Đoàn - Hội Khoa Hệ Thống Thông Tin",
            FacebookUrl = "https://www.facebook.com/BHTHTTT",
            Email = "bhthttt.uit@gmail.com",
            AvatarUrl = "https://tinyurl.com/bhthtttuit",
        },
        new{
            Name = "Đội Event - UIT",
            Description = "Đội tổ chức sự kiện trực thuộc Hội Sinh viên trường Đại học Công nghệ Thông tin - ĐHQG Tp.Hồ Chí Minh",
            FacebookUrl = "https://www.facebook.com/UIT.EventTeam",
            Email = "doievent.uit@gmail.com",
            AvatarUrl = "https://tinyurl.com/eventuitteam",
        },
        new{
            Name = "UIT GamApp Studios",
            Description = "UIT GamApp Studio - CLB Lập trình Game và ứng dụng - trực thuộc Đoàn Khoa Công nghệ phần mềm - ĐHCNTT - ĐHQG TP.HCM. Giá trị cốt lõi: CHIA SẺ - QUẢNG BÁ THƯƠNG HIỆU - GIÚP ĐỠ CỘNG ĐỒNG",
            FacebookUrl = "https://www.facebook.com/UITGamAppStudios",
            Email = "gamappuit.club@gmail.com",
            AvatarUrl = "https://tinyurl.com/uitgamapp",
        },
        new{
            Name = "CLB Sách Và Hành Động UIT",
            Description = "CLB Sách và Hành Động UIT",
            FacebookUrl = "https://www.facebook.com/clb.sachvahanhdong.uit",
            Email = "clb.sachvahanhdong.uit@gmail.com",
            AvatarUrl = "https://tinyurl.com/sachvahanhdonguit",
        },
        new{
            Name = "CLB Tiếng Nhật UIT - Wakame",
            Description = "CLB WAKAME được thành lập với sự hỗ trợ của OEP, Hội SV-UIT, khoa KH&KTTT",
            FacebookUrl = "https://www.facebook.com/hcmuit.wakame",
            Email = "wakameuit@gmail.com",
            AvatarUrl = "https://tinyurl.com/clbtiengnhatuit",
        },
        new{
            Name = "UIT Media Club",
            Description = "📸 Beyond mere media",
            FacebookUrl = "https://www.facebook.com/media.uit",
            Email = "photo@uit.edu.vn",
            AvatarUrl = "https://tinyurl.com/mediauit",
        },
        new{
            Name = "Mùa Hè Xanh UIT",
            Description = "Trang thông tin chiến dịch Mùa Hè Xanh 2012 - Đại Học Công Nghệ Thông Tin",
            FacebookUrl = "https://www.facebook.com/mhxuit",
            Email = "mhx.uit@gmail.com",
            AvatarUrl = "https://tinyurl.com/muahexanhuit",
        }
    ];

    public DataSeeder(
        IPasswordHasher<User> passwordHasher    
    )
    {
        _passwordHasher = passwordHasher;

        // number of users must be greater than 11
        Users = GenerateUsers();
        IdentityUserRoles = GenerateUserRoles(Users);
        Students = GenerateStudents(Users, IdentityUserRoles);
        UniversityUnits = GenerateUniversityUnits(Users, IdentityUserRoles);
        UnitFollows = GenerateUnitFollows(Students, UniversityUnits);
        Events = GenerateEvents(20, UniversityUnits);
        EventRegistrations = GenerateEventRegistrations(200, Events, Students);
        EventImages = GenerateEventImages(400, Events);
    }

    

    public List<User> GenerateUsers()
    {
        var predefinedUserNames = new List<string>() { 
            "21521026", "21522262", "21522215", "21521326", "23527857", "23521674", "19522741", "23526000",
            "23527605", "21528211", "19522251", "22524714", "23526143", "23521113", "19528922", "22526428",
            "22526796", "22522000", "23525333", "22523427", "21522295", "19522351", "21526968", "23524818",
            "22521905", "22526595", "20523910", "20526297", "20521405", "22528157", "19521984", "23526826",
            "23529748", "20525750", "23529029", "19528160", "23527033", "20527630", "20525863", "21529446",
            "21528534", "20522137", "22527913", "22521194", "19525497", "19527020", "23521725", "23528867",
            "22529148", "20528388", "23521526", "21524800", "22522078", "19525954", "22525421", "23528552",
            "23527087", "21523357", "22529422", "22527605", "20525753", "19527098", "19523490", "23524156",
            "20528162", "21528608", "21524562", "23524419", "19522611", "23528985", "23523150", "21523045",
            "23525656", "22523710", "19527406", "23526426", "19523331", "19521559", "20527950", "22527012",
            "21528341", "20529488", "23526222", "22521125", "21521254", "21527943", "19527306", "22521877",
            "21522663", "21523623", "19523916", "21524135", "20529046", "21521231", "23529120", "22525493",
            "23521125", "21524904", "20525936", "21524672", "23527643", "20521853", "21522897", "21527479",
            "22528008", "22529763", "22521574", "23529415", "22525846", "23523074", "19524092", "20527273",
            "19524989", "21525451", "19529323", "23525084", "19523277", "23529672", "20523184", "20528585",
            "21525160", "22528659", "23521870", "23524630", "19524223", "20522274", "22528409", "19522617",
        };

        var usedUserName = new HashSet<string>() {};

        var userId = 1;
        var studentUserFaker = new Faker<User>(LOCALE)
            .RuleFor(u => u.Id, f => userId++)
            .RuleFor(u => u.UserName, f =>
            {
                var userName = "";
                do
                {
                    if (usedUserName.Count < 4)
                        userName = predefinedUserNames[usedUserName.Count];
                    else
                        userName = f.Random.CollectionItem(predefinedUserNames);
                } while (usedUserName.Contains(userName));
                
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

        var studentUsers = Enumerable.Range(1, predefinedUserNames.Count)
            .Select(u => SeedRow(studentUserFaker, u))
            .ToList();

        var iStart = 0;
        var UnitAdminUserFaker = new Faker<User>(LOCALE)
            .RuleFor(u => u.Id, f => userId++)
            .RuleFor(u => u.UserName, f => super[iStart].Email)
            .RuleFor(u => u.NormalizedUserName, (f, u) => u.UserName!.ToUpper())
            .RuleFor(u => u.Email, f => super[iStart].Email)
            .RuleFor(u => u.NormalizedEmail, (f,u) => u.Email!.ToUpper())
            .RuleFor(u => u.EmailConfirmed, f => true)
            .RuleFor(u => u.ConcurrencyStamp, f => f.Random.Guid().ToString())
            .RuleFor(u => u.SecurityStamp, f => f.Random.Guid().ToString())
            .RuleFor(u => u.PhoneNumber, f => f.Phone.PhoneNumber())
            .RuleFor(u => u.PasswordHash, (f,u) => _passwordHasher.HashPassword(u ,"Abc123@"))
            .RuleFor(u => u.PhoneNumberConfirmed, f => true)
            .RuleFor(u => u.IsActive, f => true)
            .RuleFor(u => u.AvatarUrl, f => super[iStart++].AvatarUrl)
            .UseDateTimeReference(DateTime.Parse(DATETIMEREF));

        var unitAdminUsers = Enumerable.Range(1, super.Count)
            .Select(u => SeedRow(UnitAdminUserFaker, u))
            .ToList();

        var users = new List<User>();
        users.AddRange(studentUsers);
        users.AddRange(unitAdminUsers);

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
            var roleId = 1;

            if (super.Exists(item => item.Email == user.Email))
            {
                roleId = (int)UserRole.UnitAdmin;
            }
            else
            {
                roleId = (int)UserRole.Student;
            }

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
            .RuleFor(u => u.Name, f => super[unitId - 2].Name)
            .RuleFor(u => u.Description, f => super[unitId - 2].Description)
            .RuleFor(u => u.FacebookUrl, f => super[unitId - 2].FacebookUrl)
            .RuleFor(u => u.UserId, f =>
            {
                var user = users.First(u => u.Email == super[unitId - 2].Email);
                availableUnitAdminUsers.Remove(user);
                return user.Id;
            })
            .RuleFor(u => u.CreatedDate, f => f.Date.Past(YEARS_TO_GO_BACK_FOR_CREATED_DATE))
            .UseDateTimeReference(DateTime.Parse(DATETIMEREF));

        var units = Enumerable.Range(1, userWithUnitAdminRoles.Count)
            .Select(u => SeedRow(unitFaker, u))
            .ToList();

        return units;
    }

    private List<UnitFollow> GenerateUnitFollows(List<Student> students, List<UniversityUnit> universityUnits)
    {
        var unitFollowId = 1;

        HashSet<(int, int)> usedPair = [];

        var unitFollowFaker = new Faker<UnitFollow>(LOCALE)
            .RuleFor(uf => uf.Id, f => unitFollowId++)
            .RuleFor(uf => uf.StudentId, f => f.PickRandom(students).Id)
            .RuleFor(uf => uf.UniversityUnitId, (f, uf) => 
            {
                int maxAttempts = universityUnits.Count; // Adjust as needed
                int attempts = 0;
                var unitId = f.PickRandom(universityUnits).Id;

                while (usedPair.Contains((uf.StudentId, unitId)) && attempts < maxAttempts)
                {
                    unitId = f.PickRandom(universityUnits).Id;
                    attempts++;
                }

                if (attempts >= maxAttempts)
                {
                    // Retry limit reached, pick a different student
                    uf.StudentId = f.PickRandom(students).Id;
                    return f.PickRandom(universityUnits).Id; // Try again with new student
                }

                return unitId;
            })
            .RuleFor(uf => uf.IsFollowed, f => true)
            .RuleFor(uf => uf.FollowedDate, (f, uf) =>
            {
                var unitCreatedDate = universityUnits.First(u => u.Id == uf.UniversityUnitId).CreatedDate;
                return f.Date.Between(unitCreatedDate, unitCreatedDate.AddYears(YEARS_TO_GO_BACK_FOR_CREATED_DATE));
            })
            .UseDateTimeReference(DateTime.Parse(DATETIMEREF));


        var amount = 1000;
        var unitFollows = Enumerable.Range(1, amount)
            .Select(uf => SeedRow(unitFollowFaker, uf))
            .ToList();

        return unitFollows;
    }

    public List<Event> GenerateEvents(
        int amount,
        IEnumerable<UniversityUnit> universityUnits    
    )
    {
        var eventId = 1;
        var currUnitId = 0;
        var currEventId = 0;
        Dictionary<int, List<Event>> usedEvents = [];
        amount = super.SelectMany(s => s.Events).Count();

        UnitWithEvent currUnit = null;
        EventStructure currEvent = null;
        UniversityUnit? currUnitNormal = null;
        bool isFirstTime = true;

        var eventFaker = new Faker<Event>(LOCALE)
            .RuleFor(e => e.Id, f => eventId++)
            .RuleFor(e => e.UniversityUnitId, f =>
            {
                if (isFirstTime)
                {
                    currUnitNormal = universityUnits.ElementAt(currUnitId);
                    currUnit = super.First(u => u.Name == currUnitNormal.Name);
                    isFirstTime = false;
                }
                else
                {
                    if (currEventId == currUnit.Events.Count)
                    {
                        // reset everything
                        currUnitId++;
                        currEventId = 0;

                        if (currUnitId == universityUnits.Count())
                        {
                            currUnitId = 0;
                            currUnitNormal = universityUnits.ElementAt(currUnitId);
                            currUnit = super.First(u => u.Name == currUnitNormal.Name);
                        }
                        
                        currUnitNormal = universityUnits.ElementAt(currUnitId);
                        currUnit = super.First(u => u.Name == currUnitNormal.Name);
                    }
                }

                return currUnitNormal!.Id;
            })
            .RuleFor(e => e.Title, (f, e) =>
            {
                currEvent = currUnit!.Events[currEventId];

                var title = currEvent.Title;
                return title;
            })
            .RuleFor(e => e.Description, (f, e) =>
            {
                currEvent = currUnit!.Events[currEventId];

                return currEvent.Description;
            })
            .RuleFor(e => e.StartDate, f => f.Date.Between(f.Date.Past(2), f.Date.Future(0).AddMonths(3)))
            .RuleFor(e => e.EndDate, (f, e) => f.Date.Between(e.StartDate, e.StartDate.AddMonths(1)))
            .RuleFor(e => e.Location, (f, e) =>
            {
                currEvent = currUnit!.Events[currEventId];

                return currEvent.Location;
            })
            .RuleFor(e => e.IsPublished, f => f.Random.Bool())
            .RuleFor(e => e.PublishedDate, (f, e) => e.IsPublished ? f.Date.Between(e.StartDate.AddMonths(-2), e.StartDate.AddDays(-1)) : null)
            .RuleFor(e => e.FormUrl, f => "https://forms.gle/HkCD86Gc9UmTTZLP9")
            .RuleFor(e => e.Type, (f, e) =>
            {
                currEvent = currUnit!.Events[currEventId];

                currEventId++; 

                return Enum.Parse<EventType>(currEvent.Type);
            })
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
