// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int size = 8;
int[] num = new int[size];
FillArray(num);
PrintArray(num);
//System.Console.WriteLine("[{0}]", string.Join(","),num );


void FillArray (int[] num)
{
    for (int i = 0; i < num.Length; i++)
    {
        num[i] = new Random().Next(0,100);

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

