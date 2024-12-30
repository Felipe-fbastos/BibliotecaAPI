using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BibliotecaAPi.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_AUTOR",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_AUTOR", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TB_LIVRO",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuantidadePaginas = table.Column<int>(type: "int", nullable: false),
                    Valor = table.Column<double>(type: "float", nullable: false),
                    idAutor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_LIVRO", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TB_LIVRO_TB_AUTOR_idAutor",
                        column: x => x.idAutor,
                        principalTable: "TB_AUTOR",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "TB_AUTOR",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { 1, "J.K. Rowling" },
                    { 2, "George Orwell" },
                    { 3, "Jane Austen" },
                    { 4, "Mark Twain" },
                    { 5, "F. Scott Fitzgerald" },
                    { 6, "Harper Lee" },
                    { 7, "Hemingway" },
                    { 8, "J.R.R. Tolkien" },
                    { 9, "Gabriel García Márquez" },
                    { 10, "Oscar Wilde" }
                });

            migrationBuilder.InsertData(
                table: "TB_LIVRO",
                columns: new[] { "Id", "QuantidadePaginas", "Titulo", "Valor", "idAutor" },
                values: new object[,]
                {
                    { 1, 223, "Harry Potter e a Pedra Filosofal", 49.899999999999999, 1 },
                    { 2, 328, "1984", 39.899999999999999, 2 },
                    { 3, 368, "Orgulho e Preconceito", 29.899999999999999, 3 },
                    { 4, 366, "As Aventuras de Huckleberry Finn", 32.899999999999999, 4 },
                    { 5, 180, "O Grande Gatsby", 25.899999999999999, 5 },
                    { 6, 320, "O Sol é Para Todos", 36.899999999999999, 6 },
                    { 7, 128, "O Velho e o Mar", 19.899999999999999, 7 },
                    { 8, 310, "O Hobbit", 44.899999999999999, 8 },
                    { 9, 448, "Cem Anos de Solidão", 59.899999999999999, 9 },
                    { 10, 224, "O Retrato de Dorian Gray", 39.899999999999999, 10 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TB_LIVRO_idAutor",
                table: "TB_LIVRO",
                column: "idAutor");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_LIVRO");

            migrationBuilder.DropTable(
                name: "TB_AUTOR");
        }
    }
}
