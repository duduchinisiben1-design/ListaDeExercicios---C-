namespace Exercicio15.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Vamos calcular o IMC (Indice de Massa Corporal.) ");
            Console.WriteLine("-------------------------------------------------");

            Console.WriteLine("");

            Console.Write("Digite o peso: ");
            double peso = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a sua altura: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            double imc = peso / Math.Pow(altura, 2);

            if (imc < 18.5)
            {
                Console.WriteLine("Peso está abaixo do normal");
            }

            else if (imc <= 25)
            {
                Console.WriteLine("peso está normal");
            }

            else if (imc <= 30)
            {
                Console.WriteLine("O peso está acima do normal");
            }

            else
            {
                Console.WriteLine("Obesidade, o peso esta muito acima do normal");
            }           
        }
    }
}
