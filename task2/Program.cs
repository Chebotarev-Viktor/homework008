Console.WriteLine("Введите размер массива: ");
int a = int.Parse(Console.ReadLine());
int[,] myArray = new int[a, a];
RandomNumbersArray(myArray);
PrintArray(myArray);
int minsum = Int32.MaxValue;    
int indexLine = 0;

for (int i = 0; i < myArray.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < myArray.GetLength(1); j++)
    {
        sum = sum + myArray[i, j];        
    }
    if (sum < minsum)
    {
        minsum = sum;
        indexLine++;
    }
}

Console.WriteLine("Номер строки с наименьшей суммой элементов: " + (indexLine));

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