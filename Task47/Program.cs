// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.


int n = Prompt("Number of lines = ");
int m = Prompt("Number of columns = ");

//double lowerBound = Prompt("lowerBound = ");     // Задаём нижний и верхний пределы выборки случайных
//double upperBound = Prompt("upperBound = ");     // вещественных чисел

double[,] matrix = new double[n,m];
FillMatrix(matrix);
Console.WriteLine();
PrintMatrix(matrix);

void FillMatrix( double[,] matrix)
{
    var random = new Random();
    for (int i = 0; i < n ; i++)
    
    {
        for (int j = 0; j <  m ; j++)
        {
             matrix[i,j] = random.NextDouble()*100;

            //matrix[i,j] = GetPseudoDoubleWithinRange(lowerBound,upperBound);
        }
        
    }
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            Console.Write("{00:F2} ", matrix[i,j]);
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

// Метод для случайных вещественных чисел заданного диапазона

// double GetPseudoDoubleWithinRange(double lowerBound, double upperBound)     
// {
//     var random = new Random();
//     var rDouble = random.NextDouble();
//     var rRangeDouble = rDouble * (upperBound - lowerBound) + lowerBound;
//     return rRangeDouble;
    
// }