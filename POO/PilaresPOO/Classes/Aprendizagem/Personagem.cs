// Classe Base
namespace PilaresPOO.Classes.Aprendizagem
{
    public abstract class Personagem
    {
        // Criar um "método" Atacar que escreva no console : O personagem está atacando
        // virtual signfica que o método pode ser SOBRESCRITO na classe filha/subclasse
        public abstract void Atacar();
    }
}

// criar 3 classes (3 arquivos diferentes)
//  Mago, Guerreiro e Arqueiro 
// Criar o método virtual Atacar na classe Personagem
// Sobrescrever o método Atacar() nas classes filhas com o override
//      Personagem : O personagem está atacando
//      Mago : O mago lança o seu feitiço
//      Guerreiro : O guerreiro ataca com sua espada!!
//      Arqueiro : O arqueiro dispara uma flecha!

// Chamar o método atacar para cada um dos 4 personagens de nosso programa, lá na Program.cs

// Altere o programa e deixe a classe Personagem como abstrata e rode o programa mais uma vez!