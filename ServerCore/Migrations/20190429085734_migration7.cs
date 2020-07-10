using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ServerCore.Migrations
{
    public partial class migration7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Planes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ReadyToMove = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Planes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Stations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsAvailable = table.Column<bool>(nullable: false),
                    PlaneID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stations_Planes_PlaneID",
                        column: x => x.PlaneID,
                        principalTable: "Planes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ConnectedStations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FromStationID = table.Column<int>(nullable: true),
                    ToStationID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConnectedStations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ConnectedStations_Stations_FromStationID",
                        column: x => x.FromStationID,
                        principalTable: "Stations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ConnectedStations_Stations_ToStationID",
                        column: x => x.ToStationID,
                        principalTable: "Stations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Planes",
                columns: new[] { "Id", "ReadyToMove" },
                values: new object[,]
                {
                    { 1, true },
                    { 2, true },
                    { 3, false },
                    { 4, true },
                    { 5, false }
                });

            migrationBuilder.InsertData(
                table: "Stations",
                columns: new[] { "Id", "IsAvailable", "PlaneID" },
                values: new object[,]
                {
                    { 1, true, null },
                    { 2, true, null },
                    { 3, true, null },
                    { 4, true, null },
                    { 5, true, null }
                });

            migrationBuilder.InsertData(
                table: "ConnectedStations",
                columns: new[] { "Id", "FromStationID", "ToStationID" },
                values: new object[,]
                {
                    { 1, 1, 2 },
                    { 2, 2, 3 },
                    { 3, 1, 4 },
                    { 4, 4, 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ConnectedStations_FromStationID",
                table: "ConnectedStations",
                column: "FromStationID");

            migrationBuilder.CreateIndex(
                name: "IX_ConnectedStations_ToStationID",
                table: "ConnectedStations",
                column: "ToStationID");

            migrationBuilder.CreateIndex(
                name: "IX_Stations_PlaneID",
                table: "Stations",
                column: "PlaneID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ConnectedStations");

            migrationBuilder.DropTable(
                name: "Stations");

            migrationBuilder.DropTable(
                name: "Planes");
        }
    }
}
