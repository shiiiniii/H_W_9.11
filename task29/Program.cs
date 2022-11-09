// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

Console.Clear();
Console.WriteLine("Программа, которая задаёт массив из 8 элементов и выводит их на экран. Напишите Старт, чтобы начать: ");
string start = Console.ReadLine();


int[] NameArray(int size)
{
    int[] array = new int[8]; 
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(1, 100);
    }
    return array;
}

void PrintArray(int[] array)
{   
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " " + " ");
    }
    Console.Write("]");
}

int[] nameArray = NameArray(8);
PrintArray(nameArray);