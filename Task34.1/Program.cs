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
       array[i] = new Random().Next(99,1000);
    } 
    return array;
}
