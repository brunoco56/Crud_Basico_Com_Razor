using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ContSelf.Migrations
{
    public partial class Salao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Custo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    valor = table.Column<decimal>(type: "decimal (18,4)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Custo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pagamento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Valor = table.Column<decimal>(type: "decimal (18,4)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pagamento", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Agenda",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Agendamento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PagamentoId = table.Column<int>(type: "int", nullable: true),
                    Desconto = table.Column<decimal>(type: "decimal (18,4)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agenda", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Agenda_Pagamento_PagamentoId",
                        column: x => x.PagamentoId,
                        principalTable: "Pagamento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aniversario = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AgendaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cliente_Agenda_AgendaId",
                        column: x => x.AgendaId,
                        principalTable: "Agenda",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Funcionario",
                columns: table => new
                {
                    CodFuncionario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Salario = table.Column<decimal>(type: "decimal (18,4)", nullable: true),
                    Atividade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AgendaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionario", x => x.CodFuncionario);
                    table.ForeignKey(
                        name: "FK_Funcionario_Agenda_AgendaId",
                        column: x => x.AgendaId,
                        principalTable: "Agenda",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Servico",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Valor = table.Column<decimal>(type: "decimal (18,4)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgendaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servico", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Servico_Agenda_AgendaId",
                        column: x => x.AgendaId,
                        principalTable: "Agenda",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Agenda_PagamentoId",
                table: "Agenda",
                column: "PagamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_AgendaId",
                table: "Cliente",
                column: "AgendaId");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionario_AgendaId",
                table: "Funcionario",
                column: "AgendaId");

            migrationBuilder.CreateIndex(
                name: "IX_Servico_AgendaId",
                table: "Servico",
                column: "AgendaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Custo");

            migrationBuilder.DropTable(
                name: "Funcionario");

            migrationBuilder.DropTable(
                name: "Servico");

            migrationBuilder.DropTable(
                name: "Agenda");

            migrationBuilder.DropTable(
                name: "Pagamento");
        }
    }
}
