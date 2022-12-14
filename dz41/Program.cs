// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите числа через пробел: ");
string N = Console.ReadLine();
string[] array = N.Split(" ");
int[] numArray = new int[array.Length];
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    numArray[i] =Convert.ToInt32(array[i]);
    if (numArray[i] < 0)
    {
        count++;
    }
}
Console.Write(count);
