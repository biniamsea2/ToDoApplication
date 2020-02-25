using Microsoft.EntityFrameworkCore.Migrations;

namespace ToDoWebApp.Migrations
{
    public partial class seededDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ToDoList",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Task = table.Column<string>(nullable: false),
                    Priority = table.Column<int>(nullable: false),
                    Completed = table.Column<bool>(nullable: false),
                    DueDate = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToDoList", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "ToDoList",
                columns: new[] { "ID", "Completed", "DueDate", "Priority", "Task" },
                values: new object[,]
                {
                    { 1, false, "2/20/2020", 1, "Do Homework" },
                    { 2, false, "2/26/2020", 3, "Get an oil change" },
                    { 3, true, "2/24/2020", 2, "Clean room" },
                    { 4, true, "2/23/2020", 3, "Go to the gym" },
                    { 5, false, "2/22/2020", 1, "Wash dishes" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ToDoList");
        }
    }
}
