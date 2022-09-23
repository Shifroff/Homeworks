internal partial class Program
{
    private static void Main(string[] args)
    {
        // Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
        
        Console.Write("Enter number of array elements = ");
        int size = int.Parse(Console.ReadLine());
        double[] array = new double[size];
        FillArray(array);
        PrintArray(array);
        Positive(array);

        int Positive(double[] num)
        {
            int count = 0;

            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] > 0)
                    count++;
            }
            System.Console.Write(" Positive = " + count);
            return count;
        }





        void FillArray(double[] num)
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
                Console.Write(num[i] + ", ");
            }
            System.Console.Write("]");
        }
    }
}