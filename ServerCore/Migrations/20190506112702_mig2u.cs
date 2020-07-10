using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ServerCore.Migrations
{
    public partial class mig2u : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "EstimatedLanding",
                keyColumn: "Id",
                keyValue: 1,
                column: "EstimatedTime",
                value: new DateTime(2019, 5, 6, 15, 7, 1, 373, DateTimeKind.Local).AddTicks(1777));

            migrationBuilder.UpdateData(
                table: "EstimatedLanding",
                keyColumn: "Id",
                keyValue: 2,
                column: "EstimatedTime",
                value: new DateTime(2019, 5, 6, 14, 57, 1, 379, DateTimeKind.Local).AddTicks(5331));

            migrationBuilder.UpdateData(
                table: "EstimatedLanding",
                keyColumn: "Id",
                keyValue: 3,
                column: "EstimatedTime",
                value: new DateTime(2019, 5, 6, 14, 47, 1, 379, DateTimeKind.Local).AddTicks(5411));

            migrationBuilder.UpdateData(
                table: "EstimatedTakeOff",
                keyColumn: "Id",
                keyValue: 1,
                column: "EstimatedTime",
                value: new DateTime(2019, 5, 6, 14, 32, 1, 382, DateTimeKind.Local).AddTicks(4262));

            migrationBuilder.UpdateData(
                table: "EstimatedTakeOff",
                keyColumn: "Id",
                keyValue: 2,
                column: "EstimatedTime",
                value: new DateTime(2019, 5, 6, 14, 37, 1, 382, DateTimeKind.Local).AddTicks(8621));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "EstimatedLanding",
                keyColumn: "Id",
                keyValue: 1,
                column: "EstimatedTime",
                value: new DateTime(2019, 5, 6, 13, 1, 35, 650, DateTimeKind.Local).AddTicks(3186));

            migrationBuilder.UpdateData(
                table: "EstimatedLanding",
                keyColumn: "Id",
                keyValue: 2,
                column: "EstimatedTime",
                value: new DateTime(2019, 5, 6, 12, 51, 35, 652, DateTimeKind.Local).AddTicks(5625));

            migrationBuilder.UpdateData(
                table: "EstimatedLanding",
                keyColumn: "Id",
                keyValue: 3,
                column: "EstimatedTime",
                value: new DateTime(2019, 5, 6, 12, 41, 35, 652, DateTimeKind.Local).AddTicks(5645));

            migrationBuilder.UpdateData(
                table: "EstimatedTakeOff",
                keyColumn: "Id",
                keyValue: 1,
                column: "EstimatedTime",
                value: new DateTime(2019, 5, 6, 12, 26, 35, 653, DateTimeKind.Local).AddTicks(6593));

            migrationBuilder.UpdateData(
                table: "EstimatedTakeOff",
                keyColumn: "Id",
                keyValue: 2,
                column: "EstimatedTime",
                value: new DateTime(2019, 5, 6, 12, 31, 35, 653, DateTimeKind.Local).AddTicks(7744));
        }
    }
}
