using Banco.Classes;

Console.Clear();
Console.WriteLine($"Bem vindo ao Nubanquinho");
Console.WriteLine();

// Correntistas
ContaCorrente contaEmilly = new ContaCorrente();
ContaCorrente contaClara = new ContaCorrente();

contaEmilly.Titular = "Emilly";
contaEmilly.Depositar(1000000f);

contaClara.Titular = "Clara";
contaClara.Depositar(1000000f);

Console.WriteLine($"Conta da {contaEmilly.Titular} tem R${contaEmilly.Saldo}");
Console.WriteLine($"Conta da {contaClara.Titular} tem R${contaClara.Saldo}");

contaClara.Sacar(250f);

Console.WriteLine($"Você sacou e sua conta ficou com R${contaClara.Saldo}");
Console.WriteLine();
Console.WriteLine();

Console.WriteLine($"Conta da {contaEmilly.Titular} tem R${contaEmilly.Saldo}");
Console.WriteLine($"Conta da {contaClara.Titular} tem R${contaClara.Saldo}");
Console.WriteLine();
