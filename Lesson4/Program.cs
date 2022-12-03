// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке
// [1,0,1,1,0,1,0,0]
Console.WriteLine("введите размер массива");

int Length = Convert.ToInt32(Console.ReadLine());

int[] RandomArray(int len)
{
    int[] arrrays = new int[len];
    int i = 0;
    while (i < arrrays.Length)
    {
        arrrays[i] = new Random().Next(0, 2);
        i++;
    }
    return arrrays;
}

int[] res = RandomArray(Length);

void PrintArray(int[] ress)
{
    for (int i = 0; i < ress.Length; i++)
    {
        Console.Write($"{ress[i]}");
    }
}

PrintArray(res);