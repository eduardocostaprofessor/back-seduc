using ClasseObjeto.Classes;

Console.Clear();//limpa a tela
Console.WriteLine($"** Bem vindo ao programa ZooSharp **");
Console.WriteLine();//pula linha


Animal cachorrinho = new Animal();
cachorrinho.nome = "Luna";
cachorrinho.cor = "Branca e Marrom";
cachorrinho.idade = 3;
cachorrinho.raca = "American Bully";

Animal cachorrinhoDaBrito = new Animal();
cachorrinhoDaBrito.nome = "Max";
cachorrinhoDaBrito.cor = "Branco";
cachorrinhoDaBrito.raca = "Poodle";
cachorrinhoDaBrito.idade = 4;

Animal peixeDoKaue = new Animal();
peixeDoKaue.nome = "Anna";
peixeDoKaue.cor = "Amarelo";
peixeDoKaue.raca = "Telescópio";
peixeDoKaue.idade = 17;


// Console.WriteLine(@$"Animal 1: 
//     Nome: {cachorrinho.nome}
//     Raça: {cachorrinho.raca}
//     Cor: {cachorrinho.cor}
//     Idade: {cachorrinho.idade}
// ");

// Console.WriteLine(@$"Animal 2: 
//     Nome: {cachorrinhoDaBrito.nome}
//     Raça: {cachorrinhoDaBrito.raca}
//     Cor: {cachorrinhoDaBrito.cor}
//     Idade: {cachorrinhoDaBrito.idade}
// ");

// Console.WriteLine(@$"Animal 3: 
//     Nome: {peixeDoKaue.nome}
//     Raça: {peixeDoKaue.raca}
//     Cor: {peixeDoKaue.cor}
//     Idade: {peixeDoKaue.idade}
// ");


cachorrinho.FazerBarulho("Au Au");
Console.WriteLine($"Idade de {cachorrinho.nome} é {cachorrinho.idade}");
cachorrinho.Envelhecer();
Console.WriteLine($"Nova idade de {cachorrinho.nome} é {cachorrinho.idade}");

cachorrinhoDaBrito.FazerBarulho("Ow Ow");
Console.WriteLine($"Idade de {cachorrinhoDaBrito.nome} é {cachorrinhoDaBrito.idade}");

peixeDoKaue.FazerBarulho();
// exibir a idade de cada animal
Console.WriteLine($"Idade de {peixeDoKaue.nome} é {peixeDoKaue.idade}");