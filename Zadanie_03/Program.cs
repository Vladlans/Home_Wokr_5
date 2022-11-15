//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
double[] GetArrayOfRealNumbers()
{
    Console.Write("Введите размер массива: ");
    int size = int.Parse(Console.ReadLine());

    double[] array = new double[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round(new Random().NextDouble() * 100, 2);
        Console.Write($"{array[i]}  ");
    }
    return array;
}

double FindDiffMaxMinElems(double[] array)
{
    double minValue = array[0];
    double maxValue = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < minValue) minValue = array[i];
        if (array[i] > maxValue) maxValue = array[i];
    }

    Console.WriteLine();
    
    double diff = maxValue - minValue;
    Console.WriteLine($"Разница составляет {diff}");
    return diff;
}

FindDiffMaxMinElems(GetArrayOfRealNumbers());