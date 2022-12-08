// Задача 29: Напишите программу, которая задаёт массив из 8 целых чисел с клавиатуры и далее выводит массив на экран в одну строку.
Console.WriteLine("Введите 8 чисел через пробел");

string inputString = Console.ReadLine(); // читаем строку
int length = inputString.Length;

string[] words = inputString.Split(new char[] { ' ' });// парсим строку в массив строк
System.Console.WriteLine("Первый способ: ");

foreach (string s in words)
{
    Console.Write(s + " ");
}


System.Console.WriteLine();
System.Console.WriteLine("Второй способ");
for(int i =0; i<length;i++)
System.Console.Write(inputString[i] + " ");