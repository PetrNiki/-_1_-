﻿// Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Введите число");
if (int.Parse(Console.ReadLine()) % 2 == 0)
    Console.WriteLine("Это чётное число");
else Console.WriteLine("Это нечётное число");