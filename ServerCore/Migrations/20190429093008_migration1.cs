using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ServerCore.Migrations
{
    public partial class migration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ConnectedStations_Stations_FromStationID",
                table: "ConnectedStations");

            migrationBuilder.AlterColumn<int>(
                name: "FromStationID",
                table: "ConnectedStations",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "EstimatedLanding",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FlightNum = table.Column<int>(nullable: false),
                    EstimatedTime = table.Column<DateTime>(nullable: false),
                    PlaneID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstimatedLanding", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EstimatedLanding_Planes_PlaneID",
                        column: x => x.PlaneID,
                        principalTable: "Planes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EstimatedTakeOff",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FlightNum = table.Column<int>(nullable: false),
                    EstimatedTime = table.Column<DateTime>(nullable: false),
                    PlaneID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstimatedTakeOff", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EstimatedTakeOff_Planes_PlaneID",
                        column: x => x.PlaneID,
                        principalTable: "Planes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "EstimatedLanding",
                columns: new[] { "Id", "EstimatedTime", "FlightNum", "PlaneID" },
                values: new object[,]
                {
                    { 1, new DateTime(2019, 4, 29, 13, 10, 7, 729, DateTimeKind.Local).AddTicks(4719), 123, 1 },
                    { 2, new DateTime(2019, 4, 29, 13, 0, 7, 738, DateTimeKind.Local).AddTicks(4120), 103, 2 },
                    { 3, new DateTime(2019, 4, 29, 12, 50, 7, 738, DateTimeKind.Local).AddTicks(4139), 23, 3 }
                });

            migrationBuilder.InsertData(
                table: "EstimatedTakeOff",
                columns: new[] { "Id", "EstimatedTime", "FlightNum", "PlaneID" },
                values: new object[,]
                {
                    { 1, new DateTime(2019, 4, 29, 12, 35, 7, 739, DateTimeKind.Local).AddTicks(6322), 222, 4 },
                    { 2, new DateTime(2019, 4, 29, 12, 40, 7, 739, DateTimeKind.Local).AddTicks(7581), 111, 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_EstimatedLanding_PlaneID",
                table: "EstimatedLanding",
                column: "PlaneID");

            migrationBuilder.CreateIndex(
                name: "IX_EstimatedTakeOff_PlaneID",
                table: "EstimatedTakeOff",
                column: "PlaneID");

            migrationBuilder.AddForeignKey(
                name: "FK_ConnectedStations_Stations_FromStationID",
                table: "ConnectedStations",
                column: "FromStationID",
                principalTable: "Stations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ConnectedStations_Stations_FromStationID",
                table: "ConnectedStations");

            migrationBuilder.DropTable(
                name: "EstimatedLanding");

            migrationBuilder.DropTable(
                name: "EstimatedTakeOff");

            migrationBuilder.AlterColumn<int>(
                name: "FromStationID",
                table: "ConnectedStations",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_ConnectedStations_Stations_FromStationID",
                table: "ConnectedStations",
                column: "FromStationID",
                principalTable: "Stations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
