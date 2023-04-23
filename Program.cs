//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// string OutputNum(int n){
//     if (n == 1) return 1.ToString();
//     string str = String.Empty;
//     return str + n.ToString() + ", " + OutputNum(n - 1);
// }

// Console.WriteLine("Введите число: ");
// int n = int.Parse(Console.ReadLine());
// Console.Write(OutputNum(n));

//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// int OutputNum(int n1, int n2, int sum){
//     if (n1 == n2) return sum + n1;
//     sum += n1;
//     return OutputNum(n1 + 1, n2, sum);
// }

// Console.WriteLine("Введите 2 числа: ");
// int[] number = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// int sum = 0;
// Console.Write(OutputNum(number[0], number[1], sum));

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int OutputNum(int n1, int n2){
    if (n1 == 0) return n2 + 1;
    else if ((n1 != 0) && (n2 == 0))
      return OutputNum(n1 - 1, 1);
    else
      return OutputNum(n1 - 1, OutputNum(n1, n2 - 1));
}

Console.WriteLine("Введите 2 числа: ");
int[] number = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
Console.Write(OutputNum(number[0], number[1]));
