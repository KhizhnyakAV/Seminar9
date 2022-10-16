// See https://aka.ms/new-console-template for more information
Console.WriteLine("Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа M и N");
System.Console.Write("Введите число M: ");
string input = Console.ReadLine();
int M = int.Parse(input);
System.Console.Write("Введите число N: ");
input = Console.ReadLine();
int N = int.Parse(input);

System.Console.Write("Значение функции Аккермана: ");
int A(int n, int m)
{
    if (n == 0) return (m + 1);
    if ((n > 0) & (m == 0)) return (A(n - 1, 1));
    return A(n - 1, A(n, m - 1));
}

int res = A(M,N);
System.Console.Write(res);