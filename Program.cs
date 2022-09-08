// Домашнее задание

// Задача 64: Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа 
// в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"
// Console.WriteLine("Введите M");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите N");
// int N = Convert.ToInt32(Console.ReadLine());

// string PrintNumbers(int start, int end)
// {

//     if (start == end) return start.ToString();

//     return (start + ", " + PrintNumbers(start + 1, end));
// }

// Console.WriteLine($"Числа от {M} до {N}: '{PrintNumbers(M, N)}' ");

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// 		// M = 1; N = 15 -> 120
// 		// M = 4; N = 8. -> 30
// Console.WriteLine("Введите m");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите n");
// int n = Convert.ToInt32(Console.ReadLine());

// int CalculateSumm(int m, int n)
// {
//     int start = m;
//     int end = n;
//     if (m > n)
//     {
//         start = n;
//         end = m;
//     }
//     return (end + start) * (end - start + 1) / 2; 
// }

// Console.WriteLine($"Сумма чисел от {m} до {n}: {CalculateSumm(m, n)} ");

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9
// int InputNumber(string input)
// {
// Console.Write(input);
// int output = Convert.ToInt32(Console.ReadLine());
// return output;
// }
// int Akkerman(int m, int n)
// {
// if (m == 0)
// {
// return n + 1;
// }
// else if (n == 0 && m > 0)
// {
// return Akkerman(m - 1, 1);
// }
// else
// {
// return Akkerman(m - 1, Akkerman(m, n - 1));
// }
// }

// int m = InputNumber("Ввод m: ");
// int n = InputNumber("Ввод n: ");
// int akkermanFunction = Akkerman(m, n);
// Console.Write($"m = {m}, n = {n} - > A(m,n) = {akkermanFunction} ");
    
