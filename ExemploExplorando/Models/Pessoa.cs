using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Pessoa
    {
        private string _nome;
        public string Nome 
        {
             get
             {
                return _nome.ToUpper();
            }
             
             set
             {
                if (value == "")
                {
                    string mesage = "O nome nao pode ser vazio!!";
                    throw new ArgumentException(mesage.ToUpper());
                }

                _nome = value;
            }
        }


        private int _idade;
        public int Idade 
        { 
            get
            {
                return _idade;
            }
            
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Idade nao pode ser menor que 0!!");
                }

                _idade = value;
            }
        }

        public void Apresentar()
        {
            System.Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
        }
    }
}