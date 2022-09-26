// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
int n = Prompt("Number of lines = ");
int m = Prompt("Number of columns = ");
int numberLine = Prompt(" i = ");
int numberColumn = Prompt(" j = ");

double[,] matrix = new double[n,m];
FillMatrix(matrix);
Console.WriteLine();
PrintMatrix(matrix);
ElementValidation(matrix);

void FillMatrix( double[,] matrix)
{
    var random = new Random();
    for (int i = 0; i < n ; i++)
    
    {
        for (int j = 0; j <  m ; j++)
        {
             matrix[i,j] = Convert.ToDouble(Console.ReadLine());

        }
        
    }
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            Console.Write("  "+ matrix[i,j]);
        }
        Console.WriteLine();
    }
}


int Prompt(string message)
{
    Console.Write( message );
    string value = Console.ReadLine();
    return Convert.ToInt32(value);
}

void ElementValidation(double[,] matrix)
  {
    if ( n >numberLine && m > numberColumn)
          Console.WriteLine("Element " + matrix[numberLine,numberColumn]);
    else 
          Console.WriteLine("Element missing");
     

  }
 