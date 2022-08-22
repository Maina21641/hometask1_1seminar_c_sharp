// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите первое число: "); // выводится окно: "Введите первое число"
int a = Convert.ToInt32(Console.ReadLine()); // преобразование строки в число
Console.WriteLine("Введите второе число: "); // выводится окно: "Введите второе число"
int b = Convert.ToInt32(Console.ReadLine()); // преобразование строки в число
Console.WriteLine("Введите третье число: "); // выводится окно: "Введите третье число"
int c = Convert.ToInt32(Console.ReadLine());// преобразование строки в число

if(a > b & a > c)
{
    Console.WriteLine($"{a} maximum");
}
else if (b > c & b > a)
{
    Console.WriteLine($"{b} maximum");
}
else if (c > a & c > b)
{
    Console.WriteLine($"{c} maximum");
}
else if (c > a & a == b) // если есть равные числа и они меньше третьего
{
    Console.WriteLine($"{c} maximum");
}
else if (a > b & b == c) // если есть равные числа и они меньше третьего
{
    Console.WriteLine($"{a} maximum");
}
else if (b > c & c == a) // если есть равные числа и они меньше третьего
{
    Console.WriteLine($"{b} maximum");
}
else if (a == b & c < a) // если есть равные числа и они больше третьего
{
    Console.WriteLine($"{a} maximum");
}
else if (b == c & a < b) // если есть равные числа и они больше третьего
{
    Console.WriteLine($"{b} maximum");
}
else if (c == a & b < c) // если есть равные числа и они больше третьего
{
    Console.WriteLine($"{c} maximum");
}
else if (c == a & a == b) // если все числа равны между собой
{
    Console.WriteLine($"{a} maximum");
}