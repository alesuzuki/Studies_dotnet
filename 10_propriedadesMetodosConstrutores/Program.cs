using System.Globalization;
using _10_propriedadesMetodosConstrutores.Models;






























/*
int numero = 15;
bool ehpar = false;

//if ternario
ehpar = numero % 2 == 0;


Console.WriteLine($"O numero {numero} eh " + (ehpar ? "par" : "impar"));

*/


/*
Pessoa p1 = new Pessoa("ale","Suzuki");

(string nome, string sobrenome) = p1;

Console.WriteLine($"{nome} {sobrenome}");

*/


/*
//metodo usando tupla para retorno
LeituraArquivo arquivo = new LeituraArquivo();

var (sucesso, linhasArquivos, quantidadeLinhas) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

//posso descartar a informacao retornada pelo metodo caso nao va consumila
//var (sucesso, linhasArquivos, _) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");


if (sucesso)
{
    Console.WriteLine("Quantidade de linhas do arquivo: " + quantidadeLinhas);

    foreach(string linha in linhasArquivos)
    {
        Console.WriteLine("linha");
    }
}
else
{
    Console.WriteLine("Nao foi possivel ler o arquivo");
}


*/


/*
(int, string, string, decimal) tupla = (1, "Waltenne", "Carvalho", 1.87M);

Console.WriteLine($"Id: {tupla.Item1}");
Console.WriteLine($"Nome: {tupla.Item2}");
Console.WriteLine($"Sobrenome: {tupla.Item3}");
Console.WriteLine($"Altura: {tupla.Item4}");

Console.WriteLine("============================");


ValueTuple<int, string, string, decimal> tupla2 = (1, "hfs", "killmster", 1.50M);

Console.WriteLine($"Id: {tupla2.Item1}");
Console.WriteLine($"Nome: {tupla2.Item2}");
Console.WriteLine($"Sobrenome: {tupla2.Item3}");
Console.WriteLine($"Altura: {tupla2.Item4}");


Console.WriteLine("============================");

var tupla3 = Tuple.Create(1, "Heiz", "men", 1.75M);

Console.WriteLine($"Id: {tupla3.Item1}");
Console.WriteLine($"Nome: {tupla3.Item2}");
Console.WriteLine($"Sobrenome: {tupla3.Item3}");
Console.WriteLine($"Altura: {tupla3.Item4}");
*/


/*

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

*/


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