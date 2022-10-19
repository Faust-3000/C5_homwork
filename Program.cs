/* Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */


int[] array = GetArray(10, 100, 1000); // массив из 3х значных чисел рандомных
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
}