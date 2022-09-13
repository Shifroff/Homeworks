//Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.

int Prompt (string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    return Convert.ToInt32(value);
}
double distance = 0;
int x1 = Prompt("Enter x1 ");
int y1 = Prompt("Enter y1 ");
int z1 = Prompt("Enter z1 ");
int x2 = Prompt("Enter x2 ");
int y2 = Prompt("Enter y2 ");
int z2 = Prompt("Enter z2 ");
distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) +Math.Pow(z2 - z1,2));
Console.WriteLine($"Distance between points is {distance}");
