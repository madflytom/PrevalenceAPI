using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace IO.Swagger.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Prevalence",
                columns: table => new
                {
                    prevalanceId = table.Column<Guid>(nullable: false),
                    CountryName = table.Column<string>(nullable: true),
                    DiseaseName = table.Column<string>(nullable: false),
                    Population = table.Column<int>(nullable: true),
                    PrevalanceFactor = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prevalence", x => x.prevalanceId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Prevalence");
        }
    }
}
