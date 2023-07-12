// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.
// 
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []



Console.Clear();


string[] userArray = InputArray();


string[] resultArray = GetArrayStringLengthLE3(userArray);


Console.WriteLine($"\n{ArrayToString(userArray)} -> {ArrayToString(resultArray)}");


static string[] GetArrayStringLengthLE3(string[] arr)
{
    int length = arr.Length;
    string[] result = new string[length];
    int count = 0;
    for (int i = 0; i < length; i++)
        if (arr[i].Length <= 3)
        {
            result[count] = arr[i];
            count++;
        }
    Array.Resize(ref result, count);
    return result;
}

static string ArrayToString(string[] arr)
{
    if (arr.Length == 0) return "[]";
    return $"[\"{String.Join("\", \"", arr)}\"]";
}

static int InputNaturalNumber(string msg, int defaultValue)
{
    int num;
    Console.Write(msg);
    if (int.TryParse(Console.ReadLine(), out num))
    {
        if (num <= 0) num = defaultValue;
    }
    else
    {
        num = defaultValue;
    }
    return num;
}

static string[] InputArray()
{
    Console.WriteLine("1. [\"Hello\", \"2\", \"world\", \":-)\"]");
    Console.WriteLine("2. [\"1234\", \"1567\", \"-2\", \"computer science\"]");
    Console.WriteLine("3. [\"Russia\", \"Denmark\", \"Kazan\"]");
    Console.WriteLine("4. [\"Stas\", \"Max\", \"Sasha\", \"Git\"]");
    Console.WriteLine("5. [\"Hey\", \"^&^\", \"n&2\"]");
    Console.WriteLine("6. Ввод пользователя\n");

    int userChoice = InputNaturalNumber("Сделайте выбор (по умолчанию 6): ", 6);

    if (userChoice == 1) return new[] { "Hello", "2", "world", ":-)" };
    if (userChoice == 2) return new[] { "1234", "1567", "-2", "computer science" };
    if (userChoice == 3) return new[] { "Russia", "Denmark", "Kazan" };
    if (userChoice == 4) return new[] { "Stas", "Max", "Sasha", "Git" };
    if (userChoice == 5) return new[] { "Hey", "^&^", "n&2" };

    int N = InputNaturalNumber("Укажите длину массива (по умолчанию 2): ", 2);
    string[] result = new string[N];
    for (int i = 0; i < N; i++)
    {
        Console.Write($"Введите {i + 1} элемент массива: ");
        result[i] = Console.ReadLine() ?? "";
    }
    return result;
}
