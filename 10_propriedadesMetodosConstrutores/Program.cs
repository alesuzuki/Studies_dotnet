using System.Globalization;
using _10_propriedadesMetodosConstrutores.Models;

Dictionary<string, string> estados = new Dictionary<string, string>();  

estados.Add("SP", "São Paulo");
estados.Add("BA", "Bahia");
estados.Add("MG", "Minas Gerais");

foreach (var item in estados) 
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

estados.Remove("SP");
estados.Add("GO", "Goiânia");

estados ["MG"] = "Minas - terra do pdq (pão de queijo)";


Console.WriteLine("++++++++++++++++++++++++++++");

foreach (var item in estados) 
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

string chave = "RJ";

if (estados.ContainsKey(chave))
{
    Console.WriteLine("Ja tem!");
}
else   
{
    Console.WriteLine("não tem na lista, vamos adicionar!");
    estados.Add("RJ", "Hell de Janeiro");

}






/*
Stack<int> pilha = new Stack<int>();

pilha.Push(2);
pilha.Push(4);
pilha.Push(6);
pilha.Push(8);

foreach (int i in pilha) 
{
    Console.WriteLine(i);
}

Console.WriteLine($"Removendo o elemento: {pilha.Pop()}");
pilha.Push(666);

foreach (int i in pilha) 
{
    Console.WriteLine(i);
}

*/



/*

Queue<int> fila = new Queue<int>();

fila.Enqueue(2);
fila.Enqueue(4);
fila.Enqueue(6);
fila.Enqueue(8);

foreach (int i in fila) 
{
    Console.WriteLine(i);
}

Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");
fila.Enqueue(10);

foreach (int i in fila) 
{
    Console.WriteLine(i);
}
*/


/*
new ExemploExcecao().Metodo1();
*/


/*
try
{
    string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

    foreach(string linha in linhas)
    {
        Console.WriteLine(linha);
    }
}

catch (FileNotFoundException ex)    
{
    Console.WriteLine($"Não achamos o arquivo, confere ai bro: {ex.Message}");
}

catch (DirectoryNotFoundException ex)    
{
    Console.WriteLine($"Esse caminho ta confuso, dá uma bizoiada: {ex.Message}");
}

catch (Exception ex)    
{
    Console.WriteLine($"Ocorreu uma excecao Generica {ex.Message}");
}

finally
{
    Console.WriteLine("That's all folks!");
}
*/




/*
//formatando datas
string dataString = "2022-13-17 18:00";

bool sucesso = DateTime.TryParseExact( dataString,
                        "yyyy-MM-dd HH:mm",
                        CultureInfo.InvariantCulture,
                        DateTimeStyles.None,
                        out DateTime data);

if (sucesso)
{
    Console.WriteLine($"Conversao com sucesso data: {data}");
}
else
{
    Console.WriteLine($"{dataString} não é uma data válida");
}

//Console.WriteLine(data);
*/

/*
DateTime data = DateTime.Now;

Console.WriteLine(data);
Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));
Console.WriteLine(data.ToShortDateString());
Console.WriteLine(data.ToShortTimeString());
*/

/*
//Utilizando o regional settings para o sistema
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

//alterando a moeda apenas na formatacao da exibição do valor
decimal valorMonetario = 1582.40M;
Console.WriteLine(valorMonetario.ToString("C8"));

//porcentagem
double porcentagem = .24132;
Console.WriteLine(porcentagem.ToString("P"));

//formatos personalizados

int sbrubles = 666999;
Console.WriteLine(sbrubles.ToString("###-###"));
*/


/*
//Utilizando o regional settings para o sistema
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

//alterando a moeda apenas na formatacao da exibição do valor
decimal valorMonetario = 1582.40M;
Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
*/


/*
//Utilizando o regional settings para o sistema
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

//valores monetários
decimal valorMonetario = 1582.40M;
Console.WriteLine($"{valorMonetario:C}");

*/

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