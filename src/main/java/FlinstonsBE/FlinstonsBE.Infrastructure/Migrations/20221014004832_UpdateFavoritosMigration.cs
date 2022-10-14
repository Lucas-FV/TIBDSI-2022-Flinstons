using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlinstonsBE.Infrastructure.Migrations
{
    public partial class UpdateFavoritosMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FAV_ITEMID",
                table: "TBL_FAVORITOS",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FAV_ITEMID",
                table: "TBL_FAVORITOS");
        }
    }
}
