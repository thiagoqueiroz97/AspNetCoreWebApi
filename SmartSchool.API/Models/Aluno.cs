using System.Collections.Generic;

namespace SmartSchool.API.Models
{
    public class Aluno
    {
        public Aluno() { }

        public Aluno(int id, string nome, string sobrenome, string telefone)
        {
            this.Telefone = telefone;
            this.Nome = nome;
            this.Sobrenome = sobrenome;
            this.Id = id;
        }

        public string Telefone { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public int Id { get; set; }

        public IEnumerable<AlunoDiscipline> AlunosDisciplinas { get; set; }

    }
}
