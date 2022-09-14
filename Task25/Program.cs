// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.


Console.WriteLine("Hello, World!");

int num1 = Prompt("Enter number one = ");
int num2 = Prompt("Enter number two = "); 
double result = Math.Pow(num1, num2);
Console.WriteLine($"{num1}^{num2} = {result}");

int Prompt (string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    return Convert.ToInt32(value);
}