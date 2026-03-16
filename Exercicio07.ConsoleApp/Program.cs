using System.Diagnostics.CodeAnalysis;

Console.WriteLine("------------------------------------------------");
Console.WriteLine("vamos calcular a nota de duas provas de um aluno");
Console.WriteLine("------------------------------------------------");

Console.WriteLine("");

Console.Write("Digite a nota da primeira prova: ");
double prova1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite a nota da segunda prova: ");
double prova2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("");

Console.WriteLine("Digite o peso das provas");

Console.WriteLine("");

Console.Write("peso 1: ");
double peso1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("");


Console.Write("peso 2: ");
double peso2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("");

double media = ((prova1 * peso1) + (prova2 * peso2)) / (peso1 + peso2);



Console.WriteLine(media);




Console.ReadLine();