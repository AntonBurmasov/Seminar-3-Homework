﻿// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

// Работает как для положительных, так и для отрицательных чисел.

Console.WriteLine("Введите пятизначное число:");
int number = Convert.ToInt32(Console.ReadLine());

if(100000 < number & number < -9999 | number > 9999 & number < 100000)
{
  if(number / 10000 == number % 10)
  {
    if(number / 1000 % 10 == number % 100 / 10)
    {
    Console.WriteLine("Да.");
    }
    else
    {
      Console.WriteLine("Нет.");  
    }
  }
  else
  {
    Console.WriteLine("Нет.");
  }
}
else
{
    Console.WriteLine("Вы ввели не пятизначное число");
}