namespace Exercicio19.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("Vamos fazer a soma de todos os numeros impares do 1 ate 500.");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("");

            int soma = 0;

            for (int i = 1; i <= 500; i++)
            {
                if (i % 3 == 0 && i % 2 != 0)
                {
                    soma += i;
                }
            }

            Console.WriteLine($"A soma é {soma}");
        }
    }
}