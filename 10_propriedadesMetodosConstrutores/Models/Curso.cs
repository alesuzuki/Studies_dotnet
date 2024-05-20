using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _10_propriedadesMetodosConstrutores.Models
{
    public class Curso
    {
        public string Nome { get; set; }

        public List<Pessoa> Alunos {get; set;}

        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public int ObterQtdAlunosMatriculados()
    	{
            int qtd = Alunos.Count;
            return qtd;
        }

        public bool RemoverAluno(Pessoa aluno)
        {
            Alunos.Remove(aluno);
            return true;
        }

        public void ListarAlunos()
        {

            //Concatenação
            // foreach (Pessoa aluno in Alunos)
            // {
            //     Console.WriteLine(aluno.NomeCompleto);
            // }

            //Interpolação
            for(int i = 0; i < Alunos.Count ; i++ )
            {
                //string texto = "N° " + i + " - " + Alunos[i].NomeCompleto;
                string texto = $"N° {i+1} - {Alunos[i].NomeCompleto}";

                Console.WriteLine(texto); 
            }
        }
    }
}