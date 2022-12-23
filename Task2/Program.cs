// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

using static System.Console;
Clear();

int PrintNum(string message)
{
    WriteLine(message);
    return Convert.ToInt32(ReadLine());
}

string PrintNumber(int start, int end)
{
    if(start == end) return start.ToString();
    return (start + " " + PrintNumber(start + 1, end));
}

int SumNumber(int start, int end)
{
    if(start == end) return start;
    return end + SumNumber(start, end - 1);
}


int m = PrintNum("Enter M ");
int n = PrintNum("Enter N ");

Console.WriteLine($"Summ = {SumNumber(m,n)}");
