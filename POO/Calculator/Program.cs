using Calculator.Classes;

Console.Clear();
Console.WriteLine($"***** PROGRAMA CALCULATOR *****");
Console.WriteLine();


Console.Write("Informe o primeiro número: ");
float n1 = float.Parse(Console.ReadLine());
Console.Write("Informe o segundo número: ");
float n2 = float.Parse(Console.ReadLine());

Console.Write($@"
    1) Somar
    2) Subtrair
    3) Multiplicar
    4) Dividir
    Digite a operação: ");
string operacao = Console.ReadLine();
Console.WriteLine();

Calculadora calculadoraDaAnna = new Calculadora();

if (operacao == "1")
{
    calculadoraDaAnna.Somar(n1, n2);
}
else if (operacao == "2")
{
    calculadoraDaAnna.Subtrair(n1, n2);

}
else if (operacao == "3")
{

    calculadoraDaAnna.Multiplicar(n1, n2);
}
else if (operacao == "4")
{
    calculadoraDaAnna.Dividir(n1, n2);
} 
else {
    Console.WriteLine($"Operação Inválida!");
    
}
Console.WriteLine();

Console.WriteLine($"Obrigado por utilizar a Calculator, até logo!");
Console.WriteLine();
