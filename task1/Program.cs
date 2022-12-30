/* Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/
//Метод создания массива чисел
int[] InitArray(string message)
{
    Console.WriteLine(message);
    string str = Console.ReadLine()??"";
    int[] array = Array.ConvertAll(str.Split(','), int.Parse);
    return array;
}

//Метод нахождения количества чисел больше нуля в массиве
int GetCountPositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            count++;
    }
    return count;
}
int[] arr = InitArray("Введите числа через запятую:");
Console.WriteLine($"Количество чисел больше нуля: {GetCountPositiveNumbers(arr)}");

