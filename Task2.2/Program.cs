// Maximum in three lines of numbers
Console.WriteLine("Enter two numbers");
Console.Write("a=");

int a = Int32.Parse(Console.ReadLine()); 
Console.Write ("b=");
int b = Int32.Parse(Console.ReadLine()); 

int max1 = a;
int min1 = a;
if (a > max1) max1 = a;
else min1 =a;   
if (b > max1) max1 = b;
else min1 = b;
Console.Write("max=");
Console.Write(max1);
Console.Write("  min=");
Console.WriteLine(min1);



