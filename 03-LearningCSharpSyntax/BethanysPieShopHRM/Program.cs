Console.WriteLine("Welcome to Bethany's Pie Shop HRM");

//Console.WriteLine("Please enter your name: ");

// Valid identifiers
// ###########################################################################################

//string name = Console.ReadLine();
//string name2 = Console.ReadLine();
//string Name = Console.ReadLine(); // C# is case sensitive
//string Name_2 = Console.ReadLine();

// Invalid identifiers
// ###########################################################################################

// string 1Name = Console.ReadLine();

// Comments
// ###########################################################################################

// Single statement comment

/*
 * Multiline comments
 * ....
*/

// Primitive Types
// ###########################################################################################

// 32-bit signed integer
//int monthlyWage = 400;
//int month = 3, bonus = 300;

// bool
//bool isActive = true;

// byte 8-bit unsigned integer
//byte numberOfEmployees = 255;

// double
//double rating = 4.93;

// Type safety; Once a variable is declared its type can not be changed
// isActive = "false";

// Using const values
// ###########################################################################################

//const double interestRate = 0.07; // OR const decimal interestRate = 0.07m;

//interestRate = 0.06; // Error

// Creating strings
// ###########################################################################################

//string firstName = "John";
//string lastName = "Doe";
//string emptyString = "";

//Console.WriteLine("Please enter your name: ");
//string name = Console.ReadLine();

// *) Using Operators in C#
// ###########################################################################################

// Arithmetic Operators
// ###########################################################################################

//int bonus = 1000;
//int numberOfHoursWorked = 165;
//double ratePerHour = 12.34;

//double currentMonthWage = numberOfHoursWorked * ratePerHour + bonus;
//Console.WriteLine(currentMonthWage);

// Compound Operator
// ###########################################################################################

//currentMonthWage += 3; // Same as currentMonthWage = currentMonthWage + 3
//Console.WriteLine(currentMonthWage);

// Comparison Operator
// ###########################################################################################

//if (currentMonthWage > 2000)
//    Console.WriteLine("Top Employee!");

// Increment/Decrement Operator
// ###########################################################################################

//currentMonthWage++; // Similarly currentMonthWage--

// Default values of Primitive types
// ###########################################################################################

//int a; // 0
//bool b; // false

// *) Working with Members on Primitive Types
// ###########################################################################################

// int
// ###########################################################################################

//int intMaxValue = int.MaxValue;
//Console.WriteLine(intMaxValue);
//int intMinValue = int.MinValue;
//Console.WriteLine(intMinValue);

// char
// ###########################################################################################

//char userSelection = 'a';
//char upperVersion = char.ToUpper(userSelection);

//bool isDigit = char.IsDigit(upperVersion);
//bool isLetter = char.IsLetter(upperVersion);

// *) Working with DateTime
// ###########################################################################################

DateTime hireDate = new DateTime(2024, 1, 1, 12, 0, 0, 0);
Console.WriteLine("hireDate: " + hireDate.ToString());

DateTime endDate = new DateTime(2024, 2, 18);
Console.WriteLine("endDate: " + endDate.ToString());

DateTime startDate = hireDate.AddDays(15);
Console.WriteLine("startDate: " + startDate.ToString());

DateTime currentDate = DateTime.Now;
Console.WriteLine("currentDate: " + currentDate.ToString());

// Timestamp
// ###########################################################################################

DateTime startHour = DateTime.Now;
Console.WriteLine("startHour: " + startHour);

TimeSpan workTime = new TimeSpan(9, 45, 0);
Console.WriteLine("workTime: " + workTime);

DateTime endHour = startHour.Add(workTime);
Console.WriteLine("endHour: " + endHour);

// Date time representation
// ###########################################################################################

Console.WriteLine("Long date: " + endHour.ToLongDateString());
Console.WriteLine("Short time: " + endHour.ToShortTimeString());

// *) Converting Between Types
// ###########################################################################################

int numberOfHoursWorked = 165;
long veryLongNumber = numberOfHoursWorked; // No errors will thrown by compile during implicit conversion, long > int

double doubleNumber = 9999999.9;
Console.WriteLine("doubleNumber: " + doubleNumber);

int intToDouble = (int)doubleNumber; // Can not be converted implicitly because int < double. Explicit conversion is done using type cast operator
Console.WriteLine("intToDouble: " + intToDouble);

// *) Using var
// ###########################################################################################

Console.WriteLine("*) Using var");
Console.WriteLine("// ###########################################################################################");

var number = 1;
var dateTime = DateTime.Now;