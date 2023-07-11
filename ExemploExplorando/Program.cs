using ExemploExplorando.Models;

Pessoa p1 = new Pessoa();
p1.Nome = "Felipe";
p1.Sobrenome = "Felix";

Pessoa p2 = new Pessoa();
p2.Nome = "Henrique";
p2.Sobrenome = " Souza Felix";

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();
