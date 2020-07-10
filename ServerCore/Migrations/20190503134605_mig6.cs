using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ServerCore.Migrations
{
    public partial class mig6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "EstimatedLanding",
                keyColumn: "Id",
                keyValue : 1,
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
