namespace CSharp.Models
{
    public class Curso
    {
        private string _nome;
        public string Nome 
        { 
            get => _nome; 
            set
            {
                if(value == "")
                {
                    throw new ArgumentException("É necessário que o curso tenha um nome!");
                }

                _nome = value;
            } 
        }
        public List<Pessoa> Alunos {get; set;}

        public void AdicionarAluno(Pessoa Aluno)
        {
            Alunos.Add(Aluno);
        }

        public void ListarAlunos()
        {
            foreach(Pessoa Aluno in Alunos)
            {
                Console.WriteLine(Aluno.NomeCompleto);
            }
        }

        public int QuantidadeAlunos()
        {
            return Alunos.Count;
        }
    }
}