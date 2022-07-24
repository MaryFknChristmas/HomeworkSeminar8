int rows = 4;
int columns = 4;
int[,] array = new int[rows, columns];
FillArray(array);
PrintArray(array);
FindingSum(array);

void FindingSum(int[,] array)
{
    int sumMin = 0;
    int sumMinIndex = 0;
    for (int j = 0; j < columns; j++)
    {
        sumMin += array[0, j];
    }
   
    for (int i = 1; i<rows; i++)
    {
        int sum = 0;
        for (int j = 0; j<columns; j++)
        {
            sum += array[i,j];
        }

        if (sum < sumMin)
        {
            sumMin = sum;
            sumMinIndex = i;
        }
    }

    Console.WriteLine($"Номер строки с наименьшей суммой элементов: {sumMinIndex+1}");

}

void FillArray(int[,] array)
{
    Random random = new Random();
    for (int i = 0; i<rows; i++)
{
    for (int j = 0; j<columns; j++)
    {
        array[i,j] = random.Next(1, 10);
    }
}
}

void PrintArray(int[,] array)
{
for (int i = 0; i<rows; i++)
{
    for (int j = 0; j<columns; j++)
    {
        Console.Write(array[i,j] + "\t");
    }
    Console.WriteLine();
}
}