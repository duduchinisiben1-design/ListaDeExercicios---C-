//DEBUGAR E VERIFICAR OS ERROS

//Console.Clear();


Console.WriteLine("------------------------------------------------------");
Console.WriteLine("Vamos ler 3 valores e organizalos em ordem crescente.");
Console.WriteLine("------------------------------------------------------");

Console.WriteLine("");

Console.Write("Escreva o primeiro valor: ");
int valor1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Escreva o segundo valor: ");
int valor2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Escreva o terceiro valor: ");
int valor3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("");

if (valor1 > valor2 && valor2 > valor3)
{
    Console.WriteLine($"A ordem de seus valores organizada sera a seguinte {valor1}, {valor2} e {valor3}");
}

else if (valor2  > valor1 && valor1 > valor3)
{
    Console.WriteLine($"A ordem de seus valores organizada sera a seguinte {valor2}, {valor1} e {valor3}");
}

else if (valor3 > valor2 && valor2 > valor1)
{
    Console.WriteLine($"A ordem de seus valores organizada sera a seguinte {valor3}, {valor2} e {valor1}");
}

else if (valor1 > valor3 && valor3 > valor2)
{
    Console.WriteLine($"A ordem de seus valores organizada sera a seguinte {valor1}, {valor3} e {valor2}");
}
else if (valor2 > valor3 && valor3 > valor1)
{
    Console.WriteLine($"A ordem de seus valores organizada sera a seguinte {valor2}, {valor3} e {valor1}");
}
else
{
    Console.WriteLine($"A ordem de seus valores organizada sera a seguinte {valor1}, {valor2} e {valor3}");
}
Console.ReadLine();

