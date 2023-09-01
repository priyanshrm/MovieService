using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieEntity.Migrations
{
    public partial class createUserDbModel3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "user",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phone = table.Column<long>(type: "bigint", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "user");

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
    }
}
