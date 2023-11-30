using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class issoai : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cadastros_Farmacia",
                columns: table => new
                {
                    RG = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NomeCompleto = table.Column<string>(name: "Nome Completo", type: "text", nullable: false),
                    email = table.Column<string>(type: "text", nullable: false),
                    CPF = table.Column<string>(type: "text", nullable: false),
                    DatadoNascimento = table.Column<string>(name: "Data do Nascimento", type: "text", nullable: false),
                    NumerodeContato = table.Column<string>(name: "Numero de Contato", type: "text", nullable: false),
                    Endereco = table.Column<string>(type: "text", nullable: false),
                    Convenios = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cadastros_Farmacia", x => x.RG);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cadastros_Farmacia");
        }
    }
}
