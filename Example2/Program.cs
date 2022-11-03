
    
        //Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве
        System.Console.WriteLine("Введите координаты точек А и Б");
        double numX1 = double.Parse(Console.ReadLine());
        double numY1 = double.Parse(Console.ReadLine());
        double numZ1 = double.Parse(Console.ReadLine());

        double numX2 = double.Parse(Console.ReadLine());
        double numY2 = double.Parse(Console.ReadLine());
        double numZ2 = double.Parse(Console.ReadLine());

        double distantion = Math.Sqrt(Math.Pow((numX2 - numX1), 2) + Math.Pow((numY2 - numY1), 2) + Math.Pow((numZ2 - numZ1), 2));

        Console.WriteLine($" Расстояние между точками равно {distantion}");

