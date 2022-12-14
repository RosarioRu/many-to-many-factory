using Microsoft.EntityFrameworkCore.Migrations;

namespace Factory.Migrations
{
    public partial class AddMachineNamePropertyForMachineClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MachineName",
                table: "Machines",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MachineName",
                table: "Machines");
        }
    }
}
