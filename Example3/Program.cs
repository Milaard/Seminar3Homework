//Напишите программу, которая принимает на вход число (N) и выдает таблицу кубов чисел от 1 до N
System.Console.WriteLine("Введите число");
double num = double.Parse(Console.ReadLine());
for (int i = 1; i <= num; i++)
{
        Console.Write($"{i * i * i}, ");
}
Console.WriteLine();
