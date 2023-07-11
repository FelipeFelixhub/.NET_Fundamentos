using ExemploExplorando.Models;
using System.Globalization;

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

decimal valorMonetario = 2482.40M;

System.Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));







// Pessoa p1 = new Pessoa(nome:"Felipe", sobrenome:"Felix");
// Pessoa p2 = new Pessoa(nome:"Henrique",sobrenome:"Souza Felix");
// Pessoa p3 = new Pessoa(nome:"Caroline",sobrenome: "Felix");

// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Ingles";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.AdicionarAluno(p3);
// cursoDeIngles.ListarAlunos();
