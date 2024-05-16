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
            foreach (Pessoa aluno in Alunos)
            {
                Console.WriteLine(aluno.NomeCompleto);
            }
        }
    }
}