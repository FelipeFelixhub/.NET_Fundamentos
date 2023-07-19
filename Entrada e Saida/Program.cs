//ENTRADA E SAIDA DE DADOS

//FORMATACAO

// double x = 2.5656;
// decimal y = 30000m;

// System.Console.WriteLine(x.ToString("F6"));
// System.Console.WriteLine(y.ToString("C2"));

//ENTRADA DE DADOS

// string a = Console.ReadLine();
// System.Console.WriteLine(a);

// int b = int.Parse(Console.ReadLine());
// System.Console.WriteLine(b);

// double c = double.Parse(Console.ReadLine());
// System.Console.WriteLine(c);

// char d = char.Parse(Console.ReadLine());
// System.Console.WriteLine(d);

//EXEMPLO

double salario;
string nome;
int idade;
char sexo;

System.Console.WriteLine("Digite o nome da pessoa: ");
nome = Console.ReadLine();

System.Console.WriteLine("Digite o salario");
salario = double.Parse(Console.ReadLine());

System.Console.WriteLine("Digite a idade da pessoa: ");
idade = int.Parse(Console.ReadLine());

System.Console.WriteLine("Digite o sexo da pessoa (M/F): ");
sexo = char.Parse(Console.ReadLine());

System.Console.WriteLine($"A pessoa se chama {nome}, é do sexo {sexo}, recebe {salario.ToString("C2")} por mês e tem {idade} anos ");


