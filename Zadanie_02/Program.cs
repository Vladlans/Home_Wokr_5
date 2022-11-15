//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
int[] GetArray()
{
    Console.Write("Введите размер массива ");
    int size = int.Parse(Console.ReadLine());
    Console.Write("Введите нижний предел массива: ");
    int minValue = int.Parse(Console.ReadLine());
    Console.Write("Введите верхний предел массива: ");
    int maxValue = int.Parse(Console.ReadLine());

    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
        Console.Write($"{array[i]} ");
    }
    return array;
}

int SumOddElemsOfArray(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }
    Console.WriteLine();
    Console.WriteLine($"Сумма нечётных элементов массива = {sum}");
    return sum;
}

SumOddElemsOfArray(GetArray());
