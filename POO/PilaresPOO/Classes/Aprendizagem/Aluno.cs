
namespace PilaresPOO.Classes.Aprendizagem
{
    //Herança - aluno herda pessoa
    public class Aluno : Pessoa 
    {
        // matricula
        public int Matricula { get; set; }
        
        // curso
        public string Curso { get; set; }
        
        // media
        public float Media { get; set; }
    }
}