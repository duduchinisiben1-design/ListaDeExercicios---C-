Console.Clear();

Console.WriteLine("Digite a quilometragem inicial do veiculo: ");
decimal KmInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite a quilometragem final do veiculo: ");
decimal KmFinal = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite a quantidade de combustivel do veiculo: ");
decimal Combustivel = Convert.ToDecimal(Console.ReadLine());

decimal DistanciaPercorrida = KmFinal - KmInicial;

decimal ConsumoPorKm = DistanciaPercorrida / Combustivel;


Console.WriteLine($"O consumo de combustivel foi de {ConsumoPorKm}L e a distancia percorrida foi de {DistanciaPercorrida}Km.");
Console.ReadLine();
