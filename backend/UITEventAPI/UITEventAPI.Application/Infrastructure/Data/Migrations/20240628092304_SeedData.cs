using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UITEventAPI.Application.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "UserId", "AccessFailedCount", "AvatarUrl", "ConcurrencyStamp", "Email", "EmailConfirmed", "IsActive", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 1, 0, "https://picsum.photos/640/480/?image=419", "8286d046-9740-a3e4-95cf-ff46699c73c4", "21521026@gm.uit.edu.vn", true, true, false, null, "21521026@GM.UIT.EDU.VN", "21521026", "AQAAAAIAAYagAAAAEC21ZOrvj/ThmhUIpIym0UKqKFec5f9vd//EsH+lnWXg7Dsh3iakX7GEUoIyDNg34g==", "0209 8805 5296", true, "3410cda1-5b13-a34e-6f84-a54adf7a0ea0", false, "21521026" },
                    { 2, 0, "https://picsum.photos/640/480/?image=285", "95c69371-b924-6fe3-7c38-98b7dd200bc1", "21522262@gm.uit.edu.vn", true, true, false, null, "21522262@GM.UIT.EDU.VN", "21522262", "AQAAAAIAAYagAAAAEBgHirMG6mB4xIZimGiA3HCWuG1L3V9wCxY64weW36AtLUxZx4HGx4eP2V36jfpQPg==", "020 3867 6002", true, "2eec1e16-bdf0-4616-f2a9-e6936c626933", false, "21522262" },
                    { 3, 0, "https://picsum.photos/640/480/?image=665", "a905569d-db07-3ae3-63a0-322750a4a3bd", "21522215@gm.uit.edu.vn", true, true, false, null, "21522215@GM.UIT.EDU.VN", "21522215", "AQAAAAIAAYagAAAAEIyKKQKZe4wlAmz/1ozB/tisa3oxU/hjDEZJyaK4pI8qPelDflDzmgAbRGBgvZPWwA==", "0206 8548 6858", true, "27c86e8c-1fcc-eade-75cf-27ddf84ac5c7", false, "21522215" },
                    { 4, 0, "https://picsum.photos/640/480/?image=787", "bc4519c8-fdeb-06e2-4a08-cc98c4273aba", "21521326@gm.uit.edu.vn", true, true, false, null, "21521326@GM.UIT.EDU.VN", "21521326", "AQAAAAIAAYagAAAAEHBPFdRsT3rhS6m+Fw7yi8xsnbymbuDaOCtjuPRdb6Kyi+ZhJdFmhnzoUtaBsbFDaw==", "0200 9310 2584", true, "20a4bf01-81a8-8da6-f9f5-68278432205a", false, "21521326" },
                    { 5, 0, "https://picsum.photos/640/480/?image=910", "cecf85dd-e21e-31d1-7165-0938abd2b776", "22521194@gm.uit.edu.vn", true, true, false, null, "22521194@GM.UIT.EDU.VN", "22521194", "AQAAAAIAAYagAAAAEE1WGH1I0bRDCwQl8vDYntjHfF4Gey+QPmq4K8JhFXRM8b1dOIR778/YYg5CZj0qfw==", "023 9171 7319", true, "841a8010-6ee4-7c30-1aa9-70101a7cede6", false, "22521194" },
                    { 6, 0, "https://picsum.photos/640/480/?image=1033", "b1e2c4a0-e140-189d-d9ff-7aab2e6ab3ec", "19524092@gm.uit.edu.vn", true, true, false, null, "19524092@GM.UIT.EDU.VN", "19524092", "AQAAAAIAAYagAAAAEDJipXCZY5rVS1km59ZKQg0TaynPClXI7ESPVYa4Gf3LIVL6HOGHYCIiCO6Xs/+7og==", "027 0043 3135", true, "60135c60-3746-ffd4-40ea-ba9d01d78138", false, "19524092" },
                    { 7, 0, "https://picsum.photos/640/480/?image=71", "95f60463-e162-ff68-4199-ea1fb201b061", "20528388@gm.uit.edu.vn", true, true, false, null, "20528388@GM.UIT.EDU.VN", "20528388", "AQAAAAIAAYagAAAAEH48cmKUQPWx4CogaYR7ndHJbqL4jYR/m4Zvj9Pde5YbbVbtxADZl3qdASSe1R19cg==", "020 0815 9861", true, "3c0d38b1-ffa8-8277-662a-0429e932148b", false, "20528388" },
                    { 8, 0, "https://picsum.photos/640/480/?image=193", "78094427-e084-e634-aa33-5b933599add7", "23525084@gm.uit.edu.vn", true, true, false, null, "23525084@GM.UIT.EDU.VN", "23525084", "AQAAAAIAAYagAAAAEPoDy7uD2YsOTWYs1GuSVuKomUFG430VcavsLGoXn8qsgGRJ6dJRkED7wR3U5JJtig==", "024 1687 4696", true, "18061401-c70a-051a-8b6b-4db5d18ea7dd", false, "23525084" },
                    { 9, 0, "https://picsum.photos/640/480/?image=316", "5c1c84ea-dfa6-ceff-12cc-cc06b931a94c", "22525421@gm.uit.edu.vn", true, true, false, null, "22525421@GM.UIT.EDU.VN", "22525421", "AQAAAAIAAYagAAAAEKNZ5aWEEGzGoCU4x/QW4FOogjTihoMvRVFt9Mk7pb6gFfuU6iQCstMA/53xY9QKSQ==", "027 1458 0422", true, "f5fff052-8f6d-88be-b1ac-9742b9e93a2f", false, "22525421" },
                    { 10, 0, "https://picsum.photos/640/480/?image=439", "3f2fc3ad-dfc8-b5cb-7a66-3d7a3cc8a6c2", "22528659@gm.uit.edu.vn", true, true, false, null, "22528659@GM.UIT.EDU.VN", "22528659", "AQAAAAIAAYagAAAAEB3NJ3LbTRkxaHGGmwlyyhZQcXPJp2dWWCXhNZuLWWc0vLS3xnC+y3utRz9QM9aPOA==", "021 1310 6148", true, "d1f9cca3-57cf-0b61-d6ed-e0cea144ce82", false, "22528659" },
                    { 11, 0, "https://picsum.photos/640/480/?image=562", "23420371-deea-9c96-e300-aeeec060a237", "20525753@gm.uit.edu.vn", true, true, false, null, "20525753@GM.UIT.EDU.VN", "20525753", "AQAAAAIAAYagAAAAEK178BmvBRic2P3LX1+6S+20HRCMe1NA608zEPFspGHtqaNgx5iQEPJWkEe8v/VTew==", "024 2182 2974", true, "adf2a8f3-1f31-8e04-fc2e-2a5a88a061d4", false, "20525753" },
                    { 12, 0, "https://picsum.photos/640/480/?image=685", "06564334-de0c-8362-4b9a-1e6143f89fac", "19522617@gm.uit.edu.vn", true, true, false, null, "19522617@GM.UIT.EDU.VN", "19522617", "AQAAAAIAAYagAAAAEIHpmCZmrKUzsybHqL20Nh58WC55LSXFDdR4/hkEK1NcKUUyl/nFnAsIDBYaZXrylQ==", "028 2953 7709", true, "89eb8544-e893-11a8-226f-74e670fbf427", false, "19522617" },
                    { 13, 0, "https://picsum.photos/640/480/?image=807", "ea6982f7-dd2d-6a2d-b433-8fd5c7909c22", "21524562@gm.uit.edu.vn", true, true, false, null, "21524562@GM.UIT.EDU.VN", "21524562", "AQAAAAIAAYagAAAAEN3Rq7ArJxBeHk2picqX9fU86kb8ZxQL0EttmsOrokvlhRTZRSnD7wYEyq3GBQ2dZQ==", "021 3725 3435", true, "65e56195-b0f6-944b-47b0-bd7358568779", false, "21524562" },
                    { 14, 0, "https://picsum.photos/640/480/?image=930", "cd7cc2ba-dd4f-51f9-1ccd-00494a279897", "23521674@gm.uit.edu.vn", true, true, false, null, "23521674@GM.UIT.EDU.VN", "23521674", "AQAAAAIAAYagAAAAELt50jxII8W660IZrKu8ZevE2b4O6t6nwO4g1QesrRR7eQmc8pmBQwZzfGMF8p9eqw==", "025 3697 9261", true, "41de3de5-7858-18ee-6df0-07ff40b21bcb", false, "23521674" },
                    { 15, 0, "https://picsum.photos/640/480/?image=1053", "b08f027e-dc71-38c4-8467-71bccebf950d", "23525656@gm.uit.edu.vn", true, true, false, null, "23525656@GM.UIT.EDU.VN", "23525656", "AQAAAAIAAYagAAAAEDQ4qivGZx7t9iEV5Fjai4n4NEZt7mWwgy4iu+o3ci/wlGvhvHXpuxkFqq6S+MEtnQ==", "028 4469 4087", true, "1dd81936-40ba-9b92-9331-508b280dae1e", false, "23525656" },
                    { 16, 0, "https://picsum.photos/640/480/?image=91", "94a24141-dc93-1f90-ed01-e13051579282", "19522251@gm.uit.edu.vn", true, true, false, null, "19522251@GM.UIT.EDU.VN", "19522251", "AQAAAAIAAYagAAAAEKNlDX/PMMMN4OwXj65tFKTgmOF5a1VbV8UXdkjeUDFUL9+VO7JnWiIpIB3KW9YRzw==", "022 4220 0712", true, "f9d1f586-081c-1e35-b872-9a170f694170", false, "19522251" },
                    { 17, 0, "https://picsum.photos/640/480/?image=214", "77b68104-dbb5-075b-559a-52a4d5ee8ef8", "19521559@gm.uit.edu.vn", true, true, false, null, "19521559@GM.UIT.EDU.VN", "19521559", "AQAAAAIAAYagAAAAEORMQyn7XK116NR6+sWdQQ/hzWRzw3zmtl187rQeFGOQUX4ruWwXnA+HuACSqiD30Q==", "025 4192 6548", true, "d6cad1d7-d07f-a1d8-deb3-e4a4f7c4d4c3", false, "19521559" },
                    { 18, 0, "https://picsum.photos/640/480/?image=336", "5bc9c1c8-dad7-ee27-bd34-c31858868b6d", "22526796@gm.uit.edu.vn", true, true, false, null, "22526796@GM.UIT.EDU.VN", "22526796", "AQAAAAIAAYagAAAAEBt8QYzsFYOsu8gTx2vrxJsSfn0ZPTTjhOZMm4SfDQaKn5S2yj1/tsRfJQY+kU9yVQ==", "029 5964 1374", true, "b2c4ad28-99e1-247c-04f4-2d30df1f6815", false, "22526796" },
                    { 19, 0, "https://picsum.photos/640/480/?image=459", "3edc018b-daf9-d5f2-26ce-348bdc1e87e2", "22521125@gm.uit.edu.vn", true, true, false, null, "22521125@GM.UIT.EDU.VN", "22521125", "AQAAAAIAAYagAAAAEEKHPwm9oRG+UTHqmBOoJRKZaz3jW/mmM3ExWolnuzXnZvF953Rx4FqDZRbTnakhuA==", "022 5735 7099", true, "8ebd8978-6143-a71f-2935-77bcc77bfb67", false, "22521125" },
                    { 20, 0, "https://picsum.photos/640/480/?image=582", "22ef404e-d91b-bcbe-8e68-a5ff5fb58458", "21526968@gm.uit.edu.vn", true, true, false, null, "21526968@GM.UIT.EDU.VN", "21526968", "AQAAAAIAAYagAAAAEGYeOYunA7bymouWow1rZ3lzMFL7ELDJ9ff4KI41ZmOE5FtRj9Zh45PawXyhmpcYtA==", "026 6507 3825", true, "6ab765c9-29a5-2ac3-4f76-c149afd68eba", false, "21526968" },
                    { 21, 0, "https://picsum.photos/640/480/?image=1062", "05038011-d93c-a389-f701-1573e34d81cd", "21523623@gm.uit.edu.vn", true, true, false, null, "21523623@GM.UIT.EDU.VN", "21523623", "AQAAAAIAAYagAAAAEE5IhnEaQe6vngYkKFWNNOe3DI4EdfPgccWCMM3Ouqr/kQ9RNoer84VmLUlKB1TkpQ==", "0296 4698 6516", true, "46b0411a-f108-ad66-75b6-0ad59631210c", false, "21523623" },
                    { 22, 0, "https://picsum.photos/640/480/?image=549", "e916c0d5-d85e-8a55-5f9b-86e666e57d43", "20521405@gm.uit.edu.vn", true, true, false, null, "20521405@GM.UIT.EDU.VN", "20521405", "AQAAAAIAAYagAAAAEEf24qboZMx6w0y35CjwkdBU9dFtG38aZ0HbMQIm4rT5Ewjzts4knbyLDhO5tZ7hKg==", "0237 2314 3877", true, "22a91d6a-b96a-3009-9af7-54617e8db55f", false, "20521405" },
                    { 23, 0, "https://picsum.photos/640/480/?image=36", "cc29ff98-d880-7120-c735-f75aea7d7ab8", "23529120@gm.uit.edu.vn", true, true, false, null, "23529120@GM.UIT.EDU.VN", "23529120", "AQAAAAIAAYagAAAAEMOCog3OFeukMmIyej86ndwECFGMQ04afS1sjJjr78QTfuE0x3T+TkqaSxAul5ZHMA==", "0267 0020 1128", true, "fea3f9bb-81cc-b3ad-c038-9ded66e848b1", false, "23529120" },
                    { 24, 0, "https://picsum.photos/640/480/?image=608", "b03c3f5b-d7a2-58ec-30ce-68ce6d14772d", "20525750@gm.uit.edu.vn", true, true, false, null, "20525750@GM.UIT.EDU.VN", "20525750", "AQAAAAIAAYagAAAAENDLK3gmb197KXOUmV3yjZehA8wlu5YfGpcW00meLFHia8iM79NrP1HH5mcj5x940Q==", "0208 9745 9389", true, "db9cd50b-4a2e-3750-e579-e77a4e44db03", false, "20525750" },
                    { 25, 0, "https://picsum.photos/640/480/?image=95", "934f7f1f-d7c4-40b7-9868-d841f1ac73a3", "23527643@gm.uit.edu.vn", true, true, false, null, "23527643@GM.UIT.EDU.VN", "23527643", "AQAAAAIAAYagAAAAECMD4W2ww7sMOSKinzfFi1kaiiGjTnuBs/YJXePpRlKgjfRn1P0Py/visP7OMAJtNw==", "0238 7461 6641", true, "b795b15c-1290-baf3-0bba-3106369f6f56", false, "23527643" },
                    { 26, 0, "https://picsum.photos/640/480/?image=667", "7663bee2-d6e6-2783-0002-49b574447018", "21529446@gm.uit.edu.vn", true, true, false, null, "21529446@GM.UIT.EDU.VN", "21529446", "AQAAAAIAAYagAAAAEP/2XMWIHzAgVwpBNNZPnbSipAoQkG+RXWepA2VdkcVt9ohtbf1YlMVMF6GhIo6+ng==", "0278 5077 4992", true, "938f8dad-daf3-3d97-31fb-7a921efa02a8", false, "21529446" },
                    { 27, 0, "https://picsum.photos/640/480/?image=154", "5a76fea5-d608-0e4e-699c-ba29f8db6c8e", "22521574@gm.uit.edu.vn", true, true, false, null, "22521574@GM.UIT.EDU.VN", "22521574", "AQAAAAIAAYagAAAAENqC7/HzTX88zzbmfNEyeWsOeIMdHFBMikbvlI3hxMGCjf6S9W/CVIBDdIhg8XDyyw==", "0209 3792 2253", true, "6f8869fd-a255-c03a-563c-c41f055695fb", false, "22521574" },
                    { 28, 0, "https://picsum.photos/640/480/?image=726", "3d893e69-d52a-f51a-d135-2b9c7c736903", "19527020@gm.uit.edu.vn", true, true, false, null, "19527020@GM.UIT.EDU.VN", "19527020", "AQAAAAIAAYagAAAAEEtuzJBqMZQiCHEJrI+owfyhraQPAWiZQ1UslN2SK1DuxFQODlZ5fHnspuUcK5lArQ==", "0249 2418 0414", true, "4b82454e-6ab7-43dd-7c7d-0eabedb1284d", false, "19527020" },
                    { 29, 0, "https://picsum.photos/640/480/?image=213", "219c7e2c-d44b-dce5-39cf-9c10ff0b6679", "19524989@gm.uit.edu.vn", true, true, false, null, "19524989@GM.UIT.EDU.VN", "19524989", "AQAAAAIAAYagAAAAEDJh+Pyqnov2l/KvubewYTVPU0cqxQUZ428qQzpcSE0JSwK7INtaAcJRp1UPRRlwrg==", "0270 0134 7775", true, "277b219e-3219-c681-a2bd-5737d50cbc9f", false, "19524989" },
                    { 30, 0, "https://picsum.photos/640/480/?image=785", "04afbdef-d46d-c3b1-a269-0c8483a262ee", "21524800@gm.uit.edu.vn", true, true, false, null, "21524800@GM.UIT.EDU.VN", "21524800", "AQAAAAIAAYagAAAAEMlK5F0rjXE0xBHo0RsRWZVUaaqfJ1TWF8XNcaiA/aaa/2CfLLfnnIXF06oCObThgg==", "0210 8849 5026", true, "0374fdef-fb7c-4924-c7fe-a1c3bd684ff2", false, "21524800" },
                    { 31, 0, "https://picsum.photos/640/480/?image=272", "e8c3fdb2-d38f-aa7c-0a03-7df7063a5f63", "23529672@gm.uit.edu.vn", true, true, false, null, "23529672@GM.UIT.EDU.VN", "23529672", "AQAAAAIAAYagAAAAEH2GGVmXT7AicpjsePvXPEKpO8lMQOopvv1i6wKhLhUdSMdhdyC4F7/7bDElYlf4kA==", "0241 7565 3387", true, "df6ed940-c3de-ccc7-ed3f-ea50a5c3e244", false, "23529672" },
                    { 32, 0, "https://picsum.photos/640/480/?image=844", "cbd63d76-d3b1-9148-739c-ee6b8ad25cd9", "23527087@gm.uit.edu.vn", true, true, false, null, "23527087@GM.UIT.EDU.VN", "23527087", "AQAAAAIAAYagAAAAEJIQ4IvTeL9o8+MuJFh/Y3C4OxmTyZM1c654DvgFrMUgxDXw0d07+qO4WPkSgnHt6Q==", "0281 5181 0648", true, "bc67b590-8b40-4f6b-1380-34dc8c1f7597", false, "23527087" },
                    { 33, 0, "https://picsum.photos/640/480/?image=331", "afe97c39-d2d3-7913-db36-5fdf0d6a584e", "23524630@gm.uit.edu.vn", true, true, false, null, "23524630@GM.UIT.EDU.VN", "23524630", "AQAAAAIAAYagAAAAEAX8ELIWBCoc56FAPf3aHVAK7kADITSWxQczUvtrt+JS7aquvLMkRxclBexvogjjVQ==", "0211 3896 8890", true, "986191e1-53a2-d20e-38c1-7e68747a09e9", false, "23524630" },
                    { 34, 0, "https://picsum.photos/640/480/?image=903", "92fcbcfc-d2f5-60df-43d0-d053910155c4", "19523490@gm.uit.edu.vn", true, true, false, null, "19523490@GM.UIT.EDU.VN", "19523490", "AQAAAAIAAYagAAAAEMUyxNKtGCiO0wto8F+ZzepS2vIL/Ayl5SBcJ2djIscPQoUo1ERK3+JahJel+OpTfA==", "0252 1512 6151", true, "745a6d32-1b05-56b1-5e02-c7f45cd59c3b", false, "19523490" },
                    { 35, 0, "https://picsum.photos/640/480/?image=669", "177610fc-abd1-ac47-6a40-c61499513982", "22524714@gm.uit.edu.vn", true, true, false, null, "22524714@GM.UIT.EDU.VN", "22524714", "AQAAAAIAAYagAAAAEE3pWhMaPo6sKikv3urZjG7SpmaYwS/ChcMY9B1e37mBVTKxQ7SSlwU546gOIkXy7w==", "0220 2383 4123", true, "67505349-55e3-84d9-4311-8144312f8e67", false, "22524714" },
                    { 36, 0, "https://picsum.photos/640/480/?image=963", "59233b83-d139-2e76-1403-b13a98314eae", "19522611@gm.uit.edu.vn", true, true, false, null, "19522611@GM.UIT.EDU.VN", "19522611", "AQAAAAIAAYagAAAAEG/8Z6UzdUqEksQ3AtYsAihIx+OovlBpHYZZRHJwXbCYdhNuefQuYyEMfEvWxT264w==", "0223 8953 1773", true, "2c4d25d3-acc9-5cf8-a983-5a0d2c8cc2e0", false, "19522611" },
                    { 37, 0, "https://picsum.photos/640/480/?image=450", "3c367b46-d05a-1542-7c9d-22ae1bc84b24", "23526000@gm.uit.edu.vn", true, true, false, null, "23526000@GM.UIT.EDU.VN", "23526000", "AQAAAAIAAYagAAAAEFc3C1WYjWDc/3Q4vvS98lF/Atxa8Tj3ldwvKy/048gctDGZq43O3gNurw3hzP1C4w==", "0253 6569 9924", true, "08460123-742b-df9b-cfc4-a49913e75633", false, "23526000" },
                    { 38, 0, "https://picsum.photos/640/480/?image=1022", "2049bb09-cf7c-fc0d-e537-93219f604799", "19527406@gm.uit.edu.vn", true, true, false, null, "19527406@GM.UIT.EDU.VN", "19527406", "AQAAAAIAAYagAAAAENpE9GknEYRtF5WAo9rMUz5BqftKj8vfwFYlXsLQp3nF7AQjtiiGZWAOz2bNx7LzFw==", "0294 5285 6285", true, "e440dd74-3c8e-623f-f405-ee26fb43e985", false, "19527406" },
                    { 39, 0, "https://picsum.photos/640/480/?image=509", "035cfbcd-cf9e-e3d9-4dd1-039522f8440f", "23526143@gm.uit.edu.vn", true, true, false, null, "23526143@GM.UIT.EDU.VN", "23526143", "AQAAAAIAAYagAAAAEF09SjDUBgQxBH1pmmRRXOuosZfBwSk0kFPa1iEMguSC501yQmrkV74QJNQcEfs/JQ==", "0224 3901 4546", true, "c039b9c5-04f0-e5e2-1a46-37b2e39e7cd7", false, "23526143" },
                    { 40, 0, "https://picsum.photos/640/480/?image=1081", "e7703a90-cec0-caa4-b66a-7409a68f4184", "22527012@gm.uit.edu.vn", true, true, false, null, "22527012@GM.UIT.EDU.VN", "22527012", "AQAAAAIAAYagAAAAEL6rqZzs14SxqxQKbkhTcD3lMSkm6QrfhfnQTJZKwMwM5HIQqObAjy15U8Oa8UKYGw==", "0264 1616 2808", true, "9d329515-cc52-6886-4087-813ecbf90f2a", false, "22527012" },
                    { 41, 0, "https://picsum.photos/640/480/?image=990", "ca837a53-cee2-b270-1e04-e57c29273dfa", "23525333@gm.uit.edu.vn", true, true, false, null, "23525333@GM.UIT.EDU.VN", "23525333", "AQAAAAIAAYagAAAAEJLR7GVXfjH2tFWTiy5LsnCnknBZEe+C3LADmIOuICfLx4/4gvtUlPFZIXlf9z3a5Q==", "029 5933 2915", true, "792c7166-94b4-eb29-65c8-cbcab355a37c", false, "23525333" },
                    { 42, 0, "https://picsum.photos/640/480/?image=28", "ae96ba17-cd04-993b-869e-56f0adbf3a6f", "21527943@gm.uit.edu.vn", true, true, false, null, "21527943@GM.UIT.EDU.VN", "21527943", "AQAAAAIAAYagAAAAEMKS1PkwiQ1IYpAd0vbhze6r45TPen4VeZORAljeSWmZmsgbm+1hF6frkL9VqGRboA==", "023 5805 8731", true, "55254db7-5d17-6ecc-8b09-14579ab036cf", false, "21527943" },
                    { 43, 0, "https://picsum.photos/640/480/?image=151", "91a9f9da-cd26-8007-ef37-c764305736e4", "22521905@gm.uit.edu.vn", true, true, false, null, "22521905@GM.UIT.EDU.VN", "22521905", "AQAAAAIAAYagAAAAEG1ZZZ6Vph9aAnVjIB8KXwGB93sHpH95ZeTqaXobPKjHBy7sE0Sc6PzvFoWOHWexqA==", "026 6667 3567", true, "311e2907-2579-f170-b149-5ee3820cc921", false, "22521905" },
                    { 44, 0, "https://picsum.photos/640/480/?image=274", "75bc399d-cc48-67d2-57d1-37d7b4ee335a", "21524135@gm.uit.edu.vn", true, true, false, null, "21524135@GM.UIT.EDU.VN", "21524135", "AQAAAAIAAYagAAAAEN9or1/IiUbIoI7i4KStOF1sDXHSLJykDLRluPMUR3gip8VNSdXg1OOD6IaePbWYZA==", "020 6438 9292", true, "0d180558-eddb-7513-d68a-a76f6a675d73", false, "21524135" },
                    { 45, 0, "https://picsum.photos/640/480/?image=396", "58d07961-cc69-4e9e-bf6b-a84b378630cf", "19521984@gm.uit.edu.vn", true, true, false, null, "19521984@GM.UIT.EDU.VN", "19521984", "AQAAAAIAAYagAAAAEKXSw62DFixWVN3aLKvgYuyAbDO8Wt41foUOftuvl8USqjNTKJ5ClFPi3c5fdxMTCw==", "023 7300 5028", true, "e911e1a8-b53d-f8b6-fccb-f1fb52c2f0c6", false, "19521984" },
                    { 46, 0, "https://picsum.photos/640/480/?image=519", "3be3b824-cb8b-3569-2805-19bfbb1e2c45", "23521125@gm.uit.edu.vn", true, true, false, null, "23521125@GM.UIT.EDU.VN", "23521125", "AQAAAAIAAYagAAAAEBpFxNj7fC1BB2XF2r/9HIXdtx7yu4PydOi0fXWrdr25dg4uf1HigFQifexd86K1jQ==", "027 7172 0844", true, "c50bbdf9-7da0-7b5a-220c-3b883a1e8318", false, "23521125" },
                    { 47, 0, "https://picsum.photos/640/480/?image=642", "1ff6f8e7-caad-1c35-909e-8a323eb529ba", "19528160@gm.uit.edu.vn", true, true, false, null, "19528160@GM.UIT.EDU.VN", "19528160", "AQAAAAIAAYagAAAAEIusDz9pfpqSyAcLcHSod0Qa14std2F3Uh2AKFICbB3bU60U7jDYaY+W3jj8P4rtJQ==", "020 7943 6570", true, "a204994a-4502-fefd-474d-84142179166b", false, "19528160" },
                    { 48, 0, "https://picsum.photos/640/480/?image=765", "020938aa-cacf-0300-f838-faa6c24d2630", "21522897@gm.uit.edu.vn", true, true, false, null, "21522897@GM.UIT.EDU.VN", "21522897", "AQAAAAIAAYagAAAAEBCWOdrTO+5JwerLXIx83faW1vFgWLFTxMVqtZjXKJO5uaxTLc5CBt8lIY75UC/gNA==", "024 8705 2305", true, "7efd759a-0e64-81a0-6d8e-cea009d4aabd", false, "21522897" },
                    { 49, 0, "https://picsum.photos/640/480/?image=888", "e61d786e-c9f1-ebcc-61d2-6b1a45e522a5", "20522137@gm.uit.edu.vn", true, true, false, null, "20522137@GM.UIT.EDU.VN", "20522137", "AQAAAAIAAYagAAAAEIA8JDH1xIn4V3jMpjTGGJouaSJOBdmw/JRVs9lOk2hYwv6+gC+TTds8aRQFbznLCQ==", "027 8677 7131", true, "5af752eb-d6c6-0444-93cf-182df1303d10", false, "20522137" },
                    { 50, 0, "https://picsum.photos/640/480/?image=1010", "c930b731-c913-d297-c96c-dc8ec97c1f1a", "22525846@gm.uit.edu.vn", true, true, false, null, "22525846@GM.UIT.EDU.VN", "22525846", "AQAAAAIAAYagAAAAEIQO4BftdHYFSyPru/Mcx60b8QffuN1SSpnlaz+qQmij1k5MpSzt59WmyYk6YJRnHw==", "021 9449 3867", true, "36f02e3b-9e29-87e7-b80f-61b9d98bd062", false, "22525846" },
                    { 51, 0, "https://picsum.photos/640/480/?image=48", "ad43f7f4-c835-b963-3205-4d014d141b90", "23528867@gm.uit.edu.vn", true, true, false, null, "23528867@GM.UIT.EDU.VN", "23528867", "AQAAAAIAAYagAAAAEAG+b9YdeS/a4Y8rQncwl9c+qF6lb0Ucn+5kI2Y2x58qqi5mefLitXnnkVIRY5ufkQ==", "024 9210 9682", true, "12ea0a8c-668b-0a8a-de50-ab45c1e763b4", false, "23528867" },
                    { 52, 0, "https://picsum.photos/640/480/?image=171", "905637b8-c857-a02e-9a9f-be75d0ac1805", "19529323@gm.uit.edu.vn", true, true, false, null, "19529323@GM.UIT.EDU.VN", "19529323", "AQAAAAIAAYagAAAAENsy/Uup6XUun/7lbEq6cbT7YToZPfLV0KEupJ78hCnE9LcFvYNHrKDQz1kxj6FmGw==", "027 0182 4418", true, "eee3e6dd-2eed-8d2e-0391-f4d1a842f707", false, "19529323" },
                    { 53, 0, "https://picsum.photos/640/480/?image=294", "7469767b-c778-87fa-0239-2ee95444157b", "19525954@gm.uit.edu.vn", true, true, false, null, "19525954@GM.UIT.EDU.VN", "19525954", "AQAAAAIAAYagAAAAEJtvHPL2KqelwaLPA6eXOqpjvbm9IIyzojAuSIlBoil6SppHwLR1Wj3a+TJdfeK7ag==", "021 0954 0144", true, "cadcc22d-f64f-10d1-29d2-3e5e909d8a59", false, "19525954" },
                    { 54, 0, "https://picsum.photos/640/480/?image=416", "577db63e-c79a-6ec5-6bd3-9f5cd7db11f0", "20528585@gm.uit.edu.vn", true, true, false, null, "20528585@GM.UIT.EDU.VN", "20528585", "AQAAAAIAAYagAAAAEOokQAB8UCc4azvwxxHy9P16MnwLiSKy0EtApbARa+MIwjxwAQgCcbPLARWmfAyMMw==", "024 1715 6970", true, "a6d69e7e-bfb2-9374-4f13-88ea78f91dac", false, "20528585" },
                    { 55, 0, "https://picsum.photos/640/480/?image=539", "3b90f601-c6bc-5591-d36c-10d05b730e65", "22529422@gm.uit.edu.vn", true, true, false, null, "22529422@GM.UIT.EDU.VN", "22529422", "AQAAAAIAAYagAAAAEOfowkJMVwjNHTPEMSDXhuctK1gZXRDPkTH0gQLUxMq7R13teBRJYukpD9ShztFSYA==", "028 1587 1795", true, "83cf7acf-8714-1718-7454-d1766054b0fe", false, "22529422" },
                    { 56, 0, "https://picsum.photos/640/480/?image=662", "1ea335c5-c5de-3c5c-3b06-8144de0b0bdb", "20522274@gm.uit.edu.vn", true, true, false, null, "20522274@GM.UIT.EDU.VN", "20522274", "AQAAAAIAAYagAAAAEI19L/iR35zuhAWK/3GyXqSBIFPjEM/KFXGPZpTWcd3QrNfgWrAq6m4RSxwixcenhw==", "021 1459 7421", true, "5fc8561f-4f76-9abb-9a95-1b0348af4450", false, "20522274" },
                    { 57, 0, "https://picsum.photos/640/480/?image=785", "01b67588-c500-2428-a4a0-f1b762a20750", "20528162@gm.uit.edu.vn", true, true, false, null, "20528162@GM.UIT.EDU.VN", "20528162", "AQAAAAIAAYagAAAAELHWOk4voh9IEDeLpDnsiFWY5OZZ6pet5zEsKEuGFquyW4xRATEIW9ul8KuT7umX/w==", "025 2221 3257", true, "3bc23270-17d8-1d5e-c0d5-658f2f0bd7a3", false, "20528162" },
                    { 58, 0, "https://picsum.photos/640/480/?image=75", "f3c422e5-0c0b-623a-2be5-3a04c6c00ebb", "21525160@gm.uit.edu.vn", true, true, false, null, "21525160@GM.UIT.EDU.VN", "21525160", "AQAAAAIAAYagAAAAELSVV5Qhno+S7Xa/Z3I5GKgTXqy4XO+srM31+6pHjKQlyzWdMbwLAMYQQ63US/C4pQ==", "029 2808 3848", true, "02df3b17-e5a0-ae16-1b17-666af5f6ad2c", false, "21525160" },
                    { 59, 0, "https://picsum.photos/640/480/?image=1030", "c8ddf50f-c444-f2bf-75d3-d39f69d2003b", "23523150@gm.uit.edu.vn", true, true, false, null, "23523150@GM.UIT.EDU.VN", "23523150", "AQAAAAIAAYagAAAAEHFZeY7oNDdNnYqNHy9amq/Brpn/A0EmZVqAzDg6vhJvXxyiKkO9UAkBi+xfFDjNcg==", "022 3954 4718", true, "f3b5ea11-a79d-23a5-0b57-f8a7ffc1fd48", false, "23523150" },
                    { 60, 0, "https://picsum.photos/640/480/?image=68", "acf034d2-c365-d98a-dd6d-4412ec69fdb1", "21528211@gm.uit.edu.vn", true, true, false, null, "21528211@GM.UIT.EDU.VN", "21528211", "AQAAAAIAAYagAAAAEBCdMRvdqfpl7VRxTQ/TxkKAqNeimi0Yc7NIv+jXTm/beTPOXAz5LwsYeMoGgGQcAA==", "025 3726 0534", true, "cfaec662-70ff-a648-3198-4134e71d919a", false, "21528211" },
                    { 61, 0, "https://picsum.photos/640/480/?image=74", "8f037495-c387-c056-4507-b5867001fa26", "19523331@gm.uit.edu.vn", true, true, false, null, "19523331@GM.UIT.EDU.VN", "19523331", "AQAAAAIAAYagAAAAEM80FScpLzVRSlTVr00k24oZRzP7iDtVtQL+1DZE1fML1s/tljLE9dvplpVeBA4QDQ==", "0294 5975 3601", true, "aba7a2b2-3861-29ec-56d9-8bc0cf7824ec", false, "19523331" },
                    { 62, 0, "https://picsum.photos/640/480/?image=646", "7316b459-c2a9-a721-aea0-25faf399f69b", "19528922@gm.uit.edu.vn", true, true, false, null, "19528922@GM.UIT.EDU.VN", "19528922", "AQAAAAIAAYagAAAAECfmc+LoQ3r4cUyfOnQP3DvHq6Sbj0+mlBQvviFxTzqTt1On4qYdJ6+G1czyi1pqkQ==", "0224 3691 1952", true, "88a17e03-00c4-ac8f-7c1a-d54cb7d4b73f", false, "19528922" },
                    { 63, 0, "https://picsum.photos/640/480/?image=133", "562af31c-c2cb-8eed-163a-966d7731f311", "20529488@gm.uit.edu.vn", true, true, false, null, "20529488@GM.UIT.EDU.VN", "20529488", "AQAAAAIAAYagAAAAELczfzzljo0SnqcNaSYU37vLyySl+ptSi0gvtL4acpczzC/PtCcvtZZdMz7UonO0jw==", "0264 2317 8214", true, "649a5a54-c826-2f33-a25b-1ed89e2f4b91", false, "20529488" },
                    { 64, 0, "https://picsum.photos/640/480/?image=705", "3a3d33df-c1ed-75b8-7ed4-07e1fac8ef86", "21522295@gm.uit.edu.vn", true, true, false, null, "21522295@GM.UIT.EDU.VN", "21522295", "AQAAAAIAAYagAAAAENkK1IY5DUWOrAQbt23fbH3iTlg3wDzTcz1xPo9stv6lIUAvhXPbMH3KzSlT8NxYMA==", "0295 0932 6475", true, "409436a4-9088-b2d6-c79b-6865868adee4", false, "21522295" },
                    { 65, 0, "https://picsum.photos/640/480/?image=192", "1d5073a2-c10f-5d84-e76e-78557e60ecfc", "22521877@gm.uit.edu.vn", true, true, false, null, "22521877@GM.UIT.EDU.VN", "22521877", "AQAAAAIAAYagAAAAEF0WZF/UznVOsOkCo/I1HSQ8ONcLicrLyVQjwlhwW3EUWaSGFKydyIkXHnReRf3oCw==", "0235 8648 4736", true, "1c8d12f5-58ea-3679-eddc-b1f16ee67136", false, "22521877" },
                    { 66, 0, "https://picsum.photos/640/480/?image=764", "0163b266-c031-444f-4f07-e8c901f8e971", "20523910@gm.uit.edu.vn", true, true, false, null, "20523910@GM.UIT.EDU.VN", "20523910", "AQAAAAIAAYagAAAAEEXapjh2jcyiZCFlbfEFrPEEdDOWav2QH0UBd9/xPk9gVu39MjJpxdzGvnP5NEdDmA==", "0266 7364 1087", true, "f886ee45-214d-b91d-121d-fb7d56410488", false, "20523910" },
                    { 67, 0, "https://picsum.photos/640/480/?image=251", "e476f229-bf53-2b1b-b7a1-593c858fe5e7", "21521231@gm.uit.edu.vn", true, true, false, null, "21521231@GM.UIT.EDU.VN", "21521231", "AQAAAAIAAYagAAAAEN4fmeKi6X5tceKAMUqwsfMSMH5FykVUF84717MOzRZP1YbWuEulCXGGmbkgy/KmlA==", "0206 5080 9348", true, "d480ca96-e9af-3cc0-385e-450a3e9c98db", false, "21521231" },
                    { 68, 0, "https://picsum.photos/640/480/?image=823", "c78a32ec-bf74-12e6-203b-cab00827e25c", "23529748@gm.uit.edu.vn", true, true, false, null, "23529748@GM.UIT.EDU.VN", "23529748", "AQAAAAIAAYagAAAAEIRZYGpTrNM9vKBy4TZZcfVUEV5zYqVHUc+r2irbVykGhieusJLsv9f2+qn4J2ucKQ==", "0237 3795 7609", true, "b079a6e7-b111-bf63-5e9f-8e9625f82b2d", false, "23529748" },
                    { 69, 0, "https://picsum.photos/640/480/?image=310", "ab9d71b0-be96-f9b2-88d5-3b248cbfdfd1", "21524672@gm.uit.edu.vn", true, true, false, null, "21524672@GM.UIT.EDU.VN", "21524672", "AQAAAAIAAYagAAAAECI6AwGzKensA2ZqkjoNMDk9m6vh12l9NGJxF50mMj1DZ/Rij9xhK7RJzKwMFZUlMg==", "0277 1411 4850", true, "8c738237-7973-4207-83e0-d8220d53be80", false, "21524672" },
                    { 70, 0, "https://picsum.photos/640/480/?image=882", "8eb0b173-beb8-e07d-f16e-ac970f56db47", "20527630@gm.uit.edu.vn", true, true, false, null, "20527630@GM.UIT.EDU.VN", "20527630", "AQAAAAIAAYagAAAAEIKkBXuVIMFNlQvQ4jRx51ygMLjRrq5n40V8dSGNV7Vj05toAPANVq0l//OOLjewhg==", "0207 0037 2111", true, "696c5e88-41d6-c5aa-a921-22aef5af51d2", false, "20527630" },
                    { 71, 0, "https://picsum.photos/640/480/?image=369", "72c3f136-bdda-c749-5908-1c0b93eed8bc", "22528008@gm.uit.edu.vn", true, true, false, null, "22528008@GM.UIT.EDU.VN", "22528008", "AQAAAAIAAYagAAAAEEvjyzLPXg8XzkOcL8qHnUoM/cV/yy8kFcCcwiWL+gukb3s3KAQVkllHZadWwPdpsA==", "0248 8752 0473", true, "45653ad9-0938-484d-cf61-6b3bdd0ae524", false, "22528008" },
                    { 72, 0, "https://picsum.photos/640/480/?image=634", "14bdfc55-c1ae-8da2-7f16-86d43229165f", "20523184@gm.uit.edu.vn", true, true, false, null, "20523184@GM.UIT.EDU.VN", "20523184", "AQAAAAIAAYagAAAAECD0qkoFWIUBuFpSZ2/E7fTqeKVRArYkd12MVrQkKiKGVCkeIow4pLfY5jdXt0/5Wg==", "0246 8773 4828", true, "f1d29a21-f4cb-b5a2-c7c5-657877d20208", false, "20523184" },
                    { 73, 0, "https://picsum.photos/640/480/?image=188", "bc1e39ea-96e0-3c2a-fef2-9a1ed1a77af2", "20521853@gm.uit.edu.vn", true, true, false, null, "20521853@GM.UIT.EDU.VN", "20521853", "AQAAAAIAAYagAAAAEBfG1hnHAkiLZ5EIk1AdSCxOp4iLutm5I3AUbpB3FHT2DWenb1CN8pZncMrdiGsPdQ==", "0241 8459 8530", true, "9afcfd58-4e94-e31a-fe53-acc10bc9749b", false, "20521853" },
                    { 74, 0, "https://picsum.photos/640/480/?image=1000", "401cfdb0-abbc-927d-d56f-661db5ce1cca", "23524419@gm.uit.edu.vn", true, true, false, null, "23524419@GM.UIT.EDU.VN", "23524419", "AQAAAAIAAYagAAAAEE7wjuFlmQXkhOCKP56YqfPfiixPKcTf9wo5nmI2D5xc0YKyE08vP815Am6v1SYbTw==", "029 3809 3246", true, "5fd951ce-3762-40d1-2448-df941c9e1c16", false, "23524419" },
                    { 75, 0, "https://picsum.photos/640/480/?image=488", "0010f043-bb62-6477-fa6f-e0daa14dca92", "19523277@gm.uit.edu.vn", true, true, false, null, "19523277@GM.UIT.EDU.VN", "19523277", "AQAAAAIAAYagAAAAEF3Z6NOyIDuvD4bQWY1XJ9EukKthfU1NVMNYKMGCm35hOj4p7LRZhiet7SWvLfMY6w==", "0280 1415 0507", true, "b54baa1b-2ac1-55db-6565-926c7c77326e", false, "19523277" },
                    { 76, 0, "https://picsum.photos/640/480/?image=1060", "e3232f07-ba83-4b42-6309-504d25e5c707", "23528552@gm.uit.edu.vn", true, true, false, null, "23528552@GM.UIT.EDU.VN", "23528552", "AQAAAAIAAYagAAAAEGhgdew8mwNP+hd/9lHEGpIfecoSmV1weQU+72lFdG0GmQyRm+kieECXKeJY5jIcpQ==", "0210 9131 8868", true, "9144866c-f223-d87e-8ba6-dbf864d3c5c0", false, "23528552" },
                    { 77, 0, "https://picsum.photos/640/480/?image=655", "a5c6366f-0eba-cb32-a3c1-c1a87cc47dbc", "22522078@gm.uit.edu.vn", true, true, false, null, "22522078@GM.UIT.EDU.VN", "22522078", "AQAAAAIAAYagAAAAECfmip0/oTe7341T+1ZAMSZ0PM2n7SHVwhRKwA5kb7I4ANlsWhhTaTKu5fVHynccow==", "0208 8566 1195", true, "856e3e62-21bb-b15b-e725-844c2e5813fc", false, "22522078" },
                    { 78, 0, "https://picsum.photos/640/480/?image=525", "c7aa4aaf-d9b9-3419-3c32-352c14c0f20d", "19523916@gm.uit.edu.vn", true, true, false, null, "19523916@GM.UIT.EDU.VN", "19523916", "AQAAAAIAAYagAAAAEMLYf/1JgjSFkdinjKrk59KgpnTE6WkwVR/X/57841I2YmDe0dU4wmGmtf5N7mQCbw==", "0216 5723 3710", true, "e74a373e-c583-d6de-276f-113389eb659e", false, "19523916" },
                    { 79, 0, "https://picsum.photos/640/480/?image=396", "b9e98d5d-00a5-d69c-a3a8-afacbd685d1a", "22528409@gm.uit.edu.vn", true, true, false, null, "22528409@GM.UIT.EDU.VN", "22528409", "AQAAAAIAAYagAAAAEDBojdxKrR1K9OEJpTIe/qOgkuHHCWeE24OY/df2+nlKDQbRRkLLfAlV3YIWYYVdpQ==", "024 2881 6325", true, "4b4a2630-6168-68fc-b89d-1be57fb8402d", false, "22528409" },
                    { 80, 0, "https://picsum.photos/640/480/?image=840", "137004e7-331c-b943-ddae-f62a02ac130b", "22523710@gm.uit.edu.vn", true, true, false, null, "22523710@GM.UIT.EDU.VN", "22523710", "AQAAAAIAAYagAAAAEOkp+tS7Ox8JQty5DNEQKPxVftVSM5voCdNp+/9oO41bS7rRtOOw9FAqLEUADCBM5g==", "0298 3025 7977", true, "02a921e4-0329-1240-0ae2-c519215a1add", false, "22523710" },
                    { 81, 0, "https://picsum.photos/640/480/?image=65", "6dce3cb8-8409-b690-dbb6-52ffd223de0e", "19525497@gm.uit.edu.vn", true, true, false, null, "19525497@GM.UIT.EDU.VN", "19525497", "AQAAAAIAAYagAAAAEAGyq6oQ5s7+IT7gUcrS4Yx/Lb1dgKWLgJndG3DFYLrC25opYOu5VpinVGR/ePVPNQ==", "029 6244 6187", true, "4767afdb-4bea-ebb5-9ca5-5c855dbbbfca", false, "19525497" },
                    { 82, 0, "https://picsum.photos/640/480/?image=804", "b607b74f-a3d5-04f5-3a73-b3c84fae1dba", "22528157@gm.uit.edu.vn", true, true, false, null, "22528157@GM.UIT.EDU.VN", "22528157", "AQAAAAIAAYagAAAAEFV6k4aeepd3RL76FzLVC2xJ2jez+J3hb3Ud4WMRDamlfyyBwMyU26J1ZnyHSutq+g==", "023 5440 5102", true, "ea52a370-2b6d-4295-d3f7-39af27f65d5c", false, "22528157" },
                    { 83, 0, "https://picsum.photos/640/480/?image=963", "711baaed-d3b7-3d9d-3d66-77bd0baf3da0", "19522351@gm.uit.edu.vn", true, true, false, null, "19522351@GM.UIT.EDU.VN", "19522351", "AQAAAAIAAYagAAAAEKb6jp0jndRNgWD5sfv5XilAhlEU0ZCY2lYPr4IXBzNSwZs1ep2nI8jmObhnQS2cjw==", "0237 9502 7666", true, "d396168a-f66c-926d-6cdf-ceba52cc01c9", false, "19522351" },
                    { 84, 0, "https://picsum.photos/640/480/?image=845", "ffbd2d21-b692-849e-a6d7-d7eb41a2acb3", "20527950@gm.uit.edu.vn", true, true, false, null, "20527950@GM.UIT.EDU.VN", "20527950", "AQAAAAIAAYagAAAAEJDf/oX12pJLH59GAVFsLyl2yzphTTSegjQurez5zqpPIPWTdud5ADpduTJn7Zsapg==", "029 4667 6901", true, "720f66f1-3435-f099-b8ad-285aa2ae5f54", false, "20527950" },
                    { 85, 0, "https://picsum.photos/640/480/?image=783", "b4e2d06d-6ab5-0e6b-7047-5fc43aa92841", "21524904@gm.uit.edu.vn", true, true, false, null, "21524904@GM.UIT.EDU.VN", "21524904", "AQAAAAIAAYagAAAAEMiTlnFQ5ElP7BjQldMOYeynJpGa5QTj7gbpQ8saW4kYse6Wx4NsELo/WFf6fYuHeg==", "024 4382 7378", true, "974f0942-3cfc-de74-ee72-e78a09f2a60d", false, "21524904" },
                    { 86, 0, "https://picsum.photos/640/480/?image=574", "d6c6e3ac-35b5-7652-0ab8-d248d2a59e92", "19522741@gm.uit.edu.vn", true, true, false, null, "19522741@GM.UIT.EDU.VN", "19522741", "AQAAAAIAAYagAAAAEF2zUS1doVwDxTmROWysa4gpz3x9SnzM3U7U7jgfmF6dmNDwjTGnY/4nqUJ+ngBxgw==", "0242 9075 6302", true, "f92b021f-e0c4-03f7-2ebb-73726486f8af", false, "19522741" },
                    { 87, 0, "https://picsum.photos/640/480/?image=701", "df3901b4-29a4-cb46-69a2-13e2fbfc075c", "23526426@gm.uit.edu.vn", true, true, false, null, "23526426@GM.UIT.EDU.VN", "23526426", "AQAAAAIAAYagAAAAELJP5GWBQEa9cvc2kWWXdDvSlkX510sNjYl46S3AZfo87qzEzBfM6bNNjFz2ly58Mw==", "023 2881 7498", true, "297a838c-056f-5aff-c019-4b51f0877268", false, "23526426" },
                    { 88, 0, "https://picsum.photos/640/480/?image=807", "4720ccb4-9a3e-4fba-019e-8833d7f5e3be", "22527605@gm.uit.edu.vn", true, true, false, null, "22527605@GM.UIT.EDU.VN", "22527605", "AQAAAAIAAYagAAAAEDGIFZWKTynVVHtHcxG7CGPnUB4N9SwU83uC3xIYZfjmINu3XOV78Pyc8uieRCsrzQ==", "029 0142 3228", true, "4ffd2654-4fb0-418b-1bac-9df388290fd8", false, "22527605" },
                    { 89, 0, "https://picsum.photos/640/480/?image=1068", "b00798b3-0ad7-d22d-999b-fe84b3eebf20", "22527913@gm.uit.edu.vn", true, true, false, null, "22527913@GM.UIT.EDU.VN", "22527913", "AQAAAAIAAYagAAAAEKeiiUgmocxhRzP+0gAo4+WzQy8UwyxHJVCARY9CCAtlT0ji2nKIWMMaQtBhIeF6LA==", "0248 4038 1688", true, "7480ca1d-98f1-2918-773f-f09520cbad48", false, "22527913" },
                    { 90, 0, "https://picsum.photos/640/480/?image=497", "5330abb5-b35e-ef63-1871-7ba156309873", "22525493@gm.uit.edu.vn", true, true, false, null, "22525493@GM.UIT.EDU.VN", "22525493", "AQAAAAIAAYagAAAAELP3rPue2X4yTGqkhmohfqMAhG4Z5io1liuLQD/WIbbHocRWXzg3y5Nl86udf0d3Xg==", "020 6577 0576", true, "9be88fd4-e582-036d-9a32-e2a411d2d342", false, "22525493" },
                    { 91, 0, "https://picsum.photos/640/480/?image=619", "3743eb78-b280-d62f-800b-ec15d9c894e9", "23529029@gm.uit.edu.vn", true, true, false, null, "23529029@GM.UIT.EDU.VN", "23529029", "AQAAAAIAAYagAAAAEHENKYUOSgCDNnynC1bshq+EDuc4SYrNVMXQ5vmftRnb67c/b+ndytjotoL/pjMpfw==", "024 7439 6391", true, "77e16b25-ade5-8610-c073-2c30f92d6694", false, "23529029" },
                    { 92, 0, "https://picsum.photos/640/480/?image=882", "a11a572b-fab2-e9bd-a55d-885d60915e76", "21527479@gm.uit.edu.vn", true, true, false, null, "21527479@GM.UIT.EDU.VN", "21527479", "AQAAAAIAAYagAAAAEI5KKqvXc3CqIHChGK3HHmHsf2ZktPYKaGhIOUxfppf4Waps3IPLSU5FTbysspIBGw==", "0272 0011 2764", true, "4754da47-b475-e509-b475-bce189f9e77b", false, "21527479" },
                    { 93, 0, "https://picsum.photos/640/480/?image=1019", "c3fe6a6a-c6b1-51a4-3ece-fce0f88ed3c6", "23521113@gm.uit.edu.vn", true, true, false, null, "23521113@GM.UIT.EDU.VN", "23521113", "AQAAAAIAAYagAAAAEPKi0dOEFZ+2PpOabIKjOl8XKcxjluTYWHA4McgvXJ2hiw27NtYS7UmH/XB7z9GyNQ==", "027 0727 9537", true, "a930d423-573d-0b8c-f4bf-49c8e48c391d", false, "23521113" },
                    { 94, 0, "https://picsum.photos/640/480/?image=1008", "8b91b1e5-d8b9-703e-648f-8a4917ffcd0c", "23526222@gm.uit.edu.vn", true, true, false, null, "23526222@GM.UIT.EDU.VN", "23526222", "AQAAAAIAAYagAAAAEHx1BjXlHB3ILgNcPX9GDreerSKcwtp63mhPIHjDcC8lzr7rcBAlpzz4Dmgp1BuV6w==", "024 3689 9453", true, "0ffa050b-3530-d508-b03f-208cbf1af5c2", false, "23526222" },
                    { 95, 0, "https://picsum.photos/640/480/?image=494", "07c590ea-5db0-2272-72af-e3e72787be67", "21522663@gm.uit.edu.vn", true, true, false, null, "21522663@GM.UIT.EDU.VN", "21522663", "AQAAAAIAAYagAAAAEOBdn7YHF68cuMIFkcMBxQaoHH6JTxSubnAXEDFs5hwpZIs3YqWzNs/PkUX7L8MRkw==", "0287 1684 1409", true, "6ee8c7db-9ece-5693-7652-61989bb3de61", false, "21522663" },
                    { 96, 0, "https://picsum.photos/640/480/?image=1083", "af29a8a4-5928-0c8a-2057-6bbf8334b8b7", "20527273@gm.uit.edu.vn", true, true, false, null, "20527273@GM.UIT.EDU.VN", "20527273", "AQAAAAIAAYagAAAAEHbvbowjczPZBHWaG14auJDzEPQlegR/s5ebxS8fAODfyLTOpL2Q2t8sSH+7D8/3xA==", "0258 7423 0153", true, "96d0c4c0-1641-b77c-9cee-80f64630034b", false, "20527273" },
                    { 97, 0, "https://picsum.photos/640/480/?image=669", "8056eecb-09a9-b993-a032-5ee499a1f8e5", "22526595@gm.uit.edu.vn", true, true, false, null, "22526595@GM.UIT.EDU.VN", "22526595", "AQAAAAIAAYagAAAAEDjqbFp//Tlzkjn6HcIi3//dqGAVcQ4UjGINNs8XNud2KqTnGK+5rxCZCnb7NY0VLg==", "022 3960 6412", true, "da51687a-a583-dbe3-9cc5-5e79f79df829", false, "22526595" },
                    { 98, 0, "https://picsum.photos/640/480/?image=1076", "28bfae6d-3f5b-3f01-72ee-7d1f596fb37c", "21523357@gm.uit.edu.vn", true, true, false, null, "21523357@GM.UIT.EDU.VN", "21523357", "AQAAAAIAAYagAAAAEOk44sfMJPJGZTDRAqOmHvPVr90Br03HYbtLRxOVuYlJgN7NHQwlL8+zbbW3nvu71g==", "021 6791 3506", true, "1c882694-39c7-062f-50ad-6dd5477b7e3a", false, "21523357" },
                    { 99, 0, "https://picsum.photos/640/480/?image=154", "aa947986-ac4b-f758-ee2b-9fed7a799237", "19524223@gm.uit.edu.vn", true, true, false, null, "19524223@GM.UIT.EDU.VN", "19524223", "AQAAAAIAAYagAAAAEBIn/wxSwGH3nljwq3d+r2Rvsz/y3zbS7tPYt1P4AQkq1Gjnin1Z8wKuSgVAl8s/hw==", "020 8393 5603", true, "e9280008-2014-a4d8-a35e-ab26b70b233d", false, "19524223" },
                    { 100, 0, "https://picsum.photos/640/480/?image=320", "7926e372-761d-fa09-27a6-3559b6ce2212", "22523427@gm.uit.edu.vn", true, true, false, null, "22523427@GM.UIT.EDU.VN", "22523427", "AQAAAAIAAYagAAAAELctwdWb+9fPiiF5ZKYjT58gDX7Hlf/HR6pzh364b93sZZfFVcyqNi+T8+x6N0coVA==", "025 6830 9407", true, "1f1fc2ba-9364-8b7a-acc2-7514c5d0056a", false, "22523427" },
                    { 101, 0, "https://picsum.photos/640/480/?image=802", "add21904-dd22-0c94-549a-fdb5737f4b03", "23521725@gm.uit.edu.vn", true, true, false, null, "23521725@GM.UIT.EDU.VN", "23521725", "AQAAAAIAAYagAAAAEMvjNUV/D7Gg71NzPPzuyi/bOa63u5LXkTnOSWZz540+Qs7s9yhiHjVffLN0ps93Lg==", "026 2630 7971", true, "7fbb119f-a572-fb38-0cab-07bf27cc2d44", false, "23521725" },
                    { 102, 0, "https://picsum.photos/640/480/?image=672", "acf4fd17-c4ed-a6fc-c50d-804d6ff49cdf", "23527605@gm.uit.edu.vn", true, true, false, null, "23527605@GM.UIT.EDU.VN", "23527605", "AQAAAAIAAYagAAAAEJEOC4BhzJYSoOGI7PfxD4R3PnzFDJMGzYK0w9rcW3e6kZ1JC4p9ntK+NHZ2x05pzQ==", "025 8888 0486", true, "471ded98-2815-3c5e-5537-ef1aba1fcfdd", false, "23527605" },
                    { 103, 0, "https://picsum.photos/640/480/?image=412", "b9ac16e0-65ab-3540-8104-e56c6aecbb92", "23528985@gm.uit.edu.vn", true, true, false, null, "23528985@GM.UIT.EDU.VN", "23528985", "AQAAAAIAAYagAAAAEOgsjzQlOv72Eh8b26fj0j0t8MpkVroApecNouTyDkY2Xbd0lU1EIqfh6lCkMhiqoQ==", "025 9453 0925", true, "b90f80c9-83ab-9f7d-c3d7-764d717175a8", false, "23528985" },
                    { 104, 0, "https://picsum.photos/640/480/?image=754", "687c87f5-3ddf-8b97-a5e2-d75c2ea9bee9", "21521254@gm.uit.edu.vn", true, true, false, null, "21521254@GM.UIT.EDU.VN", "21521254", "AQAAAAIAAYagAAAAEK6ZYyOExQl8R+BNpPAl6eCz4Bsr627KuN5HqhAz320d5dzp1MqZzeRaCrXmWoI3RA==", "0237 0394 5260", true, "e0d1be50-13c4-4a0d-edd3-4e9b6c7b9541", false, "21521254" },
                    { 105, 0, "https://picsum.photos/640/480/?image=289", "5aa75067-50aa-3579-7317-680b1465558e", "21528341@gm.uit.edu.vn", true, true, false, null, "21528341@GM.UIT.EDU.VN", "21528341", "AQAAAAIAAYagAAAAEOlugbJyB0rZaiN+e29seNd0c+QucRiL4isOn0nKNCvPyrCTGh89KDbKgtMaNsGwtQ==", "023 0935 1811", true, "44818473-ff9f-cfb1-ff32-dca62c7416b5", false, "21528341" },
                    { 106, 0, "https://picsum.photos/640/480/?image=127", "1baa7c8b-9e61-880d-dc8e-ac62cade4f7e", "23524818@gm.uit.edu.vn", true, true, false, null, "23524818@GM.UIT.EDU.VN", "23524818", "AQAAAAIAAYagAAAAEDx6kUKSfSf6u/Y6lk+bJeQ1wjv1UDUoZ2tDb4LTw+5lIb4bsx94eJZ7/6pfKnqqYg==", "0264 1817 2714", true, "a367a65d-f435-7c40-688e-880768573e8e", false, "23524818" },
                    { 107, 0, "https://picsum.photos/640/480/?image=348", "9e6e77e6-e7a9-0648-a7f9-5012435e3f2f", "20526297@gm.uit.edu.vn", true, true, false, null, "20526297@GM.UIT.EDU.VN", "20526297", "AQAAAAIAAYagAAAAECZ7PoLpTNMNHzRmKWJva4yuce9/xi4MI9ErNQNHJ9Xtr3jUdNJ5qV/NzhVjkizjOw==", "024 6367 6433", true, "093a772b-4630-1ab8-80c5-f576e39abbf9", false, "20526297" },
                    { 108, 0, "https://picsum.photos/640/480/?image=532", "db95c369-b55b-077f-7116-6bf8e93b3fc1", "23523074@gm.uit.edu.vn", true, true, false, null, "23523074@GM.UIT.EDU.VN", "23523074", "AQAAAAIAAYagAAAAEBFP0NF74/EHk/bWwxU1c1A345O70kg4QNiWSLzWDaLvJIUrseVRXu2+CJkGIV3fEA==", "028 9016 4931", true, "3f5e810f-0d2d-6f9b-d264-91d665d38c13", false, "23523074" },
                    { 109, 0, "https://picsum.photos/640/480/?image=851", "a8e1359d-167e-dad7-da37-1973582ad0e3", "23521870@gm.uit.edu.vn", true, true, false, null, "23521870@GM.UIT.EDU.VN", "23521870", "AQAAAAIAAYagAAAAECZCn3jD6jiWmfex5LjL44vkaA1s3OLGMcrRWSuOGNUYN4lRkRN6QPc3jJ730skmtg==", "023 6081 9463", true, "c0cdf26a-be8d-0265-590d-459ac1603d07", false, "23521870" },
                    { 110, 0, "https://picsum.photos/640/480/?image=826", "49a80318-3ffd-4b74-ab9c-0a54a021bf63", "23527857@gm.uit.edu.vn", true, true, false, null, "23527857@GM.UIT.EDU.VN", "23527857", "AQAAAAIAAYagAAAAELQUPqS41yA4E6WeUr1vBv17xwRqgNkfdWiI7AzVhmh5rZv2q2z7xl8X59by1LqCgw==", "023 1492 0796", true, "30882fce-8b41-a243-992d-f554b2dfa016", false, "23527857" },
                    { 111, 0, "https://picsum.photos/640/480/?image=1075", "a8e415a7-bc0e-201e-a251-15719b5daa92", "21523045@gm.uit.edu.vn", true, true, false, null, "21523045@GM.UIT.EDU.VN", "21523045", "AQAAAAIAAYagAAAAEOIYgPKv/fmJFoQFgjf9zBDaJK6tbtAihYb1j2bvYhKXQoqSYv3FaGcGoJd9u8dbZw==", "029 7568 4511", true, "b0c4d350-ec84-1526-51e7-048138b83de1", false, "21523045" },
                    { 112, 0, "https://picsum.photos/640/480/?image=96", "cbe0a747-a710-922c-a33a-4d8ac2775686", "20525936@gm.uit.edu.vn", true, true, false, null, "20525936@GM.UIT.EDU.VN", "20525936", "AQAAAAIAAYagAAAAEJwWk+pesISE37VKrQd66ogW0w+bYm1+ADVzNV7xK11Y9fXqrq1RLMLMflQ0XCiNdg==", "0255 4819 9442", true, "477718f4-c5d6-b236-fdac-7a5723d05adb", false, "20525936" },
                    { 113, 0, "https://picsum.photos/640/480/?image=246", "aca669c3-78b2-9d41-0627-d24a00135350", "19527306@gm.uit.edu.vn", true, true, false, null, "19527306@GM.UIT.EDU.VN", "19527306", "AQAAAAIAAYagAAAAEA2Emedyz0sxKsF4ORFQF/k2JcEos5+JmzI2vpJb0dwUtxLuqqCz5TIt6lwgXT+FUA==", "0236 1217 0437", true, "1ae15662-fcca-7f06-3ee5-070ea9c569fc", false, "19527306" },
                    { 114, 0, "https://picsum.photos/640/480/?image=13", "a6fda404-a58b-9a77-e1db-0e7aaa694775", "23527033@gm.uit.edu.vn", true, true, false, null, "23527033@GM.UIT.EDU.VN", "23527033", "AQAAAAIAAYagAAAAEIGioqQWpHriOo+zh7nNTSsKm48z7/KF8Xq1VOT+1irrQ/4pCjmgkXU66kbWumIfig==", "0247 4086 0331", true, "3e492f63-a9b8-4dbd-2146-c9cbcc63a1fc", false, "23527033" },
                    { 115, 0, "https://picsum.photos/640/480/?image=595", "7f754981-2eed-4301-ebb4-0b421b1b7161", "22522000@gm.uit.edu.vn", true, true, false, null, "22522000@GM.UIT.EDU.VN", "22522000", "AQAAAAIAAYagAAAAEILJKqO/z6WdToFF1NZ2h5sxYR8G57hNcPSWwEEc7cbxYuYFcTon0O/GFOcjG6Oc2Q==", "0269 2504 2347", true, "128747d0-b457-34be-4e09-9940b59fc687", false, "22522000" },
                    { 116, 0, "https://picsum.photos/640/480/?image=871", "0ea4ce6d-b268-f00e-61b1-99406004e73c", "21528534@gm.uit.edu.vn", true, true, false, null, "21528534@GM.UIT.EDU.VN", "21528534", "AQAAAAIAAYagAAAAEGh2GhNesRw4pmBDFF2KZQoBdZkqfipKHsIuvVggqzmrH5RjIW6kavIExx7/kbxgfw==", "024 2859 4409", true, "04397df7-6d54-5cc8-e39c-1ac8a0ab32e2", false, "21528534" },
                    { 117, 0, "https://picsum.photos/640/480/?image=492", "ca4df35b-f084-0a7f-6cfb-f370ff0c199b", "22529148@gm.uit.edu.vn", true, true, false, null, "22529148@GM.UIT.EDU.VN", "22529148", "AQAAAAIAAYagAAAAEO1Y8J+6O3U+DPJHD/2FJGx67laqYsMmJ2hCdTuHCY9qPaZJ0HESKuzkuDbWAOtsfQ==", "020 2418 0191", true, "3eaeb73e-6f98-5491-1f4c-bb60bee7fe6a", false, "22529148" },
                    { 118, 0, "https://picsum.photos/640/480/?image=524", "a312344a-36a5-4282-d148-b8c8394ba69f", "23526826@gm.uit.edu.vn", true, true, false, null, "23526826@GM.UIT.EDU.VN", "23526826", "AQAAAAIAAYagAAAAENEcH38wHI0+SYBk4ecZbayo1lAS8UqE25SCevYAnWi2+SvOIgHsbiWkfPyCPJSKXQ==", "0277 5904 6617", true, "c941af2f-5a4b-4ab8-effc-6cd0ee45ef62", false, "23526826" },
                    { 119, 0, "https://picsum.photos/640/480/?image=332", "8b287bf6-92a4-ddee-de8b-3988532c8198", "21525451@gm.uit.edu.vn", true, true, false, null, "21525451@GM.UIT.EDU.VN", "21525451", "AQAAAAIAAYagAAAAEEF0NeZ0dijM0zb7Jj8xMIAm5+JrjYpCiYWolzSRa6M+iCZ6qyNwYgvWzDtoZTzwjg==", "0223 1708 6358", true, "2cc8fb91-4e5e-ae51-7b2f-e1ed876b582d", false, "21525451" },
                    { 120, 0, "https://picsum.photos/640/480/?image=871", "30b37553-f7bf-3632-4757-2167065a9160", "22529763@gm.uit.edu.vn", true, true, false, null, "22529763@GM.UIT.EDU.VN", "22529763", "AQAAAAIAAYagAAAAEHPhKe9p3EtPCtyWEeRBgxOcokF9gmq4rwfS7uYgRPxlm/0+sND/N4zISAtjRpebnA==", "027 8141 3803", true, "1483cc03-873b-ea15-3393-6acace70c408", false, "22529763" },
                    { 121, 0, "https://picsum.photos/640/480/?image=1050", "bbeb08a2-230f-43a3-8f2f-ab98331b4368", "20525863@gm.uit.edu.vn", true, true, false, null, "20525863@GM.UIT.EDU.VN", "20525863", "AQAAAAIAAYagAAAAEL2PrBPRnNr18AX0UiePZS4pr6HiVgPXAq0vI99xbvNEOak+eBptJ/Q81hIIkJwDWQ==", "026 3339 7353", true, "29e33522-cc0c-23a0-e2a8-3cd62b0d683d", false, "20525863" },
                    { 122, 0, "https://picsum.photos/640/480/?image=949", "8b4c7330-c7a6-6de6-059f-027826733366", "23521526@gm.uit.edu.vn", true, true, false, null, "23521526@GM.UIT.EDU.VN", "23521526", "AQAAAAIAAYagAAAAEHdVcWE72qg/GmWBZOUL3CmiKFOgRr6Cc5IA2oWH5WL1kOLFKYP5/cfMSQJk1Rxtqg==", "026 5988 2106", true, "b57cd758-3a19-ceaa-3746-fa78b4f95fb6", false, "23521526" },
                    { 123, 0, "https://picsum.photos/640/480/?image=1041", "28bf4a8b-3996-0dec-fc2d-b27ce9748e5f", "23524156@gm.uit.edu.vn", true, true, false, null, "23524156@GM.UIT.EDU.VN", "23524156", "AQAAAAIAAYagAAAAELB9n2otBI+9HHmgqSFHuUB81cJ537g5XymvBu6VF6l1O/jVDYJ49gxW7CHRAsNVsQ==", "0211 3147 1058", true, "ce99f3b9-1ae1-515c-a31d-d71b158cada6", false, "23524156" },
                    { 124, 0, "https://picsum.photos/640/480/?image=165", "9739907f-8207-7f63-d224-3654497650d1", "20529046@gm.uit.edu.vn", true, true, false, null, "20529046@GM.UIT.EDU.VN", "20529046", "AQAAAAIAAYagAAAAEPsuGnuf8rX8riCUn4R0jRBQHeAAMUa8azqQj69Mxn2YPKqK+1jBbmtdG4pK9t6yXQ==", "0287 3018 0603", true, "c8545535-3b3f-7f0a-78ac-4617255732c0", false, "20529046" },
                    { 125, 0, "https://picsum.photos/640/480/?image=478", "a4da8122-b400-43f1-c2ef-bf10f3d2c250", "19527098@gm.uit.edu.vn", true, true, false, null, "19527098@GM.UIT.EDU.VN", "19527098", "AQAAAAIAAYagAAAAEAuk+3FQ55vMjyZ/4+HLs0qejKdduHXftI4VS6zmSzz62B+3ni8EB5RocgsajyEEtg==", "023 7904 9253", true, "8d5e86f5-df95-1bfc-00c9-156c8890d0dd", false, "19527098" },
                    { 126, 0, "https://picsum.photos/640/480/?image=819", "9f2150e4-6f01-10c5-57e6-d5861ef62b80", "23529415@gm.uit.edu.vn", true, true, false, null, "23529415@GM.UIT.EDU.VN", "23529415", "AQAAAAIAAYagAAAAEAGVkdZR7bDV+Qi51+HNdtv9PwD3Acq0SOfaBTEIREQxJw8ZdiT4SdW4mhBiSIEU0Q==", "024 2952 7253", true, "0b5390fa-7366-51e5-3c5e-aaab88d80025", false, "23529415" },
                    { 127, 0, "https://picsum.photos/640/480/?image=663", "0792ea86-2b1b-bda2-d91b-db60e67d9d2b", "22526428@gm.uit.edu.vn", true, true, false, null, "22526428@GM.UIT.EDU.VN", "22526428", "AQAAAAIAAYagAAAAEJOczzvVlvsp1RT111YPwA/uLMhUWtXX3PBxM2JnCcBiKCQX/WUDXkHPTd2fz6Ycrg==", "024 4530 9275", true, "ae3e716a-06c0-e31e-f29e-9bdcfc1bd701", false, "22526428" },
                    { 128, 0, "https://picsum.photos/640/480/?image=579", "cda7c7c0-8db9-0747-ca77-18c4b99d3856", "21528608@gm.uit.edu.vn", true, true, false, null, "21528608@GM.UIT.EDU.VN", "21528608", "AQAAAAIAAYagAAAAEADfHFX8aByUO2ZnpKZvldLDjbWeibakOf9qEI29m7vxItS1zpCHfvA5XvdmfJySng==", "025 0113 8579", true, "8ccc8d29-d33f-3356-880d-49f4d519dcad", false, "21528608" },
                    { 129, 0, "https://tinyurl.com/dhhttt123", "8286d046-9740-a3e4-95cf-ff46699c73c4", "httt.doanhoi@gmail.com", true, true, false, null, "HTTT.DOANHOI@GMAIL.COM", "HTTT.DOANHOI@GMAIL.COM", "AQAAAAIAAYagAAAAECyg1f5Ujz7OcWh8fxoG1TjZ+fcDa8i3B3614hYlZj185UGMeICVQqt8XuQtqPn5NQ==", "0209 8805 5296", true, "3410cda1-5b13-a34e-6f84-a54adf7a0ea0", false, "httt.doanhoi@gmail.com" },
                    { 130, 0, "https://tinyurl.com/khoahttt", "95c69371-b924-6fe3-7c38-98b7dd200bc1", "info.httt@uit.edu.vn", true, true, false, null, "INFO.HTTT@UIT.EDU.VN", "INFO.HTTT@UIT.EDU.VN", "AQAAAAIAAYagAAAAEGTY0kt/1EE07CrQV8ZgK6pNRuqkvgHa1+WQUfRBPaU6aacO1KcN3lc/TjioGKmCkw==", "020 3867 6002", true, "2eec1e16-bdf0-4616-f2a9-e6936c626933", false, "info.httt@uit.edu.vn" },
                    { 131, 0, "https://tinyurl.com/khoammttt", "a905569d-db07-3ae3-63a0-322750a4a3bd", "doanthanhnien@suctremmt.com", true, true, false, null, "DOANTHANHNIEN@SUCTREMMT.COM", "DOANTHANHNIEN@SUCTREMMT.COM", "AQAAAAIAAYagAAAAEPOB5hc2w6B/ndgNkDI3QsRCld6BFX5Jna4zBVojd2xyFcUP4Tl/Cz849E5VaSIn/w==", "0206 8548 6858", true, "27c86e8c-1fcc-eade-75cf-27ddf84ac5c7", false, "doanthanhnien@suctremmt.com" },
                    { 132, 0, "https://tinyurl.com/khoacnpmuit", "bc4519c8-fdeb-06e2-4a08-cc98c4273aba", "cnpm.fanpage@gmail.com", true, true, false, null, "CNPM.FANPAGE@GMAIL.COM", "CNPM.FANPAGE@GMAIL.COM", "AQAAAAIAAYagAAAAEHJE738FlU8CuCt1No5G23ZE8R3EnMQhPNwLMGrC35f5BApljLzhiRXRwB3y2RB7oA==", "0200 9310 2584", true, "20a4bf01-81a8-8da6-f9f5-68278432205a", false, "cnpm.fanpage@gmail.com" },
                    { 133, 0, "https://tinyurl.com/khoaktmtuit", "cf85ddf4-1ece-d1e2-3171-650938abd2b7", "tuoitre.ktmt@gm.uit.edu.vn", true, true, false, null, "TUOITRE.KTMT@GM.UIT.EDU.VN", "TUOITRE.KTMT@GM.UIT.EDU.VN", "AQAAAAIAAYagAAAAENnFSOsbhZPJPy/azcv5VdpvB6NEMXTsWAPSodHPvJ5G4zyI/xp/Qx1XWfhOEdRtAQ==", "021 3917 1731", true, "1a801076-e484-306e-7c1a-a970101a7ced", false, "tuoitre.ktmt@gm.uit.edu.vn" },
                    { 134, 0, "https://tinyurl.com/khoaiseuit", "e2c4a01f-40b1-9de1-18d9-ff7aab2e6ab3", "bch.khkttt.uit@gmail.com", true, true, false, null, "BCH.KHKTTT.UIT@GMAIL.COM", "BCH.KHKTTT.UIT@GMAIL.COM", "AQAAAAIAAYagAAAAEGye6Z94H/3Y2GUvJrYE1KjZgKV7XTu98YXhMHNtv5QXgrLFj5uElz2EDJbblylmGQ==", "0217 0043 3135", true, "135c60ec-4660-d437-ff40-eaba9d01d781", false, "bch.khkttt.uit@gmail.com" },
                    { 135, 0, "https://tinyurl.com/khoakhmtuit", "f604634b-6295-68e1-ff41-99ea1fb201b0", "bch.cs.uit@gmail.com", true, true, false, null, "BCH.CS.UIT@GMAIL.COM", "BCH.CS.UIT@GMAIL.COM", "AQAAAAIAAYagAAAAEEXuRuoUhfd0+THCT1j4/nt7KAQleeii8BNqIqHxhw58qasEluWrDNCS5lhR/4MTjg==", "021 0081 5986", true, "0d38b161-a83c-77ff-8266-2a0429e93214", false, "bch.cs.uit@gmail.com" },
                    { 136, 0, "https://tinyurl.com/doictxhuit", "09442776-8478-34e0-e6aa-335b933599ad", "doictxh.uit@gmail.com", true, true, false, null, "DOICTXH.UIT@GMAIL.COM", "DOICTXH.UIT@GMAIL.COM", "AQAAAAIAAYagAAAAEKkKtX/svTjyVmTZwg0FebaZ3RKYGMPHFdKvQjNS0TX5qZ6l6fBrWe1yPLBEMkuNlA==", "0214 1687 4696", true, "061401d7-0a18-1ac7-058b-6b4db5d18ea7", false, "doictxh.uit@gmail.com" },
                    { 137, 0, "https://tinyurl.com/clbaiclub", "1c84eaa2-a65c-ffdf-ce12-cccc06b931a9", "aiclub@uit.edu.vn", true, true, false, null, "AICLUB@UIT.EDU.VN", "AICLUB@UIT.EDU.VN", "AQAAAAIAAYagAAAAEIabi7R0KjKAzWCAYyUUe5kcY6+FUUr54QMqPMHKcxOBTNuKzL4PxAG0sb8Jgns3mg==", "0227 1458 0422", true, "fff0524c-6df5-be8f-88b1-ac9742b9e93a", false, "aiclub@uit.edu.vn" },
                    { 138, 0, "https://tinyurl.com/openengclub", "2fc3adcd-c83f-cbdf-b57a-663d7a3cc8a6", "oeclub.uit@gmail.com", true, true, false, null, "OECLUB.UIT@GMAIL.COM", "OECLUB.UIT@GMAIL.COM", "AQAAAAIAAYagAAAAEOE9sM7Yk1IVpItqlSeDuECC9m1v/lasWEd9j180XS2q0mvWlji5ja55W99a0Mu0Ug==", "022 1131 0614", true, "f9cca3c2-cfd1-6157-0bd6-ede0cea144ce", false, "oeclub.uit@gmail.com" },
                    { 139, 0, "https://tinyurl.com/webdevuit", "420371f9-ea23-96de-9ce3-00aeeec060a2", "webdevstudios.org@gmail.com", true, true, false, null, "WEBDEVSTUDIOS.ORG@GMAIL.COM", "WEBDEVSTUDIOS.ORG@GMAIL.COM", "AQAAAAIAAYagAAAAEPzAk0koDxiWZ38eO1vPyScyG36DgEHcZtvqPs8QfwGYYXfQx828VCUyHCuXdy/2gA==", "0224 2182 2974", true, "f2a8f337-31ad-041f-8efc-2e2a5a88a061", false, "webdevstudios.org@gmail.com" },
                    { 140, 0, "https://tinyurl.com/bhtcnpmuit", "56433424-0c06-62de-834b-9a1e6143f89f", "bht.cnpm.uit@gmail.com", true, true, false, null, "BHT.CNPM.UIT@GMAIL.COM", "BHT.CNPM.UIT@GMAIL.COM", "AQAAAAIAAYagAAAAEL0Ze9G2q74dFApYW+fBzodWTgc+Jkd3OFrLClIQj5NgBeSxprurFEEkvTFaY11uyg==", "022 8295 3770", true, "eb8544ac-9389-a8e8-1122-6f74e670fbf4", false, "bht.cnpm.uit@gmail.com" },
                    { 141, 0, "https://tinyurl.com/bhthtttuit", "6982f750-2dea-2ddd-6ab4-338fd5c7909c", "bhthttt.uit@gmail.com", true, true, false, null, "BHTHTTT.UIT@GMAIL.COM", "BHTHTTT.UIT@GMAIL.COM", "AQAAAAIAAYagAAAAEDAUN91qZGaTDUa8YmT1sJpwji6pt45QCHF+sV5SxobMLprGwpfAmuMYrRNDPtsDtw==", "0231 3725 3435", true, "e5619522-f665-4bb0-9447-b0bd73585687", false, "bhthttt.uit@gmail.com" },
                    { 142, 0, "https://tinyurl.com/eventuitteam", "7cc2ba7c-4fcd-f9dd-511c-cd00494a2798", "doievent.uit@gmail.com", true, true, false, null, "DOIEVENT.UIT@GMAIL.COM", "DOIEVENT.UIT@GMAIL.COM", "AQAAAAIAAYagAAAAEMR+iOaBMjgE9CGd2gu3fvi+UAxMG5uoBvBIIcuqn0ArkWibnrytnSJFuMMzqmwUrw==", "0235 3697 9261", true, "de3de597-5841-ee78-186d-f007ff40b21b", false, "doievent.uit@gmail.com" },
                    { 143, 0, "https://tinyurl.com/uitgamapp", "8f027ea7-71b0-c4dc-3884-6771bccebf95", "gamappuit.club@gmail.com", true, true, false, null, "GAMAPPUIT.CLUB@GMAIL.COM", "GAMAPPUIT.CLUB@GMAIL.COM", "AQAAAAIAAYagAAAAEDX885LiL2UOPB8GB4wXRYKUQNIJ3NjQz/TxTUUzznl3ORzvUxrDbyD+8ChKe7bRiQ==", "023 8446 9408", true, "d819360d-ba1d-9240-9b93-31508b280dae", false, "gamappuit.club@gmail.com" },
                    { 144, 0, "https://tinyurl.com/sachvahanhdonguit", "a24141d3-9394-90dc-1fed-01e130515792", "clb.sachvahanhdong.uit@gmail.com", true, true, false, null, "CLB.SACHVAHANHDONG.UIT@GMAIL.COM", "CLB.SACHVAHANHDONG.UIT@GMAIL.COM", "AQAAAAIAAYagAAAAEAyZKqsUwSF/H0KXSXcmQSt6jagHbSMMMpgoA9v4ZNMCOQu8Q6fZwr7pUizCYlkVCg==", "0232 4220 0712", true, "d1f58682-1cf9-3508-1eb8-729a170f6941", false, "clb.sachvahanhdong.uit@gmail.com" },
                    { 145, 0, "https://tinyurl.com/clbtiengnhatuit", "b68104fe-b577-5bdb-0755-9a52a4d5ee8e", "wakameuit@gmail.com", true, true, false, null, "WAKAMEUIT@GMAIL.COM", "WAKAMEUIT@GMAIL.COM", "AQAAAAIAAYagAAAAEB/r1L0tJ1bePTZK567icpH2wyttqSSfjWF5Ni9VKEa1OG5egUurndX9T+SGnfnV+w==", "024 5419 2654", true, "cad1d7f8-7fd6-d8d0-a1de-b3e4a4f7c4d4", false, "wakameuit@gmail.com" },
                    { 146, 0, "https://tinyurl.com/mediauit", "c9c1c82a-d75b-27da-eebd-34c31858868b", "photo@uit.edu.vn", true, true, false, null, "PHOTO@UIT.EDU.VN", "PHOTO@UIT.EDU.VN", "AQAAAAIAAYagAAAAEGkWe89W1NNXtnmw8TkjPkE/i4L4abwcrda/BFq2qUjSmCckKWiZQtOK2LKF7pryNA==", "0249 5964 1374", true, "c4ad286d-e1b2-7c99-2404-f42d30df1f68", false, "photo@uit.edu.vn" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 1, 4 },
                    { 1, 5 },
                    { 1, 6 },
                    { 1, 7 },
                    { 1, 8 },
                    { 1, 9 },
                    { 1, 10 },
                    { 1, 11 },
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
                    { 1, 40 },
                    { 1, 41 },
                    { 1, 42 },
                    { 1, 43 },
                    { 1, 44 },
                    { 1, 45 },
                    { 1, 46 },
                    { 1, 47 },
                    { 1, 48 },
                    { 1, 49 },
                    { 1, 50 },
                    { 1, 51 },
                    { 1, 52 },
                    { 1, 53 },
                    { 1, 54 },
                    { 1, 55 },
                    { 1, 56 },
                    { 1, 57 },
                    { 1, 58 },
                    { 1, 59 },
                    { 1, 60 },
                    { 1, 61 },
                    { 1, 62 },
                    { 1, 63 },
                    { 1, 64 },
                    { 1, 65 },
                    { 1, 66 },
                    { 1, 67 },
                    { 1, 68 },
                    { 1, 69 },
                    { 1, 70 },
                    { 1, 71 },
                    { 1, 72 },
                    { 1, 73 },
                    { 1, 74 },
                    { 1, 75 },
                    { 1, 76 },
                    { 1, 77 },
                    { 1, 78 },
                    { 1, 79 },
                    { 1, 80 },
                    { 1, 81 },
                    { 1, 82 },
                    { 1, 83 },
                    { 1, 84 },
                    { 1, 85 },
                    { 1, 86 },
                    { 1, 87 },
                    { 1, 88 },
                    { 1, 89 },
                    { 1, 90 },
                    { 1, 91 },
                    { 1, 92 },
                    { 1, 93 },
                    { 1, 94 },
                    { 1, 95 },
                    { 1, 96 },
                    { 1, 97 },
                    { 1, 98 },
                    { 1, 99 },
                    { 1, 100 },
                    { 1, 101 },
                    { 1, 102 },
                    { 1, 103 },
                    { 1, 104 },
                    { 1, 105 },
                    { 1, 106 },
                    { 1, 107 },
                    { 1, 108 },
                    { 1, 109 },
                    { 1, 110 },
                    { 1, 111 },
                    { 1, 112 },
                    { 1, 113 },
                    { 1, 114 },
                    { 1, 115 },
                    { 1, 116 },
                    { 1, 117 },
                    { 1, 118 },
                    { 1, 119 },
                    { 1, 120 },
                    { 1, 121 },
                    { 1, 122 },
                    { 1, 123 },
                    { 1, 124 },
                    { 1, 125 },
                    { 1, 126 },
                    { 1, 127 },
                    { 1, 128 },
                    { 2, 129 },
                    { 2, 130 },
                    { 2, 131 },
                    { 2, 132 },
                    { 2, 133 },
                    { 2, 134 },
                    { 2, 135 },
                    { 2, 136 },
                    { 2, 137 },
                    { 2, 138 },
                    { 2, 139 },
                    { 2, 140 },
                    { 2, 141 },
                    { 2, 142 },
                    { 2, 143 },
                    { 2, 144 },
                    { 2, 145 },
                    { 2, 146 }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "CreatedByUserId", "CreatedDate", "DateOfBirth", "FirstName", "LastModifiedByUserId", "LastModifiedDate", "LastName", "StudentCode", "UserId" },
                values: new object[,]
                {
                    { 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1954, 11, 7, 21, 10, 55, 63, DateTimeKind.Unspecified).AddTicks(6722), "Minh Cảnh", null, null, "Lâm", 23527087, 32 },
                    { 2, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2003, 12, 18, 21, 50, 22, 54, DateTimeKind.Unspecified).AddTicks(1337), "Ðông Nguyên", null, null, "Hà", 19524223, 99 },
                    { 3, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2002, 10, 30, 0, 55, 36, 490, DateTimeKind.Unspecified).AddTicks(5745), "Tú Tâm", null, null, "Hoàng", 19527406, 38 },
                    { 4, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 3, 21, 1, 44, 32, 796, DateTimeKind.Unspecified).AddTicks(1942), "Phương An", null, null, "Bùi", 21528341, 105 },
                    { 5, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 10, 20, 4, 40, 17, 917, DateTimeKind.Unspecified).AddTicks(4770), "Hải Hà", null, null, "Đoàn", 21524135, 44 },
                    { 6, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 3, 30, 10, 54, 34, 131, DateTimeKind.Unspecified).AddTicks(7127), "Ái Nhân", null, null, "Phùng", 21523045, 111 },
                    { 7, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 10, 11, 8, 24, 59, 344, DateTimeKind.Unspecified).AddTicks(3794), "Thanh Trang", null, null, "Nguyễn", 22525846, 50 },
                    { 8, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1975, 3, 31, 6, 46, 21, 588, DateTimeKind.Unspecified).AddTicks(8266), "Hữu Minh", null, null, "Phan", 22529148, 117 },
                    { 9, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 10, 1, 12, 9, 40, 771, DateTimeKind.Unspecified).AddTicks(2818), "Bình Quân", null, null, "Hồ", 20522274, 56 },
                    { 10, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 9, 27, 2, 2, 1, 484, DateTimeKind.Unspecified).AddTicks(7330), "Thư Sương", null, null, "Trịnh", 23524156, 123 },
                    { 11, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 9, 22, 15, 54, 22, 198, DateTimeKind.Unspecified).AddTicks(1842), "Mạnh Dũng", null, null, "Tô", 19523331, 61 },
                    { 12, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1960, 3, 27, 17, 21, 15, 764, DateTimeKind.Unspecified).AddTicks(4364), "Ðình Quảng", null, null, "Lê", 21528608, 128 },
                    { 13, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 9, 12, 19, 39, 3, 625, DateTimeKind.Unspecified).AddTicks(867), "Tâm Ðoan", null, null, "Tăng", 21521231, 67 },
                    { 14, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 6, 29, 21, 15, 26, 506, DateTimeKind.Unspecified).AddTicks(4968), "Nhật Linh", null, null, "Dương", 22521194, 5 },
                    { 15, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 4, 3, 4, 17, 37, 688, DateTimeKind.Unspecified).AddTicks(7247), "Gia Thịnh", null, null, "Đinh", 20521853, 73 },
                    { 16, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1972, 9, 30, 1, 9, 37, 248, DateTimeKind.Unspecified).AddTicks(5574), "Yến Nhi", null, null, "Hà", 20525753, 11 },
                    { 17, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 8, 25, 3, 8, 26, 478, DateTimeKind.Unspecified).AddTicks(8916), "Thanh Ngân", null, null, "Lý", 22528409, 79 },
                    { 18, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2004, 1, 2, 5, 3, 47, 990, DateTimeKind.Unspecified).AddTicks(6179), "Hữu Ðạt", null, null, "Bùi", 19521559, 17 },
                    { 19, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 8, 16, 6, 53, 7, 905, DateTimeKind.Unspecified).AddTicks(7940), "Bảo Thạch", null, null, "Đào", 20527950, 84 },
                    { 20, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 4, 4, 8, 57, 58, 732, DateTimeKind.Unspecified).AddTicks(6784), "Thúy Minh", null, null, "Phùng", 23529120, 23 },
                    { 21, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 8, 6, 10, 37, 49, 332, DateTimeKind.Unspecified).AddTicks(6964), "Mỹ Hiệp", null, null, "Nguyễn", 22525493, 90 },
                    { 22, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1966, 7, 6, 12, 52, 9, 474, DateTimeKind.Unspecified).AddTicks(7390), "Ðình Hợp", null, null, "Phan", 19527020, 28 },
                    { 23, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1982, 7, 28, 14, 22, 30, 759, DateTimeKind.Unspecified).AddTicks(5989), "Tuệ Mẫn", null, null, "Hồ", 21522663, 95 },
                    { 24, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 10, 7, 16, 46, 20, 216, DateTimeKind.Unspecified).AddTicks(7995), "Như Ngọc", null, null, "Vương", 19523490, 34 },
                    { 25, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 7, 18, 18, 7, 12, 186, DateTimeKind.Unspecified).AddTicks(5013), "Gia Huy", null, null, "Tô", 23521725, 101 },
                    { 26, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1954, 7, 14, 7, 59, 32, 899, DateTimeKind.Unspecified).AddTicks(9526), "Việt Hoàng", null, null, "Trần", 22527012, 40 },
                    { 27, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1978, 7, 9, 21, 51, 53, 613, DateTimeKind.Unspecified).AddTicks(4037), "Thanh Hạnh", null, null, "Tăng", 20526297, 107 },
                    { 28, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2002, 7, 5, 11, 44, 14, 326, DateTimeKind.Unspecified).AddTicks(8550), "Hướng Dương", null, null, "Ngô", 23521125, 46 },
                    { 29, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1976, 6, 30, 1, 36, 35, 40, DateTimeKind.Unspecified).AddTicks(3063), "Bảo Hiển", null, null, "Đinh", 19527306, 113 },
                    { 30, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1955, 4, 11, 9, 16, 3, 617, DateTimeKind.Unspecified).AddTicks(780), "Thúy Diễm", null, null, "Trương", 19529323, 52 },
                    { 31, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1974, 6, 21, 5, 21, 16, 467, DateTimeKind.Unspecified).AddTicks(2086), "Mộng Nhi", null, null, "Lý", 21525451, 119 },
                    { 32, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1972, 10, 14, 8, 23, 3, 185, DateTimeKind.Unspecified).AddTicks(416), "Danh Sơn", null, null, "Bùi", 21525160, 58 },
                    { 33, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1972, 6, 11, 9, 5, 57, 894, DateTimeKind.Unspecified).AddTicks(1110), "Tuyết Nga", null, null, "Đào", 20529046, 124 },
                    { 34, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2004, 1, 16, 12, 17, 13, 927, DateTimeKind.Unspecified).AddTicks(1021), "Nhã Trang", null, null, "Phùng", 20529488, 63 },
                    { 35, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1969, 9, 1, 14, 14, 19, 298, DateTimeKind.Unspecified).AddTicks(1324), "Gia Bảo", null, null, "Phạm", 21522262, 2 },
                    { 36, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 4, 18, 16, 11, 24, 669, DateTimeKind.Unspecified).AddTicks(1627), "Viễn Ðông", null, null, "Phan", 21524672, 69 },
                    { 37, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1968, 5, 23, 16, 35, 20, 747, DateTimeKind.Unspecified).AddTicks(9158), "Sơn Ca", null, null, "Đỗ", 23525084, 8 },
                    { 38, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1966, 7, 20, 20, 5, 35, 411, DateTimeKind.Unspecified).AddTicks(2232), "Kiều Hạnh", null, null, "Vương", 19523277, 75 },
                    { 39, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 4, 16, 2, 39, 7, 174, DateTimeKind.Unspecified).AddTicks(901), "Bá Thịnh", null, null, "Mai", 23521674, 14 },
                    { 40, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 10, 21, 23, 59, 46, 153, DateTimeKind.Unspecified).AddTicks(2837), "Thùy Anh", null, null, "Trần", 19525497, 81 },
                    { 41, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1964, 5, 5, 0, 4, 43, 601, DateTimeKind.Unspecified).AddTicks(7206), "Minh Tâm", null, null, "Tăng", 22521125, 19 },
                    { 42, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1979, 1, 23, 3, 53, 56, 895, DateTimeKind.Unspecified).AddTicks(3442), "Ðại Thống", null, null, "Ngô", 23526426, 87 },
                    { 43, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 9, 9, 5, 51, 2, 266, DateTimeKind.Unspecified).AddTicks(3745), "Thường Kiệt", null, null, "Đinh", 23527643, 25 },
                    { 44, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1960, 4, 25, 7, 48, 7, 637, DateTimeKind.Unspecified).AddTicks(4048), "Ngọc Yến", null, null, "Trương", 21527479, 92 },
                    { 45, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1975, 12, 11, 9, 45, 13, 8, DateTimeKind.Unspecified).AddTicks(4351), "Duy Tâm", null, null, "Lý", 21524800, 30 },
                    { 46, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 4, 20, 0, 10, 23, 273, DateTimeKind.Unspecified).AddTicks(9884), "Tường Phát", null, null, "Đặng", 22526595, 97 },
                    { 47, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1957, 3, 13, 13, 39, 23, 750, DateTimeKind.Unspecified).AddTicks(4954), "Quỳnh Thanh", null, null, "Đào", 19522611, 36 },
                    { 48, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1975, 4, 20, 20, 2, 10, 731, DateTimeKind.Unspecified).AddTicks(1022), "Kim Tuyền", null, null, "Lâm", 21521254, 104 },
                    { 49, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 6, 14, 17, 33, 34, 492, DateTimeKind.Unspecified).AddTicks(5561), "Anh Tú", null, null, "Phạm", 22521905, 43 },
                    { 50, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 3, 24, 4, 55, 50, 22, DateTimeKind.Unspecified).AddTicks(7817), "Tất Hòa", null, null, "Hoàng", 23521870, 109 },
                    { 51, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1969, 9, 15, 21, 27, 45, 234, DateTimeKind.Unspecified).AddTicks(6166), "Minh Nhi", null, null, "Đỗ", 21522897, 48 },
                    { 52, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1978, 3, 15, 8, 40, 31, 449, DateTimeKind.Unspecified).AddTicks(6841), "Cương Quyết", null, null, "Vương", 22522000, 115 },
                    { 53, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 12, 18, 1, 21, 55, 976, DateTimeKind.Unspecified).AddTicks(6771), "Thông Minh", null, null, "Mai", 20528585, 54 },
                    { 54, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1966, 8, 4, 3, 19, 1, 347, DateTimeKind.Unspecified).AddTicks(7074), "Ngọc Sương", null, null, "Trần", 20525863, 121 },
                    { 55, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1982, 3, 21, 5, 16, 6, 718, DateTimeKind.Unspecified).AddTicks(7377), "Hạ Uyên", null, null, "Vũ", 21528211, 60 },
                    { 56, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 11, 5, 7, 13, 12, 89, DateTimeKind.Unspecified).AddTicks(7679), "Tùng Anh", null, null, "Ngô", 23529415, 126 },
                    { 57, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 2, 20, 6, 2, 15, 16, DateTimeKind.Unspecified).AddTicks(9402), "Quỳnh Hoa", null, null, "Trịnh", 22521877, 65 },
                    { 58, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1979, 2, 6, 11, 7, 22, 831, DateTimeKind.Unspecified).AddTicks(8284), "Kim Quyên", null, null, "Trương", 21522215, 3 },
                    { 59, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 2, 11, 9, 46, 56, 443, DateTimeKind.Unspecified).AddTicks(8426), "Anh Dũng", null, null, "Lê", 22528008, 71 },
                    { 60, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1960, 5, 9, 15, 1, 33, 573, DateTimeKind.Unspecified).AddTicks(8890), "Tân Long", null, null, "Đặng", 22525421, 9 },
                    { 61, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 2, 1, 13, 31, 37, 870, DateTimeKind.Unspecified).AddTicks(7451), "Minh Huyền", null, null, "Đào", 22522078, 77 },
                    { 62, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 8, 11, 18, 55, 44, 315, DateTimeKind.Unspecified).AddTicks(9495), "Công Lập", null, null, "Lâm", 23525656, 15 },
                    { 63, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1957, 3, 27, 20, 52, 49, 686, DateTimeKind.Unspecified).AddTicks(9798), "Thiện Phước", null, null, "Phạm", 19522351, 83 },
                    { 64, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1972, 11, 11, 22, 49, 55, 58, DateTimeKind.Unspecified).AddTicks(100), "Ngọc Ly", null, null, "Hoàng", 21523623, 21 },
                    { 65, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 6, 29, 0, 47, 0, 429, DateTimeKind.Unspecified).AddTicks(403), "Hương Mai", null, null, "Đỗ", 22527605, 88 },
                    { 66, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2004, 2, 14, 2, 44, 5, 800, DateTimeKind.Unspecified).AddTicks(706), "Tuấn Kiệt", null, null, "Đoàn", 21529446, 26 },
                    { 67, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1969, 9, 30, 4, 41, 11, 171, DateTimeKind.Unspecified).AddTicks(1008), "Phúc Lâm", null, null, "Mai", 23526222, 94 },
                    { 68, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1961, 12, 30, 14, 38, 2, 864, DateTimeKind.Unspecified).AddTicks(9036), "Kim Hoa", null, null, "Nguyễn", 23524630, 33 },
                    { 69, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2001, 1, 1, 8, 35, 21, 913, DateTimeKind.Unspecified).AddTicks(1614), "Yên Bằng", null, null, "Vũ", 22523427, 100 },
                    { 70, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1959, 12, 21, 18, 22, 44, 291, DateTimeKind.Unspecified).AddTicks(8060), "Sỹ Hoàng", null, null, "Hồ", 23526143, 39 },
                    { 71, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1982, 4, 4, 12, 29, 32, 655, DateTimeKind.Unspecified).AddTicks(2219), "Mai Nhi", null, null, "Trịnh", 23524818, 106 },
                    { 72, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 5, 2, 18, 23, 40, 216, DateTimeKind.Unspecified).AddTicks(4675), "Diễm Phúc", null, null, "Trương", 19521984, 45 },
                    { 73, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1963, 7, 6, 16, 23, 43, 397, DateTimeKind.Unspecified).AddTicks(2826), "Thiện Ðức", null, null, "Lê", 20525936, 112 },
                    { 74, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1979, 2, 20, 18, 20, 48, 768, DateTimeKind.Unspecified).AddTicks(3127), "Ngọc Hà", null, null, "Đặng", 23528867, 51 },
                    { 75, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 10, 7, 20, 17, 54, 139, DateTimeKind.Unspecified).AddTicks(3430), "Hà Phương", null, null, "Dương", 23526826, 118 },
                    { 76, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1960, 5, 23, 22, 14, 59, 510, DateTimeKind.Unspecified).AddTicks(3732), "Trường Vũ", null, null, "Lâm", 22529422, 55 },
                    { 77, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1977, 11, 18, 19, 29, 9, 285, DateTimeKind.Unspecified).AddTicks(9645), "Phú Hải", null, null, "Hà", 23521526, 122 },
                    { 78, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 8, 26, 2, 9, 10, 252, DateTimeKind.Unspecified).AddTicks(4338), "Khánh Vân", null, null, "Hoàng", 19528922, 62 },
                    { 79, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 5, 6, 15, 54, 56, 316, DateTimeKind.Unspecified).AddTicks(3658), "Đan Quỳnh", null, null, "Bùi", 22526428, 127 },
                    { 80, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1972, 11, 26, 6, 3, 20, 994, DateTimeKind.Unspecified).AddTicks(4942), "Quyết Thắng", null, null, "Đoàn", 20523910, 66 },
                    { 81, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 5, 7, 11, 46, 43, 773, DateTimeKind.Unspecified).AddTicks(4796), "Mai Chi", null, null, "Mai", 19524092, 6 },
                    { 82, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2004, 2, 28, 9, 57, 31, 736, DateTimeKind.Unspecified).AddTicks(5548), "Cẩm Yến", null, null, "Nguyễn", 20523184, 72 },
                    { 83, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1971, 10, 22, 6, 43, 13, 566, DateTimeKind.Unspecified).AddTicks(6720), "Thế Phúc", null, null, "Vũ", 19522617, 12 },
                    { 84, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 5, 31, 13, 51, 42, 478, DateTimeKind.Unspecified).AddTicks(6153), "Minh Khang", null, null, "Hồ", 19523916, 78 },
                    { 85, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2001, 1, 15, 15, 48, 47, 849, DateTimeKind.Unspecified).AddTicks(6456), "Huệ Lan", null, null, "Trịnh", 19522251, 16 },
                    { 86, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1966, 9, 1, 17, 45, 53, 220, DateTimeKind.Unspecified).AddTicks(6758), "Trường Liên", null, null, "Tô", 21524904, 85 },
                    { 87, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1982, 4, 18, 19, 42, 58, 591, DateTimeKind.Unspecified).AddTicks(7062), "Phi Cường", null, null, "Lê", 20521405, 22 },
                    { 88, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1975, 5, 11, 9, 17, 59, 873, DateTimeKind.Unspecified).AddTicks(3778), "Khánh Hằng", null, null, "Tăng", 22527913, 89 },
                    { 89, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1963, 7, 20, 23, 37, 9, 333, DateTimeKind.Unspecified).AddTicks(7666), "Ðoan Trang", null, null, "Dương", 22521574, 27 },
                    { 90, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 9, 19, 7, 49, 38, 560, DateTimeKind.Unspecified).AddTicks(8304), "Quốc Tiến", null, null, "Đinh", 20527273, 96 },
                    { 91, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 10, 22, 3, 31, 20, 75, DateTimeKind.Unspecified).AddTicks(8272), "Lệ Huyền", null, null, "Hà", 22524714, 35 },
                    { 92, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 9, 10, 11, 34, 19, 987, DateTimeKind.Unspecified).AddTicks(7328), "Cát Tiên", null, null, "Hoàng", 23527605, 102 },
                    { 93, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1976, 1, 23, 7, 25, 30, 817, DateTimeKind.Unspecified).AddTicks(8877), "Thế Anh", null, null, "Bùi", 23525333, 41 },
                    { 94, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 9, 9, 9, 22, 36, 188, DateTimeKind.Unspecified).AddTicks(9180), "Minh Giang", null, null, "Đoàn", 23523074, 108 },
                    { 95, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1957, 4, 25, 11, 19, 41, 559, DateTimeKind.Unspecified).AddTicks(9484), "Huyền Anh", null, null, "Phùng", 19528160, 47 },
                    { 96, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1972, 12, 10, 13, 16, 46, 930, DateTimeKind.Unspecified).AddTicks(9786), "Tịnh Lâm", null, null, "Nguyễn", 23527033, 114 },
                    { 97, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 7, 27, 15, 13, 52, 302, DateTimeKind.Unspecified).AddTicks(88), "Nhật Khương", null, null, "Phan", 20522137, 49 },
                    { 98, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2004, 3, 13, 17, 10, 57, 673, DateTimeKind.Unspecified).AddTicks(390), "Hồng Vân", null, null, "Hồ", 21528534, 116 },
                    { 99, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1955, 8, 8, 12, 40, 44, 981, DateTimeKind.Unspecified).AddTicks(8914), "Ánh Linh", null, null, "Vương", 20528162, 57 },
                    { 100, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 6, 14, 21, 5, 8, 415, DateTimeKind.Unspecified).AddTicks(996), "Quốc Mạnh", null, null, "Tô", 19527098, 125 },
                    { 101, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2003, 7, 30, 16, 25, 26, 408, DateTimeKind.Unspecified).AddTicks(7937), "Hữu Thắng", null, null, "Lê", 23523150, 59 },
                    { 102, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1966, 9, 16, 0, 59, 19, 157, DateTimeKind.Unspecified).AddTicks(1600), "Bảo Trâm", null, null, "Tăng", 21521026, 1 },
                    { 103, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 5, 18, 14, 16, 25, 801, DateTimeKind.Unspecified).AddTicks(7311), "Thành Trung", null, null, "Dương", 23529748, 68 },
                    { 104, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 12, 18, 4, 53, 29, 899, DateTimeKind.Unspecified).AddTicks(2206), "Mạnh Trình", null, null, "Đinh", 20528388, 7 },
                    { 105, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1963, 8, 4, 6, 50, 35, 270, DateTimeKind.Unspecified).AddTicks(2508), "Hoàn Vi", null, null, "Hà", 23524419, 74 },
                    { 106, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1979, 3, 21, 8, 47, 40, 641, DateTimeKind.Unspecified).AddTicks(2812), "Tú Ly", null, null, "Lý", 21524562, 13 },
                    { 107, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 11, 5, 10, 44, 46, 12, DateTimeKind.Unspecified).AddTicks(3114), "Nguyên Văn", null, null, "Bùi", 22523710, 80 },
                    { 108, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1971, 6, 27, 17, 31, 51, 402, DateTimeKind.Unspecified).AddTicks(9524), "Hồng Như", null, null, "Đào", 21526968, 20 },
                    { 109, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1976, 2, 6, 14, 38, 56, 754, DateTimeKind.Unspecified).AddTicks(3719), "Yến Trâm", null, null, "Phùng", 19522741, 86 },
                    { 110, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1969, 6, 17, 21, 16, 32, 829, DateTimeKind.Unspecified).AddTicks(8546), "Quốc Ðiền", null, null, "Phạm", 20525750, 24 },
                    { 111, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1957, 5, 9, 18, 33, 7, 496, DateTimeKind.Unspecified).AddTicks(4324), "Hữu Khanh", null, null, "Phan", 23529029, 91 },
                    { 112, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 5, 23, 7, 39, 29, 358, DateTimeKind.Unspecified).AddTicks(7432), "Bảo Châu", null, null, "Hồ", 23529672, 31 },
                    { 113, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 8, 10, 22, 27, 18, 238, DateTimeKind.Unspecified).AddTicks(4930), "Thúy Vi", null, null, "Vương", 21523357, 98 },
                    { 114, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1965, 5, 30, 4, 45, 55, 683, DateTimeKind.Unspecified).AddTicks(6596), "Lương Thiện", null, null, "Tô", 23526000, 37 },
                    { 115, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1969, 11, 12, 2, 21, 28, 980, DateTimeKind.Unspecified).AddTicks(5536), "Hoa Liên", null, null, "Trần", 23528985, 103 },
                    { 116, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 6, 29, 4, 18, 34, 351, DateTimeKind.Unspecified).AddTicks(5838), "Tâm Nguyệt", null, null, "Tăng", 21527943, 42 },
                    { 117, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2001, 2, 13, 6, 15, 39, 722, DateTimeKind.Unspecified).AddTicks(6141), "Nguyên Bổng", null, null, "Ngô", 23527857, 110 },
                    { 118, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1966, 9, 30, 8, 12, 45, 93, DateTimeKind.Unspecified).AddTicks(6444), "Gia Nghị", null, null, "Đinh", 19525954, 53 },
                    { 119, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 5, 27, 5, 10, 45, 458, DateTimeKind.Unspecified).AddTicks(6414), "Yến Anh", null, null, "Trương", 23521113, 93 },
                    { 120, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 1, 1, 12, 6, 55, 835, DateTimeKind.Unspecified).AddTicks(7049), "Quang Trọng", null, null, "Lý", 19524989, 29 },
                    { 121, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 5, 28, 1, 2, 32, 915, DateTimeKind.Unspecified).AddTicks(7552), "Hữu Cảnh", null, null, "Bùi", 22529763, 120 },
                    { 122, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1979, 4, 4, 16, 1, 6, 577, DateTimeKind.Unspecified).AddTicks(7654), "Bạch Cúc", null, null, "Đào", 21522295, 64 },
                    { 123, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 4, 18, 9, 37, 2, 104, DateTimeKind.Unspecified).AddTicks(7205), "Thúy Kiều", null, null, "Phùng", 22528157, 82 },
                    { 124, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1960, 7, 5, 19, 55, 17, 319, DateTimeKind.Unspecified).AddTicks(8260), "Lâm Trường", null, null, "Phạm", 22526796, 18 },
                    { 125, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1976, 2, 20, 21, 52, 22, 690, DateTimeKind.Unspecified).AddTicks(8562), "Ðình Cường", null, null, "Phan", 21521326, 4 },
                    { 126, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 10, 7, 23, 49, 28, 61, DateTimeKind.Unspecified).AddTicks(8864), "Tuyết Vy", null, null, "Đỗ", 20527630, 70 },
                    { 127, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1957, 5, 24, 1, 46, 33, 432, DateTimeKind.Unspecified).AddTicks(9166), "Ngọc Lân", null, null, "Vương", 22528659, 10 },
                    { 128, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1975, 5, 31, 22, 33, 49, 15, DateTimeKind.Unspecified).AddTicks(6534), "Gia Hòa", null, null, "Mai", 23528552, 76 }
                });

            migrationBuilder.InsertData(
                table: "UniversityUnits",
                columns: new[] { "UniversityUnitId", "CreatedByUserId", "CreatedDate", "Description", "FacebookUrl", "LastModifiedByUserId", "LastModifiedDate", "Name", "UserId" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2023, 9, 30, 3, 24, 21, 580, DateTimeKind.Local).AddTicks(2983), "Fanpage chính thức cho các hoạt động, sự kiện do Đoàn Khoa - Liên chi Hội HTTT tổ chức.", "https://www.facebook.com/DoanHoiHTTT", null, null, "Hoạt động Đoàn Hội - Hệ thống Thông tin", 129 },
                    { 2, null, new DateTime(2022, 3, 6, 13, 31, 49, 908, DateTimeKind.Local).AddTicks(5736), "Khoa Hệ Thống Thông Tin - Trường ĐH Công nghệ Thông tin", "https://www.facebook.com/uit.khoahttt", null, null, "Khoa Hệ Thống Thông Tin - Trường ĐH Công nghệ Thông tin", 130 },
                    { 3, null, new DateTime(2023, 8, 11, 23, 39, 18, 236, DateTimeKind.Local).AddTicks(6334), "Khoa Mạng máy tính và Truyền thông, Trường Đại học Công nghệ Thông tin - ĐHQG-HCM", "https://www.facebook.com/uit.nc", null, null, "Mạng máy tính và Truyền thông", 131 },
                    { 4, null, new DateTime(2022, 1, 16, 9, 46, 46, 564, DateTimeKind.Local).AddTicks(6918), "Kênh thông tin chính thức của khoa Công Nghệ Phần Mềm, ĐH CNTT, được thành lập và quản lí bởi Đoàn khoa, Liên chi Hội khoa Công Nghệ Phần Mềm.", "https://www.facebook.com/CNPM.Fanpage", null, null, "SeExpress - Kênh thông tin khoa Công Nghệ Phần Mềm, ĐH CNTT", 132 },
                    { 5, null, new DateTime(2023, 6, 23, 19, 54, 14, 892, DateTimeKind.Local).AddTicks(7499), "- Trang thông tin Đoàn - Hội khoa Kỹ thuật Máy tính. - Cập nhật các cuộc thi học thuật.", "https://www.facebook.com/ce.uit", null, null, "Khoa Kỹ Thuật Máy Tính - CE.UIT", 133 },
                    { 6, null, new DateTime(2021, 11, 28, 6, 1, 43, 220, DateTimeKind.Local).AddTicks(8144), "Trang thông tin về các hoạt động, các chương trình từ khoa Khoa học và Kỹ thuật Thông tin - UIT", "https://www.facebook.com/UIT.ISE", null, null, "Khoa Khoa học và Kỹ thuật Thông tin - UIT", 134 },
                    { 7, null, new DateTime(2023, 5, 5, 16, 9, 11, 548, DateTimeKind.Local).AddTicks(8720), "Page chính thức của Khoa Khoa Học Máy Tính - Trường Đại Học Công Nghệ Thông Tin, ĐHQG TP.HCM (CS-UIT)", "https://www.facebook.com/uit.cs", null, null, "Khoa Khoa học Máy tính UIT", 135 },
                    { 8, null, new DateTime(2021, 10, 10, 2, 16, 39, 876, DateTimeKind.Local).AddTicks(9292), "Đội Công tác Xã hội Trường Đại học Công nghệ Thông tin, ĐHQG-HCM", "https://www.facebook.com/ctxh.uit", null, null, "Đội Công Tác Xã Hội Trường ĐH Công Nghệ Thông Tin", 136 },
                    { 9, null, new DateTime(2023, 3, 17, 12, 24, 8, 204, DateTimeKind.Local).AddTicks(9874), "Là một diễn đàn cho các sinh viên đam mê Trí tuệ nhân tạo học hỏi và chia sẻ kiến thức.", "https://www.facebook.com/uit.cs.aiclub", null, null, "Câu lạc bộ AI - khoa Khoa học Máy tính UIT", 137 },
                    { 10, null, new DateTime(2021, 8, 21, 22, 31, 36, 533, DateTimeKind.Local).AddTicks(447), "𝐎𝐏𝐄𝐍 𝐄𝐍𝐆𝐋𝐈𝐒𝐇 𝐂𝐋𝐔𝐁 - 𝐎𝐏𝐄𝐑𝐀𝐓𝐄𝐃 𝐁𝐘 𝐒𝐓𝐔𝐃𝐄𝐍𝐓𝐒, 𝐅𝐎𝐑 𝐒𝐓𝐔𝐃𝐄𝐍𝐓𝐒", "https://www.facebook.com/oeclub.uit", null, null, "UIT Open English Club", 138 },
                    { 11, null, new DateTime(2023, 1, 27, 8, 39, 4, 861, DateTimeKind.Local).AddTicks(1025), "WebDev Studios xin chào!", "https://www.facebook.com/webdevstudios.org", null, null, "WebDev Studios", 139 },
                    { 12, null, new DateTime(2021, 7, 3, 18, 46, 33, 189, DateTimeKind.Local).AddTicks(1605), "Ban học tập Công nghệ Phần mềm là nơi chia sẻ tài liệu, kiến thức về CNTT dành cho các bạn sinh viên.", "https://www.facebook.com/bhtcnpm", null, null, "Ban học tập Công nghệ Phần mềm", 140 },
                    { 13, null, new DateTime(2022, 12, 9, 4, 54, 1, 517, DateTimeKind.Local).AddTicks(2180), "Đây là Fanpage chính thức của Ban học tập Khoa Hệ Thống Thông Tin trực thuộc Đoàn - Hội Khoa Hệ Thống Thông Tin", "https://www.facebook.com/BHTHTTT", null, null, "Ban Học Tập Khoa Hệ Thống Thông Tin", 141 },
                    { 14, null, new DateTime(2024, 5, 15, 15, 1, 29, 845, DateTimeKind.Local).AddTicks(2753), "Đội tổ chức sự kiện trực thuộc Hội Sinh viên trường Đại học Công nghệ Thông tin - ĐHQG Tp.Hồ Chí Minh", "https://www.facebook.com/UIT.EventTeam", null, null, "Đội Event - UIT", 142 },
                    { 15, null, new DateTime(2022, 10, 21, 1, 8, 58, 173, DateTimeKind.Local).AddTicks(3327), "UIT GamApp Studio - CLB Lập trình Game và ứng dụng - trực thuộc Đoàn Khoa Công nghệ phần mềm - ĐHCNTT - ĐHQG TP.HCM. Giá trị cốt lõi: CHIA SẺ - QUẢNG BÁ THƯƠNG HIỆU - GIÚP ĐỠ CỘNG ĐỒNG", "https://www.facebook.com/UITGamAppStudios", null, null, "UIT GamApp Studios", 143 },
                    { 16, null, new DateTime(2024, 3, 27, 11, 16, 26, 501, DateTimeKind.Local).AddTicks(3907), "CLB Sách và Hành Động UIT", "https://www.facebook.com/clb.sachvahanhdong.uit", null, null, "CLB Sách Và Hành Động UIT", 144 },
                    { 17, null, new DateTime(2022, 9, 1, 21, 23, 54, 829, DateTimeKind.Local).AddTicks(4486), "CLB WAKAME được thành lập với sự hỗ trợ của OEP, Hội SV-UIT, khoa KH&KTTT", "https://www.facebook.com/hcmuit.wakame", null, null, "CLB Tiếng Nhật UIT - Wakame", 145 },
                    { 18, null, new DateTime(2024, 2, 7, 7, 31, 23, 157, DateTimeKind.Local).AddTicks(5065), "📸 Beyond mere media", "https://www.facebook.com/media.uit", null, null, "UIT Media Club", 146 }
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "EventId", "CheckinFileUrl", "CreatedByUserId", "CreatedDate", "DeletedWhen", "Description", "EndDate", "FormUrl", "IsDeleted", "IsPublished", "LastModifiedByUserId", "LastModifiedDate", "Location", "MaxAttendees", "PublishedDate", "QRImageUrl", "StartDate", "Title", "TrainingPoint", "Type", "UniversityUnitId" },
                values: new object[,]
                {
                    { 1, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "❓ Bạn muốn tìm hiểu về cơ hội trao đổi sinh viên quốc tế ngành Hệ thống Thông tin ?\r\n❓ Bạn có thắc mắc về chương trình liên thông từ đại học lên thạc sĩ ngành Hệ thống Thông tin?\r\n❓ Bạn quan tâm đến cuộc thi học thuật AISC’24 nhưng chưa rõ về nội dung cuộc thi?\r\n🔉 Đừng lo, hãy đến với seminar do Khoa HTTT tổ chức sẽ giúp bạn giải đáp mọi thắc mắc và định hướng rõ ràng hơn!\r\n--------------------------\r\n🎯 NỘI DUNG CHÍNH\r\n⭐ GIỚI THIỆU THE IS:LINK NETWORK – MẠNG LƯỚI TRAO ĐỔI SINH VIÊN HỆ THỐNG THÔNG TIN\r\n- Cơ hội trao đổi sinh viên quốc tế ngành HTTT\r\n- Hợp tác giữa các trường đại học hàng đầu\r\n- Mở rộng mạng lưới quan hệ và trải nghiệm học tập toàn cầu\r\n⭐ GIỚI THIỆU CHƯƠNG TRÌNH LIÊN THÔNG (BS-MS) TỪ ĐẠI HỌC LÊN THẠC SĨ NGÀNH HỆ THỐNG THÔNG TIN\r\n- Lộ trình học tập tích hợp từ đại học lên thạc sĩ\r\n- Những quyền lợi và lợi ích của chương trình\r\n- Hỗ trợ và tư vấn về chương trình\r\n⭐ GIỚI THIỆU CUỘC THI HỌC THUẬT KHOA HỆ THỐNG THÔNG TIN – ADVANCED INFORMATION SYSTEMS CONTEST 2024 – AISC’24\r\n- Cập nhật các thông tin quan trọng về cuộc thi AISC’24\r\n- Khám phá những phần thưởng giá trị và cơ hội kết nối với các đội thi xuất sắc\r\n- Hướng dẫn và định hướng để chuẩn bị tốt nhất cho cuộc thi\r\n--------------------------\r\n🌟 THÔNG TIN VỀ CHƯƠNG TRÌNH\r\n💦 Trình bày và giải đáp: TS. Cao Thị Nhạn – Phụ trách Khoa – Phó Trưởng Khoa Hệ thống Thông tin\r\n💖 Đèn đỏ đèn xanh. Nhanh tay kẻo lỡ! Hẹn gặp bạn tại buổi seminar nhé!\r\nXem thêm thông tin tại: https://httt.uit.edu.vn/seminar-khoa-he-thong-thong-tin.../\r\n#Seminar_HTTT #IS_UIT", new DateTime(2023, 11, 8, 13, 5, 38, 483, DateTimeKind.Unspecified).AddTicks(2259), "https://forms.gle/HkCD86Gc9UmTTZLP9", false, true, null, null, "Phòng E4.1, Tòa E, Trường Đại học Công nghệ Thông tin – ĐHQG-HCM", 73, new DateTime(2023, 10, 21, 12, 28, 5, 862, DateTimeKind.Unspecified).AddTicks(9347), null, new DateTime(2023, 11, 5, 5, 21, 30, 94, DateTimeKind.Unspecified).AddTicks(3727), "🌟 SEMINAR KHOA HTTT | KHÁM PHÁ CƠ HỘI HỌC TẬP VÀ PHÁT TRIỂN 🌟", 3, "Seminar", 1 },
                    { 2, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tiếp tục hành trình lan tỏa lối sống xanh và khuyến khích người dân xử lý pin cũ đúng cách, UIT, Hội Sinh viên Trường và Cocoon đã tiếp tục đồng hành với nhau trong chương trình “Thu hồi pin cũ - Bảo vệ trái đất xanh” 2024 với hơn 90 điểm thu hồi pin trải rộng trên 5 tỉnh thành: Hà Nội, Huế, Đà Nẵng, Hồ Chí Minh và Cần Thơ. \r\nVẫn như các năm trước, chương trình sẽ tiếp nhận pin tiểu và các loại pin có kích thước từ pin tiểu trở lên (pin AA, pin AAA,... ). Mỗi khách hàng sẽ nhận được 1 quà tặng (Son Dưỡng Dầu Dừa Bến Tre phiên bản giới hạn trị giá 32.000đ) khi mang pin đã qua sử dụng đến điểm thu hồi.\r\n---------------------\r\nCÁCH THỨC ĐỔI PIN NHẬN QUÀ\r\n· Bước 1: Chuẩn bị tối thiểu 10 viên pin đã qua sử dụng, mang đến điểm thu hồi pin tại trước phòng Công tác Sinh viên - A101. \r\n· Bước 2: Quét mã QR trên nắp thùng, nhập thông tin hoặc làm theo hướng dẫn của người phụ trách tại điểm thu hồi để nhận quà.\r\n*Lưu ý:\r\nÁP DỤNG 1 QUÀ TẶNG/1 LƯỢT ĐỔI/1 KHÁCH HÀNG\r\nQuà tặng áp dụng với pin tiểu trở lên (pin AA, pin AAA,...)\r\nQuà tặng không quy đổi thành tiền mặt.\r\nQuà tặng có số lượng giới hạn, sẽ hết sớm hơn dự kiến ở mỗi địa điểm.\r\n---------------------\r\nNhững viên pin đã qua sử dụng nếu không được xử lý đúng cách sẽ để lại những tác động khôn lường, đe dọa đến môi trường tự nhiên và sức khỏe con người. Hãy cùng Cocoon và UIT góp phần bảo vệ hệ sinh thái tự nhiên bằng cách thu hồi pin cũ, gửi cho các đơn vị xử lý chuyên môn để chúng trở lại với môi trường trong một hình hài mới, có ích và thân thiện hơn.\r\n#UIT #Cocoon", new DateTime(2022, 10, 31, 20, 37, 32, 224, DateTimeKind.Unspecified).AddTicks(5246), "https://forms.gle/HkCD86Gc9UmTTZLP9", false, true, null, null, "phòng Công tác Sinh viên - A101", 28, new DateTime(2022, 10, 17, 10, 23, 47, 51, DateTimeKind.Unspecified).AddTicks(4066), null, new DateTime(2022, 10, 19, 7, 55, 43, 130, DateTimeKind.Unspecified).AddTicks(6897), "🔴 CHƯƠNG TRÌNH “THU HỒI PIN CŨ – BẢO VỆ TRÁI ĐẤT XANH” LẦN 3 CHÍNH THỨC ĐI VÀO HOẠT ĐỘNG", 2, "Other", 1 },
                    { 3, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "[NẮNG HẠ 2024 | ĐĂNG KÝ THI THỬ TOEIC]\r\n🔗 Link đăng ký: https://tinyurl.com/DK-ThithuTOEIC-HTTT\r\n🤔 Bạn đang ôn luyện TOEIC hăng say nhưng chưa có cơ hội thử sức với đề thi chuẩn? Bạn muốn cọ xát kiến thức và làm quen với áp lực phòng thi thực tế?\r\n🌟 Tin vui cho các bạn đây!\r\n🤝 Nhà Hệ thống Thông tin chúng mình hợp tác cùng Trung tâm luyện thi TOEIC - Kim Nhung TOEIC tổ chức thi thử TOEIC cho tất cả các bạn sinh viên tại các Trường Đại học trên địa bàn TP.HCM vào Thứ Tư ngày 15/05/2024.\r\n🤗 Đặc biệt hơn nữa:\r\nToàn bộ số tiền thu được từ hoạt động thi thử sẽ được dùng để gây quỹ cho chương trình tình nguyện “Nắng Hạ”.\r\n💠 Tham gia thi thử, bạn không chỉ có cơ hội đánh giá năng lực tiếng Anh của bản thân mà còn góp phần mang đến những điều tốt đẹp cho cộng đồng!\r\n⏰ Số lượng có hạn, nhanh tay đăng ký tham gia ngay nhé!\r\n------------------------------------ \r\nTHÔNG TIN THI THỬ TOEIC\r\n🔗 Link đăng ký: https://tinyurl.com/DK-ThithuTOEIC-HTTT\r\n⏰ Thời gian đăng ký: từ 06/05 đến hết ngày 11/05/2024.\r\n💵 Lệ phí thi: 20.000 VNĐ.\r\n💠 Hình thức bài thi thử TOEIC tương tự với bài thi TOEIC 2 kỹ năng Nghe & Đọc.\r\n📍 Địa điểm thi: Trường Đại học Công nghệ Thông tin - ĐHQG TP.HCM (địa điểm chi tiết sẽ được BTC thông báo qua email đã đăng ký)\r\n🗓️ Ngày thi: 15/05/2024 (Thứ Tư), 2 ca thi:\r\nCa sáng: 8h30 - 11h00\r\nCa chiều: 13h30 - 16h00\r\n💯 Thời gian công bố kết quả thi và cấp giấy chứng nhận dự kiến 01 tuần kể từ sau ngày thi thử.\r\nCơ cấu giải thưởng:\r\n🥇1 giải Nhất: 400.000 VNĐ\r\n🥈1 giải Nhì: 300.000 VNĐ\r\n🥉1 giải Ba: 200.000 VNĐ\r\n🏅2 giải Khuyến khích: 100.000 VNĐ", new DateTime(2023, 10, 25, 1, 29, 57, 686, DateTimeKind.Unspecified).AddTicks(1949), "https://forms.gle/HkCD86Gc9UmTTZLP9", false, false, null, null, "Trường Đại học Công nghệ Thông tin - ĐHQG TP.HCM (địa điểm chi tiết sẽ được BTC thông báo qua email đã đăng ký)", 36, null, null, new DateTime(2023, 10, 3, 10, 29, 56, 167, DateTimeKind.Unspecified).AddTicks(68), "[NẮNG HẠ 2024 | ĐĂNG KÝ THI THỬ TOEIC]", 4, "Other", 1 },
                    { 4, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "🔍 “Bạn đã từng nghe về những câu chuyện kỳ diệu của vương quốc IS chưa? \r\nNếu chưa, thì để Nắng Hạ kể cho bạn nghe nha”\r\n📜 Trong vương quốc IS xa xôi, người dân họ thường truyền tai nhau truyền thuyết về một pháp sư huyền thoại, người có khả năng tạo ra những loại thuốc thần kỳ mang lại sức mạnh và sự bất tử cho người dùng. Tuy nhiên, mọi thứ đã bị đảo lộn khi có kẻ tham lam đánh cắp công thức này, đe dọa biến thuốc thành sự hủy diệt.\r\n🎭 Vào Chủ nhật, ngày 12/5/2024, các bạn sẽ có cơ hội trở thành những thám tử tài ba, đối mặt những thử thách đầy cam go để giành lại công thức và ngăn chặn thảm họa. Đừng bỏ lỡ cơ hội lan tỏa yêu thương đến “Nắng Hạ” và tận hưởng một ngày đầy hứng khởi cùng chương trình chạy trạm 'Vương quốc IS - Công thức bị đánh cắp'!\r\n🌞 Hãy tìm cho mình những người đồng đội và nhanh tay điền form dưới đây để cùng Nắng Hạ “phá án” và tìm ra cuốn bí kíp giải cứu Vương quốc IS nhé!\r\n------------------------------------\r\nTHÔNG TIN CHƯƠNG TRÌNH\r\n🧍 Đối tượng: Sinh viên các trường Đại học trên địa bàn TP. HCM.\r\n⏰ Thời gian tổ chức: 7h00, chủ nhật, 12/5/2024.\r\n⌛ Thời gian đăng ký: từ 04/5/2024 đến 10/5/2024.\r\n📍 Địa điểm: Khu đô thị ĐHQG-HCM.\r\n🌟 Hình thức: Chạy trạm.\r\n🏍️ Phương tiện: Tự do.\r\nHÌNH THỨC ĐĂNG KÝ\r\n🔍 Có 2 hình thức đăng ký:\r\n- Đăng ký trực tiếp tại Sảnh C - Trường Đại học Công nghệ Thông tin, ĐHQG-HCM.\r\n- Đăng ký qua form: https://forms.gle/SHKeMCfX84uNn4kw6\r\n💸 Lệ phí:\r\n- Đăng ký theo đội: 140.000 VNĐ/đội 6 sinh viên.\r\n- Đăng ký cá nhân: 25.000 VNĐ/sinh viên.\r\n❗ Trong trường hợp một đội không đủ số lượng thành viên theo yêu cầu, các bạn vẫn có thể đăng ký cá nhân, BTC sẽ giúp các bạn có nguyện vọng chung đội thành một đội và tìm thêm những đồng đội “đỉnh của chóp”.\r\nCƠ CẤU GIẢI THƯỞNG\r\n🥇 Giải nhất: 250.000 VNĐ.\r\n🥈 Giải nhì: 200.000 VNĐ.\r\n🥉 Giải ba: 150.000 VNĐ.\r\n------------------------------------\r\nMỌI THÔNG TIN VỀ CHƯƠNG TRÌNH “NẮNG HẠ 2024” VUI LÒNG LIÊN HỆ: \r\n💠 Nguyễn Thị Dung: 0346925317 (Trưởng Ban tổ chức) \r\n🔹 Lê Nguyễn Diễm Quyên: 0866658762 (Phó Ban tổ chức)  \r\n🔹 Phạm Nguyễn Hà Vy: 0939199946 (Phó Ban tổ chức)\r\nHoặc:\r\n🌎 Fanpage Đoàn - Hội khoa Hệ thống Thông Tin: https://www.facebook.com/DoanHoiHTTT \r\n📧 Email: httt.doanhoi@gmail.com\r\n#HTTT #ISVOLUNTEER2024 #NangHa", new DateTime(2022, 10, 16, 6, 35, 20, 762, DateTimeKind.Unspecified).AddTicks(5574), "https://forms.gle/HkCD86Gc9UmTTZLP9", false, false, null, null, "Sảnh C - Trường Đại học Công nghệ Thông tin, ĐHQG-HCM", 53, null, null, new DateTime(2022, 9, 16, 13, 4, 9, 203, DateTimeKind.Unspecified).AddTicks(3239), "🎩 [NẮNG HẠ 2024 | VƯƠNG QUỐC IS - CÔNG THỨC BỊ ĐÁNH CẮP] 🎩", 1, "Other", 1 },
                    { 5, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Xem thêm thông tin tại 👉 https://httt.uit.edu.vn/hoi-nghi-sinh-vien-khoa-he-thong.../\r\n🌟 Hội nghị Sinh viên là sự kiện thường niên được tổ chức với mục đích tạo ra một không gian mở để sinh viên có thể gặp gỡ, trao đổi và đưa ra các ý kiến, đề xuất trực tiếp với ban lãnh đạo nhà trường.\r\n🌟 Đây là cơ hội để mỗi sinh viên được lắng nghe, thảo luận và đóng góp ý kiến trực tiếp vào các vấn đề học tập, cơ sở vật chất và nhiều mặt khác của đời sống sinh viên.\r\n👭 Tại hội nghị này, chúng ta sẽ cùng nhau trao đổi về:\r\n- Công tác đào tạo: thời gian, chương trình, nội dung, phương pháp học tập và giảng dạy.\r\n- Hỗ trợ từ cố vấn học tập.\r\n- Cơ sở vật chất phục vụ cho sinh viên.\r\n- Các phong trào và hoạt động chính trị xã hội.\r\n- Công tác bồi dưỡng Đoàn viên, quản lý sinh viên, phát triển Đảng.\r\n- Các thủ tục hành chính, các chính sách mới và quy định mới nhằm nâng cao chất lượng giáo dục.\r\n- Các vấn đề khác mà sinh viên quan tâm.\r\n📌 Thành phần tham dự bao gồm:\r\n- Đại diện Ban Giám hiệu nhà trường \r\n- Ban chủ nhiệm Khoa Hệ thống Thông tin \r\n- Bí thư Đoàn Khoa \r\n- Cố vấn học tập của Khoa \r\n- Đại diện Thường trực Đoàn trường \r\n- Phòng Dữ liệu và CNTT \r\n- Ban quản lý cơ sở \r\n- Đại diện Thư viện \r\n- Đại diện Bộ môn Toán \r\n- Đại diện Lãnh đạo Phòng Đào tạo Đại học\r\n- Đại diện Lãnh đạo và chuyên viên Phòng Công tác sinh viên\r\n- Lãnh đạo Văn phòng Các chương trình Đặc biệt\r\n- Đại diện lãnh đạo Trung tâm ngoại ngữ\r\n- Toàn thể sinh viên khoa HTTT\r\n🗓 Thời gian: 15h00 - 16h20, thứ Ba ngày 07 tháng 05 năm 2024\r\n🏠 Địa điểm: Hội trường E, Trường ĐH Công nghệ Thông tin\r\n🔗 Sinh viên quan tâm đến Hội nghị vui lòng đăng ký tại link sau: https://forms.gle/9hCMfCv8gm5zLHu97\r\n📘 Hãy nắm bắt cơ hội này để cùng xây dựng môi trường học tập tốt hơn!\r\nCác bạn sinh viên ơi, hãy tham gia để góp phần làm nên một khoa Hệ thống Thông tin ngày càng vững mạnh. 🔥🔥🔥", new DateTime(2023, 9, 9, 4, 25, 14, 855, DateTimeKind.Unspecified).AddTicks(6679), "https://forms.gle/HkCD86Gc9UmTTZLP9", false, true, null, null, "Hội trường E, Trường ĐH Công nghệ Thông tin", 57, new DateTime(2023, 8, 7, 19, 11, 23, 89, DateTimeKind.Unspecified).AddTicks(7757), null, new DateTime(2023, 8, 31, 15, 38, 22, 239, DateTimeKind.Unspecified).AddTicks(6409), "🔔 HỘI NGHỊ SINH VIÊN KHOA HỆ THỐNG THÔNG TIN - NĂM HỌC 2023 - 2024 🔔", 6, "Conference", 1 },
                    { 6, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "🎓 Bạn có niềm đam mê với kinh tế lượng và mong muốn nắm vững những kỹ thuật phân tích? Bạn đang tìm kiếm cơ hội để bắt đầu hành trình nghiên cứu khoa học của mình? Đừng bỏ lỡ cơ hội tuyệt vời này!\r\n💡 Nhằm hỗ trợ sinh viên trong việc nắm bắt kiến thức và kỹ năng cần thiết cho nghiên cứu khoa học, Khoa Hệ thống Thông tin tổ chức chuỗi seminar hỗ trợ nghiên cứu khoa học sinh viên. Tiếp nối sự thành công của seminar #1, Khoa Hệ thống Thông tin tổ chức seminar #2 với chủ đề Analysed Techniques in Econometrics: FDI Analysis in Vietnam hứa hẹn sẽ mang đến những thông tin thiết thực và bổ ích.\r\n🌍 Trong bối cảnh nền kinh tế toàn cầu hóa hiện nay, việc hiểu rõ và phân tích dòng FDI là chìa khóa giúp bạn có cái nhìn sâu sắc về sự phát triển kinh tế của Việt Nam. Đây là cơ hội để bạn nắm bắt những xu hướng mới nhất và áp dụng các kỹ thuật phân tích vào nghiên cứu thực tế. Hãy đăng ký tham gia ngay để không bỏ lỡ!\r\n🔍 Thông tin chi tiết chương trình:\r\n📅 Thời gian: 8h00 – 11h00 sáng thứ Ba, ngày 11 tháng 06 năm 2024\r\n📍 Địa điểm: Phòng E4.1, Tòa nhà E, Trường ĐH Công nghệ Thông tin ĐHQG-HCM\r\n👨‍🏫 Giảng viên hướng dẫn: TS. Trần Văn Hải Triều – Giảng viên Bộ môn TMĐT, Khoa Hệ thống Thông tin\r\n📚 Nội dung chính:\r\n1. Phân tích hồi quy (Regression Analysis)\r\n2. Phát triển giả thuyết nghiên cứu (How to Develop Research Hypotheses)\r\n3. Dự báo dữ liệu chuỗi thời gian (Forecasting Time Series Data)\r\n4. Phân tích FDI tại Việt Nam (Case Study: FDI Analysis in Vietnam)\r\n📌 Đăng ký tham gia tại đây: https://forms.gle/TY6PTL3P1LiA981c6\r\n🌟 Đừng bỏ lỡ cơ hội để nâng cao kỹ năng và mở rộng kiến thức của bạn. Tham gia seminar và bắt đầu hành trình nghiên cứu khoa học của bạn ngay hôm nay! \r\nXem thêm thông tin tại: https://httt.uit.edu.vn/seminar-ho-tro-nckh-sinh-vien.../", new DateTime(2022, 9, 1, 16, 7, 14, 71, DateTimeKind.Unspecified).AddTicks(2057), "https://forms.gle/HkCD86Gc9UmTTZLP9", false, false, null, null, "Phòng E4.1, Tòa nhà E, Trường ĐH Công nghệ Thông tin ĐHQG-HCM", 87, null, null, new DateTime(2022, 8, 14, 18, 12, 35, 275, DateTimeKind.Unspecified).AddTicks(9580), "🌟 SEMINAR ANALYSED TECHNIQUES IN ECONOMETRICS: FDI ANALYSIS IN VIETNAM 🌟", 6, "Seminar", 2 },
                    { 7, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "🎓 Bạn đam mê phân tích dữ liệu? Bạn muốn tham gia các đề tài nghiên cứu khoa học nhưng không biết bắt đầu từ đâu? Đây chính là cơ hội mà bạn không thể bỏ lỡ!\r\n💡 Nhằm hỗ trợ sinh viên tìm hiểu quá trình và bắt đầu tham gia nghiên cứu khoa học, Khoa Hệ thống Thông tin tổ chức chuỗi seminar để trang bị kiến thức và kỹ năng cần thiết cho các bạn sinh viên. Hãy tham gia seminar đầu tiên với những thông tin bổ ích!\r\nThông tin chi tiết:\r\n📅 Thời gian: 8h00 sáng thứ Ba, ngày 04 tháng 06 năm 2024\r\n📍 Địa điểm: Phòng E10.1, Tòa nhà E, Trường ĐH Công nghệ Thông tin ĐHQG-HCM\r\n👨‍🏫 Giảng viên hướng dẫn: TS. Nguyễn Thanh Bình – Trưởng phòng thí nghiệm HTTT – Trưởng Bộ môn HTTT Quản lý\r\n🔍 Nội dung seminar:\r\n1. Giới thiệu:\r\n- Phân tích dữ liệu\r\n- Quy trình phân tích dữ liệu\r\n- Công cụ phân tích\r\n2. Bài toán dự báo giá chứng khoán:\r\n- Giới thiệu hệ thống\r\n- Chi tiết xử lý từng module của hệ thống\r\n- Bài toán dữ liệu chuỗi thời gian\r\n- Các thuật toán sử dụng trong dự báo\r\n📌 Link đăng ký tham gia: https://forms.gle/KSWy6re37URaRFNb7\r\n🚀 Đừng bỏ lỡ cơ hội học hỏi và nâng cao kỹ năng của bạn! Đây là dịp tuyệt vời để bạn trang bị những kiến thức thực tiễn và bắt đầu cho quá trình tham gia nghiên cứu khoa học.", new DateTime(2023, 8, 25, 20, 59, 39, 532, DateTimeKind.Unspecified).AddTicks(8761), "https://forms.gle/HkCD86Gc9UmTTZLP9", false, false, null, null, "Phòng E10.1, Tòa nhà E, Trường ĐH Công nghệ Thông tin ĐHQG-HCM", 24, null, null, new DateTime(2023, 7, 29, 20, 46, 48, 312, DateTimeKind.Unspecified).AddTicks(2751), "📊 SEMINAR PHÂN TÍCH DỮ LIỆU VÀ THỰC NGHIỆM TỪ ZERO TỚI HERO: BÀI TOÁN DỰ BÁO GIÁ CHỨNG KHOÁN", 3, "Seminar", 2 },
                    { 8, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "🌟 Bạn muốn tìm hiểu về các ngành đào tạo thạc sĩ của Trường ĐH Công nghệ Thông tin?\r\n🌟 Bạn muốn tìm hiểu về tuyển sinh trình độ thạc sĩ năm 2024 chỉ xét hồ sơ, không thi tuyển\r\n🌟 Bạn muốn biết xét tuyển và tuyển thẳng khác nhau thế nào?\r\n🌟 Bạn muốn biết xét tuyển chỉ dựa vào đánh giá hồ sơ và xét tuyển dựa trên đánh giá hồ sơ kết hợp phỏng vấn thế nào?\r\n🌟 Bạn muốn biết về học phí, và các chế độ học bổng, hỗ trợ NCKH?\r\n📅 Mời các bạn đến tham dự buổi tư vấn tuyển sinh chương trình đào tạo trình độ thạc sĩ của Trường ĐH Công nghệ Thông tin: \r\n🕥 Thời gian: 10h30 - 11h30, Thứ sáu ngày 10 tháng 5 năm 2024.\r\n📍 Địa điểm: Phòng E1.1 - Trường ĐH Công nghệ Thông tin, Khu phố 6, Phường Linh Trung, TP. Thủ Đức, TP.HCM.\r\n🎙 Nội dung: PGS. TS. Lê Đình Duy - Trưởng phòng Đào tạo Sau Đại học và Khoa học Công nghệ sẽ tư vấn và giải đáp tất cả thắc mắc của các bạn. \r\n🔗 Đăng ký ngay tại: https://bom.so/kHTUfF\r\n💻 Trường hợp các bạn không tham gia offline, sau khi đăng ký Phòng sẽ gửi link tham gia online qua email đăng ký.\r\nℹ️ Thông tin tuyển sinh chi tiết xem tại: https://sdh.uit.edu.vn/.../thong-bao-tuyen-sinh-chuong...\r\n📞 Liên hệ Cô Tuyết Minh (0918302372) để được tư vấn thêm.", new DateTime(2022, 7, 18, 1, 52, 4, 994, DateTimeKind.Unspecified).AddTicks(5464), "https://forms.gle/HkCD86Gc9UmTTZLP9", false, true, null, null, "Phòng E1.1 - Trường ĐH Công nghệ Thông tin, Khu phố 6, Phường Linh Trung, TP. Thủ Đức, TP.HCM.", 86, new DateTime(2022, 5, 28, 21, 57, 54, 182, DateTimeKind.Unspecified).AddTicks(2388), null, new DateTime(2022, 7, 12, 23, 21, 1, 348, DateTimeKind.Unspecified).AddTicks(5922), "📝 TƯ VẤN TUYỂN SINH CHƯƠNG TRÌNH ĐÀO TẠO TRÌNH ĐỘ THẠC SĨ CỦA TRƯỜNG ĐẠI HỌC CÔNG NGHỆ THÔNG TIN 📝 ", 4, "Other", 2 },
                    { 9, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "🏐 Bạn yêu thích bóng chuyền? \r\n🏐 Bạn sẵn sàng thể hiện tinh thần thể thao và khả năng chơi bóng chuyền của mình? \r\nĐây là cơ hội để bạn tỏa sáng và góp phần nâng cao tinh thần thể thao trong Nhà trường!  \r\n📌 Với mục tiêu thúc đẩy phong trào tham gia hoạt động thể dục, thể thao. Nâng cao sức khỏe trong học tập và rèn luyện cho sinh viên. Phát huy sức mạnh hệ thống trong công tác giáo dục thể chất. 👉 👉 👉  Khoa Hệ thống Thông tin tuyển sinh viên tham gia vào đội tuyển bóng chuyền Nam/Nữ của Khoa để tham gia hội thao UIT Sport 2024.\r\n👥 Đối tượng tham gia: Sinh viên thuộc Khoa HTTT, hệ đào tạo chính quy văn bằng 1 của Trường và sinh viên chương trình liên kết. Đảm bảo sức khỏe tốt để tham gia thi đấu. Có Bảo hiểm y tế và Bảo hiểm tai nạn còn thời hạn.\r\n⏰ Thời gian thi đấu: Tháng 5/2024 tại sân bóng chuyền Trường Đại học Công nghệ Thông tin – ĐHQG-HCM.\r\n💰 Lệ phí tham gia: Khoa HTTT hỗ trợ 100% lệ phí tham gia.\r\n📅 Thời gian đăng ký: Từ nay đến hết ngày 02/05/2024.\r\n🔗 Đăng ký tham gia tại: https://forms.gle/b6BcSkCTiKWxvqgv8\r\n🎯 Đừng bỏ lỡ cơ hội này để trải nghiệm, rèn luyện và chiến thắng! Đăng ký ngay để trở thành một phần của đội tuyển bóng chuyền khoa Hệ thống Thông tin!\r\n👉 Xem thêm thông tin tại: https://httt.uit.edu.vn/dang-ky-tham-gia-thi-dau-giai.../", new DateTime(2023, 7, 10, 19, 44, 51, 228, DateTimeKind.Unspecified).AddTicks(1099), "https://forms.gle/HkCD86Gc9UmTTZLP9", false, true, null, null, "Sân bóng chuyền Trường Đại học Công nghệ Thông tin – ĐHQG-HCM", 41, new DateTime(2023, 5, 25, 19, 53, 35, 370, DateTimeKind.Unspecified).AddTicks(7107), null, new DateTime(2023, 6, 27, 1, 55, 14, 384, DateTimeKind.Unspecified).AddTicks(9092), "🌟 ĐĂNG KÝ THAM GIA ĐỘI TUYỂN BÓNG CHUYỀN NAM NỮ KHOA HỆ THỐNG THÔNG TIN THAM GIA GIẢI UIT SPORT 2024🌟", 3, "Other", 2 },
                    { 10, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "🧷 Đăng ký tham gia tại: https://forms.gle/aytHNGhdTprxGN1o7\r\nĐến với seminar lần này, ngoài việc khám phá cơ hội nghề nghiệp với Microsoft Dynamics, bạn sẽ được: \r\n📘 Kiến thức chuyên sâu: Hiểu rõ về các sản phẩm của Microsoft Dynamics như Finance & Operations, Business Central và Power Platform.\r\n📘 Kinh nghiệm thực tế: Nghe chia sẻ từ các chuyên gia hàng đầu và hiểu biết sâu về thị trường ERP toàn cầu.\r\n🌐 Mở rộng mạng lưới, tiếp xúc và trao đổi với các chuyên gia trong ngành.\r\n🎁 Và đặc biệt là những phần quà hấp dẫn từ BTC, cùng với điểm rèn luyện đối với các bạn sinh viên UIT. \r\n ---------------------------------------\r\n📝 THÔNG TIN VỀ CHƯƠNG TRÌNH\r\n👨‍🏫 Diễn giả: Anh Nguyễn Đức Huy Vũ - Giám Đốc Trung Tâm Dịch Vụ Phần Mềm Doanh Nghiệp Microsoft Dynamics (FPT Software)\r\n📆 Thời gian: 9h00 - 11h00, Thứ Hai, ngày 22/04/2024\r\n🏢 Địa điểm: Hội trường E, Trường Đại học Công nghệ Thông Tin\r\n🔹 Đối tượng tham gia: Giảng viên, sinh viên, và mọi người quan tâm\r\n💬 Hãy đăng ký tham gia và chia sẻ sự kiện này với bạn bè để không ai bỏ lỡ cơ hội tuyệt vời này bạn nhé!", new DateTime(2022, 7, 2, 17, 34, 45, 321, DateTimeKind.Unspecified).AddTicks(2204), "https://forms.gle/HkCD86Gc9UmTTZLP9", false, false, null, null, "Hội trường E, Trường Đại học Công nghệ Thông Tin", 76, null, null, new DateTime(2022, 6, 10, 4, 29, 27, 421, DateTimeKind.Unspecified).AddTicks(2263), "🌟 Hãy đăng ký tham Gia Seminar về Microsoft Dynamics và Khám phá những quyền lợi đặc biệt 🌟 ", 5, "Seminar", 2 },
                    { 11, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "👉 Đăng ký ngay: https://bit.ly/4bGcYvu \r\nTrong không khí sôi nổi của vòng loại Code Challenge #2 sắp diễn ra, Code Tour 2024 dành tặng riêng cho sinh viên UIT một hoạt động đặc biệt “Đăng ký và chia sẻ - Nhận ngay quà may mắn” với quà tặng độc - lạ nhưng cũng tiện dụng vô cùng.\r\nQuà tặng: 06 sinh viên tham gia hợp lệ sẽ nhận được 01 phần quà ngẫu nhiên từ Bộ sưu tập Code Tour, trong đó:\r\n🤩 01 sinh viên có chia sẻ truyền cảm hứng nhất: Chuột bluetooth Logitech trị giá 500,000 đồng.\r\n👍 05 sinh viên may mắn nhất: Lót chuột chống mỏi tay hoặc Bình giữ nhiệt trị giá 250,000 đồng.\r\n📝 Note ngay 03 bước tham gia để có cơ hội nhận giải thưởng nhé:\r\nBước 1: Đăng ký tham gia Code Challenge #2 và #3 tại https://bit.ly/4bGcYvu \r\nBước 2: Comment username + MSSV của bạn dưới bài viết này\r\nBước 3: Share bài viết về trang cá nhân của bạn ở chế độ công khai. Caption bao gồm: đôi dòng chia sẻ về lý do nên tham gia Code Tour + hashtag #CodeTour2024\r\n⏰ Thời gian tham gia: Từ ngày 13/06 đến hết ngày 20/06/2024. Kết quả sẽ được Trường thông báo trực tiếp dưới phần comment của bài viết này vào ngày 26/06/2024.\r\nVòng thi Code Challenge #2 vẫn đang mở đơn mời gọi các anh em chí code cùng tham gia, bạn hãy ĐĂNG KÝ NGAY để cùng BTC ôn tập và chuẩn bị thật tốt cho kỳ thi nha 💪\r\n---\r\nCODE TOUR 2024 - Code - Connect - Challenge\r\nWebsite: https://codetour.org/ \r\nGroup trao đổi: https://www.facebook.com/groups/codetoconnect \r\nFanpage: https://www.facebook.com/LifeAtVNG \r\n#CodeTour #CodeConnectChallenge #Giaidaulaptrinh #LifeatVNG", new DateTime(2023, 5, 26, 16, 29, 21, 379, DateTimeKind.Unspecified).AddTicks(5572), "https://forms.gle/HkCD86Gc9UmTTZLP9", false, true, null, null, "Online", 33, new DateTime(2023, 5, 18, 15, 44, 57, 747, DateTimeKind.Unspecified).AddTicks(6548), null, new DateTime(2023, 5, 25, 7, 3, 40, 457, DateTimeKind.Unspecified).AddTicks(5434), "ĐĂNG KÝ THAM GIA & “REVIEW” CUỘC THI - NHẬN QUÀ MAY MẮN TỪ CODE TOUR", 2, "Other", 3 },
                    { 12, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "💡 Đã bao giờ bạn tự hỏi “đóng gói, kế thừa, đa hình, trừu tượng” là gì mà lại khiến cho chúng ta phải say đắm nhiều như vậy chưa?\r\n❓ Nếu câu là trả lời là chưa, vậy thì còn chần chừ gì nữa mà tham gia cùng với Ban Học tập chúng mình nhé!\r\n✨ Tại đây, chúng mình hứa hẹn sẽ mang đến nhiều điều bất ngờ dành cho tất cả các bạn, cũng như giải đáp những vấn đề mà các bạn đang gặp phải. Từ đó, chúng mình hy vọng có thể giúp các bạn có nền tảng kiến thức thật vững vàng và sẵn sàng chinh phục điểm 10 “âu âu pi” sắp tới!\r\n😻 Nghe hấp dẫn quá phải không nào? Thế thì càng phải lưu lại thông tin của buổi ôn tập này đấy nhé!\r\nThông tin chi tiết:\r\n🕐 Thời gian: 𝟏𝟑𝐡𝟑𝟎 - 𝐓𝐡𝐮̛́ 𝟐, ngày 𝟏𝟎/𝟎𝟔/𝟐𝟎𝟐𝟒\r\n⛳ Địa điểm: Phòng 𝐁𝟏.𝟐𝟎\r\n❗ Lưu ý: Đừng quên trang bị đầy đủ dụng cụ học tập để có một buổi trao đổi kiến thức thật hiệu quả nhé!\r\n💌 Nếu có bất kỳ thắc mắc nào, đừng ngần ngại liên hệ ngay với Fanpage Mạng Máy tính và Truyền thông để được bọn mình hỗ trợ nhé! Chúc bạn đạt được kết quả học tập thật tốt trong thời gian sắp tới!\r\n➖➖➖➖➖\r\n#NC #UIT #VNUHCM \r\n#CTV #BHT #DOANKHOA", new DateTime(2022, 5, 18, 21, 21, 46, 841, DateTimeKind.Unspecified).AddTicks(2274), "https://forms.gle/HkCD86Gc9UmTTZLP9", false, true, null, null, "Phòng 𝐁𝟏.𝟐𝟎", 70, new DateTime(2022, 3, 15, 13, 40, 38, 936, DateTimeKind.Unspecified).AddTicks(1268), null, new DateTime(2022, 5, 8, 9, 37, 53, 493, DateTimeKind.Unspecified).AddTicks(8604), "BHT ĐOÀN KHOA MMT&TT | NHẮC NHỞ ÔN TẬP LẬP TRÌNH HƯỚNG ĐỐI TƯỢNG", 1, "Training", 3 },
                    { 13, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Phòng ĐTSĐH&KHCN vừa có thông báo triển khai xét hỗ trợ kinh phí và khen thưởng NCKH sinh viên đợt tháng 6 năm 2024. Quy trình thực hiện như sau:\r\n📍 Bước 1: Sinh viên, học viên cao học, nghiên cứu sinh điền thông tin bài báo khoa học vào form đăng ký: https://forms.gle/xJMzoF151facKuSPA và forward Response Receipt về email của GVHD, các sinh viên trong nhóm, VP Khoa, Phòng CTSV (ctsv@uit.edu.vn), Phòng ĐTĐH (phongdaotaodh@uit.edu.vn), Phòng ĐTSĐH&KHCN (qlkhcn@uit.edu.vn), VPĐB (vpdb@uit.edu.vn) (nếu là SV các chương trình Chất lượng cao, Tài năng, Tiên tiến). Đây được xem như là đơn điện tử để các đơn vị liên quan xử lý. \r\n📍 Bước 2: Theo từng đợt xét duyệt (tháng 06 và tháng 11 hàng năm), các Khoa sẽ xét duyệt các bài báo khoa học và gửi đề xuất hỗ trợ kinh phí, khen thưởng về P.ĐTSĐH&KHCN\r\n📍 Bước 3: Phòng ĐTSĐH&KHCN phối hợp các đơn vị liên quan khác (Phòng CTSV, Phòng KHTC) để thực hiện theo quy định.\r\nQuy trình xét hỗ trợ kinh phí khen thưởng NCKH SV được thực hiện theo quy định: https://khcn.uit.edu.vn/.../quy-dinh-ve-chinh-sach-ho-tro...\r\n❗ Lưu ý: Đối với Học viên cao học, cần xem Điều 3, mục 2 trong quy định trên.\r\nPhòng ĐTSĐH&KHCN vừa có thông báo triển khai xét hỗ trợ kinh phí và khen thưởng NCKH sinh viên đợt tháng 6 năm 2024.\r\nĐể hỗ trợ cho các bạn SV/HVCH trong việc đăng ký, Khoa MMT&TT sẽ tổ chức cuộc họp trực tuyến để hướng dẫn thực hiện các bước đăng ký, thông tin như sau:\r\n⏲️ Thời gian: 10:00 ngày 14/6/2024\r\n💻 Hình thức: trực tuyến qua Google Meet\r\n📧 Link: https://meet.google.com/dqm-orhy-rfi\r\nMọi thắc mắc, các bạn SV/HVCH liên hệ thầy Khánh Thuật (thuatnk@uit.edu.vn)\r\nChi tiết xem tại: https://nc.uit.edu.vn/.../thong-bao-tham-du-seminar-huong...\r\n#SEMINAR #NCKH #NC #UIT #VNUHCM", new DateTime(2023, 5, 11, 11, 4, 27, 600, DateTimeKind.Unspecified).AddTicks(5519), "https://forms.gle/HkCD86Gc9UmTTZLP9", false, false, null, null, "trực tuyến qua Google Meet: https://meet.google.com/dqm-orhy-rfi", 46, null, null, new DateTime(2023, 4, 22, 12, 12, 6, 530, DateTimeKind.Unspecified).AddTicks(1775), "[SEMINAR | HƯỚNG DẪN ĐĂNG KÝ HỖ TRỢ CÔNG BỐ KHOA HỌC DÀNH CHO SINH VIÊN]", 1, "Seminar", 3 },
                    { 14, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "😍 Bạn là người yêu thích an toàn thông tin và có niềm đam mê đặc biệt với CTF?\r\n🤗 Bạn muốn tìm kiếm những người cùng chí hướng, để cùng nhau nâng cao kỹ năng và vươn xa?\r\n🧑‍💻 Bạn đang tìm kiếm một môi trường năng động, nơi bạn có thể học hỏi và phát triển đam mê?\r\n👉 Vậy thì 𝐓𝐞𝐚𝐦𝐓 đích thị là nơi bạn đang tìm kiếm đó! 𝐓𝐞𝐚𝐦𝐓 (𝐓𝐡𝐞 𝐂𝐲𝐛𝐞𝐫 𝐊𝐧𝐢𝐠𝐡𝐓) mang trong mình nhiệm vụ hướng các bạn sinh viên UIT tới các cuộc thi học thuật về lĩnh vực An toàn thông tin cụ thể là các cuộc thi CTF; nghiên cứu chuyên sâu bảo mật, bug hunting, CVE… Đây là nơi giao lưu, học hỏi giữa những “pháp sư” ở nhiều lĩnh vực khác nhau nhưng đều có một niềm đam mê đặc biệt với CTF nói riêng và An toàn thông tin nói chung.\r\n🚩 Đến với 𝐓𝐞𝐚𝐦𝐓 của CLB 𝐖𝐚𝐧𝐧𝐚.𝐖𝟏𝐧, bạn không chỉ được học hỏi về CTF mà còn được giao lưu, có cơ hội hòa mình vào sân chơi học thuật đầy thú vị. Đồng thời phát triển được nhiều kỹ năng qua sự hướng dẫn nhiệt tình từ thầy cô cũng như các anh, chị và các bạn đồng trang lứa.\r\n𝐓𝐡𝐨̂𝐧𝐠 𝐭𝐢𝐧 𝐭𝐮𝐲𝐞̂̉𝐧 𝐭𝐡𝐚̀𝐧𝐡 𝐯𝐢𝐞̂𝐧:\r\n👉 Tuyển thành viên theo từng mảng\r\n⏰ Thời gian đăng ký: Từ ngày 𝟎𝟔/𝟎𝟔/𝟐𝟎𝟐𝟒 đến hết ngày 𝟏𝟎/𝟎𝟔/𝟐𝟎𝟐𝟒\r\n📌 Link đăng ký: https://forms.gle/p9gbrm4eCjkzagwP9\r\n🙋‍♂️ Đối tượng: Các UITer biết chơi CTF, có niềm đam mê và muốn học tập thêm về lĩnh vực này.\r\n🌟 Tham gia 2 vòng tuyển chọn:\r\nVòng 1: Test năng lực - Làm bài thi về các mảng khác nhau trong CTF \r\nVòng 2: Phỏng vấn tuyển chọn.\r\n✅ Quyền lợi: Được học tập, rèn luyện cùng những bạn có nhiều thành tích trong các cuộc thi CTF.\r\n🔥 Đây là một cơ hội 'hiếm có khó tìm' với rất nhiều sự thú vị đang chờ đón bạn. Còn chần chờ gì nữa mà không nhanh tay đăng ký để trở thành một trong những thành viên của mái nhà chung 𝐖𝐚𝐧𝐧𝐚.𝐖𝟏𝐧 thôi nào!! 🔥\r\n➖➖➖➖➖➖\r\nMọi thắc mắc vui lòng liên hệ qua:\r\n     🔸 𝐅𝐚𝐧𝐩𝐚𝐠𝐞: Phòng thí nghiệm An toàn thông tin - UIT InSecLab\r\n     🔸 𝐆𝐦𝐚𝐢𝐥: inseclab@uit.edu.vn\r\n     🔸 𝐃𝐢𝐬𝐜𝐨𝐫𝐝: Wanna.W1n - UIT Hacking Community\r\n➖➖➖➖➖➖\r\n#uit #inseclab #sinhvien #ATTT #wannaGame #CTF \r\nNguồn: Phòng thí nghiệm An toàn thông tin - UIT InSecLab", new DateTime(2024, 5, 3, 8, 54, 21, 693, DateTimeKind.Unspecified).AddTicks(6625), "https://forms.gle/HkCD86Gc9UmTTZLP9", false, false, null, null, "Online", 64, null, null, new DateTime(2024, 4, 5, 14, 46, 19, 566, DateTimeKind.Unspecified).AddTicks(4946), "TUYỂN THÀNH VIÊN | 𝐂𝐋𝐁 𝐖𝐀𝐍𝐍𝐀.𝐖𝟏𝐍 THÔNG BÁO MỞ ĐƠN TUYỂN THÀNH VIÊN 𝐓𝐄𝐀𝐌𝐓 ", 4, "Other", 3 },
                    { 15, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "🤩 Bạn là một con dân IT yêu thích sự sáng tạo?\r\n🤗 Bạn có một góc học tập/ làm việc cực chill muốn khoe nó với mọi người?\r\n🫣 Bạn là người đang sở hữu những món đồ IT độc đáo? Có thể là một bàn phím cơ “đỉnk kao”, vài cái màn hình “Vip Pro” để phục vụ cho việc code dạo.\r\n🔥 Nếu có những thứ đó thì chắc hẳn góc học tập của bạn sẽ cực kì thú vị phải không nhỉ? Hãy cùng tham gia 𝐖𝐚𝐧𝐧𝐚𝐒𝐞𝐭𝐮𝐩 để khoe không gian học tập của mình với mọi người thoi nào!!!!!!! Vừa có thể “flex” góc học tập, góc làm việc xịn xò của mình mà vừa có thể nhận được những giải thưởng thú vị nữa đó.🤭 \r\n➖➖➖➖➖\r\n𝐖𝐀𝐍𝐍𝐀𝐒𝐄𝐓𝐔𝐏 𝟐𝟎𝟐𝟒 là cuộc thi được tổ chức bởi CLB Wanna.W1n kết hợp cùng Bộ môn An toàn Thông tin - Khoa Mạng máy tính và Truyền Thông nhằm tạo sân chơi cho các bạn sinh viên An toàn Thông tin và sinh viên UIT tìm ra không gian setup ấn tượng nhất.\r\nTHỂ LỆ THAM DỰ\r\nCác bạn thí sinh tham gia cuộc thi sẽ thực hiện lựa chọn hình thức như sau:\r\n       📷 Thực hiện chụp hình góc học tập / làm việc của mình (tối thiểu 3 ảnh - tối đa 5 ảnh).\r\n     📹 Thực hiện quay video dài tối đa 5 phút giới thiệu (thuyết minh) về góc học tập / làm việc của mình (lưu ý bản quyền nhạc nếu có nhạc nền).\r\n⏰ Thời gian đăng ký: Từ ngày 𝟎𝟓/𝟎𝟔/𝟐𝟎𝟐𝟒 đến ngày 𝟏𝟎/𝟎𝟔/𝟐𝟎𝟐𝟒\r\n📈 Thời gian bình chọn: Từ ngày 𝟏𝟏/𝟎𝟔/𝟐𝟎𝟐𝟒 đến ngày 𝟏𝟒/𝟎𝟔/𝟐𝟎𝟐𝟒\r\n📌 Đăng ký tham gia tại: https://forms.gle/FoVtWFvWQf3nLi1s7\r\n📝 Ngoài ra, các bạn thí sinh khi tham gia sẽ gửi kèm một đoạn mô tả ngắn về góc học tập / làm việc của mình.\r\nCÁCH THỨC ĐÁNH GIÁ\r\nVới mỗi bài dự thi sẽ được đánh giá bởi:\r\n       🙋🏻 Đánh giá của khán giả chiếm 𝟒𝟎% bao gồm:\r\n             👍 Mỗi lượt tương tác sẽ được cộng 𝟎.𝟓 điểm.\r\n             💬 Tag tên của 3 người bạn khác được cộng 𝟎𝟏 điểm.\r\n             🔔 Chia sẻ ở chế độ công khai và có chứa hashtag của cuộc thi được cộng 𝟎𝟓 điểm.\r\n       🤵 Đánh giá của BGK chiếm 𝟔𝟎%.\r\nGIẢI THƯỞNG\r\n       🥇 1 Giải Nhất - 𝟖𝟎𝟎.𝟎𝟎𝟎 𝐕𝐍𝐃\r\n       🥈 1 Giải Nhì - 𝟒𝟎𝟎.𝟎𝟎𝟎  𝐕𝐍𝐃\r\n       🥉 1 Giải Ba - 𝟐𝟎𝟎.𝟎𝟎𝟎  𝐕𝐍𝐃\r\n       🏅 1 Giải Góc Setup được khán giả yêu thích nhất - 𝟑𝟎𝟎.𝟎𝟎𝟎 𝐕𝐍𝐃\r\n       🎖️ 1 Giải Góc Setup ấn tượng nhất - 𝟑𝟎𝟎.𝟎𝟎𝟎 𝐕𝐍𝐃\r\n🏆 Còn chần chờ gì nữa mà không nhanh tay đăng ký tham gia ngay để có cơ hội nhận được những giải thưởng vô cùng hấp dẫn.\r\n➖➖➖➖➖\r\nMọi thắc mắc vui lòng liên hệ qua:\r\n     🔸 𝐅𝐚𝐧𝐩𝐚𝐠𝐞: facebook.com/inseclab/\r\n     🔸 𝐆𝐦𝐚𝐢𝐥: inseclab@uit.edu.vn\r\n     🔸 𝐃𝐢𝐬𝐜𝐨𝐫𝐝: Wanna.W1n - UIT Hacking Community\r\n➖➖➖➖➖\r\n#uit #inseclab #sinhvien #ATTT #WannaSetup", new DateTime(2023, 3, 27, 11, 59, 3, 226, DateTimeKind.Unspecified).AddTicks(2383), "https://forms.gle/HkCD86Gc9UmTTZLP9", false, true, null, null, "Online", 99, new DateTime(2023, 3, 5, 18, 59, 28, 171, DateTimeKind.Unspecified).AddTicks(5851), null, new DateTime(2023, 3, 20, 17, 20, 32, 602, DateTimeKind.Unspecified).AddTicks(8116), "𝐖𝐀𝐍𝐍𝐀𝐒𝐄𝐓𝐔𝐏 𝟐𝟎𝟐𝟒 | CUỘC THI SETUP GÓC HỌC TẬP DÀNH CHO SINH VIÊN UIT", 5, "Other", 3 },
                    { 16, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "‼️ Đúng vậy, Seminar “Get Ready For Your Gaming Career Path” do công ty Gameloft và CLB UIT GamApp Studios phối hợp tổ chức sẽ diễn ra trong ngày mai (07/06/2024).\r\n✨ Đến với seminar, các bạn sẽ được học hỏi kinh nghiệm vào ngành từ diễn giả có thâm niên trong nghề – anh Nguyễn Anh Tuấn. Bên phía công ty còn dành ra một số phần quà cho các bạn tham gia tích cực trong buổi seminar nữa đó.\r\n👀 BTC cũng bật mí cho các bạn rằng sẽ có THÔNG TIN về 1 CHƯƠNG TRÌNH HỖ TRỢ DỰ ÁN do Gameloft tổ chức tại buổi seminar. Nếu các bạn có ý tưởng cho dự án riêng nhưng thiếu hậu thuận thì đây là 1 CƠ HỘI không thể bỏ lỡ.\r\n🔥 Nhanh chân lên nào các bạn ơi, seminar sắp diễn ra rồi!!!\r\n ——————————————————\r\n       THÔNG TIN CHI TIẾT VỀ SEMINAR:\r\n⏰ Thời gian: 9h45, thứ 6 ngày 7/6/2024.\r\n📍 Địa điểm: Hội trường E, tầng 12 tòa E, trường Đại học Công nghệ Thông tin.\r\n🎤 Diễn giả: Anh Nguyễn Anh Tuấn – Programmer Division Lead at Gameloft.\r\n📌 Link đăng ký: https://tinyurl.com/seminar-grfygcp\r\n🕤 Thời gian đăng ký: từ ngày 29/05/2024.\r\n——————————————————\r\nMọi thắc mắc liên hệ tại:\r\n 💻 Official Page: https://www.facebook.com/UITGamAppStudios\r\n 📩 Gmail: gamappuit.club@gmail.com", new DateTime(2024, 3, 19, 16, 51, 28, 687, DateTimeKind.Unspecified).AddTicks(9086), "https://forms.gle/HkCD86Gc9UmTTZLP9", false, false, null, null, "Hội trường E, tầng 12 tòa E, trường Đại học Công nghệ Thông tin", 98, null, null, new DateTime(2024, 3, 3, 19, 54, 45, 639, DateTimeKind.Unspecified).AddTicks(1287), "💫 [GAMELOFT] SEMINAR SẮP DIỄN RA RỒI!!! CÁC GAME DEVELOPER ƠI!!! 💫", 3, "Seminar", 4 },
                    { 17, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "🏖 Bạn có biết, điều hấp dẫn, thú vị nào đang chờ đón bạn trong mùa hè này không?\r\n📩 Reng…reng! Mùa Hè Xanh gửi đến bạn lời mời trở thành chiến sĩ trên hành trình tình nguyện sắp tới. Chuỗi ngày khoác lên mình chiếc áo xanh, đồng hành cùng đội hình và những người bạn, chắc chắn sẽ tạo nên những khoảnh khắc không thể quên cho thời sinh viên của bạn.\r\n🙅 Đừng để những tháng ngày nóng bức trôi qua lãng phí, hãy nhanh tay đăng ký trở thành những chiến sĩ tình nguyện ngay để cùng chúng mình “phủ xanh mùa hè” qua những hoạt động thú vị chỉ có tại Mùa Hè Xanh 2024!\r\n-----------------------------\r\n💙 THÔNG TIN CHIẾN DỊCH 💙\r\n🌈 Chiến dịch Mùa Hè Xanh 2024 của trường Đại học Công nghệ Thông tin là hoạt động tình nguyện diễn ra trong hơn một tháng với sự tham gia của nhiều đội hình khác nhau.\r\n️⛳ Timeline chiến dịch:\r\n   ▪️ Phỏng vấn tuyển chọn chiến sĩ: Các ngày 11/06 và 12/06 tại trường ĐH CNTT\r\n   ▪️ Hoạt động gây quỹ, làm việc nhóm: Các ngày 13/06 - 08/07\r\n   ▪️ Lễ ra quân chiến dịch: Ngày 08/07 tại trường ĐH CNTT\r\n   ▪️ Thời gian đóng quân tại địa bàn: Các ngày 08/07 - 29/07\r\n   ▪️ Hội quân cấp Trường: Ngày 29/07 tại trường ĐH CNTT\r\n#MHX2024 #MHXUIT2024", new DateTime(2023, 3, 10, 11, 44, 23, 619, DateTimeKind.Unspecified).AddTicks(8241), "https://forms.gle/HkCD86Gc9UmTTZLP9", false, false, null, null, "Trường ĐH CNTT", 35, null, null, new DateTime(2023, 2, 15, 22, 28, 58, 675, DateTimeKind.Unspecified).AddTicks(4458), "🍀 [MÙA HÈ XANH 2024 | THÔNG BÁO TUYỂN CHIẾN SĨ] 🍀", 6, "Other", 4 },
                    { 18, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Trước ngưỡng cửa bước vào thị trường việc làm đầy cạnh tranh, việc sở hữu “𝗔 𝗣𝗿𝗼𝗳𝗲𝘀𝘀𝗶𝗼𝗻𝗮𝗹 𝗣𝗿𝗼𝗳𝗶𝗹𝗲” - một hồ sơ cá nhân chuyên nghiệp là điều thiết yếu. Tuy nhiên, hồ sơ cá nhân như thế nào là chuyên nghiệp và giúp bạn “nổi bật” trong mắt nhà tuyển dụng⁉️ Có phải hồ sơ cá nhân chỉ là Resume hay CV không⁉️\r\nNếu còn lăn tăn những câu hỏi trên thì webinar “𝗔 𝗣𝗿𝗼𝗳𝗲𝘀𝘀𝗶𝗼𝗻𝗮𝗹 𝗣𝗿𝗼𝗳𝗶𝗹𝗲 𝗙𝗼𝗿 𝗬𝗼𝘂𝗿 𝗖𝗮𝗿𝗲𝗲𝗿 𝗦𝘂𝗰𝗰𝗲𝘀𝘀” - phiên bản dành riêng cho các bạn 𝘀𝗶𝗻𝗵 𝘃𝗶𝗲̂𝗻 𝗖𝗼̂𝗻𝗴 𝗻𝗴𝗵𝗲̣̂ 𝗧𝗵𝗼̂𝗻𝗴 𝘁𝗶𝗻, chính là chân ái của bạn đấy! Đăng ký ngay tại  https://bit.ly/VNG_2024_Webinar01 \r\n🕖 Thời gian: 𝟭𝟵𝗵𝟬𝟬 - 𝟮𝟬𝗵𝟬𝟬 𝗧𝗵𝘂̛́ 𝗡𝗮̆𝗺, 𝗻𝗴𝗮̀𝘆 𝟯𝟬/𝟬𝟱/𝟮𝟬𝟮𝟰\r\n📍 Nền tảng: 𝗭𝗼𝗼𝗺 𝗪𝗲𝗯𝗶𝗻𝗮𝗿 - đường link tham gia sẽ được gửi đến bạn qua email sau khi đăng ký thành công. \r\n🎤 Diễn giả: Chị 𝗛𝘂̛𝗼̛𝗻𝗴 𝗩𝘂̃ - 𝗧𝗮𝗹𝗲𝗻𝘁 𝗔𝗰𝗾𝘂𝗶𝘀𝗶𝘁𝗶𝗼𝗻 𝗠𝗮𝗻𝗮𝗴𝗲𝗿, VNG Corporation. Với hơn 14 năm kinh nghiệm phụ trách mảng tuyển dụng ở đa dạng các vị trí và các chương trình dành cho sinh viên tại VNG, chị Hương chắc chắn sẽ mang đến nhiều chia sẻ bổ ích và hữu dụng để bạn chinh phục trái ❤️ các nhà tuyển dụng 😉\r\n🎁 Đặc biệt: Tất cả các bạn đăng ký tham gia sẽ được VNG gửi tặng “bí kíp bỏ túi” để chuẩn chỉnh hồ sơ cá nhân của mình sau khi kết thúc sự kiện!\r\nĐặt hẹn cùng VNG Recruitment vào ngày 30/05 để được giải đáp từ A - Z về cách xây dựng và hoàn thiện hồ sơ cá nhân chuyên nghiệp cho bản thân, bạn nhé 😘!\r\n#VNG #VNGRecruitment #CareerTips #Webinar #ProfessionalProfile #Tech #Student #Fresher\r\nVisual: 2024 - Webinar - CV Tips.png", new DateTime(2024, 2, 2, 21, 51, 36, 520, DateTimeKind.Unspecified).AddTicks(9597), "https://forms.gle/HkCD86Gc9UmTTZLP9", false, true, null, null, "𝗭𝗼𝗼𝗺 𝗪𝗲𝗯𝗶𝗻𝗮𝗿 - đường link tham gia sẽ được gửi đến bạn qua email sau khi đăng ký thành công. ", 46, new DateTime(2023, 12, 24, 10, 50, 57, 639, DateTimeKind.Unspecified).AddTicks(5455), null, new DateTime(2024, 1, 31, 1, 3, 11, 711, DateTimeKind.Unspecified).AddTicks(7628), "[WEBINAR] XÂY DỰNG HỒ SƠ CÁ NHÂN CHUYÊN NGHIỆP CÙNG VNG 📝", 2, "Webinar", 4 },
                    { 19, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "❓ Bạn đam mê game và muốn góp phần tạo ra một sản phẩm game thật đỉnh?\r\n❓ Bạn muốn khám phá những cơ hội nghề nghiệp trong lĩnh vực này?\r\n❓ Nhưng bạn không biết bắt đầu từ đâu?\r\nThấu hiểu những nguyện vọng và mong mỏi khám phá của các bạn sinh viên về ngành công nghiệp game, UIT GamApp Studios hân hạnh tổ chức Seminar 'A step into the Game industry' với những diễn giả kỳ cựu đến từ Sky Mavis - studio đứng sau tựa game thành công Axie Infinity.\r\nĐến với 'A step into the Game industry', các bạn sẽ có được:\r\n👉 Góc nhìn thực tế về các vị trí trong một studio game.\r\n👉 Hiểu biết về cơ hội của ngành game tại Việt Nam.\r\n👉 Lời khuyên về study path và career path cho sinh viên muốn theo đuổi công việc trong lĩnh vực game.\r\n——————————————————\r\nTHÔNG TIN CHI TIẾT VỀ SEMINAR:\r\n⏰ Thời gian: 09h45, thứ 6 ngày 24/05/2024.\r\n📍 Địa điểm: Tầng 12, tòa nhà E trường Đại học Công nghệ Thông tin.\r\n🎤 Diễn giả:\r\n🌟 Mr. Hoan Nguyen - Director, Head of Axie Games at Sky Mavis.\r\n🌟 Mr. Phuong Nguyen - Game Engineering Lead at Sky Mavis.\r\n🌟 Mr. Anh Do - Talent Partner Lead at Sky Mavis.\r\n📌 Link đăng ký: https://tinyurl.com/a-step-into-the-game-industry\r\n⌛ Thời gian đăng ký: từ ngày 14/05/2024 đến 20h ngày 23/05/2024.\r\nSố lượng tham gia có hạn, đừng chần chờ gì nữa mà hãy nhanh tay đăng ký để tham gia chương trình, cùng khám phá thế giới game đầy thú vị và tiềm năng với CLB chúng mình nào!\r\n👐 Bật mí là sẽ có những phần quà hấp dẫn chờ đón các bạn ở buổi Seminar đó!\r\n——————————————————\r\nMọi thắc mắc liên hệ tại:\r\n💻 Fanpage: UIT GamApp Studios\r\n📩 Gmail: gamappuit.club@gmail.com", new DateTime(2023, 1, 26, 7, 28, 45, 72, DateTimeKind.Unspecified).AddTicks(9195), "https://forms.gle/HkCD86Gc9UmTTZLP9", false, true, null, null, "Tầng 12, tòa nhà E trường Đại học Công nghệ Thông tin", 83, new DateTime(2022, 12, 20, 23, 10, 27, 255, DateTimeKind.Unspecified).AddTicks(4309), null, new DateTime(2023, 1, 14, 3, 37, 24, 748, DateTimeKind.Unspecified).AddTicks(799), "🌟🌟 [UIT GAMAPP STUDIOS x SKY MAVIS] 🌟🌟 \r\n💫 SEMINAR “A STEP INTO THE GAME INDUSTRY”", 1, "Seminar", 4 },
                    { 20, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "⏰ Thời gian: 7h30 - 11h45 ngày 22/05/2023 (thứ tư)\r\n📍 Địa điểm:  VNG Campus - VNG sắp xếp xe đưa đón sinh viên tại trường.\r\n🙋‍♂️Đối tượng: Sinh viên khối ngành Công nghệ tại TP.HCM\r\nLink đăng ký tham gia: https://forms.gle/9EQU762MExUd6qJRA\r\n- Phương tiện di chuyển: Có xe đưa đón tại trường ĐH CNTT\r\n- Địa điểm tập trung (nếu đi xe của BTC): Cổng trường phía Nhân Văn, có mặt lúc 7h15 ngày 22/05/2024. Nếu di chuyển tự túc thì sinh viên có mặt tại địa điểm của công ty trước 8h30.\r\nLuôn đồng hành và mang đến những trải nghiệm thực tiễn nhất cùng sinh viên, VNG Tour sẽ là dịp gặp gỡ và kết nối cộng đồng sinh viên công nghệ. Ghi nhớ lịch ngay, hẹn gặp các bạn tại VNG Campus nhé!\r\n**Nếu có vấn đề gì thắc mắc cần giải đáp vui lòng liên hệ chaupbn@uit.edu.vn hoặc 093 8075826 (cô Bảo Châu)\r\nNhanh tay đăng kí nhé các bạn!", new DateTime(2024, 1, 19, 12, 21, 10, 534, DateTimeKind.Unspecified).AddTicks(5898), "https://forms.gle/HkCD86Gc9UmTTZLP9", false, false, null, null, "VNG Campus - VNG sắp xếp xe đưa đón sinh viên tại trường", 86, null, null, new DateTime(2023, 12, 29, 6, 11, 37, 784, DateTimeKind.Unspecified).AddTicks(3970), "[VNG TOUR] ĐĂNG KÍ THAM QUAN CÔNG TY VNG", 2, "Other", 4 },
                    { 21, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "📢THÔNG BÁO QUAN TRỌNG CHO CÁC THÍ SINH CUỘC THI THIẾT KẾ VI MẠCH 2024 📢 \r\n💝Với sự thành công của vòng sơ loại vừa qua, ban tổ chức vô cùng phấn khởi trước sự tham gia nhiệt tình của các bạn thí sinh trong và ngoài trường. Chúng tôi hy vọng niềm đam mê với lĩnh vực Thiết kế Vi mạch sẽ tiếp tục duy trì trong vòng thi ý tưởng sắp diễn ra. \r\n💡 Với chủ đề “THIẾT KẾ VI MẠCH CHO GIAO THÔNG THÔNG MINH”, ban tổ chức rất hy vọng được đón nhận những ý tưởng sáng tạo đầy tính táo bạo từ tất cả các bạn. Đừng ngần ngại chia sẻ những ý tưởng sáng tạo của nhóm các bạn vì biết đâu đó chính là ý tưởng tuyệt vời có thể giúp ích cho xã hội sau này.\r\n👉Link tải mẫu đơn đăng ký ý tưởng: https://docs.google.com/.../1w2M7y2tEdcMCYfMks2g6.../edit...\r\n✨Hãy chắc chắn ý tưởng của bạn đã nộp đúng hạn để ban tổ chức có thể tiến hành đánh giá và xem xét ý tưởng dự thi từ bạn:\r\n⏰Hạn cuối nộp ý tưởng: 30/06/2024\r\n🔗Link nộp ý tưởng: https://forms.gle/GUFbjr4a8PmGMYvf9\r\n❤️ Chúng tôi rất mong các bạn sẽ luôn tự tin với đam mê, sự yêu thích với lĩnh vực Thiết kế Vi mạch. Chúc các bạn may mắn và thành công trong các vòng thi tiếp theo!💕\r\n------------------------------------------------\r\nThông tin cuộc thi:\r\n⁉️Mọi thắc mắc liên hệ qua email: truongnh@uit.edu.vn (thầy Trường)\r\n🌐Website: https://fce.uit.edu.vn/cuoc-thi-thiet-ke-vi-mach-uit/\r\n#CE_UIT #TKVM_UIT", new DateTime(2023, 1, 11, 17, 13, 35, 996, DateTimeKind.Unspecified).AddTicks(2600), "https://forms.gle/HkCD86Gc9UmTTZLP9", false, true, null, null, "Online", 75, new DateTime(2022, 10, 14, 19, 1, 49, 632, DateTimeKind.Unspecified).AddTicks(3749), null, new DateTime(2022, 12, 12, 8, 45, 50, 820, DateTimeKind.Unspecified).AddTicks(7140), "🌟[CUỘC THI THIẾT KẾ VI MẠCH UIT 2024 |THÔNG BÁO NỘP Ý TƯỞNG VÒNG 2]🌟", 6, "Other", 5 },
                    { 22, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "👉Xin chào các bạn, chuỗi hoạt động Seminar của Khoa Kỹ thuật Máy tính đã quay trở lại rồi đây!\r\n😍Lần này CE sẽ đem đến cho các bạn Seminar “Giới thiệu Công ty XLINK và cơ hội nghề nghiệp” với sự tài trợ đến từ phía Công ty XLINK.\r\n🤔Đến với Seminar, các bạn sẽ được gặp gỡ:\r\n🍀 Dr. Michael Q. Le - President & CEO XLINK\r\n🍀 Mr. Vuong Hoang - Staff Analog Design Engineer\r\n🍀 Mr. Phu Vuong - Staff Digital Design Engineer\r\ncùng các nhân viên, kỹ sư đến từ XLINK để lắng nghe những kiến thức bổ ích và cơ hội nghề nghiệp đến từ Công ty.\r\n👇 Đăng ký tham gia ngay tại link phía dưới để không bỏ lỡ cơ hội quý báu này nhé!!!!\r\n🔗Link Đăng ký: https://forms.gle/XVWGaJBziZ31FdjJ9\r\n_________________________________\r\nTHÔNG TIN SEMINAR\r\nThời gian: 10h00, ngày 28/05/2024", new DateTime(2023, 12, 4, 15, 33, 34, 438, DateTimeKind.Unspecified).AddTicks(5465), "https://forms.gle/HkCD86Gc9UmTTZLP9", false, true, null, null, "Phòng B612, Tòa B, Trường ĐH CNTT", 31, new DateTime(2023, 10, 11, 16, 57, 30, 820, DateTimeKind.Unspecified).AddTicks(8470), null, new DateTime(2023, 11, 26, 11, 20, 3, 857, DateTimeKind.Unspecified).AddTicks(311), "🔥[SEMINAR GIỚI THIỆU CÔNG TY XLINK VÀ CƠ HỘI NGHỀ NGHIỆP]🔥", 5, "Seminar", 5 },
                    { 23, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "🔴Hiện nay, có nhiều bạn đang chuẩn bị thi TOEIC nhưng vẫn chưa thật sự sẵn sàng dù đã tự luyện đề thi ở nhà. Bên cạnh đó cũng có nhiều bạn muốn kiếm tra trình độ tiếng Anh của bản thân để tạo ra lộ trình học phù hợp trong khoảng thời gian sắp tới. Hiểu được sự băn khoăn và khó khăn của các bạn, tháng 6 này, Liên Chi Hội khoa Kỹ thuật Máy tính tổ chức Chương trình “Thi thử TOEIC”. \r\n🌸  Khi tham gia cuộc thi bạn có thể mang lại cho mình những quyền lợi như:\r\n✔️Tiếp xúc với đề thi chuẩn format mới, làm quen với không khí phòng thi, giúp bạn tự tin hơn với những cuộc thi học thuật tương tự, chuẩn bị sẵn tâm lý tốt khi bước vào kì thi TOEIC chính thức.\r\n✔️ Biết được trình độ tiếng Anh của bản thân mình, từ đó lập kế hoạch và mục tiêu phù hợp với bản thân.\r\n✔️ Các bạn tham gia thi thử sẽ nhận được Voucher trị giá 400.000 nghìn đồng khi đăng ký khóa học tại trung tâm kèm một phiếu thi thử năng lực tại trung tâm.\r\n✔️ Bạn sẽ được cấp tiêu chí 'Hội nhập tốt' trong 5 tiêu chí của ' Sinh viên 5 tốt'  khi bạn đạt được số điểm từ 450.\r\n⭐ ĐẶC BIỆT: Top 3 bạn có kết quả cao nhất trong kỳ thi sẽ nhận được phần quà từ Ban tổ chức và trung tâm đồng hành, cụ thể như sau:\r\n️🥇Giải nhất: 500.000 tiền mặt + Voucher giảm giá 25% khóa học tại trung tâm + Bình giữ nhiệt từ trung tâm\r\n️🥈Giải nhì: 300.000 tiền mặt + Voucher giảm giá 25% khóa học tại trung tâm + Bình giữ nhiệt từ trung tâm\r\n️🥉Giải ba: 200.000 tiền mặt + Voucher giảm giá 25% khóa học tại trung tâm + Bình giữ nhiệt từ trung tâm\r\n🔗Còn chần chờ gì mà không đăng ký ngay tại link: https://forms.gle/k31Qrjt9YMYA1WW29\r\n👉Thời gian đăng ký tham gia: Từ ngày 25/05/2024 - 05/06/2024.\r\nThông tin chương trình:\r\n⏰Thời gian: Thứ 7 ngày 08/06/2024.\r\n- Ca sáng: 8h – 10h30.\r\n- Ca chiều: 13h30 – 16h00.\r\nCác bạn có thể tham gia cả hai ca thi nhé.\r\n🏫Địa điểm: Tòa B – Trường Đại học Công nghệ Thông tin, ĐHQG-TP.HCM.\r\n👥 Đối tượng: Toàn bộ sinh viên trường Đại học Công nghệ thông tin - ĐHQGTPHCM.\r\n💵Lệ phí: 15.000 đồng/thí sinh/buổi thi.\r\nNếu bạn là học viên của Trung tâm Anh ngữ Tôi tự học, bạn sẽ được miễn phí tham gia.\r\n-------------------------------------------------------------------\r\n⁉️Mọi thắc mắc xin vui lòng liên hệ:\r\n- Fanpage: Khoa Kỹ Thuật Máy Tính - CE.UIT\r\n- Email: tuoitre.ktmt@gm.uit.edu.vn\r\n- Đ/c: Bùi Đăng Huy – Liên Chi hội trưởng khoa KTMT – Trưởng BTC - 0392211585\r\n- Đ/c: Đoàn Đăng Quang – Liên Chi hội phó LCH Khoa KTMT – Thành viên BTC", new DateTime(2022, 11, 26, 13, 23, 28, 531, DateTimeKind.Unspecified).AddTicks(6570), "https://forms.gle/HkCD86Gc9UmTTZLP9", false, false, null, null, "Tòa B – Trường Đại học Công nghệ Thông tin, ĐHQG-TP.HCM", 57, null, null, new DateTime(2022, 11, 9, 13, 54, 16, 893, DateTimeKind.Unspecified).AddTicks(3482), "‼️[THI THỬ TOEIC 2024 | CÔNG BỐ CHƯƠNG TRÌNH & MỞ ĐĂNG KÝ THAM GIA]‼️", 4, "Other", 5 },
                    { 24, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "🔴[GEN AI CHALLENGE 2024 | KHOA KỸ THUẬT MÁY TÍNH & BOSCH VIỆT NAM]🔴\r\n🚀Với xu thế phát triển của mảng AI&IoT trong lĩnh vực Automotives, BOSCH tổ chức cuộc thi GENAI CHALLENGE 2024 do GS. Dirk Slama và Bosch chủ trì.\r\n🪄Các bạn đang là sinh viên, các bạn có sự yêu thích với AI và IoT, GEN AI CHALLENGE sẽ là nơi các bạn có thể thoả sức trải nghiệm với đam mê của mình. Khi tham gia cuộc thi, các bạn sẽ được học hỏi thêm nhiều về AI cũng như IoT, được nhận sự hỗ trợ từ thầy cô và đặc biệt là từ phía Bosch Việt Nam. \r\n🤩Với niềm đam mê của bản thân và giải thưởng vô cùng lớn đang chờ đón, còn chần chừ gì nữa mà không nhanh tay đăng ký tham dự để thử sức mình nào các bạn ơi!\r\n‼️XEM THÊM THÔNG TIN VỀ CUỘC THI VÀ GIẢI THƯỞNG: https://www.digital.auto/genai-award\r\n🔗LINK ĐĂNG KÝ THAM GIA CUỘC THI  👉👉👉 https://forms.gle/mA7vi4529MHK3wP29\r\n---------------------------------------------\r\n#GENAICHALLENGE2024 #CE_UIT #BOSCHVIETNAM", new DateTime(2023, 11, 20, 7, 50, 52, 381, DateTimeKind.Unspecified).AddTicks(2708), "https://forms.gle/HkCD86Gc9UmTTZLP9", false, false, null, null, "Online", 75, null, null, new DateTime(2023, 10, 24, 16, 28, 29, 929, DateTimeKind.Unspecified).AddTicks(6652), "🔴[GEN AI CHALLENGE 2024 | KHOA KỸ THUẬT MÁY TÍNH & BOSCH VIỆT NAM]🔴", 1, "Other", 5 },
                    { 25, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "🔥[SEMINAR VI MẠCH CHUYÊN SÂU 2024 LẦN 2 - SYNOPSYS]🔥\r\n👉 Để có thể phát triển hợp tác giữa hai đơn vị và giúp sinh viên khoa nâng cao tư duy và kỹ năng nghề nghiệp theo định hướng Thiết kế Vi mạch, Khoa KTMT sẽ phối hợp với Synopsys tổ chức buổi Seminar nghề nghiệp Thiết kế vi mạch chuyên sâu lần 2 - năm 2024.\r\n🔥 Khi tham dự buổi Seminar, các bạn sẽ có cơ hội được lắng nghe những chia sẻ của những chuyên gia trong lĩnh vực công nghệ và tuyển dụng, đồng thời mở rộng hiểu biết về công ty, môi trường làm việc cũng như cơ hội việc làm trong tương lai đó nha!!!\r\n👇 Đăng ký tham gia ngay tại link phía dưới để không bỏ lỡ cơ hội quý báu này nhé!!!!\r\n_________________________________\r\nTHÔNG TIN SEMINAR\r\nThời gian: 9h30 - 11h, ngày 24/4/2024 (Thứ 4)\r\nDiễn giả: Chuyên gia công nghệ và tuyển dụng, Công ty Synopsys Việt Nam\r\nLink đăng ký: https://forms.gle/8Vnozz95vQCjtAAB7", new DateTime(2022, 10, 12, 12, 43, 17, 842, DateTimeKind.Unspecified).AddTicks(9412), "https://forms.gle/HkCD86Gc9UmTTZLP9", false, true, null, null, "Phòng C214, Tòa C, Trường ĐH CNTT", 59, new DateTime(2022, 9, 30, 10, 44, 34, 386, DateTimeKind.Unspecified).AddTicks(2630), null, new DateTime(2022, 10, 7, 19, 2, 42, 965, DateTimeKind.Unspecified).AddTicks(9823), "🔥[SEMINAR VI MẠCH CHUYÊN SÂU 2024 LẦN 2 - SYNOPSYS]🔥", 3, "Seminar", 5 },
                    { 26, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "📊 Trong thời đại số hóa và tăng trưởng dữ liệu nhanh chóng, nhu cầu xử lý và chọn lọc dữ liệu ngày càng tăng cao, Data Mart trở thành một “nhà kho thu nhỏ” chứa các tập dữ liệu đã được chọn lọc và xử lý trước. Data Mart giúp các doanh nghiệp phân tích và sử dụng thông tin một cách hiệu quả, từ đó đưa ra quyết định chiến lược và dự báo kinh doanh đáng tin cậy.\r\n🌀 Để hiểu hơn về Data Mart và ứng dụng của nó trong các lĩnh vực chuyên môn, khoa Khoa học và Kỹ thuật Thông tin sẽ mang đến cho bạn một buổi hội thảo với nhiều thông tin bổ ích và trải nghiệm thú vị, đầy hấp dẫn. \r\n💝 Đây sẽ là cơ hội tuyệt vời dành cho các bạn sinh viên yêu thích và quan tâm đến Khoa học Dữ liệu, vậy còn chần chờ gì mà không mau điền form đăng ký bên dưới đi nào!🔥\r\n___________________________________________\r\n📅 Thời gian: 13h30 – 16h30, Thứ tư, ngày 24/04/2024.  \r\n📍 Địa điểm: Hội trường E, Trường Đại học Công nghệ Thông tin - ĐHQG TP. HCM.  \r\n🎤 Diễn giả: Anh Lưu Minh Long, Senior Data Engineer and Data Analyst tại FPT Software.\r\n👉🏻👉🏻 Link đăng ký: https://bit.ly/DangKySeminar24-04\r\n___________________________________________\r\n🔰 KHOA KHOA HỌC VÀ KỸ THUẬT THÔNG TIN - UIT 🔰\r\n📍 Địa điểm: Tầng 10, tòa nhà E - trường Đại học Công nghệ Thông tin, ĐHQG-HCM.\r\n🌐 Website: https://fit.uit.edu.vn/\r\n📧 Email Đoàn - Hội ISE: bch.khkttt.uit@gmail.com\r\n#ISE2024\r\n#SEMINAR", new DateTime(2023, 10, 5, 6, 53, 10, 810, DateTimeKind.Unspecified).AddTicks(9885), "https://forms.gle/HkCD86Gc9UmTTZLP9", false, false, null, null, "Hội trường E, Trường Đại học Công nghệ Thông tin - ĐHQG TP. HCM", 28, null, null, new DateTime(2023, 9, 21, 21, 36, 56, 2, DateTimeKind.Unspecified).AddTicks(2994), "📝 [MỞ FORM ĐĂNG KÝ] SEMINAR 'Data Mart: Centralizing Business Data for Analytics and Forecasting' 📝", 6, "Seminar", 6 },
                    { 27, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "👉 Bạn muốn có cái nhìn thực tế và cận cảnh hơn về môi trường làm việc của doanh nghiệp?\r\n👉 Bạn muốn có cơ hội hiểu rõ mong muốn, yêu cầu của doanh nghiệp để có thể chủ động cải thiện năng lực bản thân?\r\n💘 Vậy thì còn chần chờ gì mà không tham gia ngay COMPANY TOUR 2024 - Tham quan doanh nghiệp FPT Software Hồ Chí Minh.\r\n🌏 Một chuyến đi giúp các bạn sinh viên tìm hiểu về môi trường, không gian làm việc chuyên nghiệp, và hiện đại của FPT Software Hồ Chí Minh, cung cấp và thực hiện dịch vụ an toàn thông tin trên lãnh thổ Việt Nam và các nước trong khu vực. Đến với FPT Software là đến với một môi trường làm việc trẻ trung, hiện đại, năng động và cực kỳ chuyên nghiệp.\r\n------------------------------------\r\nChi tiết về hành trình đến công ty FPT Software:\r\n👥 Đối tượng: Sinh viên khoa Khoa học và Kỹ thuật Thông tin, trường Đại học Công nghệ Thông tin, ĐHQG-HCM. Ưu tiên sinh viên năm 3, 4.\r\n🕐 Thời gian: 8g00p - 11g00p, thứ Năm ngày 04/04/2024.\r\n🏤 Địa điểm: Toà FTown 3, số 3 Đường Võ Chí Công, Phường Long Thạnh Mỹ, Khu Công nghệ cao, Thành phố Thủ Đức, TP. HCM.\r\n👕 Trang phục:\r\n👉 Sinh viên tham quan phải đeo thẻ Sinh viên và mặc đồng phục. (Trường hợp không có đồng phục trường, sinh viên mặc áo sơ mi trắng.)\r\n👉 Sinh viên nam mặc quần dài, không mặc quần ngắn trên đầu gối.\r\n⛔⛔⛔ CHÚ Ý:\r\n👉 Số lượng sinh viên có hạn: Chỉ 25 sinh viên, nên nếu bạn chắc chắn tham gia được thì hãy đăng ký nha.\r\n👉 Sinh viên tập trung tại trường và được xe đưa rước.\r\n👉 Sinh viên được hỗ trợ 100% kinh phí trong suốt hành trình tham quan.\r\n📝 📝 Hãy mau đăng ký ở link sau để trở thành một hành khách trong chuyến đi vô cùng bổ ích này nha: https://bit.ly/DangKy_CompanyTour2024_FPTSoftware \r\n------------------------------------\r\n🔰 KHOA KHOA HỌC VÀ KỸ THUẬT THÔNG TIN - UIT 🔰\r\n📍 Địa điểm: Tầng 10, tòa nhà E - trường Đại học Công nghệ Thông tin, ĐHQG-HCM.\r\n🌐 Website: https://fit.uit.edu.vn/\r\n📧 Email Đoàn - Hội ISE: bch.khkttt.uit@gmail.com\r\n👉 Fanpage Khoa Khoa học và Kỹ thuật Thông tin - UIT: https://www.facebook.com/UIT.ISE/\r\n#ISE2024\r\n#CompanyTour2024_FPTSoftware", new DateTime(2022, 9, 27, 4, 43, 4, 904, DateTimeKind.Unspecified).AddTicks(989), "https://forms.gle/HkCD86Gc9UmTTZLP9", false, false, null, null, "Toà FTown 3, số 3 Đường Võ Chí Công, Phường Long Thạnh Mỹ, Khu Công nghệ cao, Thành phố Thủ Đức, TP. HCM", 46, null, null, new DateTime(2022, 9, 5, 0, 11, 9, 38, DateTimeKind.Unspecified).AddTicks(6164), "🚎🚎 [COMPANY TOUR 2024 - FPT SOFTWARE] MỞ FORM ĐĂNG KÝ 🚎🚎", 3, "Other", 6 },
                    { 28, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "“𝑾𝒆 𝒕𝒉𝒊𝒏𝒌 𝒕𝒉𝒆 𝒔𝒖𝒏 𝒓𝒊𝒔𝒆𝒔 𝒂𝒏𝒅 𝒔𝒆𝒕𝒔 𝒐𝒏 𝒚𝒐𝒖 🌻”\r\n☀️ Như một hòa phối hoàn hảo được tạo ra bởi ánh sáng, ISE Camp 2024 là bức tranh sống động về 'Nắng' - nơi các câu chuyện về tuổi trẻ rực rỡ được kể, nơi để khám phá những trải nghiệm mới lạ và đầy hứng thú.\r\n💝 Lần đầu tiên xuất hiện với những điều được mong chờ nhất, ISE Camp 2024 là cơ hội để các bạn có thể có thêm được nhiều kiến thức, kinh nghiệm và cả trải nghiệm, cũng như tạo cơ hội để có thêm nhiều người bạn mới, học những điều hay và phát triển kỹ năng giao tiếp của bản thân mình. 💪\r\n️🎊 Vậy thì, còn chần chờ gì nữa, hãy tận hưởng tháng 3 đầy rực rỡ với 'Nắng - The Sound of Light' nhé!!! 🔥🔥\r\n🙋‍♀️ Cùng chúng mình thay những chiếc áo mới thật xinh xắn để đón chờ một chương trình hứa hẹn thật bùng nổ nhé!!!\r\n👉 Thay avatar: https://bit.ly/ISE_CAMP_2024_Avatar \r\n👉 Thay cover: https://bit.ly/ISE_CAMP_2024_Cover \r\n👉 Thay frame: https://bit.ly/ISE_CAMP_2024_Frame \r\n➖➖➖➖➖\r\n🌟 Nhanh tay đăng ký tham gia ngay thoiiii: https://bit.ly/ISE_CAMP_2024_MoFormDangKy \r\n     📲 Thông tin thanh toán trực tuyến (Momo, Internet Banking)\r\n     - Qua MOMO: 0948645540 - Bùi Yến Giàu\r\n     - Qua Ngân hàng: BIDV chi nhánh Đồng Khởi - 7290283486 - Bùi Yến Giàu\r\n     ✏ Nội dung: 𝑰𝑺𝑬 𝑪𝑨𝑴𝑷_< 𝑯𝒐 𝒕𝒆𝒏> _<𝑴𝑺𝑺𝑽>\r\n🌟Đăng ký trực tiếp: Tại bàn BTC đặt tại sảnh C, trường Đại học Công nghệ Thông tin, ĐHQG-HCM.\r\n     💵 Thông tin thanh toán trực tiếp: Thanh toán trực tiếp tại bàn đăng ký.\r\n📩 Mọi thắc mắc xin vui lòng phản hồi về FANPAGE Khoa Khoa học và Kỹ thuật Thông tin - UIT  hoặc đến trực tiếp bàn đăng ký tại sảnh C.\r\n📞 Hotline: 0964.850.620 (Lý Phi Lân - Trưởng BTC)", new DateTime(2023, 8, 21, 3, 20, 34, 227, DateTimeKind.Unspecified).AddTicks(9520), "https://forms.gle/HkCD86Gc9UmTTZLP9", false, true, null, null, "Khu Du lịch sinh thái Bò Cạp Vàng, Đồng Nai", 88, new DateTime(2023, 7, 22, 4, 31, 37, 951, DateTimeKind.Unspecified).AddTicks(6791), null, new DateTime(2023, 8, 20, 2, 45, 22, 74, DateTimeKind.Unspecified).AddTicks(9335), "[𝐈𝐒𝐄 𝐂𝐀𝐌𝐏 𝟐𝟎𝟐𝟒] ✨ Nắng - The Sound of Light ✨", 1, "Other", 6 },
                    { 29, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "📧 Nhằm truyền cảm hứng đam mê nghiên cứu đến với các bạn sinh viên, Khoa Khoa học và Kỹ thuật Thông tin kính chuyển đến các bạn sinh viên thư mời tham dự buổi Seminar Sinh viên và Nghiên cứu khoa học năm 2024.\r\n📝 Tại đây, các bạn sẽ được các cựu sinh viên và các bạn sinh viên Khoa Khoa học và Kỹ thuật Thông tin chia sẻ quá trình tham gia nghiên cứu và công bố khoa học trong suốt quãng thời gian học tập tại UIT.\r\nThông tin cụ thể:\r\n👥 Đối tượng: Sinh viên đang học tập tại Trường Đại học Công nghệ Thông tin, ĐHQG-HCM.\r\n🕗 Thời gian: 08h30 - 11h00 ngày 30/01/2024.\r\n#ISE2024 #SEMINAR", new DateTime(2022, 8, 13, 8, 12, 59, 689, DateTimeKind.Unspecified).AddTicks(6223), "https://forms.gle/HkCD86Gc9UmTTZLP9", false, true, null, null, "Online qua Google Meet: https://meet.google.com/fkb-qrpb-dbe", 44, new DateTime(2022, 7, 18, 2, 27, 19, 140, DateTimeKind.Unspecified).AddTicks(1511), null, new DateTime(2022, 8, 3, 5, 19, 35, 111, DateTimeKind.Unspecified).AddTicks(2506), "🔰 SEMINAR: SINH VIÊN VÀ NGHIÊN CỨU KHOA HỌC NĂM 2024", 6, "Seminar", 6 },
                    { 30, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Kính mời Quý Thầy/Cô và các bạn sinh viên tham dự chương trình Seminar với những chia sẻ đến từ Giáo Sư Okumura cùng với các bạn sinh viên đến từ Đại học Saga Nhật Bản. \r\n⏰Thời gian: 8h30 - 11h00, Thứ Ba ngày 23/01/2024.\r\n✍️ Nội dung: Giới thiệu các chương trình đào tạo mới tại Đại học Saga; các hướng nghiên cứu của GS. Okumura và các sinh viên. \r\n🔗 Link đăng ký: https://forms.gle/izY1349MqVDw6ZmZ9\r\n#KHKTTT", new DateTime(2023, 8, 6, 13, 5, 25, 151, DateTimeKind.Unspecified).AddTicks(2925), "https://forms.gle/HkCD86Gc9UmTTZLP9", false, false, null, null, "Hội trường E", 97, null, null, new DateTime(2023, 7, 18, 7, 53, 48, 147, DateTimeKind.Unspecified).AddTicks(5676), "🛎 Seminar của GS. Okumura (Đại học Saga, Nhật Bản) 🛎", 5, "Seminar", 6 },
                    { 31, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), " 🎉Kính mời Quý Thầy Cô tham dự buổi Seminar với chủ đề 'Wireless Brain-Inspired Computing (WiBIC).' \r\n 💥Wireless Brain-Inspired Computing (WiBIC) - một lĩnh vực nghiên cứu mới đầy tiềm năng, kết hợp các nguyên tắc tính toán lấy cảm hứng từ não bộ cùng công nghệ không dây tiên tiến. Lĩnh vực này hứa hẹn sẽ mang đến những đột phá trong cách chúng ta thiết kế và sử dụng các hệ thống máy tính, mang lại khả năng xử lý thông tin hiệu quả, linh hoạt và thích ứng hơn.\r\n 🌟Seminar 'Wireless Brain-Inspired Computing (WiBIC)' với sự tham gia của Giáo sư Hiroo Sekiya đến từ Đại học Chiba, Nhật Bản sẽ là cơ hội tuyệt vời để tìm hiểu thêm về lĩnh vực nghiên cứu mới mẻ và đầy tiềm năng này.\r\n---------- \r\n ✨️THÔNG TIN BUỔI SEMINAR✨️  \r\n📄Chủ đề: Wireless Brain-Inspired Computing (WiBIC)\r\n----------  \r\nMọi thắc mắc xin vui lòng liên hệ:  \r\n🌐Fanpage: Khoa Khoa học Máy tính UIT\r\n#CS_UIT", new DateTime(2022, 7, 29, 17, 57, 50, 612, DateTimeKind.Unspecified).AddTicks(9629), "https://forms.gle/HkCD86Gc9UmTTZLP9", false, true, null, null, "Phòng E1.1, tòa E, Trường Đại học Công nghệ Thông tin - ĐHQGHCM ", 36, new DateTime(2022, 5, 11, 22, 18, 41, 517, DateTimeKind.Unspecified).AddTicks(951), null, new DateTime(2022, 7, 1, 10, 28, 1, 183, DateTimeKind.Unspecified).AddTicks(8847), "[SEMINAR] Khám phá Wireless Brain-Inspired Computing (WiBIC)", 4, "Seminar", 7 },
                    { 32, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "THÔNG TIN CHI TIẾT BUỔI SEMINAR:\r\n✏️Chủ đề: Khởi nghiệp sinh viên IT: Cơ hội và Thách thức\r\n🎤Diễn giả: Nguyễn Ngọc Tú - CEO của TVT Group\r\n⏰Thời gian: Thứ 3 ngày 28/05/2024\r\n📌Địa điểm: Hội trường E, Trường Đại học Công nghệ Thông tin ĐHQG - HCM\r\n💡Link form đăng kí: https://forms.gle/PtVfbFnucFrPKsy49\r\n------------------------------\r\n❓Bạn đang có nhiều thắc mắc về định hướng tương lai của bản thân?\r\n❓Bạn hoài nghi và sợ sệt khi phải đưa ra những quyết định ảnh hưởng trên con đường khởi nghiệp của mình?\r\n❓Hay bạn chỉ đơn giản là muốn nghe những chia sẻ từ cựu sinh viên đã khởi nghiệp thành công?\r\n🔥Khoa rất hân hạnh được giới thiệu với các bạn diễn giả của buổi seminar, anh Nguyễn Ngọc Tú - là cựu sinh viên khóa 1 chương trình tài năng khoa Khoa học Máy tính, cũng là CEO của TVT Group.\r\n🔎TVT GROUP là một tập đoàn công nghệ với hơn 11 năm kinh nghiệm trong nền công nghiệp IT về lĩnh vực nghiên cứu và phát triển các ứng dụng & hệ thống phần mềm. Bắt tay hợp tác với nhiều đối tác tại nhiều nước trên thế giới ở nhiều lĩnh vực như: Mobile Application, Window software, Web Development & IoT Software,... TVT Group đã đạt được những thành công nhất định trong nền công nghiệp này.🔍\r\n------------------------------\r\nMọi thông tin thắc mắc vui lòng liên hệ:\r\nFanpage: Khoa Khoa học Máy tính UIT\r\n#CS_UIT", new DateTime(2023, 6, 21, 17, 52, 35, 369, DateTimeKind.Unspecified).AddTicks(6515), "https://forms.gle/HkCD86Gc9UmTTZLP9", false, true, null, null, "Hội trường E, Trường Đại học Công nghệ Thông tin ĐHQG - HCM", 72, new DateTime(2023, 5, 8, 20, 14, 22, 705, DateTimeKind.Unspecified).AddTicks(5672), null, new DateTime(2023, 6, 15, 13, 2, 14, 220, DateTimeKind.Unspecified).AddTicks(2018), "[SEMINAR | Khởi nghiệp sinh viên IT: Cơ hội và Thách thức]", 4, "Seminar", 7 },
                    { 33, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "📩 Để tạo điều kiện cho Ban giám hiệu Nhà trường và Ban chủ nhiệm khoa có thể hiểu được suy nghĩ, những khó khăn và vướng mắc mà sinh viên gặp phải trong quá trình học tập và rèn luyện, ban chủ nhiệm Khoa và Nhà trường sẽ tổ chức Hội nghị Sinh viên của khoa Khoa học Máy tính nhằm kết nối và có những góc nhìn gần gũi hơn đến với các vấn đề của các bạn sinh viên. \r\n📩 BTC và xin gửi thông tin đến tất cả các bạn sinh viên. \r\n——————————————— \r\n📌 Thời gian: 9h30 ngày 07/05/2024  \r\n📌 Địa điểm: Hội trường E, trường ĐH CNTT \r\n📌 Thành phần tham dự: \r\n   📮 Đại diện Ban giám hiệu Nhà trường \r\n   📮 Ban chủ nhiệm khoa Khoa học Máy tính \r\n   📮 Đại diện Lãnh đạo và chuyên viên Phòng CTSV \r\n   📮 Đại diện Lãnh đạo Phòng Đào tạo Đại học; Văn phòng Các Chương trình Đặc biệt; Trung tâm ngoại ngữ \r\n   📮 Toàn thể quý Thầy Cô Cố vấn học tập của Khoa Khoa học Máy tính \r\n   📮 Cùng toàn thể sinh viên của khoa Khoa học Máy tính UIT \r\n——————————————— \r\n🎁 Đây là chương trình dành riêng cho toàn thể sinh viên khoa Khoa học Máy tính. Đến với Hội nghị, các bạn sinh viên có thể: \r\n📍 Trao đổi những thuận lợi, khó khăn trong học tập, sinh hoạt cũng như thắc mắc của sinh viên về công tác đào tạo, công tác hỗ trợ CVHT, cơ sở vật chất,.... \r\n📍 Tiếp nhận những ý kiến đóng góp và đề xuất cho sự phát triển Nhà trường. \r\n🌈 Thật tuyệt vời đúng không nào! Vậy thì còn ngại ngần gì nữa mà các bạn sinh viên khoa Khoa học Máy tính không chuẩn bị những câu hỏi thật hay và sẵn sàng cho một buổi Hội nghị thật năng suất!! \r\n🌟 Hẹn gặp tất cả các bạn sinh viên trong buổi Hội nghị ♥️ \r\n——————————————— \r\nMọi thắc mắc xin liên hệ: \r\n🌎 Fanpage: Khoa Khoa học Máy tính UIT \r\n#CS_UIT", new DateTime(2022, 6, 14, 3, 42, 41, 536, DateTimeKind.Unspecified).AddTicks(3034), "https://forms.gle/HkCD86Gc9UmTTZLP9", false, false, null, null, "Hội trường E, trường ĐH CNTT", 68, null, null, new DateTime(2022, 5, 29, 15, 36, 27, 256, DateTimeKind.Unspecified).AddTicks(5188), "[HỘI NGHỊ SINH VIÊN KHOA KHOA HỌC MÁY TÍNH 2024] ", 1, "Seminar", 7 },
                    { 34, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Buổi nói chuyện thuộc Chương trình Site Visit, do Trường Đại học Công nghệ Thông tin phối hợp với Trường Đại học Bách Khoa và Đại học Khoa học Tự nhiên tổ chức. Đây là hoạt động nằm trong khuôn khổ Hội thảo AI Connect II do Bộ Khoa học và Công nghệ phối hợp với Bộ Ngoại giao Hoa Kỳ thông qua Tổ chức phi chính phủ Atlantic Council (Hoa Kỳ) tổ chức.\r\nNội dung của Buổi nói chuyện: 'Giới thiệu về đào tạo và nghiên cứu về AI tại ĐHQG-HCM và Xu hướng nguồn nhân lực AI'\r\n - Thời gian: 9:30 – 12:00, Thứ Ba, ngày 23/4/2024.\r\n- Địa điểm: Hội trường A, Trường Đại học Công nghệ Thông tin (Phường Linh Trung, TP. Thủ Đức, TP.HCM)\r\n- Link đăng ký: https://link.uit.edu.vn/AIConnect\r\n- Buổi nói chuyện được chia làm 2 phần:\r\nPhần 1: Giới thiệu về đào tạo và nghiên cứu về AI tại ĐHQG-HCM\r\nDiễn giả:\r\n1. TS. Lê Thành Sách – Trường Đại học Bách Khoa;\r\n2. TS. Lê Khánh Duy – Trường Đại học Khoa học Tự Nhiên;\r\n3. TS. Ngô Đức Thành – Trường Đại học Công nghệ Thông tin.\r\nPhần 2: Xu hướng nguồn nhân lực AI\r\nDiễn giả khách mời: Ông John Powell Adrian De Guzman - Trade Industry Development Specialist from National Government of the Philippines.", new DateTime(2023, 6, 7, 8, 35, 6, 997, DateTimeKind.Unspecified).AddTicks(9737), "https://forms.gle/HkCD86Gc9UmTTZLP9", false, false, null, null, "Hội trường A, Trường Đại học Công nghệ Thông tin", 86, null, null, new DateTime(2023, 5, 13, 18, 10, 40, 292, DateTimeKind.Unspecified).AddTicks(8359), "🔴 HỘI THẢO AI CONNECT chủ đề 'Giới thiệu về đào tạo và nghiên cứu về AI tại ĐHQG-HCM và Xu hướng nguồn nhân lực AI'", 4, "Conference", 7 },
                    { 35, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "THÔNG TIN CHI TIẾT BUỔI SEMINAR: \r\n ✏️Chủ đề: Hybrid Minds: Radically Reimagining the Future of Intelligence \r\n🎤Diễn giả: Dr. Olaf Witkowski\r\n⏰Thời gian: 10h, Thứ 3 ngày 05/03/2024 \r\n📍Địa điểm: phòng E1.1, Tòa E, Trường Đại học Công nghệ Thông tin ĐHQG-HCM \r\n🔑 Đối tượng tham gia: giảng viên và sinh viên \r\nLink form đăng kí: https://docs.google.com/.../1FAIpQLSdzbu2G.../viewform\r\nAbstract about seminar 👇\r\n⭐️ Intelligence isn’t just about acing exams, excelling at chess, or memorizing many books. It’s broader and may evolve in many different ways. In this talk, we will explore intelligence in a larger perspective, not just in humans but more generally in biology, AI, and other, possibly hybrid forms of life. \r\n🥸 We will discuss how two agents living in different substrates, such as humans, cells, or digital agents, may interact in a meaningful way. This perspective suggests thinking of diverse agents, including technological ones, not merely as tools for humans to use and offload computation to, but as true partners together with whom humans can increase their perception and cognition. This perspective invites a future where diverse minds unify to expand their understanding of reality.\r\nBio of Dr. Olaf Witkowski 👇\r\n👨‍🎓Olaf Witkowski is a leading expert in empathic AI and Artificial Life based in Kyoto, Japan. \r\n🧑‍🏫He is the Founding Director of Cross Labs, a research institute in Japan, focusing on the study of intelligence in biological and synthetic systems. \r\n🤵‍♂️He is the President of the Board of Directors of the International Society for Artificial Life, Executive Officer at leading AI company Cross Compass, and Lecturer at the University of Tokyo. \r\n🌎He has co-founded multiple ventures in science and technology on three continents, including YHouse Inc. (nonprofit institute on the emergence of consciousness in the universe) and the Center for the Study of Apparent Selves (focusing on the Self in Buddhism and AI). \r\n📰His research focuses a mathematical understanding of intelligence in any substrate, which he uses to design hybrid living systems, empathic human-machine interfaces, open-ended paradigms for collective computing, and theories of connected minds\r\n______________________ \r\nMọi thông tin thắc mắc vui lòng liên hệ: \r\n🌎 Fanpage: Khoa Khoa học Máy tính UIT ", new DateTime(2024, 4, 29, 11, 22, 17, 648, DateTimeKind.Unspecified).AddTicks(9830), "https://forms.gle/HkCD86Gc9UmTTZLP9", false, true, null, null, "phòng E1.1, Tòa E, Trường Đại học Công nghệ Thông tin ĐHQG-HCM", 20, new DateTime(2024, 2, 28, 13, 20, 9, 721, DateTimeKind.Unspecified).AddTicks(9527), null, new DateTime(2024, 4, 26, 20, 44, 53, 329, DateTimeKind.Unspecified).AddTicks(1530), "[SEMINAR | Hybrid Minds: Radically Reimagining the Future of Intelligence] ", 1, "Seminar", 7 },
                    { 36, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "🔗 Link đăng ký: https://forms.gle/sE7Ws6MjsAnvm8BH6\r\n☀️ Nhằm chào mừng ngày lễ Giỗ Quốc tổ Hùng Vương (10/03 âm lịch), Ban Quản Lý Công viên Lịch sử Văn hóa Dân tộc chính thức tổ chức Hội trại truyền thống 'Tự hào nòi giống Tiên Rồng' lần thứ XV - 2024. Đồng thời, hội trại còn được diễn ra với mong muốn nâng cao nhận thức về truyền thống lịch sử dân tộc và bồi dưỡng lòng yêu nước, niềm tự hào về cội nguồn “nòi giống Tiên Rồng” trong lực lượng đoàn viên, thanh niên thành phố.\r\n🌼 BTC mong rằng sẽ tạo được cho các bạn một sân chơi bổ ích, lành mạnh để rèn luyện kỹ năng sống, kỹ năng làm việc tập thể cũng như giao lưu học hỏi kinh nghiệm giữa các đơn vị tham gia hội trại.\r\n———————————————\r\nTHÔNG TIN CHƯƠNG TRÌNH\r\n👧 Số lượng: 30 \r\n👨‍🎓 Đối tượng tham gia: Sinh viên UIT.\r\n🔗 Link đăng ký: https://forms.gle/sE7Ws6MjsAnvm8BH6\r\n💵 Chi phí: 160.000đ bao gồm tiền áo đồng phục cho tiểu trại UIT và chi phí ăn uống buổi tối (hoạt động nướng thịt).\r\n⏰ Thời gian: Từ 05h30 ngày 18/04/2023 đến 10h00 ngày 19/04/2023.\r\n#CTXH_UIT\r\n#NOIGIONGTIENRONG2024", new DateTime(2023, 4, 22, 9, 12, 11, 742, DateTimeKind.Unspecified).AddTicks(935), "https://forms.gle/HkCD86Gc9UmTTZLP9", false, false, null, null, "Khu hội trại mới (Sân bãi bắn pháo hoa) - Đền Tưởng niệm các Vua Hùng thuộc Công viên Lịch sử - Văn hóa Dân tộc (KP. Vĩnh Thuận, P. Long Bình, TP. Thủ Đức).", 39, null, null, new DateTime(2023, 4, 10, 23, 19, 6, 365, DateTimeKind.Unspecified).AddTicks(4700), "[TRẠI NÒI GIỐNG TIÊN RỒNG 2024 | FORM ĐĂNG KÝ]", 3, "Other", 8 },
                    { 37, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "⚽️ Link đăng ký: https://forms.gle/EhKu7dQDZRxSDoSB7\r\n🔔 Cuối cùng thì ngày này cũng đã tới. Ta đã đợi cái ngày này lâu lắm rồi. Xin chào các bạn nhỏ tại CTXH CUP của taaa...\r\n🏅 Với mục đích giao lưu, học hỏi và rèn luyện thể lực, giải bóng đá CTXH Cup 2.0 đã trở lại và chính thức mở form đăng ký từ ngày hôm nay. Các bạn trong Đội ai có đam mê thì hãy nhanh tay đăng ký ngay nhé!\r\n🦵 Trước khi giải đấu bắt đầu, các bạn hãy đảm bảo duy trì sức khỏe thật tốt nha. Bên cạnh đó, cũng không quên luyện tập để sẵn sàng cho những trận đấu sắp tới với tinh thần fair-play nhé!\r\n____________________________\r\nTHÔNG TIN GIẢI ĐẤU\r\n⚽️ Link đăng ký: https://forms.gle/EhKu7dQDZRxSDoSB7\r\n⌚ Thời gian thi đấu: 17h00 - 19h00 ngày 26, 28 và 30/03/2024 (Thứ 3, 5, 7)\r\n🥅 Nơi thi đấu: Sân bóng đá KTX Liên hợp (sau KTX khu A)\r\n💵 Lệ phí: 60k/người\r\n👯 Đối tượng tham gia: CTV, TV và cựu Đội viên của Đội CTXH UIT\r\nCƠ CẤU GIẢI THƯỞNG\r\n🏆 Quán quân: Cúp + Huy chương\r\n🎖️ Á quân: Huy chương\r\n📢 Đặc biệt: Tham gia thi đấu được cộng điểm rèn luyện và có cơ hội được công nhận tiêu chí 'Thể lực tốt' để xét danh hiệu 'Sinh viên 5 Tốt'.\r\n☎️ SĐT: 0795 499 579 (Trương Vĩnh Tiến - Nắm chính)\r\n____________________________\r\nMọi thắc mắc xin liên hệ Đội qua:\r\n📌 Fanpage: Đội Công Tác Xã Hội Trường ĐH Công Nghệ Thông Tin\r\n✉️ Gmail: doictxh.uit@gmail.com\r\n☎️ Hotline: 0941 712 574 (Phạm Thị Trâm Anh)\r\n#CTXH_UIT\r\n#CTXH_CUP", new DateTime(2024, 4, 14, 23, 12, 23, 382, DateTimeKind.Unspecified).AddTicks(9846), "https://forms.gle/HkCD86Gc9UmTTZLP9", false, false, null, null, "Sân bóng đá KTX Liên hợp (sau KTX khu A)", 56, null, null, new DateTime(2024, 3, 25, 1, 53, 19, 401, DateTimeKind.Unspecified).AddTicks(7871), "[ĐỘI - CTXH CUP 2.0]", 6, "Other", 8 },
                    { 38, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), " Link Form: https://forms.gle/awZAbPCswJEUqwo68\r\n Link Template: http://bit.ly/4bkHviH\r\n🧨 “Ô kìa! Như Tết đến đây rồi! \r\nBánh chưng, bánh tét, lại gà, lại xôi... \r\nKhói bếp, trầm hương nghe ấm lạ! \r\nBi bô tiếng trẻ rộn sân đời…” \r\n💌 Hòa chung không khí rộn ràng của những ngày đất trời chuyển vần chào đón Tết Giáp Thìn 2024, Đội CTXH UIT xin gửi đến toàn thể mọi người lời chúc sức khỏe, hạnh phúc và gặp nhiều may mắn, tài lộc, vạn sự như ý.\r\n✨ Đặc biệt, hãy cùng Đội khắc nên sắc xuân với chuỗi hoạt động “Giáp Thìn Challenge” với 3 hoạt động vô cùng thú vị sẽ lần lượt được bật mí sau mỗi 2 ngày, từ mùng 1 đến mùng 6. \r\n💐 Ngay bây giờ, chúng ta sẽ khởi động với challenge đầu tiên nhé! Mùng một bừng hứng khởi với “Cây mai ước mơ” - nơi các bạn có thể gửi gắm những ước muốn, mục tiêu của mình trong năm mới. Hãy nhanh chóng tải về và chia sẻ cảm xúc đầu năm mới cùng chúng mình nào!\r\n_____________________________________\r\nCÁCH THỨC THAM GIA:\r\n1️⃣ Like page và share bài viết ở chế độ công khai kèm hashtag: \r\n#CTXH_UIT\r\n#GiapThinChallenge\r\n2️⃣ Viết ước muốn của bản thân (có thể đính kèm lời chia sẻ, một bài hát, những bức ảnh,...) vào template và đăng lên story ở chế độ công khai. \r\n3️⃣ Điền thông tin vào form minh chứng với ảnh story và hoàn thành đầy đủ 3 challenge để nhận ngay điểm rèn luyện!\r\n Link Form: https://forms.gle/awZAbPCswJEUqwo68\r\n Link Template: http://bit.ly/4bkHviH\r\n_____________________________________\r\nMọi thắc mắc xin liên hệ Đội qua:\r\n📌 Fanpage: Đội Công Tác Xã Hội Trường ĐH Công Nghệ Thông Tin\r\n✉️ Gmail: doictxh.uit@gmail.com\r\n☎️ Hotline: 0941 712 574 (Phạm Thị Trâm Anh)\r\n#CTXH_UIT\r\n#GiapThinChallenge", new DateTime(2023, 4, 8, 4, 4, 48, 844, DateTimeKind.Unspecified).AddTicks(6549), "https://forms.gle/HkCD86Gc9UmTTZLP9", false, true, null, null, "Online", 49, new DateTime(2023, 2, 16, 23, 41, 47, 923, DateTimeKind.Unspecified).AddTicks(1228), null, new DateTime(2023, 3, 9, 4, 27, 32, 438, DateTimeKind.Unspecified).AddTicks(1042), "[GIÁP THÌN CHALLENGE | HOẠT ĐỘNG 1 - CÂY MAI ƯỚC MƠ]", 5, "Other", 8 },
                    { 39, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "🔗 Link form: https://forms.gle/qHbcaD9F3U4g91bk9\r\n💨 Vèooo! Mới đó mà đã Mùng 3 rồi, hai ngày qua chúng mình rất vui khi nhìn thấy Cây Mai Ước Mơ được các bạn trang trí lên bởi những ước muốn, mục tiêu thật tuyệt vời. Đội CTXH chúc mọi người sớm đạt được những điều mà mình đã gửi gắm trên Cây Mai Ước Mơ nhé. \r\n🧧 Tiếp nối chuỗi Giáp Thìn Challenge, Đội mang đến cho các bạn một bộ câu hỏi trong template Get to know me - Lunar new()  Year Version. Chúng mình tin rằng, qua template xinh xắn này, các bạn sẽ có dịp chia sẻ với bạn bè những câu chuyện thú vị đó. Khi tham gia và thực hiện đầy đủ thể lệ, các bạn chắc chắn sẽ nhận được Điểm rèn luyện. Vậy nên, hãy share để hiểu nhau hơn và nhận ĐRL cùng chúng mình nàooo!\r\n——————————————\r\nCÁCH THỨC THAM GIA:\r\n1️⃣ Like và Follow Fanpage Đội Công Tác Xã Hội Trường ĐH Công Nghệ Thông Tin\r\n2️⃣ Thả cảm xúc và chia sẻ template lên trang cá nhân ở chế độ công khai kèm hashtag:\r\n#CTXH_UIT\r\n#GiapThinChallenge\r\n3️⃣ Điền vào form minh chứng: https://forms.gle/qHbcaD9F3U4g91bk9\r\n——————————————\r\nMọi thắc mắc xin liên hệ Đội qua:\r\n📌 Fanpage: Đội Công Tác Xã Hội Trường ĐH Công Nghệ Thông Tin\r\n✉️ Gmail: doictxh.uit@gmail.com\r\n☎️ Hotline: 0941 712 574 (Phạm Thị Trâm Anh)\r\n#CTXH_UIT\r\n#GiapThinChallenge", new DateTime(2024, 2, 28, 20, 26, 33, 736, DateTimeKind.Unspecified).AddTicks(5248), "https://forms.gle/HkCD86Gc9UmTTZLP9", false, true, null, null, "Online", 85, new DateTime(2024, 2, 13, 2, 54, 53, 450, DateTimeKind.Unspecified).AddTicks(7120), null, new DateTime(2024, 2, 21, 7, 1, 45, 474, DateTimeKind.Unspecified).AddTicks(4212), "[GIÁP THÌN CHALLENGE | HOẠT ĐỘNG 2: GET TO KNOW ME]", 4, "Other", 8 },
                    { 40, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "🔗 Link đăng ký: https://forms.gle/mJ3XkicR7qFn7k639\r\n🧣 Mỗi một mùa đông đến, người dân tại vùng đất Đắk Mil, tỉnh Đắk Nông đầy khó khăn lại phải tìm cách ứng phó với những cơn giá rét này. Những đôi chân run rẩy của các em nhỏ từng bước đến trường, những đôi bàn tay lạnh toát của các cụ già cùng tấm áo mong manh. Một hình ảnh mùa đông với những chiếc áo ấm cùng bếp than hồng có lẽ quá đỗi xa xỉ với người dân nơi đây.\r\n⛄ Với Chiến dịch “Mùa Đông yêu thương 2023”, các chiến sĩ sẽ có cơ hội trao gửi yêu thương, mang lại một mùa đông ấm áp hơn đến với con người Đắk Mil phúc hậu, đặc biệt là các bạn nhỏ xinh xắn và đáng yêu nữa. Tất thảy vì một mục đích truyền thêm động lực và niềm tin để họ có thể vượt qua được những khó khăn giữa thời tiết lạnh lẽo này.\r\n🙆‍♂️ Một bông hoa không thể làm nên mùa xuân, cũng như chỉ một người thì không thể làm nên “Mùa Đông yêu thương” được. Cho nên hãy trở thành một chiến sĩ Mùa Đông yêu thương 2023 bằng cách “giơ tay xung phong”, đăng ký qua link phía dưới nhé!\r\n_________________________\r\nTHÔNG TIN TUYỂN CHIẾN SĨ:\r\n🔗 Link đăng ký: https://forms.gle/mJ3XkicR7qFn7k639\r\n🕛 Thời gian đăng ký: 04/12/2023 - 19/12/2023.\r\n🙍 Đối tượng đăng ký chiến sĩ: Sinh viên địa bàn Thành phố Hồ Chí Minh.\r\n🚨 LƯU Ý:\r\n⚠️ Những trường hợp có đóng góp cho Chiến dịch 'Mùa Đông yêu thương 2023' (hoạt động gây quỹ,...) nhưng không điền form coi như là không tham gia.\r\n⚠️ Đăng ký và gây quỹ đủ chỉ tiêu mới có thể trở thành “Chiến sĩ” chính thức.\r\n_________________________\r\nTHÔNG TIN CHIẾN DỊCH:\r\n🕛 Thời gian: Ngày 08/09/2023 - 31/12/2023.\r\n📍 Địa điểm: Xã Thuận An, Huyện Đắk Mil, Tỉnh Đắk Nông.\r\n🎬 Phóng sự Mùa Đông yêu thương 2023: https://tinyurl.com/MDYT2023-PhongSu\r\n⛄️ Frame: twb.nz/mydt2023\r\n_________________________\r\nMọi thắc mắc xin liên hệ Đội qua:\r\n📌 Fanpage: Đội Công Tác Xã Hội Trường ĐH Công Nghệ Thông Tin\r\n✉️ Gmail: doictxh.uit@gmail.com\r\n☎️ Hotline: 0941 712 574 (Phạm Thị Trâm Anh)\r\n#CHIENDICHTINHNGUYEN\r\n#MĐYT2023\r\n#CTXH_UIT", new DateTime(2023, 2, 19, 21, 56, 4, 807, DateTimeKind.Unspecified).AddTicks(6157), "https://forms.gle/HkCD86Gc9UmTTZLP9", false, false, null, null, "Xã Thuận An, Huyện Đắk Mil, Tỉnh Đắk Nông", 27, null, null, new DateTime(2023, 2, 4, 9, 35, 58, 510, DateTimeKind.Unspecified).AddTicks(7383), "[CHIẾN DỊCH TÌNH NGUYỆN MÙA ĐÔNG YÊU THƯƠNG 2023 | TUYỂN CHIẾN SĨ]", 2, "Other", 8 },
                    { 41, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Buổi nói chuyện thuộc Chương trình Site Visit, do Trường Đại học Công nghệ Thông tin phối hợp với Trường Đại học Bách Khoa và Đại học Khoa học Tự nhiên tổ chức. Đây là hoạt động nằm trong khuôn khổ Hội thảo AI Connect II do Bộ Khoa học và Công nghệ phối hợp với Bộ Ngoại giao Hoa Kỳ thông qua Tổ chức phi chính phủ Atlantic Council (Hoa Kỳ) tổ chức.\r\nNội dung của Buổi nói chuyện: 'Giới thiệu về đào tạo và nghiên cứu về AI tại ĐHQG-HCM và Xu hướng nguồn nhân lực AI'\r\n - Thời gian: 9:30 – 12:00, Thứ Ba, ngày 23/4/2024.\r\n- Địa điểm: Hội trường A, Trường Đại học Công nghệ Thông tin (Phường Linh Trung, TP. Thủ Đức, TP.HCM)\r\n- Link đăng ký: https://link.uit.edu.vn/AIConnect\r\n- Buổi nói chuyện được chia làm 2 phần:\r\nPhần 1: Giới thiệu về đào tạo và nghiên cứu về AI tại ĐHQG-HCM\r\nDiễn giả:\r\n1. TS. Lê Thành Sách – Trường Đại học Bách Khoa;\r\n2. TS. Lê Khánh Duy – Trường Đại học Khoa học Tự Nhiên;\r\n3. TS. Ngô Đức Thành – Trường Đại học Công nghệ Thông tin.\r\nPhần 2: Xu hướng nguồn nhân lực AI\r\nDiễn giả khách mời: Ông John Powell Adrian De Guzman - Trade Industry Development Specialist from National Government of the Philippines.", new DateTime(2024, 2, 14, 18, 42, 5, 229, DateTimeKind.Unspecified).AddTicks(6657), "https://forms.gle/HkCD86Gc9UmTTZLP9", false, true, null, null, "Hội trường A, Trường Đại học Công nghệ Thông tin", 78, new DateTime(2023, 12, 8, 1, 35, 33, 401, DateTimeKind.Unspecified).AddTicks(8153), null, new DateTime(2024, 1, 19, 12, 10, 11, 547, DateTimeKind.Unspecified).AddTicks(554), "🔴 HỘI THẢO AI CONNECT chủ đề 'Giới thiệu về đào tạo và nghiên cứu về AI tại ĐHQG-HCM và Xu hướng nguồn nhân lực AI'", 3, "Conference", 9 },
                    { 42, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "🔗 Link đăng ký: https://forms.office.com/r/mKQ3sT0VXb \r\n______________________ \r\n❓ Bạn có bao giờ tự hỏi về tầm quan trọng của việc nghiên cứu trong lĩnh vực Khoa học Máy tính không?  \r\n❓ Bạn có muốn biết thêm về những cơ hội nghiên cứu tiềm năng trong ngành Khoa học Máy tính không?  \r\n❓ Hay làm thế nào để xác định hướng đi trong một lĩnh vực đa dạng và phức tạp như vậy? \r\n⚡️ Đến với buổi seminar 'Định hướng nghiên cứu: Cái nhìn từ người trong ngành Khoa học Máy tính' do khoa Khoa học Máy tính tổ chức, bạn sẽ có cơ hội để khám phá và hiểu rõ hơn về định hướng nghiên cứu bên cạnh với định hướng ứng dụng.  \r\n💥 Đây sẽ là một cơ hội độc đáo để mỗi người tham gia khám phá và hiểu rõ hơn về lĩnh vực nghiên cứu trong ngành Khoa học Máy tính, qua góc nhìn chuyên sâu của một chuyên gia trong lĩnh vực này. \r\n🌈 Khoa rất hân hạnh giới thiệu với các bạn diễn giả của buổi seminar, Tiến sĩ Nguyễn Trí Hải - một học giả tài năng và đầy nhiệt huyết. Anh hiện đang đảm nhận vị trí Nghiên cứu sau Tiến sĩ tại Đại học Khoa học và Công nghệ Quốc Gia Seoul, Hàn Quốc. Với bằng Tiến sĩ Khoa học và Kỹ thuật Máy tính từ Đại học Chung-Ang năm 2022, bằng Thạc sĩ Công nghệ Thông tin và Truyền thông từ Đại học Soongsil năm 2017, và bằng Cử nhân Khoa học máy tính hệ tài năng từ Đại học Công nghệ Thông tin ĐHQG-HCM năm 2015, anh Hải đã tạo dựng được một nền tảng vững chắc trong lĩnh vực Khoa học Máy tính. \r\n👨‍💻 Tiến sĩ Nguyễn Trí Hải đã đạt được nhiều thành tựu đáng chú ý trong lĩnh vực nghiên cứu của mình, trong đó có việc nhận giải thưởng bài báo xuất sắc tại Hội thảo quốc tế về hội tụ công nghệ thông tin và truyền thông (ICTC 2022). Không chỉ vậy, anh còn đóng góp công sức như một bình duyệt viên và thành viên ban chuyên môn cho nhiều tạp chí và hội thảo quốc tế uy tín, đồng thời cũng là thành viên trong ban biên tập của Tạp chí PLOS ONE. \r\n______________________ \r\nTHÔNG TIN CHI TIẾT BUỔI SEMINAR: \r\n✏️ Chủ đề: ĐỊNH HƯỚNG NGHIÊN CỨU: CÁI NHÌN TỪ NGƯỜI TRONG NGÀNH KHOA HỌC MÁY TÍNH  \r\n🎤 Diễn giả: Anh Nguyễn Trí Hải - Sinh viên K6 ngành Khoa học Máy tính  \r\n⏰ Thời gian: 14h00, Thứ 4 ngày 01/11/2023  \r\n📍 Địa điểm: Hội trường E, tầng 12 Tòa E, Trường Đại học Công nghệ Thông tin ĐHQG-HCM  \r\n🔑 Đối tượng tham gia: Sinh viên UIT  \r\n🔗Link đăng ký tham gia: https://forms.office.com/r/mKQ3sT0VXb \r\nĐừng bỏ lỡ cơ hội tuyệt vời này để khám phá, học hỏi và trao đổi kiến thức từ một chuyên gia hàng đầu trong lĩnh vực Khoa học Máy tính. Khoa rất mong được đón tiếp các bạn sinh viên tại buổi seminar này. \r\n______________________ \r\nMọi thông tin thắc mắc vui lòng liên hệ: \r\n🌎 Fanpage: Khoa Khoa học Máy tính UIT", new DateTime(2023, 1, 6, 23, 34, 30, 691, DateTimeKind.Unspecified).AddTicks(3359), "https://forms.gle/HkCD86Gc9UmTTZLP9", false, true, null, null, "Hội trường E, tầng 12 Tòa E, Trường Đại học Công nghệ Thông tin ĐHQG-HCM", 33, new DateTime(2022, 12, 3, 23, 31, 14, 590, DateTimeKind.Unspecified).AddTicks(2873), null, new DateTime(2023, 1, 2, 14, 44, 24, 583, DateTimeKind.Unspecified).AddTicks(3724), "[SEMINAR: ĐỊNH HƯỚNG NGHIÊN CỨU: CÁI NHÌN TỪ NGƯỜI TRONG NGÀNH KHOA HỌC MÁY TÍNH] ", 2, "Seminar", 9 },
                    { 43, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "⚡Bạn đam mê, hứng thú với AI.\r\n⚡Bạn muốn nâng cao kiến thức và tích lũy kinh nghiệm về AI/ML/DL thông qua trải nghiệm các cuộc thi và các dự án.\r\n⚡Bạn muốn nhận những góp ý, chia sẻ kinh nghiệm từ các tiền bối, đặc biệt là tìm kiếm một mentor siêu cấp dễ thương, nhiệt tình😘.\r\n⚡Bạn muốn tham gia vào các buổi workshop, seminar về các kiến thức hữu ích trong lĩnh vực này.\r\n⚡Bạn muốn kết nối những người chung chí hướng cùng nhau thực hiện hoài bão tuổi trẻ này.\r\nVậy CLB AI chúng tớ chính là nơi bạn thuộc về đây! Còn chần chờ gì nữa mà không kết nạp vào ngay gia đình AI.✨\r\n🎈Sau nhiều năm hoạt động, CLB AI đã ghi được nhiều ấn tượng trong những dự án cũng như những cuộc thi học thuật. Năm nay, chúng tớ mong muốn sẽ tìm được thêm những thành viên chất lừ để cùng chúng tớ viết tiếp hành trình này.\r\n💁‍♀️Đến với lần tuyển thành viên này, CLB AI sẽ mang đến một format hoàn toàn mới khi được chia thành 3 team:\r\n⭐Team Python\r\n⭐Team Machine Learning\r\n⭐Team Truyền thông và sự kiện\r\n🥳Hãy nhanh tay điền form đăng kí và gửi chiếc CV xịn xò đến với CLB AI thôi nào!💕\r\n-------------------------------------------------------------\r\n📍Để tham gia, bạn chỉ cần thực hiện ba bước:\r\n👉Thiết kế một chiếc CV thật xịn.\r\n👉Điền form đăng ký: https://forms.gle/a8s8nxWpVhsJnurT8\r\n👉Phỏng vấn cùng Ban chủ nhiệm.\r\n-------------------------------------------------------------\r\n📌Lưu ý:\r\nForm chỉ mở đến 20h ngày 15/10/2023 nên mọi người hãy tranh thủ điền form đúng hạn nha.\r\nSau khi đăng ký, hãy luôn check mail để nhận được các thông tin từ CLB nhé.\r\n------------------------------------------------------------\r\n☎️ Mọi thắc mắc xin vui lòng liên hệ :\r\n🏢 Văn phòng CLB: Phòng B8.02 Trường Đại học CNTT, ĐHQG TPHCM. \r\n📫Email: aiclub@uit.edu.vn", new DateTime(2023, 12, 31, 4, 26, 56, 153, DateTimeKind.Unspecified).AddTicks(62), "https://forms.gle/HkCD86Gc9UmTTZLP9", false, false, null, null, "Online", 79, null, null, new DateTime(2023, 12, 17, 17, 18, 37, 619, DateTimeKind.Unspecified).AddTicks(6895), "🎉🌈TUYỂN THÀNH VIÊN CLB AI👏", 4, "Other", 9 },
                    { 44, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Nếu bạn là một người yêu thích Tiếng Anh và có dự định thi IELTS, nhưng cảm thấy không tự tin về kỹ năng Speaking của bản thân và mong muốn có một sân chơi để học tập và rèn luyện? Chuyện gì khó đã có OEC lo😉\r\n️🎉Hãy cùng OEC tìm hiểu xem bạn sẽ nhận được những điều bổ ích và thú vị gì trong buổi training này nhé.\r\n📍TÀI LIỆU HỌC TẬP bổ trợ trước khi trải nghiệm một bài thi thử IELTS Speaking với các trainer tài năng của OEC. \r\n📍 Sau mỗi Part, các bạn sẽ nhận được những FEEDBACK chân thành để cải thiện kỹ năng Speaking của bản thân. \r\n📍 Ngoài ra, phần thi thử của các bạn cũng sẽ được RECORD, giúp các trainer góp ý chi tiết và đầy đủ hơn sau buổi training.\r\nCòn chần chờ gì nữa mà không tham gia ngay kẻo hết slot đóoo! Đừng quên rủ thêm bạn bè để cùng ôn luyện nhé😍\r\nLink đăng ký: https://forms.gle/5v2ifjFVsbCwuL8a6\r\nHạn chót đăng ký: 00h00, thứ năm ngày 16/05/2024\r\nSố lượng tối đa: 12 người\r\nThông tin chi tiết về buổi training như sau:\r\n🕛 Thời gian: từ 10h45 - 12h00, thứ sáu 17/5/2024\r\n📌 Địa điểm: phòng B4.10, trường ĐH Công nghệ Thông tin", new DateTime(2022, 12, 22, 15, 51, 24, 486, DateTimeKind.Unspecified).AddTicks(9775), "https://forms.gle/HkCD86Gc9UmTTZLP9", false, false, null, null, "phòng B4.10, trường ĐH Công nghệ Thông tin", 96, null, null, new DateTime(2022, 11, 30, 19, 52, 50, 656, DateTimeKind.Unspecified).AddTicks(66), "[𝓔𝓷𝓰𝓵𝓲𝓼𝓱 𝓑𝓮𝓵𝓸𝔀] 🌟𝐎𝐄𝐂 - 𝐈𝐄𝐋𝐓𝐒 𝐒𝐏𝐄𝐀𝐊𝐈𝐍𝐆 𝐓𝐑𝐀𝐈𝐍𝐈𝐍𝐆🌟", 1, "Training", 10 },
                    { 45, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Trò chơi? Đầy! 🎉\r\nQuà tặng? Nhóc! 😻\r\nVui? Bao! 🥳\r\nNhờ sự ủng hộ của mọi người mà OEC đang có một gian hàng cực kỳ sôi động và thú vị trong hôm nay ngày hội 𝑼𝑰𝑻 𝑪𝑳𝑼𝑩 𝑭𝑬𝑺𝑻𝑰𝑽𝑨𝑳 🤍 \r\n⏰ Thời gian: 8h00 - 11h00\r\n🏢 Địa điểm: Sảnh C\r\nCòn chần chờ gì mà không “set” ngay cái lịch hẹn với OEC để rinh ngay những phần quà hấp dẫn nào bạn ơi 🤗 Những phần quà hot nóng bỏng tay chỉ có số lượng có hạn thoai đóoo 🔥🔥🔥\r\n------------------------------------\r\n𝐎𝐄𝐂 - 𝐎𝐏𝐄𝐑𝐀𝐓𝐄𝐃 𝐁𝐘 𝐒𝐓𝐔𝐃𝐄𝐍𝐓𝐒, 𝐅𝐎𝐑 𝐒𝐓𝐔𝐃𝐄𝐍𝐓𝐒 🌻\r\n📬 If you have any question, please do not \r\nhesitate to contact us:\r\n📌Fanpage: https://www.facebook.com/oeclub.uit\r\n💌Gmail: oeclub.uit@gmail.com", new DateTime(2023, 11, 15, 13, 41, 18, 580, DateTimeKind.Unspecified).AddTicks(880), "https://forms.gle/HkCD86Gc9UmTTZLP9", false, true, null, null, "Sảnh C", 62, new DateTime(2023, 9, 24, 17, 18, 18, 155, DateTimeKind.Unspecified).AddTicks(7033), null, new DateTime(2023, 11, 14, 22, 27, 3, 692, DateTimeKind.Unspecified).AddTicks(3236), "✨𝐎𝐄𝐂 𝐀𝐓 𝐔𝐈𝐓 𝐂𝐋𝐔𝐁 𝐅𝐄𝐒𝐓𝐈𝐕𝐀𝐋 𝟐𝟎𝟐𝟒 💥", 6, "Other", 10 },
                    { 46, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "- 𝐵𝑖𝑒̂́𝑡 𝑜̂𝑛𝑔 𝐿𝑎̂̀𝑛 𝑘ℎ𝑜̂𝑛𝑔?\r\n- 𝐿𝑎̂̀𝑛 𝑛𝑎̀𝑜?\r\n❌ 𝐿𝑎̂̀𝑛 đ𝑎̂̀𝑢 𝑡𝑖𝑒̂𝑛 𝑡𝑟𝑎́𝑖...\r\n✅ 𝐿𝑎̂̀𝑛 đ𝑎̂̀𝑢 𝑡𝑖𝑒̂𝑛 đ𝑖 𝑞𝑢𝑎̂𝑛 𝑠𝑢̛̣ 𝑎̆̃𝑚 𝑛𝑔𝑎𝑦 đ𝑖𝑒̂̉𝑚 𝑟𝑒̀𝑛 𝑙𝑢𝑦𝑒̣̂𝑛!!!\r\n️✨Học kỳ quân sự 2023 của sinh viên UIT đã bắt đầu và đang bước vào giai đoạn “trọng đại” nhất.  Sau hơn 1 tuần khoác lên màu áo xanh, ắt hẳn những điều thú vị chắc chắn sẽ không dừng lại ở đó 🌿 Các bạn cảm thấy như thế nào nhỉ, có muốn biến những kỷ niệm ấy thành những thước phim tua chậm khó quên trong tuổi thanh xuân honggg 😉?\r\n🍀 Hãy tham gia ngay cuộc thi ảnh “𝐈𝐓 𝐍𝐇𝐀̣̂𝐏 𝐍𝐆𝐔̃” của OEC, bạn sẽ có cơ hội ôn lại kỉ niệm đẹp cùng đồng đội cũng như may mắn mang về những phần thưởng cực kỳ giá trị đó nhaaa 😘\r\n👨‍💻Đối tượng tham gia: Toàn bộ sinh viên UIT.\r\n🎁Giải thưởng:\r\n🥇 03 Giải đặc biệt: Điểm rèn luyện + móc khóa thương hiệu OEC\r\n❗❗❗❗Đặc biệt: Tất cả các bạn sinh viên tham gia đều được cộng điểm rèn luyện.\r\n📧Cách thức tham gia:\r\n🌷 Bước 1: Theo dõi và nhấn Thích fanpage chính thức của OEC.\r\n🌷 Bước 2: React này và share công khai bài viết này cho đồng đội cùng tham gia nhé. \r\n🌷 Bước 2: Comment ảnh về kì quân sự + tag 3 người bạn vào ngay bài viết này cùng với caption (tiếng Anh hoặc tiếng Việt), Nội dung về cảm nghiệm của bản thân trong kỳ quân sự, đồng thời truyền tải một thông điệp nào đó.\r\n🌷 Bước 4: Kiểm tra thật kỹ lưỡng, trau chuốt từng tấm hình và con chữ của mình để dễ dàng “ôm” giải về tay. \r\n🌷 Bước 5: Điền form minh chứng sau nhé:\r\n👉 Link: https://docs.google.com/.../1FAIpQLSdXimitJXW.../viewform...\r\n💯Cách thức tính điểm:\r\nMỗi bài dự thi sẽ được đăng công khai dưới dạng comment ngay tại bài viết này của OEC, chấm điểm theo tiêu chí 50% vote và 50% ban giám khảo. Cụ thể về cách chấm điểm của lượt vote:\r\n            📌Mỗi lượt reaction của comment (không tính lượt Phẫn nộ) tính 01 điểm.\r\n🌼Các tiêu chí chấm của BGK: tính nghệ thuật của ảnh, nội dung, thông điệp truyền tải trên thang điểm 10. Nếu bài dự thi của bạn là tiếng Anh, bạn sẽ được cộng thêm điểm cho phần thông điệp 😉\r\n⏳ Hạn chót nhận bài dự thi: 𝟐𝟑𝐡𝟓𝟗𝐩, 𝟐𝟐/𝟏𝟐/𝟐𝟎𝟐𝟐\r\n🍀 Lời cuối cùng, OEC xin chúc các bạn UIT K18 sẽ cùng nhau tạo nên một mùa áo xanh thật đáng nhớ!\r\n️💥 Và mn ơi, chần chừ gì nữa mà không tham gia nàoooo?\r\n📸 Nguồn ảnh: Lê Văn Hùng\r\n------------------------------------\r\n𝐎𝐄𝐂 - 𝐎𝐏𝐄𝐑𝐀𝐓𝐄𝐃 𝐁𝐘 𝐒𝐓𝐔𝐃𝐄𝐍𝐓𝐒, 𝐅𝐎𝐑 𝐒𝐓𝐔𝐃𝐄𝐍𝐓𝐒 🌻\r\n📬 If you have any questions, please do not hesitate to contact us:\r\n📌Fanpage: https://www.facebook.com/oeclub.uit\r\n💌Gmail: oeclub.uit@gmail.com", new DateTime(2022, 11, 7, 19, 4, 12, 538, DateTimeKind.Unspecified).AddTicks(171), "https://forms.gle/HkCD86Gc9UmTTZLP9", false, false, null, null, "Online", 50, null, null, new DateTime(2022, 10, 29, 1, 1, 16, 728, DateTimeKind.Unspecified).AddTicks(6407), "[❗❗❗𝙃𝙊𝙏] 📸 '𝐈𝐓 𝐍𝐇𝐀̣̂𝐏 𝐍𝐆𝐔̃” - 𝐀 𝐩𝐡𝐨𝐭𝐨 𝐜𝐨𝐧𝐭𝐞𝐬𝐭 𝓫𝔂 𝓞𝓔𝓒 📹'", 6, "Other", 10 },
                    { 47, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "✨ Trong thời gian qua, OEC đã nhận được đông đảo sự chú ý từ những thành viên tương lai của câu lạc bộ. Để đáp lại sự nhiệt huyết đó, OEC xin hân hạnh thông báo rằng, chúng mình đã sẵn sàng để chào đón những con người có cùng một lòng đam mê cháy bỏng 😎 🔊🔊\r\n🍀 Trong hành trình tìm kiếm những tài năng mới này, chúng mình mong muốn xây dựng một cộng đồng sử dụng tiếng Anh không chỉ đoàn kết, nhưng cũng thật sôi động, luôn luôn ngập tràn tiếng cười với những hoạt động vui nhộn 🥰 Vì thế, những con người năng động và sáng tạo đang đứng sau màn hình đây, bạn có thể là tương lai của OEC đấy!\r\n✨ Đến với OEC, bạn sẽ không chỉ nhận được những kiến thức về tiếng Anh, nhưng bạn cũng sẽ có thể tìm thấy những chiến hữu, những người bạn mà ta có thể trò chuyện, chia sẻ những buồn vui với nhau trong quá trình học 🌐🗣️🦜\r\n🍀 OEC tin rằng với sự giúp đỡ và phấn đấu từ tất cả các bạn, chúng ta sẽ có thể đưa OEC lên những tầm cao mới 🥳 Vậy, bạn còn chần chờ gì nữa? Hãy chia sẻ tin tức nóng hổi này cho friendlist của mình nào, hãy để sự tích cực này lan tỏa tới mọi người!\r\n👉Sau đây, chúng mình sẽ giúp các bạn hiểu rõ hơn về 4 ngôi nhà của OEC nhaa  🥳 \r\n📝Link đăng ký: https://forms.office.com/r/wru1DSSiyb\r\n📆Thời gian đăng ký: 20h00 22/09 - 20h01 03/10 \r\n📌Thời gian phỏng vấn: 14/10 ", new DateTime(2023, 10, 31, 23, 56, 37, 999, DateTimeKind.Unspecified).AddTicks(6874), "https://forms.gle/HkCD86Gc9UmTTZLP9", false, false, null, null, "Online", 67, null, null, new DateTime(2023, 10, 13, 3, 35, 29, 764, DateTimeKind.Unspecified).AddTicks(9578), "[‼️- 𝓔𝓷𝓰𝓵𝓲𝓼𝓱 𝓫𝓮𝓵𝓸𝔀] OEC THÔNG BÁO TUYỂN THÀNH VIÊN 🔥", 3, "Other", 10 },
                    { 48, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "🥳 Vậy là thời gian diễn ra Vòng Chung kết của cuộc thi WebDev Adventure 2024 do CLB WebDev Studios tổ chức đang ngày càng đến gần. Không biết rằng các bạn thí sinh đã sẵn sàng thể hiện những kinh nghiệm, kiến thức mà mình đã tích lũy được để có thể tỏa sáng trong vòng thi cuối cùng này chưa?\r\n🥰 Không khí trước thềm Chung kết đang diễn ra hết sức sôi nổi, chúng ta hãy cùng đếm ngược dòng thời gian để chuẩn bị tinh thần cổ vũ cho các đội thi xuất sắc này trong chặng đường tìm kiếm ngôi vô địch của mùa giải năm nay. Và hãy cùng nhau xem lại một số thông tin của Vòng Chung kết ngày mai nào.\r\n📌 Thông tin chi tiết Vòng Chung kết:\r\n⏰ Thời gian: 13h00, ngày 31/05/2024 (Thứ Sáu).\r\n🏫 Địa điểm: Hội trường E, Trường Đại học Công nghệ thông tin – Đại học Quốc gia Thành phố Hồ Chí Minh.\r\n🎁 Ngoài ra, khi tham dự, các bạn sẽ có cơ hội nhận được những phần quà đặc biệt đến từ BTC.\r\n🔥 Còn chần chờ gì nữa mà không nhanh tay note ngay lịch trình cụ thể về thời gian, địa điểm tổ chức để có mặt đúng giờ. Và hẹn gặp lại các bạn tại Vòng Chung kết của cuộc thi WebDev Studios nhé!\r\n---------------\r\n📝 Mọi thắc mắc xin liên hệ: Trần Minh Chính - Chủ nhiệm CLB WebDev Studios \r\n🏢 Văn phòng : Phòng B804, tòa B, Trường ĐHCNTT \r\n🌐 Portfolio: webdevstudios.org \r\n🔗 LinkedIn: linkedin.com/company/webdev-studios-org/ \r\n📧 Email: webdevstudios.org@gmail.com \r\n☎️ Số điện thoại: 0968 134 049", new DateTime(2022, 10, 23, 7, 11, 0, 859, DateTimeKind.Unspecified).AddTicks(4196), "https://forms.gle/HkCD86Gc9UmTTZLP9", false, true, null, null, "Hội trường E, Trường Đại học Công nghệ thông tin – Đại học Quốc gia Thành phố Hồ Chí Minh", 91, new DateTime(2022, 9, 13, 6, 22, 17, 369, DateTimeKind.Unspecified).AddTicks(7835), null, new DateTime(2022, 9, 26, 6, 9, 42, 801, DateTimeKind.Unspecified).AddTicks(2749), "✨ [WEBDEV STUDIOS] | [WEBDEV ADVENTURE 2024] ✨\r\n🎉 [24H ĐẾM NGƯỢC ĐẾN VÒNG CHUNG KẾT] 🎉", 4, "Other", 11 },
                    { 49, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "🔊 Vòng 2 của WebDev Adventure 2024 đã chính thức khép lại. Giờ đây, đường đua ngày càng gay cấn hơn khi Top 6 đội thi của chặng cuối đã được lộ diện.\r\n🥰 Bên cạnh đó, BTC cũng xin gửi lời cảm ơn chân thành với tất cả các đội thi vì đã quan tâm và cố gắng hết mình trong suốt hành trình của WebDev Adventure 2024. Dù kết quả có ra sao, hy vọng các bạn vẫn luôn kiên trì và giữ vững niềm đam mê Lập trình Web. Chúng mình tin chắc rằng ai cũng đã có được những bài học, kinh nghiệm để có thể nâng tầm bản thân của mình trong tương lai. Và WebDev vẫn ở đây và chào mừng một phiên bản hoàn thiện của chính bạn trong những mùa thi sau.\r\n🥳 Cuối cùng, xin chúc mừng TOP 6! Bước vào chặng đua cuối cùng, chúc các đội bình tĩnh, tự tin và hoàn thành tốt nhất bài thi của mình. Hãy sẵn sàng để tiến tới ngôi vị cao nhất của WebDev Adventure 2024 nhé!\r\n----------------------------------\r\n📝 Mọi thắc mắc xin liên hệ: Trần Minh Chính - Chủ nhiệm CLB WebDev Studios \r\n🏢 Văn phòng : Phòng B804, tòa B, Trường ĐHCNTT \r\n🌐 Portfolio: webdevstudios.org \r\n🔗 LinkedIn: linkedin.com/company/webdev-studios-org/ \r\n📧 Email: webdevstudios.org@gmail.com \r\n☎️ Số điện thoại: 0968 134 049", new DateTime(2023, 9, 16, 5, 0, 54, 952, DateTimeKind.Unspecified).AddTicks(5300), "https://forms.gle/HkCD86Gc9UmTTZLP9", false, true, null, null, "Phòng B804, tòa B, Trường ĐHCNTT ", 46, new DateTime(2023, 7, 11, 9, 25, 20, 27, DateTimeKind.Unspecified).AddTicks(4580), null, new DateTime(2023, 9, 10, 8, 43, 55, 837, DateTimeKind.Unspecified).AddTicks(5919), "✨ [WEBDEV STUDIOS] | [WEBDEV ADVENTURE 2024] ✨\r\n📢️ [THÔNG BÁO KẾT QUẢ VÒNG 2] 📢️ ", 3, "Other", 11 },
                    { 50, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "⏰ Sau bao ngày phát động cuộc thi WEBDEV ADVENTURE 2024, chắc hẳn các đội thi đều đang nóng lòng chờ kết quả của vòng 1 đúng không nào?\r\n🎉 Không để các bạn đợi lâu, BTC xin chúc mừng các đội dưới đây đã hoàn thành xuất sắc vòng 1 và chiếm trọn tình cảm từ Ban Giám Khảo của WDA 2024.  \r\n😘 Trong suốt khoảng thời gian vừa qua, BTC WDA 2024 rất vui vì đã nhận được những bài dự thi vô cùng chỉn chu và đầy tâm huyết đến từ các đội thi. Vậy nên các đội thi dừng chân tại vòng này cũng đừng buồn nha! Chúng mình tin rằng qua cuộc thi lần này, các bạn sẽ có trong mình những trải nghiệm đáng quý, những bài học mới mẻ và khó quên trong tháng ngày sinh viên tươi đẹp của mình. Hẹn gặp lại các bạn vào những sự kiện tiếp theo của WebDev Studios nhé! 🌹\r\n📢️ Và để tiếp nối cho vòng 1, BTC xin thông báo Vòng 2 - XÂY DỰNG chính thức được khởi động. Ở vòng này, các đội thi sẽ bắt tay vào việc lập trình để thực hiện hóa những giải pháp đã đưa ra trong vòng 1.\r\n🤩 BTC xin kính chúc cho tất cả các đội thi sẽ bước vào vòng 2 một cách suôn sẻ và thuận lợi. Fighting!!! 💪💪💪\r\n--------------\r\n📝 Mọi thắc mắc xin liên hệ: Trần Minh Chính - Chủ nhiệm CLB WebDev Studios \r\n🏢 Văn phòng : Phòng B804, tòa B, Trường ĐHCNTT \r\n🌐 Portfolio: webdevstudios.org \r\n🔗 LinkedIn: linkedin.com/company/webdev-studios-org/ \r\n📧 Email: webdevstudios.org@gmail.com \r\n☎️ Số điện thoại: 0968 134 049", new DateTime(2022, 9, 8, 14, 33, 54, 384, DateTimeKind.Unspecified).AddTicks(6983), "https://forms.gle/HkCD86Gc9UmTTZLP9", false, false, null, null, "Phòng B804, tòa B, Trường ĐHCNTT ", 38, null, null, new DateTime(2022, 8, 24, 11, 18, 8, 873, DateTimeKind.Unspecified).AddTicks(9090), "✨ [WEBDEV STUDIOS] | [WEBDEV ADVENTURE 2024] ✨\r\n📢️ [THÔNG BÁO KẾT QUẢ VÒNG 1️ - BẮT ĐẦU VÒNG 2]📢️ ", 5, "Other", 11 },
                    { 51, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "👉 Đăng ký ngay tại: https://adventure.webdevstudios.org/ 👈\r\n👉 Hạn đăng ký: 23h59 ngày 13/04/2024. 👈\r\n--------------------\r\n🗓️ Tháng 3 này, WebDev Studios đã trở lại và nối tiếp sự thành công rực rỡ của cuộc thi WebDev Adventure 2023, chúng mình xin trân trọng thông báo:\r\n🎊 Cuộc thi WEBDEV ADVENTURE 2024 xin chính thức được khởi tranh!!! 🎊\r\n❤️ WEBDEV ADVENTURE 2024 là cuộc thi lập trình với tiền thân là WebDev Hackathon – cuộc thi lập trình Web và Mobile do CLB WebDev Studios tổ chức hằng năm với quy mô rộng lớn trên toàn quốc, là sân chơi dành cho các bạn học sinh, sinh viên đam mê và muốn thử sức mình trong lĩnh vực lập trình Web/App.\r\n🏆 Trải qua 4 mùa, WebDev Adventure thành công tạo ra sân chơi quy tụ dàn thí sinh vô cùng chất lượng. Các đội đã có những phần thi hấp dẫn, gay cấn và cũng có những màn thể hiện vô cùng xuất sắc và tỏa sáng. Ban tổ chức cũng đã tìm ra được những đội thi xuất sắc nhất cho vị trí nhà vô địch.\r\n🥳 Đến với mùa thứ 5 này, WebDev Studios hứa hẹn sẽ mang đến một sân chơi học thuật cạnh tranh đầy thú vị giữa các bạn có niềm đam mê lập trình Web/App. Đây cũng sẽ là cơ hội để các bạn có thể làm quen và tiếp xúc với nguồn tri thức vô tận, được trải nghiệm những điều mới lạ, học cách làm việc teamwork hiệu quả, có cơ hội thể hiện bản thân, khả năng và sự tâm huyết, cố gắng của mình trong suốt quá trình thi.\r\n--------------------\r\n📌 ĐỐI TƯỢNG THAM GIA:\r\n🌟 Tất cả các bạn học sinh, sinh viên hiện đang theo học tại các Trường Đại học, Cao đẳng trên toàn quốc.\r\n📌 HÌNH THỨC ĐĂNG KÝ:\r\n👉 Đăng ký online trên website của cuộc thi: https://adventure.webdevstudios.org/\r\n👉 Đăng ký offline tại sảnh C Trường Đại học Công nghệ thông tin - Đại học Quốc gia Thành phố Hồ Chí Minh vào lúc 9h30 đến 16h30, từ ngày 25/03 đến 06/04/2024.\r\n📌 THỂ LỆ CUỘC THI:\r\n➡️ Các đội thi có số lượng thí sinh từ 3 - 5 thành viên, trong đó có ít nhất 1 thí sinh thuộc Trường Đại học Công nghệ thông tin - Đại học Quốc gia Thành phố Hồ Chí Minh.\r\n➡️ Các đội sẽ trải qua 3 vòng thi:\r\n- Vòng 1️⃣: Ý TƯỞNG: Các đội thi sẽ phải lên ý tưởng để giải quyết yêu cầu được nêu trong đề bài, thiết kế các chức năng, chọn các công nghệ phù hợp với sản phẩm của mỗi đội.\r\n- Vòng 2️⃣: XÂY DỰNG: Các đội thi sẽ hiện thực hóa ý tưởng ở Vòng 1, bằng cách lập trình Web hoặc App dựa trên những ý tưởng đã có.\r\n- Vòng 3️⃣: CHUNG KẾT: Tại vòng này, các đội thi sẽ phải thuyết trình và trả lời các câu hỏi về sản phẩm của mình với các giám khảo nhằm chứng minh rằng sản phẩm, giải pháp của mình là phù hợp nhất với vấn đề mà đề bài yêu cầu.\r\n➡️ Những đội vượt qua Vòng 2 của cuộc thi sẽ nhận được Giấy chứng nhận tiêu chí “Học tập tốt” trong Sinh viên 5 Tốt.\r\n📌 LỆ PHÍ VÀ QUYỀN LỢI THAM GIA:\r\n💸 Đối với sinh viên đăng ký tham gia cuộc thi:\r\n 🔹Lệ phí: 50.000VNĐ/thí sinh.\r\n 🔹Được tham gia các buổi workshop miễn phí.\r\n💸 Đối với sinh viên đăng ký tham gia workshop:\r\n 🔹Lệ phí: 20.000VNĐ/sinh viên.\r\n💸 Ngoài ra, các bạn còn có thể hoàn thành lệ phí offline tại sảnh C của Trường Đại học Công nghệ thông tin - Đại học Quốc gia Thành phố Hồ Chí Minh từ ngày 25/03 đến ngày 06/04/2024.\r\n🔥 Bên cạnh đó, WEBDEV ADVENTURE 2024 còn mang đến cho các bạn chuỗi Workshop về các chủ đề hấp dẫn liên quan đến ngành Công nghệ Thông tin nói chung và lập trình Web/App nói riêng.\r\n😍 Nghe thật thú vị phải không nào? Vậy còn chần chờ chi nữa, hãy đăng ký ngay thôi!\r\n🥇 Đội thi nào sẽ ghi tên mình vào vị trí quán quân của cuộc thi WEBDEV ADVENTURE 2024? Hãy cùng nhau like và follow page CLB WebDev Studios để cập nhật những thông báo về từng chặng của cuộc thi nhé!!! \r\n--------------------\r\n📝 Mọi thắc mắc xin liên hệ: Trần Minh Chính - Chủ nhiệm CLB WebDev Studios \r\n🏢 Văn phòng : Phòng B804, tòa B, Trường ĐHCNTT \r\n🌐 Portfolio: webdevstudios.org \r\n🔗 LinkedIn: linkedin.com/company/webdev-studios-org/ \r\n📧 Email: webdevstudios.org@gmail.com \r\n☎️ Số điện thoại: 0968 134 049", new DateTime(2023, 9, 1, 19, 26, 19, 846, DateTimeKind.Unspecified).AddTicks(3686), "https://forms.gle/HkCD86Gc9UmTTZLP9", false, true, null, null, "sảnh C Trường Đại học Công nghệ thông tin ", 38, new DateTime(2023, 7, 5, 4, 52, 25, 286, DateTimeKind.Unspecified).AddTicks(5355), null, new DateTime(2023, 8, 8, 13, 52, 21, 910, DateTimeKind.Unspecified).AddTicks(2261), "✨ [WEBDEV STUDIOS] | [WEBDEV ADVENTURE 2024] ✨\r\n🎉 [CHÍNH THỨC PHÁT ĐỘNG CUỘC THI WEBDEV ADVENTURE 2024] 🎉", 1, "Workshop", 11 },
                    { 52, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "“Tôi yêu CLB của tôi 🫶,\r\nMột ngày thì sao? 🤔\r\nNgày chơi MINIGAMEEEEE đó 😍”\r\n🥰 Mở đầu cho chuyến hành trình WebDev Adventure 2024 đầy thú vị và hấp dẫn của nhà WDS sắp tới là một Minigame nho nhỏ được chúng mình dày công chuẩn bị! Thông qua trò chơi lần này, WebDev Studios mong muốn sẽ đưa đến cho các bạn thật nhiều thông tin và kiến thức bổ ích mà bất kỳ UITers nào cũng không nên bỏ lỡ.\r\n🥳 Tham gia ngay để có cơ hội rinh những món quà vô cùng hấp dẫn “về tay” các bạn nhé. Và đừng quên theo dõi Fanpage WebDev Studios để nhận được thông báo mới nhất về những sự kiện sắp tới của chúng mình nha!\r\n-----------------------------\r\n🌹 THỂ LỆ THAM GIA MINIGAME: \r\n🕐 Thời gian : từ 20h00 ngày 18/03/2024 đến 23h59 ngày 22/03/2024. \r\n💁 Đối tượng tham gia: Các bạn sinh viên thuộc các trường Đại học, Cao đẳng trên địa bàn TP.HCM.\r\n📍 Hình thức: Giải mã các ô chữ hàng ngang bằng những câu hỏi gợi ý được Ban Tổ chức cung cấp và đưa ra từ khóa chính được yêu cầu. Sau đó, BTC sẽ tiến hành chọn một bạn có đáp án chính xác và nhanh chóng nhất cùng với con số may mắn sẽ được công bố tại Fanpage của CLB. \r\n🎁 Phần thưởng cho bạn may mắn nhất là 1 combo ấn phẩm đến từ CLB.\r\n🌹 CÁCH THỨC THAM GIA MINIGAME: \r\n👉 Bước 1: Like và Follow Fanpage WebDev Studios.\r\n👉 Bước 2: Comment trả lời 9 câu hỏi mà BTC đặt ra cùng với ô chữ hàng dọc được tô màu trên hình cùng với một con số may mắn từ 0 - 999 và tag tên 3 người bạn để mời họ cùng tham gia Minigame.\r\n👉 Bước 3: Like và share bài viết này ở chế độ công khai kèm hashtag:\r\n#WebDevStudios\r\n#WebDevAdventure2024\r\n👉 Bước 4: Chụp ảnh màn hình câu trả lời (không được chỉnh sửa) để điền đầy đủ vào đường dẫn Google Form BTC cung cấp.\r\n📝 Link điền minh chứng: https://forms.gle/vy3vL5fU42w9gtKu8\r\n🌹 CÂU HỎI GỢI Ý:\r\nCâu 1️⃣: Ngôn ngữ lập trình được rất nhiều các lập trình viên sử dụng cho việc lập trình web là ngôn ngữ nào?\r\nCâu 2️⃣: Một trong số những backend framework được viết bằng Python là gì?\r\nCâu 3️⃣: Một trong những trình soạn thảo mã nguồn mở được nhiều lập trình viên hiện tại sử dụng là gì?\r\nCâu 4️⃣: Trải nghiệm của người dùng đối với giao diện trên website gọi là gì? \r\nCâu 5️⃣: Hệ quản trị cơ sở dữ liệu NoSQL mã nguồn mở được nhiều lập trình viên sử dụng là gì?\r\nCâu 6️⃣: Một hệ thống quản lý các phiên bản dưới dạng phân tán gọi là gì?\r\nCâu 7️⃣: Một lập trình viên phụ trách cả FrontEnd, BackEnd cũng như các phần cần thiết khác của một dự án là gì?\r\nCâu 8️⃣: Một hệ thống máy tính có địa chỉ IP tĩnh và khả năng xử lý cao được gọi là gì?\r\nCâu 9️⃣: Kỹ thuật giúp website tương thích với nhiều độ phân giải màn hình gọi là \r\n🔥 Và cuối cùng, mọi người ghép hàng dọc ra kết quả gì nào???\r\n🌹 QUYỀN LỢI THAM GIA:\r\n🎁 Sinh viên thuộc Trường Đại học Công nghệ Thông tin - ĐHQG TP.HCM tham gia và hoàn thành Minigame theo đúng yêu cầu của Ban Tổ chức sẽ được ghi nhận điểm rèn luyện học kỳ 2 năm học 2023 - 2024 theo quy định.\r\n‼️ LƯU Ý: \r\n💭 Trường hợp có nhiều câu trả lời đúng, BTC sẽ random để chọn ra 1 bạn may mắn nhất thông qua con số may mắn mà các bạn chọn để tiến hành trao giải.\r\n-----------------------------\r\n📝 Mọi thắc mắc xin liên hệ: Trần Minh Chính - Chủ nhiệm CLB WebDev Studios \r\n🏢 Văn phòng : Phòng B804, tòa B, Trường ĐHCNTT \r\n🌐 Portfolio: webdevstudios.org \r\n🔗 LinkedIn: linkedin.com/company/webdev-studios-org/ \r\n📧 Email: webdevstudios.org@gmail.com \r\n☎️ Số điện thoại: 0968 134 049", new DateTime(2022, 7, 25, 0, 18, 45, 308, DateTimeKind.Unspecified).AddTicks(388), "https://forms.gle/HkCD86Gc9UmTTZLP9", false, true, null, null, "Online", 75, new DateTime(2022, 7, 1, 2, 48, 6, 475, DateTimeKind.Unspecified).AddTicks(74), null, new DateTime(2022, 7, 22, 16, 26, 34, 946, DateTimeKind.Unspecified).AddTicks(5431), "✨ [WEBDEV STUDIOS | WEBDEV ADVENTURE 2024] ✨\r\n🌟 [MINIGAME 1: “WEBDEV HỎI, BẠN TRẢ LỜI”] 🌟", 1, "Other", 11 },
                    { 53, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "🤗 Vậy là những buổi training cuối cùng của năm học này đã kết thúc. Hy vọng rằng nó đã đem lại hành trang bổ ích cho các bạn sinh viên trong kì thi cuối kì sắp tới này.\r\n❤️ Chân thành cảm ơn các bạn sinh viên đã đến tham gia các buổi training của Ban học tập. Chúc các bạn sẽ có kì thi thật suông sẻ và đạt được thành tích mình mong muốn.\r\n🌸 Cuối cùng, mong rằng các bạn sẽ tiếp tục ủng hộ Ban học tập Công nghệ Phần mềm trong học kì tiếp theo nha!\r\n➖➖➖➖➖➖➖➖➖➖\r\nMọi thắc mắc liên hệ tại:\r\n💻 Website: https://www.bhtcnpm.com/\r\n💌 Gmail: bht.cnpm.uit@gmail.com\r\n💬 Fanpage: https://www.facebook.com/bhtcnpm\r\n💓 Group BHT NNSC: https://www.facebook.com/groups/bht.cnpm.uit", new DateTime(2023, 7, 18, 5, 11, 10, 769, DateTimeKind.Unspecified).AddTicks(7091), "https://forms.gle/HkCD86Gc9UmTTZLP9", false, false, null, null, "Microsoft Teams", 90, null, null, new DateTime(2023, 7, 6, 19, 0, 47, 982, DateTimeKind.Unspecified).AddTicks(8602), "☀️ [TỔNG KẾT TRAINING CUỐI KÌ II 2023-2024] ☀️", 1, "Training", 12 },
                    { 54, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "💘 Tháng 6 bước sang báo hiệu một mùa thi nữa lại đến cùng các bạn UIT.\r\n🏃‍♂️ Nếu bạn vẫn đang loay hoay trong hành trình “tìm đường đi ngắn nhất” hay vẫn đang lạc lối giữa những “chu trình” thì đừng quá lo lắng nhé.\r\n🌟 Ban học tập Công nghệ Phần mềm chúng mình đến và gửi bạn một “bản đồ” là buổi training cuối kì Cấu trúc rời rạc ngay nè.\r\n🎯 Note lại thông tin để nhận bản đồ đến với kho báu A+ ngay thôi nào.\r\n ➖➖➖➖➖➖➖➖➖➖➖\r\n📌 Thông tin buổi training ONLINE:\r\n⏰ Thời gian: 19h ngày 13/6/2024\r\n⛳ Địa điểm: Microsoft Teams \r\n 🔒Code: w2dsy1q\r\n🎤 Trainers:\r\n- Nguyễn Tài Tấn - KHMT2023.4\r\n- Ngô Lê Tấn Huy - MMTT2023.1\r\n- Huỳnh Chí Hên - KTPM2023.1\r\n➖➖➖➖➖➖➖➖➖➖➖    \r\nMọi thắc mắc liên hệ tại:\r\n 💻Website: https://www.bhtcnpm.com/\r\n💌 Gmail: bht.cnpm.uit@gmail.com\r\n💬 Fanpage: https://www.facebook.com/bhtcnpm\r\n💓 Group BHT NNSC: https://www.facebook.com/groups/bht.cnpm.uit", new DateTime(2022, 7, 9, 18, 10, 25, 418, DateTimeKind.Unspecified).AddTicks(826), "https://forms.gle/HkCD86Gc9UmTTZLP9", false, false, null, null, "Microsoft Teams ", 26, null, null, new DateTime(2022, 6, 19, 21, 35, 1, 19, DateTimeKind.Unspecified).AddTicks(1773), "🔔[NHẮC NHỞ TRAINING CUỐI KÌ CẤU TRÚC RỜI RẠC] 🔔", 4, "Training", 12 },
                    { 55, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Chào mừng đến với chuyến tàu “ vượt ải DSA “ - bộ môn được coi là vô cùng khó nhằn đối với sinh viên. Tuy nhiên, đừng lo lắng, vì Ban học tập báo cho bạn một tin vui rằng sắp tới sẽ có chuỗi training lẫn online và offline nên các bạn đừng lo lắng nhé. Dĩ nhiên nội dung sẽ vô cùng bổ ích, giúp các bạn qua môn dễ dàng và gặt hái được những điểm số ấn tượng nữa đấy. 🤗\r\nCòn ngại ngần gì mà không lưu ngay bài viết này lại để nhắc nhở bản thân tham gia. Đừng quên chia sẻ với bạn bè để cùng nhau “vượt ải DSA” thành công nhé.\r\nCòn thông tin chi tiết thì ngay dưới nay đây! 👇\r\n💎 Đối với Offline:\r\n⏰ Thời gian: 9h30 12/06/2024\r\n📍 Địa điểm: B1.14\r\n🏅Trainer: \r\n+ Tiền Minh Dương - KTPM2023.1\r\n+ Lê Ngô Thanh Toàn - KHMT2023.4\r\n💎Đối với Online\r\n⏰ Thời gian: 19h 12/06/2024\r\n📍 Địa điểm: Code: w2dsy1q\r\n🏅Trainer: \r\n+ Tiền Minh Dương - KTPM2023.1\r\n+ Trương Đoàn Vũ - MMTT2022.3\r\n✅ Tài liệu và slide bài giảng môn Cấu trúc dữ liệu và giải thuật sẽ được cập nhật trong bài 'Tài liệu training' sau buổi training, các bạn nhớ tải về xem lại để nắm vững kiến thức nhé.\r\n☘ Chúc các bạn một ngày vui vẻ, và có một buổi ôn tập thật hiệu quả.\r\n➖➖➖➖➖➖➖➖➖➖➖    \r\nMọi thắc mắc liên hệ tại:\r\n💻 Website: https://www.bhtcnpm.com/\r\n💌 Gmail: bht.cnpm.uit@gmail.com\r\n💬 Fanpage: https://www.facebook.com/bhtcnpm\r\n💓 Group BHT NNSC: https://www.facebook.com/groups/bht.cnpm.uit", new DateTime(2023, 7, 2, 16, 0, 19, 511, DateTimeKind.Unspecified).AddTicks(1930), "https://forms.gle/HkCD86Gc9UmTTZLP9", false, true, null, null, "B1.14", 23, new DateTime(2023, 4, 21, 20, 35, 10, 40, DateTimeKind.Unspecified).AddTicks(4235), null, new DateTime(2023, 6, 4, 0, 9, 14, 55, DateTimeKind.Unspecified).AddTicks(4943), "⭐ [NHẮC NHỞ TRAINING CẤU TRÚC DỮ LIỆU VÀ GIẢI THUẬT K18] ⭐", 4, "Training", 12 },
                    { 56, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "🤔 Chắc hẳn không sinh viên UIT nào không biết đến Lập trình hướng đối tượng (OOP)- một môn học nền tảng quan trọng.\r\n🏃‍♂️ Bước vào kì thi sắp tới với tâm thế còn nhiều suy tư, hoang mang trong môn học này là điều khó tránh khỏi.\r\n📝 Nhưng thay vì lo lắng, loay hoay hãy đến ngay với 2 buổi training ONLINE và OFFLINE của Ban học tập khoa Mềm nào.\r\n➖➖➖➖➖➖➖➖➖➖➖\r\n📍 Thông tin buổi training OFFLINE:\r\n⏰ Thời gian: 9h30 ngày 11/06/2024\r\n🏫 Địa điểm: Phòng B1.14\r\n🗣️ Trainers: \r\n+ Nguyễn Lê Tuấn Anh - KTPM2023.1\r\n+ Quách Vĩnh Cơ - KTPM2023.1\r\n📌Thông tin buổi training ONLINE:\r\n⏰ Thời gian: 19h ngày 11/06/2024\r\n⛳ Địa điểm: Microsoft Teams \r\n 🔒Code: w2dsy1q\r\n🎤 Trainers:\r\n+ Võ Chí Cường - KTPM2023.1\r\n+ Quách Vĩnh Cơ - KTPM2023.1\r\n➖➖➖➖➖➖➖➖➖➖➖    \r\nMọi thắc mắc liên hệ tại:\r\n💻Website: https://www.bhtcnpm.com/\r\n💌 Gmail: bht.cnpm.uit@gmail.com\r\n💬 Fanpage: https://www.facebook.com/bhtcnpm\r\n💓 Group BHT NNSC: https://www.facebook.com/groups/bht.cnpm.uit", new DateTime(2022, 5, 25, 19, 48, 27, 154, DateTimeKind.Unspecified).AddTicks(7200), "https://forms.gle/HkCD86Gc9UmTTZLP9", false, false, null, null, "Phòng B1.14", 61, null, null, new DateTime(2022, 5, 18, 2, 43, 27, 91, DateTimeKind.Unspecified).AddTicks(8114), "❤️‍🔥 [NHẮC NHỞ TRAINING CUỐI KÌ LẬP TRÌNH HƯỚNG ĐỐI TƯỢNG] ❤️‍🔥", 3, "Training", 12 },
                    { 57, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "🍀 Xin chào các bạn,\r\n🍀 Thế là một năm học nữa sắp kết thúc, để có một mùa hè tràn đầy niềm vui thì trước hết chúng mình nên có một kì thi với nhiều con điểm đẹp đúng không nhỉ? 🫣🫣\r\n🍀 Sắp đến chúng mình sẽ tổ chức một chuỗi training cuối kì cho các bạn nhằm củng cố kiến thức, chia sẻ những tips hay và kinh nghiệm khi làm bài với mong muốn các bạn sẽ tự tin chiến hết mình khi bước vào phòng thi nhé! 🔥🔥\r\n📑 Thông tin buổi training:\r\n🔥 Lập trình hướng đối tượng (OOP):\r\n⏰ Thời gian: ngày 11/06/2024\r\n🏘️ Hình thức:\r\n- Offline: vào lúc 9h30 tại phòng B1.14\r\n- Online: vào lúc 19h00 tại MS Teams (Code: w2dsy1q)\r\n🙋 Trainer:\r\n- Offline: \r\n+ Nguyễn Lê Tuấn Anh - KTPM2023.1\r\n+ Quách Vĩnh Cơ - KTPM2023.1\r\n- Online: \r\n+ Võ Chí Cường - KTPM2023.1\r\n+ Quách Vĩnh Cơ - KTPM2023.1\r\n🔥 Cấu trúc dữ liệu và giải thuật (DSA):\r\n⏰ Thời gian: ngày 12/06/2024\r\n🏘️ Hình thức:\r\n- Offline: vào lúc 9h30 tại phòng B1.14\r\n- Online: vào lúc 19h00 tại MS Teams (Code: w2dsy1q)\r\n🙋 Trainer:\r\n- Offline: \r\n+ Tiền Minh Dương - KTPM2023.1\r\n+ Lê Ngô Thanh Toàn - KHMT2023.4\r\n- Online: \r\n+ Tiền Minh Dương - KTPM2023.1\r\n+ Trương Đoàn Vũ - MMTT2022.3\r\n🔥 Cấu trúc rời rạc:\r\n⏰ Thời gian: ngày 13/06/2024\r\n🏘️ Hình thức: \r\n- Online: vào lúc 19h00 tại MS Teams (Code: w2dsy1q)\r\n🙋 Trainer:  \r\n+ Ngô Lê Tấn Huy - MMTT2023.1\r\n+  Nguyễn Tài Tấn - KHMT2023.4\r\n+ Huỳnh Chí Hên - KTPM2023.1\r\n🍀 Các bạn đừng quên note lại lịch train để tham gia cùng chúng mình nhé. Cuối cùng Ban học tập chúc các bạn có một mùa thi thành công, chào hè rực rỡ! 😍😍\r\n➖➖➖➖➖➖➖➖➖➖➖    \r\nMọi thắc mắc liên hệ tại:\r\n 💻Website: https://www.bhtcnpm.com/\r\n💌 Gmail: bht.cnpm.uit@gmail.com\r\n💬 Fanpage: https://www.facebook.com/bhtcnpm\r\n💓 Group BHT NNSC: https://www.facebook.com/groups/bht.cnpm.uit", new DateTime(2023, 5, 19, 0, 40, 52, 616, DateTimeKind.Unspecified).AddTicks(3903), "https://forms.gle/HkCD86Gc9UmTTZLP9", false, false, null, null, "B1.14, MS Teams", 78, null, null, new DateTime(2023, 5, 2, 5, 17, 40, 128, DateTimeKind.Unspecified).AddTicks(1285), "🔔 [THÔNG BÁO LỊCH TRAINING CUỐI Kì K18 HỌC KÌ II 2023 - 2024] 🔔", 6, "Training", 12 },
                    { 58, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "🌼 Chớ âu lo để làm gì?\r\nHè về là ta phải đi thôi\r\nTuổi xuân nào đâu có chờ đợi?\r\n🎶 Giai điệu quen thuộc vang lên chắc hẳn đã khiến các bạn háo hức trông chờ vào kỳ nghỉ hè lắm rồi đúng không nào? Nhưng mà, dừng khoảng chừng vài giây…..Chúng mình còn phải vượt qua kỳ thi Cuối kỳ 2 trước khi “chạm tay đến mùa hè” đấy!\r\n💖 Thấu hiểu được sự bối rối và khó khăn trong ôn tập lượng kiến thức “khổng lồ” cho kỳ thi sắp đến, BHT HTTT tổ chức Training ôn tập kiến thức giúp các bạn có cái nhìn tổng quát về những gì đã học, dễ dàng hệ thống kiến thức và có cơ hội gặp gỡ, trao đổi, chia sẻ kinh nghiệm cùng các bạn Trainer siêu nhiệt huyết đến từ BHT HTTT. \r\n👉 Nhanh tay lưu lại lịch Training và rủ rê bạn bè cùng đến ôn tập và chia sẻ cùng chúng mình nào! Cơ hội giải đáp thắc mắc và gặt hái điểm 10 đang trước mắt bạn đó 😉\r\n--------------------------------------\r\n[LỊCH TRAINING CUỐI KỲ 2 – K18]\r\nCẤU TRÚC DỮ LIỆU VÀ GIẢI THUẬT - IT003\r\n🕐 Thời gian: 2 buổi trong thứ 4, ngày 05/06/2024\r\nBuổi 1: 14h30 - 16h30 (offline)\r\nBuổi 2: 19h00 - 20h30 (online)\r\n🌏 Địa điểm: \r\n+ Offline: phòng B1.18, tòa nhà B, Trường Đại học Công nghệ thông tin\r\n+ Online: MS Teams: du2lo59\r\n👨‍🏫 Trainer:\r\n- Nguyễn Đoàn Thùy Trâm - HTTT2023\r\n- Trần Lê Duy Tân - HTTT2023\r\nLẬP TRÌNH HƯỚNG ĐỐI TƯỢNG - IT002\r\n🕐 Thời gian: 9h00 - 11h00 thứ 5, ngày 06/06/2024\r\n🌏 Địa điểm: phòng B1.18, tòa nhà B, Trường Đại học Công nghệ thông tin\r\n👨‍🏫 Trainer:\r\n- Dương Trọng Toàn - TMĐT2023\r\n- Trần Thị Kiều Trâm - TMĐT2023\r\nXÁC SUẤT THỐNG KÊ - MA005\r\n🕐 Thời gian: 14h30 - 16h30 thứ 5, ngày 06/06/2024\r\n🌏 Địa điểm: phòng B1.18, tòa nhà B, Trường Đại học Công nghệ thông tin\r\n👨‍🏫 Trainer:\r\n- Trần Thế Phong - HTTT2023\r\n- Lương Đắc Nguyên - KHDL2023\r\n- Nguyễn Khánh Vy - TMĐT2023\r\nCẤU TRÚC RỜI RẠC - MA004\r\n🕐 Thời gian: 9h00 - 11h00 thứ 7, ngày 08/06/2024\r\n🌏 Địa điểm: phòng B1.18, tòa nhà B, Trường Đại học Công nghệ thông tin\r\n👨‍🏫 Trainer:\r\n- Đặng Hữu Thọ - HTTT2023\r\n- Trương Dương Hiếu Thảo -  TMĐT2023\r\n--------------------------------------\r\nMọi thắc mắc vui lòng liên hệ: \r\n💌 Email: bhthttt.uit@gmail.com \r\n🌏 Fanpage BHT HTTT: https://www.facebook.com/BHTHTTT", new DateTime(2024, 5, 10, 9, 30, 1, 790, DateTimeKind.Unspecified).AddTicks(5245), "https://forms.gle/HkCD86Gc9UmTTZLP9", false, true, null, null, "phòng B1.18, tòa nhà B, Trường Đại học Công nghệ thông tin", 51, new DateTime(2024, 4, 10, 15, 51, 43, 265, DateTimeKind.Unspecified).AddTicks(1496), null, new DateTime(2024, 4, 15, 7, 51, 53, 164, DateTimeKind.Unspecified).AddTicks(4455), "🎉 [THÔNG BÁO LỊCH TRAINING CUỐI KỲ 2 - K18] 🎉", 2, "Training", 13 },
                    { 59, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "🤔 Bạn muốn có học bổng? Bạn muốn nâng cao điểm số? Bạn muốn nắm vững kiến thức DSA?\r\n💥Vậy thì đừng bỏ lỡ cơ hội tham gia buổi training DSA sắp tới nhé!!!! Tụi mình sẽ đồng hành cùng các bạn đi tới những chân trời kiến thức mới, cùng nhau chinh phục gian nan thử thách để đạt được những  thành tựu thật đáng mong chờ 🫶\r\n👉 Và đừng quên “lôi kéo” thêm những đứa bạn chí cốt của mình nữa nha!\r\n📝Note lịch lại ngay thoaii nè:\r\n-------------------------\r\n📌[LỊCH TRAINING DSA]\r\n🗓️ Thứ 4 - 05/06/2024\r\nOffline:\r\n- Thời gian: 14h30 - 16h30. \r\n- Địa điểm: phòng B1.18\r\nOnline:\r\n- Thời gian: 19h00 - 20h30.\r\n- Địa điểm: MsTeam - du2lo59\r\n-------------------------\r\nMọi chi tiết vui lòng liên hệ:\r\n🌎 Fanpage Facebook: https://www.facebook.com/BHTHTTT\r\n💌 Email: bhthttt.uit@gmail.com", new DateTime(2023, 4, 3, 10, 25, 43, 539, DateTimeKind.Unspecified).AddTicks(7308), "https://forms.gle/HkCD86Gc9UmTTZLP9", false, true, null, null, "MsTeam - du2lo59", 88, new DateTime(2023, 2, 8, 5, 2, 11, 174, DateTimeKind.Unspecified).AddTicks(5266), null, new DateTime(2023, 3, 30, 10, 26, 6, 200, DateTimeKind.Unspecified).AddTicks(7626), "📢 [NHẮC THAM GIA TRAINING CẤU TRÚC DỮ LIỆU VÀ GIẢI THUẬT - DSA] ", 1, "Training", 13 },
                    { 60, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "🤔 Khái niệm về lớp, phạm vi truy xuất, tính kế thừa trong OOP là gì? \r\nVà còn vô vàn những câu hỏi ôn tập cùng bài giảng hệ thống kiến thức khác nữa. \r\nBạn biết nên tìm chúng ở đâu chưa???\r\n🎉 Không còn xa lạ qua những buổi tổ chức Training các kỳ, BHT HTTT đã trở lại để giúp bạn “đối đầu” với Hướng đối tượng khó nhằn này rồi đây!\r\n👉 Tất cả những gì bạn cần làm là nhanh tay lưu lại lịch training, rủ rê bạn bè của mình và chuẩn bị để có một buổi training thật hiệu quả nhé. Các bạn trainer sẽ giải đáp những thắc mắc và hướng dẫn chúng mình cách học hiệu quả nữa đó! 😉\r\n-----------------------------------------------------\r\nLẬP TRÌNH HƯỚNG ĐỐI TƯỢNG - IT002\r\n🕐 Thời gian: 9h00-11h00 thứ 5, ngày 06/06/2024\r\n🌏 Địa điểm: phòng B1.18, tòa nhà B, Trường Đại học Công nghệ thông tin\r\n👨‍🏫 Trainer:\r\nDương Trọng Toàn - TMĐT2023\r\nTrần Thị Kiều Trâm - TMĐT2023\r\n-----------------------------------------------------\r\nMọi thắc mắc vui lòng liên hệ: \r\n💌 Email: bhthttt.uit@gmail.com \r\n🌏 Fanpage BHT HTTT: https://www.facebook.com/BHTHTTT", new DateTime(2024, 3, 26, 15, 18, 9, 1, DateTimeKind.Unspecified).AddTicks(4011), "https://forms.gle/HkCD86Gc9UmTTZLP9", false, false, null, null, "phòng B1.18, tòa nhà B, Trường Đại học Công nghệ thông tin", 49, null, null, new DateTime(2024, 3, 13, 13, 0, 19, 237, DateTimeKind.Unspecified).AddTicks(797), "💐 [NHẮC NHỞ THAM GIA TRAINING LẬP TRÌNH HƯỚNG ĐỐI TƯỢNG] 💐", 2, "Training", 13 },
                    { 61, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "🩷 Các bạn đang loay hoay không biết làm sao có thể thoát ra khỏi mê cung của chu trình Euler và Hamilton? Các bạn đang cảm thấy lạc lõng giữa một lượng kiến thức khổng lồ của đại số Bool? Không sao cả, hãy để các “ngoan xinh iu” đến từ BHT HTTT giúp đỡ các bạn nhé!\r\n⭐ Với buổi training cuối kỳ này, các bạn sẽ được các trainers hệ thống và củng cố lại những kiến thức trọng tâm cũng như cung cấp những mẹo hay để giải quyết bài tập và hình thành sự phản xạ nhanh với các dạng bài có thể được đề cập trong đề.\r\n🎁 Còn ngần ngại gì mà không tham gia buổi training các bạn nhỉ? Và hãy mời thêm bạn bè để cùng nhau ôn tập lại kiến thức và có ngay những kỷ niệm đẹp với các thành viên trong BHT HTTT chúng mình nha!\r\n--------------------------------\r\n[LỊCH TRAINING CẤU TRÚC RỜI RẠC]\r\n🌍 Địa điểm: Phòng B1.18 - Toà nhà B - Trường Đại học Công nghệ Thông tin - Đại học Quốc gia TP.HCM\r\n⏰ Thời gian: Thứ 7 - Ngày 08/06/2024: 9h00 - 11h00 \r\n🧑‍🏫 Trainers:\r\n+ Đặng Hữu Thọ - HTTT2023\r\n+ Trương Dương Hiếu Thảo -  TMĐT2023\r\n--------------------------------\r\n Đừng quên like & follow fanpage BHT HTTT để nhận được những thông báo sớm và mới nhất nhé 😘\r\nMọi thắc mắc vui lòng liên hệ:\r\n 𝑭𝒂𝒏𝒑𝒂𝒈𝒆 𝑭𝒂𝒄𝒆𝒃𝒐𝒐𝒌: https://www.facebook.com/BHTHTTT\r\n 𝑬𝒎𝒂𝒊𝒍: bhthttt.uit@gmail.com", new DateTime(2023, 3, 17, 16, 38, 3, 283, DateTimeKind.Unspecified).AddTicks(4254), "https://forms.gle/HkCD86Gc9UmTTZLP9", false, true, null, null, "Phòng B1.18 - Toà nhà B - Trường Đại học Công nghệ Thông tin - Đại học Quốc gia TP.HCM", 80, new DateTime(2023, 1, 29, 22, 1, 51, 919, DateTimeKind.Unspecified).AddTicks(5532), null, new DateTime(2023, 2, 25, 15, 34, 32, 273, DateTimeKind.Unspecified).AddTicks(3967), "🌻 [NHẮC NHỞ THAM GIA TRAINING CẤU TRÚC RỜI RẠC] 🌻", 6, "Training", 13 },
                    { 62, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "'I'm working late cause my exams won’t….. procrastinate.'\r\n🥹 Cuối cùng, chuỗi Training cuối kỳ II đã kết thúc, BHT HTTT xin chân thành cảm ơn sự quan tâm ủng hộ của các bạn trong thời gian vừa qua. \r\n📌 Trong những buổi training, chúng mình đã cùng nhau ôn lại những kiến thức trọng tâm và rèn luyện các kỹ năng làm bài cần thiết cho kỳ thi cuối kỳ. Đây là một hành trình đầy nỗ lực và sự quyết tâm từ tất cả chúng ta.\r\n📚 Để hỗ trợ các bạn, chúng mình đã chuẩn bị một “món quà” đặc biệt. Đó là Tổng hợp tài liệu ôn tập của BHT: https://tinyurl.com/TaiLieu-BHT-HTTT\r\n🤩 Bây giờ thì chúng mình cùng điểm qua những hình ảnh dễ thương trong mùa training này nha!\r\n-------------------------------------\r\n🥰 Đừng quên like & follow fanpage BHT HTTT để nhận được những thông báo sớm và mới nhất nhé! \r\nMọi thắc mắc vui lòng liên hệ:\r\n𝑭𝒂𝒏𝒑𝒂𝒈𝒆 𝑭𝒂𝒄𝒆𝒃𝒐𝒐𝒌: https://www.facebook.com/BHTHTTT\r\n𝑬𝒎𝒂𝒊𝒍: bhthttt.uit@gmail.com", new DateTime(2024, 2, 10, 0, 36, 16, 401, DateTimeKind.Unspecified).AddTicks(1915), "https://forms.gle/HkCD86Gc9UmTTZLP9", false, true, null, null, "Phòng B1.18 - Toà nhà B - Trường Đại học Công nghệ Thông tin - Đại học Quốc gia TP.HCM", 36, new DateTime(2024, 1, 27, 1, 4, 54, 577, DateTimeKind.Unspecified).AddTicks(2279), null, new DateTime(2024, 2, 9, 18, 8, 45, 309, DateTimeKind.Unspecified).AddTicks(7138), "[TỔNG KẾT CHUỖI TRAINING CUỐI KỲ II & TÀI LIỆU]", 5, "Training", 13 },
                    { 63, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "✨“Không có câu chuyện cổ tích nào đẹp hơn câu chuyện do chính cuộc sống viết ra.” (An-đéc-xen) ✨\r\n🌟 Quả thực, cuộc sống này muôn hình muôn vẻ và mỗi khía cạnh đều có ý nghĩa, vẻ đẹp khác nhau. Và đó cũng là điều mà MGM 2024 hướng đến, chúng mình mong muốn mọi người đều sẽ có cho riêng mình một câu chuyện hạnh phúc từ cuộc sống của họ.\r\n🫂 Tuy nhiên đâu đó ngoài kia, vẫn có những người chưa có được một câu chuyện đẹp trong đời mình, vẫn còn những đứa trẻ chưa có nổi một câu chuyện ấm áp để xây dựng lên tuổi thơ tươi đẹp của riêng chúng. Vì thế, với sứ mệnh cũng như tinh thần cống hiến hết mình cho cuộc sống, chúng mình - MGM 2024 - ở đây để đem những câu chuyện tươi đẹp ấy đến mọi người hay đơn giản là trở thành một mảnh ghép nhỏ trong câu chuyện đang cần trên thế gian này.\r\n❤️‍🩹 Nếu bạn là một người có trái tim ấm áp, bạn mong muốn có thể giúp đỡ những mảnh ghép lẻ loi ngoài kia. Vậy thì chúng mình rất hoan nghênh bạn đến với đại gia đình MGM 2024. Chúng ta sẽ mang những mảnh ghép ý nghĩa để lấp đầy những câu chuyện chưa hoàn thiện của họ và rồi từ đây những câu chuyện đẹp nhất sẽ ra đời.\r\n⭐ Hãy theo dõi thông tin dưới đây để không bỏ lỡ cơ hội trở thành một mảnh ghép của đại gia đình MGM 2024 các bạn nhé. Chúng ta sẽ gặp lại nhau trong thời gian tới, chúng mình rất mong chờ được thấy các bạn đó nha!\r\n📌 THÔNG TIN TUYỂN CHIẾN SĨ:\r\nĐối tượng tham gia: Tất cả sinh viên trên địa bàn Thành phố Hồ Chí Minh\r\nThời gian: Từ 20g00 ngày 19/02/2024 đến 20g00 ngày 26/02/2024\r\nThời gian phỏng vấn: ngày 28/02/2024 và 01/03/2024\r\nThời gian công bố kết quả (dự kiến): 03/03/2024\r\nĐịa bàn hoạt động: Xã Tân Xuân, huyện Ba Tri, tỉnh Bến Tre\r\nThời gian hoạt động tại địa bàn: 05 - 07/04/2024\r\nĐường dẫn đăng ký: https://forms.gle/jLZLBV3L38f8Kkm38\r\n🔥 Các bạn hãy theo dõi Fanpage Chiến dịch Tình nguyện Mảnh Ghép Mới để không bỏ lỡ những thông tin quan trọng từ chương trình, các bạn nhé. Chúng mình vẫn luôn đợi đến ngày được gặp các bạn, nên hãy đến với chúng mình, các bạn nha!\r\n➖➖➖➖➖➖➖➖➖➖➖\r\n☎️ Thông tin liên hệ:\r\n🌐 Fanpage: https://www.facebook.com/CDTNManhGhepMoi.Fanpage\r\n📧 Email: manhghepmoi.uit.ussh@gmail.com\r\n📞 Hotline: \r\n        0343286085 (Trần Thị Mộng Trúc Ngân - Chỉ huy trưởng)\r\n        0937824270 (Võ Thanh Vy - Chỉ huy phó)\r\n        0386441295 (Tô Hoàng Huy - Chỉ huy phó)   ", new DateTime(2023, 2, 2, 5, 55, 25, 386, DateTimeKind.Unspecified).AddTicks(4120), "https://forms.gle/HkCD86Gc9UmTTZLP9", false, false, null, null, "Xã Tân Xuân, huyện Ba Tri, tỉnh Bến Tre", 20, null, null, new DateTime(2023, 1, 23, 20, 42, 58, 346, DateTimeKind.Unspecified).AddTicks(309), "MẢNH GHÉP MỚI 2024 - 📢 MỞ FORM TUYỂN CHIẾN SĨ 📢", 4, "Other", 14 },
                    { 64, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "🏮 Tết Trung thu từ trước đến nay vốn được biết là dịp để mọi người trong gia đình sum họp, quây quần bên nhau. Liệu Trung thu năm nay, bạn có muốn được đồng hành và sát cánh bên một gia đình mới - Đội Event UIT? 🏮\r\n--------------------------------------------------\r\n𝐓𝐇𝐎̂𝐍𝐆 𝐓𝐈𝐍 𝐂𝐇𝐔̛𝐎̛𝐍𝐆 𝐓𝐑𝐈̀𝐍𝐇:\r\n📌 Link đăng ký: https://forms.gle/8n2hZzg8JVx4qgZdA\r\n⌛ Thời gian đăng ký: Từ 20h00 ngày 29/9/2023 - 21h00 ngày 4/10/2023.\r\n👥 Đối tượng: Sinh viên UIT.\r\n⏰ Thời gian phỏng vấn: 8h00 - 16h00 ngày 6-7/10/2023.\r\n🏤 Địa điểm: Phòng B1.04, Trường Đại học Công nghệ Thông tin, ĐHQG - HCM.\r\nEvent vẫn đang chờ những gương mặt mới, còn chần chờ gì mà không điền form đăng ký và tham gia cùng chúng mình nhé!\r\n--------------------------------------------------\r\nMọi thắc mắc xin vui lòng liên hệ:\r\n🌐 Fanpage: facebook.com/UIT.EventTeam\r\n📧 Email: doievent.uit@gmail.com\r\n📞 Hotline: 0828787952 - Nguyễn Duy Tân - Đội trưởng", new DateTime(2024, 1, 26, 10, 47, 50, 848, DateTimeKind.Unspecified).AddTicks(822), "https://forms.gle/HkCD86Gc9UmTTZLP9", false, false, null, null, "Phòng B1.04, Trường Đại học Công nghệ Thông tin, ĐHQG - HCM", 37, null, null, new DateTime(2024, 1, 7, 23, 17, 11, 382, DateTimeKind.Unspecified).AddTicks(3479), "📢 [𝐄𝐕𝐄𝐍𝐓 𝐔𝐈𝐓| 𝐓𝐔𝐘𝐄̂̉𝐍 𝐓𝐇𝐀̀𝐍𝐇 𝐕𝐈𝐄̂𝐍]", 1, "Other", 14 },
                    { 65, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "💕 Một phiên bản mở đầu đầy hấp dẫn, hứa hẹn cho những chuỗi sự kiện, chương trình đầy thú vị sắp tới của Đội Event.\r\n𝗧𝗛𝗢̂𝗡𝗚 𝗧𝗜𝗡 𝗖𝗛𝗨̛𝗢̛𝗡𝗚 𝗧𝗥𝗜̀𝗡𝗛:\r\n⏰ Thời gian: Từ ngày 14/09/2023 - 21/09/2023.\r\n💏 Đối tượng: Sinh viên Trường Đại học Công nghệ Thông tin, ĐHQG-HCM.\r\n📌 𝗖𝗔́𝗖𝗛 𝗧𝗛𝗨̛́𝗖 𝗧𝗛𝗔𝗠 𝗚𝗜𝗔:\r\n1️⃣ Like và follow Fanpage Đội Event - UIT.\r\n2️⃣ Like + Share bài viết ở chế độ công khai kèm hashtag #EventUIT.\r\n3️⃣ Chụp màn hình và điền form dưới đây để làm minh chứng bạn đã tham gia chương trình nhé.\r\n👉 Form minh chứng: https://bit.ly/EventQuizz\r\nHãy cùng tham gia “𝗜𝘁’𝘀 𝘁𝗶𝗺𝗲 𝘁𝗼 𝗸𝗻𝗼𝘄” để lấy những “điểm rèn luyện” đầu tiên của năm học nào. ", new DateTime(2023, 1, 18, 15, 40, 16, 309, DateTimeKind.Unspecified).AddTicks(7525), "https://forms.gle/HkCD86Gc9UmTTZLP9", false, true, null, null, "Online", 64, new DateTime(2022, 11, 16, 23, 52, 1, 925, DateTimeKind.Unspecified).AddTicks(1437), null, new DateTime(2022, 12, 22, 1, 51, 24, 418, DateTimeKind.Unspecified).AddTicks(6650), "🌼 [𝗜𝗧’𝗦 𝗧𝗜𝗠𝗘 𝗧𝗢 𝗞𝗡𝗢𝗪] 🌼", 3, "Other", 14 },
                    { 66, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "💓Các UITer của chúng mình ơi, không biết những hoạt động vừa qua có đem đến những điều thú vị và hấp dẫn cho các bạn không nè?\r\n✨Bên cạnh những điều đó thì hôm nay chúng mình lại đem đến một sân chơi vô cùng náo nhiệt và lôi cuốn cho các bạn này. \r\n🤫Chương trình lần này sẽ được gọi tên là “SongkRun in UIT”, được lấy cảm hứng từ một chủ đề rất đặc biệt “Lễ hội té nước SongkRan của Thái Lan” kết hợp cùng với đường chạy sắc màu “Color Me Run”.\r\n📌Chúng mình xin bật mí một chút xíu về trò chơi này nhé. Chương trình sẽ chia làm 2 dạng trò chơi là trò chơi nước và trò chơi màu với kiểu hoạt động sẽ là “Chạy trạm”. Nào nào, hồi hộp chưa?\r\n📚Dưới đây là một số thông tin chi tiết\r\n🏃Đường chạy SongkRun in UIT chỉ dành riêng cho K15, K16 và K17\r\n💢Link đăng ký Online: bit.ly/DangKySongKrunUIT\r\n✨ Các bạn có thể đăng ký offline tại sảnh C từ 11h30 - 1h30 (Từ ngày 13/10/2022).✨\r\n🔔 Thể lệ chương trình\r\n🔺 Mỗi team sẽ có 5 thành viên, các bạn có thể đăng ký theo đội (Nếu đăng ký lẻ thì BTC sẽ sắp xếp).\r\n🔺Phí tham gia: 120.000VNĐ/người (Team 5 người 600.000 VNĐ). 5 Team đăng ký và hoàn thành lệ phí đầu tiên sẽ được giảm còn 500.000VNĐ/team.\r\n💸Hoàn thành lệ phí tại bàn đăng ký đăng ký offline để nhận ngay cho mình một chiếc vé cùng chiếc áo đường chạy cực chất.\r\n💓Các giải thưởng hấp dẫn:\r\n💠 Giải Nhất: 1.500.000VNĐ \r\n💠 Giải Nhì: 1.200.000VNĐ\r\n💠 Giải Ba: 1.000.000VNĐ\r\n👉 Ngoài ra, các đội hoàn thành được công nhận tiêu chí “Thể lực tốt” của “Sinh viên 5 tốt”\r\n💢Hứa hẹn những gì mà chúng mình đem lại sẽ cho bạn một sân chơi  “đầy tỏa sáng” và “cháy hết mình”.\r\n🌷Còn chần chừ gì nữa? Biết đâu các bạn sẽ tìm được “mai - đẹt - ti - ni” của đời mình qua chương trình này đó.\r\n❗Mau mau đăng ký nhanh thôi❗️", new DateTime(2023, 12, 11, 20, 32, 41, 771, DateTimeKind.Unspecified).AddTicks(4228), "https://forms.gle/HkCD86Gc9UmTTZLP9", false, false, null, null, "UIT", 72, null, null, new DateTime(2023, 12, 6, 4, 25, 37, 454, DateTimeKind.Unspecified).AddTicks(9821), "🌿Tham gia kẻo lỡ đèn xanh\r\nĐi đi kẻo lỡ trò chơi bây giờ🌿", 1, "Other", 14 },
                    { 67, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Đừng quên chúng ta có cuộc hẹn vào ngày mai!!!\r\n💥Ngày cuối cùng cho các bạn BOOK NGAY 1 VÉ ĐĂNG KÍ ĐỂ HOÀN THÀNH TIÊU CHÍ HỌC TẬP TỐT CHO DANH HIỆU SINH VIÊN 5 TỐT.\r\n👉Tất cả các bạn làm được 4/6 bài sẽ được công nhận tiêu chí học tập tốt\r\n👉Top 3 bạn giải nhiều bài và nhanh nhất\r\n🥇Top 1: 1 chiếc balo UIT 15 năm\r\n🥈Top 2: 500.000 VNĐ\r\n🥉Top 3: 300.000 VNĐ\r\n📌Thông tin chi tiết📌\r\n📍 Thời gian thi: 8h00 - 13h00 ngày 11/06/2022\r\n🧑‍💻Đối tượng: sinh viên UIT\r\n💻Hình thức thi : Hệ thống wecode - Trực tuyến\r\n🎫Phí đăng ký dự thi: 10k/sinh viên\r\n📌Link đăng ký: https://forms.gle/GrARBrwkMs4ttpiS6\r\nHình thức thanh toán: momo hoặc đóng trực tiếp tại sảnh C (10h30 - 13h30 từ 8/6 - 10/6)", new DateTime(2022, 12, 3, 13, 59, 8, 628, DateTimeKind.Unspecified).AddTicks(5190), "https://forms.gle/HkCD86Gc9UmTTZLP9", false, false, null, null, "B4.14", 89, null, null, new DateTime(2022, 11, 19, 6, 59, 50, 491, DateTimeKind.Unspecified).AddTicks(2991), "CODE CHALLENGE", 3, "Other", 14 },
                    { 68, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "‼️ Đúng vậy, Seminar “Get Ready For Your Gaming Career Path” do công ty Gameloft và CLB UIT GamApp Studios phối hợp tổ chức sẽ diễn ra trong ngày mai (07/06/2024).\r\n✨ Đến với seminar, các bạn sẽ được học hỏi kinh nghiệm vào ngành từ diễn giả có thâm niên trong nghề – anh Nguyễn Anh Tuấn. Bên phía công ty còn dành ra một số phần quà cho các bạn tham gia tích cực trong buổi seminar nữa đó.\r\n👀 BTC cũng bật mí cho các bạn rằng sẽ có THÔNG TIN về 1 CHƯƠNG TRÌNH HỖ TRỢ DỰ ÁN do Gameloft tổ chức tại buổi seminar. Nếu các bạn có ý tưởng cho dự án riêng nhưng thiếu hậu thuận thì đây là 1 CƠ HỘI không thể bỏ lỡ.\r\n🔥 Nhanh chân lên nào các bạn ơi, seminar sắp diễn ra rồi!!!\r\n ——————————————————\r\n       THÔNG TIN CHI TIẾT VỀ SEMINAR:\r\n⏰ Thời gian: 9h45, thứ 6 ngày 7/6/2024.\r\n📍 Địa điểm: Hội trường E, tầng 12 tòa E, trường Đại học Công nghệ Thông tin.\r\n🎤 Diễn giả: Anh Nguyễn Anh Tuấn – Programmer Division Lead at Gameloft.\r\n📌 Link đăng ký: https://tinyurl.com/seminar-grfygcp\r\n🕤 Thời gian đăng ký: từ ngày 29/05/2024.\r\n——————————————————\r\nMọi thắc mắc liên hệ tại:\r\n 💻 Official Page: https://www.facebook.com/UITGamAppStudios\r\n 📩 Gmail: gamappuit.club@gmail.com", new DateTime(2023, 11, 26, 11, 49, 2, 721, DateTimeKind.Unspecified).AddTicks(6296), "https://forms.gle/HkCD86Gc9UmTTZLP9", false, true, null, null, "Hội trường E, tầng 12 tòa E, trường Đại học Công nghệ Thông tin", 93, new DateTime(2023, 9, 7, 17, 39, 5, 490, DateTimeKind.Unspecified).AddTicks(5597), null, new DateTime(2023, 11, 3, 9, 34, 3, 527, DateTimeKind.Unspecified).AddTicks(6162), "💫 [GAMELOFT] SEMINAR SẮP DIỄN RA RỒI!!! CÁC GAME DEVELOPER ƠI!!! 💫", 6, "Seminar", 15 },
                    { 69, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "🤔  Bạn cần tìm một nơi:\r\n👉 Giao lưu, trao đổi kiến thức, phát triển kỹ năng và phát triển đam mê trong hoạt động phát triển sản phẩm ứng dụng.\r\n👉 Quảng bá rộng rãi những sản phẩm ứng dụng có hiệu quả sử dụng tốt do chính bạn thực hiện đến cộng đồng.\r\n😉 Vậy thì “Cuộc thi phát triển ứng dụng sinh viên - SEApp2024” chính là dành cho bạn đó. \r\n🌟 Thông tin chi tiết cuộc thi:\r\n⏰ Thời gian - địa điểm:\r\n- Từ tháng 03 đến tháng 06 năm 2024.\r\n- Địa điểm: Trường ĐH Công nghệ Thông tin, ĐHQG TP. HCM.\r\n👩‍🎓 Yêu cầu: Sinh viên thực hiện sản phẩm là các ứng dụng có tính ứng dụng hoặc tính khoa học, nhằm mang lại lợi ích cho người sử dụng và có thể download, cài đặt trên các thiết bị di động (mobile app) hoặc các ứng dụng có thể được truy cập thông qua Internet (web app, website).\r\n👩‍🎓 Đối tượng tham gia:\r\n- Sinh viên khoa Công nghệ Phần mềm hoặc sinh viên các khoa khác (thuộc ĐH Công nghệ Thông tin) có quan tâm và được ban Tổ chức đồng ý.\r\n- Sinh viên các khoa khác (thuộc ĐH Công nghệ Thông tin) có quan tâm và được ban Tổ chức đồng ý.\r\n📌 Hình thức đăng ký: \r\n- Đăng ký qua form sau: https://tinyurl.com/SEApp2024\r\n- Thời gian: Từ 20/03 đến 31/03/2024.\r\n- Số lượng thành viên của đề tài: tối thiểu 01 thành viên, tối đa 06 thành viên.\r\n➖➖➖➖➖➖➖➖➖         \r\n📅 Các mốc thời gian liên quan:\r\n- Tuần 01 – 02 (Từ 20/03 đến 31/03/2024): Mở form đăng ký.\r\n- Tuần 03 – 11 (Từ 01/04 – 02/06/2024): Sinh viên đăng ký tiến hành hoàn thiện ứng dụng và tải ứng dụng lên CHPlay/AppStore của Khoa.\r\n- Tuần 12 (Tuần 03/06/2024): Hội đồng của Khoa đánh giá và công bố các sản phẩm được triễn lãm.\r\n- Tuần 13 (Tuần 10/06/2024): Chuẩn bị và tổ chức triển lãm các ứng dụng được chọn. Người dùng trải nghiệm sử dụng sản phẩm và đánh giá.\r\n- Tuần 14 (Tuần 17/06): Tính điểm, công bố sản phẩm đoạt giải và trao thưởng.\r\n✅ Tiêu chí đánh giá\r\n- Tính khoa học và giá trị ứng dụng thực tiễn: 50%.\r\n- Tính hoàn thiện: 20%.\r\n- Tính thân thiện, dễ sử dụng và trải nghiệm người dùng: 20%.\r\n- Trình bày báo cáo và kết quả: 10%.\r\n💯 Cách tính điểm (cho các sản phẩm được chọn triển lãm)\r\n- Like share trên Facebook: 20%.\r\n- Lượt vote qua form: 20%.\r\n- Điểm từ BGK: 60%.\r\n🎁 Giải thưởng:\r\n👉 Giải thưởng dành cho ứng dụng: bao gồm hiện kim, giấy khen và quà tặng.\r\n- 01 giải Nhất: 5.000.000 VNĐ.\r\n- 01 giải Nhì: 2.000.000 VNĐ.\r\n- 02 giải Ba: 1.000.000 VNĐ.\r\n- 03 giải Khuyến khích: 500.000 VNĐ.\r\n- 01 giải có lượt download nhiều nhất: 500.000 VNĐ.\r\n- 01 giải có lượt like/ share nhiều nhất: 500.000 VNĐ.\r\n👉 Giải thưởng dành cho khán giả:\r\n- 01 giải Bình chọn chính xác nhất: 500.000 VNĐ.\r\n- 01 giải Rút thăm may mắn trong ngày tổ chức triển lãm: 200.000 VNĐ.\r\nCòn chần chờ gì mà không tham gia ngay thôi nào!", new DateTime(2022, 10, 19, 11, 9, 58, 156, DateTimeKind.Unspecified).AddTicks(4337), "https://forms.gle/HkCD86Gc9UmTTZLP9", false, false, null, null, "Trường ĐH Công nghệ Thông tin, ĐHQG TP. HCM", 43, null, null, new DateTime(2022, 10, 17, 12, 8, 16, 563, DateTimeKind.Unspecified).AddTicks(9333), "📣 [CUỘC THI PHÁT TRIỂN ỨNG DỤNG SINH VIÊN ĐỢT 1 NĂM 2024 - SEApp2024] 📣", 3, "Other", 15 },
                    { 70, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "CLB UIT GamApp Studio xin thông báo buổi học đầu tiên của project Game Gen3 sẽ bắt đầu vào:\r\n- Địa điểm: phòng B1.22\r\n- Thời gian: chiều thứ 7 hàng tuần, từ 13h15 - 14h30 (lớp Nhập môn) và từ 14h30-16h (lớp Nâng cao).\r\nMọi kênh thông tin liên lạc như group và group chat đã được gửi qua email đã đăng ký. Các bạn vui lòng kiểm tra hòm thư để nắm được thông tin từ CLB nhé!\r\nHẹn gặp lại các bạn vào ngày mai!", new DateTime(2023, 10, 12, 16, 2, 23, 618, DateTimeKind.Unspecified).AddTicks(1039), "https://forms.gle/HkCD86Gc9UmTTZLP9", false, false, null, null, "phòng B1.22", 60, null, null, new DateTime(2023, 10, 1, 14, 42, 29, 600, DateTimeKind.Unspecified).AddTicks(2503), "CLB UIT GamApp Studio xin thông báo buổi học đầu tiên của project Game Gen3", 5, "Training", 15 },
                    { 71, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Hoạt động 1: “Phiêu lưu cùng dòng chữ lịch sử”\r\n🔔 THÔNG BÁO KẾT THÚC THỜI GIAN NHẬN BÀI - CHÍNH THỨC MỞ CỔNG BÌNH CHỌN 🔔\r\n💨 Sau một tuần phát động, BTC đã nhận được rất nhiều bài dự thi vô cùng tiềm năng. Mỗi bài viết đều mang một màu sắc riêng biệt, thể hiện cá tính riêng không lẫn với bất kỳ ai.", new DateTime(2022, 10, 4, 5, 18, 45, 0, DateTimeKind.Unspecified).AddTicks(9611), "https://forms.gle/HkCD86Gc9UmTTZLP9", false, true, null, null, "sảnh C, trường Đại học Công nghệ Thông tin – ĐHQG TPHCM", 41, new DateTime(2022, 8, 27, 4, 32, 18, 496, DateTimeKind.Unspecified).AddTicks(2992), null, new DateTime(2022, 9, 14, 17, 16, 42, 636, DateTimeKind.Unspecified).AddTicks(5674), "HỘI SÁCH 2024 - Lịch sử: Trang sách và hành trình", 4, "Workshop", 16 },
                    { 72, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Hành trình lan tỏa yêu thương, tạo nên dấu ấn vĩnh cửu trong hồi ức của người khác.\r\n🌟 TỦ SÁCH ƯỚC MƠ -  một chặng đường đầy ý nghĩa và lan tỏa yêu thương. Mỗi bước đi nhỏ, mỗi đôi tay giúp đỡ và mỗi nụ cười trao đi, chúng ta đã tạo ra những dấu ấn vĩnh cửu trong lòng những người gặp gỡ. \r\n💬 Hai ngày 13/04 và 14/04 vừa qua, thành viên của CLB Sách và Hành Động các trường UIT, UEL và Nông Lâm đã có dịp ghé qua những địa điểm đặc biệt: Mái ấm Tân Bình, Làng thiếu niên Thủ Đức, Nhà trẻ mồ côi Diệu Giác. Ban đầu có vẻ bối rối do còn chút lạ lẫm, dần chúng mình đã thân thiết với nhau hơn sau các hoạt động giao lưu. Không khí hôm ấy đã rất sôi nổi và hạnh phúc.\r\n🌱 Kệ sách đã được bố trí đầy đủ, tất cả loại sách, từ tài liệu học tập đến những quyển truyện tranh đã được bày lên. Hy vọng sự quyên góp nhỏ bé này có thể đem lại một kho kiến thức mới cho các em. Hình ảnh các bé đọc sách, vui chơi hôm ấy là một cảnh tượng ý nghĩa khó quên của chúng mình.\r\n💌 Cảm ơn các bạn sinh viên đã ủng hộ chương trình TỦ SÁCH ƯỚC MƠ. Cảm ơn Mái ấm Tân Bình, Làng thiếu niên Thủ Đức, Nhà trẻ mồ côi Diệu Giác đã nhiệt tình chào đón và hướng dẫn chúng em. Chúc mọi người luôn khỏe mạnh, may mắn và hãy cùng nhau lan tỏa tinh thần yêu thương này nhé.\r\n➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖\r\n📍 THÔNG TIN CHI TIẾT VỀ CHƯƠNG TRÌNH:\r\n📚 Hoạt động 1: “Thương”\r\n⏰ 21/03/2024 – 23/03/2024: \r\n+ Nhận sách cũ tại sảnh C của UIT.\r\n+ Bán vé số gây quỹ với giá 5.000đ/vé.\r\n🎁 Cơ cấu giải thưởng:\r\n+ 1 Giải nhất: 250.000đ\r\n+ 2 Giải nhì: 150.000đ\r\n+ 2 Giải ba: 100.000đ\r\n🏆 Ngày công bố kết quả: 08/04/2024 tại Fanpage CLB Sách và Hành động UIT.\r\nMỗi tờ vé số bạn mua sẽ góp phần vào việc xây dựng một cộng đồng nhân ái và mang lại nụ cười cho các bé.\r\nSinh viên quyên góp 1 quyển sách sẽ được cộng vào điểm rèn luyện.\r\nVới mỗi quyển sách quyên góp thêm, sinh viên sẽ được tặng lại 1 món quà nhỏ từ phía BTC.\r\n🏩 Hoạt động 2: “Kết”\r\n+ 13/04/2024 : Hoạt động hỗ trợ tại Mái ấm Tân Bình và Làng thiếu niên Thủ Đức.\r\n+ 14/04/2024: Hoạt động hỗ trợ tại Nhà nuôi dạy trẻ mồ côi Diệu Giác.\r\n❗️ Lưu ý:\r\n+ Sách phải có giá trị sử dụng, giá trị thẩm mỹ và mang tính giáo dục.\r\n+ Phù hợp với độ tuổi từ 6 đến 18 tuổi.", new DateTime(2023, 9, 28, 1, 47, 14, 541, DateTimeKind.Unspecified).AddTicks(4445), "https://forms.gle/HkCD86Gc9UmTTZLP9", false, true, null, null, "sảnh C của UIT", 77, new DateTime(2023, 8, 24, 9, 21, 50, 244, DateTimeKind.Unspecified).AddTicks(4478), null, new DateTime(2023, 8, 29, 19, 50, 55, 672, DateTimeKind.Unspecified).AddTicks(8845), "📖 TỦ SÁCH ƯỚC MƠ - GIEO HẠNH PHÚC, THU NHẬN YÊU THƯƠNG 📖", 3, "Other", 16 },
                    { 73, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "⏳Chú ý! Chú ý! … Thời gian còn 1 ngày ⏳\r\n⏰Chỉ còn chưa đầy 24 giờ nữa, link đăng ký tham gia 𝐔𝐈𝐓 𝐒𝐏𝐑𝐈𝐍𝐆 𝐒𝐓𝐑𝐈𝐃𝐄 𝟐𝟎𝟐𝟒 sẽ tiến hành đóng lại. Vậy thì còn chần chờ gì mà không nhanh tay điền đơn tham gia 𝐔𝐈𝐓 𝐒𝐏𝐑𝐈𝐍𝐆 𝐒𝐓𝐑𝐈𝐃𝐄 𝟐𝟎𝟐𝟒 để cùng chúng mình chinh phục những mục tiêu đầy thú vị phía trước nhỉ? \r\n➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖\r\n📍 THÔNG TIN CHI TIẾT VỀ SPRING STRIDE:\r\n🏃‍♂️ Giải chạy ảo UIT SPRING STRIDE 2024 là giải chạy ảo thường niên do CLB Sách và Hành động UIT tổ chức, là chương trình tiếp nối cho UIT Run Over Yourself, UIT JUMPSTART 2022, UIT DYNAMIC YOUTH 2022 với mục tiêu tạo ra sân chơi lành mạnh cho những người có sở thích chạy bộ nói chung và các bạn sinh viên nói riêng; bên cạnh đó, người tham gia sẽ hình thành được thói quen rèn luyện sức khỏe, vượt qua bản thân, chinh phục những thử thách.\r\n☑️ Hình thức đăng ký:\r\n1. Đăng ký qua form: https://rg.link/xEeZe\r\n2. Đăng ký trực tiếp tại tầng 1 toà B: 9h - 15h, từ ngày 20/02/2024 đến 23/02/2024.\r\n❗️ Thời gian đăng ký: Từ ngày 19/02/2024 đến 23h59p ngày 25/02/2024.\r\n❗️ Thời gian diễn ra: Từ ngày 20/02/2024 đến 23h59p ngày 05/03/2024.\r\n☑️ Lệ phí tham gia: 25.000đ (Cá nhân) và 100.000đ (Nhóm 5 người)\r\n☑️ Cách thức: thông qua ứng dụng Strava và nghienchaybo:\r\nQuãng đường đăng ký tối thiểu: 30km-VĐV Nam; 25km-VĐV Nữ\r\nTốc độ trung bình: 4 phút/km – 15 phút/km (tốc độ này có thể đi bộ)\r\n➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖\r\nMọi thắc mắc xin liên hệ:\r\n📩 Email: clb.sachvahanhdong.uit@gmail.com\r\n📌 Fanpage: CLB Sách Và Hành Động UIT\r\n☎️ Mr. Hồng Phát: 098 1503 265\r\n☎️ Ms. Mai Linh: 038 5038 142\r\n☎️ Mr. Thiên Bảo: 091 6524 021\r\n- Câu lạc bộ Sách và Hành động UIT -\r\n✨ Trung thực ✨\r\n✨ Hành động ✨\r\n✨ Kỷ luật ✨\r\n✨ Không bỏ cuộc ✨", new DateTime(2022, 8, 20, 6, 39, 40, 3, DateTimeKind.Unspecified).AddTicks(1147), "https://forms.gle/HkCD86Gc9UmTTZLP9", false, false, null, null, "Khu đô thị ĐHQG TPHCM", 31, null, null, new DateTime(2022, 8, 12, 22, 25, 8, 709, DateTimeKind.Unspecified).AddTicks(2015), "🏃‍♂️𝐒𝐏𝐑𝐈𝐍𝐆 𝐒𝐓𝐑𝐈𝐃𝐄 - NHẮC NHỞ CÒN 24 GIỜ ĐĂNG KÝ 🏃‍♂️", 1, "Other", 16 },
                    { 74, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "👥 TỔNG KẾT VÒNG 3: 'TEAM BUILDING' 👥\r\n🎬 Cuối cùng chương trình tuyển CTV GEN 7.0 cũng đã chính thức khép lại. BAIT xin chân thành cảm ơn tất cả các bạn đã dành thời gian để tham gia cùng tụi mình.\r\n🌅 Tuy thời tiết chiều hôm ấy không đẹp, nhưng chúng ta đã có những khoảnh khắc tuyệt vời cùng nhau! Tụi mình cảm thấy thật may mắn khi đã tìm ra được những mảnh ghép mới phù hợp trong rất nhiều ứng cử viên tiềm năng. Mong rằng chúng ta sẽ đồng hành với nhau lâu nhất có thể để có thể cùng tạo ra nhiều kỉ niệm đẹp trong bức tranh thanh xuân của mình.\r\n🌼 Những bạn chưa thể đồng hành cùng tụi mình cũng xin hãy đừng buồn, có lẽ cánh cửa này chưa phải nơi phù hợp nhất với bạn. Tụi mình hi vọng bạn sẽ sớm tìm được nơi phù hợp nhất với bản thân và tiếp tục nỗ lực trong hành trình mới sắp tới.\r\n🎥 Trong chương trình vừa qua nếu có vấn đề thiếu sót, mong mọi người thông cảm và có thể góp ý cho chúng mình thông qua thông tin liên hệ bên dưới đây nhé.\r\n💕 Một lần nữa xin cảm ơn vì đã tích cực hưởng ứng và mong cho mọi điều tốt đẹp sẽ đến với tất cả mọi người!\r\n— — — — — —\r\n🔎 THÔNG TIN CHI TIẾT VỀ CHƯƠNG TRÌNH:\r\n📧 Vòng 1: Điền Form\r\n👥 Đối tượng: Tất cả sinh viên đang học tập tại địa bàn TP.HCM, những bạn có sở thích đọc và muốn lan tỏa ý nghĩa của từng trang sách thông qua văn hóa đọc.\r\n🕰️ Thời gian: 2/10 - 8/10/2023\r\n➡️ Link form: https://s.net.vn/lTCU \r\n----\r\n🗣 Vòng 2: Phỏng Vấn\r\n🕰️ Thời gian: 10/10 - 12/10/2023\r\n🏠 BAIT sẽ gửi cho các bạn thời gian, địa điểm để chúng ta có thể gặp gỡ và trò chuyện trực tiếp với nhau.\r\n----\r\n🎲 Vòng 3: Team Building\r\n🕰️ Thời gian: 17/10/2023\r\n— — — — — —\r\nMọi thắc mắc xin liên hệ:\r\n📩 Email: clb.sachvahanhdong.uit@gmail.com \r\n📌 Fanpage: CLB Sách Và Hành Động UIT\r\n☎️ Mr. Gia Khiêm: 096 4078 132\r\n☎️ Ms.Thùy Dương: 034 9414 587\r\n☎️ Mr. Thanh Sang: 038 5350 187\r\n- Câu lạc bộ Sách và Hành động UIT -\r\n✨ Trung thực ✨\r\n✨ Hành động ✨\r\n✨ Kỷ luật ✨\r\n✨ Không bỏ cuộc ✨", new DateTime(2023, 8, 13, 11, 32, 5, 464, DateTimeKind.Unspecified).AddTicks(7850), "https://forms.gle/HkCD86Gc9UmTTZLP9", false, true, null, null, "Teams", 69, new DateTime(2023, 6, 18, 5, 13, 12, 621, DateTimeKind.Unspecified).AddTicks(3918), null, new DateTime(2023, 7, 28, 0, 59, 21, 745, DateTimeKind.Unspecified).AddTicks(5186), "TUYỂN CTV GEN 7.0 - NGỠ", 2, "Other", 16 },
                    { 75, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "📍 Thông tin MINIGAME:\r\n⏳ Thời gian: 06/10 - 08/10 (23h59')\r\n👥 Đối tượng: Tất cả các bạn sinh viên UIT\r\n🎲 Thể lệ tham gia:\r\nBước 1: Like fanpage CLB Sách và Hành động UIT, react và share bài viết này ở chế độ công khai\r\nBước 2: Comment câu trả lời đúng\r\nBước 3: Chọn 1 con số may mắn từ 1 - 999 và tag 03 người bạn cùng chơi nhé\r\nBước 4: Điền form kèm ảnh chụp cmt để chúng mình ghi nhận kết quả và tính điểm rèn luyện nhé\r\nLink form:  https://forms.gle/fWSNYNUjM3bnRuU56\r\n🎁 Giải thưởng:\r\n▶️ 1 Giải nhất: Sách A-Z kiến thức nghề lập trình cho người mới bắt đầu\r\n▶️ 1 Giải nhì: Sách Không Diệt Không Sinh Đừng Sợ Hãi\r\n📦 CÁCH THỨC TÍNH GIẢI: BTC sẽ tiến hành quay số may mắn và chọn ra 2 bạn may mắn nhất để trao giải.\r\n— — — — — — — —\r\n⛳ Ngay bây giờ, hãy trả lời nhanh 8 câu hỏi sau và rinh quà về tay nào!\r\n1. Tên viết tắt của CLB Sách và Hành động UIT là gì?\r\n2. Hoạt động lớn nhất được CLB tổ chức vào tháng 5 hằng năm là gì?\r\n3. Loại hình hoạt động lần sinh nhật gần nhất CLB đã tổ chức là gì?\r\n4. Hoạt động chia sẻ được tổ chức nội bộ bởi thành viên CLB là gì?\r\n5. Tiêu chí đầu tiên trong 4 giá trị cốt lõi của Sách và Hành động UIT là gì?\r\n6. Tên của Chủ nhiệm hiện tại?\r\n7. Hoạt động thiện nguyện vừa được CLB tổ chức là gì?\r\n8. Năm thành lập của CLB Sách và Hành Động? \r\n🙋 Hy vọng sau minigame này BAIT có thể được nhiều sự quan tâm hơn nữa trong sự kiện “Tuyển CTV Gen 7.0 - NGỠ”.", new DateTime(2022, 8, 5, 16, 24, 30, 926, DateTimeKind.Unspecified).AddTicks(4554), "https://forms.gle/HkCD86Gc9UmTTZLP9", false, true, null, null, "Online", 25, new DateTime(2022, 6, 14, 3, 8, 53, 809, DateTimeKind.Unspecified).AddTicks(8639), null, new DateTime(2022, 7, 11, 3, 33, 34, 781, DateTimeKind.Unspecified).AddTicks(8357), "🎲 MINIGAME CÙNG BAIT 🎲", 1, "Other", 16 },
                    { 76, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "皆さん、注目してください！\r\nBuổi sinh hoạt đầu tiên trong năm của Wakame, đồng thời là buổi đầu tiên do ban chủ nhiệm K5 tổ chức sắp diễn ra rồi. Mọi người có thấy hào hứng không nào😳?\r\nXin phép được bật mí, chủ đề của buổi sinh hoạt lần này là Ohanami - お花見🌸, một loại hình văn hoá rất đặc trưng của Nhật vào mỗi dịp xuân về. Đến với buổi sinh hoạt lần này, các bạn sẽ được tìm hiểu thêm về văn hoá ngắm hoa anh đào thông qua các từ vựng, trò chơi giải đố,... và cả những phần quà hấp dẫn(?) Mau mau đặt một cái hẹn đến với buổi sinh hoạt thoi nào!", new DateTime(2023, 6, 28, 18, 28, 15, 466, DateTimeKind.Unspecified).AddTicks(5137), "https://forms.gle/HkCD86Gc9UmTTZLP9", false, false, null, null, "phòng B3.16, toà nhà B, trường Đại học Công nghệ Thông tin UIT", 83, null, null, new DateTime(2023, 6, 25, 6, 7, 47, 818, DateTimeKind.Unspecified).AddTicks(1528), "WAKAME UIT - THÔNG BÁO TỔ CHỨC SINH HOẠT CÂU LẠC BỘ", 4, "Other", 17 },
                    { 77, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "✌️みなさん、こんにちは！！！\r\nChỉ còn 2 tuần nữa thoi, năm 2023 sẽ kết thúc, báo hiệu thời khắc chuyển giao thế hệ đang đến rất gần. Câu lạc bộ Tiếng Nhật UIT - WAKAME chúng mình cũng không phải ngoại lệ. Trong thời gian tới, ban chủ nhiệm thế hệ K4 sẽ dần lui về sau hậu trường sau 1 năm nhiệt huyết cống hiến tuổi thanh xuân 😱\r\nTuy nhiên, những 'mầm xanh 🌱' mà các anh chị K4 đã chăm sóc trong thời gian qua - thế hệ K5, sắp tới sẽ kế thừa những 'di sản' (không kém phần wibu 👀) mà anh chị để lại. Nhằm đánh dấu cho sự kiện quan trọng này, và cũng là để thông báo cho mọi người cùng biết, Wakame xin phép được tổ chức đại hội giao ban 🥳", new DateTime(2022, 6, 20, 16, 18, 9, 559, DateTimeKind.Unspecified).AddTicks(6241), "https://forms.gle/HkCD86Gc9UmTTZLP9", false, false, null, null, "phòng B3.14, toà nhà B, trường Đại học Công nghệ Thông tin UIT", 100, null, null, new DateTime(2022, 6, 8, 8, 42, 0, 854, DateTimeKind.Unspecified).AddTicks(4698), "THÔNG BÁO: TỔ CHỨC ĐẠI HỘI", 6, "Conference", 17 },
                    { 78, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "🫵 Phát hiện nhiều đối tượng lén lút tải nhiều tài liệu tiếng Nhật về để đó không học 🫵 \r\nĐể tránh cho bạn và tôi cùng nhau lãng phí thời gian như tình huống trên, chúng tôi quyết định giới thiệu một chương trình tuyệt cả là vời và vô cùng bổ ích nhằm tạo cơ hội để bạn có thể “rửa tài liệu”, sớm ngày chinh phục đỉnh cao Nhật ngữ 🌪️\r\n💁‍♂️ Và chương trình đó chính là ✨THI THỬ TIẾNG NHẬT JLPT✨\r\nNội dung bài thi sẽ xoay quanh kiến thức về từ vựng, ngữ pháp, cụ thể là đánh giá kỹ năng nghe và đọc hiểu của người tham gia. Ngoài việc được trải nghiệm môi trường thực tế của một buổi thi tiếng Nhật với chi phí hạt dẻ, các thí sinh còn có khả năng nhận được giấy chứng nhận Hội nhập tốt để xét danh hiệu “Sinh viên 5 tốt” và mang hiện kim về nhà khoe mẹ. \r\n🫰 Sự kiện thú vị này đã mở cổng đăng ký, còn chần chừ gì nữa mà không tham gia nào 🫰", new DateTime(2023, 6, 14, 7, 1, 47, 311, DateTimeKind.Unspecified).AddTicks(4662), "https://forms.gle/HkCD86Gc9UmTTZLP9", false, true, null, null, "Trường Đại học Kinh tế - Luật", 54, new DateTime(2023, 4, 4, 20, 55, 57, 375, DateTimeKind.Unspecified).AddTicks(2799), null, new DateTime(2023, 5, 23, 11, 16, 13, 890, DateTimeKind.Unspecified).AddTicks(7869), "THI THỬ TIẾNG NHẬT JLPT", 5, "Other", 17 },
                    { 79, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Chào tất cả các bạn,\r\nWakame rất mong muốn gặp gỡ các bạn thường xuyên và tạo ra được nhiều kết nối đông đảo hơn. Do đó, buổi sinh hoạt mà Wakame sắp mang tới sẽ là buổi sinh hoạt online trêng nền tảng Google Meet.", new DateTime(2022, 6, 6, 11, 54, 12, 773, DateTimeKind.Unspecified).AddTicks(1365), "https://forms.gle/HkCD86Gc9UmTTZLP9", false, false, null, null, "Google Meet", 54, null, null, new DateTime(2022, 5, 6, 13, 50, 26, 927, DateTimeKind.Unspecified).AddTicks(1040), "SINH HOẠT THÁNG 10", 6, "Other", 17 },
                    { 80, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Các bạn sinh viên yêu ơi!❤\r\n💕Wakame UIT lại ngoi lên để gủ các bạn gặp gỡ tụi mình đây. 😊Với mong muốn sẽ lan tỏa sức sống wjbu và ngôn ngữ, văn hóa Nhật tới các bạn thì tại tầng 3 của Nhà văn hóa sinh viên, Wakame UIT có đặt bàn để giới thiệu CLB và không thể thiếu những trò chơi đầy chất Nhật Bản như là Sodoku, Kendama, Daruma, Caro XO.🎉\r\n🙌Bên dưới là link đăng ký để Wakame tụi mình có thể đảm bảo việc check in cho các bạn nhé! Bạn nhớ ghé bàn của Wakame UIT để xác nhận thông tin nhen.🤞", new DateTime(2023, 4, 29, 9, 47, 51, 838, DateTimeKind.Unspecified).AddTicks(9556), "https://forms.gle/HkCD86Gc9UmTTZLP9", false, false, null, null, "Nhà văn hóa sinh viên TPHCM", 71, null, null, new DateTime(2023, 4, 20, 16, 24, 39, 963, DateTimeKind.Unspecified).AddTicks(4210), "THAM GIA NGÀY HỘI TÂN SINH VIÊN 2023", 2, "Workshop", 17 }
                });

            migrationBuilder.InsertData(
                table: "EventImages",
                columns: new[] { "EventImageId", "EventId", "ImageUrl" },
                values: new object[,]
                {
                    { 1, 20, "https://picsum.photos/640/480/?image=120" },
                    { 2, 62, "https://picsum.photos/640/480/?image=438" },
                    { 3, 24, "https://picsum.photos/640/480/?image=756" },
                    { 4, 66, "https://picsum.photos/640/480/?image=1075" },
                    { 5, 28, "https://picsum.photos/640/480/?image=308" },
                    { 6, 69, "https://picsum.photos/640/480/?image=626" },
                    { 7, 31, "https://picsum.photos/640/480/?image=945" },
                    { 8, 73, "https://picsum.photos/640/480/?image=178" },
                    { 9, 35, "https://picsum.photos/640/480/?image=497" },
                    { 10, 77, "https://picsum.photos/640/480/?image=815" },
                    { 11, 38, "https://picsum.photos/640/480/?image=48" },
                    { 12, 80, "https://picsum.photos/640/480/?image=367" },
                    { 13, 42, "https://picsum.photos/640/480/?image=685" },
                    { 14, 4, "https://picsum.photos/640/480/?image=1003" },
                    { 15, 46, "https://picsum.photos/640/480/?image=237" },
                    { 16, 7, "https://picsum.photos/640/480/?image=555" },
                    { 17, 49, "https://picsum.photos/640/480/?image=873" },
                    { 18, 11, "https://picsum.photos/640/480/?image=107" },
                    { 19, 53, "https://picsum.photos/640/480/?image=425" },
                    { 20, 14, "https://picsum.photos/640/480/?image=743" },
                    { 21, 56, "https://picsum.photos/640/480/?image=1062" },
                    { 22, 18, "https://picsum.photos/640/480/?image=295" },
                    { 23, 60, "https://picsum.photos/640/480/?image=614" },
                    { 24, 22, "https://picsum.photos/640/480/?image=932" },
                    { 25, 63, "https://picsum.photos/640/480/?image=165" },
                    { 26, 25, "https://picsum.photos/640/480/?image=484" },
                    { 27, 67, "https://picsum.photos/640/480/?image=802" },
                    { 28, 29, "https://picsum.photos/640/480/?image=35" },
                    { 29, 71, "https://picsum.photos/640/480/?image=354" },
                    { 30, 32, "https://picsum.photos/640/480/?image=672" },
                    { 31, 74, "https://picsum.photos/640/480/?image=990" },
                    { 32, 36, "https://picsum.photos/640/480/?image=224" },
                    { 33, 78, "https://picsum.photos/640/480/?image=542" },
                    { 34, 40, "https://picsum.photos/640/480/?image=861" },
                    { 35, 1, "https://picsum.photos/640/480/?image=94" },
                    { 36, 43, "https://picsum.photos/640/480/?image=412" },
                    { 37, 5, "https://picsum.photos/640/480/?image=731" },
                    { 38, 47, "https://picsum.photos/640/480/?image=1049" },
                    { 39, 9, "https://picsum.photos/640/480/?image=282" },
                    { 40, 50, "https://picsum.photos/640/480/?image=601" },
                    { 41, 12, "https://picsum.photos/640/480/?image=919" },
                    { 42, 54, "https://picsum.photos/640/480/?image=152" },
                    { 43, 16, "https://picsum.photos/640/480/?image=471" },
                    { 44, 58, "https://picsum.photos/640/480/?image=789" },
                    { 45, 19, "https://picsum.photos/640/480/?image=22" },
                    { 46, 61, "https://picsum.photos/640/480/?image=341" },
                    { 47, 23, "https://picsum.photos/640/480/?image=659" },
                    { 48, 65, "https://picsum.photos/640/480/?image=978" },
                    { 49, 27, "https://picsum.photos/640/480/?image=211" },
                    { 50, 68, "https://picsum.photos/640/480/?image=529" },
                    { 51, 30, "https://picsum.photos/640/480/?image=848" },
                    { 52, 72, "https://picsum.photos/640/480/?image=81" },
                    { 53, 34, "https://picsum.photos/640/480/?image=399" },
                    { 54, 75, "https://picsum.photos/640/480/?image=718" },
                    { 55, 37, "https://picsum.photos/640/480/?image=1036" },
                    { 56, 79, "https://picsum.photos/640/480/?image=269" },
                    { 57, 41, "https://picsum.photos/640/480/?image=588" },
                    { 58, 3, "https://picsum.photos/640/480/?image=906" },
                    { 59, 44, "https://picsum.photos/640/480/?image=139" },
                    { 60, 6, "https://picsum.photos/640/480/?image=458" },
                    { 61, 48, "https://picsum.photos/640/480/?image=776" },
                    { 62, 10, "https://picsum.photos/640/480/?image=10" },
                    { 63, 52, "https://picsum.photos/640/480/?image=328" },
                    { 64, 13, "https://picsum.photos/640/480/?image=646" },
                    { 65, 55, "https://picsum.photos/640/480/?image=965" },
                    { 66, 17, "https://picsum.photos/640/480/?image=198" },
                    { 67, 59, "https://picsum.photos/640/480/?image=516" },
                    { 68, 21, "https://picsum.photos/640/480/?image=835" },
                    { 69, 62, "https://picsum.photos/640/480/?image=68" },
                    { 70, 24, "https://picsum.photos/640/480/?image=386" },
                    { 71, 66, "https://picsum.photos/640/480/?image=705" },
                    { 72, 28, "https://picsum.photos/640/480/?image=1023" },
                    { 73, 70, "https://picsum.photos/640/480/?image=257" },
                    { 74, 31, "https://picsum.photos/640/480/?image=575" },
                    { 75, 73, "https://picsum.photos/640/480/?image=893" },
                    { 76, 35, "https://picsum.photos/640/480/?image=127" },
                    { 77, 77, "https://picsum.photos/640/480/?image=445" },
                    { 78, 39, "https://picsum.photos/640/480/?image=763" },
                    { 79, 80, "https://picsum.photos/640/480/?image=1082" },
                    { 80, 42, "https://picsum.photos/640/480/?image=315" },
                    { 81, 4, "https://picsum.photos/640/480/?image=633" },
                    { 82, 46, "https://picsum.photos/640/480/?image=952" },
                    { 83, 8, "https://picsum.photos/640/480/?image=185" },
                    { 84, 49, "https://picsum.photos/640/480/?image=503" },
                    { 85, 11, "https://picsum.photos/640/480/?image=822" },
                    { 86, 53, "https://picsum.photos/640/480/?image=55" },
                    { 87, 15, "https://picsum.photos/640/480/?image=374" },
                    { 88, 56, "https://picsum.photos/640/480/?image=692" },
                    { 89, 18, "https://picsum.photos/640/480/?image=1010" },
                    { 90, 60, "https://picsum.photos/640/480/?image=244" },
                    { 91, 22, "https://picsum.photos/640/480/?image=562" },
                    { 92, 64, "https://picsum.photos/640/480/?image=880" },
                    { 93, 25, "https://picsum.photos/640/480/?image=114" },
                    { 94, 67, "https://picsum.photos/640/480/?image=432" },
                    { 95, 29, "https://picsum.photos/640/480/?image=750" },
                    { 96, 71, "https://picsum.photos/640/480/?image=1069" },
                    { 97, 33, "https://picsum.photos/640/480/?image=302" },
                    { 98, 74, "https://picsum.photos/640/480/?image=620" },
                    { 99, 36, "https://picsum.photos/640/480/?image=939" },
                    { 100, 78, "https://picsum.photos/640/480/?image=172" },
                    { 101, 40, "https://picsum.photos/640/480/?image=491" },
                    { 102, 2, "https://picsum.photos/640/480/?image=809" },
                    { 103, 43, "https://picsum.photos/640/480/?image=42" },
                    { 104, 5, "https://picsum.photos/640/480/?image=361" },
                    { 105, 47, "https://picsum.photos/640/480/?image=679" },
                    { 106, 9, "https://picsum.photos/640/480/?image=997" },
                    { 107, 51, "https://picsum.photos/640/480/?image=231" },
                    { 108, 12, "https://picsum.photos/640/480/?image=549" },
                    { 109, 54, "https://picsum.photos/640/480/?image=867" },
                    { 110, 16, "https://picsum.photos/640/480/?image=101" },
                    { 111, 58, "https://picsum.photos/640/480/?image=419" },
                    { 112, 20, "https://picsum.photos/640/480/?image=738" },
                    { 113, 61, "https://picsum.photos/640/480/?image=1056" },
                    { 114, 23, "https://picsum.photos/640/480/?image=289" },
                    { 115, 65, "https://picsum.photos/640/480/?image=608" },
                    { 116, 27, "https://picsum.photos/640/480/?image=926" },
                    { 117, 69, "https://picsum.photos/640/480/?image=159" },
                    { 118, 30, "https://picsum.photos/640/480/?image=478" },
                    { 119, 72, "https://picsum.photos/640/480/?image=796" },
                    { 120, 34, "https://picsum.photos/640/480/?image=29" },
                    { 121, 76, "https://picsum.photos/640/480/?image=348" },
                    { 122, 37, "https://picsum.photos/640/480/?image=666" },
                    { 123, 79, "https://picsum.photos/640/480/?image=984" },
                    { 124, 41, "https://picsum.photos/640/480/?image=218" },
                    { 125, 3, "https://picsum.photos/640/480/?image=536" },
                    { 126, 45, "https://picsum.photos/640/480/?image=855" },
                    { 127, 6, "https://picsum.photos/640/480/?image=88" },
                    { 128, 48, "https://picsum.photos/640/480/?image=406" },
                    { 129, 10, "https://picsum.photos/640/480/?image=725" },
                    { 130, 52, "https://picsum.photos/640/480/?image=1043" },
                    { 131, 14, "https://picsum.photos/640/480/?image=276" },
                    { 132, 55, "https://picsum.photos/640/480/?image=595" },
                    { 133, 17, "https://picsum.photos/640/480/?image=913" },
                    { 134, 59, "https://picsum.photos/640/480/?image=146" },
                    { 135, 21, "https://picsum.photos/640/480/?image=465" },
                    { 136, 63, "https://picsum.photos/640/480/?image=783" },
                    { 137, 24, "https://picsum.photos/640/480/?image=17" },
                    { 138, 66, "https://picsum.photos/640/480/?image=335" },
                    { 139, 28, "https://picsum.photos/640/480/?image=653" },
                    { 140, 70, "https://picsum.photos/640/480/?image=972" },
                    { 141, 32, "https://picsum.photos/640/480/?image=205" },
                    { 142, 73, "https://picsum.photos/640/480/?image=523" },
                    { 143, 35, "https://picsum.photos/640/480/?image=842" },
                    { 144, 77, "https://picsum.photos/640/480/?image=75" },
                    { 145, 39, "https://picsum.photos/640/480/?image=393" },
                    { 146, 1, "https://picsum.photos/640/480/?image=712" },
                    { 147, 42, "https://picsum.photos/640/480/?image=1030" },
                    { 148, 4, "https://picsum.photos/640/480/?image=263" },
                    { 149, 46, "https://picsum.photos/640/480/?image=582" },
                    { 150, 8, "https://picsum.photos/640/480/?image=900" },
                    { 151, 49, "https://picsum.photos/640/480/?image=134" },
                    { 152, 11, "https://picsum.photos/640/480/?image=452" },
                    { 153, 53, "https://picsum.photos/640/480/?image=770" },
                    { 154, 15, "https://picsum.photos/640/480/?image=4" },
                    { 155, 57, "https://picsum.photos/640/480/?image=322" },
                    { 156, 18, "https://picsum.photos/640/480/?image=640" },
                    { 157, 60, "https://picsum.photos/640/480/?image=959" },
                    { 158, 22, "https://picsum.photos/640/480/?image=192" },
                    { 159, 64, "https://picsum.photos/640/480/?image=510" },
                    { 160, 26, "https://picsum.photos/640/480/?image=829" },
                    { 161, 67, "https://picsum.photos/640/480/?image=62" },
                    { 162, 29, "https://picsum.photos/640/480/?image=380" },
                    { 163, 71, "https://picsum.photos/640/480/?image=699" },
                    { 164, 33, "https://picsum.photos/640/480/?image=1017" },
                    { 165, 75, "https://picsum.photos/640/480/?image=251" },
                    { 166, 36, "https://picsum.photos/640/480/?image=569" },
                    { 167, 78, "https://picsum.photos/640/480/?image=887" },
                    { 168, 40, "https://picsum.photos/640/480/?image=121" },
                    { 169, 2, "https://picsum.photos/640/480/?image=439" },
                    { 170, 44, "https://picsum.photos/640/480/?image=757" },
                    { 171, 5, "https://picsum.photos/640/480/?image=1076" },
                    { 172, 47, "https://picsum.photos/640/480/?image=309" },
                    { 173, 9, "https://picsum.photos/640/480/?image=627" },
                    { 174, 51, "https://picsum.photos/640/480/?image=946" },
                    { 175, 13, "https://picsum.photos/640/480/?image=179" },
                    { 176, 54, "https://picsum.photos/640/480/?image=498" },
                    { 177, 16, "https://picsum.photos/640/480/?image=816" },
                    { 178, 58, "https://picsum.photos/640/480/?image=49" },
                    { 179, 20, "https://picsum.photos/640/480/?image=368" },
                    { 180, 62, "https://picsum.photos/640/480/?image=686" },
                    { 181, 23, "https://picsum.photos/640/480/?image=1004" },
                    { 182, 65, "https://picsum.photos/640/480/?image=238" },
                    { 183, 27, "https://picsum.photos/640/480/?image=556" },
                    { 184, 69, "https://picsum.photos/640/480/?image=874" },
                    { 185, 30, "https://picsum.photos/640/480/?image=108" },
                    { 186, 72, "https://picsum.photos/640/480/?image=426" },
                    { 187, 34, "https://picsum.photos/640/480/?image=744" },
                    { 188, 76, "https://picsum.photos/640/480/?image=1063" },
                    { 189, 38, "https://picsum.photos/640/480/?image=296" },
                    { 190, 79, "https://picsum.photos/640/480/?image=615" },
                    { 191, 41, "https://picsum.photos/640/480/?image=933" },
                    { 192, 3, "https://picsum.photos/640/480/?image=166" },
                    { 193, 45, "https://picsum.photos/640/480/?image=485" },
                    { 194, 7, "https://picsum.photos/640/480/?image=803" },
                    { 195, 48, "https://picsum.photos/640/480/?image=36" },
                    { 196, 10, "https://picsum.photos/640/480/?image=355" },
                    { 197, 52, "https://picsum.photos/640/480/?image=673" },
                    { 198, 14, "https://picsum.photos/640/480/?image=991" },
                    { 199, 56, "https://picsum.photos/640/480/?image=225" },
                    { 200, 17, "https://picsum.photos/640/480/?image=543" },
                    { 201, 59, "https://picsum.photos/640/480/?image=861" },
                    { 202, 21, "https://picsum.photos/640/480/?image=95" },
                    { 203, 63, "https://picsum.photos/640/480/?image=413" },
                    { 204, 25, "https://picsum.photos/640/480/?image=732" },
                    { 205, 66, "https://picsum.photos/640/480/?image=1050" },
                    { 206, 28, "https://picsum.photos/640/480/?image=283" },
                    { 207, 70, "https://picsum.photos/640/480/?image=602" },
                    { 208, 32, "https://picsum.photos/640/480/?image=920" },
                    { 209, 74, "https://picsum.photos/640/480/?image=153" },
                    { 210, 35, "https://picsum.photos/640/480/?image=472" },
                    { 211, 77, "https://picsum.photos/640/480/?image=790" },
                    { 212, 39, "https://picsum.photos/640/480/?image=23" },
                    { 213, 1, "https://picsum.photos/640/480/?image=342" },
                    { 214, 43, "https://picsum.photos/640/480/?image=660" },
                    { 215, 4, "https://picsum.photos/640/480/?image=979" },
                    { 216, 46, "https://picsum.photos/640/480/?image=212" },
                    { 217, 8, "https://picsum.photos/640/480/?image=530" },
                    { 218, 50, "https://picsum.photos/640/480/?image=849" },
                    { 219, 11, "https://picsum.photos/640/480/?image=82" },
                    { 220, 53, "https://picsum.photos/640/480/?image=400" },
                    { 221, 15, "https://picsum.photos/640/480/?image=719" },
                    { 222, 57, "https://picsum.photos/640/480/?image=1037" },
                    { 223, 19, "https://picsum.photos/640/480/?image=270" },
                    { 224, 60, "https://picsum.photos/640/480/?image=589" },
                    { 225, 22, "https://picsum.photos/640/480/?image=907" },
                    { 226, 64, "https://picsum.photos/640/480/?image=140" },
                    { 227, 26, "https://picsum.photos/640/480/?image=459" },
                    { 228, 68, "https://picsum.photos/640/480/?image=777" },
                    { 229, 29, "https://picsum.photos/640/480/?image=11" },
                    { 230, 71, "https://picsum.photos/640/480/?image=329" },
                    { 231, 33, "https://picsum.photos/640/480/?image=647" },
                    { 232, 75, "https://picsum.photos/640/480/?image=966" },
                    { 233, 37, "https://picsum.photos/640/480/?image=199" },
                    { 234, 78, "https://picsum.photos/640/480/?image=517" },
                    { 235, 40, "https://picsum.photos/640/480/?image=836" },
                    { 236, 2, "https://picsum.photos/640/480/?image=69" },
                    { 237, 44, "https://picsum.photos/640/480/?image=387" },
                    { 238, 6, "https://picsum.photos/640/480/?image=706" },
                    { 239, 47, "https://picsum.photos/640/480/?image=1024" },
                    { 240, 9, "https://picsum.photos/640/480/?image=258" },
                    { 241, 51, "https://picsum.photos/640/480/?image=576" },
                    { 242, 13, "https://picsum.photos/640/480/?image=894" },
                    { 243, 55, "https://picsum.photos/640/480/?image=128" },
                    { 244, 16, "https://picsum.photos/640/480/?image=446" },
                    { 245, 58, "https://picsum.photos/640/480/?image=764" },
                    { 246, 20, "https://picsum.photos/640/480/?image=1083" },
                    { 247, 62, "https://picsum.photos/640/480/?image=316" },
                    { 248, 24, "https://picsum.photos/640/480/?image=634" },
                    { 249, 65, "https://picsum.photos/640/480/?image=953" },
                    { 250, 27, "https://picsum.photos/640/480/?image=186" },
                    { 251, 69, "https://picsum.photos/640/480/?image=504" },
                    { 252, 31, "https://picsum.photos/640/480/?image=823" },
                    { 253, 72, "https://picsum.photos/640/480/?image=56" },
                    { 254, 34, "https://picsum.photos/640/480/?image=375" },
                    { 255, 76, "https://picsum.photos/640/480/?image=693" },
                    { 256, 38, "https://picsum.photos/640/480/?image=1011" },
                    { 257, 80, "https://picsum.photos/640/480/?image=245" },
                    { 258, 41, "https://picsum.photos/640/480/?image=563" },
                    { 259, 3, "https://picsum.photos/640/480/?image=881" },
                    { 260, 45, "https://picsum.photos/640/480/?image=115" },
                    { 261, 7, "https://picsum.photos/640/480/?image=433" },
                    { 262, 49, "https://picsum.photos/640/480/?image=751" },
                    { 263, 10, "https://picsum.photos/640/480/?image=1070" },
                    { 264, 52, "https://picsum.photos/640/480/?image=303" },
                    { 265, 14, "https://picsum.photos/640/480/?image=621" },
                    { 266, 56, "https://picsum.photos/640/480/?image=940" },
                    { 267, 18, "https://picsum.photos/640/480/?image=173" },
                    { 268, 59, "https://picsum.photos/640/480/?image=492" },
                    { 269, 21, "https://picsum.photos/640/480/?image=810" },
                    { 270, 63, "https://picsum.photos/640/480/?image=43" },
                    { 271, 25, "https://picsum.photos/640/480/?image=362" },
                    { 272, 67, "https://picsum.photos/640/480/?image=680" },
                    { 273, 28, "https://picsum.photos/640/480/?image=998" },
                    { 274, 70, "https://picsum.photos/640/480/?image=232" },
                    { 275, 32, "https://picsum.photos/640/480/?image=550" },
                    { 276, 74, "https://picsum.photos/640/480/?image=868" },
                    { 277, 36, "https://picsum.photos/640/480/?image=102" },
                    { 278, 77, "https://picsum.photos/640/480/?image=420" },
                    { 279, 39, "https://picsum.photos/640/480/?image=739" },
                    { 280, 1, "https://picsum.photos/640/480/?image=1057" },
                    { 281, 43, "https://picsum.photos/640/480/?image=290" },
                    { 282, 5, "https://picsum.photos/640/480/?image=609" },
                    { 283, 46, "https://picsum.photos/640/480/?image=927" },
                    { 284, 8, "https://picsum.photos/640/480/?image=160" },
                    { 285, 50, "https://picsum.photos/640/480/?image=479" },
                    { 286, 12, "https://picsum.photos/640/480/?image=797" },
                    { 287, 53, "https://picsum.photos/640/480/?image=30" },
                    { 288, 15, "https://picsum.photos/640/480/?image=349" },
                    { 289, 57, "https://picsum.photos/640/480/?image=667" },
                    { 290, 19, "https://picsum.photos/640/480/?image=985" },
                    { 291, 61, "https://picsum.photos/640/480/?image=219" },
                    { 292, 22, "https://picsum.photos/640/480/?image=537" },
                    { 293, 64, "https://picsum.photos/640/480/?image=856" },
                    { 294, 26, "https://picsum.photos/640/480/?image=89" },
                    { 295, 68, "https://picsum.photos/640/480/?image=407" },
                    { 296, 30, "https://picsum.photos/640/480/?image=726" },
                    { 297, 71, "https://picsum.photos/640/480/?image=1044" },
                    { 298, 33, "https://picsum.photos/640/480/?image=277" },
                    { 299, 75, "https://picsum.photos/640/480/?image=596" },
                    { 300, 37, "https://picsum.photos/640/480/?image=914" },
                    { 301, 79, "https://picsum.photos/640/480/?image=147" },
                    { 302, 40, "https://picsum.photos/640/480/?image=466" },
                    { 303, 2, "https://picsum.photos/640/480/?image=784" },
                    { 304, 44, "https://picsum.photos/640/480/?image=17" },
                    { 305, 6, "https://picsum.photos/640/480/?image=336" },
                    { 306, 48, "https://picsum.photos/640/480/?image=654" },
                    { 307, 9, "https://picsum.photos/640/480/?image=973" },
                    { 308, 51, "https://picsum.photos/640/480/?image=206" },
                    { 309, 13, "https://picsum.photos/640/480/?image=524" },
                    { 310, 55, "https://picsum.photos/640/480/?image=843" },
                    { 311, 17, "https://picsum.photos/640/480/?image=76" },
                    { 312, 58, "https://picsum.photos/640/480/?image=394" },
                    { 313, 20, "https://picsum.photos/640/480/?image=713" },
                    { 314, 62, "https://picsum.photos/640/480/?image=1031" },
                    { 315, 24, "https://picsum.photos/640/480/?image=264" },
                    { 316, 66, "https://picsum.photos/640/480/?image=583" },
                    { 317, 27, "https://picsum.photos/640/480/?image=901" },
                    { 318, 69, "https://picsum.photos/640/480/?image=135" },
                    { 319, 31, "https://picsum.photos/640/480/?image=453" },
                    { 320, 73, "https://picsum.photos/640/480/?image=771" },
                    { 321, 34, "https://picsum.photos/640/480/?image=5" },
                    { 322, 76, "https://picsum.photos/640/480/?image=323" },
                    { 323, 38, "https://picsum.photos/640/480/?image=641" },
                    { 324, 80, "https://picsum.photos/640/480/?image=960" },
                    { 325, 42, "https://picsum.photos/640/480/?image=193" },
                    { 326, 3, "https://picsum.photos/640/480/?image=511" },
                    { 327, 45, "https://picsum.photos/640/480/?image=830" },
                    { 328, 7, "https://picsum.photos/640/480/?image=63" },
                    { 329, 49, "https://picsum.photos/640/480/?image=381" },
                    { 330, 11, "https://picsum.photos/640/480/?image=700" },
                    { 331, 52, "https://picsum.photos/640/480/?image=1018" },
                    { 332, 14, "https://picsum.photos/640/480/?image=252" },
                    { 333, 56, "https://picsum.photos/640/480/?image=570" },
                    { 334, 18, "https://picsum.photos/640/480/?image=888" },
                    { 335, 60, "https://picsum.photos/640/480/?image=122" },
                    { 336, 21, "https://picsum.photos/640/480/?image=440" },
                    { 337, 63, "https://picsum.photos/640/480/?image=758" },
                    { 338, 25, "https://picsum.photos/640/480/?image=1077" },
                    { 339, 67, "https://picsum.photos/640/480/?image=310" },
                    { 340, 29, "https://picsum.photos/640/480/?image=628" },
                    { 341, 70, "https://picsum.photos/640/480/?image=947" },
                    { 342, 32, "https://picsum.photos/640/480/?image=180" },
                    { 343, 74, "https://picsum.photos/640/480/?image=499" },
                    { 344, 36, "https://picsum.photos/640/480/?image=817" },
                    { 345, 78, "https://picsum.photos/640/480/?image=50" },
                    { 346, 39, "https://picsum.photos/640/480/?image=369" },
                    { 347, 1, "https://picsum.photos/640/480/?image=687" },
                    { 348, 43, "https://picsum.photos/640/480/?image=1005" },
                    { 349, 5, "https://picsum.photos/640/480/?image=239" },
                    { 350, 47, "https://picsum.photos/640/480/?image=557" },
                    { 351, 8, "https://picsum.photos/640/480/?image=875" },
                    { 352, 50, "https://picsum.photos/640/480/?image=109" },
                    { 353, 12, "https://picsum.photos/640/480/?image=427" },
                    { 354, 54, "https://picsum.photos/640/480/?image=745" },
                    { 355, 15, "https://picsum.photos/640/480/?image=1064" },
                    { 356, 57, "https://picsum.photos/640/480/?image=297" },
                    { 357, 19, "https://picsum.photos/640/480/?image=616" },
                    { 358, 61, "https://picsum.photos/640/480/?image=934" },
                    { 359, 23, "https://picsum.photos/640/480/?image=167" },
                    { 360, 64, "https://picsum.photos/640/480/?image=486" },
                    { 361, 26, "https://picsum.photos/640/480/?image=804" },
                    { 362, 68, "https://picsum.photos/640/480/?image=37" },
                    { 363, 30, "https://picsum.photos/640/480/?image=356" },
                    { 364, 72, "https://picsum.photos/640/480/?image=674" },
                    { 365, 33, "https://picsum.photos/640/480/?image=992" },
                    { 366, 75, "https://picsum.photos/640/480/?image=226" },
                    { 367, 37, "https://picsum.photos/640/480/?image=544" },
                    { 368, 79, "https://picsum.photos/640/480/?image=862" },
                    { 369, 41, "https://picsum.photos/640/480/?image=96" },
                    { 370, 2, "https://picsum.photos/640/480/?image=414" },
                    { 371, 44, "https://picsum.photos/640/480/?image=733" },
                    { 372, 6, "https://picsum.photos/640/480/?image=1051" },
                    { 373, 48, "https://picsum.photos/640/480/?image=284" },
                    { 374, 10, "https://picsum.photos/640/480/?image=603" },
                    { 375, 51, "https://picsum.photos/640/480/?image=921" },
                    { 376, 13, "https://picsum.photos/640/480/?image=154" },
                    { 377, 55, "https://picsum.photos/640/480/?image=473" },
                    { 378, 17, "https://picsum.photos/640/480/?image=791" },
                    { 379, 59, "https://picsum.photos/640/480/?image=24" },
                    { 380, 20, "https://picsum.photos/640/480/?image=343" },
                    { 381, 62, "https://picsum.photos/640/480/?image=661" },
                    { 382, 24, "https://picsum.photos/640/480/?image=980" },
                    { 383, 66, "https://picsum.photos/640/480/?image=213" },
                    { 384, 28, "https://picsum.photos/640/480/?image=531" },
                    { 385, 69, "https://picsum.photos/640/480/?image=850" },
                    { 386, 31, "https://picsum.photos/640/480/?image=83" },
                    { 387, 73, "https://picsum.photos/640/480/?image=401" },
                    { 388, 35, "https://picsum.photos/640/480/?image=720" },
                    { 389, 76, "https://picsum.photos/640/480/?image=1038" },
                    { 390, 38, "https://picsum.photos/640/480/?image=271" },
                    { 391, 80, "https://picsum.photos/640/480/?image=590" },
                    { 392, 42, "https://picsum.photos/640/480/?image=908" },
                    { 393, 4, "https://picsum.photos/640/480/?image=141" },
                    { 394, 45, "https://picsum.photos/640/480/?image=460" },
                    { 395, 7, "https://picsum.photos/640/480/?image=778" },
                    { 396, 49, "https://picsum.photos/640/480/?image=12" },
                    { 397, 11, "https://picsum.photos/640/480/?image=330" },
                    { 398, 53, "https://picsum.photos/640/480/?image=648" },
                    { 399, 14, "https://picsum.photos/640/480/?image=967" },
                    { 400, 56, "https://picsum.photos/640/480/?image=200" }
                });

            migrationBuilder.InsertData(
                table: "EventRegistrations",
                columns: new[] { "EventRegistrationId", "AttendedDate", "CreatedByUserId", "CreatedDate", "EventId", "IsAttended", "IsRegistered", "LastModifiedByUserId", "LastModifiedDate", "RegisterDate", "StudentId" },
                values: new object[,]
                {
                    { 1, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, false, true, null, null, new DateTime(2023, 11, 26, 6, 41, 21, 148, DateTimeKind.Unspecified).AddTicks(8547), 15 },
                    { 2, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 62, false, true, null, null, new DateTime(2023, 12, 19, 21, 10, 4, 701, DateTimeKind.Unspecified).AddTicks(9255), 52 },
                    { 3, new DateTime(2023, 10, 20, 16, 28, 39, 488, DateTimeKind.Unspecified).AddTicks(5726), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, true, true, null, null, new DateTime(2023, 10, 15, 14, 3, 20, 779, DateTimeKind.Unspecified).AddTicks(3945), 90 },
                    { 4, new DateTime(2023, 11, 9, 8, 21, 27, 55, DateTimeKind.Unspecified).AddTicks(4868), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 66, true, true, null, null, new DateTime(2023, 11, 9, 0, 33, 2, 47, DateTimeKind.Unspecified).AddTicks(3472), 127 },
                    { 5, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 28, false, true, null, null, new DateTime(2023, 7, 5, 21, 25, 20, 409, DateTimeKind.Unspecified).AddTicks(9344), 37 },
                    { 6, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 69, false, true, null, null, new DateTime(2022, 10, 14, 5, 20, 48, 641, DateTimeKind.Unspecified).AddTicks(5700), 74 },
                    { 7, new DateTime(2022, 6, 17, 21, 55, 24, 579, DateTimeKind.Unspecified).AddTicks(6557), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 31, true, true, null, null, new DateTime(2022, 6, 10, 2, 13, 7, 4, DateTimeKind.Unspecified).AddTicks(1571), 112 },
                    { 8, new DateTime(2022, 8, 5, 18, 13, 26, 827, DateTimeKind.Unspecified).AddTicks(4947), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 73, true, true, null, null, new DateTime(2022, 7, 4, 12, 42, 48, 272, DateTimeKind.Unspecified).AddTicks(1097), 22 },
                    { 9, new DateTime(2024, 3, 16, 13, 38, 22, 473, DateTimeKind.Unspecified).AddTicks(9805), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 35, true, true, null, null, new DateTime(2024, 3, 1, 8, 10, 16, 412, DateTimeKind.Unspecified).AddTicks(9380), 59 },
                    { 10, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 77, false, true, null, null, new DateTime(2022, 5, 23, 20, 4, 47, 902, DateTimeKind.Unspecified).AddTicks(6496), 97 },
                    { 11, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 38, false, true, null, null, new DateTime(2023, 2, 4, 16, 27, 2, 535, DateTimeKind.Unspecified).AddTicks(8926), 6 },
                    { 12, new DateTime(2023, 4, 1, 21, 24, 54, 983, DateTimeKind.Unspecified).AddTicks(5569), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 80, true, true, null, null, new DateTime(2023, 3, 1, 17, 23, 38, 679, DateTimeKind.Unspecified).AddTicks(907), 44 },
                    { 13, new DateTime(2022, 12, 24, 15, 18, 12, 439, DateTimeKind.Unspecified).AddTicks(2107), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 42, true, true, null, null, new DateTime(2022, 12, 23, 21, 44, 52, 859, DateTimeKind.Unspecified).AddTicks(4596), 81 },
                    { 14, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, false, true, null, null, new DateTime(2022, 8, 19, 7, 54, 44, 255, DateTimeKind.Unspecified).AddTicks(6922), 119 },
                    { 15, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 46, false, true, null, null, new DateTime(2022, 9, 13, 5, 6, 52, 489, DateTimeKind.Unspecified).AddTicks(9994), 28 },
                    { 16, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, false, true, null, null, new DateTime(2023, 7, 25, 23, 24, 57, 816, DateTimeKind.Unspecified).AddTicks(2696), 66 },
                    { 17, new DateTime(2023, 9, 7, 17, 11, 55, 596, DateTimeKind.Unspecified).AddTicks(8377), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 49, true, true, null, null, new DateTime(2023, 8, 19, 1, 31, 49, 804, DateTimeKind.Unspecified).AddTicks(9994), 104 },
                    { 18, new DateTime(2023, 4, 28, 14, 20, 26, 704, DateTimeKind.Unspecified).AddTicks(8065), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, true, true, null, null, new DateTime(2023, 4, 15, 6, 46, 57, 446, DateTimeKind.Unspecified).AddTicks(8095), 13 },
                    { 19, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 53, false, true, null, null, new DateTime(2023, 5, 9, 17, 16, 38, 714, DateTimeKind.Unspecified).AddTicks(7621), 51 },
                    { 20, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, false, true, null, null, new DateTime(2024, 3, 20, 17, 37, 55, 633, DateTimeKind.Unspecified).AddTicks(1233), 88 },
                    { 21, new DateTime(2022, 5, 7, 10, 3, 8, 511, DateTimeKind.Unspecified).AddTicks(2456), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 56, true, true, null, null, new DateTime(2022, 4, 13, 22, 4, 25, 308, DateTimeKind.Unspecified).AddTicks(9849), 126 },
                    { 22, new DateTime(2023, 12, 16, 7, 15, 24, 413, DateTimeKind.Unspecified).AddTicks(5940), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, true, true, null, null, new DateTime(2023, 12, 8, 22, 26, 37, 204, DateTimeKind.Unspecified).AddTicks(2355), 35 },
                    { 23, new DateTime(2024, 3, 9, 9, 4, 52, 977, DateTimeKind.Unspecified).AddTicks(3196), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, true, true, null, null, new DateTime(2024, 3, 3, 9, 9, 58, 844, DateTimeKind.Unspecified).AddTicks(4840), 73 },
                    { 24, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 22, false, true, null, null, new DateTime(2023, 10, 29, 2, 18, 43, 302, DateTimeKind.Unspecified).AddTicks(1119), 110 },
                    { 25, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 63, false, true, null, null, new DateTime(2022, 12, 8, 10, 14, 11, 533, DateTimeKind.Unspecified).AddTicks(7475), 20 },
                    { 26, new DateTime(2022, 10, 7, 13, 4, 20, 260, DateTimeKind.Unspecified).AddTicks(1905), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, true, true, null, null, new DateTime(2022, 10, 3, 7, 6, 29, 896, DateTimeKind.Unspecified).AddTicks(3347), 58 },
                    { 27, new DateTime(2022, 11, 5, 16, 4, 31, 521, DateTimeKind.Unspecified).AddTicks(5111), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 67, true, true, null, null, new DateTime(2022, 10, 27, 17, 36, 11, 164, DateTimeKind.Unspecified).AddTicks(2873), 95 },
                    { 28, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 29, false, true, null, null, new DateTime(2022, 6, 23, 14, 28, 29, 526, DateTimeKind.Unspecified).AddTicks(8746), 5 },
                    { 29, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 71, false, true, null, null, new DateTime(2022, 7, 17, 1, 53, 52, 264, DateTimeKind.Unspecified).AddTicks(1315), 42 },
                    { 30, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 32, false, true, null, null, new DateTime(2023, 5, 29, 19, 16, 16, 121, DateTimeKind.Unspecified).AddTicks(974), 80 },
                    { 31, new DateTime(2023, 6, 30, 6, 33, 25, 749, DateTimeKind.Unspecified).AddTicks(932), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 74, true, true, null, null, new DateTime(2023, 6, 23, 5, 45, 57, 389, DateTimeKind.Unspecified).AddTicks(499), 117 },
                    { 32, new DateTime(2023, 3, 24, 6, 11, 27, 263, DateTimeKind.Unspecified).AddTicks(3784), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 36, true, true, null, null, new DateTime(2023, 2, 18, 20, 7, 37, 438, DateTimeKind.Unspecified).AddTicks(7649), 27 },
                    { 33, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 78, false, true, null, null, new DateTime(2023, 5, 12, 13, 7, 57, 19, DateTimeKind.Unspecified).AddTicks(5898), 65 },
                    { 34, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 40, false, true, null, null, new DateTime(2023, 1, 5, 22, 48, 39, 663, DateTimeKind.Unspecified).AddTicks(3677), 102 },
                    { 35, new DateTime(2023, 9, 19, 13, 22, 35, 805, DateTimeKind.Unspecified).AddTicks(7797), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true, true, null, null, new DateTime(2023, 9, 19, 4, 18, 20, 708, DateTimeKind.Unspecified).AddTicks(4472), 12 },
                    { 36, new DateTime(2023, 12, 14, 23, 5, 46, 580, DateTimeKind.Unspecified).AddTicks(6362), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 43, true, true, null, null, new DateTime(2023, 12, 12, 14, 48, 1, 976, DateTimeKind.Unspecified).AddTicks(3998), 49 },
                    { 37, new DateTime(2023, 8, 29, 13, 22, 20, 880, DateTimeKind.Unspecified).AddTicks(8948), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, true, true, null, null, new DateTime(2023, 8, 8, 2, 48, 22, 307, DateTimeKind.Unspecified).AddTicks(3094), 87 },
                    { 38, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 47, false, true, null, null, new DateTime(2023, 9, 1, 22, 10, 1, 606, DateTimeKind.Unspecified).AddTicks(9397), 124 },
                    { 39, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, false, true, null, null, new DateTime(2023, 4, 28, 19, 2, 19, 969, DateTimeKind.Unspecified).AddTicks(5268), 34 },
                    { 40, new DateTime(2022, 8, 11, 17, 29, 9, 250, DateTimeKind.Unspecified).AddTicks(6714), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 50, true, true, null, null, new DateTime(2022, 8, 7, 2, 57, 48, 201, DateTimeKind.Unspecified).AddTicks(1624), 71 },
                    { 41, new DateTime(2022, 4, 28, 9, 5, 43, 352, DateTimeKind.Unspecified).AddTicks(6812), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, true, true, null, null, new DateTime(2022, 4, 2, 23, 50, 6, 563, DateTimeKind.Unspecified).AddTicks(7496), 109 },
                    { 42, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 54, false, true, null, null, new DateTime(2022, 4, 27, 10, 19, 47, 831, DateTimeKind.Unspecified).AddTicks(7023), 19 },
                    { 43, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, false, true, null, null, new DateTime(2024, 2, 21, 11, 24, 48, 851, DateTimeKind.Unspecified).AddTicks(7035), 56 },
                    { 44, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 58, false, true, null, null, new DateTime(2024, 3, 17, 5, 7, 57, 557, DateTimeKind.Unspecified).AddTicks(2788), 94 },
                    { 45, new DateTime(2022, 12, 22, 9, 59, 24, 30, DateTimeKind.Unspecified).AddTicks(4762), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, true, true, null, null, new DateTime(2022, 11, 27, 11, 59, 52, 788, DateTimeKind.Unspecified).AddTicks(5123), 3 },
                    { 46, new DateTime(2023, 2, 25, 12, 0, 53, 608, DateTimeKind.Unspecified).AddTicks(9585), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 61, true, true, null, null, new DateTime(2023, 2, 19, 20, 36, 29, 86, DateTimeKind.Unspecified).AddTicks(1827), 41 },
                    { 47, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 23, false, true, null, null, new DateTime(2022, 10, 16, 19, 21, 52, 419, DateTimeKind.Unspecified).AddTicks(521), 78 },
                    { 48, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 65, false, true, null, null, new DateTime(2022, 11, 10, 5, 51, 33, 687, DateTimeKind.Unspecified).AddTicks(47), 116 },
                    { 49, new DateTime(2022, 7, 26, 3, 36, 16, 748, DateTimeKind.Unspecified).AddTicks(1922), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 27, true, true, null, null, new DateTime(2022, 7, 6, 3, 10, 24, 766, DateTimeKind.Unspecified).AddTicks(4415), 25 },
                    { 50, new DateTime(2023, 10, 30, 10, 54, 17, 844, DateTimeKind.Unspecified).AddTicks(7870), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 68, true, true, null, null, new DateTime(2023, 10, 16, 10, 39, 20, 281, DateTimeKind.Unspecified).AddTicks(2275), 63 },
                    { 51, new DateTime(2023, 6, 20, 15, 53, 35, 846, DateTimeKind.Unspecified).AddTicks(1610), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, true, true, null, null, new DateTime(2023, 6, 12, 7, 31, 38, 643, DateTimeKind.Unspecified).AddTicks(8147), 101 },
                    { 52, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 72, false, true, null, null, new DateTime(2023, 7, 6, 18, 1, 19, 911, DateTimeKind.Unspecified).AddTicks(7674), 10 },
                    { 53, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 34, false, true, null, null, new DateTime(2023, 5, 1, 14, 53, 38, 274, DateTimeKind.Unspecified).AddTicks(3546), 48 },
                    { 54, new DateTime(2022, 6, 28, 15, 42, 26, 965, DateTimeKind.Unspecified).AddTicks(351), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 75, true, true, null, null, new DateTime(2022, 6, 10, 22, 49, 6, 505, DateTimeKind.Unspecified).AddTicks(9902), 85 },
                    { 55, new DateTime(2024, 2, 8, 9, 36, 2, 238, DateTimeKind.Unspecified).AddTicks(4324), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 37, true, true, null, null, new DateTime(2024, 2, 6, 14, 35, 36, 777, DateTimeKind.Unspecified).AddTicks(4642), 123 },
                    { 56, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 79, false, true, null, null, new DateTime(2022, 4, 30, 6, 11, 6, 136, DateTimeKind.Unspecified).AddTicks(5300), 32 },
                    { 57, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 41, false, true, null, null, new DateTime(2023, 12, 26, 3, 3, 24, 499, DateTimeKind.Unspecified).AddTicks(1172), 70 },
                    { 58, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, false, true, null, null, new DateTime(2023, 8, 21, 23, 55, 42, 861, DateTimeKind.Unspecified).AddTicks(7044), 107 },
                    { 59, new DateTime(2022, 11, 21, 8, 55, 0, 871, DateTimeKind.Unspecified).AddTicks(4596), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 44, true, true, null, null, new DateTime(2022, 10, 1, 7, 51, 11, 93, DateTimeKind.Unspecified).AddTicks(3400), 17 },
                    { 60, new DateTime(2022, 8, 1, 16, 13, 19, 201, DateTimeKind.Unspecified).AddTicks(7858), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, true, true, null, null, new DateTime(2022, 7, 27, 4, 43, 29, 455, DateTimeKind.Unspecified).AddTicks(9272), 55 },
                    { 61, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 48, false, true, null, null, new DateTime(2022, 8, 20, 0, 58, 14, 189, DateTimeKind.Unspecified).AddTicks(2566), 92 },
                    { 62, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, false, true, null, null, new DateTime(2022, 4, 16, 12, 5, 29, 86, DateTimeKind.Unspecified).AddTicks(4671), 2 },
                    { 63, new DateTime(2022, 7, 18, 5, 16, 53, 178, DateTimeKind.Unspecified).AddTicks(3314), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 52, true, true, null, null, new DateTime(2022, 7, 9, 22, 35, 10, 354, DateTimeKind.Unspecified).AddTicks(4196), 39 },
                    { 64, new DateTime(2023, 3, 26, 17, 4, 48, 752, DateTimeKind.Unspecified).AddTicks(7523), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, true, true, null, null, new DateTime(2023, 3, 23, 16, 43, 53, 375, DateTimeKind.Unspecified).AddTicks(6727), 77 },
                    { 65, new DateTime(2023, 5, 13, 3, 27, 47, 837, DateTimeKind.Unspecified).AddTicks(8550), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 55, true, true, null, null, new DateTime(2023, 4, 16, 3, 22, 56, 948, DateTimeKind.Unspecified).AddTicks(6424), 114 },
                    { 66, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, false, true, null, null, new DateTime(2023, 2, 8, 21, 53, 1, 588, DateTimeKind.Unspecified).AddTicks(4928), 24 },
                    { 67, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 59, false, true, null, null, new DateTime(2023, 3, 6, 5, 56, 18, 899, DateTimeKind.Unspecified).AddTicks(9016), 61 },
                    { 68, new DateTime(2022, 12, 8, 8, 44, 50, 464, DateTimeKind.Unspecified).AddTicks(5855), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, true, true, null, null, new DateTime(2022, 10, 30, 7, 37, 14, 941, DateTimeKind.Unspecified).AddTicks(7695), 99 },
                    { 69, new DateTime(2024, 2, 9, 1, 3, 18, 521, DateTimeKind.Unspecified).AddTicks(3976), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 62, true, true, null, null, new DateTime(2024, 2, 8, 15, 30, 7, 137, DateTimeKind.Unspecified).AddTicks(7999), 9 },
                    { 70, new DateTime(2023, 10, 21, 1, 4, 48, 198, DateTimeKind.Unspecified).AddTicks(8178), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, true, true, null, null, new DateTime(2023, 10, 5, 12, 25, 1, 535, DateTimeKind.Unspecified).AddTicks(9922), 46 },
                    { 71, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 66, false, true, null, null, new DateTime(2023, 10, 29, 22, 54, 42, 803, DateTimeKind.Unspecified).AddTicks(9449), 84 },
                    { 72, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 28, false, true, null, null, new DateTime(2023, 6, 25, 19, 47, 1, 166, DateTimeKind.Unspecified).AddTicks(5321), 121 },
                    { 73, new DateTime(2023, 9, 20, 10, 59, 11, 895, DateTimeKind.Unspecified).AddTicks(8660), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 70, true, true, null, null, new DateTime(2023, 9, 18, 6, 16, 42, 434, DateTimeKind.Unspecified).AddTicks(4847), 31 },
                    { 74, new DateTime(2022, 6, 19, 8, 57, 27, 721, DateTimeKind.Unspecified).AddTicks(951), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 31, true, true, null, null, new DateTime(2022, 5, 31, 0, 34, 47, 760, DateTimeKind.Unspecified).AddTicks(7549), 68 },
                    { 75, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 73, false, true, null, null, new DateTime(2022, 6, 24, 11, 4, 29, 28, DateTimeKind.Unspecified).AddTicks(7075), 106 },
                    { 76, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 35, false, true, null, null, new DateTime(2024, 4, 19, 10, 33, 35, 490, DateTimeKind.Unspecified).AddTicks(2591), 15 },
                    { 77, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 77, false, true, null, null, new DateTime(2022, 5, 13, 18, 26, 28, 659, DateTimeKind.Unspecified).AddTicks(2474), 53 },
                    { 78, new DateTime(2024, 1, 26, 15, 30, 11, 673, DateTimeKind.Unspecified).AddTicks(7892), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 39, true, true, null, null, new DateTime(2024, 1, 7, 22, 15, 4, 47, DateTimeKind.Unspecified).AddTicks(6248), 91 },
                    { 79, new DateTime(2023, 4, 20, 11, 16, 16, 579, DateTimeKind.Unspecified).AddTicks(4399), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 80, true, true, null, null, new DateTime(2023, 4, 18, 23, 48, 36, 77, DateTimeKind.Unspecified).AddTicks(1352), 128 },
                    { 80, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 42, false, true, null, null, new DateTime(2022, 12, 13, 20, 6, 33, 616, DateTimeKind.Unspecified).AddTicks(573), 38 },
                    { 81, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, false, true, null, null, new DateTime(2022, 8, 9, 2, 14, 46, 691, DateTimeKind.Unspecified).AddTicks(5666), 75 },
                    { 82, new DateTime(2022, 9, 15, 21, 9, 56, 5, DateTimeKind.Unspecified).AddTicks(3758), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 46, true, true, null, null, new DateTime(2022, 9, 3, 3, 28, 33, 246, DateTimeKind.Unspecified).AddTicks(5972), 113 },
                    { 83, new DateTime(2022, 7, 8, 11, 55, 53, 788, DateTimeKind.Unspecified).AddTicks(4381), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, true, true, null, null, new DateTime(2022, 6, 29, 0, 20, 51, 609, DateTimeKind.Unspecified).AddTicks(1845), 22 },
                    { 84, new DateTime(2023, 8, 13, 2, 1, 46, 424, DateTimeKind.Unspecified).AddTicks(169), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 49, true, true, null, null, new DateTime(2023, 8, 8, 19, 51, 52, 240, DateTimeKind.Unspecified).AddTicks(8738), 60 },
                    { 85, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, false, true, null, null, new DateTime(2023, 4, 5, 5, 8, 38, 203, DateTimeKind.Unspecified).AddTicks(4073), 98 },
                    { 86, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 53, false, true, null, null, new DateTime(2023, 6, 28, 15, 38, 19, 471, DateTimeKind.Unspecified).AddTicks(3598), 7 },
                    { 87, new DateTime(2023, 3, 7, 16, 3, 17, 867, DateTimeKind.Unspecified).AddTicks(2498), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, true, true, null, null, new DateTime(2023, 2, 23, 8, 40, 17, 659, DateTimeKind.Unspecified).AddTicks(5759), 45 },
                    { 88, new DateTime(2022, 5, 15, 7, 33, 51, 894, DateTimeKind.Unspecified).AddTicks(6395), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 56, true, true, null, null, new DateTime(2022, 4, 3, 20, 26, 6, 65, DateTimeKind.Unspecified).AddTicks(5826), 82 },
                    { 89, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, false, true, null, null, new DateTime(2024, 1, 28, 16, 46, 39, 640, DateTimeKind.Unspecified).AddTicks(1099), 120 },
                    { 90, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, false, true, null, null, new DateTime(2024, 2, 22, 11, 33, 17, 921, DateTimeKind.Unspecified).AddTicks(8051), 29 },
                    { 91, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 22, false, true, null, null, new DateTime(2023, 10, 19, 0, 40, 24, 58, DateTimeKind.Unspecified).AddTicks(7097), 67 },
                    { 92, new DateTime(2023, 12, 24, 10, 23, 9, 637, DateTimeKind.Unspecified).AddTicks(9163), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 64, true, true, null, null, new DateTime(2023, 11, 12, 11, 10, 5, 326, DateTimeKind.Unspecified).AddTicks(6623), 104 },
                    { 93, new DateTime(2022, 9, 26, 1, 21, 34, 725, DateTimeKind.Unspecified).AddTicks(2878), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, true, true, null, null, new DateTime(2022, 9, 23, 5, 28, 10, 652, DateTimeKind.Unspecified).AddTicks(9325), 14 },
                    { 94, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 67, false, true, null, null, new DateTime(2022, 10, 17, 15, 57, 51, 920, DateTimeKind.Unspecified).AddTicks(8850), 52 },
                    { 95, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 29, false, true, null, null, new DateTime(2022, 6, 13, 12, 50, 10, 283, DateTimeKind.Unspecified).AddTicks(4723), 89 },
                    { 96, new DateTime(2022, 9, 10, 17, 7, 22, 527, DateTimeKind.Unspecified).AddTicks(4897), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 71, true, true, null, null, new DateTime(2022, 9, 5, 20, 13, 54, 700, DateTimeKind.Unspecified).AddTicks(59), 127 },
                    { 97, new DateTime(2022, 5, 2, 20, 17, 57, 147, DateTimeKind.Unspecified).AddTicks(911), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 33, true, true, null, null, new DateTime(2022, 5, 2, 20, 12, 9, 914, DateTimeKind.Unspecified).AddTicks(121), 36 },
                    { 98, new DateTime(2023, 7, 3, 10, 28, 35, 699, DateTimeKind.Unspecified).AddTicks(8454), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 74, true, true, null, null, new DateTime(2023, 6, 13, 4, 7, 38, 145, DateTimeKind.Unspecified).AddTicks(6477), 74 },
                    { 99, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 36, false, true, null, null, new DateTime(2023, 4, 8, 2, 32, 34, 836, DateTimeKind.Unspecified).AddTicks(8094), 111 },
                    { 100, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 78, false, true, null, null, new DateTime(2023, 5, 2, 11, 29, 37, 776, DateTimeKind.Unspecified).AddTicks(1876), 21 },
                    { 101, new DateTime(2023, 1, 27, 16, 54, 42, 684, DateTimeKind.Unspecified).AddTicks(819), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 40, true, true, null, null, new DateTime(2022, 12, 26, 17, 8, 42, 99, DateTimeKind.Unspecified).AddTicks(2420), 58 },
                    { 102, new DateTime(2022, 9, 6, 22, 17, 53, 224, DateTimeKind.Unspecified).AddTicks(429), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true, true, null, null, new DateTime(2022, 8, 23, 5, 14, 14, 501, DateTimeKind.Unspecified).AddTicks(3619), 96 },
                    { 103, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 43, false, true, null, null, new DateTime(2023, 12, 2, 13, 9, 42, 732, DateTimeKind.Unspecified).AddTicks(9975), 6 },
                    { 104, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, false, true, null, null, new DateTime(2023, 7, 28, 21, 8, 24, 743, DateTimeKind.Unspecified).AddTicks(1838), 43 },
                    { 105, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 47, false, true, null, null, new DateTime(2023, 8, 22, 20, 31, 42, 363, DateTimeKind.Unspecified).AddTicks(5374), 81 },
                    { 106, new DateTime(2023, 6, 18, 7, 39, 43, 537, DateTimeKind.Unspecified).AddTicks(2402), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, true, true, null, null, new DateTime(2023, 6, 17, 17, 24, 0, 726, DateTimeKind.Unspecified).AddTicks(1246), 118 },
                    { 107, new DateTime(2023, 7, 26, 6, 45, 30, 63, DateTimeKind.Unspecified).AddTicks(6880), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 51, true, true, null, null, new DateTime(2023, 7, 12, 3, 53, 41, 994, DateTimeKind.Unspecified).AddTicks(773), 28 },
                    { 108, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, false, true, null, null, new DateTime(2022, 3, 23, 22, 11, 47, 320, DateTimeKind.Unspecified).AddTicks(3474), 65 },
                    { 109, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 54, false, true, null, null, new DateTime(2022, 6, 16, 8, 41, 28, 588, DateTimeKind.Unspecified).AddTicks(3001), 103 },
                    { 110, new DateTime(2024, 3, 1, 1, 19, 30, 597, DateTimeKind.Unspecified).AddTicks(6654), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, true, true, null, null, new DateTime(2024, 2, 11, 13, 48, 7, 929, DateTimeKind.Unspecified).AddTicks(246), 12 },
                    { 111, new DateTime(2024, 3, 19, 20, 2, 27, 522, DateTimeKind.Unspecified).AddTicks(1905), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 58, true, true, null, null, new DateTime(2024, 3, 7, 7, 31, 16, 634, DateTimeKind.Unspecified).AddTicks(5999), 50 },
                    { 112, new DateTime(2023, 12, 16, 2, 57, 27, 259, DateTimeKind.Unspecified).AddTicks(5000), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, true, true, null, null, new DateTime(2023, 11, 1, 12, 55, 46, 581, DateTimeKind.Unspecified).AddTicks(4271), 88 },
                    { 113, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 61, false, true, null, null, new DateTime(2023, 2, 9, 14, 56, 31, 522, DateTimeKind.Unspecified).AddTicks(570), 125 },
                    { 114, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 23, false, true, null, null, new DateTime(2022, 10, 6, 17, 43, 33, 175, DateTimeKind.Unspecified).AddTicks(6499), 35 },
                    { 115, new DateTime(2022, 11, 6, 18, 17, 0, 469, DateTimeKind.Unspecified).AddTicks(5558), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 65, true, true, null, null, new DateTime(2022, 10, 31, 4, 13, 14, 443, DateTimeKind.Unspecified).AddTicks(6025), 72 },
                    { 116, new DateTime(2022, 8, 31, 17, 52, 3, 264, DateTimeKind.Unspecified).AddTicks(9601), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 27, true, true, null, null, new DateTime(2022, 8, 25, 21, 30, 27, 202, DateTimeKind.Unspecified).AddTicks(3159), 110 },
                    { 117, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 69, false, true, null, null, new DateTime(2022, 9, 19, 11, 35, 14, 74, DateTimeKind.Unspecified).AddTicks(1424), 19 },
                    { 118, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, false, true, null, null, new DateTime(2023, 6, 2, 5, 53, 19, 400, DateTimeKind.Unspecified).AddTicks(4124), 57 },
                    { 119, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 72, false, true, null, null, new DateTime(2023, 8, 25, 16, 23, 0, 668, DateTimeKind.Unspecified).AddTicks(3651), 94 },
                    { 120, new DateTime(2023, 4, 30, 2, 4, 8, 817, DateTimeKind.Unspecified).AddTicks(1514), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 34, true, true, null, null, new DateTime(2023, 4, 21, 13, 15, 19, 30, DateTimeKind.Unspecified).AddTicks(9523), 4 },
                    { 121, new DateTime(2023, 6, 18, 15, 27, 28, 20, DateTimeKind.Unspecified).AddTicks(63), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 76, true, true, null, null, new DateTime(2023, 5, 15, 23, 45, 0, 298, DateTimeKind.Unspecified).AddTicks(9050), 42 },
                    { 122, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 37, false, true, null, null, new DateTime(2024, 1, 27, 16, 58, 55, 854, DateTimeKind.Unspecified).AddTicks(7853), 79 },
                    { 123, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 79, false, true, null, null, new DateTime(2022, 4, 20, 4, 32, 46, 893, DateTimeKind.Unspecified).AddTicks(1278), 117 },
                    { 124, new DateTime(2023, 12, 22, 14, 43, 11, 829, DateTimeKind.Unspecified).AddTicks(7734), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 41, true, true, null, null, new DateTime(2023, 12, 16, 1, 25, 5, 255, DateTimeKind.Unspecified).AddTicks(7150), 26 },
                    { 125, new DateTime(2023, 9, 14, 15, 1, 47, 400, DateTimeKind.Unspecified).AddTicks(5527), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, true, true, null, null, new DateTime(2023, 8, 11, 22, 17, 23, 618, DateTimeKind.Unspecified).AddTicks(3022), 64 },
                    { 126, new DateTime(2023, 11, 5, 8, 26, 8, 222, DateTimeKind.Unspecified).AddTicks(9688), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 45, true, true, null, null, new DateTime(2023, 11, 4, 8, 47, 4, 886, DateTimeKind.Unspecified).AddTicks(2547), 101 },
                    { 127, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, false, true, null, null, new DateTime(2022, 7, 17, 3, 5, 10, 212, DateTimeKind.Unspecified).AddTicks(5249), 11 },
                    { 128, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 48, false, true, null, null, new DateTime(2022, 8, 9, 19, 18, 16, 625, DateTimeKind.Unspecified).AddTicks(1310), 48 },
                    { 129, new DateTime(2022, 6, 7, 13, 30, 24, 882, DateTimeKind.Unspecified).AddTicks(7017), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, true, true, null, null, new DateTime(2022, 6, 5, 10, 27, 9, 843, DateTimeKind.Unspecified).AddTicks(648), 86 },
                    { 130, new DateTime(2022, 7, 20, 9, 14, 39, 22, DateTimeKind.Unspecified).AddTicks(9329), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 52, true, true, null, null, new DateTime(2022, 6, 29, 20, 56, 51, 111, DateTimeKind.Unspecified).AddTicks(174), 124 },
                    { 131, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, false, true, null, null, new DateTime(2024, 2, 25, 9, 46, 6, 641, DateTimeKind.Unspecified).AddTicks(8195), 33 },
                    { 132, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 55, false, true, null, null, new DateTime(2023, 4, 6, 1, 44, 37, 705, DateTimeKind.Unspecified).AddTicks(2402), 71 },
                    { 133, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, false, true, null, null, new DateTime(2023, 1, 29, 16, 13, 4, 24, DateTimeKind.Unspecified).AddTicks(3671), 108 },
                    { 134, new DateTime(2023, 3, 20, 10, 22, 51, 51, DateTimeKind.Unspecified).AddTicks(7872), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 59, true, true, null, null, new DateTime(2023, 2, 24, 12, 21, 16, 297, DateTimeKind.Unspecified).AddTicks(9461), 18 },
                    { 135, new DateTime(2022, 10, 28, 13, 37, 23, 602, DateTimeKind.Unspecified).AddTicks(8473), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, true, true, null, null, new DateTime(2022, 10, 20, 5, 58, 55, 698, DateTimeKind.Unspecified).AddTicks(3672), 55 },
                    { 136, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 63, false, true, null, null, new DateTime(2023, 1, 12, 16, 28, 36, 966, DateTimeKind.Unspecified).AddTicks(3199), 93 },
                    { 137, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, false, true, null, null, new DateTime(2023, 9, 25, 10, 46, 42, 292, DateTimeKind.Unspecified).AddTicks(5900), 3 },
                    { 138, new DateTime(2023, 11, 13, 1, 24, 39, 214, DateTimeKind.Unspecified).AddTicks(1325), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 66, true, true, null, null, new DateTime(2023, 10, 19, 21, 16, 23, 560, DateTimeKind.Unspecified).AddTicks(5427), 40 },
                    { 139, new DateTime(2023, 8, 19, 21, 56, 23, 173, DateTimeKind.Unspecified).AddTicks(6454), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 28, true, true, null, null, new DateTime(2023, 8, 14, 18, 8, 41, 923, DateTimeKind.Unspecified).AddTicks(1299), 78 },
                    { 140, new DateTime(2023, 9, 17, 21, 21, 24, 307, DateTimeKind.Unspecified).AddTicks(8257), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 70, true, true, null, null, new DateTime(2023, 9, 8, 4, 38, 23, 191, DateTimeKind.Unspecified).AddTicks(825), 115 },
                    { 141, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 32, false, true, null, null, new DateTime(2023, 5, 5, 1, 30, 41, 553, DateTimeKind.Unspecified).AddTicks(6698), 25 },
                    { 142, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 73, false, true, null, null, new DateTime(2022, 6, 14, 9, 26, 9, 785, DateTimeKind.Unspecified).AddTicks(3052), 62 },
                    { 143, new DateTime(2024, 4, 22, 20, 29, 16, 825, DateTimeKind.Unspecified).AddTicks(4825), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 35, true, true, null, null, new DateTime(2024, 4, 9, 12, 56, 54, 567, DateTimeKind.Unspecified).AddTicks(5802), 100 },
                    { 144, new DateTime(2022, 5, 11, 13, 4, 57, 722, DateTimeKind.Unspecified).AddTicks(4769), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 77, true, true, null, null, new DateTime(2022, 5, 3, 16, 48, 9, 415, DateTimeKind.Unspecified).AddTicks(8451), 9 },
                    { 145, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 39, false, true, null, null, new DateTime(2023, 12, 28, 16, 35, 6, 483, DateTimeKind.Unspecified).AddTicks(4992), 47 },
                    { 146, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, true, null, null, new DateTime(2023, 10, 24, 10, 32, 46, 141, DateTimeKind.Unspecified).AddTicks(196), 85 },
                    { 147, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 42, false, true, null, null, new DateTime(2022, 12, 3, 18, 28, 14, 372, DateTimeKind.Unspecified).AddTicks(6551), 122 },
                    { 148, new DateTime(2022, 7, 31, 2, 52, 14, 267, DateTimeKind.Unspecified).AddTicks(136), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, true, true, null, null, new DateTime(2022, 7, 29, 20, 34, 49, 127, DateTimeKind.Unspecified).AddTicks(4410), 32 },
                    { 149, new DateTime(2022, 10, 25, 22, 11, 40, 227, DateTimeKind.Unspecified).AddTicks(4225), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 46, true, true, null, null, new DateTime(2022, 10, 23, 1, 50, 14, 3, DateTimeKind.Unspecified).AddTicks(1949), 69 },
                    { 150, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, false, true, null, null, new DateTime(2022, 6, 18, 22, 42, 32, 365, DateTimeKind.Unspecified).AddTicks(7822), 107 },
                    { 151, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 49, false, true, null, null, new DateTime(2023, 7, 29, 14, 11, 54, 676, DateTimeKind.Unspecified).AddTicks(7482), 16 },
                    { 152, new DateTime(2023, 5, 15, 4, 20, 59, 347, DateTimeKind.Unspecified).AddTicks(3614), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, true, true, null, null, new DateTime(2023, 3, 26, 3, 30, 18, 960, DateTimeKind.Unspecified).AddTicks(50), 54 },
                    { 153, new DateTime(2023, 6, 23, 17, 49, 42, 84, DateTimeKind.Unspecified).AddTicks(5268), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 53, true, true, null, null, new DateTime(2023, 6, 18, 14, 0, 0, 227, DateTimeKind.Unspecified).AddTicks(9576), 91 },
                    { 154, new DateTime(2023, 3, 11, 10, 0, 27, 454, DateTimeKind.Unspecified).AddTicks(3787), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, true, true, null, null, new DateTime(2023, 2, 13, 15, 5, 15, 57, DateTimeKind.Unspecified).AddTicks(6203), 1 },
                    { 155, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 57, false, true, null, null, new DateTime(2023, 3, 8, 21, 21, 59, 858, DateTimeKind.Unspecified).AddTicks(4975), 39 },
                    { 156, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, false, true, null, null, new DateTime(2024, 1, 18, 11, 6, 42, 75, DateTimeKind.Unspecified).AddTicks(9843), 76 },
                    { 157, new DateTime(2024, 2, 15, 6, 9, 6, 202, DateTimeKind.Unspecified).AddTicks(5717), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, true, true, null, null, new DateTime(2024, 2, 12, 13, 56, 36, 999, DateTimeKind.Unspecified).AddTicks(1262), 114 },
                    { 158, new DateTime(2023, 11, 4, 4, 39, 53, 6, DateTimeKind.Unspecified).AddTicks(4163), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 22, true, true, null, null, new DateTime(2023, 10, 8, 23, 2, 4, 815, DateTimeKind.Unspecified).AddTicks(3074), 23 },
                    { 159, new DateTime(2024, 1, 7, 22, 3, 58, 921, DateTimeKind.Unspecified).AddTicks(2826), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 64, true, true, null, null, new DateTime(2024, 1, 1, 9, 31, 46, 83, DateTimeKind.Unspecified).AddTicks(2600), 61 },
                    { 160, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 26, false, true, null, null, new DateTime(2023, 8, 27, 20, 56, 51, 586, DateTimeKind.Unspecified).AddTicks(5731), 98 },
                    { 161, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 67, false, true, null, null, new DateTime(2022, 10, 7, 14, 19, 32, 677, DateTimeKind.Unspecified).AddTicks(4828), 8 },
                    { 162, new DateTime(2022, 6, 24, 12, 45, 51, 605, DateTimeKind.Unspecified).AddTicks(7500), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 29, true, true, null, null, new DateTime(2022, 6, 3, 11, 11, 51, 40, DateTimeKind.Unspecified).AddTicks(701), 45 },
                    { 163, new DateTime(2022, 9, 10, 20, 42, 51, 504, DateTimeKind.Unspecified).AddTicks(5098), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 71, true, true, null, null, new DateTime(2022, 8, 26, 14, 33, 57, 135, DateTimeKind.Unspecified).AddTicks(8803), 83 },
                    { 164, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 33, false, true, null, null, new DateTime(2022, 4, 22, 18, 33, 50, 670, DateTimeKind.Unspecified).AddTicks(6099), 121 },
                    { 165, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 75, false, true, null, null, new DateTime(2022, 5, 17, 5, 3, 31, 938, DateTimeKind.Unspecified).AddTicks(5625), 30 },
                    { 166, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 36, false, true, null, null, new DateTime(2023, 3, 29, 8, 57, 32, 234, DateTimeKind.Unspecified).AddTicks(8539), 68 },
                    { 167, new DateTime(2023, 5, 11, 4, 11, 56, 801, DateTimeKind.Unspecified).AddTicks(4469), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 78, true, true, null, null, new DateTime(2023, 4, 22, 9, 51, 18, 532, DateTimeKind.Unspecified).AddTicks(7853), 105 },
                    { 168, new DateTime(2022, 12, 19, 6, 8, 21, 808, DateTimeKind.Unspecified).AddTicks(4208), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 40, true, true, null, null, new DateTime(2022, 12, 16, 11, 28, 44, 535, DateTimeKind.Unspecified).AddTicks(1164), 15 },
                    { 169, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, false, true, null, null, new DateTime(2022, 10, 12, 3, 35, 55, 257, DateTimeKind.Unspecified).AddTicks(9597), 52 },
                    { 170, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 44, false, true, null, null, new DateTime(2022, 11, 5, 14, 5, 36, 525, DateTimeKind.Unspecified).AddTicks(9124), 90 },
                    { 171, new DateTime(2023, 8, 5, 16, 36, 7, 46, DateTimeKind.Unspecified).AddTicks(5371), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, true, true, null, null, new DateTime(2023, 7, 18, 15, 28, 27, 179, DateTimeKind.Unspecified).AddTicks(582), 127 },
                    { 172, new DateTime(2023, 10, 12, 23, 3, 54, 89, DateTimeKind.Unspecified).AddTicks(1279), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 47, true, true, null, null, new DateTime(2023, 10, 11, 18, 53, 23, 120, DateTimeKind.Unspecified).AddTicks(1352), 37 },
                    { 173, new DateTime(2023, 6, 13, 17, 42, 0, 584, DateTimeKind.Unspecified).AddTicks(4601), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, true, true, null, null, new DateTime(2023, 6, 7, 15, 45, 41, 482, DateTimeKind.Unspecified).AddTicks(7223), 75 },
                    { 174, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 51, false, true, null, null, new DateTime(2023, 7, 2, 2, 15, 22, 750, DateTimeKind.Unspecified).AddTicks(6750), 112 },
                    { 175, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, false, true, null, null, new DateTime(2023, 2, 27, 18, 45, 49, 960, DateTimeKind.Unspecified).AddTicks(4927), 22 },
                    { 176, new DateTime(2022, 6, 15, 9, 1, 10, 838, DateTimeKind.Unspecified).AddTicks(8980), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 54, true, true, null, null, new DateTime(2022, 6, 6, 7, 3, 9, 344, DateTimeKind.Unspecified).AddTicks(8978), 59 },
                    { 177, new DateTime(2024, 2, 5, 9, 10, 35, 518, DateTimeKind.Unspecified).AddTicks(8409), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, true, true, null, null, new DateTime(2024, 2, 1, 16, 11, 27, 6, DateTimeKind.Unspecified).AddTicks(3457), 97 },
                    { 178, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 58, false, true, null, null, new DateTime(2024, 2, 26, 9, 54, 35, 711, DateTimeKind.Unspecified).AddTicks(9210), 6 },
                    { 179, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, false, true, null, null, new DateTime(2023, 12, 21, 11, 17, 27, 338, DateTimeKind.Unspecified).AddTicks(249), 44 },
                    { 180, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 62, false, true, null, null, new DateTime(2024, 1, 14, 11, 50, 46, 994, DateTimeKind.Unspecified).AddTicks(2485), 81 },
                    { 181, new DateTime(2022, 11, 6, 6, 49, 4, 267, DateTimeKind.Unspecified).AddTicks(2368), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 23, true, true, null, null, new DateTime(2022, 9, 26, 16, 5, 13, 932, DateTimeKind.Unspecified).AddTicks(2476), 119 },
                    { 182, new DateTime(2022, 12, 20, 20, 22, 40, 853, DateTimeKind.Unspecified).AddTicks(7077), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 65, true, true, null, null, new DateTime(2022, 12, 20, 2, 34, 55, 200, DateTimeKind.Unspecified).AddTicks(2002), 29 },
                    { 183, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 27, false, true, null, null, new DateTime(2022, 8, 15, 15, 50, 29, 638, DateTimeKind.Unspecified).AddTicks(1903), 66 },
                    { 184, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 69, false, true, null, null, new DateTime(2022, 9, 9, 9, 56, 54, 830, DateTimeKind.Unspecified).AddTicks(7401), 104 },
                    { 185, new DateTime(2023, 7, 3, 5, 14, 17, 759, DateTimeKind.Unspecified).AddTicks(2363), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, true, true, null, null, new DateTime(2023, 5, 23, 4, 15, 0, 157, DateTimeKind.Unspecified).AddTicks(102), 13 },
                    { 186, new DateTime(2023, 8, 18, 4, 57, 20, 289, DateTimeKind.Unspecified).AddTicks(7641), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 72, true, true, null, null, new DateTime(2023, 8, 15, 14, 44, 41, 424, DateTimeKind.Unspecified).AddTicks(9629), 51 },
                    { 187, new DateTime(2023, 5, 1, 22, 35, 6, 106, DateTimeKind.Unspecified).AddTicks(3259), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 34, true, true, null, null, new DateTime(2023, 4, 11, 11, 36, 59, 787, DateTimeKind.Unspecified).AddTicks(5501), 88 },
                    { 188, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 76, false, true, null, null, new DateTime(2023, 5, 5, 22, 6, 41, 55, DateTimeKind.Unspecified).AddTicks(5028), 126 },
                    { 189, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 38, false, true, null, null, new DateTime(2023, 3, 1, 0, 53, 56, 518, DateTimeKind.Unspecified).AddTicks(7571), 36 },
                    { 190, new DateTime(2022, 5, 6, 6, 25, 37, 737, DateTimeKind.Unspecified).AddTicks(6686), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 79, true, true, null, null, new DateTime(2022, 4, 10, 2, 54, 27, 649, DateTimeKind.Unspecified).AddTicks(7255), 73 },
                    { 191, new DateTime(2023, 12, 25, 13, 40, 3, 550, DateTimeKind.Unspecified).AddTicks(1419), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 41, true, true, null, null, new DateTime(2023, 12, 5, 23, 46, 46, 12, DateTimeKind.Unspecified).AddTicks(3127), 111 },
                    { 192, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, false, true, null, null, new DateTime(2023, 9, 30, 20, 39, 4, 374, DateTimeKind.Unspecified).AddTicks(8999), 20 },
                    { 193, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 45, false, true, null, null, new DateTime(2023, 10, 25, 7, 8, 45, 642, DateTimeKind.Unspecified).AddTicks(8525), 58 },
                    { 194, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, false, true, null, null, new DateTime(2023, 6, 21, 4, 1, 4, 5, DateTimeKind.Unspecified).AddTicks(4398), 95 },
                    { 195, new DateTime(2022, 8, 13, 17, 53, 18, 793, DateTimeKind.Unspecified).AddTicks(7457), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 48, true, true, null, null, new DateTime(2022, 7, 30, 13, 38, 19, 61, DateTimeKind.Unspecified).AddTicks(54), 5 },
                    { 196, new DateTime(2022, 6, 5, 16, 48, 19, 997, DateTimeKind.Unspecified).AddTicks(8235), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, true, true, null, null, new DateTime(2022, 5, 26, 8, 48, 50, 599, DateTimeKind.Unspecified).AddTicks(6626), 42 },
                    { 197, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 52, false, true, null, null, new DateTime(2022, 6, 19, 19, 18, 31, 867, DateTimeKind.Unspecified).AddTicks(6151), 80 },
                    { 198, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, false, true, null, null, new DateTime(2024, 2, 15, 12, 9, 25, 719, DateTimeKind.Unspecified).AddTicks(1406), 118 },
                    { 199, new DateTime(2022, 5, 9, 13, 50, 38, 893, DateTimeKind.Unspecified).AddTicks(1814), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 56, true, true, null, null, new DateTime(2022, 5, 9, 2, 40, 31, 498, DateTimeKind.Unspecified).AddTicks(1550), 27 },
                    { 200, new DateTime(2023, 2, 2, 6, 37, 0, 90, DateTimeKind.Unspecified).AddTicks(1092), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, true, true, null, null, new DateTime(2023, 1, 19, 10, 33, 6, 460, DateTimeKind.Unspecified).AddTicks(2415), 65 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 7 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 8 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 9 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 10 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 11 });

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
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 41 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 42 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 43 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 44 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 45 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 46 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 47 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 48 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 49 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 50 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 51 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 52 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 53 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 54 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 55 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 56 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 57 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 58 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 59 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 60 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 61 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 62 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 63 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 64 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 65 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 66 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 67 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 68 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 69 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 70 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 71 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 72 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 73 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 74 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 75 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 76 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 77 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 78 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 79 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 80 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 81 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 82 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 83 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 84 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 85 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 86 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 87 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 88 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 89 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 90 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 91 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 92 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 93 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 94 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 95 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 96 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 97 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 98 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 99 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 100 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 101 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 102 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 103 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 104 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 105 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 106 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 107 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 108 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 109 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 110 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 111 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 112 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 113 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 114 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 115 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 116 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 117 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 118 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 119 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 120 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 121 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 122 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 123 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 124 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 125 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 126 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 127 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 128 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 129 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 130 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 131 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 132 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 133 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 134 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 135 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 136 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 137 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 138 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 139 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 140 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 141 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 142 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 143 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 144 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 145 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 146 });

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "EventImageId",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumn: "EventRegistrationId",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "UniversityUnits",
                keyColumn: "UniversityUnitId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "UniversityUnits",
                keyColumn: "UniversityUnitId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UniversityUnits",
                keyColumn: "UniversityUnitId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "UniversityUnits",
                keyColumn: "UniversityUnitId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "UniversityUnits",
                keyColumn: "UniversityUnitId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "UniversityUnits",
                keyColumn: "UniversityUnitId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "UniversityUnits",
                keyColumn: "UniversityUnitId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "UniversityUnits",
                keyColumn: "UniversityUnitId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "UniversityUnits",
                keyColumn: "UniversityUnitId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "UniversityUnits",
                keyColumn: "UniversityUnitId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "UniversityUnits",
                keyColumn: "UniversityUnitId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "UniversityUnits",
                keyColumn: "UniversityUnitId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "UniversityUnits",
                keyColumn: "UniversityUnitId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "UniversityUnits",
                keyColumn: "UniversityUnitId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "UniversityUnits",
                keyColumn: "UniversityUnitId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "UniversityUnits",
                keyColumn: "UniversityUnitId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "UniversityUnits",
                keyColumn: "UniversityUnitId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "UniversityUnits",
                keyColumn: "UniversityUnitId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: 145);
        }
    }
}
