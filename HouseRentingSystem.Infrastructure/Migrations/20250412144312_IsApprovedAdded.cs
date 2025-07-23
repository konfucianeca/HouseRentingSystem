using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseRentingSystem.Infrastructure.Migrations
{
    public partial class IsApprovedAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsApproved",
                table: "Houses",
                type: "bit",
                nullable: false,
                defaultValue: false,
                comment: "Is house approved by administrator");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "682b54e4-9bec-4c96-8c40-37462d1bf7c1", "AQAAAAEAACcQAAAAEMhsGiipMbliLwqMfBRgw51HNrgBPc5Z4wxy2Fd3RasRNf8WAEU0kUzRB2+7SH6i3A==", "5e9d1188-bacf-4c49-a356-f56b59741fcd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "78777bb1-c1dc-409d-b82c-30544d8830ba",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4f765a75-9588-4857-9c4b-eceae1bfda5f", "AQAAAAEAACcQAAAAEFQnZBexUpZy2m2+TGxUi0TYsHDLcvfivawII3RjFWz3VUgFHEXwo4Fcaegubb2U9w==", "43463545-9bfd-47ef-88a6-7121c8871983" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3be8ba59-73c9-415c-9be8-9ddbe36c64b5", "AQAAAAEAACcQAAAAEEP1f51v09oI1ZHfrQdv5rp2DALLQWCwO/wFgSwKoaj+nb0oSowdINKyg2NE1N0jyg==", "8e35faf1-ca83-4270-aa52-4a93f31b1a08" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsApproved",
                table: "Houses");

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
    }
}
