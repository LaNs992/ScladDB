using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace склад.Migrations
{
    public partial class ScladTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ScladDB",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    name = table.Column<string>(nullable: true),
                    raz = table.Column<string>(nullable: true),
                    mater = table.Column<string>(nullable: true),
                    kol = table.Column<double>(nullable: false),
                    min = table.Column<decimal>(nullable: false),
                    price = table.Column<double>(nullable: false),
                    fulprice = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScladDB", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ScladDB");
        }
    }
}
