/* Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
23432 -> да
12821 -> да*/

int number = Input ("Введите пятизначное число: ");
int Input (string output)
{
    Console.Write (output);
    return Convert.ToInt32 (Console.ReadLine());
}

int Digit1 = number / 10000;
int Digit2 = (number % 10000)/1000;
int Digit4 = (number % 100)/10;
int Digit5 = number % 10;

while (number > 9999 && number < 100000)
{
    if (Digit1 == Digit5 && Digit2 == Digit4)
    {
        Console.WriteLine ("Да");
        break;
    }
    else
    {
        Console.WriteLine ("Нет");
        break;
    }
}