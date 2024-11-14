// Importando as classes de dentro da pasta Classes
using System.Net.Http.Headers;
using ClasseObjeto.Classes;

//cria o objeto/variável animal
Animal cachorro = new Animal();
Animal gato = new Animal();

cachorro.nome = "Spaik";
cachorro.raca = "Shihtzu";
cachorro.cor = "Preto e Branco";
cachorro.idade = 5;

gato.nome = "Sol";
gato.raca = "Viralata";
gato.cor = "Preto e Branco";
gato.idade = 10;

Console.WriteLine();
Console.WriteLine();

Console.WriteLine($"Nome do cachorrinho: {cachorro.nome}");
Console.WriteLine($"Idade do {cachorro.nome}: {cachorro.idade}");
Console.WriteLine($"Cor do {cachorro.nome}: {cachorro.cor}");
Console.WriteLine($"Raça do {cachorro.nome}: {cachorro.raca}");

Console.WriteLine();
Console.WriteLine();

Console.WriteLine($"Nome do gatiho: {gato.nome}");
Console.WriteLine($"Idade do {gato.nome}: {gato.idade}");
Console.WriteLine($"Cor do {gato.nome}: {gato.cor}");
Console.WriteLine($"Raça do {gato.nome}: {gato.raca}");
Console.WriteLine();//escreve linha em branco