
namespace PilaresPOO.Classes.Pilares
{
    public class ContaCorrente : Conta
    {
        // Propriedades
        public float Limite { get; set; }

        // Métodos
        public bool Transferir(float valor, Conta contaDestino)
        {

            return false;//simulando que deu erro
        }
        public override bool Depositar(float valor)
        {
            if (valor > 0)
            {
                Saldo = Saldo + valor;
                return true;
            }
            else
            {
                return false;
            }
        }

        // Saldo ->> R$ 1000
        public override float Sacar(float valor)//1200 ?
        {

            if (valor <= Saldo)
            {
                Saldo = Saldo - valor;

                return valor;//devolve o valor do saque
            } else 
            {
                Console.WriteLine($"Valor Menor que o Saldo");
                return 0;
            }


        }


    }
}