﻿/* Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

int x1 = Input ("Введите координаты точки x1: ");
int y1 = Input ("Введите координаты точки y1: ");
int z1 = Input ("Введите координаты точки z1: ");
int x2 = Input ("Введите координаты точки x2: ");
int y2 = Input ("Введите координаты точки y2: ");
int z2 = Input ("Введите координаты точки z2: ");

int Input (string output)
{
    Console.Write (output);
    return Convert.ToInt32 (Console.ReadLine());
}

double result = Math.Sqrt ((x2 - x1)*(x2 - x1) + (y2 - y1)*(y2 - y1) + (z2 - z1)*(z2 - z1));
Console.WriteLine (result);
