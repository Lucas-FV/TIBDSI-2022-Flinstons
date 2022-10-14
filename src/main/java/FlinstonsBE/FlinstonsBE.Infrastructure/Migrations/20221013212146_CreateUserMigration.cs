using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlinstonsBE.Infrastructure.Migrations
{
    public partial class CreateUserMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TBL_USERS",
                columns: table => new
                {
                    ENT_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ENT_NAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ENT_EMAIL = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_USERS", x => x.ENT_ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TBL_USERS");
        }
    }
}
