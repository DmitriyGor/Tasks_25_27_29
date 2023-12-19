/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

Console.WriteLine("Введите размер массива: ");
int massive = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число N ");
Console.WriteLine("будет задан массив из случайных чисел от 0 до N");
int numberN = Convert.ToInt32(Console.ReadLine());
int[]array = new int[massive];
for (int i = 0; i < massive; i++)
{
    array[i] = new Random().Next(numberN+1);
    
}
Console.WriteLine($"Массив: [ {String.Join("; ",array)} ]");