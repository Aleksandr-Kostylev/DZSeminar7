// Задача 1: Задайте значения M и N. Напишите программу,
// которая выведет все натуральные числа в промежутке от M до N.
// Использовать рекурсию, не использовать циклы.


// Ввод значений M и N

    
Console.Write("Введите значение M: ");

 int m = int.Parse(Console.ReadLine());

Console.Write("Введите значение N: ");

 int n = int.Parse(Console.ReadLine());



 // Вызов рекурсивной функции для вывода всех натуральных чисел от M до N

 PrintNumbers(m, n);

 Console.ReadLine();

    

// Рекурсивная функция для вывода всех натуральных чисел от M до N

static void PrintNumbers(int m, int n)

{

 // Если M меньше либо равно N, выводим M и вызываем функцию для следующего числа

    if (m <= n)

    {

    Console.WriteLine(m);

    PrintNumbers(m + 1, n);

    }
}
 
