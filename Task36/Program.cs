 //Задайте одномерный массив, заполненный случайными числами. 
 //Найдите сумму элементов, стоящих на нечётных позициях.



Console.Write("Enter number of array elements = ");
int size = int.Parse(Console.ReadLine());
int[] array = new int[size];
FillArray(array);
PrintArray(array);


bool m = true;
int summ = 0;
for (int i = 0; i < array.Length; i++)
{
if (i%2==0)
    summ = summ + array[i];
else
    m = false;
} 
System.Console.WriteLine(" sum "+summ);




void FillArray (int[] num)
{
    for (int i = 0; i < num.Length; i++)
    {
        num[i] = new Random().Next(0,100);;

    }
}
void PrintArray(int[] num)
{
    System.Console.Write("[ ");
   for (int i = 0; i < num.Length; i++)
   {
      Console.Write(num[i]+", ");
   }    
 System.Console.Write("]");
}
