using _10_propriedadesMetodosConstrutores.Models;

Pessoa p1 = new Pessoa();
p1.Nome = "Ale";
p1.Sobrenome = "Suzuki";

Pessoa p2 = new Pessoa();
p2.Nome = "Daniel";
p2.Sobrenome = "Dev";

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();

/*
Pessoa p1 = new Pessoa();

p1.Nome = "Ale";
p1.Sobrenome = "Suzuki";
p1.Idade = 35;

p1.Apresentar();
*/