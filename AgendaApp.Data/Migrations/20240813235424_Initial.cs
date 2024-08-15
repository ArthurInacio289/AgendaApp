using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgendaApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DESCRICAO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TAREFA",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NOME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DATA = table.Column<DateTime>(type: "date", nullable: false),
                    HORA = table.Column<TimeSpan>(type: "time", nullable: false),
                    PRIORIDADE = table.Column<int>(type: "int", nullable: false),
                    CATEGORIAID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TAREFA", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TAREFA_Categoria_CATEGORIAID",
                        column: x => x.CATEGORIAID,
                        principalTable: "Categoria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TAREFA_CATEGORIAID",
                table: "TAREFA",
                column: "CATEGORIAID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TAREFA");

            migrationBuilder.DropTable(
                name: "Categoria");
        }
    }
}
