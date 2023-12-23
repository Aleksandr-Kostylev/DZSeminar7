// // Задача 1: Задайте значения M и N. Напишите программу,
// // которая выведет все натуральные числа в промежутке от M до N.
// // Использовать рекурсию, не использовать циклы.


// // Ввод значений M и N

    
// Console.Write("Введите значение M: ");

//  int m = int.Parse(Console.ReadLine());

// Console.Write("Введите значение N: ");

//  int n = int.Parse(Console.ReadLine());



//  // Вызов рекурсивной функции для вывода всех натуральных чисел от M до N

//  PrintNumbers(m, n);

//  Console.ReadLine();

    

// // Рекурсивная функция для вывода всех натуральных чисел от M до N

// static void PrintNumbers(int m, int n)

// {

//  // Если M меньше либо равно N, выводим M и вызываем функцию для следующего числа

//     if (m <= n)

//     {

//     Console.WriteLine(m);

//     PrintNumbers(m + 1, n);

//     }
// }
 
// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");

int functionAkkerman = Ack(m, n);

Console.Write($"Функция Аккермана = {functionAkkerman} ");

int Ack(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return Ack(m - 1, 1);
  else return Ack(m - 1, Ack(m, n - 1));
}

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}
