Console.Clear();

Console.WriteLine("---------------------------------------------");
Console.WriteLine("Vamos virificar a media harmonica de um aluno?");
Console.WriteLine("---------------------------------------------");

Console.Write("Digite o valor da primeira nota: ");
double nota1 = Convert.ToDouble(Console.ReadLine());


Console.Write("Digite o valor da segunda nota: ");
double nota2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o valor da terceira nota: ");
double nota3 = Convert.ToDouble(Console.ReadLine());

double soma = (1/nota1) + (1/nota2) + (1/nota3);

double media = 3 / soma;

Console.WriteLine(media.ToString("F2"));

Console.ReadLine();