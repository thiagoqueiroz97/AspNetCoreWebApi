using Microsoft.EntityFrameworkCore;
using SmartSchool.API.Models;
using System.Collections.Generic;

namespace SmartSchool.API.Data
{
    public class SmartContext : DbContext
    {
        public SmartContext(DbContextOptions<SmartContext> options) : base(options) 
        {

        }
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Professor> Professors { get; set; }
        public DbSet<Discipline> Disciplines { get; set; }
        public DbSet<AlunoDiscipline> AlunosDisciplines { get; set; }

        protected override void OnModelCreating(ModelBuilder builder) 
        {
            builder.Entity<AlunoDiscipline>()
                .HasKey(AD => new { AD.AlunoId, AD.DisciplinaId });

            builder.Entity<Professor>()
                .HasData(new List<Professor>(){
                    new Professor(1, "Lauro"),
                    new Professor(2, "Roberto"),
                    new Professor(3, "Ronaldo"),
                    new Professor(4, "Rodrigo"),
                    new Professor(5, "Alexandre"),
                });

            builder.Entity<Discipline>()
                .HasData(new List<Discipline>{
                    new Discipline(1, "Matemática", 1),
                    new Discipline(2, "Física", 2),
                    new Discipline(3, "Português", 3),
                    new Discipline(4, "Inglês", 4),
                    new Discipline(5, "Programação", 5)
                });

            builder.Entity<Aluno>()
                .HasData(new List<Aluno>(){
                    new Aluno(1, "Marta", "Kent", "33225555"),
                    new Aluno(2, "Paula", "Isabela", "3354288"),
                    new Aluno(3, "Laura", "Antonia", "55668899"),
                    new Aluno(4, "Luiza", "Maria", "6565659"),
                    new Aluno(5, "Lucas", "Machado", "565685415"),
                    new Aluno(6, "Pedro", "Alvares", "456454545"),
                    new Aluno(7, "Paulo", "José", "9874512")
                });

            builder.Entity<AlunoDiscipline>()
                .HasData(new List<AlunoDiscipline>() {
                    new AlunoDiscipline() {AlunoId = 1, DisciplinaId = 2 },
                    new AlunoDiscipline() {AlunoId = 1, DisciplinaId = 4 },
                    new AlunoDiscipline() {AlunoId = 1, DisciplinaId = 5 },
                    new AlunoDiscipline() {AlunoId = 2, DisciplinaId = 1 },
                    new AlunoDiscipline() {AlunoId = 2, DisciplinaId = 2 },
                    new AlunoDiscipline() {AlunoId = 2, DisciplinaId = 5 },
                    new AlunoDiscipline() {AlunoId = 3, DisciplinaId = 1 },
                    new AlunoDiscipline() {AlunoId = 3, DisciplinaId = 2 },
                    new AlunoDiscipline() {AlunoId = 3, DisciplinaId = 3 },
                    new AlunoDiscipline() {AlunoId = 4, DisciplinaId = 1 },
                    new AlunoDiscipline() {AlunoId = 4, DisciplinaId = 4 },
                    new AlunoDiscipline() {AlunoId = 4, DisciplinaId = 5 },
                    new AlunoDiscipline() {AlunoId = 5, DisciplinaId = 4 },
                    new AlunoDiscipline() {AlunoId = 5, DisciplinaId = 5 },
                    new AlunoDiscipline() {AlunoId = 6, DisciplinaId = 1 },
                    new AlunoDiscipline() {AlunoId = 6, DisciplinaId = 2 },
                    new AlunoDiscipline() {AlunoId = 6, DisciplinaId = 3 },
                    new AlunoDiscipline() {AlunoId = 6, DisciplinaId = 4 },
                    new AlunoDiscipline() {AlunoId = 7, DisciplinaId = 1 },
                    new AlunoDiscipline() {AlunoId = 7, DisciplinaId = 2 },
                    new AlunoDiscipline() {AlunoId = 7, DisciplinaId = 3 },
                    new AlunoDiscipline() {AlunoId = 7, DisciplinaId = 4 },
                    new AlunoDiscipline() {AlunoId = 7, DisciplinaId = 5 }
                });
        }


    }
}
