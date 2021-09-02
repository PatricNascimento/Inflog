using Microsoft.EntityFrameworkCore.Migrations;

namespace Infolog.DataAccess.Migrations
{
    public partial class atualizacaoEntregador : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Moto",
                table: "Entregadores",
                newName: "Veiculo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Veiculo",
                table: "Entregadores",
                newName: "Moto");
        }
    }
}
