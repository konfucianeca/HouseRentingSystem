using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseRentingSystem.Infrastructure.Migrations
{
    public partial class UserClaimsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUserClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "UserId" },
                values: new object[,]
                {
                    { 1, "user:fullname", "Agent Agentov", "dea12856-c198-4129-b3f3-b893d8395082" },
                    { 2, "user:fullname", "Guest Guestov", "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e" },
                    { 3, "user:fullname", "Great Admin", "78777bb1-c1dc-409d-b82c-30544d8830b" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "12b730c5-372b-4021-8e9e-d4bb829f7072", "AQAAAAEAACcQAAAAEFPgRVqJhRc7OpPZLKi7nxNw/X0MlxEsJRozbZ3sii6qM/EffWoBo+JnPhS2y6LsDw==", "e8a0127f-807f-4eda-b986-f9e2ddcf6759" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "78777bb1-c1dc-409d-b82c-30544d8830ba",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cbf89f0e-6cdf-439d-8b90-782dcf800a52", "AQAAAAEAACcQAAAAEFQYGu3MaX4v2qfesmKVabYw6+YcJODQF1ii1guiZyPNeMoIJrQGaYzzW/DPhfo9mg==", "c3344c82-f198-4b0a-981e-47db8c5f98eb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7dd91f5d-ce59-460d-a40f-0f09ff8a3678", "AQAAAAEAACcQAAAAEKl7FxcYJ12q+hB9+4Xycdyx9fCT1b+IpHTId3ok2CmDORNFJMDByxLYbixRErlCBA==", "07eca3ac-47a5-4450-bcaf-808925c5a3cc" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 3);

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
    }
}
