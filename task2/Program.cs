/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
int GetNumber (string message)
{
    int result;
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else 
        {
            Console.WriteLine("Ввели не число или некорректное число");
        }
    }
    return result;
}

//Метод, возвращающий координаты токи пересечения прямых
void GetIntersctionPoint(double b1,double k1,double b2,double k2)
{
    double x = Math.Round((b2 - b1) / (k1 - k2), 2);
    double y = Math.Round((k1 * x + b1),2);
    Console.WriteLine($"Прямые пересекаются в точке с координатами: ({x},{y})");
}

double b1 = GetNumber("Введите b1:");
double k1 = GetNumber("Введите k1:");
double b2 = GetNumber("Введите b2:");
double k2 = GetNumber("Введите k2:");
GetIntersctionPoint(b1,k1,b2,k2);
