using _20_classe_pessoa.Models;

Pessoa pessoa1 = new Pessoa();
pessoa1.Nome = "Anderson";
pessoa1.Sobrenome = "da Silva Araujo";


Pessoa pessoa2 = new Pessoa();
pessoa2.Nome = "Lucas";
pessoa2.Sobrenome = "Bonfim";


Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingreis";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(pessoa1);
cursoDeIngles.AdicionarAluno(pessoa2);
cursoDeIngles.ListarAlunos();


// Pessoa pessoa1 = new Pessoa();
// pessoa1.Nome = "Anderson";
// pessoa1.Sobrenome = "da Silva Araujo";
// pessoa1.Idade = 27;
// pessoa1.Apresentar();

// //sinal de igual = set