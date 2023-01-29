using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoFilmes.API.Migrations
{
    public partial class Seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Atores_Filmes_FilmeId",
                table: "Atores");

            migrationBuilder.DropForeignKey(
                name: "FK_Avaliacoes_Filmes_FilmeId",
                table: "Avaliacoes");

            migrationBuilder.DropForeignKey(
                name: "FK_Avaliacoes_Utilizadores_UtilizadorIdUtilizador",
                table: "Avaliacoes");

            migrationBuilder.DropForeignKey(
                name: "FK_Diretores_Filmes_FilmeId",
                table: "Diretores");

            migrationBuilder.RenameColumn(
                name: "IdUtilizador",
                table: "Utilizadores",
                newName: "UtilizadorID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Filmes",
                newName: "FilmeID");

            migrationBuilder.RenameColumn(
                name: "FilmeId",
                table: "Diretores",
                newName: "FilmeID");

            migrationBuilder.RenameColumn(
                name: "IdDiretor",
                table: "Diretores",
                newName: "DiretorID");

            migrationBuilder.RenameIndex(
                name: "IX_Diretores_FilmeId",
                table: "Diretores",
                newName: "IX_Diretores_FilmeID");

            migrationBuilder.RenameColumn(
                name: "FilmeId",
                table: "Avaliacoes",
                newName: "FilmeID");

            migrationBuilder.RenameColumn(
                name: "UtilizadorIdUtilizador",
                table: "Avaliacoes",
                newName: "UtilizadorID");

            migrationBuilder.RenameColumn(
                name: "IdAvaliacao",
                table: "Avaliacoes",
                newName: "AvaliacaoID");

            migrationBuilder.RenameIndex(
                name: "IX_Avaliacoes_FilmeId",
                table: "Avaliacoes",
                newName: "IX_Avaliacoes_FilmeID");

            migrationBuilder.RenameIndex(
                name: "IX_Avaliacoes_UtilizadorIdUtilizador",
                table: "Avaliacoes",
                newName: "IX_Avaliacoes_UtilizadorID");

            migrationBuilder.RenameColumn(
                name: "FilmeId",
                table: "Atores",
                newName: "FilmeID");

            migrationBuilder.RenameColumn(
                name: "IdAtor",
                table: "Atores",
                newName: "AtorID");

            migrationBuilder.RenameIndex(
                name: "IX_Atores_FilmeId",
                table: "Atores",
                newName: "IX_Atores_FilmeID");

            migrationBuilder.InsertData(
                table: "Filmes",
                columns: new[] { "FilmeID", "AvaliacaoAvg", "DataLancamento", "Genero", "Titulo" },
                values: new object[,]
                {
                    { 1, (short)0, new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "The Last of Us" },
                    { 2, (short)0, new DateTime(2011, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Game of Thrones" },
                    { 3, (short)0, new DateTime(2022, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Avatar: The Way of Water" }
                });

            migrationBuilder.InsertData(
                table: "Utilizadores",
                columns: new[] { "UtilizadorID", "DataNascimento", "Genero", "Nome", "UserName" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Joao", "UtilizadorTeste" },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Semedo", "UtilizadorTeste2" }
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

            migrationBuilder.AddForeignKey(
                name: "FK_Atores_Filmes_FilmeID",
                table: "Atores",
                column: "FilmeID",
                principalTable: "Filmes",
                principalColumn: "FilmeID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Avaliacoes_Filmes_FilmeID",
                table: "Avaliacoes",
                column: "FilmeID",
                principalTable: "Filmes",
                principalColumn: "FilmeID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Avaliacoes_Utilizadores_UtilizadorID",
                table: "Avaliacoes",
                column: "UtilizadorID",
                principalTable: "Utilizadores",
                principalColumn: "UtilizadorID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Diretores_Filmes_FilmeID",
                table: "Diretores",
                column: "FilmeID",
                principalTable: "Filmes",
                principalColumn: "FilmeID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Atores_Filmes_FilmeID",
                table: "Atores");

            migrationBuilder.DropForeignKey(
                name: "FK_Avaliacoes_Filmes_FilmeID",
                table: "Avaliacoes");

            migrationBuilder.DropForeignKey(
                name: "FK_Avaliacoes_Utilizadores_UtilizadorID",
                table: "Avaliacoes");

            migrationBuilder.DropForeignKey(
                name: "FK_Diretores_Filmes_FilmeID",
                table: "Diretores");

            migrationBuilder.DeleteData(
                table: "Atores",
                keyColumn: "AtorID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Atores",
                keyColumn: "AtorID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Atores",
                keyColumn: "AtorID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Avaliacoes",
                keyColumn: "AvaliacaoID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Avaliacoes",
                keyColumn: "AvaliacaoID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Utilizadores",
                keyColumn: "UtilizadorID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Filmes",
                keyColumn: "FilmeID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Filmes",
                keyColumn: "FilmeID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Filmes",
                keyColumn: "FilmeID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Utilizadores",
                keyColumn: "UtilizadorID",
                keyValue: 1);

            migrationBuilder.RenameColumn(
                name: "UtilizadorID",
                table: "Utilizadores",
                newName: "IdUtilizador");

            migrationBuilder.RenameColumn(
                name: "FilmeID",
                table: "Filmes",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "FilmeID",
                table: "Diretores",
                newName: "FilmeId");

            migrationBuilder.RenameColumn(
                name: "DiretorID",
                table: "Diretores",
                newName: "IdDiretor");

            migrationBuilder.RenameIndex(
                name: "IX_Diretores_FilmeID",
                table: "Diretores",
                newName: "IX_Diretores_FilmeId");

            migrationBuilder.RenameColumn(
                name: "FilmeID",
                table: "Avaliacoes",
                newName: "FilmeId");

            migrationBuilder.RenameColumn(
                name: "UtilizadorID",
                table: "Avaliacoes",
                newName: "UtilizadorIdUtilizador");

            migrationBuilder.RenameColumn(
                name: "AvaliacaoID",
                table: "Avaliacoes",
                newName: "IdAvaliacao");

            migrationBuilder.RenameIndex(
                name: "IX_Avaliacoes_FilmeID",
                table: "Avaliacoes",
                newName: "IX_Avaliacoes_FilmeId");

            migrationBuilder.RenameIndex(
                name: "IX_Avaliacoes_UtilizadorID",
                table: "Avaliacoes",
                newName: "IX_Avaliacoes_UtilizadorIdUtilizador");

            migrationBuilder.RenameColumn(
                name: "FilmeID",
                table: "Atores",
                newName: "FilmeId");

            migrationBuilder.RenameColumn(
                name: "AtorID",
                table: "Atores",
                newName: "IdAtor");

            migrationBuilder.RenameIndex(
                name: "IX_Atores_FilmeID",
                table: "Atores",
                newName: "IX_Atores_FilmeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Atores_Filmes_FilmeId",
                table: "Atores",
                column: "FilmeId",
                principalTable: "Filmes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Avaliacoes_Filmes_FilmeId",
                table: "Avaliacoes",
                column: "FilmeId",
                principalTable: "Filmes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Avaliacoes_Utilizadores_UtilizadorIdUtilizador",
                table: "Avaliacoes",
                column: "UtilizadorIdUtilizador",
                principalTable: "Utilizadores",
                principalColumn: "IdUtilizador",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Diretores_Filmes_FilmeId",
                table: "Diretores",
                column: "FilmeId",
                principalTable: "Filmes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
