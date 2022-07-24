int rows = 3;
int columns = 4;
int[,] array = new int[rows, columns];
FillArray(array);
PrintArray(array);
Console.WriteLine("Отсортированный массив:");
Sorting(array);
PrintArray(array);




void Sorting(int[,] array)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < columns - j - 1; k++)
            {
                if (array[i,k] < array[i, k+1])
                {
                    int temp = array[i,k];
                    array[i,k] = array[i, k+1];
                    array[i, k+1] = temp;
                }
            }
        }
    }
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