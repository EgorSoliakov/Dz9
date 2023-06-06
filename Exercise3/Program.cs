/*Задача 68: Напишите программу вычисления
 функции Аккермана с помощью
рекурсии. Даны два неотрицательных
 числа m и n.
m = 2, n = 3 -> A(m,n) = 29*/


int n = Promt();
int m = Promt();
if (n<0 || m<0) Console.WriteLine("Не работает с отрицательными числами!");
else Console.WriteLine($"{Ackermann(n,m)}");
int Promt()
{
    Console.WriteLine("Введите значение: ");
    int limit = int.Parse(Console.ReadLine());
    return limit;
}
int Ackermann(int n, int m)
{
        if (n == 0) return (m + 1); 
        else if (m == 0) return Ackermann (n - 1, 1);
        else return Ackermann (n - 1, Ackermann (n, m - 1));
}
