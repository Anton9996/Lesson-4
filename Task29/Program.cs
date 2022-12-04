// Напишите программу, которая задаёт массив из 8 элементов, заполненный псеводслучайными числами и выводит их на экран
Console.WriteLine("Алгорит создает масив из 8 элементов, заполеный псевдослучайными числами");

void FullArray(int[] collection)
{
    int Length = collection.Length;
    int index = 0;
    while (index < Length)
    {
        collection[index] = new Random().Next(0, 100);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    Console.Write($"[");
    while (position < count)
    {
        Console.Write($"{col[position]}  ");
        position++;
    }
    Console.Write($"]");
}

int[] array = new int[8];

FullArray(array);
PrintArray(array);