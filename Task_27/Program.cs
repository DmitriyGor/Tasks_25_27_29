/*
Задача 27: 
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
Console.Write("Enter the number : "); // Введите число 
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0; // Сумма цифр в числе
if (number < 0)
{
    number *= -1;
}   
    while (number > 0)   
    {
        sum = sum + number % 10;
        number /= 10;
    }
    Console.Write ($"the SUM of digits is:  {sum}");
    
    // сумму цифр в числе  равна:
