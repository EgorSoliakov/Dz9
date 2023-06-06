/*Задача 64: Задайте значения M и N. 
Напишите программу, которая выведет все
натуральные числа в промежутке от M до N.
M = 1; N = 5. -> "1, 2, 3, 4, 5"
M = 4; N = 8. -> "4, 6, 7, 8"*/

int m = Promt();
int n = Promt();

NaturalNum(n, m);
int Promt()
{
    Console.WriteLine("Введите значение: ");
    int limit = int.Parse(Console.ReadLine());
    return limit;
}
void NaturalNum(int limit, int min)
{

    if (limit == min)
    {
        Console.Write($" {limit}. ");
    }
    else
    {
        Console.Write($" {limit}, ");
        NaturalNum(limit-1, min);
    }
}

