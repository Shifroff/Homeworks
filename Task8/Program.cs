internal class Program
{
    private static void Main(string[] args)
    {
        // Show all even numbers
        Console.Write("Enter the number:");
        int Number = int.Parse(Console.ReadLine());
        int i = 0;
        int EvenNumber = 0;
        if (Number % 2 == 0)
            while (i < Number)
            {
                EvenNumber = i + 2;
                Console.Write(EvenNumber);
                Console.Write("  ");
                i = i + 2;

            }
        else
            while (i < Number - 1)
            {
                EvenNumber = i + 2;
                Console.Write(EvenNumber);
                Console.Write("  ");
                i = i + 2;
                               
                 
            }



        Console.WriteLine("   Even Numbers");
    }
}