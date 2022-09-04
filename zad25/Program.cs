//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

int Degree(int A,int B)
{
    for (int i = 1; i < B; i++)
    {
        A*=B;
    }
    return A;
}

Console.WriteLine ("Введите основание степени: ");
int basis = int.Parse(Console.ReadLine());

Console.WriteLine ("Введите показатель степени: ");
int indicator = int.Parse(Console.ReadLine());

    
Console.WriteLine(Degree(basis,indicator));
