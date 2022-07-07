/*

Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76

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

// Метод заполняет случайными числами массив, выводит его в консоль, возвращает разницу между максимальным и минимальным значением
int FillAndPrintArray(int[] array)
{
    Random rnd = new Random();
    int max = 0;
    int min = 0;

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(-99, 100);             
        Console.Write($"{array[i]} ");
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];        
    }
    Console.WriteLine();
    return max - min;
}


int number = GetNumber("Введите размер массива: ");
int[] array = new int[number];
int diff = FillAndPrintArray(array);
Console.WriteLine($"Разница между максимальным и минимальным элементами в массиве: {diff}.");