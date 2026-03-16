//nome pessoa
//idade pessoa
//exibir quantos dias de vida uma pessoa tem
//idade x diasPorAno.

Console.Clear();

Console.WriteLine("-----------------------------------------------");
Console.WriteLine("Vamos ver quantos dias voce ja viveu ate agora?");
Console.WriteLine("-----------------------------------------------");

Console.WriteLine("");

Console.Write("Digite seu nome: ");
string? nome = Console.ReadLine();

Console.WriteLine("");

Console.Write("Digite sua idade: ");
int idade = Convert.ToInt32(Console.ReadLine());

int diasDoAno = 365;

int diasVivido = idade * diasDoAno;

Console.WriteLine("");

Console.WriteLine($"Seu nome é {nome} e voce ja viveu {diasVivido}");

Console.ReadLine();