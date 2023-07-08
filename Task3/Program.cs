// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
int [,] Create2DArrey ()
{
    Console.WriteLine("Enter count of rows: ");
    int userRows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter count of collumns: ");
    int userColls = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter min possible value: ");
    int userMin = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter max possible value: ");
    int userMax = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    int [,] created2DArrey = new int [userRows, userColls];

    for (int i = 0; i < userRows; i++)
    {
        for (int j = 0; j < userColls; j++)
        {
            created2DArrey[i,j] = new Random().Next(userMin, userMax + 1);
        }
    }
    return created2DArrey;
}

void PrintArrey(int [,] arrey)
{
    for (int i = 0; i <  arrey.GetLength(0); i++)
    {
        for (int j = 0; j < arrey.GetLength(1); j++)
        {
            Console.Write(arrey[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void PrintArif(int [,] arreyAr)
{
    
    for (int j = 0; j < arreyAr.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < arreyAr.GetLength(0); i++)
        {
            sum = (arreyAr[i, j] + sum);
        }
        double arif = sum / arreyAr.GetLength(0);
        Console.Write(arif + " ");
    }
}

int [,] newArrey = Create2DArrey();
PrintArrey (newArrey);
PrintArif (newArrey);
