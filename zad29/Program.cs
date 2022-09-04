//Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
//и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]
void Processing (int Number){
    
    void FillArray(int [] Mass)
    {
        int length = Mass.Length;
        int index = 0;
        while (index < length)

            {
                Mass[index] = new Random().Next(1, 100);

                 index++;
            }
    }
    void PrintArray (int[] arr)
    {
        int cnt = 0;
        int length = arr.Length;
        while (cnt < length)
            {
                Console.Write ($"{arr[cnt]}, ");
                cnt = cnt +1;
            }
    }
    int[] array = new int[Number];
    FillArray (array);
    PrintArray (array);


}
Console.WriteLine ("Введите число элементов массива: ");
int Number = int.Parse(Console.ReadLine());
Processing (Number);