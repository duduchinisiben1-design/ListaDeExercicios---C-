namespace Exercicio20.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Vamos fdazer a tabuada de um numero.");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("");

            Console.Write("Digite um numero: ");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                int resultado = num * i;
                Console.WriteLine($"{i} x {num} = {resultado}");
            }

        }
    }
}