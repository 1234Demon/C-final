// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

using static System.Console;
Clear();

int PrintNum(string message)
{
    WriteLine(message);
    return Convert.ToInt32(ReadLine());
}

static int A(int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return A(n - 1, 1);
    else
      return A(n - 1, A(n, m - 1));
}

int m = PrintNum("Enter M ");
int n = PrintNum("Enter N ");


WriteLine(A(m, n ));