/*
    Enunciado
    Uma certa empresa fez uma pesquisa de mercado com 10 pessoas para saber
    se elas gostaram um determinado produto lançado. Para isso forneceu o sexo do entrevistado
    e sua resposta (sim ou não).
    Faça um programa que calcule e imprima:

        A.	O número de pessoas que responderam SIM;
        B.	O número de pessoas que responderam NÃO;
        C.	O número de mulheres que responderam SIM;
        D.	A porcentagem de homens que responderam NÃO entre todos
        E.	os homens analisados.

        Sugerir ao aluno para mostrar o número total de intrevistados na pesquisa!
        Este exercício pode ser alterado para outros contextos, como por exemplo, 
        total de sensores ligados dentro de um determinado número de tempo, quantos sensores falharam, 
        ou qualquer outro tipo de relatório baseado em sensores.

*/


Console.Clear(); //limpa a tela
Console.WriteLine(@$"
+----------------------+
|Bem vindo ao programa |
|       Pesquisa       |
|          de          | 
|        Mercado       |
+----------------------+
");

int totalSim = 0;
int totalNao = 0;
int mulherSim = 0;
int homemNao = 0;
int totalDeHomens = 0;
int totalDeMulheres = 0;


for (int p = 1; p <= 10; p++)
{
    Console.WriteLine($"Qual é o seu sexo? m/f");
    string sexo = Console.ReadLine()!;
    
    Console.WriteLine($"Você gostou do produto? s/n");
    string resposta = Console.ReadLine()!;

    if (sexo == "f")
    {
        totalDeMulheres++;
    }
    else
    {
        totalDeHomens++;
    }

    // se gostou do produto
    if (resposta == "s")
    {
        totalSim++;
        if(sexo == "f") {
            mulherSim++;
        }
    }
    else
    {//resposta não
        totalNao++;

        // homem que respondeu não
        if (sexo == "m")
        {   
            homemNao++;
        }
    }
}//fim do for


// saída dos totais - relatório

float percentualHomensNao = (100 / totalDeHomens) * homemNao;

// O número de pessoas que responderam SIM;
Console.WriteLine($"O número de pessoas que responderam SIM : {totalSim}");

// O número de pessoas que responderam NÃO;
Console.WriteLine($"O número de pessoas que responderam NÃO : {totalNao}");

// O número de mulheres que responderam SIM;
Console.WriteLine($"O número de mulheres que responderam SIM : {mulherSim}");

// A porcentagem de homens que responderam NÃO entre todos os homens analisados.
Console.WriteLine($"A porcentagem de homens que responderam NÃO : {percentualHomensNao}");
