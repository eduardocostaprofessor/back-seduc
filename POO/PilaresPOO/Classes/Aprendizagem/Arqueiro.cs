// Subclasse - Herda de Personagem

namespace PilaresPOO.Classes.Aprendizagem
{
    public class Arqueiro : Personagem
    {
        public override void Atacar()
        {
            Console.WriteLine($"O arqueiro dispara uma flecha!");
            
        }
    }
}