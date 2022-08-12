using Microsoft.EntityFrameworkCore.Migrations;

namespace Factory.Migrations
{
    public partial class RemoveEngineerNamePropertyFromJoinEngineerMachineClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EngineerMachines_Engineers_EngineerId",
                table: "EngineerMachines");

            migrationBuilder.DropColumn(
                name: "EngineerName",
                table: "EngineerMachines");

            migrationBuilder.AlterColumn<int>(
                name: "EngineerId",
                table: "EngineerMachines",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_EngineerMachines_Engineers_EngineerId",
                table: "EngineerMachines",
                column: "EngineerId",
                principalTable: "Engineers",
                principalColumn: "EngineerId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EngineerMachines_Engineers_EngineerId",
                table: "EngineerMachines");

            migrationBuilder.AlterColumn<int>(
                name: "EngineerId",
                table: "EngineerMachines",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "EngineerName",
                table: "EngineerMachines",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_EngineerMachines_Engineers_EngineerId",
                table: "EngineerMachines",
                column: "EngineerId",
                principalTable: "Engineers",
                principalColumn: "EngineerId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
