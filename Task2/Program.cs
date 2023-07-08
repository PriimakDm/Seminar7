/*
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
*/
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

void Print2DArrey(int [,] arrey2D)
{
    Console.WriteLine("Enter the first position of the element: ");
    int firstPos = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the second position of the element: ");
    int secondPos = Convert.ToInt32(Console.ReadLine());

    if (firstPos <= arrey2D.GetLength(0) && secondPos <= arrey2D.GetLength(0))
    {
        Console.WriteLine("Value of your element: " + arrey2D[(firstPos-1), (secondPos-1)]);
    }

    else    Console.WriteLine("No such element");

}

int [,] newArrey = Create2DArrey();
PrintArrey (newArrey);
Print2DArrey (newArrey);


