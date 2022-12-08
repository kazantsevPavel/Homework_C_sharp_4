// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Через строку решать нельзя.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.WriteLine("Пройди тест, чтобы узнать через сколько дней ты умрешь!");
Console.WriteLine("Для начала запиши, сколько дней ты уже прожил");
int inputNum = Convert.ToInt32(Console.ReadLine());
int length = GetNumLength(inputNum);

int GetNumLength(int num) // считаем длину нашего числа
{
    int length = 0;
    while (num > 0)
    {
        num = num / 10;
        length++;
    }
    return length;
}

int[] array = new int[length];
array = PrintArray(length);

int[] PrintArray(int length) // заполнение массива нашими цифрами

{
    int pow = length - 1;
    for (int i = 0; i < length; i++)
    {

        array[i] = inputNum / Convert.ToInt32(Math.Pow(10, pow));
        array[i] = array[i] % 10;
        pow--;
        
    }
    return array;
}


int Sum(int length) // считаем сумму

{
    int sum = 0;
    for (int i = 0; i < length; i++)
    {
        sum += array[i];
    }
    Console.WriteLine("Тебе осталось жить вот столько дней: " + sum);
    return sum;
}

int sum = Sum(length);