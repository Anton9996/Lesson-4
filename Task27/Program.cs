// Напишите программу, которая задает массив из 8 элемнтов, заполненый псевдослучайными числами и выводит их на экран
// 452 -> 11

Console.WriteLine("Напишите число и програма посчитает суммы цифр в этом числе");

int number = Convert.ToInt32(Console.ReadLine());

int countSumm(int num)
{
    int summ = 0;
    while (num > 0)
    {
        summ = summ + num % 10;
        num = num / 10;
    }
    return summ;
}
int result = countSumm(number);
Console.WriteLine($"сумма цифр, числа {number} = {result}");
