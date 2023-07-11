using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno)//Tipo Pessoa, mesmo da lista //nome do parametro ao criterio 
        {
            Alunos.Add(aluno); //Adiciona aluno na Lista Aluno
        }

        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno); //Remove aluno na Lista Aluno
        }

        public int ObterQuantidadeDeAlunosMatriculados()
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }

        public void ListarAlunos()
        {
            foreach (Pessoa aluno in Alunos)
            {
                System.Console.WriteLine(aluno.NomeCompleto);
            }
        }

    }
}