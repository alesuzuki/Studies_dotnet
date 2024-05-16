using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _10_propriedadesMetodosConstrutores.Models
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
            // Pode ser feito desta maneira tambem usando body expressions
            // get => _nome.ToUpper();

            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio!");
                }
                _nome = value;

            // Pode ser feito desta maneira tambem usando body expressions
            // porem não teria a validação do if
            // set => _nome = value;
            }

        }


        public int Idade { get; set; }
        
        public void Apresentar()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
        }
    }
}