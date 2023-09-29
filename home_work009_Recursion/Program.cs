// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
//  Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1


// string PrintNumbers(int n) 
// { 
//     if (n == 0) 
//         return ""; 
//     return  $"{n} " + PrintNumbers(n - 1); 
 
// } 
 
// System.Console.WriteLine("Введите натуральное число "); 
// int n = Convert.ToInt32(Console.ReadLine()); 
// System.Console.WriteLine(PrintNumbers(n));










// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int FindSum(int M, int N) 
// { 
//     if (N == M) 
//         return N; 
//     return N + FindSum(M, N - 1); 
// } 
 
// System.Console.WriteLine("Введите нижнюю границу "); 
// int M = Convert.ToInt32(Console.ReadLine()); 
// System.Console.WriteLine("Введите вверхнюю границу "); 
// int N = Convert.ToInt32(Console.ReadLine()); 
// System.Console.WriteLine(FindSum(M, N));


















// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// int AckermannFunction(int m, int n)
// {
//     if (m == 0) return n + 1;
//     else if (n == 0) return AckermannFunction(m -1,1);
//     return AckermannFunction(m - 1, AckermannFunction(m,n - 1));  
// }
// System.Console.WriteLine("Введите число m "); 
// int m = Convert.ToInt32(Console.ReadLine()); 
// System.Console.WriteLine("Введите число n "); 
// int n = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(AckermannFunction(m, n));