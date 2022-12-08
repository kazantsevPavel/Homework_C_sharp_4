// Использование функций обязательно, начиная с этого ДЗ!
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

System.Console.WriteLine("Давай узнаем, насколько сильно ты меня любишь?");
System.Console.WriteLine("Сколько раз в день ты обо мне думаешь?");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Сколько раз в день ты мне пишешь?");
int b = Convert.ToInt32(Console.ReadLine());
love(a,b);

void love (int a, int b)
{
int love = a;
for (int i=0; i<b;i++) love = love*a;
System.Console.WriteLine($"Ты меня любишь всего на {love} %");
System.Console.WriteLine($"А я тебя люблю на {love*1000} %");
}
