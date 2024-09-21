using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gerenciamento_Financeiro.Migrations
{
    /// <inheritdoc />
    public partial class CorrecaoTipoOperacao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "tipoOperacao",
                table: "transacao",
                type: "int",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "tipoOperacao",
                table: "transacao",
                type: "bit",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
