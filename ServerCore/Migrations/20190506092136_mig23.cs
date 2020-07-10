using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ServerCore.Migrations
{
    public partial class mig23 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "EstimatedLanding",
                keyColumn: "Id",
                keyValue: 1,
                column: "EstimatedTime",
                value: new DateTime(2019, 5, 3, 17, 26, 4, 187, DateTimeKind.Local).AddTicks(3874));

            migrationBuilder.UpdateData(
                table: "EstimatedLanding",
                keyColumn: "Id",
                keyValue: 2,
                column: "EstimatedTime",
                value: new DateTime(2019, 5, 3, 17, 16, 4, 194, DateTimeKind.Local).AddTicks(1792));

            migrationBuilder.UpdateData(
                table: "EstimatedLanding",
                keyColumn: "Id",
                keyValue: 3,
                column: "EstimatedTime",
                value: new DateTime(2019, 5, 3, 17, 6, 4, 194, DateTimeKind.Local).AddTicks(1871));

            migrationBuilder.UpdateData(
                table: "EstimatedTakeOff",
                keyColumn: "Id",
                keyValue: 1,
                column: "EstimatedTime",
                value: new DateTime(2019, 5, 3, 16, 51, 4, 198, DateTimeKind.Local).AddTicks(4876));

            migrationBuilder.UpdateData(
                table: "EstimatedTakeOff",
                keyColumn: "Id",
                keyValue: 2,
                column: "EstimatedTime",
                value: new DateTime(2019, 5, 3, 16, 56, 4, 198, DateTimeKind.Local).AddTicks(8316));
        }
    }
}
