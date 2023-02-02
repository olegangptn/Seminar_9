//     Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Akkermana (int n, int m)
{
  if (n == 0)
    return m + 1;
  else
  
    if ((n != 0) && (m == 0))
      return Akkermana(n - 1, 1);
    else
      return Akkermana (n - 1, Akkermana (n, m - 1));
}

Console.WriteLine ("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

int a = Akkermana(m ,n);
Console.WriteLine (a);
