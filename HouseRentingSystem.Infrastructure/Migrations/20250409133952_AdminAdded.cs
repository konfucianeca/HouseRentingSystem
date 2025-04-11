using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseRentingSystem.Infrastructure.Migrations
{
    public partial class AdminAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "83e84550-b8a0-4772-802d-5eedde16fc45", "AQAAAAEAACcQAAAAEJT0bEjk4+Nqt7e1TqJ+EFcwwx8MGBywE1sNc4Tg/Gga8XVZ61BiQrh9/+CrJG4AQg==", "5d2aaae0-cd38-4bd3-ba8f-e22f7bc28dd0" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "78777bb1-c1dc-409d-b82c-30544d8830ba", 0, "58454b7e-5504-4c6d-b04f-ce1f802d7988", "admin@mail.com", false, "Great", "Admin", false, null, "ADMIN@MAIL.COM", "ADMIN@MAIL.COM", null, null, false, "0fa9a4da-008b-4321-a485-fa6339971a60", false, "admin@mail.com" });

            migrationBuilder.InsertData(
                table: "Agents",
                columns: new[] { "Id", "PhoneNumber", "UserId" },
                values: new object[] { 3, "+359888888887", "78777bb1-c1dc-409d-b82c-30544d8830ba" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Agents",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "78777bb1-c1dc-409d-b82c-30544d8830ba");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "70e20011-023c-4977-8348-f1e3c800bf58", "AQAAAAEAACcQAAAAECH3GxEJY+ty8FptlH4jZyolQ+xkIyqujRCT/ZtvmtcfNCz5J7+xXac1cjaW/XXEsA==", "09952044-94df-4a6a-afc6-8c685e741833" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "59421a01-8982-4fcd-89d6-a1d90bf94c66", "AQAAAAEAACcQAAAAELNf6HIRcQ/n0QSCC0/gTvCWVRLAxCvttON0WZH8Frt/oqEFgntqiWK7wkwnroMPDA==", "a3a44f91-dc4c-4903-90c8-9c4397094020" });
        }
    }
}
