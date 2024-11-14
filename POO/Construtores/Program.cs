using Construtores.Classes;

// Construtores
Aluno2 spadaMen = new Aluno2("Herik Spada", 55987);
Console.WriteLine(spadaMen.Nome);
Console.WriteLine(spadaMen.CPF);

// Criar um novo projeto console chamado PilaresPOO
// na pasta POO

Aluno2 bellyBarbosa = new Aluno2("Isabelly Barbosa");
bellyBarbosa.CPF = 1234;

Aluno2 giAlves = new Aluno2("Giovanna Alves");
giAlves.CPF = 5555;

Aluno2 eduCosta = new Aluno2();

Console.WriteLine(bellyBarbosa.Nome);
Console.WriteLine(bellyBarbosa.CPF);
Console.WriteLine(giAlves.Nome);
Console.WriteLine(giAlves.CPF);




// Veiculo carro1 = new Veiculo("Ford", "Ka", 2000, "Vermelho");
// Veiculo carro2 = new Veiculo("Ford", "Mustang", 1995, "Preto");
// Veiculo carro3 = new Veiculo();
// // exibir os dados dos carros
// carro1.ExibirDados();
// carro2.ExibirDados();

// cria uma lista de jogos - parecido com arrays
// List<Jogo> estoqueJogos = new List<Jogo>();





// Jogo cODuty = new Jogo("Call Of Duty", 2003, "Ação", 23);
// Jogo cODutyColossus = new Jogo("Call Of Duty - Shadow of The Colossus", 2005, "Ação", 90);
// Jogo littleNightMares = new Jogo("Little Nightmares", 2017, "Terror / Suspense", 205.80f);
// Jogo multiversus = new Jogo("Multiversus", 2022, "Ação / Luta", 0);


// // cadastrar os jogos em uma lista
// estoqueJogos.Add(cODuty);
// estoqueJogos.Add(cODutyColossus);
// estoqueJogos.Add(littleNightMares);
// estoqueJogos.Add(multiversus);

// // Exibe o nome de cada jogo cadastrado
// foreach (var jogo in estoqueJogos)
// {
//     jogo.ExibirDados();
//     Console.WriteLine();
// }





/*
Altere o programa jogo para que contenha os seguintes elementos:

 - Menu de Opções:
    1) Cadastrar Jogo
    2) Listar Jogos
    0) Sair
    
    Os dados deverão ser solicitados ao usuário
    
    O programa deverá rodar até o usuário escolher a opção sair.
*/