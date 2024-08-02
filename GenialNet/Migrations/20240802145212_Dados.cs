using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GenialNet.Migrations
{
    /// <inheritdoc />
    public partial class Dados : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Fornecedores",
                columns: new[] { "Id", "CNPJ", "DataCriacao", "Nome", "Telefone" },
                values: new object[,]
                {
                    { 1L, "12345678000195", new DateTime(2024, 8, 2, 14, 52, 11, 714, DateTimeKind.Utc).AddTicks(5442), "Fornecedor A", "(11) 1234-5678" },
                    { 2L, "23456789000196", new DateTime(2024, 8, 2, 14, 52, 11, 714, DateTimeKind.Utc).AddTicks(5444), "Fornecedor B", "(21) 2345-6789" },
                    { 3L, "34567890000197", new DateTime(2024, 8, 2, 14, 52, 11, 714, DateTimeKind.Utc).AddTicks(5446), "Fornecedor C", "(31) 3456-7890" },
                    { 4L, "45678901000198", new DateTime(2024, 8, 2, 14, 52, 11, 714, DateTimeKind.Utc).AddTicks(5447), "Fornecedor D", "(41) 4567-8901" },
                    { 5L, "56789012000199", new DateTime(2024, 8, 2, 14, 52, 11, 714, DateTimeKind.Utc).AddTicks(5449), "Fornecedor E", "(51) 5678-9012" }
                });

            migrationBuilder.InsertData(
                table: "Enderecos",
                columns: new[] { "Id", "Bairro", "Cep", "Complemento", "Ddd", "FornecedorId", "Gia", "Ibge", "Localidade", "Logradouro", "Siafi", "Uf", "Unidade" },
                values: new object[,]
                {
                    { 1L, "Centro", "01001000", "Apto 101", "11", 1L, "0001", "3550308", "São Paulo", "Rua A", "1234", "SP", "1" },
                    { 2L, "Jardim", "02002000", "Apto 202", "11", 2L, "0002", "3550308", "São Paulo", "Rua B", "2345", "SP", "2" },
                    { 3L, "Vila", "03003000", "Apto 303", "11", 3L, "0003", "3550308", "São Paulo", "Rua C", "3456", "SP", "3" },
                    { 4L, "Bela Vista", "04004000", "Apto 404", "11", 4L, "0004", "3550308", "São Paulo", "Rua D", "4567", "SP", "4" },
                    { 5L, "Perdizes", "05005000", "Apto 505", "11", 5L, "0005", "3550308", "São Paulo", "Rua E", "5678", "SP", "5" }
                });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "Descricao", "FornecedorId", "Marca", "UnidadeMedida", "Valor" },
                values: new object[,]
                {
                    { 1L, "Produto X", 1L, "Marca X", 1, 10.00m },
                    { 2L, "Produto Y", 2L, "Marca Y", 1, 20.00m },
                    { 3L, "Produto Z", 3L, "Marca Z", 1, 30.00m },
                    { 4L, "Produto W", 4L, "Marca W", 1, 40.00m },
                    { 5L, "Produto V", 5L, "Marca V", 1, 50.00m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Enderecos",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Enderecos",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Enderecos",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Enderecos",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Enderecos",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Fornecedores",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Fornecedores",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Fornecedores",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Fornecedores",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Fornecedores",
                keyColumn: "Id",
                keyValue: 5L);
        }
    }
}
