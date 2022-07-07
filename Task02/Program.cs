/*

Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0

*/

// Метод получает число из консоли и проверяет его корректность
int GetNumber(string message)
{
    int result = 0;
    string errorMessage = "Вы ввели не число. Введите корректное число.";

    while (true)
    {

        Console.Write(message);

        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.Clear();
            Console.WriteLine(errorMessage);
        }
    }

    return result;
}

// Метод заполняет случайными числами массив, выводит его в консоль, возвращает сумму элеменов на нечетных позициях
int FillAndPrintArray(ref int[] array)
{
    Random rnd = new Random();
    int oddSum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(-99, 100);             
        Console.Write($"{array[i]} ");
        if (i % 2 == 1) oddSum += array[i];         
    }
    Console.WriteLine();
    return oddSum;
}


int number = GetNumber("Введите размер массива: ");
int[] array = new int[number];
int oddSum = FillAndPrintArray(ref array);
Console.WriteLine($"Сумма элементов на нечетных местах в массиве: {oddSum}.");