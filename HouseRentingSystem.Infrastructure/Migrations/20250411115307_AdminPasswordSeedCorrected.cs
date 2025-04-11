using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseRentingSystem.Infrastructure.Migrations
{
    public partial class AdminPasswordSeedCorrected : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ec816345-e11b-4df4-b594-fe07ea4c02df", "AQAAAAEAACcQAAAAEKoMj4mTllUEsD/h2+jEK7zMIpFr5LnObT2C6vcnqIFN6Iv49x+2BOT6ted7bevTLg==", "3eeb87e3-a600-4ed2-94e7-53b4e45616a6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "78777bb1-c1dc-409d-b82c-30544d8830ba",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3b82bb3a-580d-4f7e-93c2-607bcd962989", "AQAAAAEAACcQAAAAEPj55Vm4CFpgytnzWE4S/d7T08aotIqpAyTJhsn37cC/J2KbIKHMt8mIobwtKR8TwQ==", "24152204-7cde-46ed-a9b0-63bb8d861d83" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c4e56a34-88a5-41c0-9f3d-f535c778b2ed", "AQAAAAEAACcQAAAAEP0uqxYk0LMdqjM5SMENanF+vImj1zbDBwNWCUFJmVEvChTo555EcBVwXdUY3P9AOQ==", "af4d9308-0fab-469d-bdb5-295c44fad64f" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7c424ca2-19ba-4188-9a7d-7c684e986c54", "AQAAAAEAACcQAAAAENATrV7Wk9d/lCBGKTl77gxwDQOeIJhlUmulhM9Lo/U39JG9citHdw0aCv1llYTBeQ==", "551ed2d6-35de-485a-b2e8-21fa4687b0bb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "78777bb1-c1dc-409d-b82c-30544d8830ba",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "58454b7e-5504-4c6d-b04f-ce1f802d7988", null, "0fa9a4da-008b-4321-a485-fa6339971a60" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "83e84550-b8a0-4772-802d-5eedde16fc45", "AQAAAAEAACcQAAAAEJT0bEjk4+Nqt7e1TqJ+EFcwwx8MGBywE1sNc4Tg/Gga8XVZ61BiQrh9/+CrJG4AQg==", "5d2aaae0-cd38-4bd3-ba8f-e22f7bc28dd0" });
        }
    }
}
