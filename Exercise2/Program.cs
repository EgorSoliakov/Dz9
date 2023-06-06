/*Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму
натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

int n = Promt();
int m = Promt();

if(m>n) Console.WriteLine($"{NaturalNum(n, m)}");
int Promt()
{
    Console.WriteLine("Введите значение: ");
    int limit = int.Parse(Console.ReadLine());
    return limit;
}
int NaturalNum(int limit, int count)
{

    if (limit == count)
    {
       return limit;
    }
    else
    {
        
       return limit + NaturalNum(limit+1, count);
    }
}