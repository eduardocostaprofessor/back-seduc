
namespace PilaresPOO.Classes.Aprendizagem
{
    public class PowerGeneric : Personagem
    {
        // não tem o método Atacar, ele usa o método do pai
        public override void Atacar()
        {
            Console.WriteLine($"O personagem está atacando!");
            
        }
    }
}