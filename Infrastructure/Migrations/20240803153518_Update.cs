using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class Update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ContryName",
                table: "Countries",
                newName: "CountryName");

            migrationBuilder.RenameColumn(
                name: "ContryCode",
                table: "Countries",
                newName: "CountryCode");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CountryName",
                table: "Countries",
                newName: "ContryName");

            migrationBuilder.RenameColumn(
                name: "CountryCode",
                table: "Countries",
                newName: "ContryCode");
        }
    }
}
