﻿// Sabemos que um aluno é aprovado caso apresente média maior ou igual a 7.0 e frequência maior ou igual a 75%. Na verdade, em uma situação real, se o aluno obtiver a frequência mínima exigida e uma média entre 3 e 7, ainda teria direito a uma última avaliação de recuperação. Como faríamos para resolver o problema em questão utilizando apenas estruturas de condição se-então-senão? Poderíamos começar avaliando a frequência do aluno, e se a mesma for menor que 75% o aluno já estaria reprovado, porém caso a frequência respeite o mínimo exigido, começaríamos a avaliar a média para saber se está aprovado, em recuperação ou reprovado.


Console.Clear(); //limpa a tela
Console.WriteLine(@$"
------------------------
|Bem vindo ao programa |
|       dos            | 
|   Média Aluno        |
------------------------
"); 


float media = 7;
float frequencia = 78;

if (frequencia >= 75 )
{
    // aprovado
    // recuperação
    // reprovado
    
} else 
{
    Console.WriteLine($"Aluno foi reprovado :`(");

}
