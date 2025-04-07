using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseRentingSystem.Infrastructure.Migrations
{
    public partial class UserExtended : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Categories",
                type: "int",
                nullable: false,
                comment: "Category Identifier",
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "Categoru Identifier")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "70e20011-023c-4977-8348-f1e3c800bf58", "Teodor", "Lesly", "GUEST@MAIL.COM", "GUEST@MAIL.COM", "AQAAAAEAACcQAAAAECH3GxEJY+ty8FptlH4jZyolQ+xkIyqujRCT/ZtvmtcfNCz5J7+xXac1cjaW/XXEsA==", "09952044-94df-4a6a-afc6-8c685e741833" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "59421a01-8982-4fcd-89d6-a1d90bf94c66", "Linda", "Michaels", "AGENT@MAIL.COM", "AGENT@MAIL.COM", "AQAAAAEAACcQAAAAELNf6HIRcQ/n0QSCC0/gTvCWVRLAxCvttON0WZH8Frt/oqEFgntqiWK7wkwnroMPDA==", "a3a44f91-dc4c-4903-90c8-9c4397094020" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Categories",
                type: "int",
                nullable: false,
                comment: "Categoru Identifier",
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "Category Identifier")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6453fc2a-e2b3-41de-9b20-3cba449cd81f", "guest@mail.com", "guest@mail.com", "AQAAAAEAACcQAAAAEAFUJwwA1DCduwEYJDQdrRgKrBPS9/dl3A1eoEyBYswgRh/6IkJhDxen0kdhp0NiLA==", "229d08d6-c408-4c7f-8c30-2a34ba01a9c6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "412942ab-6a6b-40c9-8e51-4c76e0cf6641", "agent@mail.com", "agent@mail.com", "AQAAAAEAACcQAAAAEOLVuQEcsX2U90mHqwY69BCv2xFC5SoKPsD98PVucsBXmvzRBPowtnW6iYtS41hQuw==", "b1848fce-439f-4a47-98fc-7ec19009130d" });
        }
    }
}
