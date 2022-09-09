// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125



Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int count = 1;

if(number <= 0)
{
    Console.WriteLine("Число введено неверно");
    return; 
}

while(count <= number)
{
    // Хотел сначала вывести резульат так:
//   Console.WriteLine($"Кубический корень от числа {count}: "); 
//  Console.Write(Math.Pow(count, 3));   Но потом решил вывести, как в условии задачи.
  Console.Write(Math.Pow(count, 3));  
  count = count +1;
  Console.Write(" ");
}