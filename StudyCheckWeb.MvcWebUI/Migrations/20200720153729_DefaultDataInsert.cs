using Microsoft.EntityFrameworkCore.Migrations;

namespace StudyCheckWeb.MvcWebUI.Migrations
{
    public partial class DefaultDataInsert : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table:"AspNetRoles",
                columns: new[] {"Id","Name","NormalizedName","ConcurrencyStamp"},
                values:new object[] {"STDCHK-DFALT-ROL-DATA-00001","Admin","ADMIN","admin"}
                );
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "Name", "NormalizedName", "ConcurrencyStamp" },
                values: new object[] { "STDCHK-DFALT-ROL-DATA-00002", "User", "USER", "user" }
                );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
