namespace Exercicio16.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Vamos verificar se o numero e par ou impar");
            Console.WriteLine("------------------------------------------");
            
            Console.WriteLine("");

            Console.Write("Digite um numero: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("Seu numero é um numero Par");
            }
            else
            {
                Console.WriteLine("Seu numero é impar");
            }
        }
    }
}