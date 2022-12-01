// Напишите программу, которая принимает на вход число и выдает кол-во цифр в числе
// 456 -> 3
Console.WriteLine("введите число и программа посчитает кол-во цифр в нем");

int number = Convert.ToInt32(Console.ReadLine());

int count(int num)
{
    int count = 0;
    while (num > 0)
    {
        count++;
        num = num / 10;
    }
    return count;
}
int result = count(number);
Console.WriteLine($"{result}");

