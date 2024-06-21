using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UITEventAPI.Application.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AvatarUrl", "ConcurrencyStamp", "Email", "EmailConfirmed", "IsActive", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 1, 0, "https://picsum.photos/640/480/?image=764", "e89a4d07-ccb0-469a-b349-29cd63345a94", "NguyetAnh_Tran_Do@yahoo.com", true, true, false, null, "NGUYETANH_TRAN_DO@YAHOO.COM", "NGUYETANH_TRAN", "AQAAAAIAAYagAAAAEDj/V75yrAxJaJGVi+77dr5lFtH7lCRawtrfiqHxy/7vB7Ag5FM4hYI+DVhBHfpB0g==", "026 0239 6626", true, "5d6c7bcf-4978-4cf4-8fef-b7954bd11be9", false, "NguyetAnh_Tran" },
                    { 2, 0, "https://picsum.photos/640/480/?image=96", "960eafdd-0c88-46f8-8f8f-dab896c028d7", "NghiQuyen98.Vu22@gmail.com", true, true, false, null, "NGHIQUYEN98.VU22@GMAIL.COM", "NGHIQUYEN98", "AQAAAAIAAYagAAAAEIdnlldOMW2RCYww5Lox4RTcqGtHxQcaFS6amYphE3uPOjPsyFK6rHf4TxYRWGtfaQ==", "027 0053 2727", true, "6d782594-73b3-428f-a9b4-128f3622775b", false, "NghiQuyen98" },
                    { 3, 0, "https://picsum.photos/640/480/?image=633", "05e75069-5ca8-4177-99ef-47be626b487b", "PhuongGiang.Trinh56.Phan37@gmail.com", true, true, false, null, "PHUONGGIANG.TRINH56.PHAN37@GMAIL.COM", "PHUONGGIANG.TRINH56", "AQAAAAIAAYagAAAAEB1aJlCdno3BNnvj4D5TVVq464BA04u2eLaKsnMrl+aEVgEs9cfS6GmcqfcRoEkn+A==", "0286 0091 8742", true, "a3a103fe-540f-4cf8-8088-d7b16ee3ceb5", false, "PhuongGiang.Trinh56" },
                    { 4, 0, "https://picsum.photos/640/480/?image=378", "55d2ad22-d6cc-4993-8962-4050afe6a8bb", "QuangDanh.Ha.Nguyen47@gmail.com", true, true, false, null, "QUANGDANH.HA.NGUYEN47@GMAIL.COM", "QUANGDANH.HA", "AQAAAAIAAYagAAAAEK6eBxttM+9qAR2f2e7uE0x80Up0pw1tQknXvbQY4dhHSLV3ly1FkROkO9kE1AdkYw==", "0225 3575 5478", true, "1da0f84f-740b-4cdb-93f1-3b779d9fc456", false, "QuangDanh.Ha" },
                    { 5, 0, "https://picsum.photos/640/480/?image=271", "8f658ec8-9623-4ded-a8fc-34e2d973ce2c", "ThanhPhuong6295@yahoo.com", true, true, false, null, "THANHPHUONG6295@YAHOO.COM", "THANHPHUONG62", "AQAAAAIAAYagAAAAELRNvSnjdxHDuX1HiaxURUOY+RaZQ68ManvBl1nPXotLnoaF8XjVuKUCVp1WlGH+7Q==", "0219 3004 1908", true, "08e637f1-0c21-43e2-8aee-33710b822204", false, "ThanhPhuong62" },
                    { 6, 0, "https://picsum.photos/640/480/?image=692", "bc35357c-3967-49c9-a0f5-4feeed68863c", "TanThanh_Dao91_Dao@hotmail.com", true, true, false, null, "TANTHANH_DAO91_DAO@HOTMAIL.COM", "TANTHANH_DAO91", "AQAAAAIAAYagAAAAELe1WQ3UK9zAWn9sPxUISD/OP5yuFOj2dt37q0M+soDo1aTWxkSgQICjjWmLABpPwg==", "027 1751 7378", true, "502bd6ca-df72-438d-832b-c3f022dba566", false, "TanThanh_Dao91" },
                    { 7, 0, "https://picsum.photos/640/480/?image=27", "00a7100d-c79d-4829-bce6-c01ffa1900d6", "ThuyHuong.Mai95@yahoo.com", true, true, false, null, "THUYHUONG.MAI95@YAHOO.COM", "THUYHUONG.MAI", "AQAAAAIAAYagAAAAEDCglsOSJEJ05p/yoPBKcwfjUtZDqG+yxKaWSQaT+G0j+ihMXv5OnMfe5YgcTYMgkA==", "0284 9418 4838", true, "53276056-9d60-4109-b6a8-6434ab6665d4", false, "ThuyHuong.Mai" },
                    { 8, 0, "https://picsum.photos/640/480/?image=447", "142b7a27-0c34-44a6-84e3-8728cf1f822e", "ThienPhuoc.Ly.Duong@hotmail.com", true, true, false, null, "THIENPHUOC.LY.DUONG@HOTMAIL.COM", "THIENPHUOC.LY", "AQAAAAIAAYagAAAAEMlyjkmND1BdWOJQUJVQj73vKqcwZS6QOscO/u/5bABaBXBVDl+IEspD21ywMNE87g==", "0221 7165 0298", true, "09720120-1e4f-4597-9cab-bbede1b735db", false, "ThienPhuoc.Ly" },
                    { 9, 0, "https://picsum.photos/640/480/?image=13", "74394116-bb3f-4cb4-98e7-9ff19c1cb9dd", "TuyetHoa47_Do9@gmail.com", true, true, false, null, "TUYETHOA47_DO9@GMAIL.COM", "TUYETHOA47", "AQAAAAIAAYagAAAAEH+s9kSa9OFctQcqzI6V/je5i4diC7jjAh1BY6O2cC1MBCazbN7769O987BEFeQNhQ==", "0294 8126 6597", true, "363561a8-2fe7-477c-a179-85271561e14e", false, "TuyetHoa47" },
                    { 10, 0, "https://picsum.photos/640/480/?image=157", "00bcfbc3-8dc3-474c-b1e3-fdd5ddcaf589", "TuanHoang_Dinh72.Bui@gmail.com", true, true, false, null, "TUANHOANG_DINH72.BUI@GMAIL.COM", "TUANHOANG_DINH72", "AQAAAAIAAYagAAAAEFgidT4VhiO0yqhRjhzZNbpyG582RN0oBvnnwQ/cNsHyBjAD65OOnEKvFt6TQwGpIQ==", "0262 5692 0191", true, "641e8ec5-5b53-48b5-a391-d43077b2220f", false, "TuanHoang_Dinh72" },
                    { 11, 0, "https://picsum.photos/640/480/?image=622", "d8daadca-a4fe-419e-84b5-4b4fd0cd7e3b", "VanThanh_Nguyen_Ly33@gmail.com", true, true, false, null, "VANTHANH_NGUYEN_LY33@GMAIL.COM", "VANTHANH_NGUYEN", "AQAAAAIAAYagAAAAEGeMPMbeGqX6cV7M4/g4IUqyAwNx45djYIK4rTIslGYjsRJVYVp0wCrUobb+XhwGSA==", "023 0116 9489", true, "68818ab0-1010-4166-a510-62cbaf0dc3f8", false, "VanThanh_Nguyen" },
                    { 12, 0, "https://picsum.photos/640/480/?image=2", "4192881a-7a31-4e38-b7bc-304a099721e6", "XuanQuy1146@yahoo.com", true, true, false, null, "XUANQUY1146@YAHOO.COM", "XUANQUY11", "AQAAAAIAAYagAAAAEN6K2LqPVQVM4jFcLndnpYgwGuBpTu9zpHKTyO25HVxQ3c3IznJ3t5iNys0dNzyi8w==", "026 1887 3594", true, "ad9b0ed8-2c9b-4346-84d1-aae1cda746fb", false, "XuanQuy11" },
                    { 13, 0, "https://picsum.photos/640/480/?image=40", "6dbcbece-7bc9-44da-a9ef-72093fc8155b", "AnLai.Doan7_Trinh6@hotmail.com", true, true, false, null, "ANLAI.DOAN7_TRINH6@HOTMAIL.COM", "ANLAI.DOAN7", "AQAAAAIAAYagAAAAEOnU/eC5x8686JBySdsVG7M2vbAjzv5V4fD3kT83VqncjVuZP+5lMM6QV2yr2hIlSQ==", "0265 2013 0035", true, "3788d094-b93a-4abf-9a99-a6d6e386f5d6", false, "AnLai.Doan7" },
                    { 14, 0, "https://picsum.photos/640/480/?image=797", "f4a69218-2b61-4073-8b2e-198c8547f9ad", "CamHuong_Truong46@yahoo.com", true, true, false, null, "CAMHUONG_TRUONG46@YAHOO.COM", "CAMHUONG_TRUONG", "AQAAAAIAAYagAAAAECdzOmGX9j7f5F6Mxzs3B3WOOA/DSI9w3/gSFlgtMto1CylCFA7UfQ1ZswjNtPVCCQ==", "0246 3277 7760", true, "becf8cf5-a870-442a-8bd0-6b114c57594a", false, "CamHuong_Truong" },
                    { 15, 0, "https://picsum.photos/640/480/?image=133", "09875e1d-77af-476f-9942-40b99e51db00", "ChinhTruc75_Vuong@hotmail.com", true, true, false, null, "CHINHTRUC75_VUONG@HOTMAIL.COM", "CHINHTRUC75", "AQAAAAIAAYagAAAAEH///90gKppfZd1UkIuTTIfhNHyEb3EvKgLl5ZjTYZH0GsLjADyK2MKb43UoCyY/sA==", "0283 1924 3120", true, "3cb19a5b-cb0c-4743-b73a-750002151d9d", false, "ChinhTruc75" },
                    { 16, 0, "https://picsum.photos/640/480/?image=553", "3fb1c046-e4a8-4dac-8214-3773227252ab", "HoangLan_Ngo42_Nguyen@yahoo.com", true, true, false, null, "HOANGLAN_NGO42_NGUYEN@YAHOO.COM", "HOANGLAN_NGO42", "AQAAAAIAAYagAAAAEMRTu6ERl63QCO7uctvkQursQllL4UHJDFGvFFTZKeZC1tR4SlqXEwPmXdyScPIOoA==", "020 9671 0591", true, "33eebe9a-0b83-47b5-a2ca-97b3463e0bd2", false, "HoangLan_Ngo42" },
                    { 17, 0, "https://picsum.photos/640/480/?image=149", "daf599d6-f886-4b36-a9f4-d94bf4d5594b", "DucPhi.Lam_Bui@hotmail.com", true, true, false, null, "DUCPHI.LAM_BUI@HOTMAIL.COM", "DUCPHI.LAM", "AQAAAAIAAYagAAAAEC37AlBufL4mhiGcTbZGVjO77iyn7DXE3DhLnrB1tMhBowXcIk6YJ50O1uE1aY9XDg==", "025 8733 8605", true, "9d198391-a5be-48c1-8690-e72c7522e208", false, "DucPhi.Lam" },
                    { 18, 0, "https://picsum.photos/640/480/?image=226", "b5b9744e-c9d7-4836-aaa3-5d5230e679af", "HongKhoi.Tran.Vu20@gmail.com", true, true, false, null, "HONGKHOI.TRAN.VU20@GMAIL.COM", "HONGKHOI.TRAN", "AQAAAAIAAYagAAAAEBi5vKt7t+4KQjE82a+nx6DWCOJOmdNS+eQqCsNH6KP0Zc1WoijMkY8IvqBg7KvATQ==", "0255 0852 4112", true, "c42a3470-a4ae-4260-ba10-69164d2323b8", false, "HongKhoi.Tran" },
                    { 19, 0, "https://picsum.photos/640/480/?image=207", "46fb884c-18e6-4d6c-abd6-d53f499aa475", "HieuHoc61_Ly@hotmail.com", true, true, false, null, "HIEUHOC61_LY@HOTMAIL.COM", "HIEUHOC61", "AQAAAAIAAYagAAAAELVCShepxPr8TJgvT7/VT5Rz8z3N9bvUjoTkycD3TeK1xoBPsMfDggPoOVi7dqr+rQ==", "022 2363 2887", true, "e68bb1f2-1e4d-4f9f-908e-e50f9280b4b1", false, "HieuHoc61" },
                    { 20, 0, "https://picsum.photos/640/480/?image=514", "c667645b-4354-4639-b7b1-b4ad0f6e2ae1", "KieuTrinh_Vuong23.Mai@gmail.com", true, true, false, null, "KIEUTRINH_VUONG23.MAI@GMAIL.COM", "KIEUTRINH_VUONG23", "AQAAAAIAAYagAAAAEDd3itO6Splor4KsKbh7YlBWufWaIrLX4nn84GxIUSe11AOx9r9RnuGziATeC99b3w==", "0200 3895 2320", true, "5d4aa056-0d83-4623-b79c-b249a5e1267b", false, "KieuTrinh_Vuong23" },
                    { 21, 0, "https://picsum.photos/640/480/?image=483", "89a2d7f1-61db-42c0-b84e-42343aee8157", "HuuTu.Ha97@hotmail.com", true, true, false, null, "HUUTU.HA97@HOTMAIL.COM", "HUUTU.HA", "AQAAAAIAAYagAAAAEDs2OeXUqHernG1WlOXUYJH7WkXmAQB/t/RvmTDbOOfeSmm6B/BFUesBKXWi5YadOw==", "0207 8036 1602", true, "3d095317-407d-4f78-9bea-949caa19b7db", false, "HuuTu.Ha" },
                    { 22, 0, "https://picsum.photos/640/480/?image=903", "316494e5-2aa1-40fb-8c0a-746c44a936fb", "MinhTuyet25.Lam69@gmail.com", true, true, false, null, "MINHTUYET25.LAM69@GMAIL.COM", "MINHTUYET25", "AQAAAAIAAYagAAAAEMQ7tHmDttKr8GVwn465xtnWb18XqgUSVeM6Mefz9pa3lYwwm+6ti0D+2a3W5p/6jw==", "024 6793 7162", true, "d3f5d1b3-d460-43a2-93cf-10fcddcd33f9", false, "MinhTuyet25" },
                    { 23, 0, "https://picsum.photos/640/480/?image=947", "3754708e-aec0-4f0a-a009-68aa8a8b3dc6", "MinhAnh.Duong59_Hoang75@yahoo.com", true, true, false, null, "MINHANH.DUONG59_HOANG75@YAHOO.COM", "MINHANH.DUONG59", "AQAAAAIAAYagAAAAEKLbVPdk2DfIGrN4szbhzbPcy/TKCheo3L4gyylrzORrbc2gyUboqrTbU8WZXL5Udw==", "024 4403 5222", true, "0996f3d5-e792-4f78-90a8-ff6c3c282833", false, "MinhAnh.Duong59" },
                    { 24, 0, "https://picsum.photos/640/480/?image=659", "f23b5f76-fcfb-416c-b4e9-e29251174f1e", "NgocQuynh_Mai.Ngo@gmail.com", true, true, false, null, "NGOCQUYNH_MAI.NGO@GMAIL.COM", "NGOCQUYNH_MAI", "AQAAAAIAAYagAAAAEBff9kw+iNSG63XJ2/XOUGm4aZcNqTpXX5dv+Qf9cIYpY3IcCwOt+CPGc//iJkIW+A==", "0219 2197 0983", true, "82214693-e3b1-4951-b3ec-271ebdcc9045", false, "NgocQuynh_Mai" },
                    { 25, 0, "https://picsum.photos/640/480/?image=384", "00109bb6-8817-45c0-9382-63dd13a5fccd", "NguyenSu8998@yahoo.com", true, true, false, null, "NGUYENSU8998@YAHOO.COM", "NGUYENSU89", "AQAAAAIAAYagAAAAENkoFSu7Lie04ZJ43+7c4UpZHlM7J7n7c0wdJ9scZOx+VBg1k21V1a8RJgekNmwMIg==", "024 7984 4634", true, "1a6e33ea-6fa5-47af-a286-18a778b060ca", false, "NguyenSu89" },
                    { 26, 0, "https://picsum.photos/640/480/?image=294", "2f331f30-b6ff-4a06-9088-4480c85603d2", "PhuongVy.Do94.Duong@gmail.com", true, true, false, null, "PHUONGVY.DO94.DUONG@GMAIL.COM", "PHUONGVY.DO94", "AQAAAAIAAYagAAAAEEZWd4daKGDptRNpQCusGOLPJ/wsi6q11ypm8Ahq7Nlrw1nrHknXFX+NqTS5UBi/gg==", "0247 5912 7133", true, "fd199b5e-c2bb-4dd1-b01b-bf4f21ec48ca", false, "PhuongVy.Do94" },
                    { 27, 0, "https://picsum.photos/640/480/?image=442", "15d71969-09b3-4fb6-9d21-5668acfe8e37", "QuangVu.Dinh98@yahoo.com", true, true, false, null, "QUANGVU.DINH98@YAHOO.COM", "QUANGVU.DINH", "AQAAAAIAAYagAAAAEAgyvnpMrP+RYJ9KwRsDx3BAaZe/iD9XEo5TJm+SV7/HtWi07U4co4zfytyMDvX8fw==", "022 1515 8827", true, "a57c3065-0882-47eb-a7de-1d6ffc0dfb06", false, "QuangVu.Dinh" },
                    { 28, 0, "https://picsum.photos/640/480/?image=472", "deaa9353-8e9b-48cd-a93b-b6b1237a1280", "ThienThu_Pham.Pham@hotmail.com", true, true, false, null, "THIENTHU_PHAM.PHAM@HOTMAIL.COM", "THIENTHU_PHAM", "AQAAAAIAAYagAAAAEChHw6DWuS4BiNT5w1SG8X9IDZ5dciz4Fgg7itORlCtdOOhi96cu/jWu9kXXj3H++w==", "025 9380 5563", true, "71ba5f77-e1b0-4b87-a5fe-32c6811614df", false, "ThienThu_Pham" },
                    { 29, 0, "https://picsum.photos/640/480/?image=727", "789f171c-af15-47ac-ac0f-b1c16894e81d", "ThanhKien74_To56@gmail.com", true, true, false, null, "THANHKIEN74_TO56@GMAIL.COM", "THANHKIEN74", "AQAAAAIAAYagAAAAEAGbUlvxCzwF0HnVpoe0M+a2bddPkCO4GiMdaW5BQxOs/dT639dk4Mi7ELa1tKtKkA==", "0261 5521 0945", true, "d9a2e67d-d245-444a-8f67-894bcbd2fe6d", false, "ThanhKien74" },
                    { 30, 0, "https://picsum.photos/640/480/?image=1009", "4a11ed07-3b86-4626-b51f-f7932660d179", "ThaoVy_Doan75_Dang@hotmail.com", true, true, false, null, "THAOVY_DOAN75_DANG@HOTMAIL.COM", "THAOVY_DOAN75", "AQAAAAIAAYagAAAAEPtcvtr9vAQ1G6QvX6JW3MAi2Z5uun4nrUV0IOPZ0rUuGQdai/DYH3HsQ5fVFETu8Q==", "023 8209 7454", true, "898d20a0-1a34-4b64-9f51-286a3acadc96", false, "ThaoVy_Doan75" },
                    { 31, 0, "https://picsum.photos/640/480/?image=1015", "4fda3d59-46cd-40ba-9cb3-57112ca23b67", "TienHiep.To_Doan81@gmail.com", true, true, false, null, "TIENHIEP.TO_DOAN81@GMAIL.COM", "TIENHIEP.TO", "AQAAAAIAAYagAAAAELGtY6lR475OT2gqSFF4pdUm9gQGkIOCHPjUSz/F64inxG/69s8SvPcwWa6+Y50U2A==", "0216 9563 8253", true, "48dbb949-ad82-45f5-899c-fda436b66bb9", false, "TienHiep.To" },
                    { 32, 0, "https://picsum.photos/640/480/?image=765", "6a6761c1-ed1d-4df9-9ac9-46ed1535d906", "TuyLinh3849@yahoo.com", true, true, false, null, "TUYLINH3849@YAHOO.COM", "TUYLINH38", "AQAAAAIAAYagAAAAECB3arIWNOXib7//t7Q3vce5l9CGxEJsa2j1utoQWXwFpEzLaH9bfk9nsJapSgQlVQ==", "0208 4613 0385", true, "e7e6632e-493e-4949-b4ab-29b2504c136d", false, "TuyLinh38" },
                    { 33, 0, "https://picsum.photos/640/480/?image=1024", "04d35dd0-3ad2-4689-9fc4-2921fa9fc704", "VanTuyen_Ngo10.Vuong44@yahoo.com", true, true, false, null, "VANTUYEN_NGO10.VUONG44@YAHOO.COM", "VANTUYEN_NGO10", "AQAAAAIAAYagAAAAEBoccC2M6EK1U9p6tXuU/w8H8xHUMX2f0EkTPkpMk0uMFk4auIxBQgpbGwVuSLE/Yg==", "0223 6067 4502", true, "4812c55f-6721-4fe8-b40a-a39f621a7a6b", false, "VanTuyen_Ngo10" },
                    { 34, 0, "https://picsum.photos/640/480/?image=648", "63570aec-f461-4843-97aa-d17ce292ae45", "YenNhi_Lam49@yahoo.com", true, true, false, null, "YENNHI_LAM49@YAHOO.COM", "YENNHI_LAM", "AQAAAAIAAYagAAAAEEVeRwa1WQ1dUH1lpBxV4IiOqrDpo4t/CITomQcPb0gF72fyc/tUC8MplKsK4Y6YXg==", "028 3001 7210", true, "1f6eaf36-d603-494e-a8a2-68dd86a1c9ac", false, "YenNhi_Lam" },
                    { 35, 0, "https://picsum.photos/640/480/?image=677", "e4d8b552-4777-4484-aba9-f979b9df643c", "BichHai2.Le@gmail.com", true, true, false, null, "BICHHAI2.LE@GMAIL.COM", "BICHHAI2", "AQAAAAIAAYagAAAAEApmLUtvGaZeRc4SifXPvvkFTH9KH7F3gJyBVKLWRuvHXh3Mta0HeK1UJgYOh5q/ng==", "021 0766 4856", true, "e4967879-13a7-4b7f-aaba-7fbac94a77ee", false, "BichHai2" },
                    { 36, 0, "https://picsum.photos/640/480/?image=651", "77714fe6-a8e8-4274-9418-1891d4a0da85", "BaoBao.Dang45.Pham@gmail.com", true, true, false, null, "BAOBAO.DANG45.PHAM@GMAIL.COM", "BAOBAO.DANG45", "AQAAAAIAAYagAAAAEEaZBBCZcuSM+SGm7mPiOCloQqi9zKPi0LI5qskkbTSMaVvVLLUvbYYnW5CuyLTi2w==", "0285 3115 9362", true, "315f09d5-4a43-427f-acd2-0483834a79a3", false, "BaoBao.Dang45" },
                    { 37, 0, "https://picsum.photos/640/480/?image=695", "4dda4457-3a77-4d62-bd21-418391c4de05", "DieuHuyen.Vuong.To@hotmail.com", true, true, false, null, "DIEUHUYEN.VUONG.TO@HOTMAIL.COM", "DIEUHUYEN.VUONG", "AQAAAAIAAYagAAAAEO0lfjP+WYfdzSAwIH8JCbvV6Hel81Ldx+wCBytldbJldVB3ZezdnTD0+KA/LO49tw==", "0295 3078 1496", true, "3c015efd-3ac1-42e3-a6b5-78f65e134cab", false, "DieuHuyen.Vuong" },
                    { 38, 0, "https://picsum.photos/640/480/?image=30", "7a2e8a7f-e0ef-4e95-9249-f26b77416dff", "DanQue66_Dinh67@yahoo.com", true, true, false, null, "DANQUE66_DINH67@YAHOO.COM", "DANQUE66", "AQAAAAIAAYagAAAAEPz45b6R8sTffGCNeE66enwYOmUFvQpM5TqSk9AjsxoS+xm/iLFdyh2CAre1OvqZ6w==", "022 1725 7857", true, "ca2d3e6a-bfe2-4cf8-8a80-2fbbfcc6443c", false, "DanQue66" },
                    { 39, 0, "https://picsum.photos/640/480/?image=450", "b9801334-520b-46bb-ad13-fc7babc6278c", "HamNghi88.Doan@hotmail.com", true, true, false, null, "HAMNGHI88.DOAN@HOTMAIL.COM", "HAMNGHI88", "AQAAAAIAAYagAAAAEFiH8yqMaXFxPewUHLVTcrF74Gup8nN7vmQnJbRhooPbciBpoim5jDhXETEdS5e6BA==", "0260 9472 3217", true, "b4dfe8ae-8e4f-4718-99e4-c6dcf1a4dcfe", false, "HamNghi88" },
                    { 40, 0, "https://picsum.photos/640/480/?image=871", "c5765091-40b2-4c6c-b798-52c8436feec1", "DuyNgon.Duong26_Phung@yahoo.com", true, true, false, null, "DUYNGON.DUONG26_PHUNG@YAHOO.COM", "DUYNGON.DUONG26", "AQAAAAIAAYagAAAAELkAEl7LXdwQRYnMbdyx1YeLSeZg8D7P+yr6qCwIGHhQsnoGrXeIzJLYSexPbJFBOw==", "027 6129 0677", true, "3e05a530-17c6-4333-b54a-b33181160317", false, "DuyNgon.Duong26" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { 2, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 2, 4 },
                    { 2, 5 },
                    { 2, 6 },
                    { 2, 7 },
                    { 2, 8 },
                    { 2, 9 },
                    { 2, 10 },
                    { 3, 11 },
                    { 1, 12 },
                    { 1, 13 },
                    { 1, 14 },
                    { 1, 15 },
                    { 1, 16 },
                    { 1, 17 },
                    { 1, 18 },
                    { 1, 19 },
                    { 1, 20 },
                    { 1, 21 },
                    { 1, 22 },
                    { 1, 23 },
                    { 1, 24 },
                    { 1, 25 },
                    { 1, 26 },
                    { 1, 27 },
                    { 1, 28 },
                    { 1, 29 },
                    { 1, 30 },
                    { 1, 31 },
                    { 1, 32 },
                    { 1, 33 },
                    { 1, 34 },
                    { 1, 35 },
                    { 1, 36 },
                    { 1, 37 },
                    { 1, 38 },
                    { 1, 39 },
                    { 1, 40 }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "CreatedByUserId", "CreatedDate", "DateOfBirth", "FirstName", "LastModifiedByUserId", "LastModifiedDate", "LastName", "StudentCode", "UserId" },
                values: new object[,]
                {
                    { 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1954, 12, 25, 2, 0, 15, 906, DateTimeKind.Local).AddTicks(6436), "Minh Cảnh", null, null, "Lâm", 117008, 19 },
                    { 2, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2004, 2, 4, 2, 39, 42, 897, DateTimeKind.Local).AddTicks(6163), "Ðông Nguyên", null, null, "Hà", 114850, 34 },
                    { 3, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2002, 12, 16, 5, 44, 57, 334, DateTimeKind.Local).AddTicks(1939), "Tú Tâm", null, null, "Hoàng", 256865, 20 },
                    { 4, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 5, 7, 6, 33, 53, 639, DateTimeKind.Local).AddTicks(9411), "Phương An", null, null, "Bùi", 282592, 36 },
                    { 5, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 12, 6, 9, 29, 38, 761, DateTimeKind.Local).AddTicks(3607), "Hải Hà", null, null, "Đoàn", 189498, 22 },
                    { 6, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 5, 16, 15, 43, 54, 975, DateTimeKind.Local).AddTicks(7158), "Ái Nhân", null, null, "Phùng", 205913, 37 },
                    { 7, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 11, 27, 13, 14, 20, 188, DateTimeKind.Local).AddTicks(5190), "Thanh Trang", null, null, "Nguyễn", 233256, 23 },
                    { 8, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1975, 5, 17, 11, 35, 42, 433, DateTimeKind.Local).AddTicks(968), "Hữu Minh", null, null, "Phan", 256344, 38 },
                    { 9, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 11, 17, 16, 59, 1, 615, DateTimeKind.Local).AddTicks(6787), "Bình Quân", null, null, "Hồ", 279431, 24 },
                    { 10, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 11, 13, 6, 51, 22, 329, DateTimeKind.Local).AddTicks(2463), "Thư Sương", null, null, "Trịnh", 102518, 40 },
                    { 11, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 11, 8, 20, 43, 43, 42, DateTimeKind.Local).AddTicks(8207), "Mạnh Dũng", null, null, "Tô", 214216, 25 },
                    { 12, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1960, 5, 13, 22, 10, 36, 609, DateTimeKind.Local).AddTicks(1957), "Ðình Quảng", null, null, "Lê", 175876, 39 },
                    { 13, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 10, 30, 0, 28, 24, 469, DateTimeKind.Local).AddTicks(9666), "Tâm Ðoan", null, null, "Tăng", 188560, 26 },
                    { 14, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 8, 16, 2, 4, 47, 351, DateTimeKind.Local).AddTicks(5053), "Nhật Linh", null, null, "Dương", 226078, 12 },
                    { 15, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 5, 20, 9, 6, 58, 533, DateTimeKind.Local).AddTicks(8575), "Gia Thịnh", null, null, "Đinh", 296006, 28 },
                    { 16, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1972, 11, 16, 5, 58, 58, 93, DateTimeKind.Local).AddTicks(8068), "Yến Nhi", null, null, "Hà", 165934, 14 },
                    { 17, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 10, 11, 7, 57, 47, 324, DateTimeKind.Local).AddTicks(2568), "Thanh Ngân", null, null, "Lý", 264131, 29 },
                    { 18, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2004, 2, 18, 9, 53, 8, 836, DateTimeKind.Local).AddTicks(914), "Hữu Ðạt", null, null, "Bùi", 287218, 15 },
                    { 19, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 10, 2, 11, 42, 28, 751, DateTimeKind.Local).AddTicks(3828), "Bảo Thạch", null, null, "Đào", 175719, 31 },
                    { 20, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 5, 21, 13, 47, 19, 578, DateTimeKind.Local).AddTicks(3816), "Thúy Minh", null, null, "Phùng", 245648, 16 },
                    { 21, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 9, 22, 15, 27, 10, 178, DateTimeKind.Local).AddTicks(5172), "Mỹ Hiệp", null, null, "Nguyễn", 115576, 32 },
                    { 22, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1966, 8, 22, 17, 41, 30, 320, DateTimeKind.Local).AddTicks(6751), "Ðình Hợp", null, null, "Phan", 185505, 17 },
                    { 23, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1982, 9, 13, 19, 11, 51, 605, DateTimeKind.Local).AddTicks(6483), "Tuệ Mẫn", null, null, "Hồ", 202655, 33 },
                    { 24, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 11, 23, 21, 35, 41, 62, DateTimeKind.Local).AddTicks(9659), "Như Ngọc", null, null, "Vương", 125361, 18 },
                    { 25, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 9, 3, 22, 56, 33, 32, DateTimeKind.Local).AddTicks(7837), "Gia Huy", null, null, "Tô", 195290, 30 },
                    { 26, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1954, 8, 30, 12, 48, 53, 746, DateTimeKind.Local).AddTicks(3461), "Việt Hoàng", null, null, "Trần", 271918, 21 },
                    { 27, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1978, 8, 26, 2, 41, 14, 459, DateTimeKind.Local).AddTicks(9120), "Thanh Hạnh", null, null, "Tăng", 200785, 35 },
                    { 28, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2002, 8, 21, 16, 33, 35, 173, DateTimeKind.Local).AddTicks(4775), "Hướng Dương", null, null, "Ngô", 162445, 13 },
                    { 29, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1976, 8, 16, 6, 25, 55, 887, DateTimeKind.Local).AddTicks(412), "Bảo Hiển", null, null, "Đinh", 141179, 27 }
                });

            migrationBuilder.InsertData(
                table: "UniversityUnits",
                columns: new[] { "Id", "CreatedByUserId", "CreatedDate", "Description", "LastModifiedByUserId", "LastModifiedDate", "Name", "UserId" },
                values: new object[,]
                {
                    { 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bàn độc việc nước nha cái ừ một tám.", null, null, "Trần and Sons", 10 },
                    { 2, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bảy bạn khoảng.", null, null, "Bùi, Lý and Hà", 3 },
                    { 3, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Khâu viết một nước.", null, null, "Trịnh Group", 4 },
                    { 4, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Không áo khoan.", null, null, "Hà, Dương and Bùi", 6 },
                    { 5, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thuyền chìm đá nước anh thì đồng làm.", null, null, "Vũ - Phan", 1 },
                    { 6, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bạn anh khoan giày lầu dép đá giết em viết.", null, null, "Đào, Hà and Phùng", 8 },
                    { 7, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nghỉ tủ á.", null, null, "Mai - Vương", 9 },
                    { 8, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chỉ lầu khoan ruộng mượn vẽ dép là con.", null, null, "Lý, Đặng and Phan", 5 },
                    { 9, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ba ác xuồng ngọt đâu anh.", null, null, "Đỗ - Nguyễn", 7 },
                    { 10, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sáu nhà thuyền mướn ruộng bàn bốn đỏ.", null, null, "Đinh, Đinh and Trịnh", 2 }
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "CreatedByUserId", "CreatedDate", "DeletedWhen", "Description", "EndDate", "FormUrl", "IsDeleted", "IsPublished", "LastModifiedByUserId", "LastModifiedDate", "Location", "MaxAttendees", "StartDate", "Title", "TrainingPoint", "Type", "UniversityUnitId" },
                values: new object[,]
                {
                    { 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Nước nha cái ừ một. Quê quần bàn năm thương. Nón nước đâu đập nhà bạn phá tôi. Trời leo khâu dép nón.", new DateTime(2024, 7, 11, 0, 7, 19, 808, DateTimeKind.Local).AddTicks(3303), "http://thiênthêu.info", false, true, null, null, "296 Đông Nghi Mountain, Hậu Giang, Palestine", 48, new DateTime(2024, 6, 11, 5, 58, 16, 966, DateTimeKind.Local).AddTicks(3036), "Thế tàu chết bàn.", 5, "Workshop", 7 },
                    { 2, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Đã đỏ nhà. Nón mua lỗi đâu hết. Chín lỗi núi tui bàn. Nha áo chìm đồng nha ờ thôi gió quần được. Đâu á ba ba xanh ruộng khâu đang. Thôi lầu cái thương gì núi.", new DateTime(2023, 4, 25, 22, 54, 29, 473, DateTimeKind.Local).AddTicks(3920), "https://tùngquang.info", false, false, null, null, "8350 Phương Loan Ports, Trà Vinh, Vatican", 23, new DateTime(2023, 4, 12, 23, 36, 9, 750, DateTimeKind.Local).AddTicks(7589), "Xe phá quê thế bảy bạn khoảng mượn đang.", 5, "Webinar", 2 },
                    { 3, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Thôi nhà xanh tui áo ờ hết bơi thì máy. Bè mướn em xanh hết hương khoan đỏ chỉ. Xanh sáu một xanh biết áo. Tím ác máy ghế tui chỉ mây thương lầu độc.", new DateTime(2023, 10, 19, 6, 16, 54, 515, DateTimeKind.Local).AddTicks(9757), "https://sơnquân.com", false, false, null, null, "0771 Nguyễn Squares, Cao Bằng, Bénin", 44, new DateTime(2023, 10, 3, 15, 9, 7, 900, DateTimeKind.Local).AddTicks(5372), "Áo hàng tô khâu viết.", 4, "Workshop", 7 },
                    { 4, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Nhà chỉ hết vàng chỉ tàu hết. Thôi trăng ghế độc đâu nha làm phá bàn. Ghế đỏ bơi đâu á.", new DateTime(2022, 8, 17, 9, 52, 53, 405, DateTimeKind.Local).AddTicks(3609), "https://phươngtrang.com.vn", false, false, null, null, "47036 Ðắc Trọng Stream, Kon Tum, Samoa", 46, new DateTime(2022, 8, 6, 18, 6, 2, 204, DateTimeKind.Local).AddTicks(6501), "Hương may đạp đang không áo khoan tàu ghét.", 1, "Other", 9 },
                    { 5, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Anh thì đồng làm gì gì bè đá ruộng đâu. Một bè gì mây hết vẽ được mượn hết. Thế ờ chết bảy thế cửa đồng phá tôi tô.", new DateTime(2022, 11, 27, 6, 56, 29, 96, DateTimeKind.Local).AddTicks(7455), "http://ngọcquyên.info", false, false, null, null, "056 Dương Extensions, Yên Bái, Venezuela", 55, new DateTime(2022, 11, 16, 23, 32, 34, 722, DateTimeKind.Local).AddTicks(5914), "Năm ba thích thuyền chìm.", 5, "Seminar", 3 }
                });

            migrationBuilder.InsertData(
                table: "EventImages",
                columns: new[] { "Id", "EventId", "ImageUrl" },
                values: new object[,]
                {
                    { 1, 2, "https://picsum.photos/640/480/?image=120" },
                    { 2, 4, "https://picsum.photos/640/480/?image=438" },
                    { 3, 2, "https://picsum.photos/640/480/?image=756" },
                    { 4, 5, "https://picsum.photos/640/480/?image=1075" },
                    { 5, 2, "https://picsum.photos/640/480/?image=308" },
                    { 6, 5, "https://picsum.photos/640/480/?image=626" },
                    { 7, 2, "https://picsum.photos/640/480/?image=945" },
                    { 8, 5, "https://picsum.photos/640/480/?image=178" },
                    { 9, 3, "https://picsum.photos/640/480/?image=497" },
                    { 10, 5, "https://picsum.photos/640/480/?image=815" },
                    { 11, 3, "https://picsum.photos/640/480/?image=48" },
                    { 12, 5, "https://picsum.photos/640/480/?image=367" },
                    { 13, 3, "https://picsum.photos/640/480/?image=685" },
                    { 14, 1, "https://picsum.photos/640/480/?image=1003" },
                    { 15, 3, "https://picsum.photos/640/480/?image=237" },
                    { 16, 1, "https://picsum.photos/640/480/?image=555" },
                    { 17, 4, "https://picsum.photos/640/480/?image=873" },
                    { 18, 1, "https://picsum.photos/640/480/?image=107" },
                    { 19, 4, "https://picsum.photos/640/480/?image=425" },
                    { 20, 1, "https://picsum.photos/640/480/?image=743" }
                });

            migrationBuilder.InsertData(
                table: "EventRegistrations",
                columns: new[] { "Id", "AttendedDate", "CreatedByUserId", "CreatedDate", "EventId", "IsAttended", "IsRegistered", "LastModifiedByUserId", "LastModifiedDate", "RegisterDate", "StudentId" },
                values: new object[,]
                {
                    { 1, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, false, true, null, null, new DateTime(2023, 3, 12, 1, 40, 53, 669, DateTimeKind.Local).AddTicks(7347), 4 },
                    { 2, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, false, true, null, null, new DateTime(2022, 6, 16, 17, 8, 19, 311, DateTimeKind.Local).AddTicks(7436), 12 },
                    { 3, new DateTime(2023, 4, 9, 2, 27, 13, 203, DateTimeKind.Local).AddTicks(3112), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true, true, null, null, new DateTime(2023, 4, 4, 3, 39, 50, 905, DateTimeKind.Local).AddTicks(4972), 21 },
                    { 4, new DateTime(2022, 10, 21, 3, 28, 24, 323, DateTimeKind.Local).AddTicks(961), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, true, true, null, null, new DateTime(2022, 10, 20, 19, 39, 59, 314, DateTimeKind.Local).AddTicks(9565), 29 },
                    { 5, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, false, true, null, null, new DateTime(2023, 2, 28, 5, 38, 48, 141, DateTimeKind.Local).AddTicks(2597), 9 },
                    { 6, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, false, true, null, null, new DateTime(2022, 11, 13, 16, 45, 6, 800, DateTimeKind.Local).AddTicks(2281), 17 },
                    { 7, new DateTime(2023, 3, 30, 21, 22, 13, 694, DateTimeKind.Local).AddTicks(6682), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true, true, null, null, new DateTime(2023, 3, 23, 7, 37, 45, 377, DateTimeKind.Local).AddTicks(223), 26 },
                    { 8, new DateTime(2022, 11, 9, 19, 20, 52, 840, DateTimeKind.Local).AddTicks(8846), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, true, true, null, null, new DateTime(2022, 10, 8, 13, 50, 14, 285, DateTimeKind.Local).AddTicks(4996), 5 },
                    { 9, new DateTime(2023, 8, 22, 15, 32, 32, 512, DateTimeKind.Local).AddTicks(6372), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, true, true, null, null, new DateTime(2023, 8, 7, 3, 59, 21, 206, DateTimeKind.Local).AddTicks(812), 14 },
                    { 10, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, false, true, null, null, new DateTime(2022, 11, 1, 10, 55, 21, 770, DateTimeKind.Local).AddTicks(7712), 22 },
                    { 11, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, false, true, null, null, new DateTime(2023, 8, 31, 1, 4, 28, 691, DateTimeKind.Local).AddTicks(3528), 2 },
                    { 12, new DateTime(2022, 10, 28, 13, 18, 24, 685, DateTimeKind.Local).AddTicks(5080), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, true, true, null, null, new DateTime(2022, 9, 26, 8, 0, 29, 256, DateTimeKind.Local).AddTicks(428), 10 },
                    { 13, new DateTime(2023, 9, 24, 15, 42, 55, 756, DateTimeKind.Local).AddTicks(3755), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, true, true, null, null, new DateTime(2023, 9, 23, 22, 9, 36, 176, DateTimeKind.Local).AddTicks(6244), 19 },
                    { 14, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, true, null, null, new DateTime(2024, 5, 14, 11, 31, 18, 985, DateTimeKind.Local).AddTicks(266), 27 },
                    { 15, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, false, true, null, null, new DateTime(2023, 8, 18, 19, 14, 43, 661, DateTimeKind.Local).AddTicks(8959), 7 },
                    { 16, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, true, null, null, new DateTime(2024, 6, 7, 8, 36, 26, 470, DateTimeKind.Local).AddTicks(2981), 15 },
                    { 17, new DateTime(2022, 8, 4, 3, 33, 43, 337, DateTimeKind.Local).AddTicks(79), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, true, true, null, null, new DateTime(2022, 7, 15, 19, 16, 45, 451, DateTimeKind.Local).AddTicks(2804), 24 },
                    { 18, new DateTime(2024, 5, 15, 13, 15, 3, 213, DateTimeKind.Local).AddTicks(5667), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true, true, null, null, new DateTime(2024, 5, 2, 5, 41, 33, 955, DateTimeKind.Local).AddTicks(5697), 3 },
                    { 19, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, false, true, null, null, new DateTime(2022, 6, 9, 16, 21, 52, 936, DateTimeKind.Local).AddTicks(5520), 12 },
                    { 20, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, true, null, null, new DateTime(2024, 5, 26, 2, 46, 41, 440, DateTimeKind.Local).AddTicks(8413), 20 },
                    { 21, new DateTime(2022, 7, 27, 1, 25, 43, 624, DateTimeKind.Local).AddTicks(843), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, true, true, null, null, new DateTime(2022, 7, 3, 13, 27, 0, 421, DateTimeKind.Local).AddTicks(8236), 29 },
                    { 22, new DateTime(2023, 2, 28, 10, 46, 46, 681, DateTimeKind.Local).AddTicks(6142), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true, true, null, null, new DateTime(2023, 2, 21, 10, 29, 54, 645, DateTimeKind.Local).AddTicks(2412), 8 },
                    { 23, new DateTime(2022, 8, 2, 12, 38, 58, 995, DateTimeKind.Local).AddTicks(9692), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, true, true, null, null, new DateTime(2022, 7, 27, 10, 32, 7, 907, DateTimeKind.Local).AddTicks(951), 17 },
                    { 24, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, false, true, null, null, new DateTime(2023, 3, 16, 12, 28, 51, 881, DateTimeKind.Local).AddTicks(37), 25 },
                    { 25, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, false, true, null, null, new DateTime(2022, 6, 21, 7, 37, 15, 392, DateTimeKind.Local).AddTicks(3667), 5 },
                    { 26, new DateTime(2023, 4, 12, 17, 47, 4, 429, DateTimeKind.Local).AddTicks(5040), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true, true, null, null, new DateTime(2023, 4, 8, 14, 27, 49, 116, DateTimeKind.Local).AddTicks(7662), 13 },
                    { 27, new DateTime(2022, 11, 3, 8, 37, 15, 752, DateTimeKind.Local).AddTicks(8034), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, true, true, null, null, new DateTime(2022, 10, 25, 10, 8, 55, 395, DateTimeKind.Local).AddTicks(5796), 22 },
                    { 28, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, false, true, null, null, new DateTime(2023, 3, 4, 16, 26, 46, 352, DateTimeKind.Local).AddTicks(5287), 1 },
                    { 29, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, false, true, null, null, new DateTime(2022, 9, 19, 7, 14, 2, 880, DateTimeKind.Local).AddTicks(8512), 10 },
                    { 30, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, false, true, null, null, new DateTime(2023, 3, 27, 18, 25, 43, 588, DateTimeKind.Local).AddTicks(2913), 18 },
                    { 31, new DateTime(2022, 10, 20, 5, 6, 38, 726, DateTimeKind.Local).AddTicks(1660), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, true, true, null, null, new DateTime(2022, 10, 13, 4, 19, 10, 366, DateTimeKind.Local).AddTicks(1227), 27 },
                    { 32, new DateTime(2023, 9, 15, 7, 39, 6, 448, DateTimeKind.Local).AddTicks(7938), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, true, true, null, null, new DateTime(2023, 8, 11, 18, 28, 17, 286, DateTimeKind.Local).AddTicks(7043), 6 },
                    { 33, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, false, true, null, null, new DateTime(2022, 11, 6, 1, 24, 17, 851, DateTimeKind.Local).AddTicks(3943), 15 },
                    { 34, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, false, true, null, null, new DateTime(2023, 9, 4, 15, 33, 24, 771, DateTimeKind.Local).AddTicks(9759), 24 },
                    { 35, new DateTime(2024, 4, 25, 13, 59, 22, 677, DateTimeKind.Local).AddTicks(7106), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true, true, null, null, new DateTime(2024, 4, 25, 4, 55, 7, 580, DateTimeKind.Local).AddTicks(3781), 3 },
                    { 36, new DateTime(2023, 9, 30, 20, 56, 16, 861, DateTimeKind.Local).AddTicks(4839), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, true, true, null, null, new DateTime(2023, 9, 28, 12, 38, 32, 257, DateTimeKind.Local).AddTicks(2475), 12 },
                    { 37, new DateTime(2024, 6, 9, 4, 29, 36, 136, DateTimeKind.Local).AddTicks(187), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true, true, null, null, new DateTime(2024, 5, 19, 2, 0, 15, 65, DateTimeKind.Local).AddTicks(6497), 20 },
                    { 38, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, false, true, null, null, new DateTime(2023, 8, 23, 9, 43, 39, 742, DateTimeKind.Local).AddTicks(5191), 29 },
                    { 39, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, true, null, null, new DateTime(2024, 4, 12, 23, 5, 22, 550, DateTimeKind.Local).AddTicks(9212), 8 },
                    { 40, new DateTime(2022, 7, 25, 0, 17, 2, 581, DateTimeKind.Local).AddTicks(4125), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, true, true, null, null, new DateTime(2022, 7, 20, 9, 45, 41, 531, DateTimeKind.Local).AddTicks(9035), 17 },
                    { 41, new DateTime(2024, 6, 1, 5, 26, 6, 825, DateTimeKind.Local).AddTicks(1244), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true, true, null, null, new DateTime(2024, 5, 6, 20, 10, 30, 36, DateTimeKind.Local).AddTicks(1928), 25 },
                    { 42, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, false, true, null, null, new DateTime(2022, 6, 14, 6, 50, 49, 17, DateTimeKind.Local).AddTicks(1751), 5 },
                    { 43, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, true, null, null, new DateTime(2024, 5, 30, 17, 15, 37, 521, DateTimeKind.Local).AddTicks(4644), 13 },
                    { 44, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, false, true, null, null, new DateTime(2022, 7, 8, 3, 55, 56, 502, DateTimeKind.Local).AddTicks(4467), 22 },
                    { 45, new DateTime(2023, 3, 21, 23, 46, 30, 984, DateTimeKind.Local).AddTicks(4325), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true, true, null, null, new DateTime(2023, 2, 25, 21, 17, 52, 856, DateTimeKind.Local).AddTicks(5102), 1 },
                    { 46, new DateTime(2022, 8, 6, 14, 35, 17, 390, DateTimeKind.Local).AddTicks(2622), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, true, true, null, null, new DateTime(2022, 8, 1, 1, 1, 3, 987, DateTimeKind.Local).AddTicks(7183), 10 },
                    { 47, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, false, true, null, null, new DateTime(2023, 3, 20, 23, 16, 50, 92, DateTimeKind.Local).AddTicks(2727), 18 },
                    { 48, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, false, true, null, null, new DateTime(2022, 10, 6, 3, 32, 43, 990, DateTimeKind.Local).AddTicks(9311), 27 },
                    { 49, new DateTime(2023, 3, 5, 2, 27, 16, 652, DateTimeKind.Local).AddTicks(9315), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true, true, null, null, new DateTime(2023, 2, 14, 1, 15, 47, 328, DateTimeKind.Local).AddTicks(352), 6 },
                    { 50, new DateTime(2022, 11, 13, 0, 52, 49, 39, DateTimeKind.Local).AddTicks(7622), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, true, true, null, null, new DateTime(2022, 10, 30, 0, 37, 51, 476, DateTimeKind.Local).AddTicks(2027), 15 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 6 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 7 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 8 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 9 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 10 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 11 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 12 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 13 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 14 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 15 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 16 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 17 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 18 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 19 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 20 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 21 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 22 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 23 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 24 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 25 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 26 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 27 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 28 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 29 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 30 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 31 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 32 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 33 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 34 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 35 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 36 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 37 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 38 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 39 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 40 });

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "UniversityUnits",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UniversityUnits",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "UniversityUnits",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "UniversityUnits",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "UniversityUnits",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "UniversityUnits",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "UniversityUnits",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "UniversityUnits",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "UniversityUnits",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "UniversityUnits",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9);
        }
    }
}
