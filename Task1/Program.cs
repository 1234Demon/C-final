// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

using static System.Console;
Clear();

int PrintNumber(string message)
{
    WriteLine(message);
    return Convert.ToInt32(ReadLine());
}

string PrintInvers(int n)
{
    if(n == 1) return n.ToString();
    return (n + ", " + PrintInvers(n-1));
}



int n = PrintNumber("Enter N ");

WriteLine(PrintInvers(n));