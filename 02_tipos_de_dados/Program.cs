//  Tipos de dados
//.O Tipo DateTime

DateTime dataAtual = DateTime.Now;
Console.WriteLine("A Data atual é: " + dataAtual);

DateTime data02 = DateTime.Now.AddDays(5);
Console.WriteLine("A Data de hoje mais 5 dias é: " + data02);

Console.WriteLine("A Data formatada em dd/MM/yyyy: " + data02.ToString("dd/MM/yyyy"));

Console.WriteLine("A Data formatada em dd/MM/yyyy HH:mm: " + data02.ToString("dd/MM/yyyy HH:mm"));
/*
//  Tipos de dados
//. Introdução e tipos inteiros
//.Número com casas decimais
//.declando os tipos de variáveis

string apresentacao = "Olá, seja bem vindo";

int     quantidade = 1;
double  altura = 1.70;
decimal preco = 1.80M;
bool    condicao = true;


quantidade = 10;

Console.WriteLine(apresentacao);
Console.WriteLine("Valor da variável quantidade: " + quantidade);
Console.WriteLine("Valor da variável altura: " + altura);
Console.WriteLine("Valor da variável altura com mais casas decimais: " + altura.ToString("0.00"));
Console.WriteLine("Valor da variável preco: " + preco);
Console.WriteLine("Valor da variável condicao: " + condicao);
*/

/*
//  Tipos de dados
//.Manipulando variaveis
int     quantidade = 1;
Console.WriteLine("Valor da variável quantidade: " + quantidade);

quantidade = 10;
Console.WriteLine("Valor da variável quantidade: " + quantidade);
*/