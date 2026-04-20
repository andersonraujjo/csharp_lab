namespace _20_classe_pessoa.Models;


public class Curso
{
    public string Nome {get;set;}
    public List<Pessoa> Alunos {get;set;}

    public void AdicionarAluno(Pessoa aluno)
    {
        Alunos.Add(aluno);
    }


    public int ObterQuantidadeDeAlunosMatriculados()
    {
        int quantidade = Alunos.Count;
        return quantidade;
    }

    public bool RemoverAluno(Pessoa aluno)
    {
        Alunos.Remove(aluno);
        return true;
    }

    public void ListarAlunos()
    {
        foreach(Pessoa aluno in Alunos)
        {
            Console.WriteLine(aluno.NomeCompleto);
        }
    } 

}
