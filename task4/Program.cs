int s1 = InputInt("Введите размерность 1: ");
int s2 = InputInt("Введите размерность 2: ");
int s3 = InputInt("Введите размерность 3: ");
int count = 99;

if (s1 * s2 * s3 > count)
{
    Console.Write("Массив слишком большой");
    return;
}

int[,,] res = Masive3D(s1, s2, s3);

for (int i = 0; i < res.GetLength(0); i++)
{
    for (int j = 0; j < res.GetLength(1); j++)
    {
        for (int k = 0; k < res.GetLength(2); k++)
        {
            Console.Write($"  {res[i, j, k]}({i},{j},{k})");
        }
        Console.WriteLine();
    }
}
int[,,] Masive3D(int z1, int z2, int z3)
{
    int[,,] array = new int[z1, z2, z3];
    int[] v = new int[count];
    int num
     = 10;
    for (int i = 0; i < v.Length; i++)
        v[i] = num
        ++;

    for (int i = 0; i < v.Length; i++)
    {
        int random = new Random().Next(0, v.Length);
        int temp = v[i];
        v[i] = v[random];
        v[random] = temp;
    }

    int vIndex = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = v[vIndex++];
            }
        }
    }
    return array;
}

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}