


List<string> listaString = new List<string>();

listaString.Add("Rp");
listaString.AddRange("Sp","Go");

Console.WriteLine($"------------------------");
Console.WriteLine($"printando com o foreach:");
//printando com foreach
foreach(string item in listaString)
{
    Console.WriteLine($"Item: {item}");
}


Console.WriteLine($"------------------------");

//printando com for
//aqui o count substitui o lenght
Console.WriteLine($"printando com o for:");
for (int contador = 0; contador < listaString.Count; contador ++)
{
    Console.WriteLine($"Item de n° {contador+1}: {listaString[contador]}");
}

//listaString.Remove("Sp") > remove item x da lista
Console.WriteLine($"------------------------");