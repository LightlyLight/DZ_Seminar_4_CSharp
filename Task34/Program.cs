/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

int GetNum(string message)
{
    Console.WriteLine($"Введите {message}: ");
    int num = int.Parse(Console.ReadLine());
    return num;
}

int[] getRandomArray(int size, int min, int max)
{
    int[] array = new int[size];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(min, max);
    }
    return array;
}

int SumChet(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count = count + 1;

        }
    }
    return count;
}

int SizeArr = GetNum("размер массива");

int[] array = getRandomArray(SizeArr, 100, 999);
int chet = SumChet(array);

Console.WriteLine(string.Join(" // ", array));

Console.WriteLine($"Количество чётных чисел в массиве = {chet}");
