using Microsoft.EntityFrameworkCore.Migrations;

namespace IndependentTravel.Migrations
{
    public partial class UpdateDestinationModel_AddIsDelete : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Destinations",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Destinations");
        }
    }
}
