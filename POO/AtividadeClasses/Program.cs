using AtividadeClasses;
Console.Clear();

Console.WriteLine(@$"*** Programa Fábrica de Carros! ***");

Veiculo bmwX6 = new Veiculo();
// entrada/processamento
Console.WriteLine($"Qual é a marca do carro?");
bmwX6.marca = Console.ReadLine();

Console.WriteLine($"Qual é o modelo?");
bmwX6.modelo = Console.ReadLine();

Console.WriteLine($"Qual é a cor?");
bmwX6.cor = Console.ReadLine();

Console.WriteLine($"Qual é a potência?");
bmwX6.potencia = Console.ReadLine();

Console.WriteLine($"Quantas portas?");
bmwX6.qtdPortas = int.Parse(Console.ReadLine()) ;

Console.WriteLine(@$"Carro: {bmwX6.marca} {bmwX6.modelo}!");

bmwX6.Ligar();
