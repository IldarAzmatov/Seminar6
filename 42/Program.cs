// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
string stroke = "";
int N3 = 0;
while (N > 0)
{
    N3 = N % 2;
    N = N / 2;
    stroke = N3 + stroke;
}
Console.WriteLine(stroke);