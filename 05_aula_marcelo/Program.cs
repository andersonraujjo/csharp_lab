using System.Diagnostics;

Console.WriteLine("Digite o nome: ");
string nome = Console.ReadLine();

Console.WriteLine("Digite a idade: ");

string idadeInput = Console.ReadLine();

if (int.TryParse(idadeInput, out int idade))
{
    Console.WriteLine("------------");
}

else
{
    Console.WriteLine("Caracter inválido.");
}

Console.WriteLine("Digite a altura: ");
string alturaInput = Console.ReadLine();

if (double.TryParse(alturaInput, out double altura))
{
    Console.WriteLine("--------");
}

else
{
    Console.WriteLine("Valor não válido");
}

Console.WriteLine($"Nome: {nome}, Idade: {idade}, Altura: {altura}");