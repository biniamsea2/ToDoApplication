using Microsoft.EntityFrameworkCore.Migrations;

namespace ToDoWebApp.Migrations
{
    public partial class testing : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ToDoList",
                table: "ToDoList");

            migrationBuilder.RenameTable(
                name: "ToDoList",
                newName: "ToDoPackage");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ToDoPackage",
                table: "ToDoPackage",
                column: "ID");

            migrationBuilder.UpdateData(
                table: "ToDoPackage",
                keyColumn: "ID",
                keyValue: 1,
                column: "Priority",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ToDoPackage",
                keyColumn: "ID",
                keyValue: 2,
                column: "Priority",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ToDoPackage",
                keyColumn: "ID",
                keyValue: 3,
                column: "Priority",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ToDoPackage",
                keyColumn: "ID",
                keyValue: 4,
                column: "Priority",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ToDoPackage",
                keyColumn: "ID",
                keyValue: 5,
                column: "Priority",
                value: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ToDoPackage",
                table: "ToDoPackage");

            migrationBuilder.RenameTable(
                name: "ToDoPackage",
                newName: "ToDoList");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ToDoList",
                table: "ToDoList",
                column: "ID");

            migrationBuilder.UpdateData(
                table: "ToDoList",
                keyColumn: "ID",
                keyValue: 1,
                column: "Priority",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ToDoList",
                keyColumn: "ID",
                keyValue: 2,
                column: "Priority",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ToDoList",
                keyColumn: "ID",
                keyValue: 3,
                column: "Priority",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ToDoList",
                keyColumn: "ID",
                keyValue: 4,
                column: "Priority",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ToDoList",
                keyColumn: "ID",
                keyValue: 5,
                column: "Priority",
                value: 1);
        }
    }
}
