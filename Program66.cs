// See https://aka.ms/new-console-template for more information
Console.WriteLine("Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N");
System.Console.Write("Введите число M: ");
string input = Console.ReadLine();
int M = int.Parse(input);
System.Console.Write("Введите число N: ");
input = Console.ReadLine();
int N = int.Parse(input);



System.Console.WriteLine("Сумма чисел в диапозоне от M до N: ");

int summ = 0;

int nature (int n, int m, int samm)
{
    if (n == m-1) return samm;
    {
        samm= samm+n; 
    }
    return nature(n-1,m,samm);  
}

summ = nature(N,M,summ);
System.Console.WriteLine(summ);