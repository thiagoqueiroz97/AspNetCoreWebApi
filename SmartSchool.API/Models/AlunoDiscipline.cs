namespace SmartSchool.API.Models
{
    public class AlunoDiscipline
    {
        public AlunoDiscipline() { }
        public AlunoDiscipline(int alunoId, int disciplinaId)
        {
            this.AlunoId = alunoId;
            this.DisciplinaId = disciplinaId;
        }

        public int AlunoId { get; set; }
        public Aluno Aluno { get; set; }
        public int DisciplinaId { get; set; }
        public Discipline Discipline { get; set; }
    }
}
