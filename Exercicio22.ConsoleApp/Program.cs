namespace Exercicio22.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Sequencia Fibonacci");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("");

            Console.Write("Digite o limite de seu fibonacci: ");
            int limite = Convert.ToInt32(Console.ReadLine());
            
            int a = 0;
            int b = 1;

            int proximo = a + b;

            while (proximo <= limite)
            {
                Console.Write($"{proximo} ");

                a = b;
                b = proximo;
                proximo = a + b;
            }
            
        }
    }
}