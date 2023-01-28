/* Задача 36: Задайте одномерный массив, 
заполненный случайными числами. Найдите 
сумму элементов, стоящих на нечётных 
позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

int[] numbers = new int[100];

FillArray(numbers);
PrintArray(numbers);
SumNe4etPoz(numbers);

int PrintArray(int[] array)
{
    for (int i = 1; i < array.Length; i++)
    {
        Console.WriteLine($"{array[i]}");
    }
}

void FillArray(int[] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(-100, 100);
    }
}

int SumNe4etPoz(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum += array[i];
        }
        //return;
    }
    return sum;
}