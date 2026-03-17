

bool notaValida = false;
float nota = 0; //declara antes just to make sure


while (notaValida != true){
    
    Console.Write("Digite a nota do aluno: ");
    string notaInput = Console.ReadLine();

        if (float.TryParse(notaInput, out nota)) //como ja foi declarado antes como float so usa o out nota
{
            notaValida = true;

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
            Console.WriteLine("Valor digitado inválido, tente novamente!");
}
}