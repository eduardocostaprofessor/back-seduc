namespace Calculator.Classes
{
    public class Calculadora
    {
        public float numero1;
        public float numero2;




        public void Somar(float maria1, float joao2)
        {
            // guardando os números recebidos lá nas propriedades
            numero1 = maria1;
            numero2 = joao2;

            // processando o resultado
            float resultado = numero1 + numero2;

            // saída do resultlado
            Console.WriteLine($"O resultado da soma é: {resultado}");


        }

        public void Multiplicar(float leandra1, float ruana2)
        {
            // guardando os números recebidos lá nas propriedades
            numero1 = leandra1;
            numero2 = ruana2;

            // processando o resultado
            float resultado = numero1 * numero2;

            // saída do resultlado
            Console.WriteLine($"O resultado da Multiplicação é: {resultado}");
        }

        public void Subtrair(float pepe1, float nenem2)
        {
            // guardando os números recebidos lá nas propriedades
            numero1 = pepe1;
            numero2 = nenem2;

            // processando o resultado
            float resultado = numero1 - numero2;

            // saída do resultlado
            Console.WriteLine($"O resultado da Subtração é: {resultado}");
        }

        public void Dividir(float flora1, float raiane2)
        {
            // guardando os números recebidos lá nas propriedades
            numero1 = flora1;
            numero2 = raiane2;

            // processando o resultado
            float resultado = numero1 / numero2;

            // saída do resultlado
            Console.WriteLine($"O resultado da Divisão é: {resultado}");
        }

    }
}