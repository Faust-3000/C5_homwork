/* Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */


/*int[] array = GetArray(10, 100, 1000); // массив из 3х значных чисел рандомных
Console.WriteLine($"Полученный массив: {String.Join(", ", array)}");
Console.WriteLine($"Количество четных чиссел в массиве: {numEvenPosition(array)}");


int numEvenPosition(int[] array){ // метод расчета четного числа
    int numEven = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
        {
        numEven ++;
        }
    }
    return numEven;
}

int[] GetArray(int size, int minValue, int maxValue){ //метод вывода рандомного массива
    int[] res = new int[size];

    for(int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
} */

/* Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

/*int[] array = GetArray(4);
Console.WriteLine($"Полученный массив: {String.Join(", ", array)}");
Console.WriteLine($"Количество  не четных чиссел в массиве: {numEvenPosition(array)}");

int numEvenPosition(int[] array){ 
    int numEven = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 != 0)
        {
        numEven ++;
        }
    }
    return numEven;
}

int[] GetArray(int size){ //метод вывода рандомного массива без ручных ограничений
    int[] res = new int[size];

    for(int i = 0; i < size; i++)
    {
        res[i] = new Random().Next();
    }
    return res;
} */


/*Задайте массив вещественных чисел(просто от минус бесконечности, до плюс бесконечности, 
с дробными не работаем). Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */

int[] array = GetArray(10, -1000, 1000);
Console.WriteLine($"Полученный массив: {String.Join(", ", array)}");


// метод вывода рандомного массива ограниченного пользователем
int[] GetArray(int size, int minValue, int maxValue){
    int[] res = new int[size];

    for(int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int numbermin = Int32.MaxValue;
int numbermax = Int32.MinValue;
int diff = 0;

for(int i = 0; i < array.Length; i++){
    if(array[i] > numbermax){
        numbermax = array[i];
    } 
    if(array[i] < numbermin){
        numbermin = array[i];
    }
}
diff = numbermax - numbermin;
Console.WriteLine($"разность между {numbermax} и {numbermin} равна {diff}");