using CSharp.Models;

Pessoa Aluno01 = new()
{
    Nome = "Matheus",
    Sobrenome = "Urban",
    Idade = 21
};

Pessoa Aluno02 = new()
{
    Nome = "Rebeca",
    Sobrenome = "Urban",
    Idade = 13
};

Pessoa Aluno03 = new("Débora", "Urban", 25);

Curso Ingles = new()
{
    Nome = "Inglês",
    Alunos = new List<Pessoa>()
};

Ingles.AdicionarAluno(Aluno01);
Ingles.AdicionarAluno(Aluno02);
Ingles.AdicionarAluno(Aluno03);

Ingles.ListarAlunos();

