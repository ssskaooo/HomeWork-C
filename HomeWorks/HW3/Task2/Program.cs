﻿using System;
// Внутри класса Answer напишите метод DistanceBetweenPoints, который принимает на вход
//  координаты двух точек pointA и pointB в виде массива целых чисел, и возвращает 
// расстояние между ними в 3D пространстве.
public class Answer
{
    private static double Length(int[] pointA, int[] pointB)
    {
        double x = pointB[0] - pointA[0];
        double y = pointB[1] - pointA[1];
        double z = pointB[2] - pointA[2];

    return Math.Sqrt(x * x + y * y + z * z);

    }

  // Не удаляйте и не меняйте метод Main! 
    public static void Main(string[] args) {
        int x1, x2, x3, y1, y2, y3;

        if (args.Length >= 6) {
            x1 = int.Parse(args[0]);
            x2 = int.Parse(args[1]);
            x3 = int.Parse(args[2]);
            y1 = int.Parse(args[3]);
            y2 = int.Parse(args[4]);
            y3 = int.Parse(args[5]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            // x1 = 3;
            // x2 = 6;
            // x3 = 8;
            // y1 = 2;
            // y2 = 1;
            // y3 = -7;

            x1 = 7;
            x2 = -5;
            x3 = 0;
            y1 = 1;
            y2 = -1;
            y3 = 9;
        }

        // Не удаляйте строки ниже
        double result = Length(new int[]{x1, x2, x3}, new int[]{y1, y2, y3});
        Console.WriteLine($"{result:F2}");
    }
}