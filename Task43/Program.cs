// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
double b1 = Prompt(" b1 =");
double k1 = Prompt(" k1 =");
double b2 = Prompt(" b2 =");
double k2 = Prompt(" k2 =");
IntersectionPoint(b1,b2,k1,k2);


int Prompt (string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    return Convert.ToInt32(value);
}
void IntersectionPoint(double b1, double k1, double b2, double k2)
{
double x,y;
if( k1==k2)
 System.Console.WriteLine("Lines are parallel");

else
{
x = (b2-b1)/(k1-k2);
y =(k1*(b2-b1))/((k1-k2)+b2);
System.Console.WriteLine("x="+x+"y="+y);
}
if(k1==k2)                            // if ((k1==k2)&&(b1==b2))
System.Console.WriteLine("Lines coincide");
if(b1==b2)
System.Console.WriteLine("Lines coincide"); 
}