using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlinstonsBE.Infrastructure.Migrations
{
    public partial class CreateFavoritosMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TBL_FAVORITOS",
                columns: table => new
                {
                    FAV_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FAV_MODELO = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false),
                    FAV_PRECO = table.Column<int>(type: "int", nullable: false),
                    FAV_IMG = table.Column<string>(type: "nvarchar(max)", maxLength: 10000, nullable: false),
                    FAV_LINK = table.Column<string>(type: "nvarchar(max)", maxLength: 10000, nullable: false),
                    FAV_DESC = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_FAVORITOS", x => x.FAV_ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TBL_FAVORITOS");
        }
    }
}
