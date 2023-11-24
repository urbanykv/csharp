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
            Console.WriteLine($"Alunos do curso: {Nome}");
            for(int contador = 0; contador < Alunos.Count; contador++)
            {
                Console.WriteLine($"{contador + 1} - {Alunos[contador]}");
            }
        }

        public int QuantidadeAlunos()
        {
            return Alunos.Count;
        }
    }
}