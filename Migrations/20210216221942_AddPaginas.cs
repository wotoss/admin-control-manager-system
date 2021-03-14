using Microsoft.EntityFrameworkCore.Migrations;

namespace admin_cms.Migrations
{
    public partial class AddPaginas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Paginas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(maxLength: 100, nullable: false),
                    Conteudo = table.Column<string>(type: "text", nullable: false),
                    Login = table.Column<bool>(nullable: false),
                    AreaRestrita = table.Column<bool>(nullable: false),
                    Home = table.Column<bool>(nullable: false),
                    Ordem = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paginas", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Paginas");
        }
    }
}
