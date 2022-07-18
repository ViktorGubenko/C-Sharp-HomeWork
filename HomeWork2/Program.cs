/* Task 1
 Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.

int ShowSN (int num)
{
    int num1 = num % 100 /10;
        return num1;
}
int number = new Random().Next(100,1000);
Console.WriteLine (number);
int result = ShowSN (number);
Console.WriteLine(result);
*/


/* Task 2 Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
//что третьей цифры нет.

Console.Write("Input integer number: ");
int num = Convert.ToInt32(Console.ReadLine());
string num1 = Convert.ToString(num);
if (num1.Length > 2)
{
  Console.WriteLine("Third number is  " + num1[2]);
}
else 
{
  Console.WriteLine("There is no third number");
}
*/

/* Task 3
Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.

bool Weekend (int num)
{
    if (num>5 && num <8) return true;
    else return (false);
    }
Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
bool result = Weekend(number);
{
    if (number >=8) Console.WriteLine("In one week 7 days");
    if (result == false) Console.WriteLine("OOOPS, you are wrong, try another number");
    if (result == true) Console.WriteLine("WeekEnd");
}
*/