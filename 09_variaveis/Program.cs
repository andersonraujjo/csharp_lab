Console.WriteLine("\n");
Console.WriteLine("-----------------------------");

//tipo da var - nome da var
string apresentacao = "Olá, seja bem-vindo ao módulo de váriaveis!";
int quantidade = 1;
double altura = 1.74;
decimal preco = 1.80M; //adicionar o m no final caso seja um valor decimal literal
bool condicao = false;

DateTime dataAtual = DateTime.Now;


Console.WriteLine(apresentacao);
Console.WriteLine($"A quantidade é {quantidade}.");
Console.WriteLine($"A altura é {altura}.");
Console.WriteLine($"O preço é {preco}.");
Console.WriteLine($"A condição booleana é {condicao}.");
Console.WriteLine($"A data atual é {dataAtual}.");
Console.WriteLine("\n");
Console.WriteLine("-----------------------------");


//casting

//converte com o convert, se for null ele converte pra 0
int a = Convert.ToInt32("5");
Console.WriteLine(a);

//converte com o parse, se der erro quebra, não pode ser nulo
int b = int.Parse("6");
Console.WriteLine(b);

//convertendo pra string
int inteiro = 9;
string c = inteiro.ToString();
Console.WriteLine(c);

//casting implicito
int d = 10;
double e = d;