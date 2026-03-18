namespace Exercicio18.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Vamos veriificar os valores impares de 100 a 200");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("");

            for (int i = 101; i < 200; i = i + 2)
            {    
            Console.WriteLine(i);
            }
        }
    }
}