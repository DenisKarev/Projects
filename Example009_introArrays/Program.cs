int Max(int arg1, int arg2, int arg3)
{
    int res = arg1;
    if (arg2 > res) res = arg2;
    if (arg3 > res) res = arg3;
    return res;
}
//             0   1   2   3   4   5   6   7   8  
int[] arr = { 41, 22, 83, 14, 15, 26, 17, 28, 39 };
// arr[0] = 22;
// Console.Write(arr[0]);

int resu = Max(
    Max(arr[0], arr[1], arr[2]),
    Max(arr[3], arr[4], arr[5]),
    Max(arr[6], arr[7], arr[8]));

Console.WriteLine(resu);

// int[] array0 = { 9, 28, 1, 32, 1990 };

// int[] array1 = { 0, 0, 0, 0, 0 };
// int[] array2 = new int[5];
// int[] array3 = new int[] { 0, 0, 0, 0, 0 };
// int[] array4 = new int[5] { 2, 2, 1, 4, 7 };