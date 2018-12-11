using Microsoft.EntityFrameworkCore.Migrations;

namespace SuharjoCore.Data.Migrations
{
    public partial class migration4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Code",
                table: "Categories");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Code",
                table: "Categories",
                nullable: false,
                defaultValue: 0);
        }
    }
}
