// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


Console.Clear();
string[] originArray = {"1234", "1567", "-2", "computer science"};
string[] arrayToReplace = new string[originArray.Length];
int count = 0;
for (int i = 0; i < originArray.Length; i++)
{
    if (originArray[i].Length <= 3)
    {
        arrayToReplace[count] = originArray[i];
        count++;
    }
}

Console.Write("Массив строк после замены: ");
for(int i = 0; i < count; i++)
{
    Console.Write(arrayToReplace[i]);
}

