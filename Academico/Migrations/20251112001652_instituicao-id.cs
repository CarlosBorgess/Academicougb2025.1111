using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Academico.Migrations
{
    /// <inheritdoc />
    public partial class instituicaoid : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "InstituicaoID",
                table: "Departamentos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Instituicao",
                columns: table => new
                {
                    instituicaoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instituicao", x => x.instituicaoId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Departamentos_InstituicaoID",
                table: "Departamentos",
                column: "InstituicaoID");

            migrationBuilder.AddForeignKey(
                name: "FK_Departamentos_Instituicao_InstituicaoID",
                table: "Departamentos",
                column: "InstituicaoID",
                principalTable: "Instituicao",
                principalColumn: "instituicaoId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departamentos_Instituicao_InstituicaoID",
                table: "Departamentos");

            migrationBuilder.DropTable(
                name: "Instituicao");

            migrationBuilder.DropIndex(
                name: "IX_Departamentos_InstituicaoID",
                table: "Departamentos");

            migrationBuilder.DropColumn(
                name: "InstituicaoID",
                table: "Departamentos");
        }
    }
}
