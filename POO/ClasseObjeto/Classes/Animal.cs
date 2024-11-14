
namespace ClasseObjeto.Classes
{
    public class Animal
    {
        //Atributos:
        public string nome;
        public string cor; 
        public string raca;
        public int idade = 0;
        // visibilidade tipoRetorno nomeDoMétodo(parâmetros)
 
        //Metodos:
        public void FazerBarulho(string barulho = "Barulho Genérico")
        {
            Console.WriteLine($"Som do animal: {barulho}");
            
        }

        public void Envelhecer()
        {
            idade = idade + 1;
        }
    }
}