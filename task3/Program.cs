// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] RandomArray(int length)
{
    int[] result = new int[length];

    for (int i = 0; i < length; i++)
    {
        result[i] = new Random().Next(-100, 101);
    }
    return result;
}

void PrintArray(int[] array)
{
    foreach(int item in array)
    {
        System.Console.Write(item + " ");
    }
}

System.Console.WriteLine("Введите длину массива");
int length = Convert.ToInt32(Console.ReadLine());
PrintArray (RandomArray(length));