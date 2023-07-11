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
            System.Console.WriteLine($"Alunos do curso de: {Nome}");

            for (int i = 0; i < Alunos.Count; i++)
            {
                //string texto = "No " + i + " - " + Alunos[i].NomeCompleto ;
                string texto = $"No {i + 1} - {Alunos[i].NomeCompleto}";
                System.Console.WriteLine(texto);
            }

        }

    }
}