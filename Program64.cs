// See https://aka.ms/new-console-template for more information
Console.WriteLine("Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии");
System.Console.Write("Введите число N: ");
string input = Console.ReadLine();
int N = int.Parse(input);

System.Console.WriteLine("Натуральные числа в диапозоне от 1 до N: ");
int nature (int n)
{
    if (n == 0) return 1;
    System.Console.WriteLine(n);
    return nature(n-1);
}

nature(N);