//salario basi
//ao mentar 15% salario base
//descontar 8% do salario
//dps mostrar o salario inicial, com aumento e o salario final.
Console.Clear();

Console.WriteLine("------------------------------------------");
Console.WriteLine("Vamos calclar o salario de um funcionario.");
Console.WriteLine("------------------------------------------");

Console.WriteLine("");

Console.Write("Informe o salario inicial: ");
double salarioBase = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("");

Console.WriteLine("sobre o salario de seu funcionario sera aumentado 15% e apos esse aumento vamos descontar 8% de impostos sobre este aumento.");

Console.WriteLine("");

//calculos de aumento e desconto da linha 22 ate a linha 27.
double SalarioAumento = salarioBase * 15 / 100;
double SalarioReal = salarioBase + SalarioAumento;

double descontoCalculo = SalarioReal * 8 /100;
SalarioReal = SalarioReal - descontoCalculo;


Console.WriteLine($"O valor base de seu funcionario foi de {salarioBase} seu funcionario teve um aumento de {SalarioAumento} e foram descontados cerca de {descontoCalculo} no total seu funcionario recebe-ra o valor de {SalarioReal}");


Console.ReadLine();