using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AulasAspNet.Migrations
{
    public partial class criarbasededados : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(maxLength: 30, nullable: false),
                    Senha = table.Column<string>(nullable: true),
                    CPF = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: false),
                    Nascimento = table.Column<string>(nullable: false),
                    Cep = table.Column<string>(nullable: true),
                    Logradouro = table.Column<string>(nullable: true),
                    Localidade = table.Column<string>(nullable: true),
                    uf = table.Column<string>(nullable: true),
                    bairro = table.Column<string>(nullable: true),
                    numero = table.Column<string>(nullable: true),
                    complemento = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.UsuarioId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
