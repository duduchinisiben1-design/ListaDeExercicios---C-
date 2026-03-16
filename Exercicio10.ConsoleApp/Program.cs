// paozizinho = 0.12;
// broa = 1.50;
// venda = broa + paozinho;
// 10% das vendas 
//  quantidadeDoDia = unidadesX
// int vendaPaozinho = unidadesX x paozinho
Console.Clear();

double paozinho = 0.12;
double broa = 1.50;

Console.WriteLine("----------------------------------------------------------");
Console.WriteLine("Vamos calcular o valor das vendas totais da padaria hotpao");
Console.WriteLine("----------------------------------------------------------");

Console.WriteLine("");

Console.Write("Digite quantas unidades de bisnaguinhas que foi vendida no dia: ");
double unidadePaozinho = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite quantas unidades de broas foram vendidas no dia: ");
double unidadeBroa = Convert.ToDouble(Console.ReadLine());


double paozinhoTotal = unidadePaozinho * paozinho;
double broaTotal = unidadeBroa * broa;
double valorVendaDoDia = broaTotal + paozinhoTotal; 
double valorDeDez = valorVendaDoDia * 10 / 100;

Console.WriteLine("");

Console.WriteLine($"O valor vendido de cada unidade de bisnaguinhas foi R${paozinhoTotal}, e o valor vendido por unidade das broas foram R${broaTotal}");

Console.WriteLine("");

Console.WriteLine($"Ja o valor das vendas do dia foram o total de R${valorVendaDoDia}");

Console.WriteLine("");

Console.WriteLine($"10% do valor das vendas será guardado para reserva da padaria, valor este sendo R${valorDeDez}");

Console.ReadLine();