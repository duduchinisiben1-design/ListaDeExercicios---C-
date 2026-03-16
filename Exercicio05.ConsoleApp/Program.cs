//salario base + camissao
//comissao = vendas * percentual /100

using System.Security.Cryptography;

Console.Clear();

Console.WriteLine("---------------------------------------------------------------------");
Console.WriteLine("Vamos calcular o salario de um vendedor com mais a comissao de vendas");
Console.WriteLine("---------------------------------------------------------------------");

Console.WriteLine("");

Console.Write("Qual o salario base deste vendedor?: ");
double salarioBase = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("");

Console.Write("Qual o valor total das vendas deste vendedor?: ");
double vendas = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("");

Console.Write("Qual o valor da comissao deste vendedor?: ");
double percentual = Convert.ToDouble(Console.ReadLine());

double comissao = vendas * percentual / 100;
double salarioTotal = salarioBase + comissao;

Console.WriteLine($"Sua comissao é de {comissao.ToString("F2")}");
Console.WriteLine("");
Console.WriteLine($"Seu salario total é de {salarioTotal.ToString("F2")}");

Console.ReadLine();