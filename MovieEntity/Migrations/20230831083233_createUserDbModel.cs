using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieEntity.Migrations
{
    public partial class createUserDbModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_theatre",
                table: "theatre");

            migrationBuilder.RenameTable(
                name: "theatre",
                newName: "TheatreModel");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TheatreModel",
                table: "TheatreModel",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TheatreModel",
                table: "TheatreModel");

            migrationBuilder.RenameTable(
                name: "TheatreModel",
                newName: "theatre");

            migrationBuilder.AddPrimaryKey(
                name: "PK_theatre",
                table: "theatre",
                column: "Id");
        }
    }
}
