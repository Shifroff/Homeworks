// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.


Console.Write("Enter number of array elements = ");
int size = int.Parse(Console.ReadLine());
int[] array = FillArray(size);


System.Console.WriteLine("[{0}]", string.Join(", ", array));

int counter = 0;
for (int i = 0; i < size; i++)
{
    int num = array[i]; 
    if (num%2==0)
    {
        counter++;
    }
}
System.Console.Write("Number of even numbers counter = ");
System.Console.WriteLine(counter);
int[] FillArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
       Console.Write("Enter three-degree number = "); 
       array[i] = int.Parse(Console.ReadLine());
       int n = array[i];
       if (  999 > n&&n < 100)
       {
        System.Console.WriteLine("Incorrect massive");
        break;
       }
    } 
    return array;
}


//                                       "Array output"
//                                         
// void PrintArray(int[] num)
// {
//     System.Console.Write("[ ");
//    for (int i = 0; i < num.Length; i++)
//    {
//       Console.Write(num[i]+", ");
//    }    
//  System.Console.Write("]");
// }
