internal class Program
{
    private static void Main(string[] args)
    {
        string userString = "";

        //Цикл с постусловием
        do
        {
            //Приглашение пользователю
            Console.Write("Enter number: ");

            /*
            * Получение веденной с клавиатуры строки,
            * введенная строка сохраняется в переменную userString
            */
            userString = Console.ReadLine();

            //Вывод введенной строки
            Console.WriteLine("Our number: " + userString);
            if (userString.Length < 3)
        {
            Console.WriteLine("Element missing");

        }
        else
        {
          char chr = userString[3];
          Console.WriteLine("",chr); 
        }
       
            }    while (userString != "Exit");
    }
}
       