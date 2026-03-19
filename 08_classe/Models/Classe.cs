namespace _08_classe.Models; //nome do projeto + . + pasta, começa com _ pq aqui o projeto começa com num
    
//classe é o molde, representa um objeto da vida real.

//classe sempre começa com letra maiuscula
    public class Pessoa 
    {
        public string Nome {get; set;}
        public int Idade {get; set;}

        public void Apresentar()
    {
        Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} anos!");
        
    }
    }   
