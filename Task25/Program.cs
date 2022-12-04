// Напишите цикл, который принимает на вход два числа (А и В) и возводит число А в натуральную степень В
Console.WriteLine("введите число А");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число B");
int b = Convert.ToInt32(Console.ReadLine());

int degree(int num1, int num2)
{
    int count = 1;
    for (int i = 1; i <= num2; i++)
    {
        count = count * num1;
    }
    return count;
}
int result = degree(a, b);
Console.WriteLine($"{a} в степени {b} = {result}");