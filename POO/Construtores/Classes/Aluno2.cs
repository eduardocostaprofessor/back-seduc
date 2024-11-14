
namespace Construtores.Classes
{
    public class Aluno2
    {
        public string Nome;
        public int CPF;

        // sobrecarga de métodos
        public Aluno2() { }
        public Aluno2(string _chuchu)
        {
            Nome = _chuchu;
        }

        // criar um 3º construtor que receba o nome e o cpf
        public Aluno2(string _nome, int _cpf){
            Nome = _nome;
            CPF = _cpf;
        }

    }
}