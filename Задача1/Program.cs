// Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает последнюю цифру этого числа.

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int num = number % 10;
Console.WriteLine("Единицы: " + num);