// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumNum(int num)
{
    int result = 0;
    for (int i = 1; i < num; num /= 10)
    {
        result += num % 10;
    }
    return result;
}

System.Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(SumNum(num));
