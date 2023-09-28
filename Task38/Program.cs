/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
*/


int GetNum(string message)
{
    Console.WriteLine($"Введите {message}: ");
    int num = int.Parse(Console.ReadLine());
    return num;
}

double[] getRandomArray(int size)
{
    double[] array = new double[size];
    Random rand = new Random(size);
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.NextDouble();
    }
    return array;
}

double MinElement(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
        min = array[i];
        }
    }
return min;
}

double MaxElement(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
        max = array[i];
        }
    }
 return max;
}

int SizeArr = GetNum("размер массива");

double[] array = getRandomArray(SizeArr);

double PositionMin = MinElement(array);
double PositionMax = MaxElement(array);

double DiffMinMaxElement(double[] array)
{
    double diff = PositionMax - PositionMin;
    return diff;
}
double DiffMaxMin = DiffMinMaxElement(array);

Console.WriteLine(string.Join(" // ", array));

Console.WriteLine($"Наименьший элемент массива это {PositionMin}");
Console.WriteLine($"Наибольший элемент массива это {PositionMax}");
Console.WriteLine($"Разница между наибольшим и наименьшим элементами массива составляет {DiffMaxMin}");