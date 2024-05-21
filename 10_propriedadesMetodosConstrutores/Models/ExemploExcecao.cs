using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _10_propriedadesMetodosConstrutores.Models
{
    public class ExemploExcecao
    {
        public void Metodo1()
        {
            try 
            {
                Metodo2();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Olha o bug: " + ex.Message);
                Console.WriteLine("Olha o caminho do erro: " + ex.StackTrace);
            } 
            
        }
        public void Metodo2()
        {
            Metodo3();
        }
        public void Metodo3()
        {
            Metodo4();  
        }
        public void Metodo4()
        {
            throw new Exception("Ocorreu um exceção");
        }
    }
}