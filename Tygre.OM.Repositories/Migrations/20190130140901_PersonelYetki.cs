using Microsoft.EntityFrameworkCore.Migrations;

namespace Tygre.OM.Repositories.Migrations
{
    public partial class PersonelYetki : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Icon",
                table: "Yetkiler",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Icon",
                table: "Yetkiler");
        }
    }
}
