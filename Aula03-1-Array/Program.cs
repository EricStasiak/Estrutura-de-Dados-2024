﻿//Array unidimensional
int[] numbers;

numbers = new int[5];

//Atribuição de valor direta ao indice do vetor
numbers[0] = 1;
numbers[1] = 2;
numbers[2] = 3;
numbers[3] = 4;
numbers[4] = 5;

//Declaração inicializada
string[] names =
{"Eu", "Tu", "Ele", "Nós", "Vós", "Eles"};

//Exemplo vetor com os nomes dos meses
string[] months = new string[12];
for(int i = 1; i <= 12; i++)
{
    DateTime firstDay = new DateTime(DateTime.Now.Year, i, 1);
    string name = firstDay.ToString("MMMM");
    months[i-1] = name;
}

foreach(string m in months)
{
    Console.WriteLine(m);
}