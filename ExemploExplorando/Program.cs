using ExemploExplorando.Models;

Pessoa p1 = new Pessoa(nome:"Felipe", sobrenome:"Felix");
Pessoa p2 = new Pessoa(nome:"Henrique",sobrenome:"Souza Felix");
Pessoa p3 = new Pessoa("Caroline", "Felix");

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.AdicionarAluno(p3);
cursoDeIngles.ListarAlunos();
