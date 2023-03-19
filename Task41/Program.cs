// Задача 41: 
// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// Примеры:
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int Prompt(string message)
{
    Console.WriteLine(message); // Выводим приглашение ко вводу
    string readInput = Console.ReadLine(); // Вводим значение
    int result = int.Parse(readInput); // приводим к числу
    return result;
}

int[] InputArray (int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = Prompt($"введите {i + 1}-й элемент");
    }
    return array;
}

void PrintArray(int[] array)
{
    for(int i =0; i < array.Length; i++)
    {
        Console.WriteLine($"a[{i}] = {array[i]}");
    }
}

int PositiveNumbers(int[] array)
{
    int count = 0;
    for(int i =0; i < array.Length; i++)
    {
       if(array[i] > 0) 
       count++;
    }
    return count;
}
int length = Prompt("Задайте длину массива: ");// любое число
int[] array = InputArray (length);
PrintArray(array);
Console.WriteLine($"В массиве {PositiveNumbers(array)} чисел больше нуля");