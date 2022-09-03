/*Задача 38: Задайте массив вещественных чисел. 

Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76*/

Console.Write("Укажите количество чисел, которые необходимо поместить в массив: ");
int number = Convert.ToInt32(Console.ReadLine());
double[] array = new double[number];
int count = 0;

for (int index = 0; index < number; index++)
{
    array[index] = new Random().Next(-100, 101);
    Console.Write(array[index] + "\t");
}

double max = array[0];
double min = array[0];

for (int index = 0; index < number; index++)
{
    if (array[index] > max) max = array[index];
    else if (array[index] < min) min = array[index];
}

Console.WriteLine();
Console.WriteLine("Разность между максимальным и минимальным элементом массива: " + (max - min));