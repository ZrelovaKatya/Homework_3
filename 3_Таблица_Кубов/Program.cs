/* Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27.
5 -> 1, 8, 27, 64, 125*/

int number = Input ("Введите число N: ");
int Input (string output)
{
    Console.Write (output);
    return Convert.ToInt32 (Console.ReadLine());
}
int num = 1;

while (num <= number)
{
    int result = Cube (num);
    Console.Write($"{result}, ");
    num++;
}

int Cube (int a)
{
    return a*a*a;
}