// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// void FillArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(100, 1000);
// }

// void PrintArray(int[] array)
// {
//     System.Console.Write(" [ ");
//     foreach (int item in array)
//         System.Console.Write($"{item} ");
//     System.Console.Write(" ] ");
// }

// void FindSum(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0)
//             count++;
//     }
//     System.Console.WriteLine();
//     System.Console.WriteLine($"Количество чётныйх чисел = {count}");
// }
// int[] array = new int[10];
// FillArray(array);
// PrintArray(array);
// FindSum(array);









// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0



// void FillArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(-10, 100);
// }

// void PrintArray(int[] array)
// {
//     System.Console.Write(" [ ");
//     foreach (int item in array)
//         System.Console.Write($"{item} ");
//     System.Console.Write(" ] ");
// }

// void SumNegative(int[] array)
// {
//     int res = 0;
//     for (int i = 1; i < array.Length; i += 2)
//     {
//         res = res + array[i];
//     }
//     System.Console.WriteLine($"Сумма чисел на не чётных позициях = {res}");
// }
// int[] array = new int[10];
// FillArray(array);
// PrintArray(array);
// SumNegative(array);








// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76



// void FillArray(double[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = Math.Round((new Random().NextDouble() * 1000), 2);
//         System.Console.Write($"{array[i]} ");
//     }
// }

// void PrintArray(double[] array)
// {
    
//     foreach (double item in array)
//         System.Console.Write($"{item} ");
    
// }

// void Difference(double[] array)
// {
//     double max = array[0];
//     double min = array[0];
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i] > max)
//             max = array[i];
//         else if (array[i] < min)
//             min = array[i];
//     }
//         System.Console.WriteLine();
//         System.Console.WriteLine($"Максимальное число {max} минимальное {min}");
//         System.Console.WriteLine();
//         System.Console.WriteLine($"Разница между максимальным и минимальным числами {max - min}");
// }
// double[] array = new double[10];
// FillArray(array);
// System.Console.WriteLine();
// Difference(array);
