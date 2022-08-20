string[,] table = new string[2, 5];
// String.Empty();
// table[0, 0]   table[0, 1]     table[0, 2]     table[0, 3]     table[0, 4]
// table[1, 0]   table[1, 1]     table[1, 2]     table[1, 3]     table[1, 4]
table[1, 2] = "Word";
for (int row = 0; row < table.GetLength(0); row++)
{
    for (int col = 0; col < table.GetLength(1); col++)
    {
        Console.Write($"|{table[row, col]}|");
    }
    Console.WriteLine();
}

void PrintArray2dInt(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}
void FillArray2dInt(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        Random rnd = new Random();
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rnd.Next(1, 10);
        }
    }
}
int[,] matrix = new int[3, 4];
// PrintArray2dInt(matrix);
FillArray2dInt(matrix);
// Console.WriteLine();
PrintArray2dInt(matrix);

void PrintArray2dPic(int[,] image2d)
{
    for (int i = 0; i < image2d.GetLength(0); i++)
    {
        for (int j = 0; j < image2d.GetLength(1); j++)
        {
            if (image2d[i, j] == 0) Console.Write(" ");
            else Console.Write("8");
        }
        Console.WriteLine();
    }
}


int[,] pic = new int[,] {
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0 },
{0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,0, 0, 0, 0, 0, 0, 0 },};

void FillArray2dPic(int row, int col)
{
    if (pic[row, col] == 0)
    {
        pic[row, col] = 1;
        FillArray2dPic(row - 1, col);
        FillArray2dPic(row, col - 1);
        FillArray2dPic(row + 1, col);
        FillArray2dPic(row, col + 1);
    }
}

// PrintArray2dPic(pic);
// FillArray2dPic (13, 13);
// PrintArray2dPic(pic);

double Factorial(int f)
{
    // 0! = 1;
    // 1! = 1;
    if (f == 0) return 1;
    if (f == 1) return 1;
    else return f * Factorial(f - 1);
}

// void PrintDouble(double fa)
// {
//     while (fa > 0)
//     {
//         double temp = fa;
//         while (temp > 9)
//         {
//             temp /= 10;
//         }
//         Console.Write(Convert.ToInt32(temp % 10));
//         fa /= 10;
//     }
//     Console.WriteLine();
// }

// Console.WriteLine(int.MaxValue);
// Console.WriteLine(double.MaxValue);
// for (int i = 1; i < 40; i++)
// {
//     Console.WriteLine($"{i}! - {Factorial(i)}");
// }

// f(1) = 1;
// f(2) = 1;
// f(n) = f(n-1) + f(n-2)

double Fibonacchi(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacchi(n - 1) + Fibonacchi(n - 2);
}

for (int i = 1; i <= 40; i++)
{
    Console.WriteLine($"f({i}) = {Fibonacchi(i)}");
}