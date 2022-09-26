// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.


int n = Prompt("Number of lines = ");
int m = Prompt("Number of columns = ");


int [,] matrix = new int[n,m];
FillMatrix(matrix);
Console.WriteLine();
PrintMatrix(matrix);
Average(matrix);

void FillMatrix( int [,] matrix)
{
    for (int i = 0; i < n ; i++)
    
    {
        for (int j = 0; j <  m ; j++)
        {
             matrix[i,j] = Convert.ToInt32(Console.ReadLine());

        }
        
    }
}

void PrintMatrix(int[,] matrix)
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

void Average(int[,] matrix)
  {
    double[]sum=new double[m];
    
    for (int i = 0; i < m; i++)
    { 
       for (int j = 0; j < n; j++)         // matrix[j,i] - работа со столбиками 
        {
            sum[i] += matrix[j,i];
           
        }
    }
    for (int i = 0; i < m; i++)
    {
        Console.WriteLine(sum[i]/n + " "); 
    }
  
  }