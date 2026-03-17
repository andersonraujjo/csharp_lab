

Console.Write("Digite a nota do aluno: ");
string notaInput = Console.ReadLine();

if (float.TryParse(notaInput, out float nota))
{
    if(nota >= 7)
    {
        Console.WriteLine($"Com sua nota de {nota} você foi aprovado!");

    }
    else if (nota <= 5)
    {
        Console.Write($"Com sua nota de {nota} você foi reprovado!");
    }

    else
    Console.Write($"Com sua nota de {nota} passou raspando!!");
}

else
{
    Console.WriteLine("Valor digitado inválido.");
}