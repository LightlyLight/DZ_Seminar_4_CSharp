/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
int GetNum(string message)
{
    Console.WriteLine($"Введите {message}: ");
    int num = int.Parse(Console.ReadLine());
    return num;
}

int[] getRandomArray(int size)
{
    int[] array = new int[size];
    Random rand = new Random(size);
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next();
    }
    return array;
}

int SumPositionNehet(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i%2 > 0)
        {
        count = count + array[i];
        }
    }

    
    return count;
}

int SizeArr = GetNum("размер массива");

int[] array = getRandomArray(SizeArr);


int PositionNechet = SumPositionNehet(array);

Console.WriteLine(string.Join(" // ", array));

Console.WriteLine($"Суммв элементов в массиве на нечётных позициях = {PositionNechet}");




