
/* Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

1) приглошение ко вводу;
2) объявление переменных;
3) интеграция в строку- числа;
4) ввод данных их консоли;
5) условие, проверка на четность
6) вывод ответа
*/


Console.Clear();

Console.WriteLine("ВВедите число, а я скажу число четное либо нет!!!");

Console.Write("Введите число: ");

string input = Console.ReadLine();  
int number1 = int.Parse(input);

Console.WriteLine($"Число: {number1}");




int max = number1;
int min = number2;

if(max < number2)
{
    max = number2;
    min = number1;
}
Console.Write("Ответ: ");
Console.Write($"max = {max}; ");
Console.WriteLine($"min = {min}.");

