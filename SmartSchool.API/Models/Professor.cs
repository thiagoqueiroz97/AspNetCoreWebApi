using System.Collections.Generic;

namespace SmartSchool.API.Models
{
    public class Professor
    {
        public Professor() { }
        public Professor(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public int MyProperty { get; set; }

        public IEnumerable<Discipline> Disciplinas { get; set; }

    }
}
