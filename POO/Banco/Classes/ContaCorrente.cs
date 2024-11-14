
namespace Banco.Classes
{
    public class ContaCorrente
    {
        public int NumeroConta;
        public string? Titular; //valor vai ser pré preenchido
        public float Saldo = 0f;

        public void Depositar(float valor)
        {
            Saldo = Saldo + valor;
        }

        public void Sacar(float valor)
        {
            Saldo = Saldo - valor;
        }
    }
}