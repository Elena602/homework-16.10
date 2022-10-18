// Задать двумерный массив следующим правилом: A (mn) = m + n
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = i + j;
        }
    }
}
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i,j]} ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите количество строк (n): ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите количество столбцов (m): ");
int m = int.Parse(Console.ReadLine() ?? "0");
int[,] matrix = new int [n, m];
FillArray(matrix);
PrintArray(matrix);