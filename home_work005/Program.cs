// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


// System.Console.WriteLine("Введите трёхзначное число");
// int num = Convert.ToInt32(Console.ReadLine());
// int result = num / 10;
// System.Console.Write("Вторая цифра вашего трёхзначного числа = ");
// System.Console.WriteLine(result % 10);




// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


// System.Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// int digit = -1;

// while (num > 999)
// {
//     num = num / 10;
//     digit = num % 10;    
// }
// System.Console.WriteLine(digit);

// if (num < 100)
//     System.Console.Write("третьей цифры нет");
    




// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет



// System.Console.WriteLine("Введите цифру обозначающую день недели");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num == 7 || num == 6)
//     System.Console.WriteLine("Выходной,можете отдыхать!");
// if (num < 1 || num > 7)
//     System.Console.WriteLine("Такого дня в неделе нет");
// else if (num < 6 )
//     System.Console.WriteLine("К сожалению рабочий день -_-");