using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Project6.Migrations
{
    public partial class ConnerSecond : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "TaskId",
                keyValue: 1,
                column: "DueDate",
                value: new DateTime(2022, 2, 10, 14, 17, 30, 944, DateTimeKind.Local).AddTicks(3855));

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "TaskId",
                keyValue: 2,
                column: "DueDate",
                value: new DateTime(2022, 2, 10, 14, 17, 30, 947, DateTimeKind.Local).AddTicks(590));

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "TaskId",
                keyValue: 3,
                column: "DueDate",
                value: new DateTime(2022, 2, 10, 14, 17, 30, 947, DateTimeKind.Local).AddTicks(668));

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "TaskId",
                keyValue: 4,
                column: "DueDate",
                value: new DateTime(2022, 2, 10, 14, 17, 30, 947, DateTimeKind.Local).AddTicks(676));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "TaskId",
                keyValue: 1,
                column: "DueDate",
                value: new DateTime(2022, 2, 9, 22, 53, 12, 286, DateTimeKind.Local).AddTicks(3261));

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "TaskId",
                keyValue: 2,
                column: "DueDate",
                value: new DateTime(2022, 2, 9, 22, 53, 12, 289, DateTimeKind.Local).AddTicks(1759));

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "TaskId",
                keyValue: 3,
                column: "DueDate",
                value: new DateTime(2022, 2, 9, 22, 53, 12, 289, DateTimeKind.Local).AddTicks(1847));

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "TaskId",
                keyValue: 4,
                column: "DueDate",
                value: new DateTime(2022, 2, 9, 22, 53, 12, 289, DateTimeKind.Local).AddTicks(1855));
        }
    }
}
