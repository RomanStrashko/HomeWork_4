// Задача 1. Написать цикл, который принимает на вход два числа (А и В) и возводит число А в натуральную степень В

//Способ 1

/*Console.Write("Введите число A: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int num2 = Convert.ToInt32(Console.ReadLine());

double result = Math.Pow(num1,num2);
Console.WriteLine($"Число A в натуральной степени B равно {result}");*/

//Способ 2

/*Console.Write("Введите число A: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Число A в натуральной степени B равно {Exponentiation(num1,num2)}");

int Exponentiation(int x,int y)
{
    int result = 1;
    for(int i = 1; i <= y; i++)
    {
    result = result * x;
    }
return result;
}*/


// Задача 2. Наисать программу, которая принимает на вход число и выдает сумму цифр в числе.

/*Console.Write("Введите число A: ");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма цифр в числе равна {GetSum(num)}");

int GetSum(int limit)
{
   int sum = 0;
   while(num > 0)
   {
    int number = num % 10;
    num = num / 10;
    sum = sum + number;
   }
   return sum;
}*/


// Задача 3. Написать программу, которая задает массив из 8 рандомных элементов и выводит их на экран

/*int[] array = GetArray(8);
Console.WriteLine($"[{String.Join(",", array)}]");


int[] GetArray(int size)
{
    int[] result = new int [size];
    for(int i = 0; i < size; i++)
    {
        result [i] = new Random().Next(0,10);
    }
return result;
}*/
