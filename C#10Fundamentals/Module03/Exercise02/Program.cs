Console.WriteLine("Enter a first value");

string stringValue1 = Console.ReadLine();

Console.WriteLine("Enter a Second Value");

string stringValue2 = Console.ReadLine();

int intValue1 = int.Parse(stringValue1);
int intValue2 = int.Parse(stringValue2);

var sum = intValue1 + intValue2;

Console.WriteLine("The Total is " + sum);
