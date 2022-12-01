// Напишите программу, которая принимает на вход число (А) и выдает сумму чисел от 1 до А
//N * (N + 1) / 2 (нашел формулу в интернете)
Console.WriteLine("введите целое положительное число");

int number = Convert.ToInt32(Console.ReadLine());

int summOfNumbers(int a)
{
    int sum = 0;
    for (int i = 1; i <= a; i++)
    {
        sum += i; // sum = sum + i
    }
    return sum;
}

if (number <= 0)
{
    Console.WriteLine($"По-моему это -> {number}, не положительное число");
}
else
{
    int result = summOfNumbers(number);
    Console.WriteLine($"Сумма чисел от 1 до {number} = {result}");
}
