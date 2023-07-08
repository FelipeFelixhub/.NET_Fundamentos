using Models;


//DO WHILE

int soma = 0, numero = 0;

do
{
    System.Console.WriteLine("Digite um numero (0 para parar)");
    numero = Convert.ToInt32(Console.ReadLine());

    soma += numero;
    
} while (numero != 0);

System.Console.WriteLine($"Total da soma dos numeros digitados é: {soma}");







//WHILE
// int numero = 5;
// int contador = 0;


// while (contador <= 10)
// {
//     System.Console.WriteLine($"{numero} x {contador} = {numero * contador}");
//     contador++;

//     if (contador > 5)
//     {
//         break;
//     }
// }













// int inteiro = 10;
// string a = inteiro.ToString();

// System.Console.WriteLine(a);

// long c = long.MaxValue;
// System.Console.WriteLine(c);

//int a = int.Parse("5");

//System.Console.WriteLine(a);


//DateTime dataAtual = DateTime.Now.AddDays(5);
//System.Console.WriteLine(dataAtual.ToString("dd/MM/yyy HH:mm"));


// string apresentacao = "Olá, seja bem vindo";
// int quantidade = 1;
// double altura = 1.80;
// float largura  = 1.80f;
// decimal preco = 1.90M;
// bool condicao = true;



// System.Console.WriteLine(apresentacao);
// System.Console.WriteLine("Valor da variavel: " + quantidade);
// System.Console.WriteLine("Valor da variavel: " + altura.ToString("0.00")); //2 casas decimais
// System.Console.WriteLine("Valor da variavel: " + preco);
// System.Console.WriteLine("Valor da variavel: " + condicao);
// System.Console.WriteLine("Valor da variavel: " + largura);


// Pessoa pessoa1 = new Pessoa();

//pessoa1.Nome = "Felipe";
//pessoa1.Idade = 31;
//pessoa1.Apresentar();


// Try Parse

// string a = "15-";

// int b = 0;

// int.TryParse(a, out b);

// System.Console.WriteLine(b);
// System.Console.WriteLine("Conversao realizada com sucesso!");


// Operador Condicional

// int quantidadeEmEstoque = 3;
// int quantidadeCompra = 0;
// bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

// System.Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// System.Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
// System.Console.WriteLine($"É possivel realizar a venda?: {possivelVenda}");

// if (quantidadeCompra == 0)
// {
//     System.Console.WriteLine("Venda invalida");
// }

// else if (possivelVenda)
// {
//     System.Console.WriteLine("Venda realizda");
// }
// else
// {
//     System.Console.WriteLine("Quantidade fora de estoque");
// }


// string nome = "Felipe";
// string sobreNome = "Felix";
// int idade = 31;
// string age = idade.ToString();

// System.Console.WriteLine($"Meu nome completo é {nome} {sobreNome} e eu tenho {age} anos ");

// Switch case

// System.Console.WriteLine("Digite uma letra");
// string letra = Console.ReadLine();


// switch (letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         System.Console.WriteLine("Vogal");
//         break;

//     default:
//     System.Console.WriteLine("Nao é uma vogal");
//     break;
// }


//System.Console.WriteLine($"A letra informada foi: {letra}");

// if (letra == "a" ||
//     letra == "e" ||
//     letra == "i" ||
//     letra == "o" ||
//     letra == "u" )
// {
//     System.Console.WriteLine("Vogal");
// }
// else
// {
//     System.Console.WriteLine("Nao é uma vogal");
// }