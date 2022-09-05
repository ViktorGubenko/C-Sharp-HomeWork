/* Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа 
в промежутке от M до N.

M = 1; N = 5. -> ""1, 2, 3, 4, 5""

M = 4; N = 8. -> ""4, 6, 7, 8""


void Posledovatelnost(int a, int b)
{
    if (a < b) Posledovatelnost (a, b-1);
    Console.Write(b + " ");
}

Console.Write("Input number a: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number b: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Posledovatelnost(num1, num2);
*/

/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int PosledovatelnostSum(int a, int b)
{
    if (a < b) return (b-1) + PosledovatelnostSum (a, b-1);
    return 0;
}

Console.Write("Input number a: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number b: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма последовательности от {num1} до {num2} is {PosledovatelnostSum(num1, num2)}");
*/

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

int Akkerman (int m, int n)
{
    if (m==0) return (n+1);
    { 
        if ((m>0) && (n == 0)) return Akkerman((m-1), 1);
        {
            if ((m>0) && (n>0)) return Akkerman ((m-1), Akkerman(m, n-1));
        }
    }
    return n+1;
}
Console.Write("Input number a: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number b: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Функция Аккермана от чисел {num1} и {num2} is {Akkerman(num1, num2)}");