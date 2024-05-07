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
            //Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} anos");

            //ou também  pulando linha concatenando o comando:
            //desta forma o código fica mais organizado
            /*
            Console.WriteLine($"Apresentação 02: Olá, meu nome é" +
            $" {Nome}, e tenho {Idade} anos");
            */

            //também posso quebrar uma linha no resultado do comando que está executando
            //usando o \n como quebra de linha
            Console.WriteLine($"Olá, meu nome é {Nome}, \n e tenho {Idade} anos");

        }    

     }

}