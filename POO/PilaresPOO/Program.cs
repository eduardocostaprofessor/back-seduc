// Herança
// Abstração
// Encapsulamento
// Polimorfismo

using PilaresPOO.Classes.Aprendizagem;

Aluno joao = new Aluno();
joao.Nome = "João";
Console.WriteLine($"{joao.Nome} Nasceu com {joao.Idade} anos");
Console.WriteLine();

// Dados do professor
Professor sam = new Professor(123321);
sam.Nome = "Samanta";
sam.Idade = 22;

// Dados do aluno
Aluno isaacBorges = new Aluno();

isaacBorges.Nome = "Isaac Borges";
isaacBorges.Idade = 17;
isaacBorges.Matricula = 1234987;
isaacBorges.Curso = "Dev";
isaacBorges.Media = 7.9f;

// Exibição dos dados
Console.WriteLine($"Curso: {isaacBorges.Curso}");
Console.WriteLine($"    Professor: {sam.Nome}");
Console.WriteLine($"    Identificação do Professor: {sam.NIF}");

Console.WriteLine($"    Aluno: {isaacBorges.Nome}");
Console.WriteLine($"    Idade: {isaacBorges.Idade}");
Console.WriteLine($"    Matrícula: {isaacBorges.Matricula}");
Console.WriteLine($"    Média: {isaacBorges.Media}");




//Serao criadas 4 classes: Veiculo, Aviao, Carro, Moto

// Veículo Classe Abstrata
    // Props/Atributos:
    // marca, modelo, cor, potência, qtdPassageiro

    // Métodos:
    // Ligar, Desligar, Buzinar

// Classes concretas que herdem de Veículo:
// Carro - Atributo: qtdPortas 
// Avião - Atributo: qtdPortas
// Moto - 

// Testar pelo menos um objeto de cada classe concreta 
// na classe program