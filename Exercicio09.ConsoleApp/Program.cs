Console.WriteLine("-----------------------");
Console.WriteLine("Vamos verificar a area.");
Console.WriteLine("-----------------------");
Console.WriteLine("");

Console.Write("escreva o valor da base: ");
double b = Convert.ToDouble(Console.ReadLine());

Console.Write("escreva o valor da altura: ");
double altura= Convert.ToDouble(Console.ReadLine());

double area = b * altura;

Console.WriteLine("");

Console.WriteLine($"sua area é de {area}m²");
Console.ReadLine();