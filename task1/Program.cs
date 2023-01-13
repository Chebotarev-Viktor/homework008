Console.WriteLine("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine());
int[,] myArray = new int[rows, columns];
RandomNumbersArray(myArray);
Console.WriteLine();
Console.WriteLine("Массив: ");
PrintArray(myArray);

for (int i = 0; i < myArray.GetLength(0); i++)
{
    for (int j = 0; j < myArray.GetLength(1) - 1; j++)
    {
        for (int z = 0; z < myArray.GetLength(1) - 1; z++)
        {
            if (myArray[i, z] < myArray[i, z + 1]) 
            {
                int temp = 0;
                temp = myArray[i, z];
                myArray[i, z] = myArray[i, z + 1];
                myArray[i, z + 1] = temp;
            }
        }
    }
}
Console.WriteLine();
Console.WriteLine("Упорядоченный массив: ");
PrintArray(myArray);

void RandomNumbersArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

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