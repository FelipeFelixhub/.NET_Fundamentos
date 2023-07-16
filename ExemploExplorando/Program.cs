using ExemploExplorando.Models;
using System.Globalization;
using Newtonsoft.Json;

//TIPOS NULOS

// bool? desejaReceberEmail = true;

// if (desejaReceberEmail.HasValue && desejaReceberEmail.Value)
// {
//     System.Console.WriteLine("O usuario optou por receber email");
// }
// else
// {
//     System.Console.WriteLine("O usuario nao respondeu ou optou por nao receber email");
// }



// --------------------------------------

//DESERIALIZACAO


// string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

// List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

// foreach (Venda venda in listaVenda)
// {
//     System.Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, "
//                             + $"Preco: {venda.Preco}, Data: {venda.DataVenda.ToString("dd/MM/yyy HH:mm")}"
//                             + $"{(venda.Desconto.HasValue ? $", Desconto de : {venda.Desconto}" : "")}");
// }




//-------------------------------

//SERIALIZACAO

// DateTime dataAtual = DateTime.Now;


// List<Venda> listaVendas = new List<Venda>();

// Venda v1 = new Venda(1, "Material de escritorio", 25.00M, dataAtual);
// Venda v2 = new Venda(2,"Licenca de Software", 130.00M, dataAtual);

// listaVendas.Add(v1);
// listaVendas.Add(v2);

// string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

// File.WriteAllText("Arquivos/vendas.json", serializado);

// System.Console.WriteLine(serializado);





//----------------------------------------

// TERNARIO

// int numero = 20;
// bool ehPar = false;

// ehPar = numero % 2 == 0;
// System.Console.WriteLine($"O numero {numero} é " + (ehPar ? "par" : "impar"));



//--------------------------

//TUPLAS


// Pessoa p1 = new Pessoa("Felipe", "Felix");

// (string nome, string sobrenome) = p1;

// System.Console.WriteLine(nome + sobrenome);


// LeituraArquivo arquivo = new LeituraArquivo();

// var (sucesso, linhasArquivo, _) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

// if (sucesso)
// {
//     //System.Console.WriteLine($"Quantidade linhas do aquivo: {quantidadeLinhas}");
//     foreach (string linha in linhasArquivo)
//     {
//         System.Console.WriteLine(linha);
//     }
// }
// else
// {
//     System.Console.WriteLine("Não foi possivel ler o arquivo");
// }







// (int, string, string) tupla = (1, "Felipe", "Felix");
// ValueTuple<int, string, string> tupla2 = (2, "Henrique", "Felix");

// System.Console.WriteLine(tupla);
// System.Console.WriteLine(tupla2);





// ----------------------------

// COLECOES

//DICTIONARY

// Dictionary<string, string> estados = new Dictionary<string, string>();

// estados.Add("SP", "Sao Paulo");
// estados.Add("BA", "Bahia");
// estados.Add("MG", "Minas Gerais");

// foreach (var item in estados)
// {
//     System.Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// System.Console.WriteLine("-----------------------");

// estados.Remove("BA");
// estados["SP"] = "SP agora é Santo André";

// foreach (var item in estados)
// {
//     System.Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// string chave = "SP";
// System.Console.WriteLine($"Verificando o elemento: {chave}");

// if (estados.ContainsKey(chave))
// {
//     System.Console.WriteLine($"Valor existente: {chave}");
// }
// else
// {
//     System.Console.WriteLine($"Valor nao existe. É possivel add a chave: {chave}");
// }



//PILHA - STACK

// Stack<int> pilha = new Stack<int>();

// pilha.Push(10);
// pilha.Push(20);
// pilha.Push(30);
// pilha.Push(40);

// foreach (int item in pilha)
// {
//     System.Console.WriteLine(item);
// }

// System.Console.WriteLine($"Removendo o elemento do topo da pilha {pilha.Pop()}");

// foreach (int item in pilha)
// {
//     System.Console.WriteLine(item);
// }




//FILA - QUEUE

// Queue<int> fila = new Queue<int>();

// fila.Enqueue(1);
// fila.Enqueue(2);
// fila.Enqueue(3);

// foreach (int item in fila)
// {
//     System.Console.WriteLine(item);
// }

// System.Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");

// foreach (int item in fila)
// {
//     System.Console.WriteLine(item);
// }





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
