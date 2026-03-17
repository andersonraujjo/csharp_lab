Console.WriteLine("Digite o primeiro numero: ");
double primeiro_num = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o segundo numero:");
double segundo_num = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite a operação: \n1 - Adição \n 2 - Subtração \n 3 - Multiplicação \n 4 - Divisão");
int entrada = Convert.ToInt32(Console.ReadLine());

switch(entrada)
{
    case 1:
    Console.WriteLine($"A adição de {primeiro_num} com {segundo_num} é igual a {primeiro_num+segundo_num}");
    break;
    
    case 2:
    Console.WriteLine($"A subtração de {primeiro_num} com {segundo_num} é igual a {primeiro_num-segundo_num}");
    break;
    
    case 3:
    Console.WriteLine($"A multiplicação de {primeiro_num} com {segundo_num} é igual a {primeiro_num*segundo_num}");
    break;
    
    case 4:
    Console.WriteLine($"A divisão de {primeiro_num} por {segundo_num} é igual a {primeiro_num/segundo_num}");
    break;
    


}