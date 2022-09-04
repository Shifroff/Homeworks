// Maximum of three numbers from three lines

Console.WriteLine("Enter three numbers");
Console.Write("Enter a1=");
int VariableA = Int32.Parse(Console.ReadLine()); 
Console.Write ("Enter b1=");
int VariableB = Int32.Parse(Console.ReadLine()); 
Console.Write ("Enter c1=");
int VariableC = Int32.Parse(Console.ReadLine());

int max = VariableA;
if (VariableA > max) max = VariableA;
if (VariableB > max) max = VariableB;
if (VariableC > max) max = VariableC;

Console.WriteLine(max);

Console.WriteLine("Enter another three numbers");
Console.Write("Enter a2=");
int VariableSecondA = Int32.Parse(Console.ReadLine()); 
Console.Write ("Enter b2=");
int VariableSecondB = Int32.Parse(Console.ReadLine()); 
Console.Write ("Enter c2=");
int VariableSecondC = Int32.Parse(Console.ReadLine());

int max1 = VariableSecondA;
if (VariableSecondA > max1) max1 = VariableSecondA;
if (VariableSecondB > max1) max1 = VariableSecondB;
if (VariableSecondC > max1) max1 = VariableSecondC;

Console.WriteLine(max1);

Console.WriteLine("Enter last three numbers");
Console.Write("Enter a3=");
int VariableThirdA = Int32.Parse(Console.ReadLine()); 
Console.Write ("Enter b3=");
int VariableThirdB = Int32.Parse(Console.ReadLine()); 
Console.Write ("Enter c3=");
int VariableThirdC = Int32.Parse(Console.ReadLine());

int max2 = VariableThirdA;
if (VariableThirdA > max2) max2 = VariableThirdA;
if (VariableThirdB > max2) max2 = VariableThirdB;
if (VariableThirdC > max2) max2 = VariableThirdC;

Console.WriteLine(max2);

int maximum = max;
if (max > maximum) maximum = max;
if (max1 > maximum) maximum = max1;
if (max2 > maximum) maximum = max2;

Console.Write("max=");
Console.WriteLine(maximum);
