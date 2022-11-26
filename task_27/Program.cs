// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.

Console.Write("Введите число А: ");
int A = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while (A > 0)
{
    int B = A%10;
    A = A/10;
    sum = sum + B;
}
Console.WriteLine("Сумма цифр "+ sum);