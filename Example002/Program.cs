﻿Console.WriteLine("Введите число1: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число3: ");
int number3 = Convert.ToInt32(Console.ReadLine());


int max = number1;

if (number2>max) max = number2;

 
if (number3>max) max = number3;  
    
Console.Write(max);   