void FillArray(int[] collection)
{
    int len = collection.Length;
    int i = 0;
    while (i < len)
    {
        collection[i] = new Random().Next(1, 10);
        i++;
    }
}

void PrintArray(int[] colle)
{
    int cou = colle.Length;
    int pos = 0;
    while (pos < cou)
    {
        Console.Write($" {colle[pos]}");
        pos++;
    }

}

int IndexOf(int[] col, int sear)
{
    int c_size = col.Length;
    int ind = 0;
    int position = -1;
    while (ind < c_size)
    {
        if (col[ind] == sear) {
            position = ind;
            break;
        }
        ind++;
    }
    return position;
}

int[] arr = new int[10];    // new array size 10 filled with 0

FillArray(arr);
PrintArray(arr);
Console.WriteLine();
int posi = IndexOf(arr, 3);
Console.WriteLine(posi);