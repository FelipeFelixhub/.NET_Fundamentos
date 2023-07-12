using ExemploExplorando.Models;
using System.Globalization;

// COLECOES

//FILA - QUEUE

Queue<int> fila = new Queue<int>();

fila.Enqueue(1);
fila.Enqueue(2);
fila.Enqueue(3);

foreach (int item in fila)
{
    System.Console.WriteLine(item);
}

System.Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");

foreach (int item in fila)
{
    System.Console.WriteLine(item);
}





//-----------------------------
// EXCECOES


// new ExemploExcecao().Metodo1();


// try
// {

//     string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

//     foreach (string linha in linhas)
//     {
//         System.Console.WriteLine(linha);
//     }



// }
// catch (FileNotFoundException ex)
// {
//     System.Console.WriteLine($"Ocorreu um erro na leitura do arquivo.{ex.Message}");
// }

// catch (DirectoryNotFoundException ex)
// {
//     System.Console.WriteLine($"Caminho da pasta nao encontrado.{ex.Message}");
// }

// catch (Exception ex)
// {
//     System.Console.WriteLine($"Ocorreu uma exception generica.{ex.Message}");
// }
// finally
// {
//     System.Console.WriteLine("Chegou ate aqui!!");
// }




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
