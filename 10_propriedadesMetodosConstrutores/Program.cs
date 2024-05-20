using System.Globalization;
using _10_propriedadesMetodosConstrutores.Models;


//Utilizando o regional settings para o sistema
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

//valores monetários
decimal valorMonetario = 1582.40M;
Console.WriteLine($"{valorMonetario:C}");


/*
Pessoa p1 = new Pessoa("Ale","Suzuki");
Pessoa p2 = new Pessoa("Mimers","Diasis");

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();
*/

/*
Pessoa p1 = new Pessoa();

p1.Nome = "Ale";
p1.Sobrenome = "Suzuki";
p1.Idade = 35;

p1.Apresentar();
*/


/*
Pessoa p1 = new Pessoa();
p1.Nome = "Ale";
p1.Sobrenome = "Suzuki";

Pessoa p2 = new Pessoa();
p2.Nome = "Daniel";
p2.Sobrenome = "Dev";
*/