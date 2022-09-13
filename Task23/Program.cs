// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
System.Console.WriteLine("Enter number");
int number = int.Parse(Console.ReadLine());
int length = number;
for (int i = 1; i < length+1; i++)
{ 
  System.Console.WriteLine($"{i}x{i}x{i}={i*i*i}");  
}