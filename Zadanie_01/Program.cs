//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
int[] GetThreeDigitNumbersArray()
{
    Console.Write("Введите кол-во чисел в массиве: ");
    int size = int.Parse(Console.ReadLine());

    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
        Console.Write($"{array[i]} ");
    }
    return array;
}

int CountEvenElements(int[] array)
{
    int count = 0;
    Console.WriteLine();

    foreach (int el in array)
    {
        if (el % 2 == 0) count++;
    }
    Console.WriteLine($"В этом массиве {count} чётных чисел.");
    return count;
}
CountEvenElements(GetThreeDigitNumbersArray());