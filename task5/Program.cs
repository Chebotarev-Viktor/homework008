onsole.WriteLine("Введите размер массива");
int a = int.Parse(Console.ReadLine());

int[,] z = new int[a, a];

int k = 1;
int i = 0;
int j = 0;

while (k <= a * a)
{
    z[i, j] = k;
    if (i <= j + 1 && i + j < a - 1)
        ++j;
    else if (i < j && i + j >= a - 1)
        ++i;
    else if (i >= j && i + j > a - 1)
        --j;
    else
        --i;
    ++k;
}

PrintArray(z);

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine("");
    }
}
