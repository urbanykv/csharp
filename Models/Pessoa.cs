

namespace CSharp.Models
{
    public class Pessoa 
    {

        public Pessoa()
        {

        }

        public Pessoa(string nome, string sobrenome, int idade)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Idade = idade;
        }

        private string _nome;

        private string _sobrenome;

        private int _idade;

        public string Nome 
        { 
            get => _nome.ToUpper();

            set
            {
               if(value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }

                _nome = value;
            }
        }

        public string Sobrenome
        { 
            get => _sobrenome.ToUpper();

            set
            {
               if(value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }

                _sobrenome = value;
            }
        }

        public string NomeCompleto => Nome + " " + Sobrenome;

        public int Idade 
        { 
            get => _idade;

            set
            {
               if(value < 0)
                {
                    throw new ArgumentException("A idade não pode ser menor que 0");
                }

                _idade = value;
            }
        }

        public void Apresentar() 
        {
            Console.WriteLine($"Olá, meu nome é {NomeCompleto} e eu tenho {Idade} anos.");
        }
    }
};