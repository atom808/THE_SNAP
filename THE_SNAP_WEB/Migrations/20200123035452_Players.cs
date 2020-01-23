using Microsoft.EntityFrameworkCore.Migrations;

namespace THE_SNAP_WEB.Migrations
{
    public partial class Players : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "name",
                table: "Teams",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "imageUrl",
                table: "Teams",
                newName: "ImageUrl");

            migrationBuilder.RenameColumn(
                name: "division",
                table: "Teams",
                newName: "Division");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Teams",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Teams",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Teams",
                newName: "imageUrl");

            migrationBuilder.RenameColumn(
                name: "Division",
                table: "Teams",
                newName: "division");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Teams",
                newName: "id");
        }
    }
}
