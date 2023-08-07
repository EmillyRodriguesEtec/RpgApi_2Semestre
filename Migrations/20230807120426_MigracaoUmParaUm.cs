using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RpgApi.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoUmParaUm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PersonagemId",
                table: "Armas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Armas",
                keyColumn: "Id",
                keyValue: 1,
                column: "PersonagemId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Armas",
                keyColumn: "Id",
                keyValue: 2,
                column: "PersonagemId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Armas",
                keyColumn: "Id",
                keyValue: 3,
                column: "PersonagemId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Armas",
                keyColumn: "Id",
                keyValue: 4,
                column: "PersonagemId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Armas",
                keyColumn: "Id",
                keyValue: 5,
                column: "PersonagemId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Armas",
                keyColumn: "Id",
                keyValue: 6,
                column: "PersonagemId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Armas",
                keyColumn: "Id",
                keyValue: 7,
                column: "PersonagemId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 77, 91, 143, 0, 80, 230, 144, 105, 52, 152, 112, 248, 189, 103, 204, 1, 119, 20, 184, 184, 159, 203, 48, 59, 193, 183, 190, 148, 212, 209, 11, 251, 33, 88, 132, 37, 74, 41, 98, 239, 115, 251, 148, 100, 121, 73, 54, 112, 106, 57, 245, 207, 139, 20, 63, 100, 70, 238, 220, 192, 19, 133, 191, 144 }, new byte[] { 97, 3, 35, 218, 77, 197, 107, 57, 154, 138, 232, 63, 127, 255, 75, 66, 229, 250, 113, 71, 240, 172, 147, 85, 199, 29, 92, 195, 61, 219, 102, 186, 97, 144, 100, 177, 223, 180, 248, 10, 64, 114, 230, 181, 84, 245, 252, 124, 166, 152, 10, 104, 17, 106, 163, 35, 240, 198, 78, 132, 107, 62, 134, 174, 156, 17, 82, 49, 138, 50, 208, 215, 5, 1, 137, 2, 41, 161, 214, 167, 37, 31, 45, 96, 191, 1, 238, 72, 18, 58, 101, 156, 153, 97, 45, 172, 189, 145, 133, 249, 37, 78, 100, 59, 103, 193, 170, 65, 170, 123, 204, 29, 93, 226, 254, 69, 140, 0, 150, 33, 151, 144, 34, 254, 11, 191, 172, 222 } });

            migrationBuilder.CreateIndex(
                name: "IX_Armas_PersonagemId",
                table: "Armas",
                column: "PersonagemId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Armas_Personagens_PersonagemId",
                table: "Armas",
                column: "PersonagemId",
                principalTable: "Personagens",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Armas_Personagens_PersonagemId",
                table: "Armas");

            migrationBuilder.DropIndex(
                name: "IX_Armas_PersonagemId",
                table: "Armas");

            migrationBuilder.DropColumn(
                name: "PersonagemId",
                table: "Armas");

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 181, 204, 2, 37, 133, 194, 33, 41, 198, 242, 152, 88, 70, 17, 49, 195, 211, 212, 13, 33, 57, 53, 0, 222, 245, 172, 154, 224, 201, 189, 121, 109, 184, 92, 16, 19, 42, 35, 58, 139, 151, 94, 19, 177, 81, 97, 71, 53, 149, 141, 16, 94, 56, 159, 218, 67, 70, 250, 10, 118, 177, 79, 86, 51 }, new byte[] { 50, 234, 39, 132, 194, 122, 96, 184, 130, 204, 216, 249, 191, 226, 187, 24, 58, 235, 151, 218, 223, 153, 120, 200, 165, 63, 74, 189, 109, 253, 3, 143, 45, 19, 101, 168, 156, 164, 23, 67, 232, 60, 159, 42, 208, 195, 164, 132, 251, 155, 251, 4, 72, 189, 190, 95, 163, 255, 202, 118, 117, 149, 117, 145, 178, 234, 37, 13, 229, 204, 142, 219, 89, 25, 168, 225, 171, 164, 45, 136, 247, 147, 205, 210, 251, 232, 249, 175, 141, 84, 222, 232, 96, 245, 132, 60, 62, 35, 212, 239, 239, 225, 221, 232, 126, 253, 142, 63, 71, 234, 107, 178, 15, 130, 110, 171, 148, 101, 152, 181, 67, 6, 13, 33, 105, 58, 22, 213 } });
        }
    }
}
