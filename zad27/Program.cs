// Задача 27: Напишите программу, которая принимает на вход число 
//и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

void Sumnumber( int number)
{
    int newNumber = 0;
    while (number > 0)
    {
        int figure = number %10; 
        newNumber += figure;
        number/=10;
    }
    Console.WriteLine($"Сумма цифр введенного числа = {newNumber}");
}

Console.WriteLine ("Введите число: ");
int number = int.Parse(Console.ReadLine());
Sumnumber(number);