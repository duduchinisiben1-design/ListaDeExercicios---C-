while (true)
{
    Console.Clear();
    Console.WriteLine("Vamos calcular o volume de uma caixa retangular");
    Console.WriteLine("-------------------------------");
    Console.Write("Digite o valor do comprimento: ");
    double Comprimento = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("-------------------------------");
    Console.Write("Digite a Largura: ");
    double largura = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("-------------------------------");
    Console.WriteLine("Digite a Altura: ");
    double altura = Convert.ToDouble(Console.ReadLine());

    double volume = Comprimento * largura * altura;

    Console.WriteLine($"O volume da caixa é de {volume}");

    Console.WriteLine("");
    Console.WriteLine("Deseja Continuar? digite Y para continuar e N para sair");

    string? devContinuar = Console.ReadLine(); 
    
    if (devContinuar?.ToUpper() == "Y")
    {
        continue;
    }
    else
    {
        Console.WriteLine("Seu programa será finalzado, Pressione ENTER para fechar a pagina");
        break;
    }
}




Console.ReadLine();

