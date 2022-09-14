// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.


System.Console.WriteLine("Enter the number");
string S = Console.ReadLine();
int sum = Summ(S);
System.Console.WriteLine(sum);



int Summ (string str)
{
    sum =0;
    for (int i = 0; i < str.Length; i++)
    {
        sum = sum + Convert.ToInt32(Convert.ToString(str[i])); 
    }
return sum;
} 