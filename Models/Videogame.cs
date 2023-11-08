using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csharp.Models
{
    public class Videogame
    {
        public Videogame(string modelo, string marca, int ano)
        {
            Modelo = modelo;
            Marca = marca;
            Ano = ano;
        }
        private string _modelo;
        private string _marca;
        private int _ano;

        public string Modelo 
        { 
            get => _modelo;
            set
            {
                if(value == "")
                {
                    throw new ArgumentException("Preencha este campo!");
                }

                _modelo = value;
            } 
        }
        public string Marca { get; set; }
        public int Ano { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"O {Modelo} da {Marca} foi lançado em {Ano}");
        }
    }
}