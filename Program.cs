//Console.WriteLine("Hello, World!");

//Posso tambem fazer desta outra forma para referenciar o namespace
//negativas de usar desta forma: O código fica extenso
///estrutura.Models.Pessoa p = new estrutura.Models.Pessoa();


// Posso fazer desta forma
using estrutura.Models;

///instanciamos uma pessoa na variavel p
//passa a existir e eu posso manipular essa instancia na variavel p
Pessoa p = new Pessoa();

//Aqui eu passo dados para pessoa e atribuo valores aos atributos Nome e idade
p.Nome = "Alessandra Pasquale";
p.Idade = 35;

//Aqui chamo o método de apresentar e executa a apresentação 
//quando dou o comando "dotnet run" no terminal
p.Apresentar();





