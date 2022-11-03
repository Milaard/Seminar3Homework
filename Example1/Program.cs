// Напишите программу, которая принимает на вход пятизначноечисло и проверяет, является ли оно палиндромом

System.Console.WriteLine("ВВедите пятизначное число");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = 0;
int num2 = 0;
int num4 = 0;
int num5 = 0;

if (num > 9999 && num < 100000)

{
    num1 = num %10;
    num2 = (num /10) % 10;
    num4 = (num /1000) % 10;
    num5 = (num /10000) % 10;

    if ( num1 == num5 && num2 == num4 )
    {
        Console.WriteLine("Палиндром");
    }
    else 
    
        Console.WriteLine("Не палиндром");
}
else
{
    Console.WriteLine("Введено некорректное число");
}
