﻿// Estudando os tipos de operadores
// Operador de Atribuição
// Operador de Condicionais -- a partir daqui tem que fazer os exercicios e subir no github
// a partir de "operadores condicionais" do modulo 2 









/*
// Estudando os tipos de operadores
// Operador de Atribuição

// sinal de = 
// Para modificar o valor da variavel
int a = 10;
int b = 20;

int c = a + b;


Console.WriteLine(c);
*/


/*
// Estudando os tipos de operadores
// Operador de Atribuição
// Operador de Condicionais
// Operador de Lógicos

// Combinando operadores

int a = 10;
int b = 20;

int c = a + b;

//Ao invés de fazer desta forma, 
//podemos acrescer e atribuir ao mesmo tempo
//utilizando os sinais +=
c = c + 5;

//fazendo desta maneira
//uma maneira mais concisa
//escrevo menos codigo e represneto a mesma coisa
//da para usar subtracao -, soma +, divisao /, multiplicacao *
c += 5;

Console.WriteLine(c);

*/

/*
// Estudando os tipos de operadores
// Operador de Atribuição
// Operador de Condicionais
// Operador de Lógicos

// Convertendo tipos de variáveis
//cast ou casting

//convert é a classe, toint32 é um metodo, que recebe a variavel

int a = Convert.ToInt32("5");
Console.WriteLine(a);


int b = int.Parse("10");
Console.WriteLine(b);

//o que acontece se eu passar algo que nao é convertivel para numero? 
//R: Da erro // exceçao

// int c = int.Parse("10c");
// Console.WriteLine(c);

// Unhandled exception. System.FormatException: The input string '10c' was not in a correct format.
//    at System.Number.ThrowFormatException[TChar](ReadOnlySpan`1 value)
//    at System.Int32.Parse(String s)

*/



/*
// Operador de Atribuição
// Conversão para string
int inteiro = 5;
string a = inteiro.ToString();

Console.WriteLine(a);
*/

/*
// Operador de Atribuição
// Cast implicito
// conversao de diferentes tipos que nao precisa usar a conversao em si
// pois a ide faz automaticamente

int a = 5;
double b = a;
Console.WriteLine(b);

long c = a;
Console.WriteLine(c);

int d = int.MaxValue;
long e = d;
Console.WriteLine(e);
*/


/*
// Ordem dos operadores
// obedece a ordem das operacoes matematicas
// 1 - parenteses 2 - expoentes 3 - divisao e multiplicacao 4 adicao e subtracao
double a = 10 / 2 + 2;
Console.WriteLine(a);


*/
