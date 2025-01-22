using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseRentingSystem.Infrastructure.Migrations
{
    public partial class HouseImageChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://ap.rdcpix.com/d6b96afc29bb0c8e960c121e77e2f863l-m3737799178rd-w2048_h1536.webp");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aa07df5a-18d8-412b-9ec8-2ae975ca874e", "AQAAAAEAACcQAAAAEJlx1knjhobdVwAgf+SbFOx/LAXeVEawTE1uzYfL6TLFCD/jrLbLaabJ3O5g89Fzlg==", "932ae911-a735-4561-a5e5-a8a6d0d76e42" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aa726fd7-a452-4938-95e0-1bf1ed6d7811", "AQAAAAEAACcQAAAAECsxmvdAm+WEBfiaXUYsYJTMm28BynKzuwBBIMJKcRHx4tVUkX+HYAkPbyHoFD1sYg==", "2f61bbf2-a96d-4de0-9cb3-a20d65b5d87e" });

            migrationBuilder.UpdateData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://www.luxury-architecture.net/wp-content/uploads/2017/12/1513217889-7597-FAIRWAYS-010.jpg");
        }
    }
}
