Console.Write("Enter a number to Check Palindrome : ");
string number = Console.ReadLine();
string reverse = string.Empty;
            
for (int i = number.Length - 1; i >= 0; i--)
{
    reverse = reverse+number[i];
}
            
if (number == reverse)
{
    Console.WriteLine($"{number} is Palindrome.");
}
else
{
        Console.WriteLine($"{number} is not Palindrome");
}
