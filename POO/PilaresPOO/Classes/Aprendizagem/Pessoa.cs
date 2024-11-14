
namespace PilaresPOO.Classes.Aprendizagem
{
    public abstract class Pessoa
    {
        // Atributos - características
        // visibilidade tipoDeDado nomeDaProp
        public string Nome;
        public int Idade;
        public string Cpf;
        public float Peso { get; set; }
        public float Altura { get; set; }

        // Métodos - ações
        // visibilidade tipoDeDadoRetornado nome(parametros){corpo}
        // Envelhecer
        public void Envelhecer()
        {
            Idade++;
        }
        // Engordar
        public void Engordar(float _kg)
        {
            Peso = Peso + _kg;
        }

        public void Emagrecer(float _kg)
        {
            Peso = Peso - _kg;
        }
    }
}