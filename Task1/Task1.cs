﻿//Напишите программу, которая на вход принимает
//число и выдает его квадрат (число умноженное
//на само себя).
//Например:
//● 4 -> 16
//● -3 -> 9
//● -7 -> 49 



Console.Clear();

int num = new Random().Next(10, 100); //10 - 99

//12 / 10 = 12; 12 % 10 = 3

int a1 = num / 10;
int a2 = num % 10;

int max = a1;

if (a2 > max)
{
    max = a2;
}

Console.WriteLine($"Максимальная цифра {num} равна {max}");