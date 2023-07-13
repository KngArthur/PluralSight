// See https://aka.ms/new-console-template for more information


Console.WriteLine("Welcome to Bethany's Pie Shop HRM");

// Console.WriteLine("Please enter your name: ");

// string name = Console.ReadLine();

// string name2 = Console.ReadLine();

// int monthlyWage = 1234;

// int months = 12, bonus = 1000;

// bool isActive = true;

// double rating = 99.25;

// byte numberOfEmployees = 300;

// int hoursWorked;

// hoursWorked = 125;

// hoursWorked = 148;

// monthlyWage = true;

// const double interestRate = 0.07;

// string firstName = "Bethany";
// string lastName = "";

// Console.WriteLine("Please enter your name");
// string name = Console.ReadLine();

// int intMaxValue = int.MaxValue;
// int intMinValue = int.MinValue;

// char userSelection = 'a';
// char upperVersion = char.ToUpper(userSelection);

// bool isDigit = char.IsDigit(userSelection);

// bool isLetter = char.IsLetter(userSelection);


//DateTime hireDate = new DateTime(2022, 3, 28, 14, 30, 0);
//Console.WriteLine("Hire Date: " + hireDate);

//DateTime exitDate = new DateTime(2025, 12, 11);
//Console.WriteLine("Exit Date: " + exitDate);

//DateTime startDate = hireDate.AddDays(15);
//Console.WriteLine("Start Date: " + startDate);

//DateTime currentDate = DateTime.Now;
//bool areWeInDaylightSavings = currentDate.IsDaylightSavingTime();

//DateTime startHour = DateTime.Now;
//TimeSpan workTime = new TimeSpan(8, 35, 0);
//DateTime endHour = startHour.Add(workTime);

//Console.WriteLine("Start Time: " + startHour.ToLongDateString());
//Console.WriteLine("End Time: " + endHour.ToShortTimeString());

//Console.ReadLine();

Console.WriteLine("Enter the age of the new candidate: ");
int age = int.Parse(Console.ReadLine());

//if (age < 18)
//{
//    Console.WriteLine("Too young to apply.");
//    Console.WriteLine("Send Email to candidate.");
//}
//else
//{
//    Console.WriteLine("Great, you can now start with the application.");
//}

//DateTime today = DateTime.Now;
//bool endOfMothPaymentStarted = false;

//if (today.Date.Day == 20)
//{
//    Console.WriteLine("Please start end-of-month employee payments");
//}
//else if (today.Date.Day >= 25 && !endOfMothPaymentStarted)
//{
//    Console.WriteLine("Payments will be late!!");
//}

switch (age)
{
    case < 18:
    case > 65:
        Console.WriteLine("Sorry, your age is not within the range we are looking for");
        break;
    case 23:
        Console.WriteLine("Wow, exacly what we are looking for");
        break;
    default: 
        Console.WriteLine("Great, you can now start the application!");
        break;
}

Console.WriteLine("Choose the action you want to do: ");
Console.WriteLine("1. Add employee");
Console.WriteLine("2. Update employee");
Console.WriteLine("3. Delete employee");
string selectedAction = Console.ReadLine();

switch (selectedAction)
{
    case "1":
        Console.WriteLine("Adding new employee...");
        break;
    case "2": 
        Console.WriteLine("Updating employee...");
        break;
    case "3":
        Console.WriteLine("Deleting employee...");
        break;
    default:
        Console.WriteLine("Invalid input");
        break;
}