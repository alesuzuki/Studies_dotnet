﻿// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

string apresentacao = "Olá, seja bem vindo";

int     quantidade = 1;
double  altura = 1.70;
decimal preco = 1.80M;
bool    condicao = true;

Console.WriteLine(apresentacao);
Console.WriteLine("Valor da variável quantidade: " + quantidade);
Console.WriteLine("Valor da variável altura: " + altura);
Console.WriteLine("Valor da variável altura com mais casas decimais: " + altura.ToString("0.00"));
Console.WriteLine("Valor da variável preco: " + preco);
Console.WriteLine("Valor da variável condicao: " + condicao);