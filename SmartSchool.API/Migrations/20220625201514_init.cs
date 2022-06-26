using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartSchool.API.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Alunos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Telefone = table.Column<string>(nullable: true),
                    Nome = table.Column<string>(nullable: true),
                    Sobrenome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alunos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Professors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(nullable: true),
                    MyProperty = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Disciplines",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(nullable: true),
                    ProfessorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Disciplines", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Disciplines_Professors_ProfessorId",
                        column: x => x.ProfessorId,
                        principalTable: "Professors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AlunosDisciplines",
                columns: table => new
                {
                    AlunoId = table.Column<int>(nullable: false),
                    DisciplinaId = table.Column<int>(nullable: false),
                    DisciplineId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlunosDisciplines", x => new { x.AlunoId, x.DisciplinaId });
                    table.ForeignKey(
                        name: "FK_AlunosDisciplines_Alunos_AlunoId",
                        column: x => x.AlunoId,
                        principalTable: "Alunos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AlunosDisciplines_Disciplines_DisciplineId",
                        column: x => x.DisciplineId,
                        principalTable: "Disciplines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Alunos",
                columns: new[] { "Id", "Nome", "Sobrenome", "Telefone" },
                values: new object[] { 1, "Marta", "Kent", "33225555" });

            migrationBuilder.InsertData(
                table: "Alunos",
                columns: new[] { "Id", "Nome", "Sobrenome", "Telefone" },
                values: new object[] { 2, "Paula", "Isabela", "3354288" });

            migrationBuilder.InsertData(
                table: "Alunos",
                columns: new[] { "Id", "Nome", "Sobrenome", "Telefone" },
                values: new object[] { 3, "Laura", "Antonia", "55668899" });

            migrationBuilder.InsertData(
                table: "Alunos",
                columns: new[] { "Id", "Nome", "Sobrenome", "Telefone" },
                values: new object[] { 4, "Luiza", "Maria", "6565659" });

            migrationBuilder.InsertData(
                table: "Alunos",
                columns: new[] { "Id", "Nome", "Sobrenome", "Telefone" },
                values: new object[] { 5, "Lucas", "Machado", "565685415" });

            migrationBuilder.InsertData(
                table: "Alunos",
                columns: new[] { "Id", "Nome", "Sobrenome", "Telefone" },
                values: new object[] { 6, "Pedro", "Alvares", "456454545" });

            migrationBuilder.InsertData(
                table: "Alunos",
                columns: new[] { "Id", "Nome", "Sobrenome", "Telefone" },
                values: new object[] { 7, "Paulo", "José", "9874512" });

            migrationBuilder.InsertData(
                table: "Professors",
                columns: new[] { "Id", "MyProperty", "Nome" },
                values: new object[] { 1, 0, "Lauro" });

            migrationBuilder.InsertData(
                table: "Professors",
                columns: new[] { "Id", "MyProperty", "Nome" },
                values: new object[] { 2, 0, "Roberto" });

            migrationBuilder.InsertData(
                table: "Professors",
                columns: new[] { "Id", "MyProperty", "Nome" },
                values: new object[] { 3, 0, "Ronaldo" });

            migrationBuilder.InsertData(
                table: "Professors",
                columns: new[] { "Id", "MyProperty", "Nome" },
                values: new object[] { 4, 0, "Rodrigo" });

            migrationBuilder.InsertData(
                table: "Professors",
                columns: new[] { "Id", "MyProperty", "Nome" },
                values: new object[] { 5, 0, "Alexandre" });

            migrationBuilder.InsertData(
                table: "AlunosDisciplines",
                columns: new[] { "AlunoId", "DisciplinaId", "DisciplineId" },
                values: new object[] { 1, 2, null });

            migrationBuilder.InsertData(
                table: "AlunosDisciplines",
                columns: new[] { "AlunoId", "DisciplinaId", "DisciplineId" },
                values: new object[] { 7, 5, null });

            migrationBuilder.InsertData(
                table: "AlunosDisciplines",
                columns: new[] { "AlunoId", "DisciplinaId", "DisciplineId" },
                values: new object[] { 7, 4, null });

            migrationBuilder.InsertData(
                table: "AlunosDisciplines",
                columns: new[] { "AlunoId", "DisciplinaId", "DisciplineId" },
                values: new object[] { 7, 3, null });

            migrationBuilder.InsertData(
                table: "AlunosDisciplines",
                columns: new[] { "AlunoId", "DisciplinaId", "DisciplineId" },
                values: new object[] { 7, 2, null });

            migrationBuilder.InsertData(
                table: "AlunosDisciplines",
                columns: new[] { "AlunoId", "DisciplinaId", "DisciplineId" },
                values: new object[] { 7, 1, null });

            migrationBuilder.InsertData(
                table: "AlunosDisciplines",
                columns: new[] { "AlunoId", "DisciplinaId", "DisciplineId" },
                values: new object[] { 6, 4, null });

            migrationBuilder.InsertData(
                table: "AlunosDisciplines",
                columns: new[] { "AlunoId", "DisciplinaId", "DisciplineId" },
                values: new object[] { 6, 3, null });

            migrationBuilder.InsertData(
                table: "AlunosDisciplines",
                columns: new[] { "AlunoId", "DisciplinaId", "DisciplineId" },
                values: new object[] { 6, 2, null });

            migrationBuilder.InsertData(
                table: "AlunosDisciplines",
                columns: new[] { "AlunoId", "DisciplinaId", "DisciplineId" },
                values: new object[] { 6, 1, null });

            migrationBuilder.InsertData(
                table: "AlunosDisciplines",
                columns: new[] { "AlunoId", "DisciplinaId", "DisciplineId" },
                values: new object[] { 5, 4, null });

            migrationBuilder.InsertData(
                table: "AlunosDisciplines",
                columns: new[] { "AlunoId", "DisciplinaId", "DisciplineId" },
                values: new object[] { 5, 5, null });

            migrationBuilder.InsertData(
                table: "AlunosDisciplines",
                columns: new[] { "AlunoId", "DisciplinaId", "DisciplineId" },
                values: new object[] { 4, 4, null });

            migrationBuilder.InsertData(
                table: "AlunosDisciplines",
                columns: new[] { "AlunoId", "DisciplinaId", "DisciplineId" },
                values: new object[] { 4, 1, null });

            migrationBuilder.InsertData(
                table: "AlunosDisciplines",
                columns: new[] { "AlunoId", "DisciplinaId", "DisciplineId" },
                values: new object[] { 3, 3, null });

            migrationBuilder.InsertData(
                table: "AlunosDisciplines",
                columns: new[] { "AlunoId", "DisciplinaId", "DisciplineId" },
                values: new object[] { 3, 2, null });

            migrationBuilder.InsertData(
                table: "AlunosDisciplines",
                columns: new[] { "AlunoId", "DisciplinaId", "DisciplineId" },
                values: new object[] { 3, 1, null });

            migrationBuilder.InsertData(
                table: "AlunosDisciplines",
                columns: new[] { "AlunoId", "DisciplinaId", "DisciplineId" },
                values: new object[] { 2, 5, null });

            migrationBuilder.InsertData(
                table: "AlunosDisciplines",
                columns: new[] { "AlunoId", "DisciplinaId", "DisciplineId" },
                values: new object[] { 2, 2, null });

            migrationBuilder.InsertData(
                table: "AlunosDisciplines",
                columns: new[] { "AlunoId", "DisciplinaId", "DisciplineId" },
                values: new object[] { 2, 1, null });

            migrationBuilder.InsertData(
                table: "AlunosDisciplines",
                columns: new[] { "AlunoId", "DisciplinaId", "DisciplineId" },
                values: new object[] { 1, 5, null });

            migrationBuilder.InsertData(
                table: "AlunosDisciplines",
                columns: new[] { "AlunoId", "DisciplinaId", "DisciplineId" },
                values: new object[] { 1, 4, null });

            migrationBuilder.InsertData(
                table: "AlunosDisciplines",
                columns: new[] { "AlunoId", "DisciplinaId", "DisciplineId" },
                values: new object[] { 4, 5, null });

            migrationBuilder.InsertData(
                table: "Disciplines",
                columns: new[] { "Id", "Nome", "ProfessorId" },
                values: new object[] { 4, "Inglês", 4 });

            migrationBuilder.InsertData(
                table: "Disciplines",
                columns: new[] { "Id", "Nome", "ProfessorId" },
                values: new object[] { 1, "Matemática", 1 });

            migrationBuilder.InsertData(
                table: "Disciplines",
                columns: new[] { "Id", "Nome", "ProfessorId" },
                values: new object[] { 2, "Física", 2 });

            migrationBuilder.InsertData(
                table: "Disciplines",
                columns: new[] { "Id", "Nome", "ProfessorId" },
                values: new object[] { 3, "Português", 3 });

            migrationBuilder.InsertData(
                table: "Disciplines",
                columns: new[] { "Id", "Nome", "ProfessorId" },
                values: new object[] { 5, "Programação", 5 });

            migrationBuilder.CreateIndex(
                name: "IX_AlunosDisciplines_DisciplineId",
                table: "AlunosDisciplines",
                column: "DisciplineId");

            migrationBuilder.CreateIndex(
                name: "IX_Disciplines_ProfessorId",
                table: "Disciplines",
                column: "ProfessorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AlunosDisciplines");

            migrationBuilder.DropTable(
                name: "Alunos");

            migrationBuilder.DropTable(
                name: "Disciplines");

            migrationBuilder.DropTable(
                name: "Professors");
        }
    }
}
