/*Задача 36: 

Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/

Console.Write("Укажите количество чисел, которые необходимо поместить в массив: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = new int[number];
int count = 0;

for (int index = 0; index < number; index++)
{
    array[index] = new Random().Next(-100, 101);
    Console.Write(array[index] + "\t");
    if (index % 2 != 0) count += array[index];
}

Console.WriteLine();
Console.WriteLine($"Сумма чисел на нечётных позициях: {count}");