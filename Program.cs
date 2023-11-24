using System.Globalization;
using CSharp.Models;

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

Pessoa Aluno01 = new Pessoa("Matheus", "Urban", 21);

Pessoa Aluno02 = new()
{
    Nome = "Débora",
    Sobrenome = "Urban",
    Idade = 19
};

Curso Ingles = new()
{
    Nome = "Inglês",
    Alunos = new List<Pessoa>()
};

Ingles.AdicionarAluno(Aluno01);
Ingles.AdicionarAluno(Aluno02);

Ingles.ListarAlunos();

decimal dolar = 2525.99M;

Console.WriteLine($"{dolar:C0}");

DateTime data = DateTime.Now;

Console.WriteLine(data.ToString("dd/MM/yyyy"));