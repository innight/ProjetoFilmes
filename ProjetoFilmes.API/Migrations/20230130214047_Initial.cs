using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoFilmes.API.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Filmes",
                columns: table => new
                {
                    FilmeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    DataLancamento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    AvaliacaoAvg = table.Column<short>(type: "smallint", nullable: false),
                    Genero = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filmes", x => x.FilmeID);
                });

            migrationBuilder.CreateTable(
                name: "Utilizadores",
                columns: table => new
                {
                    UtilizadorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Genero = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utilizadores", x => x.UtilizadorID);
                });

            migrationBuilder.CreateTable(
                name: "Atores",
                columns: table => new
                {
                    AtorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FilmeID = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Genero = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Atores", x => x.AtorID);
                    table.ForeignKey(
                        name: "FK_Atores_Filmes_FilmeID",
                        column: x => x.FilmeID,
                        principalTable: "Filmes",
                        principalColumn: "FilmeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Diretores",
                columns: table => new
                {
                    DiretorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FilmeID = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Genero = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diretores", x => x.DiretorID);
                    table.ForeignKey(
                        name: "FK_Diretores_Filmes_FilmeID",
                        column: x => x.FilmeID,
                        principalTable: "Filmes",
                        principalColumn: "FilmeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Avaliacoes",
                columns: table => new
                {
                    AvaliacaoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Opiniao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<byte>(type: "tinyint", nullable: false),
                    FilmeID = table.Column<int>(type: "int", nullable: false),
                    UtilizadorID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Avaliacoes", x => x.AvaliacaoID);
                    table.ForeignKey(
                        name: "FK_Avaliacoes_Filmes_FilmeID",
                        column: x => x.FilmeID,
                        principalTable: "Filmes",
                        principalColumn: "FilmeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Avaliacoes_Utilizadores_UtilizadorID",
                        column: x => x.UtilizadorID,
                        principalTable: "Utilizadores",
                        principalColumn: "UtilizadorID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Filmes",
                columns: new[] { "FilmeID", "AvaliacaoAvg", "DataLancamento", "Descricao", "Genero", "Titulo" },
                values: new object[,]
                {
                    { 1, (short)0, new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "After a global pandemic destroys civilization, a hardened survivor takes charge of a 14-year-old girl who may be humanity's last hope.", 2, "The Last of Us" },
                    { 2, (short)0, new DateTime(2011, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nine noble families fight for control over the lands of Westeros, while an ancient enemy returns after being dormant for millennia.", 2, "Game of Thrones" },
                    { 3, (short)0, new DateTime(2022, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jake Sully lives with his newfound family formed on the extrasolar moon Pandora.", 7, "Avatar: The Way of Water" }
                });

            migrationBuilder.InsertData(
                table: "Utilizadores",
                columns: new[] { "UtilizadorID", "DataNascimento", "Genero", "Nome", "UserName" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Joao", "UserOne" },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Semedo", "UserTwo" }
                });

            migrationBuilder.InsertData(
                table: "Atores",
                columns: new[] { "AtorID", "DataNascimento", "FilmeID", "Genero", "Nome" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, "Pedro Pascal" },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, false, "Emilia Clarke" },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, false, "Matt Smith" }
                });

            migrationBuilder.InsertData(
                table: "Avaliacoes",
                columns: new[] { "AvaliacaoID", "FilmeID", "Opiniao", "Rating", "UtilizadorID" },
                values: new object[,]
                {
                    { 1, 1, "interessante", (byte)4, 1 },
                    { 2, 2, "bom", (byte)4, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Atores_FilmeID",
                table: "Atores",
                column: "FilmeID");

            migrationBuilder.CreateIndex(
                name: "IX_Avaliacoes_FilmeID",
                table: "Avaliacoes",
                column: "FilmeID");

            migrationBuilder.CreateIndex(
                name: "IX_Avaliacoes_UtilizadorID",
                table: "Avaliacoes",
                column: "UtilizadorID");

            migrationBuilder.CreateIndex(
                name: "IX_Diretores_FilmeID",
                table: "Diretores",
                column: "FilmeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Atores");

            migrationBuilder.DropTable(
                name: "Avaliacoes");

            migrationBuilder.DropTable(
                name: "Diretores");

            migrationBuilder.DropTable(
                name: "Utilizadores");

            migrationBuilder.DropTable(
                name: "Filmes");
        }
    }
}
