//Задача1. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*bool Topot(int num1, int num2, int num3, int num4, int num5)
{
    if((num1 == num5) && (num2 == num4)) return true;
    else return false;
}
Console.Write("Input num1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input num2: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input num3: ");
int num3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input num4: ");
int num4 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input num5: ");
int num5 = Convert.ToInt32(Console.ReadLine());
bool result = Topot(num1, num2, num3, num4, num5);
{
    if (result == false) Console.WriteLine("OOOPS, you are wrong, try another number");
    if (result == true) Console.WriteLine("Well Done");
}
*/

/*
void Topot (int number)
{
    int num1 = number/10000;
    int num2 = number/1000%10;
    int num4 = number%100/10;
    int num5 = number%10;
        if ((num1==num5) && (num2==num4))
        {   
            Console.WriteLine("It is polyndrome");
        }
        else 
        {
            Console.WriteLine("It is not a polyndrome");
        }
}
Console.Write("Input a five-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());
Topot(num);
*/

/*
//Задача2. Напишите программу, 
//которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
double Length(double xa, double ya, double xb, double yb, double zb, double za)
{
    double length = Math.Sqrt((xb - xa)*(xb-xa)+(yb - ya)*(yb-ya) + (zb-za)*(zb-za));
    return length;
}
Console.Write("Input xa: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("Input ya: ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.Write("Input xb: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("Input yb: ");
int yb = Convert.ToInt32(Console.ReadLine());
Console.Write("Input za: ");
int za = Convert.ToInt32(Console.ReadLine());
Console.Write("Input zb: ");
int zb = Convert.ToInt32(Console.ReadLine());

double length = Length(xa,ya,xb,yb, za, zb);
Console.Write($"Расстояние между точками А и В равно {length}");

Задача 3.
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
int num;
Console.Write("Input integer number ");
num = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= num; i++)
        {
            Console.WriteLine($"{i} x {i} x {i} = {i*i*i}");
        }
    Console.WriteLine();
*/
