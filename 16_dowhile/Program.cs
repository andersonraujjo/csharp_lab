


using System.ComponentModel;

int soma = 0, numero = 0;


do
{
    Console.WriteLine("Digite um numero (0 interrompe): ");
    numero = Convert.ToInt32(Console.ReadLine());
    soma += numero;
}
while (numero !=0);{
    Console.WriteLine($"Total da soma dos numeros digitados é: {soma}");
    

    
}