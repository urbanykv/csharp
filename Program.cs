try
{
    string[] linhas = File.ReadAllLines("./arquivoDeLeitura.txt");

    foreach ( string linha in linhas )
    {
        Console.WriteLine(linha);
    }
}
catch(Exception ex)
{
    Console.WriteLine($"Ocorreu uma exceção Generica {ex.Message}");
}
finally
{
    Console.WriteLine("Chegou até aqui.");
}

string[] nomes = new string[5];

nomes[0] = "Matheus";
nomes[1] = "Giulia";
nomes[2] = "Pércio";
nomes[3] = "Rebeca";
nomes[4] = "Débora";

Console.WriteLine(nomes);

List<string> nomesList = new()
{
    "Matheus",
    "Giulia",
    "Leila",
    "Pércio",
    "Rebeca",
    "Débora"
};

foreach(string nome in nomesList)
{
    Console.WriteLine(nome);
}


















//using System.Globalization;
//using CSharp.Models;

//CultureInfo.DefaultThreadCurrentCulture = new //CultureInfo("pt-BR");

//Pessoa Aluno01 = new("Matheus", "Urban", 21);

//Pessoa Aluno02 = new()
//{
//    Nome = "Débora",
//    Sobrenome = "Urban",
//    Idade = 19
//};

//Curso Ingles = new()
//{
//    Nome = "Inglês",
//    Alunos = new List<Pessoa>()
//};

//Ingles.AdicionarAluno(Aluno01);
//Ingles.AdicionarAluno(Aluno02);

//Ingles.ListarAlunos();

//decimal dolar = 2525.99M;

//Console.WriteLine($"{dolar:C0}");

//DateTime data = DateTime.Now;

//Console.WriteLine(data.ToString("dd/MM/yyyy"));