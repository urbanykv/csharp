
namespace CSharp.Models
{
    public class Calculadora
    {
        public void Somar(int num1, int num2)
        {
            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
        }
        
        public void Subtrair(int num1, int num2)
        {
            Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
        }

        public void Multiplicacao(int num1, int num2)
        {
            Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
        }

        public void Divisao(int num1, int num2)
        {
            Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
        }

        public void Potencia(int num1, int num2)
        {
            double potencia = Math.Pow(num1, num2);
            Console.WriteLine($"{num1} ^ {num2} = {potencia}");
        }

        public void RaizQuadrada(double num)
        {
            double raiz = Math.Sqrt(num);
            Console.WriteLine($"Raiz quadrada de {num} = {raiz}");
        }
    }
}

