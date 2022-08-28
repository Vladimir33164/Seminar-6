//Задача 40: Напишите программу, которая принимает на вход три 
//числа и проверяет, может ли существовать треугольник с сторонами 
//такой длины.

int A = Convert.ToInt32(Console.ReadLine());

int B = Convert.ToInt32(Console.ReadLine());

int C = Convert.ToInt32(Console.ReadLine());

if(A + B > C & A + C > B & B + C > A)
{
    Console.WriteLine($"Треугольник со сторонами: {A}, {B}, {C} существует");
}
else Console.WriteLine($"Треугольник со сторонами: {A}, {B}, {C} НЕ существует");
