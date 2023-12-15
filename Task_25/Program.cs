/*
Задача 25: 
Напишите цикл, который принимает на вход два числа (А и В) 
и возводит число А в натуральную степень В.
3, 5  -> 243 // (3 ^ 5)
2, 4 -> 16   // (2 ^ 4)
*/
Console.Write("Enter a natural number A:  "); // Введите натуральное число А
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter a natural number B:  "); // Введите натуральное число B
int numberB = Convert.ToInt32(Console.ReadLine());

int result = 1;
for (int i = 1; i <= numberB; i++)
{
    result *= numberA;
}
Console.WriteLine ($"number {numberA} to natural power {numberB} is equal to: {result}"); 
// натуральное число А в натуральной степени В равно: