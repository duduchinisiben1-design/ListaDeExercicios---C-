//conversao de celsius para fahrenheit  F = (C X 9 / 5) + 32

Console.Clear();
Console.WriteLine("------------------------------------------------------");
Console.WriteLine("Vamos converter a temperatuda celsius para fahrenheit.");
Console.WriteLine("------------------------------------------------------");

Console.WriteLine("");

Console.Write("Qual o valor de ceusius?: ");
double c = Convert.ToDouble(Console.ReadLine());

double f = (c * 9 / 5) + 32;
Console.WriteLine("");

Console.WriteLine($"o valor convertido para fahrenheit é {f.ToString("F0")}");

Console.ReadLine();