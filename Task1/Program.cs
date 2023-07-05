// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
double [,] Create2DArrey ()
{
    Console.WriteLine("Enter count of rows: ");
    int userRows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter count of collumns: ");
    int userColls = Convert.ToInt32(Console.ReadLine());

    double [,] created2DArrey = new double [userRows, userColls];

    for (int i = 0; i < userRows; i++)
    {
        for (int j = 0; j < userColls; j++)
        {
            created2DArrey[i,j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
    return created2DArrey;
}

void Print2DArrey(double [,] arrey2D)
{
    for (int i = 0; i <  arrey2D.GetLength(0); i++)
    {
        for (int j = 0; j < arrey2D.GetLength(1); j++)
        {
            Console.Write(arrey2D[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

double [,] new2DArrey = Create2DArrey();
Print2DArrey (new2DArrey);