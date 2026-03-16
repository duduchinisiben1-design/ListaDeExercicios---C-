Console.WriteLine("-----------------------------------");
Console.WriteLine("Vamos verificar se o numero é primo");
Console.WriteLine("-----------------------------------");

Console.Write("Digite o numero que deseja verificar: ");
int numero = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");

bool primo = true;

for (int i = 2; i < numero; i++)
{
    if (numero % i == 0)
    {
        primo = false;
    }
}

if (primo && numero > 1)
{
    Console.WriteLine("Seu numero é um numero primo");
}
else
{
    Console.WriteLine("Seu numero não é um numero primo");
}

Console.ReadLine();