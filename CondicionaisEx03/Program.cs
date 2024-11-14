// 3) Escreva     um     programa que leia     as     medidas     dos     lados     de     um     triângulo     e    escreva    se    ele    é    Equilátero,    Isósceles    ou    Escaleno.    Sendo    que:     

//    − Triângulo    Equilátero:    possui    os    3    lados    iguais.     
//    − Triângulo    Isóscele:    possui    2    lados    iguais.     
//    − Triângulo    Escaleno:    possui    3    lados    diferentes.

Console.Clear(); //limpa a tela
Console.WriteLine(@$"
------------------------
|Bem vindo ao programa |
|       dos            | 
|    Triângulos        |
------------------------
");

Console.WriteLine($"Digite o primeiro lado do trinângulo");
int ladoA = int.Parse(Console.ReadLine());

Console.WriteLine($"Digite o segundo lado do trinângulo");
int ladoB = int.Parse(Console.ReadLine());

Console.WriteLine($"Digite o terceiro lado do trinângulo");
int ladoC = int.Parse(Console.ReadLine());

if (ladoA == ladoB && ladoB == ladoC)
{
    Console.WriteLine($"O triângulo é EQUILÁTERO");
}
else if (ladoA == ladoC || ladoB == ladoC || ladoC == ladoA)
{
    Console.WriteLine($"O triângulo é ISÓCELE");
} else 
{
    Console.WriteLine("O triângulo é ESCALENO");
}

Console.WriteLine();//linha vazia
