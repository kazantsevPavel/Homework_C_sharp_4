// SЗадача 30: - HARD необязательная Напишите программу, которая на вход получает размерность массива. 
// Далее заполняет его случайными уникальными числами и выводит на экран. 
// Далее производим сортировку массива от большего к меньшему и выводим на экран. 
// Далее придумываем алгоритм перемешивания списка на основе случайности , применяем этот алгоритм и выводим на экран результат. 
// Встроенные методы работы со списками использовать нельзя.


Console.WriteLine("Выберите длинну массива");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(n);


int[] FillArray(int n) // Создание случайного массива
{
    int[] array = new int[n];
    for (int i = 0; i < n; i++)

    {
        array[i] = new Random().Next(0, 100);

    }


    return array;
}

int coincidence = 1; //проверка повторяющихся цифр в нашем массиве
while (coincidence > 0)  // делать до тех пор, пока повторяющихся цифр не будет

{
    coincidence = 0;
    array = FillArray(n);

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {

            if (array[i] == array[j]) coincidence++;
            if (i == j) coincidence--;
        }
    }


}

System.Console.WriteLine("Создан случайный массив");
for (int i = 0; i < n - 1; i++)

{
    array[i] = new Random().Next(0, 100);
    System.Console.Write(array[i] + ",");
}
array[n - 1] = new Random().Next(0, 100);
System.Console.WriteLine(array[n - 1]);



// СОРТИРОВКА МАССИВА

int[] arraySorting = BubbleSort(array);

int[] BubbleSort(int[] mas)
{
    int temp;
    for (int i = 0; i < mas.Length; i++)
    {
        for (int j = i + 1; j < mas.Length; j++)
        {
            if (mas[i] > mas[j])
            {
                temp = mas[i];
                mas[i] = mas[j];
                mas[j] = temp;
            }
        }
    }
    return mas;
}

System.Console.WriteLine();
System.Console.WriteLine("сортированный массив");
for (int i = 0; i < n; i++)
    System.Console.Write(arraySorting[i] + " ");



// ПЕРЕМЕШИВАНИЕ МАССИВА


int[] tempArray = new int[n];  // создаю случайный временный массив, чтобы на основе его перемешать свой массив

for (int i = 0; i < n; i++)
    tempArray[i] = new Random().Next(1, 100);



int max = tempArray[0];
int indexMax = 0;

for (int i = 0; i < n; i++)
{
    if (tempArray[i] > max) // нахожу максимальный элемент временного массива
    {
        max = tempArray[i];
        indexMax = i;
    }
}



int min = tempArray[0];
int indexMin = 0;

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)

    {
        if (tempArray[j] < min && tempArray[j] > 0) // нахожу минимальный элемент временного массива и его индекс
        {
            min = tempArray[j];
            indexMin = j;

        }

    }

    min = max + 1;

    int tempArraySortingNum = arraySorting[i]; // на основе найденного минимума сортирую мой массив
    arraySorting[i] = arraySorting[indexMin];
    arraySorting[indexMin] = tempArraySortingNum;

    tempArray[indexMin] = tempArray[indexMin] * (-1); // делаю этот элемент массива отрицательным, чтобы исключить его из выборки при следующей итерации

}

System.Console.WriteLine();
System.Console.WriteLine("перемешанный массив");
for (int i = 0; i < n; i++)
    System.Console.Write(arraySorting[i] + " ");

System.Console.WriteLine();
System.Console.WriteLine("Я ДЕЛАЛ ЭТУ ЗАДАЧУ ТРИ ДНЯ!!!!");