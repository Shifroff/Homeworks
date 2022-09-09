
public enum WeekDays 
{
  Monday = 1,
  Tuesday =2,
  Wednesday =3,
  Thursday = 4,
  Friday = 5,
  Saturday = 6,
  Sunday = 7,


};
  class Program
{
     public static void Main(string[] args)
     {
         Console.Write( "Enter number of the WeekDay:" );
         var n = int.Parse(Console.ReadLine());
         if (n < 6)
         {
           Console.WriteLine((WeekDays)((n) % Enum.GetValues(typeof(WeekDays)).Length)); 
           Console.WriteLine("Working day");
         }
         else
         {
          Console.WriteLine((WeekDays)((n) % Enum.GetValues(typeof(WeekDays)).Length)); 
          Console.WriteLine("Weekend");  
         }
     }
}
