Console.Clear();

Console.WriteLine("-------------------------------------");
Console.WriteLine("Vamos calcular os valor de a A, B e C");
Console.WriteLine("-------------------------------------");

Console.WriteLine("");

Console.WriteLine("Oque sera feito? este programa ira ler os valor A, B e C e ira verificar se o valor de A + B é maior que o C.");

Console.WriteLine("");

Console.Write("Digite o valor de A: ");
double a = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o valor de B: ");
double b = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o valor de C: ");
double c = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("");

double somaAB = a + b;

if (somaAB > c)
{
    Console.WriteLine($"A soma de A mais B é maior que C o valor da soma foi {somaAB} o valor de C é {c}");
}
else if (somaAB == c)
{
    Console.WriteLine($"A soma de A mais B é igual a C o valor da soma foi {somaAB} o valor de C é {c}");
}
else
{
    Console.WriteLine($"A soma de A mais B é menor que C o valor da soma foi {somaAB} o valor de C é {c}");
}


Console.ReadLine();