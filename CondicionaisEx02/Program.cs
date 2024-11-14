// Desenvolva um programa que recebe do usuário, o placar de um jogo de futebol (os gols de cada time) e informa se o resultado foi um empate, se a vitória foi do primeiro time ou do segundo time.
Console.Clear();// limpar a tela 
Console.WriteLine(@$"
------------------------
|Bem vindo ao programa |
|     FutResult        |
------------------------
");

// entrada dos gols
int golsTimaA;
int golsTimaB;

Console.WriteLine($"Entre com a quantidade de gols do time A");
golsTimaA = int.Parse(Console.ReadLine());
Console.WriteLine($"Entre com a quantidade de gols do time B");
golsTimaB = int.Parse(Console.ReadLine());

if (golsTimaA > golsTimaB)
{
    Console.WriteLine($"A vitória é do time A");

}
else if (golsTimaA < golsTimaB)
{
    Console.WriteLine($"A vitória é do time B");

}
else
{
    Console.WriteLine("O resultado foi um empate");
}



Console.WriteLine("");// pula linha 

