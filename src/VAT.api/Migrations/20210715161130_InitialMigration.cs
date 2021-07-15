using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VAT.api.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VMT_Countys",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    county_fips = table.Column<int>(type: "int", nullable: false),
                    county_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    state_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    county_vmt = table.Column<int>(type: "int", nullable: false),
                    baseline_jan_vmt = table.Column<int>(type: "int", nullable: false),
                    percent_change_from_jan = table.Column<float>(type: "real", nullable: false),
                    mean7_county_vmt = table.Column<float>(type: "real", nullable: false),
                    mean7_percent_change_from_jan = table.Column<float>(type: "real", nullable: false),
                    date_at_low = table.Column<DateTime>(type: "datetime2", nullable: false),
                    mean7_county_vmt_at_low = table.Column<float>(type: "real", nullable: false),
                    percent_change_from_low = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VMT_Countys", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VMT_Countys");
        }
    }
}
