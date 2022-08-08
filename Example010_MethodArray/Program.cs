int[] arr = {1, 2, 3, 4, 5, 6, 7, 4};

int n = arr.Length;
int find = 4;

int index = 0;

while (index < n)
{
    if (arr[index]==find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;    // index +=1 // index = index +1
}