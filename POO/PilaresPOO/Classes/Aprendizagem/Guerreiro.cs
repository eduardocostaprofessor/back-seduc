// Subclasse - Herda de Personagem

namespace PilaresPOO.Classes.Aprendizagem
{
    public class Guerreiro : Personagem
    {
        public override void Atacar()
        {
            Console.WriteLine($"O guerreiro ataca com sua espada!");
            
        }
    }
}