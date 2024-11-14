string[] frutas = {"Melancia", "Carambola", "Maracujá", "Morango", "Limão", "Jabuticaba", "Abacate", "Kiwi", "Acerola", "Pinha", "Lichia", "Pitaya", "Pêssego", "Banana"};

Console.Write($"Sua sacola contém {frutas.Length} frutas: ");

// percorre todo o array e exibe cada fruta
foreach (string f in frutas)
{
    Console.Write($"{f}, ");
}

Console.WriteLine();



// Crie um novo projeto console - DesafioForeach01
// Carregue um array fixo de 10 números
// Utilize um laço foreach para imprimir o dobro de cada número do array