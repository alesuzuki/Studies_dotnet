using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace _10_propriedadesMetodosConstrutores.Models
{
    public class VendaDes
    {
        
        public int Id { get; set; }

        //propriedade para quando no json a tag possuir outro nome, mas que no meu sistema possui uma nomenclatura diferente
        //[JsonProperty("Nome_Produto")]
        public string Produto { get; set; } 
        public decimal Preco { get; set; }
        public DateTime DataVenda { get; set; }
    }
}