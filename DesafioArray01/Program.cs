int[] numeros = new int[6]; //array vazio
int par = 0, impar = 0;

// entrada de dados
for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"Digite o {i + 1}º número");
    int numeroDigitado = int.Parse(Console.ReadLine()!);
    numeros[i] = numeroDigitado;//guarda o número no array

    if (numeroDigitado % 2 == 0)
    { //par
        par++;
    }
    else
    { //ímpar
        impar++;
    }
}

Console.Clear();//limpa a tela
//          0   1  2   3   4  5   
// array ( 35, 22, 15, 17, 7, 21 )
// Desafio
Console.WriteLine($"{par} número(s) par(es): ");
// 22
for (int i = 0; i < numeros.Length; i++)
{
    if(numeros[i] % 2 == 0){ //se for par
        Console.Write($"{numeros[i]} ");
    }
}

 Console.WriteLine();//pula uma linha
 Console.WriteLine();//pula uma linha

Console.WriteLine($"{impar} número(s) impar(es):");
//          0   1  2   3   4  5
// array ( 35, 22, 15, 17, 7, 21 )
for (int i = 0; i < numeros.Length; i++)
{
    if (numeros[i] % 2 == 1)
    {
        Console.Write($"{numeros[i]} ");
    }
}

 Console.WriteLine();//pula uma linha
 Console.WriteLine();//pula uma linha