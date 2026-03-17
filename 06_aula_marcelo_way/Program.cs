
Console.WriteLine("Entre com o nome: ");
string nome = Console.ReadLine();

Console.WriteLine("Entre com a idade: ");
int idade = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Entre com a altura: ");
double altura = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Nome: {nome}, Altura: {altura:f2}, Idade: {idade}");

