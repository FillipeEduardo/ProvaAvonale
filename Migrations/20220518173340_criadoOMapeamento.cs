using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProvaAvonale.Migrations
{
    /// <inheritdoc />
    public partial class criadoOMapeamento : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Estoques");

            migrationBuilder.CreateTable(
                name: "Produto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "NVARCHAR", maxLength: 80, nullable: false),
                    ValorUnitario = table.Column<double>(type: "DOUBLE", nullable: false),
                    Quantidade = table.Column<int>(type: "INTEGER", nullable: false),
                    DataUltimaVenda = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    ValorUltimaVenda = table.Column<double>(type: "DOUBLE", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produto");

            migrationBuilder.CreateTable(
                name: "Estoques",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DataUltimaVenda = table.Column<DateTime>(type: "TEXT", nullable: false),
                    NomeProduto = table.Column<string>(type: "TEXT", nullable: false),
                    QuantidadeEstoque = table.Column<int>(type: "INTEGER", nullable: false),
                    ValorUltimaVenda = table.Column<double>(type: "REAL", nullable: false),
                    ValorUnitario = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estoques", x => x.Id);
                });
        }
    }
}
