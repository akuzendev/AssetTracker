using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AssetTracker.Data.Migrations
{
    public partial class InitalSetup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Asset",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    qty = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asset", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Asset");
        }
    }
}
