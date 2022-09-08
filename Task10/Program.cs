internal class Program
{
    private static void Main(string[] args)
    {
        int n;
        n = 3;
        // Объявим одномерный массив Data с n-элементами 
        int[] Data = new int[n];
        int i = 0;
        Console.WriteLine("Enter the three-degree number ");
        while (i < n)
        {
            Data[i] = Convert.ToInt32(Console.ReadLine());
            i++;
        }
        Console.WriteLine("Second number" + Data[1]);
    }
}