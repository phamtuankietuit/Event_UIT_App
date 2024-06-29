namespace UITEventAPI.Application.Infrastructure.Data.Seeder;

public class EventStructure
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string Location { get; set; }
    public string Type { get; set; }
}


public class UnitWithEvent
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string FacebookUrl { get; set; }
    public string Email { get; set; }
    public string AvatarUrl { get; set; }
    public List<EventStructure> Events { get; set; }
}

public static class Data
{


    public static readonly List<UnitWithEvent> data = [
        new() {
            Name = "Hoạt động Đoàn Hội - Hệ thống Thông tin",
            Description = @"Fanpage chính thức cho các hoạt động, sự kiện do Đoàn Khoa - Liên chi Hội HTTT tổ chức.",
            FacebookUrl = "https://www.facebook.com/DoanHoiHTTT",
            Email = "httt.doanhoi@gmail.com",
            AvatarUrl = "https://tinyurl.com/dhhttt123",
            Events = [
                new()  {
                    Title = @"🌟 SEMINAR KHOA HTTT | KHÁM PHÁ CƠ HỘI HỌC TẬP VÀ PHÁT TRIỂN 🌟",
                    Description = @"❓ Bạn muốn tìm hiểu về cơ hội trao đổi sinh viên quốc tế ngành Hệ thống Thông tin ?
❓ Bạn có thắc mắc về chương trình liên thông từ đại học lên thạc sĩ ngành Hệ thống Thông tin?
❓ Bạn quan tâm đến cuộc thi học thuật AISC’24 nhưng chưa rõ về nội dung cuộc thi?
🔉 Đừng lo, hãy đến với seminar do Khoa HTTT tổ chức sẽ giúp bạn giải đáp mọi thắc mắc và định hướng rõ ràng hơn!
--------------------------
🎯 NỘI DUNG CHÍNH
⭐ GIỚI THIỆU THE IS:LINK NETWORK – MẠNG LƯỚI TRAO ĐỔI SINH VIÊN HỆ THỐNG THÔNG TIN
- Cơ hội trao đổi sinh viên quốc tế ngành HTTT
- Hợp tác giữa các trường đại học hàng đầu
- Mở rộng mạng lưới quan hệ và trải nghiệm học tập toàn cầu
⭐ GIỚI THIỆU CHƯƠNG TRÌNH LIÊN THÔNG (BS-MS) TỪ ĐẠI HỌC LÊN THẠC SĨ NGÀNH HỆ THỐNG THÔNG TIN
- Lộ trình học tập tích hợp từ đại học lên thạc sĩ
- Những quyền lợi và lợi ích của chương trình
- Hỗ trợ và tư vấn về chương trình
⭐ GIỚI THIỆU CUỘC THI HỌC THUẬT KHOA HỆ THỐNG THÔNG TIN – ADVANCED INFORMATION SYSTEMS CONTEST 2024 – AISC’24
- Cập nhật các thông tin quan trọng về cuộc thi AISC’24
- Khám phá những phần thưởng giá trị và cơ hội kết nối với các đội thi xuất sắc
- Hướng dẫn và định hướng để chuẩn bị tốt nhất cho cuộc thi
--------------------------
🌟 THÔNG TIN VỀ CHƯƠNG TRÌNH
💦 Trình bày và giải đáp: TS. Cao Thị Nhạn – Phụ trách Khoa – Phó Trưởng Khoa Hệ thống Thông tin
💖 Đèn đỏ đèn xanh. Nhanh tay kẻo lỡ! Hẹn gặp bạn tại buổi seminar nhé!
Xem thêm thông tin tại: https://httt.uit.edu.vn/seminar-khoa-he-thong-thong-tin.../
#Seminar_HTTT #IS_UIT",
                    Location = "Phòng E4.1, Tòa E, Trường Đại học Công nghệ Thông tin – ĐHQG-HCM",
                    Type = "Seminar", // "Training", "Workshop", "Seminar", "Webinar", "Conference", "Other"
                },
                new()  {
                    Title = @"🔴 CHƯƠNG TRÌNH “THU HỒI PIN CŨ – BẢO VỆ TRÁI ĐẤT XANH” LẦN 3 CHÍNH THỨC ĐI VÀO HOẠT ĐỘNG",
                    Description = @"Tiếp tục hành trình lan tỏa lối sống xanh và khuyến khích người dân xử lý pin cũ đúng cách, UIT, Hội Sinh viên Trường và Cocoon đã tiếp tục đồng hành với nhau trong chương trình “Thu hồi pin cũ - Bảo vệ trái đất xanh” 2024 với hơn 90 điểm thu hồi pin trải rộng trên 5 tỉnh thành: Hà Nội, Huế, Đà Nẵng, Hồ Chí Minh và Cần Thơ. 
Vẫn như các năm trước, chương trình sẽ tiếp nhận pin tiểu và các loại pin có kích thước từ pin tiểu trở lên (pin AA, pin AAA,... ). Mỗi khách hàng sẽ nhận được 1 quà tặng (Son Dưỡng Dầu Dừa Bến Tre phiên bản giới hạn trị giá 32.000đ) khi mang pin đã qua sử dụng đến điểm thu hồi.
---------------------
CÁCH THỨC ĐỔI PIN NHẬN QUÀ
· Bước 1: Chuẩn bị tối thiểu 10 viên pin đã qua sử dụng, mang đến điểm thu hồi pin tại trước phòng Công tác Sinh viên - A101. 
· Bước 2: Quét mã QR trên nắp thùng, nhập thông tin hoặc làm theo hướng dẫn của người phụ trách tại điểm thu hồi để nhận quà.
*Lưu ý:
ÁP DỤNG 1 QUÀ TẶNG/1 LƯỢT ĐỔI/1 KHÁCH HÀNG
Quà tặng áp dụng với pin tiểu trở lên (pin AA, pin AAA,...)
Quà tặng không quy đổi thành tiền mặt.
Quà tặng có số lượng giới hạn, sẽ hết sớm hơn dự kiến ở mỗi địa điểm.
---------------------
Những viên pin đã qua sử dụng nếu không được xử lý đúng cách sẽ để lại những tác động khôn lường, đe dọa đến môi trường tự nhiên và sức khỏe con người. Hãy cùng Cocoon và UIT góp phần bảo vệ hệ sinh thái tự nhiên bằng cách thu hồi pin cũ, gửi cho các đơn vị xử lý chuyên môn để chúng trở lại với môi trường trong một hình hài mới, có ích và thân thiện hơn.
#UIT #Cocoon",
                    Location = "phòng Công tác Sinh viên - A101",
                    Type = "Other", // "Training", "Workshop", "Seminar", "Webinar", "Conference", "Other"
                },
                new()  {
                    Title = @"[NẮNG HẠ 2024 | ĐĂNG KÝ THI THỬ TOEIC]",
                    Description = @"[NẮNG HẠ 2024 | ĐĂNG KÝ THI THỬ TOEIC]
🔗 Link đăng ký: https://tinyurl.com/DK-ThithuTOEIC-HTTT
🤔 Bạn đang ôn luyện TOEIC hăng say nhưng chưa có cơ hội thử sức với đề thi chuẩn? Bạn muốn cọ xát kiến thức và làm quen với áp lực phòng thi thực tế?
🌟 Tin vui cho các bạn đây!
🤝 Nhà Hệ thống Thông tin chúng mình hợp tác cùng Trung tâm luyện thi TOEIC - Kim Nhung TOEIC tổ chức thi thử TOEIC cho tất cả các bạn sinh viên tại các Trường Đại học trên địa bàn TP.HCM vào Thứ Tư ngày 15/05/2024.
🤗 Đặc biệt hơn nữa:
Toàn bộ số tiền thu được từ hoạt động thi thử sẽ được dùng để gây quỹ cho chương trình tình nguyện “Nắng Hạ”.
💠 Tham gia thi thử, bạn không chỉ có cơ hội đánh giá năng lực tiếng Anh của bản thân mà còn góp phần mang đến những điều tốt đẹp cho cộng đồng!
⏰ Số lượng có hạn, nhanh tay đăng ký tham gia ngay nhé!
------------------------------------ 
THÔNG TIN THI THỬ TOEIC
🔗 Link đăng ký: https://tinyurl.com/DK-ThithuTOEIC-HTTT
⏰ Thời gian đăng ký: từ 06/05 đến hết ngày 11/05/2024.
💵 Lệ phí thi: 20.000 VNĐ.
💠 Hình thức bài thi thử TOEIC tương tự với bài thi TOEIC 2 kỹ năng Nghe & Đọc.
📍 Địa điểm thi: Trường Đại học Công nghệ Thông tin - ĐHQG TP.HCM (địa điểm chi tiết sẽ được BTC thông báo qua email đã đăng ký)
🗓️ Ngày thi: 15/05/2024 (Thứ Tư), 2 ca thi:
Ca sáng: 8h30 - 11h00
Ca chiều: 13h30 - 16h00
💯 Thời gian công bố kết quả thi và cấp giấy chứng nhận dự kiến 01 tuần kể từ sau ngày thi thử.
Cơ cấu giải thưởng:
🥇1 giải Nhất: 400.000 VNĐ
🥈1 giải Nhì: 300.000 VNĐ
🥉1 giải Ba: 200.000 VNĐ
🏅2 giải Khuyến khích: 100.000 VNĐ",
                    Location = "Trường Đại học Công nghệ Thông tin - ĐHQG TP.HCM (địa điểm chi tiết sẽ được BTC thông báo qua email đã đăng ký)",
                    Type = "Other", // "Training", "Workshop", "Seminar", "Webinar", "Conference", "Other"
                },
                new()  {
                    Title = @"🎩 [NẮNG HẠ 2024 | VƯƠNG QUỐC IS - CÔNG THỨC BỊ ĐÁNH CẮP] 🎩",
                    Description = @"🔍 “Bạn đã từng nghe về những câu chuyện kỳ diệu của vương quốc IS chưa? 
Nếu chưa, thì để Nắng Hạ kể cho bạn nghe nha”
📜 Trong vương quốc IS xa xôi, người dân họ thường truyền tai nhau truyền thuyết về một pháp sư huyền thoại, người có khả năng tạo ra những loại thuốc thần kỳ mang lại sức mạnh và sự bất tử cho người dùng. Tuy nhiên, mọi thứ đã bị đảo lộn khi có kẻ tham lam đánh cắp công thức này, đe dọa biến thuốc thành sự hủy diệt.
🎭 Vào Chủ nhật, ngày 12/5/2024, các bạn sẽ có cơ hội trở thành những thám tử tài ba, đối mặt những thử thách đầy cam go để giành lại công thức và ngăn chặn thảm họa. Đừng bỏ lỡ cơ hội lan tỏa yêu thương đến “Nắng Hạ” và tận hưởng một ngày đầy hứng khởi cùng chương trình chạy trạm 'Vương quốc IS - Công thức bị đánh cắp'!
🌞 Hãy tìm cho mình những người đồng đội và nhanh tay điền form dưới đây để cùng Nắng Hạ “phá án” và tìm ra cuốn bí kíp giải cứu Vương quốc IS nhé!
------------------------------------
THÔNG TIN CHƯƠNG TRÌNH
🧍 Đối tượng: Sinh viên các trường Đại học trên địa bàn TP. HCM.
⏰ Thời gian tổ chức: 7h00, chủ nhật, 12/5/2024.
⌛ Thời gian đăng ký: từ 04/5/2024 đến 10/5/2024.
📍 Địa điểm: Khu đô thị ĐHQG-HCM.
🌟 Hình thức: Chạy trạm.
🏍️ Phương tiện: Tự do.
HÌNH THỨC ĐĂNG KÝ
🔍 Có 2 hình thức đăng ký:
- Đăng ký trực tiếp tại Sảnh C - Trường Đại học Công nghệ Thông tin, ĐHQG-HCM.
- Đăng ký qua form: https://forms.gle/SHKeMCfX84uNn4kw6
💸 Lệ phí:
- Đăng ký theo đội: 140.000 VNĐ/đội 6 sinh viên.
- Đăng ký cá nhân: 25.000 VNĐ/sinh viên.
❗ Trong trường hợp một đội không đủ số lượng thành viên theo yêu cầu, các bạn vẫn có thể đăng ký cá nhân, BTC sẽ giúp các bạn có nguyện vọng chung đội thành một đội và tìm thêm những đồng đội “đỉnh của chóp”.
CƠ CẤU GIẢI THƯỞNG
🥇 Giải nhất: 250.000 VNĐ.
🥈 Giải nhì: 200.000 VNĐ.
🥉 Giải ba: 150.000 VNĐ.
------------------------------------
MỌI THÔNG TIN VỀ CHƯƠNG TRÌNH “NẮNG HẠ 2024” VUI LÒNG LIÊN HỆ: 
💠 Nguyễn Thị Dung: 0346925317 (Trưởng Ban tổ chức) 
🔹 Lê Nguyễn Diễm Quyên: 0866658762 (Phó Ban tổ chức)  
🔹 Phạm Nguyễn Hà Vy: 0939199946 (Phó Ban tổ chức)
Hoặc:
🌎 Fanpage Đoàn - Hội khoa Hệ thống Thông Tin: https://www.facebook.com/DoanHoiHTTT 
📧 Email: httt.doanhoi@gmail.com
#HTTT #ISVOLUNTEER2024 #NangHa",
                    Location = "Sảnh C - Trường Đại học Công nghệ Thông tin, ĐHQG-HCM",
                    Type = "Other", // "Training", "Workshop", "Seminar", "Webinar", "Conference", "Other"
                },
                new()  {
                    Title = @"🔔 HỘI NGHỊ SINH VIÊN KHOA HỆ THỐNG THÔNG TIN - NĂM HỌC 2023 - 2024 🔔",
                    Description = @"Xem thêm thông tin tại 👉 https://httt.uit.edu.vn/hoi-nghi-sinh-vien-khoa-he-thong.../
🌟 Hội nghị Sinh viên là sự kiện thường niên được tổ chức với mục đích tạo ra một không gian mở để sinh viên có thể gặp gỡ, trao đổi và đưa ra các ý kiến, đề xuất trực tiếp với ban lãnh đạo nhà trường.
🌟 Đây là cơ hội để mỗi sinh viên được lắng nghe, thảo luận và đóng góp ý kiến trực tiếp vào các vấn đề học tập, cơ sở vật chất và nhiều mặt khác của đời sống sinh viên.
👭 Tại hội nghị này, chúng ta sẽ cùng nhau trao đổi về:
- Công tác đào tạo: thời gian, chương trình, nội dung, phương pháp học tập và giảng dạy.
- Hỗ trợ từ cố vấn học tập.
- Cơ sở vật chất phục vụ cho sinh viên.
- Các phong trào và hoạt động chính trị xã hội.
- Công tác bồi dưỡng Đoàn viên, quản lý sinh viên, phát triển Đảng.
- Các thủ tục hành chính, các chính sách mới và quy định mới nhằm nâng cao chất lượng giáo dục.
- Các vấn đề khác mà sinh viên quan tâm.
📌 Thành phần tham dự bao gồm:
- Đại diện Ban Giám hiệu nhà trường 
- Ban chủ nhiệm Khoa Hệ thống Thông tin 
- Bí thư Đoàn Khoa 
- Cố vấn học tập của Khoa 
- Đại diện Thường trực Đoàn trường 
- Phòng Dữ liệu và CNTT 
- Ban quản lý cơ sở 
- Đại diện Thư viện 
- Đại diện Bộ môn Toán 
- Đại diện Lãnh đạo Phòng Đào tạo Đại học
- Đại diện Lãnh đạo và chuyên viên Phòng Công tác sinh viên
- Lãnh đạo Văn phòng Các chương trình Đặc biệt
- Đại diện lãnh đạo Trung tâm ngoại ngữ
- Toàn thể sinh viên khoa HTTT
🗓 Thời gian: 15h00 - 16h20, thứ Ba ngày 07 tháng 05 năm 2024
🏠 Địa điểm: Hội trường E, Trường ĐH Công nghệ Thông tin
🔗 Sinh viên quan tâm đến Hội nghị vui lòng đăng ký tại link sau: https://forms.gle/9hCMfCv8gm5zLHu97
📘 Hãy nắm bắt cơ hội này để cùng xây dựng môi trường học tập tốt hơn!
Các bạn sinh viên ơi, hãy tham gia để góp phần làm nên một khoa Hệ thống Thông tin ngày càng vững mạnh. 🔥🔥🔥",
                    Location = "Hội trường E, Trường ĐH Công nghệ Thông tin",
                    Type = "Conference", // "Training", "Workshop", "Seminar", "Webinar", "Conference", "Other"
                },
            ]
        },
        new() {
            Name = "Khoa Hệ Thống Thông Tin - Trường ĐH Công nghệ Thông tin",
            Description = @"Khoa Hệ Thống Thông Tin - Trường ĐH Công nghệ Thông tin",
            FacebookUrl = "https://www.facebook.com/uit.khoahttt",
            Email = "info.httt@uit.edu.vn",
            AvatarUrl = "https://tinyurl.com/khoahttt",
            Events = [
                new()  {
                    Title = @"🌟 SEMINAR ANALYSED TECHNIQUES IN ECONOMETRICS: FDI ANALYSIS IN VIETNAM 🌟",
                    Description = @"🎓 Bạn có niềm đam mê với kinh tế lượng và mong muốn nắm vững những kỹ thuật phân tích? Bạn đang tìm kiếm cơ hội để bắt đầu hành trình nghiên cứu khoa học của mình? Đừng bỏ lỡ cơ hội tuyệt vời này!
💡 Nhằm hỗ trợ sinh viên trong việc nắm bắt kiến thức và kỹ năng cần thiết cho nghiên cứu khoa học, Khoa Hệ thống Thông tin tổ chức chuỗi seminar hỗ trợ nghiên cứu khoa học sinh viên. Tiếp nối sự thành công của seminar #1, Khoa Hệ thống Thông tin tổ chức seminar #2 với chủ đề Analysed Techniques in Econometrics: FDI Analysis in Vietnam hứa hẹn sẽ mang đến những thông tin thiết thực và bổ ích.
🌍 Trong bối cảnh nền kinh tế toàn cầu hóa hiện nay, việc hiểu rõ và phân tích dòng FDI là chìa khóa giúp bạn có cái nhìn sâu sắc về sự phát triển kinh tế của Việt Nam. Đây là cơ hội để bạn nắm bắt những xu hướng mới nhất và áp dụng các kỹ thuật phân tích vào nghiên cứu thực tế. Hãy đăng ký tham gia ngay để không bỏ lỡ!
🔍 Thông tin chi tiết chương trình:
📅 Thời gian: 8h00 – 11h00 sáng thứ Ba, ngày 11 tháng 06 năm 2024
📍 Địa điểm: Phòng E4.1, Tòa nhà E, Trường ĐH Công nghệ Thông tin ĐHQG-HCM
👨‍🏫 Giảng viên hướng dẫn: TS. Trần Văn Hải Triều – Giảng viên Bộ môn TMĐT, Khoa Hệ thống Thông tin
📚 Nội dung chính:
1. Phân tích hồi quy (Regression Analysis)
2. Phát triển giả thuyết nghiên cứu (How to Develop Research Hypotheses)
3. Dự báo dữ liệu chuỗi thời gian (Forecasting Time Series Data)
4. Phân tích FDI tại Việt Nam (Case Study: FDI Analysis in Vietnam)
📌 Đăng ký tham gia tại đây: https://forms.gle/TY6PTL3P1LiA981c6
🌟 Đừng bỏ lỡ cơ hội để nâng cao kỹ năng và mở rộng kiến thức của bạn. Tham gia seminar và bắt đầu hành trình nghiên cứu khoa học của bạn ngay hôm nay! 
Xem thêm thông tin tại: https://httt.uit.edu.vn/seminar-ho-tro-nckh-sinh-vien.../",
                    Location = "Phòng E4.1, Tòa nhà E, Trường ĐH Công nghệ Thông tin ĐHQG-HCM",
                    Type = "Seminar", // "Training", "Workshop", "Seminar", "Webinar", "Conference", "Other"
                },
                new()  {
                    Title = @"📊 SEMINAR PHÂN TÍCH DỮ LIỆU VÀ THỰC NGHIỆM TỪ ZERO TỚI HERO: BÀI TOÁN DỰ BÁO GIÁ CHỨNG KHOÁN",
                    Description = @"🎓 Bạn đam mê phân tích dữ liệu? Bạn muốn tham gia các đề tài nghiên cứu khoa học nhưng không biết bắt đầu từ đâu? Đây chính là cơ hội mà bạn không thể bỏ lỡ!
💡 Nhằm hỗ trợ sinh viên tìm hiểu quá trình và bắt đầu tham gia nghiên cứu khoa học, Khoa Hệ thống Thông tin tổ chức chuỗi seminar để trang bị kiến thức và kỹ năng cần thiết cho các bạn sinh viên. Hãy tham gia seminar đầu tiên với những thông tin bổ ích!
Thông tin chi tiết:
📅 Thời gian: 8h00 sáng thứ Ba, ngày 04 tháng 06 năm 2024
📍 Địa điểm: Phòng E10.1, Tòa nhà E, Trường ĐH Công nghệ Thông tin ĐHQG-HCM
👨‍🏫 Giảng viên hướng dẫn: TS. Nguyễn Thanh Bình – Trưởng phòng thí nghiệm HTTT – Trưởng Bộ môn HTTT Quản lý
🔍 Nội dung seminar:
1. Giới thiệu:
- Phân tích dữ liệu
- Quy trình phân tích dữ liệu
- Công cụ phân tích
2. Bài toán dự báo giá chứng khoán:
- Giới thiệu hệ thống
- Chi tiết xử lý từng module của hệ thống
- Bài toán dữ liệu chuỗi thời gian
- Các thuật toán sử dụng trong dự báo
📌 Link đăng ký tham gia: https://forms.gle/KSWy6re37URaRFNb7
🚀 Đừng bỏ lỡ cơ hội học hỏi và nâng cao kỹ năng của bạn! Đây là dịp tuyệt vời để bạn trang bị những kiến thức thực tiễn và bắt đầu cho quá trình tham gia nghiên cứu khoa học.",
                    Location = "Phòng E10.1, Tòa nhà E, Trường ĐH Công nghệ Thông tin ĐHQG-HCM",
                    Type = "Seminar", // "Training", "Workshop", "Seminar", "Webinar", "Conference", "Other"
                },
                new()  {
                    Title = @"📝 TƯ VẤN TUYỂN SINH CHƯƠNG TRÌNH ĐÀO TẠO TRÌNH ĐỘ THẠC SĨ CỦA TRƯỜNG ĐẠI HỌC CÔNG NGHỆ THÔNG TIN 📝 ",
                    Description = @"🌟 Bạn muốn tìm hiểu về các ngành đào tạo thạc sĩ của Trường ĐH Công nghệ Thông tin?
🌟 Bạn muốn tìm hiểu về tuyển sinh trình độ thạc sĩ năm 2024 chỉ xét hồ sơ, không thi tuyển
🌟 Bạn muốn biết xét tuyển và tuyển thẳng khác nhau thế nào?
🌟 Bạn muốn biết xét tuyển chỉ dựa vào đánh giá hồ sơ và xét tuyển dựa trên đánh giá hồ sơ kết hợp phỏng vấn thế nào?
🌟 Bạn muốn biết về học phí, và các chế độ học bổng, hỗ trợ NCKH?
📅 Mời các bạn đến tham dự buổi tư vấn tuyển sinh chương trình đào tạo trình độ thạc sĩ của Trường ĐH Công nghệ Thông tin: 
🕥 Thời gian: 10h30 - 11h30, Thứ sáu ngày 10 tháng 5 năm 2024.
📍 Địa điểm: Phòng E1.1 - Trường ĐH Công nghệ Thông tin, Khu phố 6, Phường Linh Trung, TP. Thủ Đức, TP.HCM.
🎙 Nội dung: PGS. TS. Lê Đình Duy - Trưởng phòng Đào tạo Sau Đại học và Khoa học Công nghệ sẽ tư vấn và giải đáp tất cả thắc mắc của các bạn. 
🔗 Đăng ký ngay tại: https://bom.so/kHTUfF
💻 Trường hợp các bạn không tham gia offline, sau khi đăng ký Phòng sẽ gửi link tham gia online qua email đăng ký.
ℹ️ Thông tin tuyển sinh chi tiết xem tại: https://sdh.uit.edu.vn/.../thong-bao-tuyen-sinh-chuong...
📞 Liên hệ Cô Tuyết Minh (0918302372) để được tư vấn thêm.",
                    Location = "Phòng E1.1 - Trường ĐH Công nghệ Thông tin, Khu phố 6, Phường Linh Trung, TP. Thủ Đức, TP.HCM.",
                    Type = "Other", // "Training", "Workshop", "Seminar", "Webinar", "Conference", "Other"
                },
                new()  {
                    Title = @"🌟 ĐĂNG KÝ THAM GIA ĐỘI TUYỂN BÓNG CHUYỀN NAM NỮ KHOA HỆ THỐNG THÔNG TIN THAM GIA GIẢI UIT SPORT 2024🌟",
                    Description = @"🏐 Bạn yêu thích bóng chuyền? 
🏐 Bạn sẵn sàng thể hiện tinh thần thể thao và khả năng chơi bóng chuyền của mình? 
Đây là cơ hội để bạn tỏa sáng và góp phần nâng cao tinh thần thể thao trong Nhà trường!  
📌 Với mục tiêu thúc đẩy phong trào tham gia hoạt động thể dục, thể thao. Nâng cao sức khỏe trong học tập và rèn luyện cho sinh viên. Phát huy sức mạnh hệ thống trong công tác giáo dục thể chất. 👉 👉 👉  Khoa Hệ thống Thông tin tuyển sinh viên tham gia vào đội tuyển bóng chuyền Nam/Nữ của Khoa để tham gia hội thao UIT Sport 2024.
👥 Đối tượng tham gia: Sinh viên thuộc Khoa HTTT, hệ đào tạo chính quy văn bằng 1 của Trường và sinh viên chương trình liên kết. Đảm bảo sức khỏe tốt để tham gia thi đấu. Có Bảo hiểm y tế và Bảo hiểm tai nạn còn thời hạn.
⏰ Thời gian thi đấu: Tháng 5/2024 tại sân bóng chuyền Trường Đại học Công nghệ Thông tin – ĐHQG-HCM.
💰 Lệ phí tham gia: Khoa HTTT hỗ trợ 100% lệ phí tham gia.
📅 Thời gian đăng ký: Từ nay đến hết ngày 02/05/2024.
🔗 Đăng ký tham gia tại: https://forms.gle/b6BcSkCTiKWxvqgv8
🎯 Đừng bỏ lỡ cơ hội này để trải nghiệm, rèn luyện và chiến thắng! Đăng ký ngay để trở thành một phần của đội tuyển bóng chuyền khoa Hệ thống Thông tin!
👉 Xem thêm thông tin tại: https://httt.uit.edu.vn/dang-ky-tham-gia-thi-dau-giai.../",
                    Location = "Sân bóng chuyền Trường Đại học Công nghệ Thông tin – ĐHQG-HCM",
                    Type = "Other", // "Training", "Workshop", "Seminar", "Webinar", "Conference", "Other"
                },
                new()  {
                    Title = @"🌟 Hãy đăng ký tham Gia Seminar về Microsoft Dynamics và Khám phá những quyền lợi đặc biệt 🌟 ",
                    Description = @"🧷 Đăng ký tham gia tại: https://forms.gle/aytHNGhdTprxGN1o7
Đến với seminar lần này, ngoài việc khám phá cơ hội nghề nghiệp với Microsoft Dynamics, bạn sẽ được: 
📘 Kiến thức chuyên sâu: Hiểu rõ về các sản phẩm của Microsoft Dynamics như Finance & Operations, Business Central và Power Platform.
📘 Kinh nghiệm thực tế: Nghe chia sẻ từ các chuyên gia hàng đầu và hiểu biết sâu về thị trường ERP toàn cầu.
🌐 Mở rộng mạng lưới, tiếp xúc và trao đổi với các chuyên gia trong ngành.
🎁 Và đặc biệt là những phần quà hấp dẫn từ BTC, cùng với điểm rèn luyện đối với các bạn sinh viên UIT. 
 ---------------------------------------
📝 THÔNG TIN VỀ CHƯƠNG TRÌNH
👨‍🏫 Diễn giả: Anh Nguyễn Đức Huy Vũ - Giám Đốc Trung Tâm Dịch Vụ Phần Mềm Doanh Nghiệp Microsoft Dynamics (FPT Software)
📆 Thời gian: 9h00 - 11h00, Thứ Hai, ngày 22/04/2024
🏢 Địa điểm: Hội trường E, Trường Đại học Công nghệ Thông Tin
🔹 Đối tượng tham gia: Giảng viên, sinh viên, và mọi người quan tâm
💬 Hãy đăng ký tham gia và chia sẻ sự kiện này với bạn bè để không ai bỏ lỡ cơ hội tuyệt vời này bạn nhé!",
                    Location = "Hội trường E, Trường Đại học Công nghệ Thông Tin",
                    Type = "Seminar", // "Training", "Workshop", "Seminar", "Webinar", "Conference", "Other"
                },
            ]
        },
        new() {
            Name = "Mạng máy tính và Truyền thông",
            Description = @"Khoa Mạng máy tính và Truyền thông, Trường Đại học Công nghệ Thông tin - ĐHQG-HCM",
            FacebookUrl = "https://www.facebook.com/uit.nc",
            Email = "doanthanhnien@suctremmt.com",
            AvatarUrl = "https://tinyurl.com/khoammttt",
            Events = [
                new()  {
                    Title = @"ĐĂNG KÝ THAM GIA & “REVIEW” CUỘC THI - NHẬN QUÀ MAY MẮN TỪ CODE TOUR",
                    Description = @"👉 Đăng ký ngay: https://bit.ly/4bGcYvu 
Trong không khí sôi nổi của vòng loại Code Challenge #2 sắp diễn ra, Code Tour 2024 dành tặng riêng cho sinh viên UIT một hoạt động đặc biệt “Đăng ký và chia sẻ - Nhận ngay quà may mắn” với quà tặng độc - lạ nhưng cũng tiện dụng vô cùng.
Quà tặng: 06 sinh viên tham gia hợp lệ sẽ nhận được 01 phần quà ngẫu nhiên từ Bộ sưu tập Code Tour, trong đó:
🤩 01 sinh viên có chia sẻ truyền cảm hứng nhất: Chuột bluetooth Logitech trị giá 500,000 đồng.
👍 05 sinh viên may mắn nhất: Lót chuột chống mỏi tay hoặc Bình giữ nhiệt trị giá 250,000 đồng.
📝 Note ngay 03 bước tham gia để có cơ hội nhận giải thưởng nhé:
Bước 1: Đăng ký tham gia Code Challenge #2 và #3 tại https://bit.ly/4bGcYvu 
Bước 2: Comment username + MSSV của bạn dưới bài viết này
Bước 3: Share bài viết về trang cá nhân của bạn ở chế độ công khai. Caption bao gồm: đôi dòng chia sẻ về lý do nên tham gia Code Tour + hashtag #CodeTour2024
⏰ Thời gian tham gia: Từ ngày 13/06 đến hết ngày 20/06/2024. Kết quả sẽ được Trường thông báo trực tiếp dưới phần comment của bài viết này vào ngày 26/06/2024.
Vòng thi Code Challenge #2 vẫn đang mở đơn mời gọi các anh em chí code cùng tham gia, bạn hãy ĐĂNG KÝ NGAY để cùng BTC ôn tập và chuẩn bị thật tốt cho kỳ thi nha 💪
---
CODE TOUR 2024 - Code - Connect - Challenge
Website: https://codetour.org/ 
Group trao đổi: https://www.facebook.com/groups/codetoconnect 
Fanpage: https://www.facebook.com/LifeAtVNG 
#CodeTour #CodeConnectChallenge #Giaidaulaptrinh #LifeatVNG",
                    Location = "Online",
                    Type = "Other", // "Training", "Workshop", "Seminar", "Webinar", "Conference", "Other"
                },
                new()  {
                    Title = @"BHT ĐOÀN KHOA MMT&TT | NHẮC NHỞ ÔN TẬP LẬP TRÌNH HƯỚNG ĐỐI TƯỢNG",
                    Description = @"💡 Đã bao giờ bạn tự hỏi “đóng gói, kế thừa, đa hình, trừu tượng” là gì mà lại khiến cho chúng ta phải say đắm nhiều như vậy chưa?
❓ Nếu câu là trả lời là chưa, vậy thì còn chần chừ gì nữa mà tham gia cùng với Ban Học tập chúng mình nhé!
✨ Tại đây, chúng mình hứa hẹn sẽ mang đến nhiều điều bất ngờ dành cho tất cả các bạn, cũng như giải đáp những vấn đề mà các bạn đang gặp phải. Từ đó, chúng mình hy vọng có thể giúp các bạn có nền tảng kiến thức thật vững vàng và sẵn sàng chinh phục điểm 10 “âu âu pi” sắp tới!
😻 Nghe hấp dẫn quá phải không nào? Thế thì càng phải lưu lại thông tin của buổi ôn tập này đấy nhé!
Thông tin chi tiết:
🕐 Thời gian: 𝟏𝟑𝐡𝟑𝟎 - 𝐓𝐡𝐮̛́ 𝟐, ngày 𝟏𝟎/𝟎𝟔/𝟐𝟎𝟐𝟒
⛳ Địa điểm: Phòng 𝐁𝟏.𝟐𝟎
❗ Lưu ý: Đừng quên trang bị đầy đủ dụng cụ học tập để có một buổi trao đổi kiến thức thật hiệu quả nhé!
💌 Nếu có bất kỳ thắc mắc nào, đừng ngần ngại liên hệ ngay với Fanpage Mạng Máy tính và Truyền thông để được bọn mình hỗ trợ nhé! Chúc bạn đạt được kết quả học tập thật tốt trong thời gian sắp tới!
➖➖➖➖➖
#NC #UIT #VNUHCM 
#CTV #BHT #DOANKHOA",
                    Location = "Phòng 𝐁𝟏.𝟐𝟎",
                    Type = "Training", // "Training", "Workshop", "Seminar", "Webinar", "Conference", "Other"
                },
                new()  {
                    Title = @"[SEMINAR | HƯỚNG DẪN ĐĂNG KÝ HỖ TRỢ CÔNG BỐ KHOA HỌC DÀNH CHO SINH VIÊN]",
                    Description = @"Phòng ĐTSĐH&KHCN vừa có thông báo triển khai xét hỗ trợ kinh phí và khen thưởng NCKH sinh viên đợt tháng 6 năm 2024. Quy trình thực hiện như sau:
📍 Bước 1: Sinh viên, học viên cao học, nghiên cứu sinh điền thông tin bài báo khoa học vào form đăng ký: https://forms.gle/xJMzoF151facKuSPA và forward Response Receipt về email của GVHD, các sinh viên trong nhóm, VP Khoa, Phòng CTSV (ctsv@uit.edu.vn), Phòng ĐTĐH (phongdaotaodh@uit.edu.vn), Phòng ĐTSĐH&KHCN (qlkhcn@uit.edu.vn), VPĐB (vpdb@uit.edu.vn) (nếu là SV các chương trình Chất lượng cao, Tài năng, Tiên tiến). Đây được xem như là đơn điện tử để các đơn vị liên quan xử lý. 
📍 Bước 2: Theo từng đợt xét duyệt (tháng 06 và tháng 11 hàng năm), các Khoa sẽ xét duyệt các bài báo khoa học và gửi đề xuất hỗ trợ kinh phí, khen thưởng về P.ĐTSĐH&KHCN
📍 Bước 3: Phòng ĐTSĐH&KHCN phối hợp các đơn vị liên quan khác (Phòng CTSV, Phòng KHTC) để thực hiện theo quy định.
Quy trình xét hỗ trợ kinh phí khen thưởng NCKH SV được thực hiện theo quy định: https://khcn.uit.edu.vn/.../quy-dinh-ve-chinh-sach-ho-tro...
❗ Lưu ý: Đối với Học viên cao học, cần xem Điều 3, mục 2 trong quy định trên.
Phòng ĐTSĐH&KHCN vừa có thông báo triển khai xét hỗ trợ kinh phí và khen thưởng NCKH sinh viên đợt tháng 6 năm 2024.
Để hỗ trợ cho các bạn SV/HVCH trong việc đăng ký, Khoa MMT&TT sẽ tổ chức cuộc họp trực tuyến để hướng dẫn thực hiện các bước đăng ký, thông tin như sau:
⏲️ Thời gian: 10:00 ngày 14/6/2024
💻 Hình thức: trực tuyến qua Google Meet
📧 Link: https://meet.google.com/dqm-orhy-rfi
Mọi thắc mắc, các bạn SV/HVCH liên hệ thầy Khánh Thuật (thuatnk@uit.edu.vn)
Chi tiết xem tại: https://nc.uit.edu.vn/.../thong-bao-tham-du-seminar-huong...
#SEMINAR #NCKH #NC #UIT #VNUHCM",
                    Location = "trực tuyến qua Google Meet: https://meet.google.com/dqm-orhy-rfi",
                    Type = "Seminar", // "Training", "Workshop", "Seminar", "Webinar", "Conference", "Other"
                },
                new()  {
                    Title = @"TUYỂN THÀNH VIÊN | 𝐂𝐋𝐁 𝐖𝐀𝐍𝐍𝐀.𝐖𝟏𝐍 THÔNG BÁO MỞ ĐƠN TUYỂN THÀNH VIÊN 𝐓𝐄𝐀𝐌𝐓 ",
                    Description = @"😍 Bạn là người yêu thích an toàn thông tin và có niềm đam mê đặc biệt với CTF?
🤗 Bạn muốn tìm kiếm những người cùng chí hướng, để cùng nhau nâng cao kỹ năng và vươn xa?
🧑‍💻 Bạn đang tìm kiếm một môi trường năng động, nơi bạn có thể học hỏi và phát triển đam mê?
👉 Vậy thì 𝐓𝐞𝐚𝐦𝐓 đích thị là nơi bạn đang tìm kiếm đó! 𝐓𝐞𝐚𝐦𝐓 (𝐓𝐡𝐞 𝐂𝐲𝐛𝐞𝐫 𝐊𝐧𝐢𝐠𝐡𝐓) mang trong mình nhiệm vụ hướng các bạn sinh viên UIT tới các cuộc thi học thuật về lĩnh vực An toàn thông tin cụ thể là các cuộc thi CTF; nghiên cứu chuyên sâu bảo mật, bug hunting, CVE… Đây là nơi giao lưu, học hỏi giữa những “pháp sư” ở nhiều lĩnh vực khác nhau nhưng đều có một niềm đam mê đặc biệt với CTF nói riêng và An toàn thông tin nói chung.
🚩 Đến với 𝐓𝐞𝐚𝐦𝐓 của CLB 𝐖𝐚𝐧𝐧𝐚.𝐖𝟏𝐧, bạn không chỉ được học hỏi về CTF mà còn được giao lưu, có cơ hội hòa mình vào sân chơi học thuật đầy thú vị. Đồng thời phát triển được nhiều kỹ năng qua sự hướng dẫn nhiệt tình từ thầy cô cũng như các anh, chị và các bạn đồng trang lứa.
𝐓𝐡𝐨̂𝐧𝐠 𝐭𝐢𝐧 𝐭𝐮𝐲𝐞̂̉𝐧 𝐭𝐡𝐚̀𝐧𝐡 𝐯𝐢𝐞̂𝐧:
👉 Tuyển thành viên theo từng mảng
⏰ Thời gian đăng ký: Từ ngày 𝟎𝟔/𝟎𝟔/𝟐𝟎𝟐𝟒 đến hết ngày 𝟏𝟎/𝟎𝟔/𝟐𝟎𝟐𝟒
📌 Link đăng ký: https://forms.gle/p9gbrm4eCjkzagwP9
🙋‍♂️ Đối tượng: Các UITer biết chơi CTF, có niềm đam mê và muốn học tập thêm về lĩnh vực này.
🌟 Tham gia 2 vòng tuyển chọn:
Vòng 1: Test năng lực - Làm bài thi về các mảng khác nhau trong CTF 
Vòng 2: Phỏng vấn tuyển chọn.
✅ Quyền lợi: Được học tập, rèn luyện cùng những bạn có nhiều thành tích trong các cuộc thi CTF.
🔥 Đây là một cơ hội 'hiếm có khó tìm' với rất nhiều sự thú vị đang chờ đón bạn. Còn chần chờ gì nữa mà không nhanh tay đăng ký để trở thành một trong những thành viên của mái nhà chung 𝐖𝐚𝐧𝐧𝐚.𝐖𝟏𝐧 thôi nào!! 🔥
➖➖➖➖➖➖
Mọi thắc mắc vui lòng liên hệ qua:
     🔸 𝐅𝐚𝐧𝐩𝐚𝐠𝐞: Phòng thí nghiệm An toàn thông tin - UIT InSecLab
     🔸 𝐆𝐦𝐚𝐢𝐥: inseclab@uit.edu.vn
     🔸 𝐃𝐢𝐬𝐜𝐨𝐫𝐝: Wanna.W1n - UIT Hacking Community
➖➖➖➖➖➖
#uit #inseclab #sinhvien #ATTT #wannaGame #CTF 
Nguồn: Phòng thí nghiệm An toàn thông tin - UIT InSecLab",
                    Location = "Online",
                    Type = "Other", // "Training", "Workshop", "Seminar", "Webinar", "Conference", "Other"
                },
                new()  {
                    Title = @"𝐖𝐀𝐍𝐍𝐀𝐒𝐄𝐓𝐔𝐏 𝟐𝟎𝟐𝟒 | CUỘC THI SETUP GÓC HỌC TẬP DÀNH CHO SINH VIÊN UIT",
                    Description = @"🤩 Bạn là một con dân IT yêu thích sự sáng tạo?
🤗 Bạn có một góc học tập/ làm việc cực chill muốn khoe nó với mọi người?
🫣 Bạn là người đang sở hữu những món đồ IT độc đáo? Có thể là một bàn phím cơ “đỉnk kao”, vài cái màn hình “Vip Pro” để phục vụ cho việc code dạo.
🔥 Nếu có những thứ đó thì chắc hẳn góc học tập của bạn sẽ cực kì thú vị phải không nhỉ? Hãy cùng tham gia 𝐖𝐚𝐧𝐧𝐚𝐒𝐞𝐭𝐮𝐩 để khoe không gian học tập của mình với mọi người thoi nào!!!!!!! Vừa có thể “flex” góc học tập, góc làm việc xịn xò của mình mà vừa có thể nhận được những giải thưởng thú vị nữa đó.🤭 
➖➖➖➖➖
𝐖𝐀𝐍𝐍𝐀𝐒𝐄𝐓𝐔𝐏 𝟐𝟎𝟐𝟒 là cuộc thi được tổ chức bởi CLB Wanna.W1n kết hợp cùng Bộ môn An toàn Thông tin - Khoa Mạng máy tính và Truyền Thông nhằm tạo sân chơi cho các bạn sinh viên An toàn Thông tin và sinh viên UIT tìm ra không gian setup ấn tượng nhất.
THỂ LỆ THAM DỰ
Các bạn thí sinh tham gia cuộc thi sẽ thực hiện lựa chọn hình thức như sau:
       📷 Thực hiện chụp hình góc học tập / làm việc của mình (tối thiểu 3 ảnh - tối đa 5 ảnh).
     📹 Thực hiện quay video dài tối đa 5 phút giới thiệu (thuyết minh) về góc học tập / làm việc của mình (lưu ý bản quyền nhạc nếu có nhạc nền).
⏰ Thời gian đăng ký: Từ ngày 𝟎𝟓/𝟎𝟔/𝟐𝟎𝟐𝟒 đến ngày 𝟏𝟎/𝟎𝟔/𝟐𝟎𝟐𝟒
📈 Thời gian bình chọn: Từ ngày 𝟏𝟏/𝟎𝟔/𝟐𝟎𝟐𝟒 đến ngày 𝟏𝟒/𝟎𝟔/𝟐𝟎𝟐𝟒
📌 Đăng ký tham gia tại: https://forms.gle/FoVtWFvWQf3nLi1s7
📝 Ngoài ra, các bạn thí sinh khi tham gia sẽ gửi kèm một đoạn mô tả ngắn về góc học tập / làm việc của mình.
CÁCH THỨC ĐÁNH GIÁ
Với mỗi bài dự thi sẽ được đánh giá bởi:
       🙋🏻 Đánh giá của khán giả chiếm 𝟒𝟎% bao gồm:
             👍 Mỗi lượt tương tác sẽ được cộng 𝟎.𝟓 điểm.
             💬 Tag tên của 3 người bạn khác được cộng 𝟎𝟏 điểm.
             🔔 Chia sẻ ở chế độ công khai và có chứa hashtag của cuộc thi được cộng 𝟎𝟓 điểm.
       🤵 Đánh giá của BGK chiếm 𝟔𝟎%.
GIẢI THƯỞNG
       🥇 1 Giải Nhất - 𝟖𝟎𝟎.𝟎𝟎𝟎 𝐕𝐍𝐃
       🥈 1 Giải Nhì - 𝟒𝟎𝟎.𝟎𝟎𝟎  𝐕𝐍𝐃
       🥉 1 Giải Ba - 𝟐𝟎𝟎.𝟎𝟎𝟎  𝐕𝐍𝐃
       🏅 1 Giải Góc Setup được khán giả yêu thích nhất - 𝟑𝟎𝟎.𝟎𝟎𝟎 𝐕𝐍𝐃
       🎖️ 1 Giải Góc Setup ấn tượng nhất - 𝟑𝟎𝟎.𝟎𝟎𝟎 𝐕𝐍𝐃
🏆 Còn chần chờ gì nữa mà không nhanh tay đăng ký tham gia ngay để có cơ hội nhận được những giải thưởng vô cùng hấp dẫn.
➖➖➖➖➖
Mọi thắc mắc vui lòng liên hệ qua:
     🔸 𝐅𝐚𝐧𝐩𝐚𝐠𝐞: facebook.com/inseclab/
     🔸 𝐆𝐦𝐚𝐢𝐥: inseclab@uit.edu.vn
     🔸 𝐃𝐢𝐬𝐜𝐨𝐫𝐝: Wanna.W1n - UIT Hacking Community
➖➖➖➖➖
#uit #inseclab #sinhvien #ATTT #WannaSetup",
                    Location = "Online",
                    Type = "Other", // "Training", "Workshop", "Seminar", "Webinar", "Conference", "Other"
                },
            ]
        },
        new() {
            Name = "SeExpress - Kênh thông tin khoa Công Nghệ Phần Mềm, ĐH CNTT",
            Description = @"Kênh thông tin chính thức của khoa Công Nghệ Phần Mềm, ĐH CNTT, được thành lập và quản lí bởi Đoàn khoa, Liên chi Hội khoa Công Nghệ Phần Mềm.",
            FacebookUrl = "https://www.facebook.com/CNPM.Fanpage",
            Email = "cnpm.fanpage@gmail.com",
            AvatarUrl = "https://tinyurl.com/khoacnpmuit",
            Events = [
                new()  {
                    Title = @"💫 [GAMELOFT] SEMINAR SẮP DIỄN RA RỒI!!! CÁC GAME DEVELOPER ƠI!!! 💫",
                    Description = @"‼️ Đúng vậy, Seminar “Get Ready For Your Gaming Career Path” do công ty Gameloft và CLB UIT GamApp Studios phối hợp tổ chức sẽ diễn ra trong ngày mai (07/06/2024).
✨ Đến với seminar, các bạn sẽ được học hỏi kinh nghiệm vào ngành từ diễn giả có thâm niên trong nghề – anh Nguyễn Anh Tuấn. Bên phía công ty còn dành ra một số phần quà cho các bạn tham gia tích cực trong buổi seminar nữa đó.
👀 BTC cũng bật mí cho các bạn rằng sẽ có THÔNG TIN về 1 CHƯƠNG TRÌNH HỖ TRỢ DỰ ÁN do Gameloft tổ chức tại buổi seminar. Nếu các bạn có ý tưởng cho dự án riêng nhưng thiếu hậu thuận thì đây là 1 CƠ HỘI không thể bỏ lỡ.
🔥 Nhanh chân lên nào các bạn ơi, seminar sắp diễn ra rồi!!!
 ——————————————————
       THÔNG TIN CHI TIẾT VỀ SEMINAR:
⏰ Thời gian: 9h45, thứ 6 ngày 7/6/2024.
📍 Địa điểm: Hội trường E, tầng 12 tòa E, trường Đại học Công nghệ Thông tin.
🎤 Diễn giả: Anh Nguyễn Anh Tuấn – Programmer Division Lead at Gameloft.
📌 Link đăng ký: https://tinyurl.com/seminar-grfygcp
🕤 Thời gian đăng ký: từ ngày 29/05/2024.
——————————————————
Mọi thắc mắc liên hệ tại:
 💻 Official Page: https://www.facebook.com/UITGamAppStudios
 📩 Gmail: gamappuit.club@gmail.com",
                    Location = "Hội trường E, tầng 12 tòa E, trường Đại học Công nghệ Thông tin",
                    Type = "Seminar", // "Training", "Workshop", "Seminar", "Webinar", "Conference", "Other"
                },
                new()  {
                    Title = @"🍀 [MÙA HÈ XANH 2024 | THÔNG BÁO TUYỂN CHIẾN SĨ] 🍀",
                    Description = @"🏖 Bạn có biết, điều hấp dẫn, thú vị nào đang chờ đón bạn trong mùa hè này không?
📩 Reng…reng! Mùa Hè Xanh gửi đến bạn lời mời trở thành chiến sĩ trên hành trình tình nguyện sắp tới. Chuỗi ngày khoác lên mình chiếc áo xanh, đồng hành cùng đội hình và những người bạn, chắc chắn sẽ tạo nên những khoảnh khắc không thể quên cho thời sinh viên của bạn.
🙅 Đừng để những tháng ngày nóng bức trôi qua lãng phí, hãy nhanh tay đăng ký trở thành những chiến sĩ tình nguyện ngay để cùng chúng mình “phủ xanh mùa hè” qua những hoạt động thú vị chỉ có tại Mùa Hè Xanh 2024!
-----------------------------
💙 THÔNG TIN CHIẾN DỊCH 💙
🌈 Chiến dịch Mùa Hè Xanh 2024 của trường Đại học Công nghệ Thông tin là hoạt động tình nguyện diễn ra trong hơn một tháng với sự tham gia của nhiều đội hình khác nhau.
️⛳ Timeline chiến dịch:
   ▪️ Phỏng vấn tuyển chọn chiến sĩ: Các ngày 11/06 và 12/06 tại trường ĐH CNTT
   ▪️ Hoạt động gây quỹ, làm việc nhóm: Các ngày 13/06 - 08/07
   ▪️ Lễ ra quân chiến dịch: Ngày 08/07 tại trường ĐH CNTT
   ▪️ Thời gian đóng quân tại địa bàn: Các ngày 08/07 - 29/07
   ▪️ Hội quân cấp Trường: Ngày 29/07 tại trường ĐH CNTT
#MHX2024 #MHXUIT2024",
                    Location = "Trường ĐH CNTT",
                    Type = "Other", // "Training", "Workshop", "Seminar", "Webinar", "Conference", "Other"
                },
                new()  {
                    Title = @"[WEBINAR] XÂY DỰNG HỒ SƠ CÁ NHÂN CHUYÊN NGHIỆP CÙNG VNG 📝",
                    Description = @"Trước ngưỡng cửa bước vào thị trường việc làm đầy cạnh tranh, việc sở hữu “𝗔 𝗣𝗿𝗼𝗳𝗲𝘀𝘀𝗶𝗼𝗻𝗮𝗹 𝗣𝗿𝗼𝗳𝗶𝗹𝗲” - một hồ sơ cá nhân chuyên nghiệp là điều thiết yếu. Tuy nhiên, hồ sơ cá nhân như thế nào là chuyên nghiệp và giúp bạn “nổi bật” trong mắt nhà tuyển dụng⁉️ Có phải hồ sơ cá nhân chỉ là Resume hay CV không⁉️
Nếu còn lăn tăn những câu hỏi trên thì webinar “𝗔 𝗣𝗿𝗼𝗳𝗲𝘀𝘀𝗶𝗼𝗻𝗮𝗹 𝗣𝗿𝗼𝗳𝗶𝗹𝗲 𝗙𝗼𝗿 𝗬𝗼𝘂𝗿 𝗖𝗮𝗿𝗲𝗲𝗿 𝗦𝘂𝗰𝗰𝗲𝘀𝘀” - phiên bản dành riêng cho các bạn 𝘀𝗶𝗻𝗵 𝘃𝗶𝗲̂𝗻 𝗖𝗼̂𝗻𝗴 𝗻𝗴𝗵𝗲̣̂ 𝗧𝗵𝗼̂𝗻𝗴 𝘁𝗶𝗻, chính là chân ái của bạn đấy! Đăng ký ngay tại  https://bit.ly/VNG_2024_Webinar01 
🕖 Thời gian: 𝟭𝟵𝗵𝟬𝟬 - 𝟮𝟬𝗵𝟬𝟬 𝗧𝗵𝘂̛́ 𝗡𝗮̆𝗺, 𝗻𝗴𝗮̀𝘆 𝟯𝟬/𝟬𝟱/𝟮𝟬𝟮𝟰
📍 Nền tảng: 𝗭𝗼𝗼𝗺 𝗪𝗲𝗯𝗶𝗻𝗮𝗿 - đường link tham gia sẽ được gửi đến bạn qua email sau khi đăng ký thành công. 
🎤 Diễn giả: Chị 𝗛𝘂̛𝗼̛𝗻𝗴 𝗩𝘂̃ - 𝗧𝗮𝗹𝗲𝗻𝘁 𝗔𝗰𝗾𝘂𝗶𝘀𝗶𝘁𝗶𝗼𝗻 𝗠𝗮𝗻𝗮𝗴𝗲𝗿, VNG Corporation. Với hơn 14 năm kinh nghiệm phụ trách mảng tuyển dụng ở đa dạng các vị trí và các chương trình dành cho sinh viên tại VNG, chị Hương chắc chắn sẽ mang đến nhiều chia sẻ bổ ích và hữu dụng để bạn chinh phục trái ❤️ các nhà tuyển dụng 😉
🎁 Đặc biệt: Tất cả các bạn đăng ký tham gia sẽ được VNG gửi tặng “bí kíp bỏ túi” để chuẩn chỉnh hồ sơ cá nhân của mình sau khi kết thúc sự kiện!
Đặt hẹn cùng VNG Recruitment vào ngày 30/05 để được giải đáp từ A - Z về cách xây dựng và hoàn thiện hồ sơ cá nhân chuyên nghiệp cho bản thân, bạn nhé 😘!
#VNG #VNGRecruitment #CareerTips #Webinar #ProfessionalProfile #Tech #Student #Fresher
Visual: 2024 - Webinar - CV Tips.png",
                    Location = "𝗭𝗼𝗼𝗺 𝗪𝗲𝗯𝗶𝗻𝗮𝗿 - đường link tham gia sẽ được gửi đến bạn qua email sau khi đăng ký thành công. ",
                    Type = "Webinar", // "Training", "Workshop", "Seminar", "Webinar", "Conference", "Other"
                },
                new()  {
                    Title = @"🌟🌟 [UIT GAMAPP STUDIOS x SKY MAVIS] 🌟🌟 
💫 SEMINAR “A STEP INTO THE GAME INDUSTRY”",
                    Description = @"❓ Bạn đam mê game và muốn góp phần tạo ra một sản phẩm game thật đỉnh?
❓ Bạn muốn khám phá những cơ hội nghề nghiệp trong lĩnh vực này?
❓ Nhưng bạn không biết bắt đầu từ đâu?
Thấu hiểu những nguyện vọng và mong mỏi khám phá của các bạn sinh viên về ngành công nghiệp game, UIT GamApp Studios hân hạnh tổ chức Seminar 'A step into the Game industry' với những diễn giả kỳ cựu đến từ Sky Mavis - studio đứng sau tựa game thành công Axie Infinity.
Đến với 'A step into the Game industry', các bạn sẽ có được:
👉 Góc nhìn thực tế về các vị trí trong một studio game.
👉 Hiểu biết về cơ hội của ngành game tại Việt Nam.
👉 Lời khuyên về study path và career path cho sinh viên muốn theo đuổi công việc trong lĩnh vực game.
——————————————————
THÔNG TIN CHI TIẾT VỀ SEMINAR:
⏰ Thời gian: 09h45, thứ 6 ngày 24/05/2024.
📍 Địa điểm: Tầng 12, tòa nhà E trường Đại học Công nghệ Thông tin.
🎤 Diễn giả:
🌟 Mr. Hoan Nguyen - Director, Head of Axie Games at Sky Mavis.
🌟 Mr. Phuong Nguyen - Game Engineering Lead at Sky Mavis.
🌟 Mr. Anh Do - Talent Partner Lead at Sky Mavis.
📌 Link đăng ký: https://tinyurl.com/a-step-into-the-game-industry
⌛ Thời gian đăng ký: từ ngày 14/05/2024 đến 20h ngày 23/05/2024.
Số lượng tham gia có hạn, đừng chần chờ gì nữa mà hãy nhanh tay đăng ký để tham gia chương trình, cùng khám phá thế giới game đầy thú vị và tiềm năng với CLB chúng mình nào!
👐 Bật mí là sẽ có những phần quà hấp dẫn chờ đón các bạn ở buổi Seminar đó!
——————————————————
Mọi thắc mắc liên hệ tại:
💻 Fanpage: UIT GamApp Studios
📩 Gmail: gamappuit.club@gmail.com",
                    Location = "Tầng 12, tòa nhà E trường Đại học Công nghệ Thông tin",
                    Type = "Seminar", // "Training", "Workshop", "Seminar", "Webinar", "Conference", "Other"
                },
                new()  {
                    Title = @"[VNG TOUR] ĐĂNG KÍ THAM QUAN CÔNG TY VNG",
                    Description = @"⏰ Thời gian: 7h30 - 11h45 ngày 22/05/2023 (thứ tư)
📍 Địa điểm:  VNG Campus - VNG sắp xếp xe đưa đón sinh viên tại trường.
🙋‍♂️Đối tượng: Sinh viên khối ngành Công nghệ tại TP.HCM
Link đăng ký tham gia: https://forms.gle/9EQU762MExUd6qJRA
- Phương tiện di chuyển: Có xe đưa đón tại trường ĐH CNTT
- Địa điểm tập trung (nếu đi xe của BTC): Cổng trường phía Nhân Văn, có mặt lúc 7h15 ngày 22/05/2024. Nếu di chuyển tự túc thì sinh viên có mặt tại địa điểm của công ty trước 8h30.
Luôn đồng hành và mang đến những trải nghiệm thực tiễn nhất cùng sinh viên, VNG Tour sẽ là dịp gặp gỡ và kết nối cộng đồng sinh viên công nghệ. Ghi nhớ lịch ngay, hẹn gặp các bạn tại VNG Campus nhé!
**Nếu có vấn đề gì thắc mắc cần giải đáp vui lòng liên hệ chaupbn@uit.edu.vn hoặc 093 8075826 (cô Bảo Châu)
Nhanh tay đăng kí nhé các bạn!",
                    Location = "VNG Campus - VNG sắp xếp xe đưa đón sinh viên tại trường",
                    Type = "Other", // "Training", "Workshop", "Seminar", "Webinar", "Conference", "Other"
                },
            ]
        },
        new() {
            Name = "Khoa Kỹ Thuật Máy Tính - CE.UIT",
            Description = @"- Trang thông tin Đoàn - Hội khoa Kỹ thuật Máy tính. - Cập nhật các cuộc thi học thuật.",
            FacebookUrl = "https://www.facebook.com/ce.uit",
            Email = "tuoitre.ktmt@gm.uit.edu.vn",
            AvatarUrl = "https://tinyurl.com/khoaktmtuit",
            Events = [
                new()  {
                    Title = @"🌟[CUỘC THI THIẾT KẾ VI MẠCH UIT 2024 |THÔNG BÁO NỘP Ý TƯỞNG VÒNG 2]🌟",
                    Description = @"📢THÔNG BÁO QUAN TRỌNG CHO CÁC THÍ SINH CUỘC THI THIẾT KẾ VI MẠCH 2024 📢 
💝Với sự thành công của vòng sơ loại vừa qua, ban tổ chức vô cùng phấn khởi trước sự tham gia nhiệt tình của các bạn thí sinh trong và ngoài trường. Chúng tôi hy vọng niềm đam mê với lĩnh vực Thiết kế Vi mạch sẽ tiếp tục duy trì trong vòng thi ý tưởng sắp diễn ra. 
💡 Với chủ đề “THIẾT KẾ VI MẠCH CHO GIAO THÔNG THÔNG MINH”, ban tổ chức rất hy vọng được đón nhận những ý tưởng sáng tạo đầy tính táo bạo từ tất cả các bạn. Đừng ngần ngại chia sẻ những ý tưởng sáng tạo của nhóm các bạn vì biết đâu đó chính là ý tưởng tuyệt vời có thể giúp ích cho xã hội sau này.
👉Link tải mẫu đơn đăng ký ý tưởng: https://docs.google.com/.../1w2M7y2tEdcMCYfMks2g6.../edit...
✨Hãy chắc chắn ý tưởng của bạn đã nộp đúng hạn để ban tổ chức có thể tiến hành đánh giá và xem xét ý tưởng dự thi từ bạn:
⏰Hạn cuối nộp ý tưởng: 30/06/2024
🔗Link nộp ý tưởng: https://forms.gle/GUFbjr4a8PmGMYvf9
❤️ Chúng tôi rất mong các bạn sẽ luôn tự tin với đam mê, sự yêu thích với lĩnh vực Thiết kế Vi mạch. Chúc các bạn may mắn và thành công trong các vòng thi tiếp theo!💕
------------------------------------------------
Thông tin cuộc thi:
⁉️Mọi thắc mắc liên hệ qua email: truongnh@uit.edu.vn (thầy Trường)
🌐Website: https://fce.uit.edu.vn/cuoc-thi-thiet-ke-vi-mach-uit/
#CE_UIT #TKVM_UIT",
                    Location = "Online",
                    Type = "Other", // "Training", "Workshop", "Seminar", "Webinar", "Conference", "Other"
                },
                new()  {
                    Title = @"🔥[SEMINAR GIỚI THIỆU CÔNG TY XLINK VÀ CƠ HỘI NGHỀ NGHIỆP]🔥",
                    Description = @"👉Xin chào các bạn, chuỗi hoạt động Seminar của Khoa Kỹ thuật Máy tính đã quay trở lại rồi đây!
😍Lần này CE sẽ đem đến cho các bạn Seminar “Giới thiệu Công ty XLINK và cơ hội nghề nghiệp” với sự tài trợ đến từ phía Công ty XLINK.
🤔Đến với Seminar, các bạn sẽ được gặp gỡ:
🍀 Dr. Michael Q. Le - President & CEO XLINK
🍀 Mr. Vuong Hoang - Staff Analog Design Engineer
🍀 Mr. Phu Vuong - Staff Digital Design Engineer
cùng các nhân viên, kỹ sư đến từ XLINK để lắng nghe những kiến thức bổ ích và cơ hội nghề nghiệp đến từ Công ty.
👇 Đăng ký tham gia ngay tại link phía dưới để không bỏ lỡ cơ hội quý báu này nhé!!!!
🔗Link Đăng ký: https://forms.gle/XVWGaJBziZ31FdjJ9
_________________________________
THÔNG TIN SEMINAR
Thời gian: 10h00, ngày 28/05/2024",
                    Location = "Phòng B612, Tòa B, Trường ĐH CNTT",
                    Type = "Seminar", // "Training", "Workshop", "Seminar", "Webinar", "Conference", "Other"
                },
                new()  {
                    Title = @"‼️[THI THỬ TOEIC 2024 | CÔNG BỐ CHƯƠNG TRÌNH & MỞ ĐĂNG KÝ THAM GIA]‼️",
                    Description = @"🔴Hiện nay, có nhiều bạn đang chuẩn bị thi TOEIC nhưng vẫn chưa thật sự sẵn sàng dù đã tự luyện đề thi ở nhà. Bên cạnh đó cũng có nhiều bạn muốn kiếm tra trình độ tiếng Anh của bản thân để tạo ra lộ trình học phù hợp trong khoảng thời gian sắp tới. Hiểu được sự băn khoăn và khó khăn của các bạn, tháng 6 này, Liên Chi Hội khoa Kỹ thuật Máy tính tổ chức Chương trình “Thi thử TOEIC”. 
🌸  Khi tham gia cuộc thi bạn có thể mang lại cho mình những quyền lợi như:
✔️Tiếp xúc với đề thi chuẩn format mới, làm quen với không khí phòng thi, giúp bạn tự tin hơn với những cuộc thi học thuật tương tự, chuẩn bị sẵn tâm lý tốt khi bước vào kì thi TOEIC chính thức.
✔️ Biết được trình độ tiếng Anh của bản thân mình, từ đó lập kế hoạch và mục tiêu phù hợp với bản thân.
✔️ Các bạn tham gia thi thử sẽ nhận được Voucher trị giá 400.000 nghìn đồng khi đăng ký khóa học tại trung tâm kèm một phiếu thi thử năng lực tại trung tâm.
✔️ Bạn sẽ được cấp tiêu chí 'Hội nhập tốt' trong 5 tiêu chí của ' Sinh viên 5 tốt'  khi bạn đạt được số điểm từ 450.
⭐ ĐẶC BIỆT: Top 3 bạn có kết quả cao nhất trong kỳ thi sẽ nhận được phần quà từ Ban tổ chức và trung tâm đồng hành, cụ thể như sau:
️🥇Giải nhất: 500.000 tiền mặt + Voucher giảm giá 25% khóa học tại trung tâm + Bình giữ nhiệt từ trung tâm
️🥈Giải nhì: 300.000 tiền mặt + Voucher giảm giá 25% khóa học tại trung tâm + Bình giữ nhiệt từ trung tâm
️🥉Giải ba: 200.000 tiền mặt + Voucher giảm giá 25% khóa học tại trung tâm + Bình giữ nhiệt từ trung tâm
🔗Còn chần chờ gì mà không đăng ký ngay tại link: https://forms.gle/k31Qrjt9YMYA1WW29
👉Thời gian đăng ký tham gia: Từ ngày 25/05/2024 - 05/06/2024.
Thông tin chương trình:
⏰Thời gian: Thứ 7 ngày 08/06/2024.
- Ca sáng: 8h – 10h30.
- Ca chiều: 13h30 – 16h00.
Các bạn có thể tham gia cả hai ca thi nhé.
🏫Địa điểm: Tòa B – Trường Đại học Công nghệ Thông tin, ĐHQG-TP.HCM.
👥 Đối tượng: Toàn bộ sinh viên trường Đại học Công nghệ thông tin - ĐHQGTPHCM.
💵Lệ phí: 15.000 đồng/thí sinh/buổi thi.
Nếu bạn là học viên của Trung tâm Anh ngữ Tôi tự học, bạn sẽ được miễn phí tham gia.
-------------------------------------------------------------------
⁉️Mọi thắc mắc xin vui lòng liên hệ:
- Fanpage: Khoa Kỹ Thuật Máy Tính - CE.UIT
- Email: tuoitre.ktmt@gm.uit.edu.vn
- Đ/c: Bùi Đăng Huy – Liên Chi hội trưởng khoa KTMT – Trưởng BTC - 0392211585
- Đ/c: Đoàn Đăng Quang – Liên Chi hội phó LCH Khoa KTMT – Thành viên BTC",
                    Location = "Tòa B – Trường Đại học Công nghệ Thông tin, ĐHQG-TP.HCM",
                    Type = "Other", // "Training", "Workshop", "Seminar", "Webinar", "Conference", "Other"
                },
                new()  {
                    Title = @"🔴[GEN AI CHALLENGE 2024 | KHOA KỸ THUẬT MÁY TÍNH & BOSCH VIỆT NAM]🔴",
                    Description = @"🔴[GEN AI CHALLENGE 2024 | KHOA KỸ THUẬT MÁY TÍNH & BOSCH VIỆT NAM]🔴
🚀Với xu thế phát triển của mảng AI&IoT trong lĩnh vực Automotives, BOSCH tổ chức cuộc thi GENAI CHALLENGE 2024 do GS. Dirk Slama và Bosch chủ trì.
🪄Các bạn đang là sinh viên, các bạn có sự yêu thích với AI và IoT, GEN AI CHALLENGE sẽ là nơi các bạn có thể thoả sức trải nghiệm với đam mê của mình. Khi tham gia cuộc thi, các bạn sẽ được học hỏi thêm nhiều về AI cũng như IoT, được nhận sự hỗ trợ từ thầy cô và đặc biệt là từ phía Bosch Việt Nam. 
🤩Với niềm đam mê của bản thân và giải thưởng vô cùng lớn đang chờ đón, còn chần chừ gì nữa mà không nhanh tay đăng ký tham dự để thử sức mình nào các bạn ơi!
‼️XEM THÊM THÔNG TIN VỀ CUỘC THI VÀ GIẢI THƯỞNG: https://www.digital.auto/genai-award
🔗LINK ĐĂNG KÝ THAM GIA CUỘC THI  👉👉👉 https://forms.gle/mA7vi4529MHK3wP29
---------------------------------------------
#GENAICHALLENGE2024 #CE_UIT #BOSCHVIETNAM",
                    Location = "Online",
                    Type = "Other", // "Training", "Workshop", "Seminar", "Webinar", "Conference", "Other"
                },
                new()  {
                    Title = @"🔥[SEMINAR VI MẠCH CHUYÊN SÂU 2024 LẦN 2 - SYNOPSYS]🔥",
                    Description = @"🔥[SEMINAR VI MẠCH CHUYÊN SÂU 2024 LẦN 2 - SYNOPSYS]🔥
👉 Để có thể phát triển hợp tác giữa hai đơn vị và giúp sinh viên khoa nâng cao tư duy và kỹ năng nghề nghiệp theo định hướng Thiết kế Vi mạch, Khoa KTMT sẽ phối hợp với Synopsys tổ chức buổi Seminar nghề nghiệp Thiết kế vi mạch chuyên sâu lần 2 - năm 2024.
🔥 Khi tham dự buổi Seminar, các bạn sẽ có cơ hội được lắng nghe những chia sẻ của những chuyên gia trong lĩnh vực công nghệ và tuyển dụng, đồng thời mở rộng hiểu biết về công ty, môi trường làm việc cũng như cơ hội việc làm trong tương lai đó nha!!!
👇 Đăng ký tham gia ngay tại link phía dưới để không bỏ lỡ cơ hội quý báu này nhé!!!!
_________________________________
THÔNG TIN SEMINAR
Thời gian: 9h30 - 11h, ngày 24/4/2024 (Thứ 4)
Diễn giả: Chuyên gia công nghệ và tuyển dụng, Công ty Synopsys Việt Nam
Link đăng ký: https://forms.gle/8Vnozz95vQCjtAAB7",
                    Location = "Phòng C214, Tòa C, Trường ĐH CNTT",
                    Type = "Seminar", // "Training", "Workshop", "Seminar", "Webinar", "Conference", "Other"
                },
            ]
        },
        new() {
            Name = "Khoa Khoa học và Kỹ thuật Thông tin - UIT",
            Description = @"Trang thông tin về các hoạt động, các chương trình từ khoa Khoa học và Kỹ thuật Thông tin - UIT",
            FacebookUrl = "https://www.facebook.com/UIT.ISE",
            Email = "bch.khkttt.uit@gmail.com",
            AvatarUrl = "https://tinyurl.com/khoaiseuit",
            Events = [
                new()  {
                    Title = @"📝 [MỞ FORM ĐĂNG KÝ] SEMINAR 'Data Mart: Centralizing Business Data for Analytics and Forecasting' 📝",
                    Description = @"📊 Trong thời đại số hóa và tăng trưởng dữ liệu nhanh chóng, nhu cầu xử lý và chọn lọc dữ liệu ngày càng tăng cao, Data Mart trở thành một “nhà kho thu nhỏ” chứa các tập dữ liệu đã được chọn lọc và xử lý trước. Data Mart giúp các doanh nghiệp phân tích và sử dụng thông tin một cách hiệu quả, từ đó đưa ra quyết định chiến lược và dự báo kinh doanh đáng tin cậy.
🌀 Để hiểu hơn về Data Mart và ứng dụng của nó trong các lĩnh vực chuyên môn, khoa Khoa học và Kỹ thuật Thông tin sẽ mang đến cho bạn một buổi hội thảo với nhiều thông tin bổ ích và trải nghiệm thú vị, đầy hấp dẫn. 
💝 Đây sẽ là cơ hội tuyệt vời dành cho các bạn sinh viên yêu thích và quan tâm đến Khoa học Dữ liệu, vậy còn chần chờ gì mà không mau điền form đăng ký bên dưới đi nào!🔥
___________________________________________
📅 Thời gian: 13h30 – 16h30, Thứ tư, ngày 24/04/2024.  
📍 Địa điểm: Hội trường E, Trường Đại học Công nghệ Thông tin - ĐHQG TP. HCM.  
🎤 Diễn giả: Anh Lưu Minh Long, Senior Data Engineer and Data Analyst tại FPT Software.
👉🏻👉🏻 Link đăng ký: https://bit.ly/DangKySeminar24-04
___________________________________________
🔰 KHOA KHOA HỌC VÀ KỸ THUẬT THÔNG TIN - UIT 🔰
📍 Địa điểm: Tầng 10, tòa nhà E - trường Đại học Công nghệ Thông tin, ĐHQG-HCM.
🌐 Website: https://fit.uit.edu.vn/
📧 Email Đoàn - Hội ISE: bch.khkttt.uit@gmail.com
#ISE2024
#SEMINAR",
                    Location = "Hội trường E, Trường Đại học Công nghệ Thông tin - ĐHQG TP. HCM",
                    Type = "Seminar", // "Training", "Workshop", "Seminar", "Webinar", "Conference", "Other"
                },
                new()  {
                    Title = @"🚎🚎 [COMPANY TOUR 2024 - FPT SOFTWARE] MỞ FORM ĐĂNG KÝ 🚎🚎",
                    Description = @"👉 Bạn muốn có cái nhìn thực tế và cận cảnh hơn về môi trường làm việc của doanh nghiệp?
👉 Bạn muốn có cơ hội hiểu rõ mong muốn, yêu cầu của doanh nghiệp để có thể chủ động cải thiện năng lực bản thân?
💘 Vậy thì còn chần chờ gì mà không tham gia ngay COMPANY TOUR 2024 - Tham quan doanh nghiệp FPT Software Hồ Chí Minh.
🌏 Một chuyến đi giúp các bạn sinh viên tìm hiểu về môi trường, không gian làm việc chuyên nghiệp, và hiện đại của FPT Software Hồ Chí Minh, cung cấp và thực hiện dịch vụ an toàn thông tin trên lãnh thổ Việt Nam và các nước trong khu vực. Đến với FPT Software là đến với một môi trường làm việc trẻ trung, hiện đại, năng động và cực kỳ chuyên nghiệp.
------------------------------------
Chi tiết về hành trình đến công ty FPT Software:
👥 Đối tượng: Sinh viên khoa Khoa học và Kỹ thuật Thông tin, trường Đại học Công nghệ Thông tin, ĐHQG-HCM. Ưu tiên sinh viên năm 3, 4.
🕐 Thời gian: 8g00p - 11g00p, thứ Năm ngày 04/04/2024.
🏤 Địa điểm: Toà FTown 3, số 3 Đường Võ Chí Công, Phường Long Thạnh Mỹ, Khu Công nghệ cao, Thành phố Thủ Đức, TP. HCM.
👕 Trang phục:
👉 Sinh viên tham quan phải đeo thẻ Sinh viên và mặc đồng phục. (Trường hợp không có đồng phục trường, sinh viên mặc áo sơ mi trắng.)
👉 Sinh viên nam mặc quần dài, không mặc quần ngắn trên đầu gối.
⛔⛔⛔ CHÚ Ý:
👉 Số lượng sinh viên có hạn: Chỉ 25 sinh viên, nên nếu bạn chắc chắn tham gia được thì hãy đăng ký nha.
👉 Sinh viên tập trung tại trường và được xe đưa rước.
👉 Sinh viên được hỗ trợ 100% kinh phí trong suốt hành trình tham quan.
📝 📝 Hãy mau đăng ký ở link sau để trở thành một hành khách trong chuyến đi vô cùng bổ ích này nha: https://bit.ly/DangKy_CompanyTour2024_FPTSoftware 
------------------------------------
🔰 KHOA KHOA HỌC VÀ KỸ THUẬT THÔNG TIN - UIT 🔰
📍 Địa điểm: Tầng 10, tòa nhà E - trường Đại học Công nghệ Thông tin, ĐHQG-HCM.
🌐 Website: https://fit.uit.edu.vn/
📧 Email Đoàn - Hội ISE: bch.khkttt.uit@gmail.com
👉 Fanpage Khoa Khoa học và Kỹ thuật Thông tin - UIT: https://www.facebook.com/UIT.ISE/
#ISE2024
#CompanyTour2024_FPTSoftware",
                    Location = "Toà FTown 3, số 3 Đường Võ Chí Công, Phường Long Thạnh Mỹ, Khu Công nghệ cao, Thành phố Thủ Đức, TP. HCM",
                    Type = "Other", // "Training", "Workshop", "Seminar", "Webinar", "Conference", "Other"
                },
                new()  {
                    Title = @"[𝐈𝐒𝐄 𝐂𝐀𝐌𝐏 𝟐𝟎𝟐𝟒] ✨ Nắng - The Sound of Light ✨",
                    Description = @"“𝑾𝒆 𝒕𝒉𝒊𝒏𝒌 𝒕𝒉𝒆 𝒔𝒖𝒏 𝒓𝒊𝒔𝒆𝒔 𝒂𝒏𝒅 𝒔𝒆𝒕𝒔 𝒐𝒏 𝒚𝒐𝒖 🌻”
☀️ Như một hòa phối hoàn hảo được tạo ra bởi ánh sáng, ISE Camp 2024 là bức tranh sống động về 'Nắng' - nơi các câu chuyện về tuổi trẻ rực rỡ được kể, nơi để khám phá những trải nghiệm mới lạ và đầy hứng thú.
💝 Lần đầu tiên xuất hiện với những điều được mong chờ nhất, ISE Camp 2024 là cơ hội để các bạn có thể có thêm được nhiều kiến thức, kinh nghiệm và cả trải nghiệm, cũng như tạo cơ hội để có thêm nhiều người bạn mới, học những điều hay và phát triển kỹ năng giao tiếp của bản thân mình. 💪
️🎊 Vậy thì, còn chần chờ gì nữa, hãy tận hưởng tháng 3 đầy rực rỡ với 'Nắng - The Sound of Light' nhé!!! 🔥🔥
🙋‍♀️ Cùng chúng mình thay những chiếc áo mới thật xinh xắn để đón chờ một chương trình hứa hẹn thật bùng nổ nhé!!!
👉 Thay avatar: https://bit.ly/ISE_CAMP_2024_Avatar 
👉 Thay cover: https://bit.ly/ISE_CAMP_2024_Cover 
👉 Thay frame: https://bit.ly/ISE_CAMP_2024_Frame 
➖➖➖➖➖
🌟 Nhanh tay đăng ký tham gia ngay thoiiii: https://bit.ly/ISE_CAMP_2024_MoFormDangKy 
     📲 Thông tin thanh toán trực tuyến (Momo, Internet Banking)
     - Qua MOMO: 0948645540 - Bùi Yến Giàu
     - Qua Ngân hàng: BIDV chi nhánh Đồng Khởi - 7290283486 - Bùi Yến Giàu
     ✏ Nội dung: 𝑰𝑺𝑬 𝑪𝑨𝑴𝑷_< 𝑯𝒐 𝒕𝒆𝒏> _<𝑴𝑺𝑺𝑽>
🌟Đăng ký trực tiếp: Tại bàn BTC đặt tại sảnh C, trường Đại học Công nghệ Thông tin, ĐHQG-HCM.
     💵 Thông tin thanh toán trực tiếp: Thanh toán trực tiếp tại bàn đăng ký.
📩 Mọi thắc mắc xin vui lòng phản hồi về FANPAGE Khoa Khoa học và Kỹ thuật Thông tin - UIT  hoặc đến trực tiếp bàn đăng ký tại sảnh C.
📞 Hotline: 0964.850.620 (Lý Phi Lân - Trưởng BTC)",
                    Location = "Khu Du lịch sinh thái Bò Cạp Vàng, Đồng Nai",
                    Type = "Other", // "Training", "Workshop", "Seminar", "Webinar", "Conference", "Other"
                },
                new()  {
                    Title = @"🔰 SEMINAR: SINH VIÊN VÀ NGHIÊN CỨU KHOA HỌC NĂM 2024",
                    Description = @"📧 Nhằm truyền cảm hứng đam mê nghiên cứu đến với các bạn sinh viên, Khoa Khoa học và Kỹ thuật Thông tin kính chuyển đến các bạn sinh viên thư mời tham dự buổi Seminar Sinh viên và Nghiên cứu khoa học năm 2024.
📝 Tại đây, các bạn sẽ được các cựu sinh viên và các bạn sinh viên Khoa Khoa học và Kỹ thuật Thông tin chia sẻ quá trình tham gia nghiên cứu và công bố khoa học trong suốt quãng thời gian học tập tại UIT.
Thông tin cụ thể:
👥 Đối tượng: Sinh viên đang học tập tại Trường Đại học Công nghệ Thông tin, ĐHQG-HCM.
🕗 Thời gian: 08h30 - 11h00 ngày 30/01/2024.
#ISE2024 #SEMINAR",
                    Location = "Online qua Google Meet: https://meet.google.com/fkb-qrpb-dbe",
                    Type = "Seminar", // "Training", "Workshop", "Seminar", "Webinar", "Conference", "Other"
                },
                new()  {
                    Title = @"🛎 Seminar của GS. Okumura (Đại học Saga, Nhật Bản) 🛎",
                    Description = @"Kính mời Quý Thầy/Cô và các bạn sinh viên tham dự chương trình Seminar với những chia sẻ đến từ Giáo Sư Okumura cùng với các bạn sinh viên đến từ Đại học Saga Nhật Bản. 
⏰Thời gian: 8h30 - 11h00, Thứ Ba ngày 23/01/2024.
✍️ Nội dung: Giới thiệu các chương trình đào tạo mới tại Đại học Saga; các hướng nghiên cứu của GS. Okumura và các sinh viên. 
🔗 Link đăng ký: https://forms.gle/izY1349MqVDw6ZmZ9
#KHKTTT",
                    Location = "Hội trường E",
                    Type = "Seminar", // "Training", "Workshop", "Seminar", "Webinar", "Conference", "Other"
                },
            ]
        },
        new() {
            Name = "Khoa Khoa học Máy tính UIT",
            Description = @"Page chính thức của Khoa Khoa Học Máy Tính - Trường Đại Học Công Nghệ Thông Tin, ĐHQG TP.HCM (CS-UIT)",
            FacebookUrl = "https://www.facebook.com/uit.cs",
            Email = "bch.cs.uit@gmail.com",
            AvatarUrl = "https://tinyurl.com/khoakhmtuit",
            Events = [
                new()  {
                    Title = @"[SEMINAR] Khám phá Wireless Brain-Inspired Computing (WiBIC)",
                    Description = @" 🎉Kính mời Quý Thầy Cô tham dự buổi Seminar với chủ đề 'Wireless Brain-Inspired Computing (WiBIC).' 
 💥Wireless Brain-Inspired Computing (WiBIC) - một lĩnh vực nghiên cứu mới đầy tiềm năng, kết hợp các nguyên tắc tính toán lấy cảm hứng từ não bộ cùng công nghệ không dây tiên tiến. Lĩnh vực này hứa hẹn sẽ mang đến những đột phá trong cách chúng ta thiết kế và sử dụng các hệ thống máy tính, mang lại khả năng xử lý thông tin hiệu quả, linh hoạt và thích ứng hơn.
 🌟Seminar 'Wireless Brain-Inspired Computing (WiBIC)' với sự tham gia của Giáo sư Hiroo Sekiya đến từ Đại học Chiba, Nhật Bản sẽ là cơ hội tuyệt vời để tìm hiểu thêm về lĩnh vực nghiên cứu mới mẻ và đầy tiềm năng này.
---------- 
 ✨️THÔNG TIN BUỔI SEMINAR✨️  
📄Chủ đề: Wireless Brain-Inspired Computing (WiBIC)
----------  
Mọi thắc mắc xin vui lòng liên hệ:  
🌐Fanpage: Khoa Khoa học Máy tính UIT
#CS_UIT",
                    Location = "Phòng E1.1, tòa E, Trường Đại học Công nghệ Thông tin - ĐHQGHCM ",
                    Type = "Seminar", // "Training", "Workshop", "Seminar", "Webinar", "Conference", "Other"
                },
                new()  {
                    Title = @"[SEMINAR | Khởi nghiệp sinh viên IT: Cơ hội và Thách thức]",
                    Description = @"THÔNG TIN CHI TIẾT BUỔI SEMINAR:
✏️Chủ đề: Khởi nghiệp sinh viên IT: Cơ hội và Thách thức
🎤Diễn giả: Nguyễn Ngọc Tú - CEO của TVT Group
⏰Thời gian: Thứ 3 ngày 28/05/2024
📌Địa điểm: Hội trường E, Trường Đại học Công nghệ Thông tin ĐHQG - HCM
💡Link form đăng kí: https://forms.gle/PtVfbFnucFrPKsy49
------------------------------
❓Bạn đang có nhiều thắc mắc về định hướng tương lai của bản thân?
❓Bạn hoài nghi và sợ sệt khi phải đưa ra những quyết định ảnh hưởng trên con đường khởi nghiệp của mình?
❓Hay bạn chỉ đơn giản là muốn nghe những chia sẻ từ cựu sinh viên đã khởi nghiệp thành công?
🔥Khoa rất hân hạnh được giới thiệu với các bạn diễn giả của buổi seminar, anh Nguyễn Ngọc Tú - là cựu sinh viên khóa 1 chương trình tài năng khoa Khoa học Máy tính, cũng là CEO của TVT Group.
🔎TVT GROUP là một tập đoàn công nghệ với hơn 11 năm kinh nghiệm trong nền công nghiệp IT về lĩnh vực nghiên cứu và phát triển các ứng dụng & hệ thống phần mềm. Bắt tay hợp tác với nhiều đối tác tại nhiều nước trên thế giới ở nhiều lĩnh vực như: Mobile Application, Window software, Web Development & IoT Software,... TVT Group đã đạt được những thành công nhất định trong nền công nghiệp này.🔍
------------------------------
Mọi thông tin thắc mắc vui lòng liên hệ:
Fanpage: Khoa Khoa học Máy tính UIT
#CS_UIT",
                    Location = "Hội trường E, Trường Đại học Công nghệ Thông tin ĐHQG - HCM",
                    Type = "Seminar", // "Training", "Workshop", "Seminar", "Webinar", "Conference", "Other"
                },
                new()  {
                    Title = @"[HỘI NGHỊ SINH VIÊN KHOA KHOA HỌC MÁY TÍNH 2024] ",
                    Description = @"📩 Để tạo điều kiện cho Ban giám hiệu Nhà trường và Ban chủ nhiệm khoa có thể hiểu được suy nghĩ, những khó khăn và vướng mắc mà sinh viên gặp phải trong quá trình học tập và rèn luyện, ban chủ nhiệm Khoa và Nhà trường sẽ tổ chức Hội nghị Sinh viên của khoa Khoa học Máy tính nhằm kết nối và có những góc nhìn gần gũi hơn đến với các vấn đề của các bạn sinh viên. 
📩 BTC và xin gửi thông tin đến tất cả các bạn sinh viên. 
——————————————— 
📌 Thời gian: 9h30 ngày 07/05/2024  
📌 Địa điểm: Hội trường E, trường ĐH CNTT 
📌 Thành phần tham dự: 
   📮 Đại diện Ban giám hiệu Nhà trường 
   📮 Ban chủ nhiệm khoa Khoa học Máy tính 
   📮 Đại diện Lãnh đạo và chuyên viên Phòng CTSV 
   📮 Đại diện Lãnh đạo Phòng Đào tạo Đại học; Văn phòng Các Chương trình Đặc biệt; Trung tâm ngoại ngữ 
   📮 Toàn thể quý Thầy Cô Cố vấn học tập của Khoa Khoa học Máy tính 
   📮 Cùng toàn thể sinh viên của khoa Khoa học Máy tính UIT 
——————————————— 
🎁 Đây là chương trình dành riêng cho toàn thể sinh viên khoa Khoa học Máy tính. Đến với Hội nghị, các bạn sinh viên có thể: 
📍 Trao đổi những thuận lợi, khó khăn trong học tập, sinh hoạt cũng như thắc mắc của sinh viên về công tác đào tạo, công tác hỗ trợ CVHT, cơ sở vật chất,.... 
📍 Tiếp nhận những ý kiến đóng góp và đề xuất cho sự phát triển Nhà trường. 
🌈 Thật tuyệt vời đúng không nào! Vậy thì còn ngại ngần gì nữa mà các bạn sinh viên khoa Khoa học Máy tính không chuẩn bị những câu hỏi thật hay và sẵn sàng cho một buổi Hội nghị thật năng suất!! 
🌟 Hẹn gặp tất cả các bạn sinh viên trong buổi Hội nghị ♥️ 
——————————————— 
Mọi thắc mắc xin liên hệ: 
🌎 Fanpage: Khoa Khoa học Máy tính UIT 
#CS_UIT",
                    Location = "Hội trường E, trường ĐH CNTT",
                    Type = "Seminar", // "Training", "Workshop", "Seminar", "Webinar", "Conference", "Other"
                },
                new()  {
                    Title = @"🔴 HỘI THẢO AI CONNECT chủ đề 'Giới thiệu về đào tạo và nghiên cứu về AI tại ĐHQG-HCM và Xu hướng nguồn nhân lực AI'",
                    Description = @"Buổi nói chuyện thuộc Chương trình Site Visit, do Trường Đại học Công nghệ Thông tin phối hợp với Trường Đại học Bách Khoa và Đại học Khoa học Tự nhiên tổ chức. Đây là hoạt động nằm trong khuôn khổ Hội thảo AI Connect II do Bộ Khoa học và Công nghệ phối hợp với Bộ Ngoại giao Hoa Kỳ thông qua Tổ chức phi chính phủ Atlantic Council (Hoa Kỳ) tổ chức.
Nội dung của Buổi nói chuyện: 'Giới thiệu về đào tạo và nghiên cứu về AI tại ĐHQG-HCM và Xu hướng nguồn nhân lực AI'
 - Thời gian: 9:30 – 12:00, Thứ Ba, ngày 23/4/2024.
- Địa điểm: Hội trường A, Trường Đại học Công nghệ Thông tin (Phường Linh Trung, TP. Thủ Đức, TP.HCM)
- Link đăng ký: https://link.uit.edu.vn/AIConnect
- Buổi nói chuyện được chia làm 2 phần:
Phần 1: Giới thiệu về đào tạo và nghiên cứu về AI tại ĐHQG-HCM
Diễn giả:
1. TS. Lê Thành Sách – Trường Đại học Bách Khoa;
2. TS. Lê Khánh Duy – Trường Đại học Khoa học Tự Nhiên;
3. TS. Ngô Đức Thành – Trường Đại học Công nghệ Thông tin.
Phần 2: Xu hướng nguồn nhân lực AI
Diễn giả khách mời: Ông John Powell Adrian De Guzman - Trade Industry Development Specialist from National Government of the Philippines.",
                    Location = "Hội trường A, Trường Đại học Công nghệ Thông tin",
                    Type = "Conference", // "Training", "Workshop", "Seminar", "Webinar", "Conference", "Other"
                },
                new()  {
                    Title = @"[SEMINAR | Hybrid Minds: Radically Reimagining the Future of Intelligence] ",
                    Description = @"THÔNG TIN CHI TIẾT BUỔI SEMINAR: 
 ✏️Chủ đề: Hybrid Minds: Radically Reimagining the Future of Intelligence 
🎤Diễn giả: Dr. Olaf Witkowski
⏰Thời gian: 10h, Thứ 3 ngày 05/03/2024 
📍Địa điểm: phòng E1.1, Tòa E, Trường Đại học Công nghệ Thông tin ĐHQG-HCM 
🔑 Đối tượng tham gia: giảng viên và sinh viên 
Link form đăng kí: https://docs.google.com/.../1FAIpQLSdzbu2G.../viewform
Abstract about seminar 👇
⭐️ Intelligence isn’t just about acing exams, excelling at chess, or memorizing many books. It’s broader and may evolve in many different ways. In this talk, we will explore intelligence in a larger perspective, not just in humans but more generally in biology, AI, and other, possibly hybrid forms of life. 
🥸 We will discuss how two agents living in different substrates, such as humans, cells, or digital agents, may interact in a meaningful way. This perspective suggests thinking of diverse agents, including technological ones, not merely as tools for humans to use and offload computation to, but as true partners together with whom humans can increase their perception and cognition. This perspective invites a future where diverse minds unify to expand their understanding of reality.
Bio of Dr. Olaf Witkowski 👇
👨‍🎓Olaf Witkowski is a leading expert in empathic AI and Artificial Life based in Kyoto, Japan. 
🧑‍🏫He is the Founding Director of Cross Labs, a research institute in Japan, focusing on the study of intelligence in biological and synthetic systems. 
🤵‍♂️He is the President of the Board of Directors of the International Society for Artificial Life, Executive Officer at leading AI company Cross Compass, and Lecturer at the University of Tokyo. 
🌎He has co-founded multiple ventures in science and technology on three continents, including YHouse Inc. (nonprofit institute on the emergence of consciousness in the universe) and the Center for the Study of Apparent Selves (focusing on the Self in Buddhism and AI). 
📰His research focuses a mathematical understanding of intelligence in any substrate, which he uses to design hybrid living systems, empathic human-machine interfaces, open-ended paradigms for collective computing, and theories of connected minds
______________________ 
Mọi thông tin thắc mắc vui lòng liên hệ: 
🌎 Fanpage: Khoa Khoa học Máy tính UIT ",
                    Location = "phòng E1.1, Tòa E, Trường Đại học Công nghệ Thông tin ĐHQG-HCM",
                    Type = "Seminar", // "Training", "Workshop", "Seminar", "Webinar", "Conference", "Other"
                },
            ]
        },
        new() {
            Name = "Đội Công Tác Xã Hội Trường ĐH Công Nghệ Thông Tin",
            Description = @"Đội Công tác Xã hội Trường Đại học Công nghệ Thông tin, ĐHQG-HCM",
            FacebookUrl = "https://www.facebook.com/ctxh.uit",
            Email = "doictxh.uit@gmail.com",
            AvatarUrl = "https://tinyurl.com/doictxhuit",
            Events = [
                new()  {
                    Title = @"[TRẠI NÒI GIỐNG TIÊN RỒNG 2024 | FORM ĐĂNG KÝ]",
                    Description = @"🔗 Link đăng ký: https://forms.gle/sE7Ws6MjsAnvm8BH6
☀️ Nhằm chào mừng ngày lễ Giỗ Quốc tổ Hùng Vương (10/03 âm lịch), Ban Quản Lý Công viên Lịch sử Văn hóa Dân tộc chính thức tổ chức Hội trại truyền thống 'Tự hào nòi giống Tiên Rồng' lần thứ XV - 2024. Đồng thời, hội trại còn được diễn ra với mong muốn nâng cao nhận thức về truyền thống lịch sử dân tộc và bồi dưỡng lòng yêu nước, niềm tự hào về cội nguồn “nòi giống Tiên Rồng” trong lực lượng đoàn viên, thanh niên thành phố.
🌼 BTC mong rằng sẽ tạo được cho các bạn một sân chơi bổ ích, lành mạnh để rèn luyện kỹ năng sống, kỹ năng làm việc tập thể cũng như giao lưu học hỏi kinh nghiệm giữa các đơn vị tham gia hội trại.
———————————————
THÔNG TIN CHƯƠNG TRÌNH
👧 Số lượng: 30 
👨‍🎓 Đối tượng tham gia: Sinh viên UIT.
🔗 Link đăng ký: https://forms.gle/sE7Ws6MjsAnvm8BH6
💵 Chi phí: 160.000đ bao gồm tiền áo đồng phục cho tiểu trại UIT và chi phí ăn uống buổi tối (hoạt động nướng thịt).
⏰ Thời gian: Từ 05h30 ngày 18/04/2023 đến 10h00 ngày 19/04/2023.
#CTXH_UIT
#NOIGIONGTIENRONG2024",
                    Location = "Khu hội trại mới (Sân bãi bắn pháo hoa) - Đền Tưởng niệm các Vua Hùng thuộc Công viên Lịch sử - Văn hóa Dân tộc (KP. Vĩnh Thuận, P. Long Bình, TP. Thủ Đức).",
                    Type = "Other", // "Training", "Workshop", "Seminar", "Webinar", "Conference", "Other"
                },
                new()  {
                    Title = @"[ĐỘI - CTXH CUP 2.0]",
                    Description = @"⚽️ Link đăng ký: https://forms.gle/EhKu7dQDZRxSDoSB7
🔔 Cuối cùng thì ngày này cũng đã tới. Ta đã đợi cái ngày này lâu lắm rồi. Xin chào các bạn nhỏ tại CTXH CUP của taaa...
🏅 Với mục đích giao lưu, học hỏi và rèn luyện thể lực, giải bóng đá CTXH Cup 2.0 đã trở lại và chính thức mở form đăng ký từ ngày hôm nay. Các bạn trong Đội ai có đam mê thì hãy nhanh tay đăng ký ngay nhé!
🦵 Trước khi giải đấu bắt đầu, các bạn hãy đảm bảo duy trì sức khỏe thật tốt nha. Bên cạnh đó, cũng không quên luyện tập để sẵn sàng cho những trận đấu sắp tới với tinh thần fair-play nhé!
____________________________
THÔNG TIN GIẢI ĐẤU
⚽️ Link đăng ký: https://forms.gle/EhKu7dQDZRxSDoSB7
⌚ Thời gian thi đấu: 17h00 - 19h00 ngày 26, 28 và 30/03/2024 (Thứ 3, 5, 7)
🥅 Nơi thi đấu: Sân bóng đá KTX Liên hợp (sau KTX khu A)
💵 Lệ phí: 60k/người
👯 Đối tượng tham gia: CTV, TV và cựu Đội viên của Đội CTXH UIT
CƠ CẤU GIẢI THƯỞNG
🏆 Quán quân: Cúp + Huy chương
🎖️ Á quân: Huy chương
📢 Đặc biệt: Tham gia thi đấu được cộng điểm rèn luyện và có cơ hội được công nhận tiêu chí 'Thể lực tốt' để xét danh hiệu 'Sinh viên 5 Tốt'.
☎️ SĐT: 0795 499 579 (Trương Vĩnh Tiến - Nắm chính)
____________________________
Mọi thắc mắc xin liên hệ Đội qua:
📌 Fanpage: Đội Công Tác Xã Hội Trường ĐH Công Nghệ Thông Tin
✉️ Gmail: doictxh.uit@gmail.com
☎️ Hotline: 0941 712 574 (Phạm Thị Trâm Anh)
#CTXH_UIT
#CTXH_CUP",
                    Location = "Sân bóng đá KTX Liên hợp (sau KTX khu A)",
                    Type = "Other", // "Training", "Workshop", "Seminar", "Webinar", "Conference", "Other"
                },
                new()  {
                    Title = @"[GIÁP THÌN CHALLENGE | HOẠT ĐỘNG 1 - CÂY MAI ƯỚC MƠ]",
                    Description = @" Link Form: https://forms.gle/awZAbPCswJEUqwo68
 Link Template: http://bit.ly/4bkHviH
🧨 “Ô kìa! Như Tết đến đây rồi! 
Bánh chưng, bánh tét, lại gà, lại xôi... 
Khói bếp, trầm hương nghe ấm lạ! 
Bi bô tiếng trẻ rộn sân đời…” 
💌 Hòa chung không khí rộn ràng của những ngày đất trời chuyển vần chào đón Tết Giáp Thìn 2024, Đội CTXH UIT xin gửi đến toàn thể mọi người lời chúc sức khỏe, hạnh phúc và gặp nhiều may mắn, tài lộc, vạn sự như ý.
✨ Đặc biệt, hãy cùng Đội khắc nên sắc xuân với chuỗi hoạt động “Giáp Thìn Challenge” với 3 hoạt động vô cùng thú vị sẽ lần lượt được bật mí sau mỗi 2 ngày, từ mùng 1 đến mùng 6. 
💐 Ngay bây giờ, chúng ta sẽ khởi động với challenge đầu tiên nhé! Mùng một bừng hứng khởi với “Cây mai ước mơ” - nơi các bạn có thể gửi gắm những ước muốn, mục tiêu của mình trong năm mới. Hãy nhanh chóng tải về và chia sẻ cảm xúc đầu năm mới cùng chúng mình nào!
_____________________________________
CÁCH THỨC THAM GIA:
1️⃣ Like page và share bài viết ở chế độ công khai kèm hashtag: 
#CTXH_UIT
#GiapThinChallenge
2️⃣ Viết ước muốn của bản thân (có thể đính kèm lời chia sẻ, một bài hát, những bức ảnh,...) vào template và đăng lên story ở chế độ công khai. 
3️⃣ Điền thông tin vào form minh chứng với ảnh story và hoàn thành đầy đủ 3 challenge để nhận ngay điểm rèn luyện!
 Link Form: https://forms.gle/awZAbPCswJEUqwo68
 Link Template: http://bit.ly/4bkHviH
_____________________________________
Mọi thắc mắc xin liên hệ Đội qua:
📌 Fanpage: Đội Công Tác Xã Hội Trường ĐH Công Nghệ Thông Tin
✉️ Gmail: doictxh.uit@gmail.com
☎️ Hotline: 0941 712 574 (Phạm Thị Trâm Anh)
#CTXH_UIT
#GiapThinChallenge",
                    Location = "Online",
                    Type = "Other", // "Training", "Workshop", "Seminar", "Webinar", "Conference", "Other"
                },
                new()  {
                    Title = @"[GIÁP THÌN CHALLENGE | HOẠT ĐỘNG 2: GET TO KNOW ME]",
                    Description = @"🔗 Link form: https://forms.gle/qHbcaD9F3U4g91bk9
💨 Vèooo! Mới đó mà đã Mùng 3 rồi, hai ngày qua chúng mình rất vui khi nhìn thấy Cây Mai Ước Mơ được các bạn trang trí lên bởi những ước muốn, mục tiêu thật tuyệt vời. Đội CTXH chúc mọi người sớm đạt được những điều mà mình đã gửi gắm trên Cây Mai Ước Mơ nhé. 
🧧 Tiếp nối chuỗi Giáp Thìn Challenge, Đội mang đến cho các bạn một bộ câu hỏi trong template Get to know me - Lunar new()  Year Version. Chúng mình tin rằng, qua template xinh xắn này, các bạn sẽ có dịp chia sẻ với bạn bè những câu chuyện thú vị đó. Khi tham gia và thực hiện đầy đủ thể lệ, các bạn chắc chắn sẽ nhận được Điểm rèn luyện. Vậy nên, hãy share để hiểu nhau hơn và nhận ĐRL cùng chúng mình nàooo!
——————————————
CÁCH THỨC THAM GIA:
1️⃣ Like và Follow Fanpage Đội Công Tác Xã Hội Trường ĐH Công Nghệ Thông Tin
2️⃣ Thả cảm xúc và chia sẻ template lên trang cá nhân ở chế độ công khai kèm hashtag:
#CTXH_UIT
#GiapThinChallenge
3️⃣ Điền vào form minh chứng: https://forms.gle/qHbcaD9F3U4g91bk9
——————————————
Mọi thắc mắc xin liên hệ Đội qua:
📌 Fanpage: Đội Công Tác Xã Hội Trường ĐH Công Nghệ Thông Tin
✉️ Gmail: doictxh.uit@gmail.com
☎️ Hotline: 0941 712 574 (Phạm Thị Trâm Anh)
#CTXH_UIT
#GiapThinChallenge",
                    Location = "Online",
                    Type = "Other", // "Training", "Workshop", "Seminar", "Webinar", "Conference", "Other"
                },
                new()  {
                    Title = @"[CHIẾN DỊCH TÌNH NGUYỆN MÙA ĐÔNG YÊU THƯƠNG 2023 | TUYỂN CHIẾN SĨ]",
                    Description = @"🔗 Link đăng ký: https://forms.gle/mJ3XkicR7qFn7k639
🧣 Mỗi một mùa đông đến, người dân tại vùng đất Đắk Mil, tỉnh Đắk Nông đầy khó khăn lại phải tìm cách ứng phó với những cơn giá rét này. Những đôi chân run rẩy của các em nhỏ từng bước đến trường, những đôi bàn tay lạnh toát của các cụ già cùng tấm áo mong manh. Một hình ảnh mùa đông với những chiếc áo ấm cùng bếp than hồng có lẽ quá đỗi xa xỉ với người dân nơi đây.
⛄ Với Chiến dịch “Mùa Đông yêu thương 2023”, các chiến sĩ sẽ có cơ hội trao gửi yêu thương, mang lại một mùa đông ấm áp hơn đến với con người Đắk Mil phúc hậu, đặc biệt là các bạn nhỏ xinh xắn và đáng yêu nữa. Tất thảy vì một mục đích truyền thêm động lực và niềm tin để họ có thể vượt qua được những khó khăn giữa thời tiết lạnh lẽo này.
🙆‍♂️ Một bông hoa không thể làm nên mùa xuân, cũng như chỉ một người thì không thể làm nên “Mùa Đông yêu thương” được. Cho nên hãy trở thành một chiến sĩ Mùa Đông yêu thương 2023 bằng cách “giơ tay xung phong”, đăng ký qua link phía dưới nhé!
_________________________
THÔNG TIN TUYỂN CHIẾN SĨ:
🔗 Link đăng ký: https://forms.gle/mJ3XkicR7qFn7k639
🕛 Thời gian đăng ký: 04/12/2023 - 19/12/2023.
🙍 Đối tượng đăng ký chiến sĩ: Sinh viên địa bàn Thành phố Hồ Chí Minh.
🚨 LƯU Ý:
⚠️ Những trường hợp có đóng góp cho Chiến dịch 'Mùa Đông yêu thương 2023' (hoạt động gây quỹ,...) nhưng không điền form coi như là không tham gia.
⚠️ Đăng ký và gây quỹ đủ chỉ tiêu mới có thể trở thành “Chiến sĩ” chính thức.
_________________________
THÔNG TIN CHIẾN DỊCH:
🕛 Thời gian: Ngày 08/09/2023 - 31/12/2023.
📍 Địa điểm: Xã Thuận An, Huyện Đắk Mil, Tỉnh Đắk Nông.
🎬 Phóng sự Mùa Đông yêu thương 2023: https://tinyurl.com/MDYT2023-PhongSu
⛄️ Frame: twb.nz/mydt2023
_________________________
Mọi thắc mắc xin liên hệ Đội qua:
📌 Fanpage: Đội Công Tác Xã Hội Trường ĐH Công Nghệ Thông Tin
✉️ Gmail: doictxh.uit@gmail.com
☎️ Hotline: 0941 712 574 (Phạm Thị Trâm Anh)
#CHIENDICHTINHNGUYEN
#MĐYT2023
#CTXH_UIT",
                    Location = "Xã Thuận An, Huyện Đắk Mil, Tỉnh Đắk Nông",
                    Type = "Other", // "Training", "Workshop", "Seminar", "Webinar", "Conference", "Other"
                },
            ]
        },
        new() {
            Name = "Câu lạc bộ AI - khoa Khoa học Máy tính UIT",
            Description = @"Là một diễn đàn cho các sinh viên đam mê Trí tuệ nhân tạo học hỏi và chia sẻ kiến thức.",
            FacebookUrl = "https://www.facebook.com/uit.cs.aiclub",
            Email = "aiclub@uit.edu.vn",
            AvatarUrl = "https://tinyurl.com/clbaiclub",
            Events = [
                new()  {
                    Title = @"🔴 HỘI THẢO AI CONNECT chủ đề 'Giới thiệu về đào tạo và nghiên cứu về AI tại ĐHQG-HCM và Xu hướng nguồn nhân lực AI'",
                    Description = @"Buổi nói chuyện thuộc Chương trình Site Visit, do Trường Đại học Công nghệ Thông tin phối hợp với Trường Đại học Bách Khoa và Đại học Khoa học Tự nhiên tổ chức. Đây là hoạt động nằm trong khuôn khổ Hội thảo AI Connect II do Bộ Khoa học và Công nghệ phối hợp với Bộ Ngoại giao Hoa Kỳ thông qua Tổ chức phi chính phủ Atlantic Council (Hoa Kỳ) tổ chức.
Nội dung của Buổi nói chuyện: 'Giới thiệu về đào tạo và nghiên cứu về AI tại ĐHQG-HCM và Xu hướng nguồn nhân lực AI'
 - Thời gian: 9:30 – 12:00, Thứ Ba, ngày 23/4/2024.
- Địa điểm: Hội trường A, Trường Đại học Công nghệ Thông tin (Phường Linh Trung, TP. Thủ Đức, TP.HCM)
- Link đăng ký: https://link.uit.edu.vn/AIConnect
- Buổi nói chuyện được chia làm 2 phần:
Phần 1: Giới thiệu về đào tạo và nghiên cứu về AI tại ĐHQG-HCM
Diễn giả:
1. TS. Lê Thành Sách – Trường Đại học Bách Khoa;
2. TS. Lê Khánh Duy – Trường Đại học Khoa học Tự Nhiên;
3. TS. Ngô Đức Thành – Trường Đại học Công nghệ Thông tin.
Phần 2: Xu hướng nguồn nhân lực AI
Diễn giả khách mời: Ông John Powell Adrian De Guzman - Trade Industry Development Specialist from National Government of the Philippines.",
                    Location = "Hội trường A, Trường Đại học Công nghệ Thông tin",
                    Type = "Conference", // "Training", "Workshop", "Seminar", "Webinar", "Conference", "Other"
                },
                new()  {
                    Title = @"[SEMINAR: ĐỊNH HƯỚNG NGHIÊN CỨU: CÁI NHÌN TỪ NGƯỜI TRONG NGÀNH KHOA HỌC MÁY TÍNH] ",
                    Description = @"🔗 Link đăng ký: https://forms.office.com/r/mKQ3sT0VXb 
______________________ 
❓ Bạn có bao giờ tự hỏi về tầm quan trọng của việc nghiên cứu trong lĩnh vực Khoa học Máy tính không?  
❓ Bạn có muốn biết thêm về những cơ hội nghiên cứu tiềm năng trong ngành Khoa học Máy tính không?  
❓ Hay làm thế nào để xác định hướng đi trong một lĩnh vực đa dạng và phức tạp như vậy? 
⚡️ Đến với buổi seminar 'Định hướng nghiên cứu: Cái nhìn từ người trong ngành Khoa học Máy tính' do khoa Khoa học Máy tính tổ chức, bạn sẽ có cơ hội để khám phá và hiểu rõ hơn về định hướng nghiên cứu bên cạnh với định hướng ứng dụng.  
💥 Đây sẽ là một cơ hội độc đáo để mỗi người tham gia khám phá và hiểu rõ hơn về lĩnh vực nghiên cứu trong ngành Khoa học Máy tính, qua góc nhìn chuyên sâu của một chuyên gia trong lĩnh vực này. 
🌈 Khoa rất hân hạnh giới thiệu với các bạn diễn giả của buổi seminar, Tiến sĩ Nguyễn Trí Hải - một học giả tài năng và đầy nhiệt huyết. Anh hiện đang đảm nhận vị trí Nghiên cứu sau Tiến sĩ tại Đại học Khoa học và Công nghệ Quốc Gia Seoul, Hàn Quốc. Với bằng Tiến sĩ Khoa học và Kỹ thuật Máy tính từ Đại học Chung-Ang năm 2022, bằng Thạc sĩ Công nghệ Thông tin và Truyền thông từ Đại học Soongsil năm 2017, và bằng Cử nhân Khoa học máy tính hệ tài năng từ Đại học Công nghệ Thông tin ĐHQG-HCM năm 2015, anh Hải đã tạo dựng được một nền tảng vững chắc trong lĩnh vực Khoa học Máy tính. 
👨‍💻 Tiến sĩ Nguyễn Trí Hải đã đạt được nhiều thành tựu đáng chú ý trong lĩnh vực nghiên cứu của mình, trong đó có việc nhận giải thưởng bài báo xuất sắc tại Hội thảo quốc tế về hội tụ công nghệ thông tin và truyền thông (ICTC 2022). Không chỉ vậy, anh còn đóng góp công sức như một bình duyệt viên và thành viên ban chuyên môn cho nhiều tạp chí và hội thảo quốc tế uy tín, đồng thời cũng là thành viên trong ban biên tập của Tạp chí PLOS ONE. 
______________________ 
THÔNG TIN CHI TIẾT BUỔI SEMINAR: 
✏️ Chủ đề: ĐỊNH HƯỚNG NGHIÊN CỨU: CÁI NHÌN TỪ NGƯỜI TRONG NGÀNH KHOA HỌC MÁY TÍNH  
🎤 Diễn giả: Anh Nguyễn Trí Hải - Sinh viên K6 ngành Khoa học Máy tính  
⏰ Thời gian: 14h00, Thứ 4 ngày 01/11/2023  
📍 Địa điểm: Hội trường E, tầng 12 Tòa E, Trường Đại học Công nghệ Thông tin ĐHQG-HCM  
🔑 Đối tượng tham gia: Sinh viên UIT  
🔗Link đăng ký tham gia: https://forms.office.com/r/mKQ3sT0VXb 
Đừng bỏ lỡ cơ hội tuyệt vời này để khám phá, học hỏi và trao đổi kiến thức từ một chuyên gia hàng đầu trong lĩnh vực Khoa học Máy tính. Khoa rất mong được đón tiếp các bạn sinh viên tại buổi seminar này. 
______________________ 
Mọi thông tin thắc mắc vui lòng liên hệ: 
🌎 Fanpage: Khoa Khoa học Máy tính UIT",
                    Location = "Hội trường E, tầng 12 Tòa E, Trường Đại học Công nghệ Thông tin ĐHQG-HCM",
                    Type = "Seminar", // "Training", "Workshop", "Seminar", "Webinar", "Conference", "Other"
                },
                new()  {
                    Title = @"🎉🌈TUYỂN THÀNH VIÊN CLB AI👏",
                    Description = @"⚡Bạn đam mê, hứng thú với AI.
⚡Bạn muốn nâng cao kiến thức và tích lũy kinh nghiệm về AI/ML/DL thông qua trải nghiệm các cuộc thi và các dự án.
⚡Bạn muốn nhận những góp ý, chia sẻ kinh nghiệm từ các tiền bối, đặc biệt là tìm kiếm một mentor siêu cấp dễ thương, nhiệt tình😘.
⚡Bạn muốn tham gia vào các buổi workshop, seminar về các kiến thức hữu ích trong lĩnh vực này.
⚡Bạn muốn kết nối những người chung chí hướng cùng nhau thực hiện hoài bão tuổi trẻ này.
Vậy CLB AI chúng tớ chính là nơi bạn thuộc về đây! Còn chần chờ gì nữa mà không kết nạp vào ngay gia đình AI.✨
🎈Sau nhiều năm hoạt động, CLB AI đã ghi được nhiều ấn tượng trong những dự án cũng như những cuộc thi học thuật. Năm nay, chúng tớ mong muốn sẽ tìm được thêm những thành viên chất lừ để cùng chúng tớ viết tiếp hành trình này.
💁‍♀️Đến với lần tuyển thành viên này, CLB AI sẽ mang đến một format hoàn toàn mới khi được chia thành 3 team:
⭐Team Python
⭐Team Machine Learning
⭐Team Truyền thông và sự kiện
🥳Hãy nhanh tay điền form đăng kí và gửi chiếc CV xịn xò đến với CLB AI thôi nào!💕
-------------------------------------------------------------
📍Để tham gia, bạn chỉ cần thực hiện ba bước:
👉Thiết kế một chiếc CV thật xịn.
👉Điền form đăng ký: https://forms.gle/a8s8nxWpVhsJnurT8
👉Phỏng vấn cùng Ban chủ nhiệm.
-------------------------------------------------------------
📌Lưu ý:
Form chỉ mở đến 20h ngày 15/10/2023 nên mọi người hãy tranh thủ điền form đúng hạn nha.
Sau khi đăng ký, hãy luôn check mail để nhận được các thông tin từ CLB nhé.
------------------------------------------------------------
☎️ Mọi thắc mắc xin vui lòng liên hệ :
🏢 Văn phòng CLB: Phòng B8.02 Trường Đại học CNTT, ĐHQG TPHCM. 
📫Email: aiclub@uit.edu.vn",
                    Location = "Online",
                    Type = "Other", // "Training", "Workshop", "Seminar", "Webinar", "Conference", "Other"
                },
            ]
        },
        new() {
            Name = "UIT Open English Club",
            Description = @"𝐎𝐏𝐄𝐍 𝐄𝐍𝐆𝐋𝐈𝐒𝐇 𝐂𝐋𝐔𝐁 - 𝐎𝐏𝐄𝐑𝐀𝐓𝐄𝐃 𝐁𝐘 𝐒𝐓𝐔𝐃𝐄𝐍𝐓𝐒, 𝐅𝐎𝐑 𝐒𝐓𝐔𝐃𝐄𝐍𝐓𝐒",
            FacebookUrl = "https://www.facebook.com/oeclub.uit",
            Email = "oeclub.uit@gmail.com",
            AvatarUrl = "https://tinyurl.com/openengclub",
            Events = [
                new()  {
                    Title = @"[𝓔𝓷𝓰𝓵𝓲𝓼𝓱 𝓑𝓮𝓵𝓸𝔀] 🌟𝐎𝐄𝐂 - 𝐈𝐄𝐋𝐓𝐒 𝐒𝐏𝐄𝐀𝐊𝐈𝐍𝐆 𝐓𝐑𝐀𝐈𝐍𝐈𝐍𝐆🌟",
                    Description = @"Nếu bạn là một người yêu thích Tiếng Anh và có dự định thi IELTS, nhưng cảm thấy không tự tin về kỹ năng Speaking của bản thân và mong muốn có một sân chơi để học tập và rèn luyện? Chuyện gì khó đã có OEC lo😉
️🎉Hãy cùng OEC tìm hiểu xem bạn sẽ nhận được những điều bổ ích và thú vị gì trong buổi training này nhé.
📍TÀI LIỆU HỌC TẬP bổ trợ trước khi trải nghiệm một bài thi thử IELTS Speaking với các trainer tài năng của OEC. 
📍 Sau mỗi Part, các bạn sẽ nhận được những FEEDBACK chân thành để cải thiện kỹ năng Speaking của bản thân. 
📍 Ngoài ra, phần thi thử của các bạn cũng sẽ được RECORD, giúp các trainer góp ý chi tiết và đầy đủ hơn sau buổi training.
Còn chần chờ gì nữa mà không tham gia ngay kẻo hết slot đóoo! Đừng quên rủ thêm bạn bè để cùng ôn luyện nhé😍
Link đăng ký: https://forms.gle/5v2ifjFVsbCwuL8a6
Hạn chót đăng ký: 00h00, thứ năm ngày 16/05/2024
Số lượng tối đa: 12 người
Thông tin chi tiết về buổi training như sau:
🕛 Thời gian: từ 10h45 - 12h00, thứ sáu 17/5/2024
📌 Địa điểm: phòng B4.10, trường ĐH Công nghệ Thông tin",
                    Location = "phòng B4.10, trường ĐH Công nghệ Thông tin",
                    Type = "Training", // "Training", "Workshop", "Seminar", "Webinar", "Conference", "Other"
                },
                new()  {
                    Title = @"✨𝐎𝐄𝐂 𝐀𝐓 𝐔𝐈𝐓 𝐂𝐋𝐔𝐁 𝐅𝐄𝐒𝐓𝐈𝐕𝐀𝐋 𝟐𝟎𝟐𝟒 💥",
                    Description = @"Trò chơi? Đầy! 🎉
Quà tặng? Nhóc! 😻
Vui? Bao! 🥳
Nhờ sự ủng hộ của mọi người mà OEC đang có một gian hàng cực kỳ sôi động và thú vị trong hôm nay ngày hội 𝑼𝑰𝑻 𝑪𝑳𝑼𝑩 𝑭𝑬𝑺𝑻𝑰𝑽𝑨𝑳 🤍 
⏰ Thời gian: 8h00 - 11h00
🏢 Địa điểm: Sảnh C
Còn chần chờ gì mà không “set” ngay cái lịch hẹn với OEC để rinh ngay những phần quà hấp dẫn nào bạn ơi 🤗 Những phần quà hot nóng bỏng tay chỉ có số lượng có hạn thoai đóoo 🔥🔥🔥
------------------------------------
𝐎𝐄𝐂 - 𝐎𝐏𝐄𝐑𝐀𝐓𝐄𝐃 𝐁𝐘 𝐒𝐓𝐔𝐃𝐄𝐍𝐓𝐒, 𝐅𝐎𝐑 𝐒𝐓𝐔𝐃𝐄𝐍𝐓𝐒 🌻
📬 If you have any question, please do not 
hesitate to contact us:
📌Fanpage: https://www.facebook.com/oeclub.uit
💌Gmail: oeclub.uit@gmail.com",
                    Location = "Sảnh C",
                    Type = "Other", // "Training", "Workshop", "Seminar", "Webinar", "Conference", "Other"
                },
                new()  {
                    Title = @"[❗❗❗𝙃𝙊𝙏] 📸 '𝐈𝐓 𝐍𝐇𝐀̣̂𝐏 𝐍𝐆𝐔̃” - 𝐀 𝐩𝐡𝐨𝐭𝐨 𝐜𝐨𝐧𝐭𝐞𝐬𝐭 𝓫𝔂 𝓞𝓔𝓒 📹'",
                    Description = @"- 𝐵𝑖𝑒̂́𝑡 𝑜̂𝑛𝑔 𝐿𝑎̂̀𝑛 𝑘ℎ𝑜̂𝑛𝑔?
- 𝐿𝑎̂̀𝑛 𝑛𝑎̀𝑜?
❌ 𝐿𝑎̂̀𝑛 đ𝑎̂̀𝑢 𝑡𝑖𝑒̂𝑛 𝑡𝑟𝑎́𝑖...
✅ 𝐿𝑎̂̀𝑛 đ𝑎̂̀𝑢 𝑡𝑖𝑒̂𝑛 đ𝑖 𝑞𝑢𝑎̂𝑛 𝑠𝑢̛̣ 𝑎̆̃𝑚 𝑛𝑔𝑎𝑦 đ𝑖𝑒̂̉𝑚 𝑟𝑒̀𝑛 𝑙𝑢𝑦𝑒̣̂𝑛!!!
️✨Học kỳ quân sự 2023 của sinh viên UIT đã bắt đầu và đang bước vào giai đoạn “trọng đại” nhất.  Sau hơn 1 tuần khoác lên màu áo xanh, ắt hẳn những điều thú vị chắc chắn sẽ không dừng lại ở đó 🌿 Các bạn cảm thấy như thế nào nhỉ, có muốn biến những kỷ niệm ấy thành những thước phim tua chậm khó quên trong tuổi thanh xuân honggg 😉?
🍀 Hãy tham gia ngay cuộc thi ảnh “𝐈𝐓 𝐍𝐇𝐀̣̂𝐏 𝐍𝐆𝐔̃” của OEC, bạn sẽ có cơ hội ôn lại kỉ niệm đẹp cùng đồng đội cũng như may mắn mang về những phần thưởng cực kỳ giá trị đó nhaaa 😘
👨‍💻Đối tượng tham gia: Toàn bộ sinh viên UIT.
🎁Giải thưởng:
🥇 03 Giải đặc biệt: Điểm rèn luyện + móc khóa thương hiệu OEC
❗❗❗❗Đặc biệt: Tất cả các bạn sinh viên tham gia đều được cộng điểm rèn luyện.
📧Cách thức tham gia:
🌷 Bước 1: Theo dõi và nhấn Thích fanpage chính thức của OEC.
🌷 Bước 2: React này và share công khai bài viết này cho đồng đội cùng tham gia nhé. 
🌷 Bước 2: Comment ảnh về kì quân sự + tag 3 người bạn vào ngay bài viết này cùng với caption (tiếng Anh hoặc tiếng Việt), Nội dung về cảm nghiệm của bản thân trong kỳ quân sự, đồng thời truyền tải một thông điệp nào đó.
🌷 Bước 4: Kiểm tra thật kỹ lưỡng, trau chuốt từng tấm hình và con chữ của mình để dễ dàng “ôm” giải về tay. 
🌷 Bước 5: Điền form minh chứng sau nhé:
👉 Link: https://docs.google.com/.../1FAIpQLSdXimitJXW.../viewform...
💯Cách thức tính điểm:
Mỗi bài dự thi sẽ được đăng công khai dưới dạng comment ngay tại bài viết này của OEC, chấm điểm theo tiêu chí 50% vote và 50% ban giám khảo. Cụ thể về cách chấm điểm của lượt vote:
            📌Mỗi lượt reaction của comment (không tính lượt Phẫn nộ) tính 01 điểm.
🌼Các tiêu chí chấm của BGK: tính nghệ thuật của ảnh, nội dung, thông điệp truyền tải trên thang điểm 10. Nếu bài dự thi của bạn là tiếng Anh, bạn sẽ được cộng thêm điểm cho phần thông điệp 😉
⏳ Hạn chót nhận bài dự thi: 𝟐𝟑𝐡𝟓𝟗𝐩, 𝟐𝟐/𝟏𝟐/𝟐𝟎𝟐𝟐
🍀 Lời cuối cùng, OEC xin chúc các bạn UIT K18 sẽ cùng nhau tạo nên một mùa áo xanh thật đáng nhớ!
️💥 Và mn ơi, chần chừ gì nữa mà không tham gia nàoooo?
📸 Nguồn ảnh: Lê Văn Hùng
------------------------------------
𝐎𝐄𝐂 - 𝐎𝐏𝐄𝐑𝐀𝐓𝐄𝐃 𝐁𝐘 𝐒𝐓𝐔𝐃𝐄𝐍𝐓𝐒, 𝐅𝐎𝐑 𝐒𝐓𝐔𝐃𝐄𝐍𝐓𝐒 🌻
📬 If you have any questions, please do not hesitate to contact us:
📌Fanpage: https://www.facebook.com/oeclub.uit
💌Gmail: oeclub.uit@gmail.com",
                    Location = "Online",
                    Type = "Other", // "Training", "Workshop", "Seminar", "Webinar", "Conference", "Other"
                },
                new()  {
                    Title = @"[‼️- 𝓔𝓷𝓰𝓵𝓲𝓼𝓱 𝓫𝓮𝓵𝓸𝔀] OEC THÔNG BÁO TUYỂN THÀNH VIÊN 🔥",
                    Description = @"✨ Trong thời gian qua, OEC đã nhận được đông đảo sự chú ý từ những thành viên tương lai của câu lạc bộ. Để đáp lại sự nhiệt huyết đó, OEC xin hân hạnh thông báo rằng, chúng mình đã sẵn sàng để chào đón những con người có cùng một lòng đam mê cháy bỏng 😎 🔊🔊
🍀 Trong hành trình tìm kiếm những tài năng mới này, chúng mình mong muốn xây dựng một cộng đồng sử dụng tiếng Anh không chỉ đoàn kết, nhưng cũng thật sôi động, luôn luôn ngập tràn tiếng cười với những hoạt động vui nhộn 🥰 Vì thế, những con người năng động và sáng tạo đang đứng sau màn hình đây, bạn có thể là tương lai của OEC đấy!
✨ Đến với OEC, bạn sẽ không chỉ nhận được những kiến thức về tiếng Anh, nhưng bạn cũng sẽ có thể tìm thấy những chiến hữu, những người bạn mà ta có thể trò chuyện, chia sẻ những buồn vui với nhau trong quá trình học 🌐🗣️🦜
🍀 OEC tin rằng với sự giúp đỡ và phấn đấu từ tất cả các bạn, chúng ta sẽ có thể đưa OEC lên những tầm cao mới 🥳 Vậy, bạn còn chần chờ gì nữa? Hãy chia sẻ tin tức nóng hổi này cho friendlist của mình nào, hãy để sự tích cực này lan tỏa tới mọi người!
👉Sau đây, chúng mình sẽ giúp các bạn hiểu rõ hơn về 4 ngôi nhà của OEC nhaa  🥳 
📝Link đăng ký: https://forms.office.com/r/wru1DSSiyb
📆Thời gian đăng ký: 20h00 22/09 - 20h01 03/10 
📌Thời gian phỏng vấn: 14/10 ",
                    Location = "Online",
                    Type = "Other", // "Training", "Workshop", "Seminar", "Webinar", "Conference", "Other"
                },
            ]
        },
        new() {
            Name = "WebDev Studios",
            Description = @"WebDev Studios xin chào!",
            FacebookUrl = "https://www.facebook.com/webdevstudios.org",
            Email = "webdevstudios.org@gmail.com",
            AvatarUrl = "https://tinyurl.com/webdevuit",
            Events = [
                new()  {
                    Title = @"✨ [WEBDEV STUDIOS] | [WEBDEV ADVENTURE 2024] ✨
🎉 [24H ĐẾM NGƯỢC ĐẾN VÒNG CHUNG KẾT] 🎉",
                    Description = @"🥳 Vậy là thời gian diễn ra Vòng Chung kết của cuộc thi WebDev Adventure 2024 do CLB WebDev Studios tổ chức đang ngày càng đến gần. Không biết rằng các bạn thí sinh đã sẵn sàng thể hiện những kinh nghiệm, kiến thức mà mình đã tích lũy được để có thể tỏa sáng trong vòng thi cuối cùng này chưa?
🥰 Không khí trước thềm Chung kết đang diễn ra hết sức sôi nổi, chúng ta hãy cùng đếm ngược dòng thời gian để chuẩn bị tinh thần cổ vũ cho các đội thi xuất sắc này trong chặng đường tìm kiếm ngôi vô địch của mùa giải năm nay. Và hãy cùng nhau xem lại một số thông tin của Vòng Chung kết ngày mai nào.
📌 Thông tin chi tiết Vòng Chung kết:
⏰ Thời gian: 13h00, ngày 31/05/2024 (Thứ Sáu).
🏫 Địa điểm: Hội trường E, Trường Đại học Công nghệ thông tin – Đại học Quốc gia Thành phố Hồ Chí Minh.
🎁 Ngoài ra, khi tham dự, các bạn sẽ có cơ hội nhận được những phần quà đặc biệt đến từ BTC.
🔥 Còn chần chờ gì nữa mà không nhanh tay note ngay lịch trình cụ thể về thời gian, địa điểm tổ chức để có mặt đúng giờ. Và hẹn gặp lại các bạn tại Vòng Chung kết của cuộc thi WebDev Studios nhé!
---------------
📝 Mọi thắc mắc xin liên hệ: Trần Minh Chính - Chủ nhiệm CLB WebDev Studios 
🏢 Văn phòng : Phòng B804, tòa B, Trường ĐHCNTT 
🌐 Portfolio: webdevstudios.org 
🔗 LinkedIn: linkedin.com/company/webdev-studios-org/ 
📧 Email: webdevstudios.org@gmail.com 
☎️ Số điện thoại: 0968 134 049",
                    Location = "Hội trường E, Trường Đại học Công nghệ thông tin – Đại học Quốc gia Thành phố Hồ Chí Minh",
                    Type = "Other", // "Training", "Workshop", "Seminar", "Webinar", "Conference", "Other"
                },
                new()  {
                    Title = @"✨ [WEBDEV STUDIOS] | [WEBDEV ADVENTURE 2024] ✨
📢️ [THÔNG BÁO KẾT QUẢ VÒNG 2] 📢️ ",
                    Description = @"🔊 Vòng 2 của WebDev Adventure 2024 đã chính thức khép lại. Giờ đây, đường đua ngày càng gay cấn hơn khi Top 6 đội thi của chặng cuối đã được lộ diện.
🥰 Bên cạnh đó, BTC cũng xin gửi lời cảm ơn chân thành với tất cả các đội thi vì đã quan tâm và cố gắng hết mình trong suốt hành trình của WebDev Adventure 2024. Dù kết quả có ra sao, hy vọng các bạn vẫn luôn kiên trì và giữ vững niềm đam mê Lập trình Web. Chúng mình tin chắc rằng ai cũng đã có được những bài học, kinh nghiệm để có thể nâng tầm bản thân của mình trong tương lai. Và WebDev vẫn ở đây và chào mừng một phiên bản hoàn thiện của chính bạn trong những mùa thi sau.
🥳 Cuối cùng, xin chúc mừng TOP 6! Bước vào chặng đua cuối cùng, chúc các đội bình tĩnh, tự tin và hoàn thành tốt nhất bài thi của mình. Hãy sẵn sàng để tiến tới ngôi vị cao nhất của WebDev Adventure 2024 nhé!
----------------------------------
📝 Mọi thắc mắc xin liên hệ: Trần Minh Chính - Chủ nhiệm CLB WebDev Studios 
🏢 Văn phòng : Phòng B804, tòa B, Trường ĐHCNTT 
🌐 Portfolio: webdevstudios.org 
🔗 LinkedIn: linkedin.com/company/webdev-studios-org/ 
📧 Email: webdevstudios.org@gmail.com 
☎️ Số điện thoại: 0968 134 049",
                    Location = "Phòng B804, tòa B, Trường ĐHCNTT ",
                    Type = "Other", // "Training", "Workshop", "Seminar", "Webinar", "Conference", "Other"
                },
                new()  {
                    Title = @"✨ [WEBDEV STUDIOS] | [WEBDEV ADVENTURE 2024] ✨
📢️ [THÔNG BÁO KẾT QUẢ VÒNG 1️ - BẮT ĐẦU VÒNG 2]📢️ ",
                    Description = @"⏰ Sau bao ngày phát động cuộc thi WEBDEV ADVENTURE 2024, chắc hẳn các đội thi đều đang nóng lòng chờ kết quả của vòng 1 đúng không nào?
🎉 Không để các bạn đợi lâu, BTC xin chúc mừng các đội dưới đây đã hoàn thành xuất sắc vòng 1 và chiếm trọn tình cảm từ Ban Giám Khảo của WDA 2024.  
😘 Trong suốt khoảng thời gian vừa qua, BTC WDA 2024 rất vui vì đã nhận được những bài dự thi vô cùng chỉn chu và đầy tâm huyết đến từ các đội thi. Vậy nên các đội thi dừng chân tại vòng này cũng đừng buồn nha! Chúng mình tin rằng qua cuộc thi lần này, các bạn sẽ có trong mình những trải nghiệm đáng quý, những bài học mới mẻ và khó quên trong tháng ngày sinh viên tươi đẹp của mình. Hẹn gặp lại các bạn vào những sự kiện tiếp theo của WebDev Studios nhé! 🌹
📢️ Và để tiếp nối cho vòng 1, BTC xin thông báo Vòng 2 - XÂY DỰNG chính thức được khởi động. Ở vòng này, các đội thi sẽ bắt tay vào việc lập trình để thực hiện hóa những giải pháp đã đưa ra trong vòng 1.
🤩 BTC xin kính chúc cho tất cả các đội thi sẽ bước vào vòng 2 một cách suôn sẻ và thuận lợi. Fighting!!! 💪💪💪
--------------
📝 Mọi thắc mắc xin liên hệ: Trần Minh Chính - Chủ nhiệm CLB WebDev Studios 
🏢 Văn phòng : Phòng B804, tòa B, Trường ĐHCNTT 
🌐 Portfolio: webdevstudios.org 
🔗 LinkedIn: linkedin.com/company/webdev-studios-org/ 
📧 Email: webdevstudios.org@gmail.com 
☎️ Số điện thoại: 0968 134 049",
                    Location = "Phòng B804, tòa B, Trường ĐHCNTT ",
                    Type = "Other", // "Training", "Workshop", "Seminar", "Webinar", "Conference", "Other"
                },
                new()  {
                    Title = @"✨ [WEBDEV STUDIOS] | [WEBDEV ADVENTURE 2024] ✨
🎉 [CHÍNH THỨC PHÁT ĐỘNG CUỘC THI WEBDEV ADVENTURE 2024] 🎉",
                    Description = @"👉 Đăng ký ngay tại: https://adventure.webdevstudios.org/ 👈
👉 Hạn đăng ký: 23h59 ngày 13/04/2024. 👈
--------------------
🗓️ Tháng 3 này, WebDev Studios đã trở lại và nối tiếp sự thành công rực rỡ của cuộc thi WebDev Adventure 2023, chúng mình xin trân trọng thông báo:
🎊 Cuộc thi WEBDEV ADVENTURE 2024 xin chính thức được khởi tranh!!! 🎊
❤️ WEBDEV ADVENTURE 2024 là cuộc thi lập trình với tiền thân là WebDev Hackathon – cuộc thi lập trình Web và Mobile do CLB WebDev Studios tổ chức hằng năm với quy mô rộng lớn trên toàn quốc, là sân chơi dành cho các bạn học sinh, sinh viên đam mê và muốn thử sức mình trong lĩnh vực lập trình Web/App.
🏆 Trải qua 4 mùa, WebDev Adventure thành công tạo ra sân chơi quy tụ dàn thí sinh vô cùng chất lượng. Các đội đã có những phần thi hấp dẫn, gay cấn và cũng có những màn thể hiện vô cùng xuất sắc và tỏa sáng. Ban tổ chức cũng đã tìm ra được những đội thi xuất sắc nhất cho vị trí nhà vô địch.
🥳 Đến với mùa thứ 5 này, WebDev Studios hứa hẹn sẽ mang đến một sân chơi học thuật cạnh tranh đầy thú vị giữa các bạn có niềm đam mê lập trình Web/App. Đây cũng sẽ là cơ hội để các bạn có thể làm quen và tiếp xúc với nguồn tri thức vô tận, được trải nghiệm những điều mới lạ, học cách làm việc teamwork hiệu quả, có cơ hội thể hiện bản thân, khả năng và sự tâm huyết, cố gắng của mình trong suốt quá trình thi.
--------------------
📌 ĐỐI TƯỢNG THAM GIA:
🌟 Tất cả các bạn học sinh, sinh viên hiện đang theo học tại các Trường Đại học, Cao đẳng trên toàn quốc.
📌 HÌNH THỨC ĐĂNG KÝ:
👉 Đăng ký online trên website của cuộc thi: https://adventure.webdevstudios.org/
👉 Đăng ký offline tại sảnh C Trường Đại học Công nghệ thông tin - Đại học Quốc gia Thành phố Hồ Chí Minh vào lúc 9h30 đến 16h30, từ ngày 25/03 đến 06/04/2024.
📌 THỂ LỆ CUỘC THI:
➡️ Các đội thi có số lượng thí sinh từ 3 - 5 thành viên, trong đó có ít nhất 1 thí sinh thuộc Trường Đại học Công nghệ thông tin - Đại học Quốc gia Thành phố Hồ Chí Minh.
➡️ Các đội sẽ trải qua 3 vòng thi:
- Vòng 1️⃣: Ý TƯỞNG: Các đội thi sẽ phải lên ý tưởng để giải quyết yêu cầu được nêu trong đề bài, thiết kế các chức năng, chọn các công nghệ phù hợp với sản phẩm của mỗi đội.
- Vòng 2️⃣: XÂY DỰNG: Các đội thi sẽ hiện thực hóa ý tưởng ở Vòng 1, bằng cách lập trình Web hoặc App dựa trên những ý tưởng đã có.
- Vòng 3️⃣: CHUNG KẾT: Tại vòng này, các đội thi sẽ phải thuyết trình và trả lời các câu hỏi về sản phẩm của mình với các giám khảo nhằm chứng minh rằng sản phẩm, giải pháp của mình là phù hợp nhất với vấn đề mà đề bài yêu cầu.
➡️ Những đội vượt qua Vòng 2 của cuộc thi sẽ nhận được Giấy chứng nhận tiêu chí “Học tập tốt” trong Sinh viên 5 Tốt.
📌 LỆ PHÍ VÀ QUYỀN LỢI THAM GIA:
💸 Đối với sinh viên đăng ký tham gia cuộc thi:
 🔹Lệ phí: 50.000VNĐ/thí sinh.
 🔹Được tham gia các buổi workshop miễn phí.
💸 Đối với sinh viên đăng ký tham gia workshop:
 🔹Lệ phí: 20.000VNĐ/sinh viên.
💸 Ngoài ra, các bạn còn có thể hoàn thành lệ phí offline tại sảnh C của Trường Đại học Công nghệ thông tin - Đại học Quốc gia Thành phố Hồ Chí Minh từ ngày 25/03 đến ngày 06/04/2024.
🔥 Bên cạnh đó, WEBDEV ADVENTURE 2024 còn mang đến cho các bạn chuỗi Workshop về các chủ đề hấp dẫn liên quan đến ngành Công nghệ Thông tin nói chung và lập trình Web/App nói riêng.
😍 Nghe thật thú vị phải không nào? Vậy còn chần chờ chi nữa, hãy đăng ký ngay thôi!
🥇 Đội thi nào sẽ ghi tên mình vào vị trí quán quân của cuộc thi WEBDEV ADVENTURE 2024? Hãy cùng nhau like và follow page CLB WebDev Studios để cập nhật những thông báo về từng chặng của cuộc thi nhé!!! 
--------------------
📝 Mọi thắc mắc xin liên hệ: Trần Minh Chính - Chủ nhiệm CLB WebDev Studios 
🏢 Văn phòng : Phòng B804, tòa B, Trường ĐHCNTT 
🌐 Portfolio: webdevstudios.org 
🔗 LinkedIn: linkedin.com/company/webdev-studios-org/ 
📧 Email: webdevstudios.org@gmail.com 
☎️ Số điện thoại: 0968 134 049",
                    Location = "sảnh C Trường Đại học Công nghệ thông tin ",
                    Type = "Workshop", // "Training", "Workshop", "Seminar", "Webinar", "Conference", "Other"
                },
                new()  {
                    Title = @"✨ [WEBDEV STUDIOS | WEBDEV ADVENTURE 2024] ✨
🌟 [MINIGAME 1: “WEBDEV HỎI, BẠN TRẢ LỜI”] 🌟",
                    Description = @"“Tôi yêu CLB của tôi 🫶,
Một ngày thì sao? 🤔
Ngày chơi MINIGAMEEEEE đó 😍”
🥰 Mở đầu cho chuyến hành trình WebDev Adventure 2024 đầy thú vị và hấp dẫn của nhà WDS sắp tới là một Minigame nho nhỏ được chúng mình dày công chuẩn bị! Thông qua trò chơi lần này, WebDev Studios mong muốn sẽ đưa đến cho các bạn thật nhiều thông tin và kiến thức bổ ích mà bất kỳ UITers nào cũng không nên bỏ lỡ.
🥳 Tham gia ngay để có cơ hội rinh những món quà vô cùng hấp dẫn “về tay” các bạn nhé. Và đừng quên theo dõi Fanpage WebDev Studios để nhận được thông báo mới nhất về những sự kiện sắp tới của chúng mình nha!
-----------------------------
🌹 THỂ LỆ THAM GIA MINIGAME: 
🕐 Thời gian : từ 20h00 ngày 18/03/2024 đến 23h59 ngày 22/03/2024. 
💁 Đối tượng tham gia: Các bạn sinh viên thuộc các trường Đại học, Cao đẳng trên địa bàn TP.HCM.
📍 Hình thức: Giải mã các ô chữ hàng ngang bằng những câu hỏi gợi ý được Ban Tổ chức cung cấp và đưa ra từ khóa chính được yêu cầu. Sau đó, BTC sẽ tiến hành chọn một bạn có đáp án chính xác và nhanh chóng nhất cùng với con số may mắn sẽ được công bố tại Fanpage của CLB. 
🎁 Phần thưởng cho bạn may mắn nhất là 1 combo ấn phẩm đến từ CLB.
🌹 CÁCH THỨC THAM GIA MINIGAME: 
👉 Bước 1: Like và Follow Fanpage WebDev Studios.
👉 Bước 2: Comment trả lời 9 câu hỏi mà BTC đặt ra cùng với ô chữ hàng dọc được tô màu trên hình cùng với một con số may mắn từ 0 - 999 và tag tên 3 người bạn để mời họ cùng tham gia Minigame.
👉 Bước 3: Like và share bài viết này ở chế độ công khai kèm hashtag:
#WebDevStudios
#WebDevAdventure2024
👉 Bước 4: Chụp ảnh màn hình câu trả lời (không được chỉnh sửa) để điền đầy đủ vào đường dẫn Google Form BTC cung cấp.
📝 Link điền minh chứng: https://forms.gle/vy3vL5fU42w9gtKu8
🌹 CÂU HỎI GỢI Ý:
Câu 1️⃣: Ngôn ngữ lập trình được rất nhiều các lập trình viên sử dụng cho việc lập trình web là ngôn ngữ nào?
Câu 2️⃣: Một trong số những backend framework được viết bằng Python là gì?
Câu 3️⃣: Một trong những trình soạn thảo mã nguồn mở được nhiều lập trình viên hiện tại sử dụng là gì?
Câu 4️⃣: Trải nghiệm của người dùng đối với giao diện trên website gọi là gì? 
Câu 5️⃣: Hệ quản trị cơ sở dữ liệu NoSQL mã nguồn mở được nhiều lập trình viên sử dụng là gì?
Câu 6️⃣: Một hệ thống quản lý các phiên bản dưới dạng phân tán gọi là gì?
Câu 7️⃣: Một lập trình viên phụ trách cả FrontEnd, BackEnd cũng như các phần cần thiết khác của một dự án là gì?
Câu 8️⃣: Một hệ thống máy tính có địa chỉ IP tĩnh và khả năng xử lý cao được gọi là gì?
Câu 9️⃣: Kỹ thuật giúp website tương thích với nhiều độ phân giải màn hình gọi là 
🔥 Và cuối cùng, mọi người ghép hàng dọc ra kết quả gì nào???
🌹 QUYỀN LỢI THAM GIA:
🎁 Sinh viên thuộc Trường Đại học Công nghệ Thông tin - ĐHQG TP.HCM tham gia và hoàn thành Minigame theo đúng yêu cầu của Ban Tổ chức sẽ được ghi nhận điểm rèn luyện học kỳ 2 năm học 2023 - 2024 theo quy định.
‼️ LƯU Ý: 
💭 Trường hợp có nhiều câu trả lời đúng, BTC sẽ random để chọn ra 1 bạn may mắn nhất thông qua con số may mắn mà các bạn chọn để tiến hành trao giải.
-----------------------------
📝 Mọi thắc mắc xin liên hệ: Trần Minh Chính - Chủ nhiệm CLB WebDev Studios 
🏢 Văn phòng : Phòng B804, tòa B, Trường ĐHCNTT 
🌐 Portfolio: webdevstudios.org 
🔗 LinkedIn: linkedin.com/company/webdev-studios-org/ 
📧 Email: webdevstudios.org@gmail.com 
☎️ Số điện thoại: 0968 134 049",
                    Location = "Online",
                    Type = "Other", // "Training", "Workshop", "Seminar", "Webinar", "Conference", "Other"
                },
            ]
        },
        new() {
            Name = "Ban học tập Công nghệ Phần mềm",
            Description = @"Ban học tập Công nghệ Phần mềm là nơi chia sẻ tài liệu, kiến thức về CNTT dành cho các bạn sinh viên.",
            FacebookUrl = "https://www.facebook.com/bhtcnpm",
            Email = "bht.cnpm.uit@gmail.com",
            AvatarUrl = "https://tinyurl.com/bhtcnpmuit",
            Events = [
                new()  {
                    Title = @"☀️ [TỔNG KẾT TRAINING CUỐI KÌ II 2023-2024] ☀️",
                    Description = @"🤗 Vậy là những buổi training cuối cùng của năm học này đã kết thúc. Hy vọng rằng nó đã đem lại hành trang bổ ích cho các bạn sinh viên trong kì thi cuối kì sắp tới này.
❤️ Chân thành cảm ơn các bạn sinh viên đã đến tham gia các buổi training của Ban học tập. Chúc các bạn sẽ có kì thi thật suông sẻ và đạt được thành tích mình mong muốn.
🌸 Cuối cùng, mong rằng các bạn sẽ tiếp tục ủng hộ Ban học tập Công nghệ Phần mềm trong học kì tiếp theo nha!
➖➖➖➖➖➖➖➖➖➖
Mọi thắc mắc liên hệ tại:
💻 Website: https://www.bhtcnpm.com/
💌 Gmail: bht.cnpm.uit@gmail.com
💬 Fanpage: https://www.facebook.com/bhtcnpm
💓 Group BHT NNSC: https://www.facebook.com/groups/bht.cnpm.uit",
                    Location = "Microsoft Teams",
                    Type = "Training", // "Training", "Workshop", "Seminar", "Webinar", "Conference", "Other"
                },
                new()  {
                    Title = @"🔔[NHẮC NHỞ TRAINING CUỐI KÌ CẤU TRÚC RỜI RẠC] 🔔",
                    Description = @"💘 Tháng 6 bước sang báo hiệu một mùa thi nữa lại đến cùng các bạn UIT.
🏃‍♂️ Nếu bạn vẫn đang loay hoay trong hành trình “tìm đường đi ngắn nhất” hay vẫn đang lạc lối giữa những “chu trình” thì đừng quá lo lắng nhé.
🌟 Ban học tập Công nghệ Phần mềm chúng mình đến và gửi bạn một “bản đồ” là buổi training cuối kì Cấu trúc rời rạc ngay nè.
🎯 Note lại thông tin để nhận bản đồ đến với kho báu A+ ngay thôi nào.
 ➖➖➖➖➖➖➖➖➖➖➖
📌 Thông tin buổi training ONLINE:
⏰ Thời gian: 19h ngày 13/6/2024
⛳ Địa điểm: Microsoft Teams 
 🔒Code: w2dsy1q
🎤 Trainers:
- Nguyễn Tài Tấn - KHMT2023.4
- Ngô Lê Tấn Huy - MMTT2023.1
- Huỳnh Chí Hên - KTPM2023.1
➖➖➖➖➖➖➖➖➖➖➖    
Mọi thắc mắc liên hệ tại:
 💻Website: https://www.bhtcnpm.com/
💌 Gmail: bht.cnpm.uit@gmail.com
💬 Fanpage: https://www.facebook.com/bhtcnpm
💓 Group BHT NNSC: https://www.facebook.com/groups/bht.cnpm.uit",
                    Location = "Microsoft Teams ",
                    Type = "Training", // "Training", "Workshop", "Seminar", "Webinar", "Conference", "Other"
                },
                new()  {
                    Title = @"⭐ [NHẮC NHỞ TRAINING CẤU TRÚC DỮ LIỆU VÀ GIẢI THUẬT K18] ⭐",
                    Description = @"Chào mừng đến với chuyến tàu “ vượt ải DSA “ - bộ môn được coi là vô cùng khó nhằn đối với sinh viên. Tuy nhiên, đừng lo lắng, vì Ban học tập báo cho bạn một tin vui rằng sắp tới sẽ có chuỗi training lẫn online và offline nên các bạn đừng lo lắng nhé. Dĩ nhiên nội dung sẽ vô cùng bổ ích, giúp các bạn qua môn dễ dàng và gặt hái được những điểm số ấn tượng nữa đấy. 🤗
Còn ngại ngần gì mà không lưu ngay bài viết này lại để nhắc nhở bản thân tham gia. Đừng quên chia sẻ với bạn bè để cùng nhau “vượt ải DSA” thành công nhé.
Còn thông tin chi tiết thì ngay dưới nay đây! 👇
💎 Đối với Offline:
⏰ Thời gian: 9h30 12/06/2024
📍 Địa điểm: B1.14
🏅Trainer: 
+ Tiền Minh Dương - KTPM2023.1
+ Lê Ngô Thanh Toàn - KHMT2023.4
💎Đối với Online
⏰ Thời gian: 19h 12/06/2024
📍 Địa điểm: Code: w2dsy1q
🏅Trainer: 
+ Tiền Minh Dương - KTPM2023.1
+ Trương Đoàn Vũ - MMTT2022.3
✅ Tài liệu và slide bài giảng môn Cấu trúc dữ liệu và giải thuật sẽ được cập nhật trong bài 'Tài liệu training' sau buổi training, các bạn nhớ tải về xem lại để nắm vững kiến thức nhé.
☘ Chúc các bạn một ngày vui vẻ, và có một buổi ôn tập thật hiệu quả.
➖➖➖➖➖➖➖➖➖➖➖    
Mọi thắc mắc liên hệ tại:
💻 Website: https://www.bhtcnpm.com/
💌 Gmail: bht.cnpm.uit@gmail.com
💬 Fanpage: https://www.facebook.com/bhtcnpm
💓 Group BHT NNSC: https://www.facebook.com/groups/bht.cnpm.uit",
                    Location = "B1.14",
                    Type = "Training", // "Training", "Workshop", "Seminar", "Webinar", "Conference", "Other"
                },
                new()  {
                    Title = @"❤️‍🔥 [NHẮC NHỞ TRAINING CUỐI KÌ LẬP TRÌNH HƯỚNG ĐỐI TƯỢNG] ❤️‍🔥",
                    Description = @"🤔 Chắc hẳn không sinh viên UIT nào không biết đến Lập trình hướng đối tượng (OOP)- một môn học nền tảng quan trọng.
🏃‍♂️ Bước vào kì thi sắp tới với tâm thế còn nhiều suy tư, hoang mang trong môn học này là điều khó tránh khỏi.
📝 Nhưng thay vì lo lắng, loay hoay hãy đến ngay với 2 buổi training ONLINE và OFFLINE của Ban học tập khoa Mềm nào.
➖➖➖➖➖➖➖➖➖➖➖
📍 Thông tin buổi training OFFLINE:
⏰ Thời gian: 9h30 ngày 11/06/2024
🏫 Địa điểm: Phòng B1.14
🗣️ Trainers: 
+ Nguyễn Lê Tuấn Anh - KTPM2023.1
+ Quách Vĩnh Cơ - KTPM2023.1
📌Thông tin buổi training ONLINE:
⏰ Thời gian: 19h ngày 11/06/2024
⛳ Địa điểm: Microsoft Teams 
 🔒Code: w2dsy1q
🎤 Trainers:
+ Võ Chí Cường - KTPM2023.1
+ Quách Vĩnh Cơ - KTPM2023.1
➖➖➖➖➖➖➖➖➖➖➖    
Mọi thắc mắc liên hệ tại:
💻Website: https://www.bhtcnpm.com/
💌 Gmail: bht.cnpm.uit@gmail.com
💬 Fanpage: https://www.facebook.com/bhtcnpm
💓 Group BHT NNSC: https://www.facebook.com/groups/bht.cnpm.uit",
                    Location = "Phòng B1.14",
                    Type = "Training", // "Training", "Workshop", "Seminar", "Webinar", "Conference", "Other"
                },
                new()  {
                    Title = @"🔔 [THÔNG BÁO LỊCH TRAINING CUỐI Kì K18 HỌC KÌ II 2023 - 2024] 🔔",
                    Description = @"🍀 Xin chào các bạn,
🍀 Thế là một năm học nữa sắp kết thúc, để có một mùa hè tràn đầy niềm vui thì trước hết chúng mình nên có một kì thi với nhiều con điểm đẹp đúng không nhỉ? 🫣🫣
🍀 Sắp đến chúng mình sẽ tổ chức một chuỗi training cuối kì cho các bạn nhằm củng cố kiến thức, chia sẻ những tips hay và kinh nghiệm khi làm bài với mong muốn các bạn sẽ tự tin chiến hết mình khi bước vào phòng thi nhé! 🔥🔥
📑 Thông tin buổi training:
🔥 Lập trình hướng đối tượng (OOP):
⏰ Thời gian: ngày 11/06/2024
🏘️ Hình thức:
- Offline: vào lúc 9h30 tại phòng B1.14
- Online: vào lúc 19h00 tại MS Teams (Code: w2dsy1q)
🙋 Trainer:
- Offline: 
+ Nguyễn Lê Tuấn Anh - KTPM2023.1
+ Quách Vĩnh Cơ - KTPM2023.1
- Online: 
+ Võ Chí Cường - KTPM2023.1
+ Quách Vĩnh Cơ - KTPM2023.1
🔥 Cấu trúc dữ liệu và giải thuật (DSA):
⏰ Thời gian: ngày 12/06/2024
🏘️ Hình thức:
- Offline: vào lúc 9h30 tại phòng B1.14
- Online: vào lúc 19h00 tại MS Teams (Code: w2dsy1q)
🙋 Trainer:
- Offline: 
+ Tiền Minh Dương - KTPM2023.1
+ Lê Ngô Thanh Toàn - KHMT2023.4
- Online: 
+ Tiền Minh Dương - KTPM2023.1
+ Trương Đoàn Vũ - MMTT2022.3
🔥 Cấu trúc rời rạc:
⏰ Thời gian: ngày 13/06/2024
🏘️ Hình thức: 
- Online: vào lúc 19h00 tại MS Teams (Code: w2dsy1q)
🙋 Trainer:  
+ Ngô Lê Tấn Huy - MMTT2023.1
+  Nguyễn Tài Tấn - KHMT2023.4
+ Huỳnh Chí Hên - KTPM2023.1
🍀 Các bạn đừng quên note lại lịch train để tham gia cùng chúng mình nhé. Cuối cùng Ban học tập chúc các bạn có một mùa thi thành công, chào hè rực rỡ! 😍😍
➖➖➖➖➖➖➖➖➖➖➖    
Mọi thắc mắc liên hệ tại:
 💻Website: https://www.bhtcnpm.com/
💌 Gmail: bht.cnpm.uit@gmail.com
💬 Fanpage: https://www.facebook.com/bhtcnpm
💓 Group BHT NNSC: https://www.facebook.com/groups/bht.cnpm.uit",
                    Location = "B1.14, MS Teams",
                    Type = "Training", // "Training", "Workshop", "Seminar", "Webinar", "Conference", "Other"
                },
            ]
        },
        new() {
            Name = "Ban Học Tập Khoa Hệ Thống Thông Tin",
            Description = @"Đây là Fanpage chính thức của Ban học tập Khoa Hệ Thống Thông Tin trực thuộc Đoàn - Hội Khoa Hệ Thống Thông Tin",
            FacebookUrl = "https://www.facebook.com/BHTHTTT",
            Email = "bhthttt.uit@gmail.com",
            AvatarUrl = "https://tinyurl.com/bhthtttuit",
            Events = [
                new()  {
                    Title = @"🎉 [THÔNG BÁO LỊCH TRAINING CUỐI KỲ 2 - K18] 🎉",
                    Description = @"🌼 Chớ âu lo để làm gì?
Hè về là ta phải đi thôi
Tuổi xuân nào đâu có chờ đợi?
🎶 Giai điệu quen thuộc vang lên chắc hẳn đã khiến các bạn háo hức trông chờ vào kỳ nghỉ hè lắm rồi đúng không nào? Nhưng mà, dừng khoảng chừng vài giây…..Chúng mình còn phải vượt qua kỳ thi Cuối kỳ 2 trước khi “chạm tay đến mùa hè” đấy!
💖 Thấu hiểu được sự bối rối và khó khăn trong ôn tập lượng kiến thức “khổng lồ” cho kỳ thi sắp đến, BHT HTTT tổ chức Training ôn tập kiến thức giúp các bạn có cái nhìn tổng quát về những gì đã học, dễ dàng hệ thống kiến thức và có cơ hội gặp gỡ, trao đổi, chia sẻ kinh nghiệm cùng các bạn Trainer siêu nhiệt huyết đến từ BHT HTTT. 
👉 Nhanh tay lưu lại lịch Training và rủ rê bạn bè cùng đến ôn tập và chia sẻ cùng chúng mình nào! Cơ hội giải đáp thắc mắc và gặt hái điểm 10 đang trước mắt bạn đó 😉
--------------------------------------
[LỊCH TRAINING CUỐI KỲ 2 – K18]
CẤU TRÚC DỮ LIỆU VÀ GIẢI THUẬT - IT003
🕐 Thời gian: 2 buổi trong thứ 4, ngày 05/06/2024
Buổi 1: 14h30 - 16h30 (offline)
Buổi 2: 19h00 - 20h30 (online)
🌏 Địa điểm: 
+ Offline: phòng B1.18, tòa nhà B, Trường Đại học Công nghệ thông tin
+ Online: MS Teams: du2lo59
👨‍🏫 Trainer:
- Nguyễn Đoàn Thùy Trâm - HTTT2023
- Trần Lê Duy Tân - HTTT2023
LẬP TRÌNH HƯỚNG ĐỐI TƯỢNG - IT002
🕐 Thời gian: 9h00 - 11h00 thứ 5, ngày 06/06/2024
🌏 Địa điểm: phòng B1.18, tòa nhà B, Trường Đại học Công nghệ thông tin
👨‍🏫 Trainer:
- Dương Trọng Toàn - TMĐT2023
- Trần Thị Kiều Trâm - TMĐT2023
XÁC SUẤT THỐNG KÊ - MA005
🕐 Thời gian: 14h30 - 16h30 thứ 5, ngày 06/06/2024
🌏 Địa điểm: phòng B1.18, tòa nhà B, Trường Đại học Công nghệ thông tin
👨‍🏫 Trainer:
- Trần Thế Phong - HTTT2023
- Lương Đắc Nguyên - KHDL2023
- Nguyễn Khánh Vy - TMĐT2023
CẤU TRÚC RỜI RẠC - MA004
🕐 Thời gian: 9h00 - 11h00 thứ 7, ngày 08/06/2024
🌏 Địa điểm: phòng B1.18, tòa nhà B, Trường Đại học Công nghệ thông tin
👨‍🏫 Trainer:
- Đặng Hữu Thọ - HTTT2023
- Trương Dương Hiếu Thảo -  TMĐT2023
--------------------------------------
Mọi thắc mắc vui lòng liên hệ: 
💌 Email: bhthttt.uit@gmail.com 
🌏 Fanpage BHT HTTT: https://www.facebook.com/BHTHTTT",
                    Location = "phòng B1.18, tòa nhà B, Trường Đại học Công nghệ thông tin",
                    Type = "Training", // "Training", "Workshop", "Seminar", "Webinar", "Conference", "Other"
                },
                new()  {
                    Title = @"📢 [NHẮC THAM GIA TRAINING CẤU TRÚC DỮ LIỆU VÀ GIẢI THUẬT - DSA] ",
                    Description = @"🤔 Bạn muốn có học bổng? Bạn muốn nâng cao điểm số? Bạn muốn nắm vững kiến thức DSA?
💥Vậy thì đừng bỏ lỡ cơ hội tham gia buổi training DSA sắp tới nhé!!!! Tụi mình sẽ đồng hành cùng các bạn đi tới những chân trời kiến thức mới, cùng nhau chinh phục gian nan thử thách để đạt được những  thành tựu thật đáng mong chờ 🫶
👉 Và đừng quên “lôi kéo” thêm những đứa bạn chí cốt của mình nữa nha!
📝Note lịch lại ngay thoaii nè:
-------------------------
📌[LỊCH TRAINING DSA]
🗓️ Thứ 4 - 05/06/2024
Offline:
- Thời gian: 14h30 - 16h30. 
- Địa điểm: phòng B1.18
Online:
- Thời gian: 19h00 - 20h30.
- Địa điểm: MsTeam - du2lo59
-------------------------
Mọi chi tiết vui lòng liên hệ:
🌎 Fanpage Facebook: https://www.facebook.com/BHTHTTT
💌 Email: bhthttt.uit@gmail.com",
                    Location = "MsTeam - du2lo59",
                    Type = "Training", // "Training", "Workshop", "Seminar", "Webinar", "Conference", "Other"
                },
                new()  {
                    Title = @"💐 [NHẮC NHỞ THAM GIA TRAINING LẬP TRÌNH HƯỚNG ĐỐI TƯỢNG] 💐",
                    Description = @"🤔 Khái niệm về lớp, phạm vi truy xuất, tính kế thừa trong OOP là gì? 
Và còn vô vàn những câu hỏi ôn tập cùng bài giảng hệ thống kiến thức khác nữa. 
Bạn biết nên tìm chúng ở đâu chưa???
🎉 Không còn xa lạ qua những buổi tổ chức Training các kỳ, BHT HTTT đã trở lại để giúp bạn “đối đầu” với Hướng đối tượng khó nhằn này rồi đây!
👉 Tất cả những gì bạn cần làm là nhanh tay lưu lại lịch training, rủ rê bạn bè của mình và chuẩn bị để có một buổi training thật hiệu quả nhé. Các bạn trainer sẽ giải đáp những thắc mắc và hướng dẫn chúng mình cách học hiệu quả nữa đó! 😉
-----------------------------------------------------
LẬP TRÌNH HƯỚNG ĐỐI TƯỢNG - IT002
🕐 Thời gian: 9h00-11h00 thứ 5, ngày 06/06/2024
🌏 Địa điểm: phòng B1.18, tòa nhà B, Trường Đại học Công nghệ thông tin
👨‍🏫 Trainer:
Dương Trọng Toàn - TMĐT2023
Trần Thị Kiều Trâm - TMĐT2023
-----------------------------------------------------
Mọi thắc mắc vui lòng liên hệ: 
💌 Email: bhthttt.uit@gmail.com 
🌏 Fanpage BHT HTTT: https://www.facebook.com/BHTHTTT",
                    Location = "phòng B1.18, tòa nhà B, Trường Đại học Công nghệ thông tin",
                    Type = "Training", // "Training", "Workshop", "Seminar", "Webinar", "Conference", "Other"
                },
                new()  {
                    Title = @"🌻 [NHẮC NHỞ THAM GIA TRAINING CẤU TRÚC RỜI RẠC] 🌻",
                    Description = @"🩷 Các bạn đang loay hoay không biết làm sao có thể thoát ra khỏi mê cung của chu trình Euler và Hamilton? Các bạn đang cảm thấy lạc lõng giữa một lượng kiến thức khổng lồ của đại số Bool? Không sao cả, hãy để các “ngoan xinh iu” đến từ BHT HTTT giúp đỡ các bạn nhé!
⭐ Với buổi training cuối kỳ này, các bạn sẽ được các trainers hệ thống và củng cố lại những kiến thức trọng tâm cũng như cung cấp những mẹo hay để giải quyết bài tập và hình thành sự phản xạ nhanh với các dạng bài có thể được đề cập trong đề.
🎁 Còn ngần ngại gì mà không tham gia buổi training các bạn nhỉ? Và hãy mời thêm bạn bè để cùng nhau ôn tập lại kiến thức và có ngay những kỷ niệm đẹp với các thành viên trong BHT HTTT chúng mình nha!
--------------------------------
[LỊCH TRAINING CẤU TRÚC RỜI RẠC]
🌍 Địa điểm: Phòng B1.18 - Toà nhà B - Trường Đại học Công nghệ Thông tin - Đại học Quốc gia TP.HCM
⏰ Thời gian: Thứ 7 - Ngày 08/06/2024: 9h00 - 11h00 
🧑‍🏫 Trainers:
+ Đặng Hữu Thọ - HTTT2023
+ Trương Dương Hiếu Thảo -  TMĐT2023
--------------------------------
 Đừng quên like & follow fanpage BHT HTTT để nhận được những thông báo sớm và mới nhất nhé 😘
Mọi thắc mắc vui lòng liên hệ:
 𝑭𝒂𝒏𝒑𝒂𝒈𝒆 𝑭𝒂𝒄𝒆𝒃𝒐𝒐𝒌: https://www.facebook.com/BHTHTTT
 𝑬𝒎𝒂𝒊𝒍: bhthttt.uit@gmail.com",
                    Location = "Phòng B1.18 - Toà nhà B - Trường Đại học Công nghệ Thông tin - Đại học Quốc gia TP.HCM",
                    Type = "Training", // "Training", "Workshop", "Seminar", "Webinar", "Conference", "Other"
                },
                new()  {
                    Title = @"[TỔNG KẾT CHUỖI TRAINING CUỐI KỲ II & TÀI LIỆU]",
                    Description = @"'I'm working late cause my exams won’t….. procrastinate.'
🥹 Cuối cùng, chuỗi Training cuối kỳ II đã kết thúc, BHT HTTT xin chân thành cảm ơn sự quan tâm ủng hộ của các bạn trong thời gian vừa qua. 
📌 Trong những buổi training, chúng mình đã cùng nhau ôn lại những kiến thức trọng tâm và rèn luyện các kỹ năng làm bài cần thiết cho kỳ thi cuối kỳ. Đây là một hành trình đầy nỗ lực và sự quyết tâm từ tất cả chúng ta.
📚 Để hỗ trợ các bạn, chúng mình đã chuẩn bị một “món quà” đặc biệt. Đó là Tổng hợp tài liệu ôn tập của BHT: https://tinyurl.com/TaiLieu-BHT-HTTT
🤩 Bây giờ thì chúng mình cùng điểm qua những hình ảnh dễ thương trong mùa training này nha!
-------------------------------------
🥰 Đừng quên like & follow fanpage BHT HTTT để nhận được những thông báo sớm và mới nhất nhé! 
Mọi thắc mắc vui lòng liên hệ:
𝑭𝒂𝒏𝒑𝒂𝒈𝒆 𝑭𝒂𝒄𝒆𝒃𝒐𝒐𝒌: https://www.facebook.com/BHTHTTT
𝑬𝒎𝒂𝒊𝒍: bhthttt.uit@gmail.com",
                    Location = "Phòng B1.18 - Toà nhà B - Trường Đại học Công nghệ Thông tin - Đại học Quốc gia TP.HCM",
                    Type = "Training", // "Training", "Workshop", "Seminar", "Webinar", "Conference", "Other"
                },
            ]
        },
        new() {
            Name = "Đội Event - UIT",
            Description = @"Đội tổ chức sự kiện trực thuộc Hội Sinh viên trường Đại học Công nghệ Thông tin - ĐHQG Tp.Hồ Chí Minh",
            FacebookUrl = "https://www.facebook.com/UIT.EventTeam",
            Email = "doievent.uit@gmail.com",
            AvatarUrl = "https://tinyurl.com/eventuitteam",
            Events = [
                new()  {
                    Title = @"MẢNH GHÉP MỚI 2024 - 📢 MỞ FORM TUYỂN CHIẾN SĨ 📢",
                    Description = @"✨“Không có câu chuyện cổ tích nào đẹp hơn câu chuyện do chính cuộc sống viết ra.” (An-đéc-xen) ✨
🌟 Quả thực, cuộc sống này muôn hình muôn vẻ và mỗi khía cạnh đều có ý nghĩa, vẻ đẹp khác nhau. Và đó cũng là điều mà MGM 2024 hướng đến, chúng mình mong muốn mọi người đều sẽ có cho riêng mình một câu chuyện hạnh phúc từ cuộc sống của họ.
🫂 Tuy nhiên đâu đó ngoài kia, vẫn có những người chưa có được một câu chuyện đẹp trong đời mình, vẫn còn những đứa trẻ chưa có nổi một câu chuyện ấm áp để xây dựng lên tuổi thơ tươi đẹp của riêng chúng. Vì thế, với sứ mệnh cũng như tinh thần cống hiến hết mình cho cuộc sống, chúng mình - MGM 2024 - ở đây để đem những câu chuyện tươi đẹp ấy đến mọi người hay đơn giản là trở thành một mảnh ghép nhỏ trong câu chuyện đang cần trên thế gian này.
❤️‍🩹 Nếu bạn là một người có trái tim ấm áp, bạn mong muốn có thể giúp đỡ những mảnh ghép lẻ loi ngoài kia. Vậy thì chúng mình rất hoan nghênh bạn đến với đại gia đình MGM 2024. Chúng ta sẽ mang những mảnh ghép ý nghĩa để lấp đầy những câu chuyện chưa hoàn thiện của họ và rồi từ đây những câu chuyện đẹp nhất sẽ ra đời.
⭐ Hãy theo dõi thông tin dưới đây để không bỏ lỡ cơ hội trở thành một mảnh ghép của đại gia đình MGM 2024 các bạn nhé. Chúng ta sẽ gặp lại nhau trong thời gian tới, chúng mình rất mong chờ được thấy các bạn đó nha!
📌 THÔNG TIN TUYỂN CHIẾN SĨ:
Đối tượng tham gia: Tất cả sinh viên trên địa bàn Thành phố Hồ Chí Minh
Thời gian: Từ 20g00 ngày 19/02/2024 đến 20g00 ngày 26/02/2024
Thời gian phỏng vấn: ngày 28/02/2024 và 01/03/2024
Thời gian công bố kết quả (dự kiến): 03/03/2024
Địa bàn hoạt động: Xã Tân Xuân, huyện Ba Tri, tỉnh Bến Tre
Thời gian hoạt động tại địa bàn: 05 - 07/04/2024
Đường dẫn đăng ký: https://forms.gle/jLZLBV3L38f8Kkm38
🔥 Các bạn hãy theo dõi Fanpage Chiến dịch Tình nguyện Mảnh Ghép Mới để không bỏ lỡ những thông tin quan trọng từ chương trình, các bạn nhé. Chúng mình vẫn luôn đợi đến ngày được gặp các bạn, nên hãy đến với chúng mình, các bạn nha!
➖➖➖➖➖➖➖➖➖➖➖
☎️ Thông tin liên hệ:
🌐 Fanpage: https://www.facebook.com/CDTNManhGhepMoi.Fanpage
📧 Email: manhghepmoi.uit.ussh@gmail.com
📞 Hotline: 
        0343286085 (Trần Thị Mộng Trúc Ngân - Chỉ huy trưởng)
        0937824270 (Võ Thanh Vy - Chỉ huy phó)
        0386441295 (Tô Hoàng Huy - Chỉ huy phó)   ",
                    Location = "Xã Tân Xuân, huyện Ba Tri, tỉnh Bến Tre",
                    Type = "Other", // "Training", "Workshop", "Seminar", "Webinar", "Conference", "Other"
                },
                new()  {
                    Title = @"📢 [𝐄𝐕𝐄𝐍𝐓 𝐔𝐈𝐓| 𝐓𝐔𝐘𝐄̂̉𝐍 𝐓𝐇𝐀̀𝐍𝐇 𝐕𝐈𝐄̂𝐍]",
                    Description = @"🏮 Tết Trung thu từ trước đến nay vốn được biết là dịp để mọi người trong gia đình sum họp, quây quần bên nhau. Liệu Trung thu năm nay, bạn có muốn được đồng hành và sát cánh bên một gia đình mới - Đội Event UIT? 🏮
--------------------------------------------------
𝐓𝐇𝐎̂𝐍𝐆 𝐓𝐈𝐍 𝐂𝐇𝐔̛𝐎̛𝐍𝐆 𝐓𝐑𝐈̀𝐍𝐇:
📌 Link đăng ký: https://forms.gle/8n2hZzg8JVx4qgZdA
⌛ Thời gian đăng ký: Từ 20h00 ngày 29/9/2023 - 21h00 ngày 4/10/2023.
👥 Đối tượng: Sinh viên UIT.
⏰ Thời gian phỏng vấn: 8h00 - 16h00 ngày 6-7/10/2023.
🏤 Địa điểm: Phòng B1.04, Trường Đại học Công nghệ Thông tin, ĐHQG - HCM.
Event vẫn đang chờ những gương mặt mới, còn chần chờ gì mà không điền form đăng ký và tham gia cùng chúng mình nhé!
--------------------------------------------------
Mọi thắc mắc xin vui lòng liên hệ:
🌐 Fanpage: facebook.com/UIT.EventTeam
📧 Email: doievent.uit@gmail.com
📞 Hotline: 0828787952 - Nguyễn Duy Tân - Đội trưởng",
                    Location = "Phòng B1.04, Trường Đại học Công nghệ Thông tin, ĐHQG - HCM",
                    Type = "Other", // "Training", "Workshop", "Seminar", "Webinar", "Conference", "Other"
                },
                new()  {
                    Title = @"🌼 [𝗜𝗧’𝗦 𝗧𝗜𝗠𝗘 𝗧𝗢 𝗞𝗡𝗢𝗪] 🌼",
                    Description = @"💕 Một phiên bản mở đầu đầy hấp dẫn, hứa hẹn cho những chuỗi sự kiện, chương trình đầy thú vị sắp tới của Đội Event.
𝗧𝗛𝗢̂𝗡𝗚 𝗧𝗜𝗡 𝗖𝗛𝗨̛𝗢̛𝗡𝗚 𝗧𝗥𝗜̀𝗡𝗛:
⏰ Thời gian: Từ ngày 14/09/2023 - 21/09/2023.
💏 Đối tượng: Sinh viên Trường Đại học Công nghệ Thông tin, ĐHQG-HCM.
📌 𝗖𝗔́𝗖𝗛 𝗧𝗛𝗨̛́𝗖 𝗧𝗛𝗔𝗠 𝗚𝗜𝗔:
1️⃣ Like và follow Fanpage Đội Event - UIT.
2️⃣ Like + Share bài viết ở chế độ công khai kèm hashtag #EventUIT.
3️⃣ Chụp màn hình và điền form dưới đây để làm minh chứng bạn đã tham gia chương trình nhé.
👉 Form minh chứng: https://bit.ly/EventQuizz
Hãy cùng tham gia “𝗜𝘁’𝘀 𝘁𝗶𝗺𝗲 𝘁𝗼 𝗸𝗻𝗼𝘄” để lấy những “điểm rèn luyện” đầu tiên của năm học nào. ",
                    Location = "Online",
                    Type = "Other", // "Training", "Workshop", "Seminar", "Webinar", "Conference", "Other"
                },
                new()  {
                    Title = @"🌿Tham gia kẻo lỡ đèn xanh
Đi đi kẻo lỡ trò chơi bây giờ🌿",
                    Description = @"💓Các UITer của chúng mình ơi, không biết những hoạt động vừa qua có đem đến những điều thú vị và hấp dẫn cho các bạn không nè?
✨Bên cạnh những điều đó thì hôm nay chúng mình lại đem đến một sân chơi vô cùng náo nhiệt và lôi cuốn cho các bạn này. 
🤫Chương trình lần này sẽ được gọi tên là “SongkRun in UIT”, được lấy cảm hứng từ một chủ đề rất đặc biệt “Lễ hội té nước SongkRan của Thái Lan” kết hợp cùng với đường chạy sắc màu “Color Me Run”.
📌Chúng mình xin bật mí một chút xíu về trò chơi này nhé. Chương trình sẽ chia làm 2 dạng trò chơi là trò chơi nước và trò chơi màu với kiểu hoạt động sẽ là “Chạy trạm”. Nào nào, hồi hộp chưa?
📚Dưới đây là một số thông tin chi tiết
🏃Đường chạy SongkRun in UIT chỉ dành riêng cho K15, K16 và K17
💢Link đăng ký Online: bit.ly/DangKySongKrunUIT
✨ Các bạn có thể đăng ký offline tại sảnh C từ 11h30 - 1h30 (Từ ngày 13/10/2022).✨
🔔 Thể lệ chương trình
🔺 Mỗi team sẽ có 5 thành viên, các bạn có thể đăng ký theo đội (Nếu đăng ký lẻ thì BTC sẽ sắp xếp).
🔺Phí tham gia: 120.000VNĐ/người (Team 5 người 600.000 VNĐ). 5 Team đăng ký và hoàn thành lệ phí đầu tiên sẽ được giảm còn 500.000VNĐ/team.
💸Hoàn thành lệ phí tại bàn đăng ký đăng ký offline để nhận ngay cho mình một chiếc vé cùng chiếc áo đường chạy cực chất.
💓Các giải thưởng hấp dẫn:
💠 Giải Nhất: 1.500.000VNĐ 
💠 Giải Nhì: 1.200.000VNĐ
💠 Giải Ba: 1.000.000VNĐ
👉 Ngoài ra, các đội hoàn thành được công nhận tiêu chí “Thể lực tốt” của “Sinh viên 5 tốt”
💢Hứa hẹn những gì mà chúng mình đem lại sẽ cho bạn một sân chơi  “đầy tỏa sáng” và “cháy hết mình”.
🌷Còn chần chừ gì nữa? Biết đâu các bạn sẽ tìm được “mai - đẹt - ti - ni” của đời mình qua chương trình này đó.
❗Mau mau đăng ký nhanh thôi❗️",
                    Location = "UIT",
                    Type = "Other", // "Training", "Workshop", "Seminar", "Webinar", "Conference", "Other"
                },
                new()  {
                    Title = @"CODE CHALLENGE",
                    Description = @"Đừng quên chúng ta có cuộc hẹn vào ngày mai!!!
💥Ngày cuối cùng cho các bạn BOOK NGAY 1 VÉ ĐĂNG KÍ ĐỂ HOÀN THÀNH TIÊU CHÍ HỌC TẬP TỐT CHO DANH HIỆU SINH VIÊN 5 TỐT.
👉Tất cả các bạn làm được 4/6 bài sẽ được công nhận tiêu chí học tập tốt
👉Top 3 bạn giải nhiều bài và nhanh nhất
🥇Top 1: 1 chiếc balo UIT 15 năm
🥈Top 2: 500.000 VNĐ
🥉Top 3: 300.000 VNĐ
📌Thông tin chi tiết📌
📍 Thời gian thi: 8h00 - 13h00 ngày 11/06/2022
🧑‍💻Đối tượng: sinh viên UIT
💻Hình thức thi : Hệ thống wecode - Trực tuyến
🎫Phí đăng ký dự thi: 10k/sinh viên
📌Link đăng ký: https://forms.gle/GrARBrwkMs4ttpiS6
Hình thức thanh toán: momo hoặc đóng trực tiếp tại sảnh C (10h30 - 13h30 từ 8/6 - 10/6)",
                    Location = "B4.14",
                    Type = "Other", // "Training", "Workshop", "Seminar", "Webinar", "Conference", "Other"
                },
            ]
        },
          new() {
            Name = "UIT GamApp Studios",
            Description = @"UIT GamApp Studio - CLB Lập trình Game và ứng dụng - trực thuộc Đoàn Khoa Công nghệ phần mềm - ĐHCNTT - ĐHQG TP.HCM. Giá trị cốt lõi: CHIA SẺ - QUẢNG BÁ THƯƠNG HIỆU - GIÚP ĐỠ CỘNG ĐỒNG",
            FacebookUrl = "https://www.facebook.com/UITGamAppStudios",
            Email = "gamappuit.club@gmail.com",
            AvatarUrl = "https://tinyurl.com/uitgamapp",
            Events = [
                new()  {
                    Title = @"💫 [GAMELOFT] SEMINAR SẮP DIỄN RA RỒI!!! CÁC GAME DEVELOPER ƠI!!! 💫",
                    Description = @"‼️ Đúng vậy, Seminar “Get Ready For Your Gaming Career Path” do công ty Gameloft và CLB UIT GamApp Studios phối hợp tổ chức sẽ diễn ra trong ngày mai (07/06/2024).
✨ Đến với seminar, các bạn sẽ được học hỏi kinh nghiệm vào ngành từ diễn giả có thâm niên trong nghề – anh Nguyễn Anh Tuấn. Bên phía công ty còn dành ra một số phần quà cho các bạn tham gia tích cực trong buổi seminar nữa đó.
👀 BTC cũng bật mí cho các bạn rằng sẽ có THÔNG TIN về 1 CHƯƠNG TRÌNH HỖ TRỢ DỰ ÁN do Gameloft tổ chức tại buổi seminar. Nếu các bạn có ý tưởng cho dự án riêng nhưng thiếu hậu thuận thì đây là 1 CƠ HỘI không thể bỏ lỡ.
🔥 Nhanh chân lên nào các bạn ơi, seminar sắp diễn ra rồi!!!
 ——————————————————
       THÔNG TIN CHI TIẾT VỀ SEMINAR:
⏰ Thời gian: 9h45, thứ 6 ngày 7/6/2024.
📍 Địa điểm: Hội trường E, tầng 12 tòa E, trường Đại học Công nghệ Thông tin.
🎤 Diễn giả: Anh Nguyễn Anh Tuấn – Programmer Division Lead at Gameloft.
📌 Link đăng ký: https://tinyurl.com/seminar-grfygcp
🕤 Thời gian đăng ký: từ ngày 29/05/2024.
——————————————————
Mọi thắc mắc liên hệ tại:
 💻 Official Page: https://www.facebook.com/UITGamAppStudios
 📩 Gmail: gamappuit.club@gmail.com",
                    Location = "Hội trường E, tầng 12 tòa E, trường Đại học Công nghệ Thông tin",
                    Type = "Seminar", // "Training", "Workshop", "Seminar", "Webinar", "Conference", "Other"
                },
                new()  {
                    Title = @"📣 [CUỘC THI PHÁT TRIỂN ỨNG DỤNG SINH VIÊN ĐỢT 1 NĂM 2024 - SEApp2024] 📣",
                    Description = @"🤔  Bạn cần tìm một nơi:
👉 Giao lưu, trao đổi kiến thức, phát triển kỹ năng và phát triển đam mê trong hoạt động phát triển sản phẩm ứng dụng.
👉 Quảng bá rộng rãi những sản phẩm ứng dụng có hiệu quả sử dụng tốt do chính bạn thực hiện đến cộng đồng.
😉 Vậy thì “Cuộc thi phát triển ứng dụng sinh viên - SEApp2024” chính là dành cho bạn đó. 
🌟 Thông tin chi tiết cuộc thi:
⏰ Thời gian - địa điểm:
- Từ tháng 03 đến tháng 06 năm 2024.
- Địa điểm: Trường ĐH Công nghệ Thông tin, ĐHQG TP. HCM.
👩‍🎓 Yêu cầu: Sinh viên thực hiện sản phẩm là các ứng dụng có tính ứng dụng hoặc tính khoa học, nhằm mang lại lợi ích cho người sử dụng và có thể download, cài đặt trên các thiết bị di động (mobile app) hoặc các ứng dụng có thể được truy cập thông qua Internet (web app, website).
👩‍🎓 Đối tượng tham gia:
- Sinh viên khoa Công nghệ Phần mềm hoặc sinh viên các khoa khác (thuộc ĐH Công nghệ Thông tin) có quan tâm và được ban Tổ chức đồng ý.
- Sinh viên các khoa khác (thuộc ĐH Công nghệ Thông tin) có quan tâm và được ban Tổ chức đồng ý.
📌 Hình thức đăng ký: 
- Đăng ký qua form sau: https://tinyurl.com/SEApp2024
- Thời gian: Từ 20/03 đến 31/03/2024.
- Số lượng thành viên của đề tài: tối thiểu 01 thành viên, tối đa 06 thành viên.
➖➖➖➖➖➖➖➖➖         
📅 Các mốc thời gian liên quan:
- Tuần 01 – 02 (Từ 20/03 đến 31/03/2024): Mở form đăng ký.
- Tuần 03 – 11 (Từ 01/04 – 02/06/2024): Sinh viên đăng ký tiến hành hoàn thiện ứng dụng và tải ứng dụng lên CHPlay/AppStore của Khoa.
- Tuần 12 (Tuần 03/06/2024): Hội đồng của Khoa đánh giá và công bố các sản phẩm được triễn lãm.
- Tuần 13 (Tuần 10/06/2024): Chuẩn bị và tổ chức triển lãm các ứng dụng được chọn. Người dùng trải nghiệm sử dụng sản phẩm và đánh giá.
- Tuần 14 (Tuần 17/06): Tính điểm, công bố sản phẩm đoạt giải và trao thưởng.
✅ Tiêu chí đánh giá
- Tính khoa học và giá trị ứng dụng thực tiễn: 50%.
- Tính hoàn thiện: 20%.
- Tính thân thiện, dễ sử dụng và trải nghiệm người dùng: 20%.
- Trình bày báo cáo và kết quả: 10%.
💯 Cách tính điểm (cho các sản phẩm được chọn triển lãm)
- Like share trên Facebook: 20%.
- Lượt vote qua form: 20%.
- Điểm từ BGK: 60%.
🎁 Giải thưởng:
👉 Giải thưởng dành cho ứng dụng: bao gồm hiện kim, giấy khen và quà tặng.
- 01 giải Nhất: 5.000.000 VNĐ.
- 01 giải Nhì: 2.000.000 VNĐ.
- 02 giải Ba: 1.000.000 VNĐ.
- 03 giải Khuyến khích: 500.000 VNĐ.
- 01 giải có lượt download nhiều nhất: 500.000 VNĐ.
- 01 giải có lượt like/ share nhiều nhất: 500.000 VNĐ.
👉 Giải thưởng dành cho khán giả:
- 01 giải Bình chọn chính xác nhất: 500.000 VNĐ.
- 01 giải Rút thăm may mắn trong ngày tổ chức triển lãm: 200.000 VNĐ.
Còn chần chờ gì mà không tham gia ngay thôi nào!",
                    Location = "Trường ĐH Công nghệ Thông tin, ĐHQG TP. HCM",
                    Type = "Other", // "Training", "Workshop", "Seminar", "Webinar", "Conference", "Other"
                },
                new()  {
                    Title = @"CLB UIT GamApp Studio xin thông báo buổi học đầu tiên của project Game Gen3",
                    Description = @"CLB UIT GamApp Studio xin thông báo buổi học đầu tiên của project Game Gen3 sẽ bắt đầu vào:
- Địa điểm: phòng B1.22
- Thời gian: chiều thứ 7 hàng tuần, từ 13h15 - 14h30 (lớp Nhập môn) và từ 14h30-16h (lớp Nâng cao).
Mọi kênh thông tin liên lạc như group và group chat đã được gửi qua email đã đăng ký. Các bạn vui lòng kiểm tra hòm thư để nắm được thông tin từ CLB nhé!
Hẹn gặp lại các bạn vào ngày mai!",
                    Location = "phòng B1.22",
                    Type = "Training", // "Training", "Workshop", "Seminar", "Webinar", "Conference", "Other"
                },
            ]
        },
        new() {
            Name = "CLB Sách Và Hành Động UIT",
            Description = @"CLB Sách và Hành Động UIT",
            FacebookUrl = "https://www.facebook.com/clb.sachvahanhdong.uit",
            Email = "clb.sachvahanhdong.uit@gmail.com",
            AvatarUrl = "https://tinyurl.com/sachvahanhdonguit",
            Events = [
                new()  {
                    Title = @"HỘI SÁCH 2024 - Lịch sử: Trang sách và hành trình",
                    Description = @"Hoạt động 1: “Phiêu lưu cùng dòng chữ lịch sử”
🔔 THÔNG BÁO KẾT THÚC THỜI GIAN NHẬN BÀI - CHÍNH THỨC MỞ CỔNG BÌNH CHỌN 🔔
💨 Sau một tuần phát động, BTC đã nhận được rất nhiều bài dự thi vô cùng tiềm năng. Mỗi bài viết đều mang một màu sắc riêng biệt, thể hiện cá tính riêng không lẫn với bất kỳ ai.",
                    Location = "sảnh C, trường Đại học Công nghệ Thông tin – ĐHQG TPHCM",
                    Type = "Workshop", // "Training", "Workshop", "Seminar", "Webinar", "Conference", "Other"
                },
                new()  {
                    Title = @"📖 TỦ SÁCH ƯỚC MƠ - GIEO HẠNH PHÚC, THU NHẬN YÊU THƯƠNG 📖",
                    Description = @"Hành trình lan tỏa yêu thương, tạo nên dấu ấn vĩnh cửu trong hồi ức của người khác.
🌟 TỦ SÁCH ƯỚC MƠ -  một chặng đường đầy ý nghĩa và lan tỏa yêu thương. Mỗi bước đi nhỏ, mỗi đôi tay giúp đỡ và mỗi nụ cười trao đi, chúng ta đã tạo ra những dấu ấn vĩnh cửu trong lòng những người gặp gỡ. 
💬 Hai ngày 13/04 và 14/04 vừa qua, thành viên của CLB Sách và Hành Động các trường UIT, UEL và Nông Lâm đã có dịp ghé qua những địa điểm đặc biệt: Mái ấm Tân Bình, Làng thiếu niên Thủ Đức, Nhà trẻ mồ côi Diệu Giác. Ban đầu có vẻ bối rối do còn chút lạ lẫm, dần chúng mình đã thân thiết với nhau hơn sau các hoạt động giao lưu. Không khí hôm ấy đã rất sôi nổi và hạnh phúc.
🌱 Kệ sách đã được bố trí đầy đủ, tất cả loại sách, từ tài liệu học tập đến những quyển truyện tranh đã được bày lên. Hy vọng sự quyên góp nhỏ bé này có thể đem lại một kho kiến thức mới cho các em. Hình ảnh các bé đọc sách, vui chơi hôm ấy là một cảnh tượng ý nghĩa khó quên của chúng mình.
💌 Cảm ơn các bạn sinh viên đã ủng hộ chương trình TỦ SÁCH ƯỚC MƠ. Cảm ơn Mái ấm Tân Bình, Làng thiếu niên Thủ Đức, Nhà trẻ mồ côi Diệu Giác đã nhiệt tình chào đón và hướng dẫn chúng em. Chúc mọi người luôn khỏe mạnh, may mắn và hãy cùng nhau lan tỏa tinh thần yêu thương này nhé.
➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖
📍 THÔNG TIN CHI TIẾT VỀ CHƯƠNG TRÌNH:
📚 Hoạt động 1: “Thương”
⏰ 21/03/2024 – 23/03/2024: 
+ Nhận sách cũ tại sảnh C của UIT.
+ Bán vé số gây quỹ với giá 5.000đ/vé.
🎁 Cơ cấu giải thưởng:
+ 1 Giải nhất: 250.000đ
+ 2 Giải nhì: 150.000đ
+ 2 Giải ba: 100.000đ
🏆 Ngày công bố kết quả: 08/04/2024 tại Fanpage CLB Sách và Hành động UIT.
Mỗi tờ vé số bạn mua sẽ góp phần vào việc xây dựng một cộng đồng nhân ái và mang lại nụ cười cho các bé.
Sinh viên quyên góp 1 quyển sách sẽ được cộng vào điểm rèn luyện.
Với mỗi quyển sách quyên góp thêm, sinh viên sẽ được tặng lại 1 món quà nhỏ từ phía BTC.
🏩 Hoạt động 2: “Kết”
+ 13/04/2024 : Hoạt động hỗ trợ tại Mái ấm Tân Bình và Làng thiếu niên Thủ Đức.
+ 14/04/2024: Hoạt động hỗ trợ tại Nhà nuôi dạy trẻ mồ côi Diệu Giác.
❗️ Lưu ý:
+ Sách phải có giá trị sử dụng, giá trị thẩm mỹ và mang tính giáo dục.
+ Phù hợp với độ tuổi từ 6 đến 18 tuổi.",
                    Location = "sảnh C của UIT",
                    Type = "Other", // "Training", "Workshop", "Seminar", "Webinar", "Conference", "Other"
                },
                new()  {
                    Title = @"🏃‍♂️𝐒𝐏𝐑𝐈𝐍𝐆 𝐒𝐓𝐑𝐈𝐃𝐄 - NHẮC NHỞ CÒN 24 GIỜ ĐĂNG KÝ 🏃‍♂️",
                    Description = @"⏳Chú ý! Chú ý! … Thời gian còn 1 ngày ⏳
⏰Chỉ còn chưa đầy 24 giờ nữa, link đăng ký tham gia 𝐔𝐈𝐓 𝐒𝐏𝐑𝐈𝐍𝐆 𝐒𝐓𝐑𝐈𝐃𝐄 𝟐𝟎𝟐𝟒 sẽ tiến hành đóng lại. Vậy thì còn chần chờ gì mà không nhanh tay điền đơn tham gia 𝐔𝐈𝐓 𝐒𝐏𝐑𝐈𝐍𝐆 𝐒𝐓𝐑𝐈𝐃𝐄 𝟐𝟎𝟐𝟒 để cùng chúng mình chinh phục những mục tiêu đầy thú vị phía trước nhỉ? 
➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖
📍 THÔNG TIN CHI TIẾT VỀ SPRING STRIDE:
🏃‍♂️ Giải chạy ảo UIT SPRING STRIDE 2024 là giải chạy ảo thường niên do CLB Sách và Hành động UIT tổ chức, là chương trình tiếp nối cho UIT Run Over Yourself, UIT JUMPSTART 2022, UIT DYNAMIC YOUTH 2022 với mục tiêu tạo ra sân chơi lành mạnh cho những người có sở thích chạy bộ nói chung và các bạn sinh viên nói riêng; bên cạnh đó, người tham gia sẽ hình thành được thói quen rèn luyện sức khỏe, vượt qua bản thân, chinh phục những thử thách.
☑️ Hình thức đăng ký:
1. Đăng ký qua form: https://rg.link/xEeZe
2. Đăng ký trực tiếp tại tầng 1 toà B: 9h - 15h, từ ngày 20/02/2024 đến 23/02/2024.
❗️ Thời gian đăng ký: Từ ngày 19/02/2024 đến 23h59p ngày 25/02/2024.
❗️ Thời gian diễn ra: Từ ngày 20/02/2024 đến 23h59p ngày 05/03/2024.
☑️ Lệ phí tham gia: 25.000đ (Cá nhân) và 100.000đ (Nhóm 5 người)
☑️ Cách thức: thông qua ứng dụng Strava và nghienchaybo:
Quãng đường đăng ký tối thiểu: 30km-VĐV Nam; 25km-VĐV Nữ
Tốc độ trung bình: 4 phút/km – 15 phút/km (tốc độ này có thể đi bộ)
➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖
Mọi thắc mắc xin liên hệ:
📩 Email: clb.sachvahanhdong.uit@gmail.com
📌 Fanpage: CLB Sách Và Hành Động UIT
☎️ Mr. Hồng Phát: 098 1503 265
☎️ Ms. Mai Linh: 038 5038 142
☎️ Mr. Thiên Bảo: 091 6524 021
- Câu lạc bộ Sách và Hành động UIT -
✨ Trung thực ✨
✨ Hành động ✨
✨ Kỷ luật ✨
✨ Không bỏ cuộc ✨",
                    Location = "Khu đô thị ĐHQG TPHCM",
                    Type = "Other", // "Training", "Workshop", "Seminar", "Webinar", "Conference", "Other"
                },
                new()  {
                    Title = @"TUYỂN CTV GEN 7.0 - NGỠ",
                    Description = @"👥 TỔNG KẾT VÒNG 3: 'TEAM BUILDING' 👥
🎬 Cuối cùng chương trình tuyển CTV GEN 7.0 cũng đã chính thức khép lại. BAIT xin chân thành cảm ơn tất cả các bạn đã dành thời gian để tham gia cùng tụi mình.
🌅 Tuy thời tiết chiều hôm ấy không đẹp, nhưng chúng ta đã có những khoảnh khắc tuyệt vời cùng nhau! Tụi mình cảm thấy thật may mắn khi đã tìm ra được những mảnh ghép mới phù hợp trong rất nhiều ứng cử viên tiềm năng. Mong rằng chúng ta sẽ đồng hành với nhau lâu nhất có thể để có thể cùng tạo ra nhiều kỉ niệm đẹp trong bức tranh thanh xuân của mình.
🌼 Những bạn chưa thể đồng hành cùng tụi mình cũng xin hãy đừng buồn, có lẽ cánh cửa này chưa phải nơi phù hợp nhất với bạn. Tụi mình hi vọng bạn sẽ sớm tìm được nơi phù hợp nhất với bản thân và tiếp tục nỗ lực trong hành trình mới sắp tới.
🎥 Trong chương trình vừa qua nếu có vấn đề thiếu sót, mong mọi người thông cảm và có thể góp ý cho chúng mình thông qua thông tin liên hệ bên dưới đây nhé.
💕 Một lần nữa xin cảm ơn vì đã tích cực hưởng ứng và mong cho mọi điều tốt đẹp sẽ đến với tất cả mọi người!
— — — — — —
🔎 THÔNG TIN CHI TIẾT VỀ CHƯƠNG TRÌNH:
📧 Vòng 1: Điền Form
👥 Đối tượng: Tất cả sinh viên đang học tập tại địa bàn TP.HCM, những bạn có sở thích đọc và muốn lan tỏa ý nghĩa của từng trang sách thông qua văn hóa đọc.
🕰️ Thời gian: 2/10 - 8/10/2023
➡️ Link form: https://s.net.vn/lTCU 
----
🗣 Vòng 2: Phỏng Vấn
🕰️ Thời gian: 10/10 - 12/10/2023
🏠 BAIT sẽ gửi cho các bạn thời gian, địa điểm để chúng ta có thể gặp gỡ và trò chuyện trực tiếp với nhau.
----
🎲 Vòng 3: Team Building
🕰️ Thời gian: 17/10/2023
— — — — — —
Mọi thắc mắc xin liên hệ:
📩 Email: clb.sachvahanhdong.uit@gmail.com 
📌 Fanpage: CLB Sách Và Hành Động UIT
☎️ Mr. Gia Khiêm: 096 4078 132
☎️ Ms.Thùy Dương: 034 9414 587
☎️ Mr. Thanh Sang: 038 5350 187
- Câu lạc bộ Sách và Hành động UIT -
✨ Trung thực ✨
✨ Hành động ✨
✨ Kỷ luật ✨
✨ Không bỏ cuộc ✨",
                    Location = "Teams",
                    Type = "Other", // "Training", "Workshop", "Seminar", "Webinar", "Conference", "Other"
                },
                new()  {
                    Title = @"🎲 MINIGAME CÙNG BAIT 🎲",
                    Description = @"📍 Thông tin MINIGAME:
⏳ Thời gian: 06/10 - 08/10 (23h59')
👥 Đối tượng: Tất cả các bạn sinh viên UIT
🎲 Thể lệ tham gia:
Bước 1: Like fanpage CLB Sách và Hành động UIT, react và share bài viết này ở chế độ công khai
Bước 2: Comment câu trả lời đúng
Bước 3: Chọn 1 con số may mắn từ 1 - 999 và tag 03 người bạn cùng chơi nhé
Bước 4: Điền form kèm ảnh chụp cmt để chúng mình ghi nhận kết quả và tính điểm rèn luyện nhé
Link form:  https://forms.gle/fWSNYNUjM3bnRuU56
🎁 Giải thưởng:
▶️ 1 Giải nhất: Sách A-Z kiến thức nghề lập trình cho người mới bắt đầu
▶️ 1 Giải nhì: Sách Không Diệt Không Sinh Đừng Sợ Hãi
📦 CÁCH THỨC TÍNH GIẢI: BTC sẽ tiến hành quay số may mắn và chọn ra 2 bạn may mắn nhất để trao giải.
— — — — — — — —
⛳ Ngay bây giờ, hãy trả lời nhanh 8 câu hỏi sau và rinh quà về tay nào!
1. Tên viết tắt của CLB Sách và Hành động UIT là gì?
2. Hoạt động lớn nhất được CLB tổ chức vào tháng 5 hằng năm là gì?
3. Loại hình hoạt động lần sinh nhật gần nhất CLB đã tổ chức là gì?
4. Hoạt động chia sẻ được tổ chức nội bộ bởi thành viên CLB là gì?
5. Tiêu chí đầu tiên trong 4 giá trị cốt lõi của Sách và Hành động UIT là gì?
6. Tên của Chủ nhiệm hiện tại?
7. Hoạt động thiện nguyện vừa được CLB tổ chức là gì?
8. Năm thành lập của CLB Sách và Hành Động? 
🙋 Hy vọng sau minigame này BAIT có thể được nhiều sự quan tâm hơn nữa trong sự kiện “Tuyển CTV Gen 7.0 - NGỠ”.",
                    Location = "Online",
                    Type = "Other", // "Training", "Workshop", "Seminar", "Webinar", "Conference", "Other"
                },
            ]
        },
        new() {
            Name = "CLB Tiếng Nhật UIT - Wakame",
            Description = @"CLB WAKAME được thành lập với sự hỗ trợ của OEP, Hội SV-UIT, khoa KH&KTTT",
            FacebookUrl = "https://www.facebook.com/hcmuit.wakame",
            Email = "wakameuit@gmail.com",
            AvatarUrl = "https://tinyurl.com/clbtiengnhatuit",
            Events = [
                new()  {
                    Title = @"WAKAME UIT - THÔNG BÁO TỔ CHỨC SINH HOẠT CÂU LẠC BỘ",
                    Description = @"皆さん、注目してください！
Buổi sinh hoạt đầu tiên trong năm của Wakame, đồng thời là buổi đầu tiên do ban chủ nhiệm K5 tổ chức sắp diễn ra rồi. Mọi người có thấy hào hứng không nào😳?
Xin phép được bật mí, chủ đề của buổi sinh hoạt lần này là Ohanami - お花見🌸, một loại hình văn hoá rất đặc trưng của Nhật vào mỗi dịp xuân về. Đến với buổi sinh hoạt lần này, các bạn sẽ được tìm hiểu thêm về văn hoá ngắm hoa anh đào thông qua các từ vựng, trò chơi giải đố,... và cả những phần quà hấp dẫn(?) Mau mau đặt một cái hẹn đến với buổi sinh hoạt thoi nào!",
                    Location = "phòng B3.16, toà nhà B, trường Đại học Công nghệ Thông tin UIT",
                    Type = "Other", // "Training", "Workshop", "Seminar", "Webinar", "Conference", "Other"
                },
                new()  {
                    Title = @"THÔNG BÁO: TỔ CHỨC ĐẠI HỘI",
                    Description = @"✌️みなさん、こんにちは！！！
Chỉ còn 2 tuần nữa thoi, năm 2023 sẽ kết thúc, báo hiệu thời khắc chuyển giao thế hệ đang đến rất gần. Câu lạc bộ Tiếng Nhật UIT - WAKAME chúng mình cũng không phải ngoại lệ. Trong thời gian tới, ban chủ nhiệm thế hệ K4 sẽ dần lui về sau hậu trường sau 1 năm nhiệt huyết cống hiến tuổi thanh xuân 😱
Tuy nhiên, những 'mầm xanh 🌱' mà các anh chị K4 đã chăm sóc trong thời gian qua - thế hệ K5, sắp tới sẽ kế thừa những 'di sản' (không kém phần wibu 👀) mà anh chị để lại. Nhằm đánh dấu cho sự kiện quan trọng này, và cũng là để thông báo cho mọi người cùng biết, Wakame xin phép được tổ chức đại hội giao ban 🥳",
                    Location = "phòng B3.14, toà nhà B, trường Đại học Công nghệ Thông tin UIT",
                    Type = "Conference", // "Training", "Workshop", "Seminar", "Webinar", "Conference", "Other"
                },
                new()  {
                    Title = @"THI THỬ TIẾNG NHẬT JLPT",
                    Description = @"🫵 Phát hiện nhiều đối tượng lén lút tải nhiều tài liệu tiếng Nhật về để đó không học 🫵 
Để tránh cho bạn và tôi cùng nhau lãng phí thời gian như tình huống trên, chúng tôi quyết định giới thiệu một chương trình tuyệt cả là vời và vô cùng bổ ích nhằm tạo cơ hội để bạn có thể “rửa tài liệu”, sớm ngày chinh phục đỉnh cao Nhật ngữ 🌪️
💁‍♂️ Và chương trình đó chính là ✨THI THỬ TIẾNG NHẬT JLPT✨
Nội dung bài thi sẽ xoay quanh kiến thức về từ vựng, ngữ pháp, cụ thể là đánh giá kỹ năng nghe và đọc hiểu của người tham gia. Ngoài việc được trải nghiệm môi trường thực tế của một buổi thi tiếng Nhật với chi phí hạt dẻ, các thí sinh còn có khả năng nhận được giấy chứng nhận Hội nhập tốt để xét danh hiệu “Sinh viên 5 tốt” và mang hiện kim về nhà khoe mẹ. 
🫰 Sự kiện thú vị này đã mở cổng đăng ký, còn chần chừ gì nữa mà không tham gia nào 🫰",
                    Location = "Trường Đại học Kinh tế - Luật",
                    Type = "Other", // "Training", "Workshop", "Seminar", "Webinar", "Conference", "Other"
                },
                new()  {
                    Title = @"SINH HOẠT THÁNG 10",
                    Description = @"Chào tất cả các bạn,
Wakame rất mong muốn gặp gỡ các bạn thường xuyên và tạo ra được nhiều kết nối đông đảo hơn. Do đó, buổi sinh hoạt mà Wakame sắp mang tới sẽ là buổi sinh hoạt online trêng nền tảng Google Meet.",
                    Location = "Google Meet",
                    Type = "Other", // "Training", "Workshop", "Seminar", "Webinar", "Conference", "Other"
                },
                new()  {
                    Title = @"THAM GIA NGÀY HỘI TÂN SINH VIÊN 2023",
                    Description = @"Các bạn sinh viên yêu ơi!❤
💕Wakame UIT lại ngoi lên để gủ các bạn gặp gỡ tụi mình đây. 😊Với mong muốn sẽ lan tỏa sức sống wjbu và ngôn ngữ, văn hóa Nhật tới các bạn thì tại tầng 3 của Nhà văn hóa sinh viên, Wakame UIT có đặt bàn để giới thiệu CLB và không thể thiếu những trò chơi đầy chất Nhật Bản như là Sodoku, Kendama, Daruma, Caro XO.🎉
🙌Bên dưới là link đăng ký để Wakame tụi mình có thể đảm bảo việc check in cho các bạn nhé! Bạn nhớ ghé bàn của Wakame UIT để xác nhận thông tin nhen.🤞",
                    Location = "Nhà văn hóa sinh viên TPHCM",
                    Type = "Workshop", // "Training", "Workshop", "Seminar", "Webinar", "Conference", "Other"
                },
            ]
        },
        new() {
            Name = "UIT Media Club",
            Description = @"📸 Beyond mere media",
            FacebookUrl = "https://www.facebook.com/media.uit",
            Email = "photo@uit.edu.vn",
            AvatarUrl = "https://tinyurl.com/mediauit",
            Events = [
            ]
        }    
    ];
}
