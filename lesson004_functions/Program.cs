// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


// int numberDegree (int num1, int num2)
// {
//     int res = 1;
//     for (int i = 1; i <= num2; i++)
//     {
//         res = res * num1;        
//     }
//    return res;
// }   
// System.Console.WriteLine("Введите число для возведения");
// int num1 = Convert.ToInt32( Console.ReadLine() );
// System.Console.WriteLine("Укажите степень возведения");
// int num2 = Convert.ToInt32( Console.ReadLine() );
// System.Console.WriteLine($"{numberDegree(num1,num2)}");





// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int SumNumber (int num)
// {
//     int res = 0;
//     while(num > 0 )
//     {
//     res = res + (num % 10);
//     num /= 10;
//     }
//     return res;
// }
// System.Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($"Сумма цифр числа: {num} равна {SumNumber(num)}");



// Задача 29: Напишите программу, которая задаёт массив из 8 элементов случайных целых чисел от 1 до 50 и выводит их на экран.

// необязательная задача SORT Написать программу сортировки массива от большего к меньшему. Массив задается размерностью N с клавиатуры,
//  далее заполняется случайными целыми числами от -100 до 100, выводится на экран. Сортируется,
//  и затем опять выводится на экран.



// void FillArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(-100, 100);
// }
// void PrintArray(int[] array)
// {
//     foreach (int item in array)
//         System.Console.Write($"{item} ");
//     System.Console.WriteLine();
// }
// void Sort(int[] array)
// {
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         int minPosition = i;

//         for (int j = i + 1; j < array.Length; j++)
//         {
//             if (array[j] < array[minPosition]) minPosition = j;
//         }
//         int temporary = array[i];
//         array[i] = array[minPosition];
//         array[minPosition] = temporary;
//     }
// }
// System.Console.WriteLine("Введите количество элементов массива");
// int len = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[len];
// FillArray(array);
// PrintArray(array);
// Sort(array);
// System.Console.WriteLine();
// PrintArray(array);




