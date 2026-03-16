//V= π × r2 × h

Console.Clear();

Console.WriteLine("--------------------------------------");
Console.WriteLine("Vamos calcular o volume de um cilindro");
Console.WriteLine("--------------------------------------");

Console.WriteLine("");

Console.Write("Qual o valor do raio da base do cilindro?: ");
double raio = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("");

Console.Write("Qual o valor da altura do cilindro?: ");
double altura = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("");

double volume = Math.PI * Math.Pow(raio, 2) * altura; 

Console.WriteLine($"o volume do cilindo é {volume.ToString("F2")}");

Console.ReadLine();