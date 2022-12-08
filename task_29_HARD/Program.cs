// // Задача 26. - HARD необязательная Напишите программу, которая принимает на вход целое или дробное число и выдаёт количество цифр в числе.
// 452 -> 3
// 82 -> 2
// 9,012 ->4


System.Console.WriteLine("Пришла пора доказать, что я не тупая программа!");
System.Console.WriteLine("Я могу посчитать количество цифр в любом числе! Даже если оно отрицательное или дробное!");
System.Console.WriteLine("Попробуй написать ЛЮБОЕ число!");
double inputNum = Convert.ToDouble(Console.ReadLine());

int numberOfDigits = NumberOfDigits(inputNum);

int NumberOfDigits(double num) //функция подсчёта длины строки включая минусы и запятые
{
    string inputNumString = Convert.ToString(num);
    int length = inputNumString.Length;
    return length;
}

int numberOfCommaAndMinus = 0;
numberOfCommaAndMinus = CommaAndMinus(inputNum); // поиск запятых и минусов

int CommaAndMinus(double num)

{
    int numberOfCommaAndMinus2 = 0;
    if (num < 0)
    {
        numberOfCommaAndMinus2++;
       
    }

    if (num % 1 != 0)
    {
        numberOfCommaAndMinus2++;
    }
    return numberOfCommaAndMinus2;
}



numberOfDigits = numberOfDigits - numberOfCommaAndMinus;
System.Console.WriteLine(numberOfDigits);


System.Console.WriteLine("Число цифр в этом числе: " + numberOfDigits);
