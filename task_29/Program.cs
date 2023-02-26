﻿// Задача 29: Напишите программу, которая задаёт массив из 8 элементов
//  и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

int[] GetBinaryArray(int size)
{
    int[] array = new int[size]; 
   
    for (int i = 0; i < size; i++)
    {
        
        array[i] = new Random().Next(10000); 
        
    }
    return array;
}
int[] resultArray = GetBinaryArray(8);
Console.WriteLine($"Массив: [ {String.Join(", ", resultArray)} ]");