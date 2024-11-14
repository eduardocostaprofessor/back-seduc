// Exercício - LacosEx01
// Faça um programa que pergunte quantas pessoas tem à mesa (serão entrevistados).Para cada pessoa pergunte o sexo das pessoas e pergunte também se ela gosta de esportes. Ao final informe:

// quantidade de pessoas do sexo feminino 
// quantidade de pessoas do sexo masculino
// a quantidade de pessoas que gostam de esportes
// Total de entrevistados
// Percentual de pessoas que gostam de esportes

Console.WriteLine(@$"
------------------------
|Bem vindo ao programa |
|   Contador           |
|        de            |
|    Pessoas           |
------------------------
");

// criar um laço de 10 repetições
// dentro dele perguntar o sexo
// se for homem contar na variável qtdHomem
// se for mulher contar na variável qtdMulher
// ao final (fora do laço) exibir a quantidade de cada um 
int qtdHomem = 0;
int qtdMulher = 0;
int qtdEsportes = 0;
int qtdNaoGostaDeEsportes = 0;

Console.WriteLine($"Quantas pessoas tem na sua mesa?");
int qtdDeEntrevistados = int.Parse(Console.ReadLine()!);

for (int i = 1; i <= qtdDeEntrevistados; i++)
{
    Console.WriteLine($"Qual é o seu sexo? m/f");
    string sexo = Console.ReadLine();

    if (sexo == "f")
    {
        qtdMulher++;
    }
    else
    {
        qtdHomem++;
    }

    Console.WriteLine($"Voce gosta de esportes ? s/n");
    string esportes = Console.ReadLine();
    // alterar o código e contar/mostrar qauntidade que não gosta de esportes

    if (esportes == "s")
    {
        qtdEsportes++;//gostam de esportes
    }
    else
    {
        qtdNaoGostaDeEsportes++;
    }

}//fim do for

    // total 4
    // gostam 2
    // 100 / total * gostam
float percentual = (100 / qtdDeEntrevistados) * qtdEsportes;

// impressão dos resultados
Console.WriteLine($"Quantidade de Mulheres: {qtdMulher}");
Console.WriteLine($"Quantidade de Homens: {qtdHomem}");
Console.WriteLine($"Total de Entrevistados: {qtdDeEntrevistados}");
Console.WriteLine($"Total de pessoas que gostam de esportes {qtdEsportes}");
Console.WriteLine($"Total de pessoas que NÃO gostam de esportes {qtdNaoGostaDeEsportes}");
Console.WriteLine($"Percentual de pessoas que gostam de esportes {percentual} %");

