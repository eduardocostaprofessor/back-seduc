// Novo Exercício, novo arquivo ( CondicionaisEx01 )

// Faça um programa que o usuário informe o salário recebido e o total gasto. Deverá ser exibido na tela “Gastos dentro do orçamento” caso o valor gasto não ultrapasse o valor do salário e “Orçamento estourado” se o valor gasto ultrapassar o valor do salário.

Console.WriteLine(@$"
------------------------
|Bem vindo ao programa |
|   Banco XPTO         |
------------------------
");

Console.WriteLine($"Entre com o valor do salário recebido");
float salario = float.Parse(Console.ReadLine()!);

Console.WriteLine($"Entre com o valor do gasto");
float gasto = float.Parse(Console.ReadLine()!);

if (salario >= gasto)
{
    Console.WriteLine($"Gastos dentro do orçamento");
}
else
{
    Console.WriteLine($"Orçamento estourado");
}