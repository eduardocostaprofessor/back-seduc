// variáveis e tipos de dados

// Criar um cabeçalho de boas vindas

using System.Numerics;

Console.WriteLine(@"
+-----------------------------------------+
|        Programa de Cadastros            |
+-----------------------------------------+
|               Olá :)                    |
| Por favor digite seus dados abaixo      |
+-----------------------------------------+");

Console.WriteLine(); // linha em vazia

// Pedir os dados de cadastro
Console.WriteLine($"Digite seu nome");
string nome = Console.ReadLine()!;
Console.WriteLine($"Olá, {nome}, digite seu sobrenome");
string sobrenome = Console.ReadLine()!;

// email
Console.WriteLine($"Qual é o seu e-mail?");
string email = Console.ReadLine()!;

// telefone
Console.WriteLine($"Qual é o seu telefone?");
UInt128 telefone = UInt128.Parse(Console.ReadLine()!);
// cpf
Console.WriteLine($"Qual cpf?");
UInt128 cpf = UInt128.Parse(Console.ReadLine()!);
// endereço
Console.WriteLine($"Qual é o seu endereço?");
string endereco = Console.ReadLine()!;

// Estado Civil
Console.WriteLine($"Qual é o seu estado civil?");
string estadoCivil = Console.ReadLine()!;

//Idade
Console.WriteLine($"Em que ano você nasceu");
int anoNascimento = int.Parse(Console.ReadLine());
int anoAtual = DateTime.Now.Year;
int idade = anoAtual - anoNascimento;


// // mostrar esses dados cadastrados
Console.Clear(); // limpa a tela
Console.WriteLine($"Cadastro concluído com sucesso!");
Console.WriteLine();
Console.WriteLine();

Console.WriteLine($"Nome Completo: {nome} {sobrenome}");
Console.WriteLine($"Idade: {idade}");
Console.WriteLine($"Telefone: {telefone}");
Console.WriteLine($"CPF: {cpf}");
Console.WriteLine($"Endereço: {endereco}");
Console.WriteLine($"Estado Civil: {estadoCivil}");










// Console.WriteLine(DateTime.Now.Year - new DateTime(1982, 07, 20).Year);



// estruturas condicionais
// laços de repetição
// arrays
