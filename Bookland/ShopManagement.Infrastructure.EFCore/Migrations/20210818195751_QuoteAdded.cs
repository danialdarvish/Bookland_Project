using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ShopManagement.Infrastructure.EFCore.Migrations
{
    public partial class QuoteAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Quotes",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonName = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    PersonPost = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonPicture = table.Column<string>(type: "nvarchar(1000)", nullable: true),
                    PictureAlt = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    PictureTitle = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quotes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Quotes");
        }
    }
}
