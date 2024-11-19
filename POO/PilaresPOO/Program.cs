
using PilaresPOO.Classes.Pilares;
Console.Clear();

ContaCorrente ctEdu = new ContaCorrente();
ctEdu.Titular = "Eduardo Mendes da Costa";
ctEdu.Depositar(1000f);// usuário colocou grana direto no saldo

Console.WriteLine($"Titular da Conta: {ctEdu.Titular}"); 
Console.WriteLine($"Saldo Inicial da Conta: R${ctEdu.getSaldo()}");

float valorSacado = ctEdu.Sacar(200f);

Console.WriteLine($"Seu saque foi de: {valorSacado}");
Console.WriteLine($"Novo Saldo: R${ctEdu.getSaldo()}");