namespace Exercicio21.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Vamos virificar o valor de fatorial.");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("");

            Console.Write("Digite um nuemro: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int fatorial = 1;
            Console.Write($"{num}!= ");

            for (int i = num; i > 1; i--)
            {
                Console.Write($"{i}x");             
                fatorial *= i;
            }

            Console.Write($"1 = {fatorial}"); 
        }
    }
}