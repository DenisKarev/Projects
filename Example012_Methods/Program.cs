// Вид 1
void Method1()
{
    Console.WriteLine("Автор...");
}

// Method1();

// Вид 2
void Method2(string msg)
{
    Console.WriteLine(msg);
}
// Method2(msg: "Тоже автор !");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
// Method21(msg: "Тоже автор !", count: 4);

// Вид 3
int Method3()
{
    return DateTime.Now.Year;
}
// int year = Method3();
// Console.WriteLine(year);

// Вид 4
// string  Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;
//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }
string Method4(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
// string res = Method4(10, "z_");
// Console.WriteLine(res);

void MultipyTable()
{
    for (int i = 2; i <= 10; i++)
    {
        for (int j = 2; j <= 10; j++)
        {
            Console.WriteLine($"{i} x {j} = {i * j}");
        }
        Console.WriteLine();
    }
}
// MultipyTable();


// =====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.
// Ясна ли задача?

string text1 = "— Я думаю, — сказал князь, улыбаясь, — что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде, "
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

string ReplaceChar(string text, char oldChar, char newChar)
{
    string resu = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldChar) resu = resu + $"{newChar}";
        else resu = resu + $"{text[i]}";
    }
    return resu;
}
// string newText = ReplaceChar(text1, ' ', '_');
// Console.WriteLine (newText);
// newText = ReplaceChar(newText, 'с', 'С');
// Console.WriteLine (newText);
// newText = ReplaceChar(newText, 'к', 'К');
// Console.WriteLine (newText);


//
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
        // Console.Write(array[i] + " | ");
    }
    Console.WriteLine();
}
void SeletionSortMin(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }

        int tempopary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = tempopary;
    }
}
void SeletionSortMax(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPosition]) maxPosition = j;
        }

        int tempopary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = tempopary;
    }
}
int[] arr = { 6, 1, 8, 3, 2, 6, 4, 5, 7, 11, 0, 1, 3 };
int[] arrMax = arr;
PrintArray(arr);
SeletionSortMin(arr);
PrintArray(arr);
SeletionSortMax(arrMax);
PrintArray(arrMax);