/*

Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2

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

// // Метод заполняет случайными числами массив и выводит его в консоль
// void FillAndPrintArray(ref int[] array)
// {
//     Random rnd = new Random();

//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = rnd.Next(100, 1000);             // [100,1000)
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// Метод заполняет случайными числами массив, выводит его в консоль, возвращает количество четных чисел
int FillAndPrintArray(ref int[] array)
{
    Random rnd = new Random();
    int evenCount = 0;

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(100, 1000);             // [100,1000)
        Console.Write($"{array[i]} ");
        if (array[i] % 2 == 0) evenCount++;
    }
    Console.WriteLine();
    return evenCount;
}


int number = GetNumber("Введите размерность массива: ");
int[] array = new int[number];
int evenCnt = FillAndPrintArray(ref array);
Console.WriteLine($"Количество четных чисел в массиве: {evenCnt}.");