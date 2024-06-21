using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UITEventAPI.Application.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSeedData1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "https://picsum.photos/640/480/?image=306", "72db281a-f527-4982-84fc-2c1aeec198d1", "149733_Ho43@gmail.com", "149733_HO43@GMAIL.COM", "149733", "AQAAAAIAAYagAAAAEEZmQVrawlccZ9LwL5xCKT6TMcJ04SbMxxQHwOCjzYxrUc/6XRSrXH+CRQZj4z9XAg==", "029 1602 3966", "15c6f87f-cbf6-4ed6-9b90-09863507097d", "149733" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "https://picsum.photos/640/480/?image=255", "8231e84e-93c5-4e8c-86df-b34cc7a28436", "254219.Ly30@yahoo.com", "254219.LY30@YAHOO.COM", "254219", "AQAAAAIAAYagAAAAEJKxo5os1I68wDvYUapEw3hkBepGpVzK07dHxmB9IXBvGsr3fGKJKHlGc6lLc1UM2g==", "0242 0700 5327", "0d9418dd-fea9-4051-9c9d-35ede859e339", "254219" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "https://picsum.photos/640/480/?image=980", "ae4f1583-3e7b-4308-b095-44c03be9fe2d", "15870456@hotmail.com", "15870456@HOTMAIL.COM", "158704", "AQAAAAIAAYagAAAAEIyBkU4XG7QJdE5DZoBps6KKNzBcp8/f7fouNpPkrG5+hLxHT2yNUDc9vhtY1Dx6/Q==", "022 9335 8600", "c7f48391-ce69-483a-9753-362fc7393411", "158704" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "https://picsum.photos/640/480/?image=573", "8e6c71f0-6e0d-420d-a80d-11e9c9fa27c2", "263189.Duong@hotmail.com", "263189.DUONG@HOTMAIL.COM", "263189", "AQAAAAIAAYagAAAAEFfaCesi9SnF4gnuwvb7n0AVSgYp0tngVNDRllwE67mMFoD88VW57A/ZRYb+lHrKoQ==", "026 4472 5357", "9049cd76-c548-4834-a64c-fd073ce1911c", "263189" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "https://picsum.photos/640/480/?image=1046", "e44ce964-600b-4211-8aff-291663e203a8", "167674.Phan@gmail.com", "167674.PHAN@GMAIL.COM", "167674", "AQAAAAIAAYagAAAAEF8RYHYPw0v/CRcqcN4bRYdPY18k35vj+wUWJEQcq6nh320tVCvf4c2pXhD61tnQxg==", "0219 5193 0041", "9efc1376-7c94-4b3e-8a3b-aaf7fd4ba169", "167674" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "https://picsum.photos/640/480/?image=776", "3b26fd81-7d00-4a69-8123-5001ae703dd0", "272159_Ha80@yahoo.com", "272159_HA80@YAHOO.COM", "272159", "AQAAAAIAAYagAAAAEOYGCWlHBPvEwZqQcYYEAe0upDU4SzgAeYIRykFQMT1neFlDL3ox1NljR5qfPoITKA==", "0247 4717 5173", "be92af10-58b1-4db0-aa0f-b05599703821", "272159" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "https://picsum.photos/640/480/?image=873", "7ff69c66-5740-47c8-8a00-1773cb5c0acb", "17664436@hotmail.com", "17664436@HOTMAIL.COM", "176644", "AQAAAAIAAYagAAAAEDnyeeu23N2pODOc80boSkNnQA6/BOOlMC/0KeF8OMbjlkSyZGaelhLZuaqWQNaIAQ==", "0209 8849 4184", "c1639db4-257f-4063-91fd-0e7e0e7f9f42", "176644" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "https://picsum.photos/640/480/?image=244", "8866fec0-c4fe-488f-8a7d-5aca6705b53a", "28113081@gmail.com", "28113081@GMAIL.COM", "281130", "AQAAAAIAAYagAAAAENmYbTYrXg914qvKloc4UejmrlzhuI4Xdf/74JYwOmbGWncAArspbRvgNZ74w4vkFg==", "0244 9217 1650", "91925fdf-6b5e-4f03-8536-b2322c018cd9", "281130" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "https://picsum.photos/640/480/?image=706", "437a16c9-3012-48b2-9d71-fae1eb424fdc", "185614.Nguyen@yahoo.com", "185614.NGUYEN@YAHOO.COM", "185614", "AQAAAAIAAYagAAAAEHSHCr8gi0tELfsXKOxzX/hsccIh0ERnOYDykx0R2h9wYt5TBEDQcPHEZF4FztpudA==", "029 9059 4812", "d755f949-3f39-49d8-ab69-709a1106b053", "185614" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "https://picsum.photos/640/480/?image=71", "3c9cb399-f4e6-457b-b01e-b7edcf503c7e", "290100_Dinh29@hotmail.com", "290100_DINH29@HOTMAIL.COM", "290100", "AQAAAAIAAYagAAAAEOzqU+6I7bTqP9poZljMpkJ/xvyml4b2tNnx9RSnncJI+dyw5mYFMzx5iJZn4W8F+A==", "024 2962 5692", "8ede3247-bea5-45a0-978a-e289888fb853", "290100" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "https://picsum.photos/640/480/?image=884", "cc6bc6d3-dc2f-4ddc-b8cb-cc39f31fa6f9", "194584.Do17@gmail.com", "194584.DO17@GMAIL.COM", "194584", "AQAAAAIAAYagAAAAELixvsgd1PAejErUyJWQMt3Sfc9dX5p/CqhU3He8iXGg3IkqR3HlbO/Hwj5JoLwWrg==", "0293 3301 1694", "21f5f5b3-a20d-4725-b83f-5932f91e5819", "194584" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "https://picsum.photos/640/480/?image=569", "c1f3f1dd-5e98-4a83-850c-7757c8e71473", "29907062@yahoo.com", "29907062@YAHOO.COM", "299070", "AQAAAAIAAYagAAAAEMBjRNtwGR9DEa9FVh8z8v+LZt4AL7ApLckSU2i+2m7Wal7aex2KDyVDdxJ41BwoIw==", "022 4461 8873", "37e69fc0-c034-495b-b668-3647e0cb5f0a", "299070" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "https://picsum.photos/640/480/?image=354", "1e3e848a-e3db-47d9-8658-5efd654bb8bf", "2035547@yahoo.com", "2035547@YAHOO.COM", "203554", "AQAAAAIAAYagAAAAEKmhuqp81agjUjmHCS7F5a2OD83r9kMXfQOC8YX2xaVxFZ36Fxe/ozCrL4D2GcEqrA==", "0279 5086 5201", "7d7d035c-357f-40ed-ad13-81133e8e2f11", "203554" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "https://picsum.photos/640/480/?image=810", "48130760-cde8-4e87-a661-b0e4c72ffb96", "108039_Duong@hotmail.com", "108039_DUONG@HOTMAIL.COM", "108039", "AQAAAAIAAYagAAAAEHEkU1FMhG6rqppeYrxxXoAjhvMtP6JN5Ovh+kI0kgsmDl1uiijLUSCj4HrSM8MBQw==", "0214 7463 2777", "b331eb89-fa61-4e7c-aaf6-ed47a0191353", "108039" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "https://picsum.photos/640/480/?image=320", "ac4f3209-8756-4521-a31b-fc8e30a28336", "212525_Phan66@gmail.com", "212525_PHAN66@GMAIL.COM", "212525", "AQAAAAIAAYagAAAAEHGvXMPPZrNeJGWu3mROo/FzC68aTQeayxx42R5jvNJyxxI1gFB+iLhtnj1INGwbbA==", "0298 8319 2431", "1fdbb03c-baa0-49de-bf47-f1df63e67846", "212525" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "https://picsum.photos/640/480/?image=638", "d1a9e1f4-0484-40e7-81f5-87379fd8800a", "117009.Truong54@yahoo.com", "117009.TRUONG54@YAHOO.COM", "117009", "AQAAAAIAAYagAAAAEHEiJRTzeda21Rt32MMWIzMkC/I/wNvCtPfxbcHP1VO+AWEMyIMGKGVQba3mH2fOSg==", "024 9109 6710", "132e3b21-28be-41ff-a1e9-e648d63063b3", "117009" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "https://picsum.photos/640/480/?image=702", "6de88fd7-f33c-4964-8947-9d97e6f98577", "22149588@hotmail.com", "22149588@HOTMAIL.COM", "221495", "AQAAAAIAAYagAAAAEKesUrrnQDnO0HE5KPw3lKKum4qpp6U4DRTu4Ijy3jjM7vqAJoTAEiXGfVFYxQlfxQ==", "025 9058 7338", "59e39624-68c5-4ae7-9562-2597489f8e01", "221495" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "https://picsum.photos/640/480/?image=294", "4529b21d-e780-4212-bba4-dff1549129a6", "125979.Dang@gmail.com", "125979.DANG@GMAIL.COM", "125979", "AQAAAAIAAYagAAAAENUgctdvbLJGWXWtkx/Gv5Keycw9Py5J+FQBhsrCRXlYWL5Aubj0nmC/SkUdrBGABQ==", "029 4295 5085", "4f4ab061-9dfb-48b2-b400-d07fca2db15a", "125979" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "https://picsum.photos/640/480/?image=972", "4e14541c-647f-4f66-b12b-7f7ad760d0d2", "230465_Nguyen@yahoo.com", "230465_NGUYEN@YAHOO.COM", "230465", "AQAAAAIAAYagAAAAEN08uLmFufpHq9ac2Za8uVCWYb6JFj7ytaTBxmFY8Q3x1MoTRVZuebc6y1X6/T0ZLA==", "024 9322 3632", "3a7b8175-1091-4a3e-a3d4-ed8c39742bd8", "230465" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "https://picsum.photos/640/480/?image=428", "91599246-af1a-43ef-a81e-1f043d86a668", "134950.Dinh3@hotmail.com", "134950.DINH3@HOTMAIL.COM", "134950", "AQAAAAIAAYagAAAAEOiM/tUJo4JCW4bRttRc/ybgBfu2q3tafISnlcbwo3oCyfe4xQ23YEt1QbuhVC83Jg==", "0244 6003 8952", "da288257-b9ca-4372-b3e3-d23907b38bf2", "134950" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "https://picsum.photos/640/480/?image=748", "1606c7ec-4f5b-4d33-9435-2b6887e06365", "23943568@hotmail.com", "23943568@HOTMAIL.COM", "239435", "AQAAAAIAAYagAAAAEDU3UVChWXDSKjpnavudufb9dTQIC+Gn5jJKWhAkgI5OCWl7lv0fzMWdSgHVY32sbg==", "0239 5078 0361", "725ccca3-2870-4e11-9cd8-c4eccdddab46", "239435" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "https://picsum.photos/640/480/?image=119", "9bac9e8f-f0c7-4f21-b2dc-ec477137e545", "14392013@gmail.com", "14392013@GMAIL.COM", "143920", "AQAAAAIAAYagAAAAEGMgIZA+7PMHAIqKSVqUKvyN9vruHE89+5Zjm+6rwdQg4Dh8sOpaWGLBC1Wqc2C+eA==", "0274 6346 7937", "92ece6ad-e27a-45d1-ad1c-85d9f8b3825e", "143920" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "https://picsum.photos/640/480/?image=575", "5acfe29c-086f-4ed8-9e51-133a1f7b11b6", "248405_Phung@yahoo.com", "248405_PHUNG@YAHOO.COM", "248405", "AQAAAAIAAYagAAAAEJzbB/Iit2/A43JeeMW4fTvmh7RAUpR8xy33Ol3H64mAv7B0kds4oWaDdLQCUWEULg==", "0229 8724 4403", "3bdd125b-906d-4168-ad18-25750ea339cc", "248405" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "https://picsum.photos/640/480/?image=949", "9beddd62-3724-42bd-8f5a-59c1579ab5f5", "152890.Duong53@hotmail.com", "152890.DUONG53@HOTMAIL.COM", "152890", "AQAAAAIAAYagAAAAENtmmy7ZgMYPCKmQT8yZI7Be5dU6UT9RnT57Yh62Gtj8hFF5czgQ1i02HjiDOnos4A==", "0249 1921 9709", "6a7eae19-710c-4339-bf27-9f37469cd43e", "152890" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "https://picsum.photos/640/480/?image=402", "3add5d2f-7e76-4c5f-bd54-8414e9f8c40e", "257376.Phan40@gmail.com", "257376.PHAN40@GMAIL.COM", "257376", "AQAAAAIAAYagAAAAEGkLY/DOJLUo2QI52EYCohRuLUIK9B9MY19yIxwevd6Wjeb4iolTq2EjayIF1Ntffw==", "029 0479 8446", "9802ac36-1ecc-4203-af1f-1714331f844b", "257376" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "https://picsum.photos/640/480/?image=290", "81fb08d5-7c63-48c2-9d85-d3ebf651d2cc", "16186094@yahoo.com", "16186094@YAHOO.COM", "161860", "AQAAAAIAAYagAAAAEA+Zvm9QCzs+rE209vfHu9dJORorm8V9wgXGsNJpmmCVPG5HNq2qoijKB+/s6LoF/Q==", "025 4184 7591", "4a34b9f2-3f3f-4d7c-82c5-c51014a6ff59", "161860" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "https://picsum.photos/640/480/?image=968", "ec556642-d53c-410f-b609-453aad223bc1", "26634639@hotmail.com", "26634639@HOTMAIL.COM", "266346", "AQAAAAIAAYagAAAAECLQfmipCsC4yYhtwWtTYEWxx0QYGopmTZM4tdNNWu4/l3JeE/pSvH2DUlRUiH0BnQ==", "020 9321 5158", "ef62714a-7a3a-4f7d-a2f7-63c8a5303d4e", "266346" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "https://picsum.photos/640/480/?image=560", "4bc618c9-fa9c-495e-88ce-f011ff0a7ef2", "170830_Tang@gmail.com", "170830_TANG@GMAIL.COM", "170830", "AQAAAAIAAYagAAAAEJScunOMwTUU3l/GJn7quJSN0ltDEuHtRexZw/bWiOnbZFUVj+ZXGdSEgNEN3XbYSA==", "024 4459 3805", "ac180f2b-cdd1-4dbc-ad2b-5f866eb9aa7d", "170830" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "https://picsum.photos/640/480/?image=1058", "465648a3-ae98-459f-b062-e25cbb05b8dc", "275316.Nguyen90@gmail.com", "275316.NGUYEN90@GMAIL.COM", "275316", "AQAAAAIAAYagAAAAEH6nh5xaf8f8togS0tIG0s9ChR5EjO/kuXFESVGKLKyebO5CwZ2kQoHrpkKPQ877SA==", "0295 9615 5210", "ad87d85a-f300-4a02-b4a1-39fcaba78078", "275316" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "https://picsum.photos/640/480/?image=513", "c307ab9d-e865-45d6-80c5-d43cf84cee92", "179800_Dinh77@yahoo.com", "179800_DINH77@YAHOO.COM", "179800", "AQAAAAIAAYagAAAAEM3Z+xRzilY0nswucY5zVtEqf+vdamqKrKCMOdwZYs1JsmxRdkVynBop4v4u9LRBVg==", "024 6338 2097", "c48ccc32-4756-4848-944e-6847c0ecafef", "179800" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "https://picsum.photos/640/480/?image=969", "04fb92bc-7901-49f9-a0b0-5fc2b9bb470b", "28428620@hotmail.com", "28428620@HOTMAIL.COM", "284286", "AQAAAAIAAYagAAAAEBNOjI5wA0OOYZihuv1zoDFcqTxpz1cStoohf87a+cPCsuHgVW1t32Jn3iMLD50XBw==", "0279 8716 9563", "121e3f08-bef0-45ad-bc99-c508543961b6", "284286" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "https://picsum.photos/640/480/?image=340", "fcf398c9-7ea1-47c1-8c82-86c757f28ba1", "188771_Le@gmail.com", "188771_LE@GMAIL.COM", "188771", "AQAAAAIAAYagAAAAEEYV2Ks65BXI+vrTzQYgQ/mmQj4HLCpJkUKVDTsoJZUyXm1Fwy+Ss0cli2SoEFFIYw==", "0224 9084 6130", "0963a550-47e1-4394-b19c-31c8ab3986e4", "188771" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "https://picsum.photos/640/480/?image=693", "7e5441e4-6c3f-4db3-96d3-87dfdaa5ced2", "293256.Phung@yahoo.com", "293256.PHUNG@YAHOO.COM", "293256", "AQAAAAIAAYagAAAAEGy5z5cg00yWJZUZIOP83kZSJJ5thQXQEkmnJ+wk2gOJ+xFNDOn+V1JEWQccCzeJjg==", "026 9046 2360", "44ce8a92-7393-475e-91fc-9b7181890de7", "293256" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "https://picsum.photos/640/480/?image=167", "327c049f-6639-40f0-93fa-7ea8096838e1", "197741_Ngo27@hotmail.com", "197741_NGO27@HOTMAIL.COM", "197741", "AQAAAAIAAYagAAAAEL7NDYqOKPcgQPAvHZV+FWQ8LNSVBlmX/ZuFnlRAjKBPreRjzl+py2fgAihZn9e0rg==", "024 1830 0172", "124f3515-8a51-4470-96cd-87ae45869a2c", "197741" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "https://picsum.photos/640/480/?image=964", "6f0fb00c-41c3-41f0-91ca-53c35aa1ed24", "1022250@gmail.com", "1022250@GMAIL.COM", "102225", "AQAAAAIAAYagAAAAEF03HGQaKcW12laKPODrI0Pdx+44eU+k20GWpEfBojZFaxpTEdX4hx85vV/ecRx5ig==", "025 0310 7664", "57ee9129-bdd2-4fb4-bf5a-dfff22693a3f", "102225" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "https://picsum.photos/640/480/?image=556", "07bbea1f-3296-45c5-8034-562d664afa55", "20671145@yahoo.com", "20671145@YAHOO.COM", "206711", "AQAAAAIAAYagAAAAEAboiXZ0WCK5DKPHi+UUpfCljERpyc8THALItJTNZnNz3znVwbB69YhGSIENdHYT8Q==", "020 5458 5311", "c9607497-d610-427c-9b07-62bbb7e08954", "206711" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "https://picsum.photos/640/480/?image=450", "f6b59a95-2012-48a7-8084-0a26c9205013", "111196_Doan@hotmail.com", "111196_DOAN@HOTMAIL.COM", "111196", "AQAAAAIAAYagAAAAEK/tVgtC9Y+EdCKB2sSch4E2r5vDA1l/xS1VkRncWk/zBh7weGwHppfD/4HuzrF6YQ==", "0240 5953 0781", "52253010-d747-4e4d-b95c-c32eb2ae61ca", "111196" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "https://picsum.photos/640/480/?image=602", "85131c3a-096e-4d6a-8219-e5696c717608", "215681.Tang76@hotmail.com", "215681.TANG76@HOTMAIL.COM", "215681", "AQAAAAIAAYagAAAAEA3aPL7v58rlM/difEbKZLChB//ZCpGJhrekf7gq3/eLR2lJufRurLKX6ZxDfFMtTg==", "0256 2217 2578", "b18fc853-f492-4193-a9c1-f3d0e2d33634", "215681" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "https://picsum.photos/640/480/?image=278", "5a634852-dba6-4360-a94e-5d1845aaeed5", "120166_Pham64@gmail.com", "120166_PHAM64@GMAIL.COM", "120166", "AQAAAAIAAYagAAAAEDhAzhxbQjg5epJlsyK0XtEzV6FRgybaOlRBm8vrnGZqbgZTxFtHJ7Q9QFJgYACNLg==", "020 8609 4723", "1799fa9a-03fc-4f94-92fe-8dc2eabc474a", "120166" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "https://picsum.photos/640/480/?image=734", "65868502-5823-444b-960c-14cabdb7adb9", "22465126@yahoo.com", "22465126@YAHOO.COM", "224651", "AQAAAAIAAYagAAAAEP25/KxYYR+5fPxgSsjf3CiGCzpcc55NtyNrzDxN3BqPJHk87QO+ZfmD3v+/IFmURQ==", "0285 9076 1290", "088a7397-f627-46b1-9e40-d278953d5358", "224651" });

            migrationBuilder.UpdateData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegisterDate",
                value: new DateTime(2023, 3, 12, 9, 39, 58, 650, DateTimeKind.Local).AddTicks(350));

            migrationBuilder.UpdateData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 2,
                column: "RegisterDate",
                value: new DateTime(2022, 6, 17, 1, 7, 24, 292, DateTimeKind.Local).AddTicks(199));

            migrationBuilder.UpdateData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AttendedDate", "RegisterDate" },
                values: new object[] { new DateTime(2023, 4, 9, 10, 26, 18, 183, DateTimeKind.Local).AddTicks(6115), new DateTime(2023, 4, 4, 11, 38, 55, 885, DateTimeKind.Local).AddTicks(7975) });

            migrationBuilder.UpdateData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AttendedDate", "RegisterDate" },
                values: new object[] { new DateTime(2022, 10, 21, 11, 27, 29, 303, DateTimeKind.Local).AddTicks(3503), new DateTime(2022, 10, 21, 3, 39, 4, 295, DateTimeKind.Local).AddTicks(2107) });

            migrationBuilder.UpdateData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 5,
                column: "RegisterDate",
                value: new DateTime(2023, 2, 28, 13, 37, 53, 121, DateTimeKind.Local).AddTicks(5600));

            migrationBuilder.UpdateData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 6,
                column: "RegisterDate",
                value: new DateTime(2022, 11, 14, 0, 44, 11, 780, DateTimeKind.Local).AddTicks(4823));

            migrationBuilder.UpdateData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AttendedDate", "RegisterDate" },
                values: new object[] { new DateTime(2023, 3, 31, 5, 21, 18, 674, DateTimeKind.Local).AddTicks(9685), new DateTime(2023, 3, 23, 15, 36, 50, 357, DateTimeKind.Local).AddTicks(3226) });

            migrationBuilder.UpdateData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AttendedDate", "RegisterDate" },
                values: new object[] { new DateTime(2022, 11, 10, 3, 19, 57, 821, DateTimeKind.Local).AddTicks(1388), new DateTime(2022, 10, 8, 21, 49, 19, 265, DateTimeKind.Local).AddTicks(7538) });

            migrationBuilder.UpdateData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AttendedDate", "RegisterDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 31, 37, 492, DateTimeKind.Local).AddTicks(9256), new DateTime(2023, 8, 7, 11, 58, 26, 186, DateTimeKind.Local).AddTicks(3696) });

            migrationBuilder.UpdateData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 10,
                column: "RegisterDate",
                value: new DateTime(2022, 11, 1, 18, 54, 26, 751, DateTimeKind.Local).AddTicks(254));

            migrationBuilder.UpdateData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 11,
                column: "RegisterDate",
                value: new DateTime(2023, 8, 31, 9, 3, 33, 671, DateTimeKind.Local).AddTicks(6412));

            migrationBuilder.UpdateData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AttendedDate", "RegisterDate" },
                values: new object[] { new DateTime(2022, 10, 28, 21, 17, 29, 665, DateTimeKind.Local).AddTicks(7622), new DateTime(2022, 9, 26, 15, 59, 34, 236, DateTimeKind.Local).AddTicks(2970) });

            migrationBuilder.UpdateData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AttendedDate", "RegisterDate" },
                values: new object[] { new DateTime(2023, 9, 24, 23, 42, 0, 736, DateTimeKind.Local).AddTicks(6639), new DateTime(2023, 9, 24, 6, 8, 41, 156, DateTimeKind.Local).AddTicks(9128) });

            migrationBuilder.UpdateData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 14,
                column: "RegisterDate",
                value: new DateTime(2024, 5, 14, 19, 30, 23, 965, DateTimeKind.Local).AddTicks(3482));

            migrationBuilder.UpdateData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 15,
                column: "RegisterDate",
                value: new DateTime(2023, 8, 19, 3, 13, 48, 642, DateTimeKind.Local).AddTicks(1843));

            migrationBuilder.UpdateData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 16,
                column: "RegisterDate",
                value: new DateTime(2024, 6, 7, 16, 35, 31, 450, DateTimeKind.Local).AddTicks(6197));

            migrationBuilder.UpdateData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AttendedDate", "RegisterDate" },
                values: new object[] { new DateTime(2022, 8, 4, 11, 32, 48, 317, DateTimeKind.Local).AddTicks(2842), new DateTime(2022, 7, 16, 3, 15, 50, 431, DateTimeKind.Local).AddTicks(5567) });

            migrationBuilder.UpdateData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AttendedDate", "RegisterDate" },
                values: new object[] { new DateTime(2024, 5, 15, 21, 14, 8, 193, DateTimeKind.Local).AddTicks(8883), new DateTime(2024, 5, 2, 13, 40, 38, 935, DateTimeKind.Local).AddTicks(8913) });

            migrationBuilder.UpdateData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 19,
                column: "RegisterDate",
                value: new DateTime(2022, 6, 10, 0, 20, 57, 916, DateTimeKind.Local).AddTicks(8283));

            migrationBuilder.UpdateData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 20,
                column: "RegisterDate",
                value: new DateTime(2024, 5, 26, 10, 45, 46, 421, DateTimeKind.Local).AddTicks(1629));

            migrationBuilder.UpdateData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AttendedDate", "RegisterDate" },
                values: new object[] { new DateTime(2022, 7, 27, 9, 24, 48, 604, DateTimeKind.Local).AddTicks(3606), new DateTime(2022, 7, 3, 21, 26, 5, 402, DateTimeKind.Local).AddTicks(999) });

            migrationBuilder.UpdateData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AttendedDate", "RegisterDate" },
                values: new object[] { new DateTime(2023, 2, 28, 18, 45, 51, 661, DateTimeKind.Local).AddTicks(9145), new DateTime(2023, 2, 21, 18, 28, 59, 625, DateTimeKind.Local).AddTicks(5415) });

            migrationBuilder.UpdateData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AttendedDate", "RegisterDate" },
                values: new object[] { new DateTime(2022, 8, 2, 20, 38, 3, 976, DateTimeKind.Local).AddTicks(2455), new DateTime(2022, 7, 27, 18, 31, 12, 887, DateTimeKind.Local).AddTicks(3714) });

            migrationBuilder.UpdateData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 24,
                column: "RegisterDate",
                value: new DateTime(2023, 3, 16, 20, 27, 56, 861, DateTimeKind.Local).AddTicks(3040));

            migrationBuilder.UpdateData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 25,
                column: "RegisterDate",
                value: new DateTime(2022, 6, 21, 15, 36, 20, 372, DateTimeKind.Local).AddTicks(6430));

            migrationBuilder.UpdateData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AttendedDate", "RegisterDate" },
                values: new object[] { new DateTime(2023, 4, 13, 1, 46, 9, 409, DateTimeKind.Local).AddTicks(8043), new DateTime(2023, 4, 8, 22, 26, 54, 97, DateTimeKind.Local).AddTicks(665) });

            migrationBuilder.UpdateData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AttendedDate", "RegisterDate" },
                values: new object[] { new DateTime(2022, 11, 3, 16, 36, 20, 733, DateTimeKind.Local).AddTicks(576), new DateTime(2022, 10, 25, 18, 8, 0, 375, DateTimeKind.Local).AddTicks(8338) });

            migrationBuilder.UpdateData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 28,
                column: "RegisterDate",
                value: new DateTime(2023, 3, 5, 0, 25, 51, 332, DateTimeKind.Local).AddTicks(8290));

            migrationBuilder.UpdateData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 29,
                column: "RegisterDate",
                value: new DateTime(2022, 9, 19, 15, 13, 7, 861, DateTimeKind.Local).AddTicks(1054));

            migrationBuilder.UpdateData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 30,
                column: "RegisterDate",
                value: new DateTime(2023, 3, 28, 2, 24, 48, 568, DateTimeKind.Local).AddTicks(5916));

            migrationBuilder.UpdateData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "AttendedDate", "RegisterDate" },
                values: new object[] { new DateTime(2022, 10, 20, 13, 5, 43, 706, DateTimeKind.Local).AddTicks(4202), new DateTime(2022, 10, 13, 12, 18, 15, 346, DateTimeKind.Local).AddTicks(3769) });

            migrationBuilder.UpdateData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "AttendedDate", "RegisterDate" },
                values: new object[] { new DateTime(2023, 9, 15, 15, 38, 11, 429, DateTimeKind.Local).AddTicks(822), new DateTime(2023, 8, 12, 2, 27, 22, 266, DateTimeKind.Local).AddTicks(9927) });

            migrationBuilder.UpdateData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 33,
                column: "RegisterDate",
                value: new DateTime(2022, 11, 6, 9, 23, 22, 831, DateTimeKind.Local).AddTicks(6485));

            migrationBuilder.UpdateData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 34,
                column: "RegisterDate",
                value: new DateTime(2023, 9, 4, 23, 32, 29, 752, DateTimeKind.Local).AddTicks(2643));

            migrationBuilder.UpdateData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "AttendedDate", "RegisterDate" },
                values: new object[] { new DateTime(2024, 4, 25, 21, 58, 27, 658, DateTimeKind.Local).AddTicks(322), new DateTime(2024, 4, 25, 12, 54, 12, 560, DateTimeKind.Local).AddTicks(6997) });

            migrationBuilder.UpdateData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "AttendedDate", "RegisterDate" },
                values: new object[] { new DateTime(2023, 10, 1, 4, 55, 21, 841, DateTimeKind.Local).AddTicks(7723), new DateTime(2023, 9, 28, 20, 37, 37, 237, DateTimeKind.Local).AddTicks(5359) });

            migrationBuilder.UpdateData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "AttendedDate", "RegisterDate" },
                values: new object[] { new DateTime(2024, 6, 9, 12, 28, 41, 116, DateTimeKind.Local).AddTicks(3403), new DateTime(2024, 5, 19, 9, 59, 20, 45, DateTimeKind.Local).AddTicks(9713) });

            migrationBuilder.UpdateData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 38,
                column: "RegisterDate",
                value: new DateTime(2023, 8, 23, 17, 42, 44, 722, DateTimeKind.Local).AddTicks(8075));

            migrationBuilder.UpdateData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 39,
                column: "RegisterDate",
                value: new DateTime(2024, 4, 13, 7, 4, 27, 531, DateTimeKind.Local).AddTicks(2428));

            migrationBuilder.UpdateData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "AttendedDate", "RegisterDate" },
                values: new object[] { new DateTime(2022, 7, 25, 8, 16, 7, 561, DateTimeKind.Local).AddTicks(6888), new DateTime(2022, 7, 20, 17, 44, 46, 512, DateTimeKind.Local).AddTicks(1798) });

            migrationBuilder.UpdateData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "AttendedDate", "RegisterDate" },
                values: new object[] { new DateTime(2024, 6, 1, 13, 25, 11, 805, DateTimeKind.Local).AddTicks(4460), new DateTime(2024, 5, 7, 4, 9, 35, 16, DateTimeKind.Local).AddTicks(5144) });

            migrationBuilder.UpdateData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 42,
                column: "RegisterDate",
                value: new DateTime(2022, 6, 14, 14, 49, 53, 997, DateTimeKind.Local).AddTicks(4514));

            migrationBuilder.UpdateData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 43,
                column: "RegisterDate",
                value: new DateTime(2024, 5, 31, 1, 14, 42, 501, DateTimeKind.Local).AddTicks(7860));

            migrationBuilder.UpdateData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 44,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 8, 11, 55, 1, 482, DateTimeKind.Local).AddTicks(7230));

            migrationBuilder.UpdateData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "AttendedDate", "RegisterDate" },
                values: new object[] { new DateTime(2023, 3, 22, 7, 45, 35, 964, DateTimeKind.Local).AddTicks(7328), new DateTime(2023, 2, 26, 5, 16, 57, 836, DateTimeKind.Local).AddTicks(8105) });

            migrationBuilder.UpdateData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "AttendedDate", "RegisterDate" },
                values: new object[] { new DateTime(2022, 8, 6, 22, 34, 22, 370, DateTimeKind.Local).AddTicks(5385), new DateTime(2022, 8, 1, 9, 0, 8, 967, DateTimeKind.Local).AddTicks(9946) });

            migrationBuilder.UpdateData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 47,
                column: "RegisterDate",
                value: new DateTime(2023, 3, 21, 7, 15, 55, 72, DateTimeKind.Local).AddTicks(5730));

            migrationBuilder.UpdateData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 48,
                column: "RegisterDate",
                value: new DateTime(2022, 10, 6, 11, 31, 48, 971, DateTimeKind.Local).AddTicks(1853));

            migrationBuilder.UpdateData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "AttendedDate", "RegisterDate" },
                values: new object[] { new DateTime(2023, 3, 5, 10, 26, 21, 633, DateTimeKind.Local).AddTicks(2318), new DateTime(2023, 2, 14, 9, 14, 52, 308, DateTimeKind.Local).AddTicks(3355) });

            migrationBuilder.UpdateData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "AttendedDate", "RegisterDate" },
                values: new object[] { new DateTime(2022, 11, 13, 8, 51, 54, 20, DateTimeKind.Local).AddTicks(164), new DateTime(2022, 10, 30, 8, 36, 56, 456, DateTimeKind.Local).AddTicks(4569) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 11, 8, 6, 24, 788, DateTimeKind.Local).AddTicks(6519), new DateTime(2024, 6, 11, 13, 57, 21, 946, DateTimeKind.Local).AddTicks(6252) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 4, 26, 6, 53, 34, 453, DateTimeKind.Local).AddTicks(6923), new DateTime(2023, 4, 13, 7, 35, 14, 731, DateTimeKind.Local).AddTicks(592) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 19, 14, 15, 59, 496, DateTimeKind.Local).AddTicks(2641), new DateTime(2023, 10, 3, 23, 8, 12, 880, DateTimeKind.Local).AddTicks(8256) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 8, 17, 17, 51, 58, 385, DateTimeKind.Local).AddTicks(6372), new DateTime(2022, 8, 7, 2, 5, 7, 184, DateTimeKind.Local).AddTicks(9264) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 27, 14, 55, 34, 76, DateTimeKind.Local).AddTicks(9997), new DateTime(2022, 11, 17, 7, 31, 39, 702, DateTimeKind.Local).AddTicks(8456) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateOfBirth", "StudentCode" },
                values: new object[] { new DateTime(1954, 12, 25, 9, 59, 20, 890, DateTimeKind.Local).AddTicks(2034), 230465 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOfBirth", "StudentCode" },
                values: new object[] { new DateTime(2004, 2, 4, 10, 38, 47, 881, DateTimeKind.Local).AddTicks(453), 197741 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateOfBirth", "StudentCode" },
                values: new object[] { new DateTime(2002, 12, 16, 13, 44, 2, 317, DateTimeKind.Local).AddTicks(6026), 134950 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateOfBirth", "StudentCode" },
                values: new object[] { new DateTime(1985, 5, 7, 14, 32, 58, 623, DateTimeKind.Local).AddTicks(3169), 206711 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateOfBirth", "StudentCode" },
                values: new object[] { new DateTime(2000, 12, 6, 17, 28, 43, 744, DateTimeKind.Local).AddTicks(6970), 143920 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateOfBirth", "StudentCode" },
                values: new object[] { new DateTime(1995, 5, 16, 23, 42, 59, 959, DateTimeKind.Local).AddTicks(439), 111196 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateOfBirth", "StudentCode" },
                values: new object[] { new DateTime(1998, 11, 27, 21, 13, 25, 171, DateTimeKind.Local).AddTicks(8520), 248405 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateOfBirth", "StudentCode" },
                values: new object[] { new DateTime(1975, 5, 17, 19, 34, 47, 416, DateTimeKind.Local).AddTicks(3993), 215681 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateOfBirth", "StudentCode" },
                values: new object[] { new DateTime(1996, 11, 18, 0, 58, 6, 598, DateTimeKind.Local).AddTicks(9536), 152890 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateOfBirth", "StudentCode" },
                values: new object[] { new DateTime(1970, 11, 13, 14, 50, 27, 312, DateTimeKind.Local).AddTicks(5117), 224651 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateOfBirth", "StudentCode" },
                values: new object[] { new DateTime(1994, 11, 9, 4, 42, 48, 26, DateTimeKind.Local).AddTicks(714), 257376 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateOfBirth", "StudentCode" },
                values: new object[] { new DateTime(1960, 5, 14, 6, 9, 41, 592, DateTimeKind.Local).AddTicks(4184), 120166 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateOfBirth", "StudentCode" },
                values: new object[] { new DateTime(1992, 10, 30, 8, 27, 29, 453, DateTimeKind.Local).AddTicks(1598), 161860 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateOfBirth", "StudentCode" },
                values: new object[] { new DateTime(1991, 8, 16, 10, 3, 52, 334, DateTimeKind.Local).AddTicks(6732), 299070 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateOfBirth", "StudentCode" },
                values: new object[] { new DateTime(1980, 5, 20, 17, 6, 3, 516, DateTimeKind.Local).AddTicks(9992), 170830 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateOfBirth", "StudentCode" },
                values: new object[] { new DateTime(1972, 11, 16, 13, 58, 3, 76, DateTimeKind.Local).AddTicks(9185), 108039 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateOfBirth", "StudentCode" },
                values: new object[] { new DateTime(1988, 10, 11, 15, 56, 52, 307, DateTimeKind.Local).AddTicks(3432), 275316 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateOfBirth", "StudentCode" },
                values: new object[] { new DateTime(2004, 2, 18, 17, 52, 13, 819, DateTimeKind.Local).AddTicks(1711), 212525 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateOfBirth", "StudentCode" },
                values: new object[] { new DateTime(1986, 10, 2, 19, 41, 33, 734, DateTimeKind.Local).AddTicks(4310), 284286 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateOfBirth", "StudentCode" },
                values: new object[] { new DateTime(1985, 5, 21, 21, 46, 24, 561, DateTimeKind.Local).AddTicks(4238), 117009 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateOfBirth", "StudentCode" },
                values: new object[] { new DateTime(1984, 9, 22, 23, 26, 15, 161, DateTimeKind.Local).AddTicks(5346), 188771 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateOfBirth", "StudentCode" },
                values: new object[] { new DateTime(1966, 8, 23, 1, 40, 35, 303, DateTimeKind.Local).AddTicks(6749), 221495 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateOfBirth", "StudentCode" },
                values: new object[] { new DateTime(1982, 9, 14, 3, 10, 56, 588, DateTimeKind.Local).AddTicks(6336), 293256 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateOfBirth", "StudentCode" },
                values: new object[] { new DateTime(1997, 11, 24, 5, 34, 46, 45, DateTimeKind.Local).AddTicks(9292), 125979 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateOfBirth", "StudentCode" },
                values: new object[] { new DateTime(1980, 9, 4, 6, 55, 38, 15, DateTimeKind.Local).AddTicks(7187), 179800 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateOfBirth", "StudentCode" },
                values: new object[] { new DateTime(1954, 8, 30, 20, 47, 58, 729, DateTimeKind.Local).AddTicks(2735), 239435 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateOfBirth", "StudentCode" },
                values: new object[] { new DateTime(1978, 8, 26, 10, 40, 19, 442, DateTimeKind.Local).AddTicks(8149), 102225 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateOfBirth", "StudentCode" },
                values: new object[] { new DateTime(2002, 8, 22, 0, 32, 40, 156, DateTimeKind.Local).AddTicks(3574), 203554 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateOfBirth", "StudentCode" },
                values: new object[] { new DateTime(1976, 8, 16, 14, 25, 0, 869, DateTimeKind.Local).AddTicks(8951), 266346 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "https://picsum.photos/640/480/?image=764", "e89a4d07-ccb0-469a-b349-29cd63345a94", "NguyetAnh_Tran_Do@yahoo.com", "NGUYETANH_TRAN_DO@YAHOO.COM", "NGUYETANH_TRAN", "AQAAAAIAAYagAAAAEDj/V75yrAxJaJGVi+77dr5lFtH7lCRawtrfiqHxy/7vB7Ag5FM4hYI+DVhBHfpB0g==", "026 0239 6626", "5d6c7bcf-4978-4cf4-8fef-b7954bd11be9", "NguyetAnh_Tran" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "https://picsum.photos/640/480/?image=96", "960eafdd-0c88-46f8-8f8f-dab896c028d7", "NghiQuyen98.Vu22@gmail.com", "NGHIQUYEN98.VU22@GMAIL.COM", "NGHIQUYEN98", "AQAAAAIAAYagAAAAEIdnlldOMW2RCYww5Lox4RTcqGtHxQcaFS6amYphE3uPOjPsyFK6rHf4TxYRWGtfaQ==", "027 0053 2727", "6d782594-73b3-428f-a9b4-128f3622775b", "NghiQuyen98" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "https://picsum.photos/640/480/?image=633", "05e75069-5ca8-4177-99ef-47be626b487b", "PhuongGiang.Trinh56.Phan37@gmail.com", "PHUONGGIANG.TRINH56.PHAN37@GMAIL.COM", "PHUONGGIANG.TRINH56", "AQAAAAIAAYagAAAAEB1aJlCdno3BNnvj4D5TVVq464BA04u2eLaKsnMrl+aEVgEs9cfS6GmcqfcRoEkn+A==", "0286 0091 8742", "a3a103fe-540f-4cf8-8088-d7b16ee3ceb5", "PhuongGiang.Trinh56" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "https://picsum.photos/640/480/?image=378", "55d2ad22-d6cc-4993-8962-4050afe6a8bb", "QuangDanh.Ha.Nguyen47@gmail.com", "QUANGDANH.HA.NGUYEN47@GMAIL.COM", "QUANGDANH.HA", "AQAAAAIAAYagAAAAEK6eBxttM+9qAR2f2e7uE0x80Up0pw1tQknXvbQY4dhHSLV3ly1FkROkO9kE1AdkYw==", "0225 3575 5478", "1da0f84f-740b-4cdb-93f1-3b779d9fc456", "QuangDanh.Ha" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "https://picsum.photos/640/480/?image=271", "8f658ec8-9623-4ded-a8fc-34e2d973ce2c", "ThanhPhuong6295@yahoo.com", "THANHPHUONG6295@YAHOO.COM", "THANHPHUONG62", "AQAAAAIAAYagAAAAELRNvSnjdxHDuX1HiaxURUOY+RaZQ68ManvBl1nPXotLnoaF8XjVuKUCVp1WlGH+7Q==", "0219 3004 1908", "08e637f1-0c21-43e2-8aee-33710b822204", "ThanhPhuong62" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "https://picsum.photos/640/480/?image=692", "bc35357c-3967-49c9-a0f5-4feeed68863c", "TanThanh_Dao91_Dao@hotmail.com", "TANTHANH_DAO91_DAO@HOTMAIL.COM", "TANTHANH_DAO91", "AQAAAAIAAYagAAAAELe1WQ3UK9zAWn9sPxUISD/OP5yuFOj2dt37q0M+soDo1aTWxkSgQICjjWmLABpPwg==", "027 1751 7378", "502bd6ca-df72-438d-832b-c3f022dba566", "TanThanh_Dao91" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "https://picsum.photos/640/480/?image=27", "00a7100d-c79d-4829-bce6-c01ffa1900d6", "ThuyHuong.Mai95@yahoo.com", "THUYHUONG.MAI95@YAHOO.COM", "THUYHUONG.MAI", "AQAAAAIAAYagAAAAEDCglsOSJEJ05p/yoPBKcwfjUtZDqG+yxKaWSQaT+G0j+ihMXv5OnMfe5YgcTYMgkA==", "0284 9418 4838", "53276056-9d60-4109-b6a8-6434ab6665d4", "ThuyHuong.Mai" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "https://picsum.photos/640/480/?image=447", "142b7a27-0c34-44a6-84e3-8728cf1f822e", "ThienPhuoc.Ly.Duong@hotmail.com", "THIENPHUOC.LY.DUONG@HOTMAIL.COM", "THIENPHUOC.LY", "AQAAAAIAAYagAAAAEMlyjkmND1BdWOJQUJVQj73vKqcwZS6QOscO/u/5bABaBXBVDl+IEspD21ywMNE87g==", "0221 7165 0298", "09720120-1e4f-4597-9cab-bbede1b735db", "ThienPhuoc.Ly" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "https://picsum.photos/640/480/?image=13", "74394116-bb3f-4cb4-98e7-9ff19c1cb9dd", "TuyetHoa47_Do9@gmail.com", "TUYETHOA47_DO9@GMAIL.COM", "TUYETHOA47", "AQAAAAIAAYagAAAAEH+s9kSa9OFctQcqzI6V/je5i4diC7jjAh1BY6O2cC1MBCazbN7769O987BEFeQNhQ==", "0294 8126 6597", "363561a8-2fe7-477c-a179-85271561e14e", "TuyetHoa47" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "https://picsum.photos/640/480/?image=157", "00bcfbc3-8dc3-474c-b1e3-fdd5ddcaf589", "TuanHoang_Dinh72.Bui@gmail.com", "TUANHOANG_DINH72.BUI@GMAIL.COM", "TUANHOANG_DINH72", "AQAAAAIAAYagAAAAEFgidT4VhiO0yqhRjhzZNbpyG582RN0oBvnnwQ/cNsHyBjAD65OOnEKvFt6TQwGpIQ==", "0262 5692 0191", "641e8ec5-5b53-48b5-a391-d43077b2220f", "TuanHoang_Dinh72" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "https://picsum.photos/640/480/?image=622", "d8daadca-a4fe-419e-84b5-4b4fd0cd7e3b", "VanThanh_Nguyen_Ly33@gmail.com", "VANTHANH_NGUYEN_LY33@GMAIL.COM", "VANTHANH_NGUYEN", "AQAAAAIAAYagAAAAEGeMPMbeGqX6cV7M4/g4IUqyAwNx45djYIK4rTIslGYjsRJVYVp0wCrUobb+XhwGSA==", "023 0116 9489", "68818ab0-1010-4166-a510-62cbaf0dc3f8", "VanThanh_Nguyen" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "https://picsum.photos/640/480/?image=2", "4192881a-7a31-4e38-b7bc-304a099721e6", "XuanQuy1146@yahoo.com", "XUANQUY1146@YAHOO.COM", "XUANQUY11", "AQAAAAIAAYagAAAAEN6K2LqPVQVM4jFcLndnpYgwGuBpTu9zpHKTyO25HVxQ3c3IznJ3t5iNys0dNzyi8w==", "026 1887 3594", "ad9b0ed8-2c9b-4346-84d1-aae1cda746fb", "XuanQuy11" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "https://picsum.photos/640/480/?image=40", "6dbcbece-7bc9-44da-a9ef-72093fc8155b", "AnLai.Doan7_Trinh6@hotmail.com", "ANLAI.DOAN7_TRINH6@HOTMAIL.COM", "ANLAI.DOAN7", "AQAAAAIAAYagAAAAEOnU/eC5x8686JBySdsVG7M2vbAjzv5V4fD3kT83VqncjVuZP+5lMM6QV2yr2hIlSQ==", "0265 2013 0035", "3788d094-b93a-4abf-9a99-a6d6e386f5d6", "AnLai.Doan7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "https://picsum.photos/640/480/?image=797", "f4a69218-2b61-4073-8b2e-198c8547f9ad", "CamHuong_Truong46@yahoo.com", "CAMHUONG_TRUONG46@YAHOO.COM", "CAMHUONG_TRUONG", "AQAAAAIAAYagAAAAECdzOmGX9j7f5F6Mxzs3B3WOOA/DSI9w3/gSFlgtMto1CylCFA7UfQ1ZswjNtPVCCQ==", "0246 3277 7760", "becf8cf5-a870-442a-8bd0-6b114c57594a", "CamHuong_Truong" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "https://picsum.photos/640/480/?image=133", "09875e1d-77af-476f-9942-40b99e51db00", "ChinhTruc75_Vuong@hotmail.com", "CHINHTRUC75_VUONG@HOTMAIL.COM", "CHINHTRUC75", "AQAAAAIAAYagAAAAEH///90gKppfZd1UkIuTTIfhNHyEb3EvKgLl5ZjTYZH0GsLjADyK2MKb43UoCyY/sA==", "0283 1924 3120", "3cb19a5b-cb0c-4743-b73a-750002151d9d", "ChinhTruc75" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "https://picsum.photos/640/480/?image=553", "3fb1c046-e4a8-4dac-8214-3773227252ab", "HoangLan_Ngo42_Nguyen@yahoo.com", "HOANGLAN_NGO42_NGUYEN@YAHOO.COM", "HOANGLAN_NGO42", "AQAAAAIAAYagAAAAEMRTu6ERl63QCO7uctvkQursQllL4UHJDFGvFFTZKeZC1tR4SlqXEwPmXdyScPIOoA==", "020 9671 0591", "33eebe9a-0b83-47b5-a2ca-97b3463e0bd2", "HoangLan_Ngo42" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "https://picsum.photos/640/480/?image=149", "daf599d6-f886-4b36-a9f4-d94bf4d5594b", "DucPhi.Lam_Bui@hotmail.com", "DUCPHI.LAM_BUI@HOTMAIL.COM", "DUCPHI.LAM", "AQAAAAIAAYagAAAAEC37AlBufL4mhiGcTbZGVjO77iyn7DXE3DhLnrB1tMhBowXcIk6YJ50O1uE1aY9XDg==", "025 8733 8605", "9d198391-a5be-48c1-8690-e72c7522e208", "DucPhi.Lam" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "https://picsum.photos/640/480/?image=226", "b5b9744e-c9d7-4836-aaa3-5d5230e679af", "HongKhoi.Tran.Vu20@gmail.com", "HONGKHOI.TRAN.VU20@GMAIL.COM", "HONGKHOI.TRAN", "AQAAAAIAAYagAAAAEBi5vKt7t+4KQjE82a+nx6DWCOJOmdNS+eQqCsNH6KP0Zc1WoijMkY8IvqBg7KvATQ==", "0255 0852 4112", "c42a3470-a4ae-4260-ba10-69164d2323b8", "HongKhoi.Tran" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "https://picsum.photos/640/480/?image=207", "46fb884c-18e6-4d6c-abd6-d53f499aa475", "HieuHoc61_Ly@hotmail.com", "HIEUHOC61_LY@HOTMAIL.COM", "HIEUHOC61", "AQAAAAIAAYagAAAAELVCShepxPr8TJgvT7/VT5Rz8z3N9bvUjoTkycD3TeK1xoBPsMfDggPoOVi7dqr+rQ==", "022 2363 2887", "e68bb1f2-1e4d-4f9f-908e-e50f9280b4b1", "HieuHoc61" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "https://picsum.photos/640/480/?image=514", "c667645b-4354-4639-b7b1-b4ad0f6e2ae1", "KieuTrinh_Vuong23.Mai@gmail.com", "KIEUTRINH_VUONG23.MAI@GMAIL.COM", "KIEUTRINH_VUONG23", "AQAAAAIAAYagAAAAEDd3itO6Splor4KsKbh7YlBWufWaIrLX4nn84GxIUSe11AOx9r9RnuGziATeC99b3w==", "0200 3895 2320", "5d4aa056-0d83-4623-b79c-b249a5e1267b", "KieuTrinh_Vuong23" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "https://picsum.photos/640/480/?image=483", "89a2d7f1-61db-42c0-b84e-42343aee8157", "HuuTu.Ha97@hotmail.com", "HUUTU.HA97@HOTMAIL.COM", "HUUTU.HA", "AQAAAAIAAYagAAAAEDs2OeXUqHernG1WlOXUYJH7WkXmAQB/t/RvmTDbOOfeSmm6B/BFUesBKXWi5YadOw==", "0207 8036 1602", "3d095317-407d-4f78-9bea-949caa19b7db", "HuuTu.Ha" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "https://picsum.photos/640/480/?image=903", "316494e5-2aa1-40fb-8c0a-746c44a936fb", "MinhTuyet25.Lam69@gmail.com", "MINHTUYET25.LAM69@GMAIL.COM", "MINHTUYET25", "AQAAAAIAAYagAAAAEMQ7tHmDttKr8GVwn465xtnWb18XqgUSVeM6Mefz9pa3lYwwm+6ti0D+2a3W5p/6jw==", "024 6793 7162", "d3f5d1b3-d460-43a2-93cf-10fcddcd33f9", "MinhTuyet25" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "https://picsum.photos/640/480/?image=947", "3754708e-aec0-4f0a-a009-68aa8a8b3dc6", "MinhAnh.Duong59_Hoang75@yahoo.com", "MINHANH.DUONG59_HOANG75@YAHOO.COM", "MINHANH.DUONG59", "AQAAAAIAAYagAAAAEKLbVPdk2DfIGrN4szbhzbPcy/TKCheo3L4gyylrzORrbc2gyUboqrTbU8WZXL5Udw==", "024 4403 5222", "0996f3d5-e792-4f78-90a8-ff6c3c282833", "MinhAnh.Duong59" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "https://picsum.photos/640/480/?image=659", "f23b5f76-fcfb-416c-b4e9-e29251174f1e", "NgocQuynh_Mai.Ngo@gmail.com", "NGOCQUYNH_MAI.NGO@GMAIL.COM", "NGOCQUYNH_MAI", "AQAAAAIAAYagAAAAEBff9kw+iNSG63XJ2/XOUGm4aZcNqTpXX5dv+Qf9cIYpY3IcCwOt+CPGc//iJkIW+A==", "0219 2197 0983", "82214693-e3b1-4951-b3ec-271ebdcc9045", "NgocQuynh_Mai" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "https://picsum.photos/640/480/?image=384", "00109bb6-8817-45c0-9382-63dd13a5fccd", "NguyenSu8998@yahoo.com", "NGUYENSU8998@YAHOO.COM", "NGUYENSU89", "AQAAAAIAAYagAAAAENkoFSu7Lie04ZJ43+7c4UpZHlM7J7n7c0wdJ9scZOx+VBg1k21V1a8RJgekNmwMIg==", "024 7984 4634", "1a6e33ea-6fa5-47af-a286-18a778b060ca", "NguyenSu89" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "https://picsum.photos/640/480/?image=294", "2f331f30-b6ff-4a06-9088-4480c85603d2", "PhuongVy.Do94.Duong@gmail.com", "PHUONGVY.DO94.DUONG@GMAIL.COM", "PHUONGVY.DO94", "AQAAAAIAAYagAAAAEEZWd4daKGDptRNpQCusGOLPJ/wsi6q11ypm8Ahq7Nlrw1nrHknXFX+NqTS5UBi/gg==", "0247 5912 7133", "fd199b5e-c2bb-4dd1-b01b-bf4f21ec48ca", "PhuongVy.Do94" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "https://picsum.photos/640/480/?image=442", "15d71969-09b3-4fb6-9d21-5668acfe8e37", "QuangVu.Dinh98@yahoo.com", "QUANGVU.DINH98@YAHOO.COM", "QUANGVU.DINH", "AQAAAAIAAYagAAAAEAgyvnpMrP+RYJ9KwRsDx3BAaZe/iD9XEo5TJm+SV7/HtWi07U4co4zfytyMDvX8fw==", "022 1515 8827", "a57c3065-0882-47eb-a7de-1d6ffc0dfb06", "QuangVu.Dinh" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "https://picsum.photos/640/480/?image=472", "deaa9353-8e9b-48cd-a93b-b6b1237a1280", "ThienThu_Pham.Pham@hotmail.com", "THIENTHU_PHAM.PHAM@HOTMAIL.COM", "THIENTHU_PHAM", "AQAAAAIAAYagAAAAEChHw6DWuS4BiNT5w1SG8X9IDZ5dciz4Fgg7itORlCtdOOhi96cu/jWu9kXXj3H++w==", "025 9380 5563", "71ba5f77-e1b0-4b87-a5fe-32c6811614df", "ThienThu_Pham" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "https://picsum.photos/640/480/?image=727", "789f171c-af15-47ac-ac0f-b1c16894e81d", "ThanhKien74_To56@gmail.com", "THANHKIEN74_TO56@GMAIL.COM", "THANHKIEN74", "AQAAAAIAAYagAAAAEAGbUlvxCzwF0HnVpoe0M+a2bddPkCO4GiMdaW5BQxOs/dT639dk4Mi7ELa1tKtKkA==", "0261 5521 0945", "d9a2e67d-d245-444a-8f67-894bcbd2fe6d", "ThanhKien74" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "https://picsum.photos/640/480/?image=1009", "4a11ed07-3b86-4626-b51f-f7932660d179", "ThaoVy_Doan75_Dang@hotmail.com", "THAOVY_DOAN75_DANG@HOTMAIL.COM", "THAOVY_DOAN75", "AQAAAAIAAYagAAAAEPtcvtr9vAQ1G6QvX6JW3MAi2Z5uun4nrUV0IOPZ0rUuGQdai/DYH3HsQ5fVFETu8Q==", "023 8209 7454", "898d20a0-1a34-4b64-9f51-286a3acadc96", "ThaoVy_Doan75" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "https://picsum.photos/640/480/?image=1015", "4fda3d59-46cd-40ba-9cb3-57112ca23b67", "TienHiep.To_Doan81@gmail.com", "TIENHIEP.TO_DOAN81@GMAIL.COM", "TIENHIEP.TO", "AQAAAAIAAYagAAAAELGtY6lR475OT2gqSFF4pdUm9gQGkIOCHPjUSz/F64inxG/69s8SvPcwWa6+Y50U2A==", "0216 9563 8253", "48dbb949-ad82-45f5-899c-fda436b66bb9", "TienHiep.To" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "https://picsum.photos/640/480/?image=765", "6a6761c1-ed1d-4df9-9ac9-46ed1535d906", "TuyLinh3849@yahoo.com", "TUYLINH3849@YAHOO.COM", "TUYLINH38", "AQAAAAIAAYagAAAAECB3arIWNOXib7//t7Q3vce5l9CGxEJsa2j1utoQWXwFpEzLaH9bfk9nsJapSgQlVQ==", "0208 4613 0385", "e7e6632e-493e-4949-b4ab-29b2504c136d", "TuyLinh38" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "https://picsum.photos/640/480/?image=1024", "04d35dd0-3ad2-4689-9fc4-2921fa9fc704", "VanTuyen_Ngo10.Vuong44@yahoo.com", "VANTUYEN_NGO10.VUONG44@YAHOO.COM", "VANTUYEN_NGO10", "AQAAAAIAAYagAAAAEBoccC2M6EK1U9p6tXuU/w8H8xHUMX2f0EkTPkpMk0uMFk4auIxBQgpbGwVuSLE/Yg==", "0223 6067 4502", "4812c55f-6721-4fe8-b40a-a39f621a7a6b", "VanTuyen_Ngo10" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "https://picsum.photos/640/480/?image=648", "63570aec-f461-4843-97aa-d17ce292ae45", "YenNhi_Lam49@yahoo.com", "YENNHI_LAM49@YAHOO.COM", "YENNHI_LAM", "AQAAAAIAAYagAAAAEEVeRwa1WQ1dUH1lpBxV4IiOqrDpo4t/CITomQcPb0gF72fyc/tUC8MplKsK4Y6YXg==", "028 3001 7210", "1f6eaf36-d603-494e-a8a2-68dd86a1c9ac", "YenNhi_Lam" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "https://picsum.photos/640/480/?image=677", "e4d8b552-4777-4484-aba9-f979b9df643c", "BichHai2.Le@gmail.com", "BICHHAI2.LE@GMAIL.COM", "BICHHAI2", "AQAAAAIAAYagAAAAEApmLUtvGaZeRc4SifXPvvkFTH9KH7F3gJyBVKLWRuvHXh3Mta0HeK1UJgYOh5q/ng==", "021 0766 4856", "e4967879-13a7-4b7f-aaba-7fbac94a77ee", "BichHai2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "https://picsum.photos/640/480/?image=651", "77714fe6-a8e8-4274-9418-1891d4a0da85", "BaoBao.Dang45.Pham@gmail.com", "BAOBAO.DANG45.PHAM@GMAIL.COM", "BAOBAO.DANG45", "AQAAAAIAAYagAAAAEEaZBBCZcuSM+SGm7mPiOCloQqi9zKPi0LI5qskkbTSMaVvVLLUvbYYnW5CuyLTi2w==", "0285 3115 9362", "315f09d5-4a43-427f-acd2-0483834a79a3", "BaoBao.Dang45" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "https://picsum.photos/640/480/?image=695", "4dda4457-3a77-4d62-bd21-418391c4de05", "DieuHuyen.Vuong.To@hotmail.com", "DIEUHUYEN.VUONG.TO@HOTMAIL.COM", "DIEUHUYEN.VUONG", "AQAAAAIAAYagAAAAEO0lfjP+WYfdzSAwIH8JCbvV6Hel81Ldx+wCBytldbJldVB3ZezdnTD0+KA/LO49tw==", "0295 3078 1496", "3c015efd-3ac1-42e3-a6b5-78f65e134cab", "DieuHuyen.Vuong" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "https://picsum.photos/640/480/?image=30", "7a2e8a7f-e0ef-4e95-9249-f26b77416dff", "DanQue66_Dinh67@yahoo.com", "DANQUE66_DINH67@YAHOO.COM", "DANQUE66", "AQAAAAIAAYagAAAAEPz45b6R8sTffGCNeE66enwYOmUFvQpM5TqSk9AjsxoS+xm/iLFdyh2CAre1OvqZ6w==", "022 1725 7857", "ca2d3e6a-bfe2-4cf8-8a80-2fbbfcc6443c", "DanQue66" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "https://picsum.photos/640/480/?image=450", "b9801334-520b-46bb-ad13-fc7babc6278c", "HamNghi88.Doan@hotmail.com", "HAMNGHI88.DOAN@HOTMAIL.COM", "HAMNGHI88", "AQAAAAIAAYagAAAAEFiH8yqMaXFxPewUHLVTcrF74Gup8nN7vmQnJbRhooPbciBpoim5jDhXETEdS5e6BA==", "0260 9472 3217", "b4dfe8ae-8e4f-4718-99e4-c6dcf1a4dcfe", "HamNghi88" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "https://picsum.photos/640/480/?image=871", "c5765091-40b2-4c6c-b798-52c8436feec1", "DuyNgon.Duong26_Phung@yahoo.com", "DUYNGON.DUONG26_PHUNG@YAHOO.COM", "DUYNGON.DUONG26", "AQAAAAIAAYagAAAAELkAEl7LXdwQRYnMbdyx1YeLSeZg8D7P+yr6qCwIGHhQsnoGrXeIzJLYSexPbJFBOw==", "027 6129 0677", "3e05a530-17c6-4333-b54a-b33181160317", "DuyNgon.Duong26" });

            migrationBuilder.UpdateData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegisterDate",
                value: new DateTime(2023, 3, 12, 1, 40, 53, 669, DateTimeKind.Local).AddTicks(7347));

            migrationBuilder.UpdateData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 2,
                column: "RegisterDate",
                value: new DateTime(2022, 6, 16, 17, 8, 19, 311, DateTimeKind.Local).AddTicks(7436));

            migrationBuilder.UpdateData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AttendedDate", "RegisterDate" },
                values: new object[] { new DateTime(2023, 4, 9, 2, 27, 13, 203, DateTimeKind.Local).AddTicks(3112), new DateTime(2023, 4, 4, 3, 39, 50, 905, DateTimeKind.Local).AddTicks(4972) });

            migrationBuilder.UpdateData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AttendedDate", "RegisterDate" },
                values: new object[] { new DateTime(2022, 10, 21, 3, 28, 24, 323, DateTimeKind.Local).AddTicks(961), new DateTime(2022, 10, 20, 19, 39, 59, 314, DateTimeKind.Local).AddTicks(9565) });

            migrationBuilder.UpdateData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 5,
                column: "RegisterDate",
                value: new DateTime(2023, 2, 28, 5, 38, 48, 141, DateTimeKind.Local).AddTicks(2597));

            migrationBuilder.UpdateData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 6,
                column: "RegisterDate",
                value: new DateTime(2022, 11, 13, 16, 45, 6, 800, DateTimeKind.Local).AddTicks(2281));

            migrationBuilder.UpdateData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AttendedDate", "RegisterDate" },
                values: new object[] { new DateTime(2023, 3, 30, 21, 22, 13, 694, DateTimeKind.Local).AddTicks(6682), new DateTime(2023, 3, 23, 7, 37, 45, 377, DateTimeKind.Local).AddTicks(223) });

            migrationBuilder.UpdateData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AttendedDate", "RegisterDate" },
                values: new object[] { new DateTime(2022, 11, 9, 19, 20, 52, 840, DateTimeKind.Local).AddTicks(8846), new DateTime(2022, 10, 8, 13, 50, 14, 285, DateTimeKind.Local).AddTicks(4996) });

            migrationBuilder.UpdateData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AttendedDate", "RegisterDate" },
                values: new object[] { new DateTime(2023, 8, 22, 15, 32, 32, 512, DateTimeKind.Local).AddTicks(6372), new DateTime(2023, 8, 7, 3, 59, 21, 206, DateTimeKind.Local).AddTicks(812) });

            migrationBuilder.UpdateData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 10,
                column: "RegisterDate",
                value: new DateTime(2022, 11, 1, 10, 55, 21, 770, DateTimeKind.Local).AddTicks(7712));

            migrationBuilder.UpdateData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 11,
                column: "RegisterDate",
                value: new DateTime(2023, 8, 31, 1, 4, 28, 691, DateTimeKind.Local).AddTicks(3528));

            migrationBuilder.UpdateData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AttendedDate", "RegisterDate" },
                values: new object[] { new DateTime(2022, 10, 28, 13, 18, 24, 685, DateTimeKind.Local).AddTicks(5080), new DateTime(2022, 9, 26, 8, 0, 29, 256, DateTimeKind.Local).AddTicks(428) });

            migrationBuilder.UpdateData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AttendedDate", "RegisterDate" },
                values: new object[] { new DateTime(2023, 9, 24, 15, 42, 55, 756, DateTimeKind.Local).AddTicks(3755), new DateTime(2023, 9, 23, 22, 9, 36, 176, DateTimeKind.Local).AddTicks(6244) });

            migrationBuilder.UpdateData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 14,
                column: "RegisterDate",
                value: new DateTime(2024, 5, 14, 11, 31, 18, 985, DateTimeKind.Local).AddTicks(266));

            migrationBuilder.UpdateData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 15,
                column: "RegisterDate",
                value: new DateTime(2023, 8, 18, 19, 14, 43, 661, DateTimeKind.Local).AddTicks(8959));

            migrationBuilder.UpdateData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 16,
                column: "RegisterDate",
                value: new DateTime(2024, 6, 7, 8, 36, 26, 470, DateTimeKind.Local).AddTicks(2981));

            migrationBuilder.UpdateData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AttendedDate", "RegisterDate" },
                values: new object[] { new DateTime(2022, 8, 4, 3, 33, 43, 337, DateTimeKind.Local).AddTicks(79), new DateTime(2022, 7, 15, 19, 16, 45, 451, DateTimeKind.Local).AddTicks(2804) });

            migrationBuilder.UpdateData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AttendedDate", "RegisterDate" },
                values: new object[] { new DateTime(2024, 5, 15, 13, 15, 3, 213, DateTimeKind.Local).AddTicks(5667), new DateTime(2024, 5, 2, 5, 41, 33, 955, DateTimeKind.Local).AddTicks(5697) });

            migrationBuilder.UpdateData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 19,
                column: "RegisterDate",
                value: new DateTime(2022, 6, 9, 16, 21, 52, 936, DateTimeKind.Local).AddTicks(5520));

            migrationBuilder.UpdateData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 20,
                column: "RegisterDate",
                value: new DateTime(2024, 5, 26, 2, 46, 41, 440, DateTimeKind.Local).AddTicks(8413));

            migrationBuilder.UpdateData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AttendedDate", "RegisterDate" },
                values: new object[] { new DateTime(2022, 7, 27, 1, 25, 43, 624, DateTimeKind.Local).AddTicks(843), new DateTime(2022, 7, 3, 13, 27, 0, 421, DateTimeKind.Local).AddTicks(8236) });

            migrationBuilder.UpdateData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AttendedDate", "RegisterDate" },
                values: new object[] { new DateTime(2023, 2, 28, 10, 46, 46, 681, DateTimeKind.Local).AddTicks(6142), new DateTime(2023, 2, 21, 10, 29, 54, 645, DateTimeKind.Local).AddTicks(2412) });

            migrationBuilder.UpdateData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AttendedDate", "RegisterDate" },
                values: new object[] { new DateTime(2022, 8, 2, 12, 38, 58, 995, DateTimeKind.Local).AddTicks(9692), new DateTime(2022, 7, 27, 10, 32, 7, 907, DateTimeKind.Local).AddTicks(951) });

            migrationBuilder.UpdateData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 24,
                column: "RegisterDate",
                value: new DateTime(2023, 3, 16, 12, 28, 51, 881, DateTimeKind.Local).AddTicks(37));

            migrationBuilder.UpdateData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 25,
                column: "RegisterDate",
                value: new DateTime(2022, 6, 21, 7, 37, 15, 392, DateTimeKind.Local).AddTicks(3667));

            migrationBuilder.UpdateData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AttendedDate", "RegisterDate" },
                values: new object[] { new DateTime(2023, 4, 12, 17, 47, 4, 429, DateTimeKind.Local).AddTicks(5040), new DateTime(2023, 4, 8, 14, 27, 49, 116, DateTimeKind.Local).AddTicks(7662) });

            migrationBuilder.UpdateData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AttendedDate", "RegisterDate" },
                values: new object[] { new DateTime(2022, 11, 3, 8, 37, 15, 752, DateTimeKind.Local).AddTicks(8034), new DateTime(2022, 10, 25, 10, 8, 55, 395, DateTimeKind.Local).AddTicks(5796) });

            migrationBuilder.UpdateData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 28,
                column: "RegisterDate",
                value: new DateTime(2023, 3, 4, 16, 26, 46, 352, DateTimeKind.Local).AddTicks(5287));

            migrationBuilder.UpdateData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 29,
                column: "RegisterDate",
                value: new DateTime(2022, 9, 19, 7, 14, 2, 880, DateTimeKind.Local).AddTicks(8512));

            migrationBuilder.UpdateData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 30,
                column: "RegisterDate",
                value: new DateTime(2023, 3, 27, 18, 25, 43, 588, DateTimeKind.Local).AddTicks(2913));

            migrationBuilder.UpdateData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "AttendedDate", "RegisterDate" },
                values: new object[] { new DateTime(2022, 10, 20, 5, 6, 38, 726, DateTimeKind.Local).AddTicks(1660), new DateTime(2022, 10, 13, 4, 19, 10, 366, DateTimeKind.Local).AddTicks(1227) });

            migrationBuilder.UpdateData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "AttendedDate", "RegisterDate" },
                values: new object[] { new DateTime(2023, 9, 15, 7, 39, 6, 448, DateTimeKind.Local).AddTicks(7938), new DateTime(2023, 8, 11, 18, 28, 17, 286, DateTimeKind.Local).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 33,
                column: "RegisterDate",
                value: new DateTime(2022, 11, 6, 1, 24, 17, 851, DateTimeKind.Local).AddTicks(3943));

            migrationBuilder.UpdateData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 34,
                column: "RegisterDate",
                value: new DateTime(2023, 9, 4, 15, 33, 24, 771, DateTimeKind.Local).AddTicks(9759));

            migrationBuilder.UpdateData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "AttendedDate", "RegisterDate" },
                values: new object[] { new DateTime(2024, 4, 25, 13, 59, 22, 677, DateTimeKind.Local).AddTicks(7106), new DateTime(2024, 4, 25, 4, 55, 7, 580, DateTimeKind.Local).AddTicks(3781) });

            migrationBuilder.UpdateData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "AttendedDate", "RegisterDate" },
                values: new object[] { new DateTime(2023, 9, 30, 20, 56, 16, 861, DateTimeKind.Local).AddTicks(4839), new DateTime(2023, 9, 28, 12, 38, 32, 257, DateTimeKind.Local).AddTicks(2475) });

            migrationBuilder.UpdateData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "AttendedDate", "RegisterDate" },
                values: new object[] { new DateTime(2024, 6, 9, 4, 29, 36, 136, DateTimeKind.Local).AddTicks(187), new DateTime(2024, 5, 19, 2, 0, 15, 65, DateTimeKind.Local).AddTicks(6497) });

            migrationBuilder.UpdateData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 38,
                column: "RegisterDate",
                value: new DateTime(2023, 8, 23, 9, 43, 39, 742, DateTimeKind.Local).AddTicks(5191));

            migrationBuilder.UpdateData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 39,
                column: "RegisterDate",
                value: new DateTime(2024, 4, 12, 23, 5, 22, 550, DateTimeKind.Local).AddTicks(9212));

            migrationBuilder.UpdateData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "AttendedDate", "RegisterDate" },
                values: new object[] { new DateTime(2022, 7, 25, 0, 17, 2, 581, DateTimeKind.Local).AddTicks(4125), new DateTime(2022, 7, 20, 9, 45, 41, 531, DateTimeKind.Local).AddTicks(9035) });

            migrationBuilder.UpdateData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "AttendedDate", "RegisterDate" },
                values: new object[] { new DateTime(2024, 6, 1, 5, 26, 6, 825, DateTimeKind.Local).AddTicks(1244), new DateTime(2024, 5, 6, 20, 10, 30, 36, DateTimeKind.Local).AddTicks(1928) });

            migrationBuilder.UpdateData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 42,
                column: "RegisterDate",
                value: new DateTime(2022, 6, 14, 6, 50, 49, 17, DateTimeKind.Local).AddTicks(1751));

            migrationBuilder.UpdateData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 43,
                column: "RegisterDate",
                value: new DateTime(2024, 5, 30, 17, 15, 37, 521, DateTimeKind.Local).AddTicks(4644));

            migrationBuilder.UpdateData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 44,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 8, 3, 55, 56, 502, DateTimeKind.Local).AddTicks(4467));

            migrationBuilder.UpdateData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "AttendedDate", "RegisterDate" },
                values: new object[] { new DateTime(2023, 3, 21, 23, 46, 30, 984, DateTimeKind.Local).AddTicks(4325), new DateTime(2023, 2, 25, 21, 17, 52, 856, DateTimeKind.Local).AddTicks(5102) });

            migrationBuilder.UpdateData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "AttendedDate", "RegisterDate" },
                values: new object[] { new DateTime(2022, 8, 6, 14, 35, 17, 390, DateTimeKind.Local).AddTicks(2622), new DateTime(2022, 8, 1, 1, 1, 3, 987, DateTimeKind.Local).AddTicks(7183) });

            migrationBuilder.UpdateData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 47,
                column: "RegisterDate",
                value: new DateTime(2023, 3, 20, 23, 16, 50, 92, DateTimeKind.Local).AddTicks(2727));

            migrationBuilder.UpdateData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 48,
                column: "RegisterDate",
                value: new DateTime(2022, 10, 6, 3, 32, 43, 990, DateTimeKind.Local).AddTicks(9311));

            migrationBuilder.UpdateData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "AttendedDate", "RegisterDate" },
                values: new object[] { new DateTime(2023, 3, 5, 2, 27, 16, 652, DateTimeKind.Local).AddTicks(9315), new DateTime(2023, 2, 14, 1, 15, 47, 328, DateTimeKind.Local).AddTicks(352) });

            migrationBuilder.UpdateData(
                table: "EventRegistrations",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "AttendedDate", "RegisterDate" },
                values: new object[] { new DateTime(2022, 11, 13, 0, 52, 49, 39, DateTimeKind.Local).AddTicks(7622), new DateTime(2022, 10, 30, 0, 37, 51, 476, DateTimeKind.Local).AddTicks(2027) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 11, 0, 7, 19, 808, DateTimeKind.Local).AddTicks(3303), new DateTime(2024, 6, 11, 5, 58, 16, 966, DateTimeKind.Local).AddTicks(3036) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 4, 25, 22, 54, 29, 473, DateTimeKind.Local).AddTicks(3920), new DateTime(2023, 4, 12, 23, 36, 9, 750, DateTimeKind.Local).AddTicks(7589) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 19, 6, 16, 54, 515, DateTimeKind.Local).AddTicks(9757), new DateTime(2023, 10, 3, 15, 9, 7, 900, DateTimeKind.Local).AddTicks(5372) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 8, 17, 9, 52, 53, 405, DateTimeKind.Local).AddTicks(3609), new DateTime(2022, 8, 6, 18, 6, 2, 204, DateTimeKind.Local).AddTicks(6501) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 27, 6, 56, 29, 96, DateTimeKind.Local).AddTicks(7455), new DateTime(2022, 11, 16, 23, 32, 34, 722, DateTimeKind.Local).AddTicks(5914) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateOfBirth", "StudentCode" },
                values: new object[] { new DateTime(1954, 12, 25, 2, 0, 15, 906, DateTimeKind.Local).AddTicks(6436), 117008 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOfBirth", "StudentCode" },
                values: new object[] { new DateTime(2004, 2, 4, 2, 39, 42, 897, DateTimeKind.Local).AddTicks(6163), 114850 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateOfBirth", "StudentCode" },
                values: new object[] { new DateTime(2002, 12, 16, 5, 44, 57, 334, DateTimeKind.Local).AddTicks(1939), 256865 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateOfBirth", "StudentCode" },
                values: new object[] { new DateTime(1985, 5, 7, 6, 33, 53, 639, DateTimeKind.Local).AddTicks(9411), 282592 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateOfBirth", "StudentCode" },
                values: new object[] { new DateTime(2000, 12, 6, 9, 29, 38, 761, DateTimeKind.Local).AddTicks(3607), 189498 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateOfBirth", "StudentCode" },
                values: new object[] { new DateTime(1995, 5, 16, 15, 43, 54, 975, DateTimeKind.Local).AddTicks(7158), 205913 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateOfBirth", "StudentCode" },
                values: new object[] { new DateTime(1998, 11, 27, 13, 14, 20, 188, DateTimeKind.Local).AddTicks(5190), 233256 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateOfBirth", "StudentCode" },
                values: new object[] { new DateTime(1975, 5, 17, 11, 35, 42, 433, DateTimeKind.Local).AddTicks(968), 256344 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateOfBirth", "StudentCode" },
                values: new object[] { new DateTime(1996, 11, 17, 16, 59, 1, 615, DateTimeKind.Local).AddTicks(6787), 279431 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateOfBirth", "StudentCode" },
                values: new object[] { new DateTime(1970, 11, 13, 6, 51, 22, 329, DateTimeKind.Local).AddTicks(2463), 102518 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateOfBirth", "StudentCode" },
                values: new object[] { new DateTime(1994, 11, 8, 20, 43, 43, 42, DateTimeKind.Local).AddTicks(8207), 214216 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateOfBirth", "StudentCode" },
                values: new object[] { new DateTime(1960, 5, 13, 22, 10, 36, 609, DateTimeKind.Local).AddTicks(1957), 175876 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateOfBirth", "StudentCode" },
                values: new object[] { new DateTime(1992, 10, 30, 0, 28, 24, 469, DateTimeKind.Local).AddTicks(9666), 188560 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateOfBirth", "StudentCode" },
                values: new object[] { new DateTime(1991, 8, 16, 2, 4, 47, 351, DateTimeKind.Local).AddTicks(5053), 226078 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateOfBirth", "StudentCode" },
                values: new object[] { new DateTime(1980, 5, 20, 9, 6, 58, 533, DateTimeKind.Local).AddTicks(8575), 296006 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateOfBirth", "StudentCode" },
                values: new object[] { new DateTime(1972, 11, 16, 5, 58, 58, 93, DateTimeKind.Local).AddTicks(8068), 165934 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateOfBirth", "StudentCode" },
                values: new object[] { new DateTime(1988, 10, 11, 7, 57, 47, 324, DateTimeKind.Local).AddTicks(2568), 264131 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateOfBirth", "StudentCode" },
                values: new object[] { new DateTime(2004, 2, 18, 9, 53, 8, 836, DateTimeKind.Local).AddTicks(914), 287218 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateOfBirth", "StudentCode" },
                values: new object[] { new DateTime(1986, 10, 2, 11, 42, 28, 751, DateTimeKind.Local).AddTicks(3828), 175719 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateOfBirth", "StudentCode" },
                values: new object[] { new DateTime(1985, 5, 21, 13, 47, 19, 578, DateTimeKind.Local).AddTicks(3816), 245648 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateOfBirth", "StudentCode" },
                values: new object[] { new DateTime(1984, 9, 22, 15, 27, 10, 178, DateTimeKind.Local).AddTicks(5172), 115576 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateOfBirth", "StudentCode" },
                values: new object[] { new DateTime(1966, 8, 22, 17, 41, 30, 320, DateTimeKind.Local).AddTicks(6751), 185505 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateOfBirth", "StudentCode" },
                values: new object[] { new DateTime(1982, 9, 13, 19, 11, 51, 605, DateTimeKind.Local).AddTicks(6483), 202655 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateOfBirth", "StudentCode" },
                values: new object[] { new DateTime(1997, 11, 23, 21, 35, 41, 62, DateTimeKind.Local).AddTicks(9659), 125361 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateOfBirth", "StudentCode" },
                values: new object[] { new DateTime(1980, 9, 3, 22, 56, 33, 32, DateTimeKind.Local).AddTicks(7837), 195290 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateOfBirth", "StudentCode" },
                values: new object[] { new DateTime(1954, 8, 30, 12, 48, 53, 746, DateTimeKind.Local).AddTicks(3461), 271918 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateOfBirth", "StudentCode" },
                values: new object[] { new DateTime(1978, 8, 26, 2, 41, 14, 459, DateTimeKind.Local).AddTicks(9120), 200785 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateOfBirth", "StudentCode" },
                values: new object[] { new DateTime(2002, 8, 21, 16, 33, 35, 173, DateTimeKind.Local).AddTicks(4775), 162445 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateOfBirth", "StudentCode" },
                values: new object[] { new DateTime(1976, 8, 16, 6, 25, 55, 887, DateTimeKind.Local).AddTicks(412), 141179 });
        }
    }
}
