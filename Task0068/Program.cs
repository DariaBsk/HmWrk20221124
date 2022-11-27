﻿// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29

uint AckermanFunction(uint n, uint m)
{
  if (n == 0)
    return m + 1;
  else if ((n != 0) && (m == 0))
    return AckermanFunction(n - 1, 1);
  else
    return AckermanFunction(n - 1, AckermanFunction(n, m - 1));
}

Console.Write("Введите челое положительное число M: ");
uint m = Convert.ToUInt32(Console.ReadLine());

Console.Write("Введите челое положительное число N: ");
uint n = Convert.ToUInt32(Console.ReadLine());

uint result = AckermanFunction(m, n);
Console.Write($"{result} ");