namespace Construtores.Classes
{
    public class Jogo
    {
        // nome, lancamento, genero, preco
        public string Nome { get; set; }
        public int Lancamento { get; set; }
        public string Genero { get; set; }
        public float Preco { get; set; }

        public Jogo(string nome, int lancamento, string genero, float preco)
        {
            Nome = nome;
            Lancamento = lancamento;
            Genero = genero;
            Preco = preco;
        }

        public void ExibirDados()
        {
            Console.WriteLine($@"
            Nome do Jogo: {Nome}
            Ano Lançamento: {Lancamento} 
            Genero: {Genero}
            Preço Atual: {Preco}
            ");
        }
    }
}