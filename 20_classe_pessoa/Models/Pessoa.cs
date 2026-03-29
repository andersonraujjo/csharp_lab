namespace _20_classe_pessoa.Models

{public class Pessoa
    {
        private string _nome;


        public string Nome {
        get
            {
                return _nome.ToUpper();
            }

        
        set //atribuir valor
        {
            if (value == "")
                {
                    throw new ArgumentException ("O nome não pode ser vazio."); // famoso try except
                    
                } 
            _nome = value;
        }
        
        }
        
        
        public int Idade {get;set;}

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
        }
    }

}