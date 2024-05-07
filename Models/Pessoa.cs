using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace estrutura.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }


        public void Apresentar()
        {
            //Posso fazer desta forma, 
            Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} anos");

            //ou também  pulando linha concatenando o comando:0
            Console.WriteLine($"Apresentação 02: Olá, meu nome é" +
            $" {Nome}, e tenho {Idade} anos");
        }    

     }

}