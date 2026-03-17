
Console.Write("Digite a nota: ");
string notaInput = Console.ReadLine();

if (float.TryParse(notaInput, out float nota))
{
    Console.WriteLine($"A nota digitada foi {nota}");
}
else
{
    Console.WriteLine("Valor digitado inválido.");
}