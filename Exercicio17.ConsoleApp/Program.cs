/*
Faça um algoritmo que leia dois valores inteiros A e B, se os valores forem iguais deverá se somar os dois, caso
contrário multiplique A por B. Ao final de qualquer um dos cálculos deve-se atribuir o resultado para uma
*/

namespace Exercicio17.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Vamos somar seus valores");
            Console.WriteLine("---------------------------------");

            Console.WriteLine("");

            Console.Write("Digite o valor de A: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor de B: ");
            double b = Convert.ToDouble(Console.ReadLine());

            double c;

            if (a == b)
            {
                c = a + b; 
                Console.WriteLine($"Seu valores são igual entao eles foram somados, seu valor é {c}");
            }
            else
            {
                c = a * b;
                Console.WriteLine($"Seu valores são diferentes entao seram multiplicados, seu valor é {c}");
            }
        }
    }
}