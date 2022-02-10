using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Project6.Migrations
{
    public partial class ConnerInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "TaskId",
                keyValue: 1,
                columns: new[] { "DueDate", "Task" },
                values: new object[] { new DateTime(2022, 2, 9, 22, 53, 12, 286, DateTimeKind.Local).AddTicks(3261), "Finish this project" });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "TaskId", "CategoryId", "Completed", "DueDate", "QuadrantId", "Task" },
                values: new object[] { 2, 3, false, new DateTime(2022, 2, 9, 22, 53, 12, 289, DateTimeKind.Local).AddTicks(1759), 2, "Study for Exam" });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "TaskId", "CategoryId", "Completed", "DueDate", "QuadrantId", "Task" },
                values: new object[] { 3, 3, false, new DateTime(2022, 2, 9, 22, 53, 12, 289, DateTimeKind.Local).AddTicks(1847), 3, "Clean the Dishes" });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "TaskId", "CategoryId", "Completed", "DueDate", "QuadrantId", "Task" },
                values: new object[] { 4, 1, false, new DateTime(2022, 2, 9, 22, 53, 12, 289, DateTimeKind.Local).AddTicks(1855), 4, "Sleep" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "TaskId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "TaskId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "TaskId",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "TaskId",
                keyValue: 1,
                columns: new[] { "DueDate", "Task" },
                values: new object[] { new DateTime(2022, 2, 9, 14, 17, 13, 553, DateTimeKind.Local).AddTicks(6924), null });
        }
    }
}
