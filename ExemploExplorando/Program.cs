using ExemploExplorando.Models;
using System.Globalization;
// EXCECOES E COLECOES

try
{

    string[] linhas = File.ReadAllLines("Arquivos/arquivooLeitura.txt");

    foreach (string linha in linhas)
    {
        System.Console.WriteLine(linha);
    }

} catch(Exception ex)
{
    System.Console.WriteLine($"Ocorreu uma exception generica.{ex.Message}");
}







//-----------------------------------

// string dataString = "2023-01-17 20:00";

// bool sucesso = DateTime.TryParseExact(dataString,
//                       "yyyy-MM-dd HH:mm",
//                       CultureInfo.InvariantCulture,
//                       DateTimeStyles.None, out DateTime data);
// if (sucesso)
// {
//     System.Console.WriteLine($"Conversao com sucesso Data:  {data}");
// }
// else
// {
//     System.Console.WriteLine("Nao foi possivel a conversao!!");
// }

// DateTime data = DateTime.Now;
// System.Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));




// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

// decimal valorMonetario = 2482.40M;

// System.Console.WriteLine(valorMonetario.ToString("C4"));

// double porcentagem = .4545;

// System.Console.WriteLine(porcentagem.ToString("P"));

// int numero = 123456;
// System.Console.WriteLine(numero.ToString("###-###"));




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
