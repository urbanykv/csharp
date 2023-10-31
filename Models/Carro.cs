namespace csharp.Models
{
    public class Carro
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }

        public void RenderizarInformacoes()
        {
            Console.WriteLine($"Modelo: {Modelo}\nMarca: {Marca}\nAno: {Ano}");
        }
    }
}