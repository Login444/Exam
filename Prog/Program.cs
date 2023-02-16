string[] GetArray(int size)

{
    string[] result = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Ваше {i+1}-я строка: ");
        result[i] = Convert.ToString(Console.ReadLine());
    }

    return result;
}

void ShowArray(string[] array)
{
    Console.WriteLine("Ваш массив: ");
    for (int i = 0; i<array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}


void ShowNewArray(string[] array)
{
    Console.WriteLine("Вот строки длинна которых меньше либо равна 3: ");
    for (int i = 0; i<array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            Console.Write(array[i] + " ");
        }
    }
    Console.WriteLine();
}

Console.WriteLine("Сколько строк вы хотите проверить?");
int a = Convert.ToInt32(Console.ReadLine());

string[] arr = GetArray(a);

ShowArray(arr);
ShowNewArray(arr);
