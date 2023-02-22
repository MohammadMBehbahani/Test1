using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FishManagement_Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fishes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FishType = table.Column<string>(type: "nvarchar(140)", maxLength: 140, nullable: false),
                    FishFoodWeight = table.Column<double>(type: "float", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fishes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tanks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TankName = table.Column<string>(type: "nvarchar(140)", maxLength: 140, nullable: false),
                    FishTotalFoodWeight = table.Column<double>(type: "float", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tanks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FishToTanks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TankId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FishId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FishName = table.Column<string>(type: "nvarchar(140)", maxLength: 140, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FishToTanks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FishToTanks_Fishes_FishId",
                        column: x => x.FishId,
                        principalTable: "Fishes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FishToTanks_Tanks_TankId",
                        column: x => x.TankId,
                        principalTable: "Tanks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FishToTanks_FishId",
                table: "FishToTanks",
                column: "FishId");

            migrationBuilder.CreateIndex(
                name: "IX_FishToTanks_TankId",
                table: "FishToTanks",
                column: "TankId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FishToTanks");

            migrationBuilder.DropTable(
                name: "Fishes");

            migrationBuilder.DropTable(
                name: "Tanks");
        }
    }
}
