using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RpgApi.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoMuitosParaMuitos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Derrotas",
                table: "Personagens",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Disputas",
                table: "Personagens",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Vitorias",
                table: "Personagens",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Habilidades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dano = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Habilidades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersonagemHabilidades",
                columns: table => new
                {
                    PersonagemId = table.Column<int>(type: "int", nullable: false),
                    HabilidadeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonagemHabilidades", x => new { x.PersonagemId, x.HabilidadeId });
                    table.ForeignKey(
                        name: "FK_PersonagemHabilidades_Habilidades_HabilidadeId",
                        column: x => x.HabilidadeId,
                        principalTable: "Habilidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonagemHabilidades_Personagens_PersonagemId",
                        column: x => x.PersonagemId,
                        principalTable: "Personagens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Habilidades",
                columns: new[] { "Id", "Dano", "Nome" },
                values: new object[,]
                {
                    { 1, 39, "Adormecer" },
                    { 2, 41, "Congelar" },
                    { 3, 37, "Hipnotizar" }
                });

            migrationBuilder.UpdateData(
                table: "Personagens",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Personagens",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Personagens",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Personagens",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Personagens",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Personagens",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Personagens",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 55, 24, 29, 7, 80, 142, 137, 189, 186, 161, 225, 58, 31, 51, 225, 95, 210, 253, 204, 174, 92, 73, 173, 193, 238, 75, 30, 36, 41, 111, 108, 118, 131, 232, 218, 181, 8, 53, 0, 14, 47, 186, 180, 83, 157, 65, 221, 133, 150, 29, 222, 77, 150, 1, 145, 101, 129, 97, 138, 94, 13, 133, 40, 168 }, new byte[] { 95, 207, 93, 60, 242, 98, 75, 39, 250, 86, 123, 32, 183, 150, 118, 37, 195, 193, 113, 242, 219, 31, 232, 158, 8, 75, 23, 205, 252, 126, 165, 69, 208, 49, 168, 57, 133, 232, 101, 108, 202, 156, 141, 180, 237, 79, 238, 34, 111, 235, 231, 118, 26, 240, 53, 35, 215, 105, 126, 242, 151, 115, 242, 118, 227, 212, 138, 153, 6, 83, 47, 182, 99, 89, 151, 188, 139, 255, 220, 90, 17, 216, 15, 92, 108, 244, 104, 26, 225, 226, 225, 178, 59, 38, 203, 45, 20, 156, 195, 149, 39, 142, 218, 248, 113, 204, 30, 90, 100, 1, 227, 47, 0, 90, 95, 67, 80, 161, 131, 66, 228, 118, 243, 204, 70, 45, 162, 66 } });

            migrationBuilder.InsertData(
                table: "PersonagemHabilidades",
                columns: new[] { "HabilidadeId", "PersonagemId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 3, 3 },
                    { 3, 4 },
                    { 1, 5 },
                    { 2, 6 },
                    { 3, 7 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PersonagemHabilidades_HabilidadeId",
                table: "PersonagemHabilidades",
                column: "HabilidadeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonagemHabilidades");

            migrationBuilder.DropTable(
                name: "Habilidades");

            migrationBuilder.DropColumn(
                name: "Derrotas",
                table: "Personagens");

            migrationBuilder.DropColumn(
                name: "Disputas",
                table: "Personagens");

            migrationBuilder.DropColumn(
                name: "Vitorias",
                table: "Personagens");

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 77, 91, 143, 0, 80, 230, 144, 105, 52, 152, 112, 248, 189, 103, 204, 1, 119, 20, 184, 184, 159, 203, 48, 59, 193, 183, 190, 148, 212, 209, 11, 251, 33, 88, 132, 37, 74, 41, 98, 239, 115, 251, 148, 100, 121, 73, 54, 112, 106, 57, 245, 207, 139, 20, 63, 100, 70, 238, 220, 192, 19, 133, 191, 144 }, new byte[] { 97, 3, 35, 218, 77, 197, 107, 57, 154, 138, 232, 63, 127, 255, 75, 66, 229, 250, 113, 71, 240, 172, 147, 85, 199, 29, 92, 195, 61, 219, 102, 186, 97, 144, 100, 177, 223, 180, 248, 10, 64, 114, 230, 181, 84, 245, 252, 124, 166, 152, 10, 104, 17, 106, 163, 35, 240, 198, 78, 132, 107, 62, 134, 174, 156, 17, 82, 49, 138, 50, 208, 215, 5, 1, 137, 2, 41, 161, 214, 167, 37, 31, 45, 96, 191, 1, 238, 72, 18, 58, 101, 156, 153, 97, 45, 172, 189, 145, 133, 249, 37, 78, 100, 59, 103, 193, 170, 65, 170, 123, 204, 29, 93, 226, 254, 69, 140, 0, 150, 33, 151, 144, 34, 254, 11, 191, 172, 222 } });
        }
    }
}
