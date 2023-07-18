using ExemploPOO.Models;
using ExemploPOO.Interfaces;

//INTERFACE

ICalculadora calc = new Calculadora();
System.Console.WriteLine(calc.Multiplicar(4, 5));
System.Console.WriteLine(calc.Dividir(20, 5));
System.Console.WriteLine(calc.Somar(2, 5));
System.Console.WriteLine(calc.Subtrair(30, 40));







//------------------------------

//ClASSE OBJECT

// Computador cp = new Computador();
// System.Console.WriteLine(cp.ToString());



//------------------

//CLASSE ABSTRATA

// Corrente c = new Corrente();

// c.Creditar(600);
// c.ExibirSaldo();



//-----------------------------

//HERANCA E POLIMORFISMO

// Aluno a1 = new Aluno();
// a1.Nome = "Felipe";
// a1.Idade = 31;
// a1.Nota = 10;
// a1.Apresentar();


// Professor p1 = new Professor();
// p1.Nome = "Humberto";
// p1.Idade = 45;
// p1.Salario = 15000;
// p1.Apresentar();

//-------------------------------------


// ContaCorrente c1 = new ContaCorrente(123, 1000);

// c1.ExibirSaldo();
// c1.Sacar(200);
// c1.ExibirSaldo();




// Pessoa p1 = new Pessoa();

// p1.Nome = "Felipe";
// p1.Idade = 31;

// p1.Apresentar();

