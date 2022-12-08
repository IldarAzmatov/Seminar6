// Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int[] array = { 1, 5, 3, 7, 89, 3, 6 };
for (int i =0; i<array.Length/2; i++ )
    {
        int temporary = array[i];
        array[i] = array[array.Length -1-i];
        array[array.Length -1-i]= temporary;
    }
Console.WriteLine (String.Join( " ", array));