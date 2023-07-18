using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class ContaCorrente
    {
          public ContaCorrente(int numeroConta, decimal saldo)
        {
            NumeroConta = numeroConta;
            Saldo = saldo;
        }
      
        public int NumeroConta { get; set; }
        private decimal Saldo;

        public void Sacar (decimal valor)
        {
            if (Saldo >= valor)
            {
                Saldo -= valor;    
                System.Console.WriteLine("Saque realizado com sucesso!");
            }
            else
            {
                System.Console.WriteLine("Valor desejado maior que saldo disponivel");
            }
        }

        public void ExibirSaldo()
        {
            System.Console.WriteLine($"Seu saldo disponivel é: {Saldo}");
        }

    }
}