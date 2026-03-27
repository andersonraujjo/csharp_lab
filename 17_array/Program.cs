


int[] arrayInteiros = new int[3];

arrayInteiros[0] = 72;
arrayInteiros[1] = 65;
arrayInteiros[2] = 51;

//ou então declarando direto:
//int[] arrayInteiros_ = {72,65,51};

//com for
Console.WriteLine("Modo for:");
for(int contador = 0; contador < arrayInteiros.Length; contador++)
{
    Console.WriteLine($"Array na posição {contador} = {arrayInteiros[contador]}");
}

Console.WriteLine("---------------------");
//com join
Console.WriteLine("Modo Join:");
Console.WriteLine(string.Join(", ", arrayInteiros));


Console.WriteLine("---------------------");
Console.WriteLine("Modo foreach:");
//com foreach
foreach(int valor in arrayInteiros) //valor aqui recebe a mesma tipagem do array
{
    Console.WriteLine(valor);
}

//dobrando o array
int[] arrayInteirosDobrado = new int [arrayInteiros.Length *2];
Array.Copy(arrayInteiros,arrayInteirosDobrado,arrayInteiros.Length);
//(array origem, array destino, qtde da cópia)