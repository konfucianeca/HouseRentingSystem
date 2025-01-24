using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseRentingSystem.Infrastructure.Migrations
{
    public partial class UniqueConstraintForPhoneNumberAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6453fc2a-e2b3-41de-9b20-3cba449cd81f", "AQAAAAEAACcQAAAAEAFUJwwA1DCduwEYJDQdrRgKrBPS9/dl3A1eoEyBYswgRh/6IkJhDxen0kdhp0NiLA==", "229d08d6-c408-4c7f-8c30-2a34ba01a9c6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "412942ab-6a6b-40c9-8e51-4c76e0cf6641", "AQAAAAEAACcQAAAAEOLVuQEcsX2U90mHqwY69BCv2xFC5SoKPsD98PVucsBXmvzRBPowtnW6iYtS41hQuw==", "b1848fce-439f-4a47-98fc-7ec19009130d" });

            migrationBuilder.CreateIndex(
                name: "IX_Agents_PhoneNumber",
                table: "Agents",
                column: "PhoneNumber",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Agents_PhoneNumber",
                table: "Agents");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "34c48507-fff9-4658-8551-374e18f8cf94", "AQAAAAEAACcQAAAAEBjAWwkMt1Ufhmw3QhxgLas00E9AafuDWVBvoX2oEBKc+87qef92YsqJ6LoPC/EqLA==", "2b3cf718-c371-4d36-bde8-f7d785b4ead2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f93b099a-9be9-44e7-8427-056031e7c201", "AQAAAAEAACcQAAAAEE9K7UE5FWOgFaIICAaMVjMX9PbM18dLtH8VJ2s8Z0ZNy7n6TO09dE6ZaKVn9kT/iQ==", "2e331563-4866-4e8d-ac76-1721a046535a" });
        }
    }
}
