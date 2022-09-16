//Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
Console.Write("Enter number of array elements = ");
int size = int.Parse(Console.ReadLine());
double[] array = new double[size];
FillArray(array);
PrintArray(array);
MinMax(array);

double MinMax(double[] array)
{
double odds = 0;
double max = array[0];
double min = array[0];
for (int i = 0; i < array.Length; i++)
{
if (array[i]>max)
max=array[i];
if (array[i]<min)
min=array[i];
} 
odds = max-min;
System.Console.Write(" min = "+min);
System.Console.WriteLine(" max = "+max);
System.Console.WriteLine("Difference between max min = "  +odds);
return max;
return min;
return odds;
}





void FillArray (double[] num)
{
    for (int i = 0; i < num.Length; i++)
    {
        num[i] = Convert.ToDouble(Console.ReadLine());

    }
}
void PrintArray(double[] num)
{
    System.Console.Write("[ ");
   for (int i = 0; i < num.Length; i++)
   {
      Console.Write(num[i]+", ");
   }    
 System.Console.Write("]");
}
