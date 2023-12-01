using System;

class Program
{
    static void Main()
    {
        // Solicita o nome do usuário, quilômetros percorridos por dia, 
       // Horas de uso de eletrônicos por dia e o número de refeições com carne:
       string nome = Console.ReadLine();
       double quilometrosPorDia = double.Parse(Console.ReadLine());
       int horasDeEletronicos = int.Parse(Console.ReadLine());
       int refeicoesComCarne = int.Parse(Console.ReadLine());

        // Chama o método para calcular a pegada de carbono
        double pegadaDeCarbono = CalcularPegadaDeCarbono(quilometrosPorDia, horasDeEletronicos, refeicoesComCarne);
        
        // TODO: Exiba o resultado para o usuário:
        Console.WriteLine($"{nome}, sua pegada de carbono e de {pegadaDeCarbono} toneladas de CO2 por ano.");

        // Aguarda a entrada do usuário antes de encerrar o programa:
        Console.ReadLine();
    }

    // TODO: Crie um método/função para calcular a pegada de carbono com base nos parâmetros fornecidos:
    static double CalcularPegadaDeCarbono(double kmPorDia, int horasDeEletronicos, int refeicoesComCarne)
    {
        // Fatores de emissão
        double fatorTransporte = 0.2;
        double fatorEletronicos = 0.1;
        double fatorCarne = 0.5;

        // Cálculo da pegada de carbono
        double pegadaTransporte = kmPorDia * 365 * fatorTransporte;
        double pegadaEletronicos = horasDeEletronicos * fatorEletronicos;
        double pegadaCarne = refeicoesComCarne * fatorCarne;

        // Soma dos valores para obter a pegada total
        double pegadaTotal = pegadaTransporte + pegadaEletronicos + pegadaCarne;

        return pegadaTotal;
    }

}







// Dictionary<string, string> dicionario = new();

// dicionario.Add("Nome", "Matheus");
// dicionario.Add("Sobrenome", "Urban");

// foreach (var item in dicionario)
// {
//     Console.WriteLine($"{item.Key}: {item.Value}");
// }

// dicionario.Remove("Sobrenome");

// dicionario["Nome"] = "Leandro";

// foreach (var item in dicionario)
// {
//     Console.WriteLine($"{item.Key}: {item.Value}");
// }













// using System.Collections.Generic;
// using System.Numerics;

// Stack<int> pilha = new();

// pilha.Push(4);
// pilha.Push(8);
// pilha.Push(16);
// pilha.Push(32);
// pilha.Push(64);

// foreach(int item in pilha)
// {
//     Console.WriteLine(item);
// }

// pilha.Pop();

// foreach(int item in pilha)
// {
//     Console.WriteLine(item);
// }















// using System.Collections.Generic;
// using System.Numerics;

// Queue <int> fila = new();

// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);
// fila.Enqueue(10);

// foreach(int item in fila)
// {
//     Console.WriteLine(item);
// }

// fila.Dequeue();

// foreach(int item in fila)
// {
//     Console.WriteLine(item);
// }


















// try
// {
//     string[] linhas = File.ReadAllLines("./arquivoDeLeitura.txt");

//     foreach ( string linha in linhas )
//     {
//         Console.WriteLine(linha);
//     }
// }
// catch(Exception ex)
// {
//     Console.WriteLine($"Ocorreu uma exceção Generica {ex.Message}");
// }
// finally
// {
//     Console.WriteLine("Chegou até aqui.");
// }

// string[] nomes = new string[5];

// nomes[0] = "Matheus";
// nomes[1] = "Giulia";
// nomes[2] = "Pércio";
// nomes[3] = "Rebeca";
// nomes[4] = "Débora";

// Console.WriteLine(nomes);

// List<string> nomesList = new()
// {
//     "Matheus",
//     "Giulia",
//     "Leila",
//     "Pércio",
//     "Rebeca",
//     "Débora"
// };

// foreach(string nome in nomesList)
// {
//     Console.WriteLine(nome);
// }


















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