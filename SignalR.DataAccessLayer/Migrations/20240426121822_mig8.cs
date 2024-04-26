using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SignalR.DataAccessLayer.Migrations
{
    public partial class mig8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImageURL",
                table: "Discounts",
                newName: "ImageUrl");

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "Discounts",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Discounts");

            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Discounts",
                newName: "ImageURL");
        }
    }
}
