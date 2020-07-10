using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ServerCore.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "EstimatedLanding",
                keyColumn: "Id",
                keyValue: 1,
                column: "EstimatedTime",
                value: new DateTime(2019, 4, 30, 20, 51, 52, 562, DateTimeKind.Local).AddTicks(117));

            migrationBuilder.UpdateData(
                table: "EstimatedLanding",
                keyColumn: "Id",
                keyValue: 2,
                column: "EstimatedTime",
                value: new DateTime(2019, 4, 30, 20, 41, 52, 566, DateTimeKind.Local).AddTicks(8829));

            migrationBuilder.UpdateData(
                table: "EstimatedLanding",
                keyColumn: "Id",
                keyValue: 3,
                column: "EstimatedTime",
                value: new DateTime(2019, 4, 30, 20, 31, 52, 566, DateTimeKind.Local).AddTicks(8874));

            migrationBuilder.UpdateData(
                table: "EstimatedTakeOff",
                keyColumn: "Id",
                keyValue: 1,
                column: "EstimatedTime",
                value: new DateTime(2019, 4, 30, 20, 16, 52, 569, DateTimeKind.Local).AddTicks(3249));

            migrationBuilder.UpdateData(
                table: "EstimatedTakeOff",
                keyColumn: "Id",
                keyValue: 2,
                column: "EstimatedTime",
                value: new DateTime(2019, 4, 30, 20, 21, 52, 569, DateTimeKind.Local).AddTicks(5991));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "EstimatedLanding",
                keyColumn: "Id",
                keyValue: 1,
                column: "EstimatedTime",
                value: new DateTime(2019, 4, 29, 13, 10, 7, 729, DateTimeKind.Local).AddTicks(4719));

            migrationBuilder.UpdateData(
                table: "EstimatedLanding",
                keyColumn: "Id",
                keyValue: 2,
                column: "EstimatedTime",
                value: new DateTime(2019, 4, 29, 13, 0, 7, 738, DateTimeKind.Local).AddTicks(4120));

            migrationBuilder.UpdateData(
                table: "EstimatedLanding",
                keyColumn: "Id",
                keyValue: 3,
                column: "EstimatedTime",
                value: new DateTime(2019, 4, 29, 12, 50, 7, 738, DateTimeKind.Local).AddTicks(4139));

            migrationBuilder.UpdateData(
                table: "EstimatedTakeOff",
                keyColumn: "Id",
                keyValue: 1,
                column: "EstimatedTime",
                value: new DateTime(2019, 4, 29, 12, 35, 7, 739, DateTimeKind.Local).AddTicks(6322));

            migrationBuilder.UpdateData(
                table: "EstimatedTakeOff",
                keyColumn: "Id",
                keyValue: 2,
                column: "EstimatedTime",
                value: new DateTime(2019, 4, 29, 12, 40, 7, 739, DateTimeKind.Local).AddTicks(7581));
        }
    }
}
