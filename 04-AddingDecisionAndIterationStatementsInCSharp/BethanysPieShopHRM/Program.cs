Console.WriteLine("Working with Relational Operators");
Console.WriteLine("###########################################################################################");
Console.WriteLine();

int age = 23;
bool a = age == 23;
Console.WriteLine("Age is 23: " + a);

bool b = age > 23;
Console.WriteLine("Age is greater than 23: " + b);

bool c = (age >= 18) && (age <= 65);
Console.WriteLine("Age is between 18 and 65: " + c);

// Logical AND
int age1 = 16;
int age2 = 64;
bool d = (age1 >= 18) && (age2 <= 65);
Console.WriteLine("age1 is greater than 18 AND age2 is less than 65: " + d);

// Logical OR
bool e = (age1 >= 18) || (age2 <= 65);
Console.WriteLine("age2 is greater than 18 OR age2 is less than 65: " + e);

Console.WriteLine();
Console.WriteLine("Using if Statements");
Console.WriteLine("###########################################################################################");
Console.WriteLine();

// Example 1
Console.WriteLine("Enter the age of the new candidate: ");
int age4 = int.Parse(Console.ReadLine());

if (age4 < 18)
{
    Console.WriteLine("Too young to apply");
}
else if (age4 > 65)
{
    Console.WriteLine("Sorry, the selected age is too old");
}
else
{
    Console.WriteLine("Great, you can now start with the application!");
}

// Example 2
DateTime today = DateTime.Now;
bool endOfMonthPaymentStarted = false;

if (today.Date.Day == 20)
    Console.WriteLine("Please start end-of-month payments");
else if (today.Date.Day >= 25 && !endOfMonthPaymentStarted)
    Console.WriteLine("Payments will be late");
// else isn't required

Console.WriteLine();
Console.WriteLine("Using the switch Statement");
Console.WriteLine("###########################################################################################");
Console.WriteLine();

// Example 1

switch (age4)
{
    case < 18:
    case > 65:
        Console.WriteLine("Sorry, your age is not within the range we are looking for");
        break;
    case 23:
        Console.WriteLine("Wow, exactly what we are looking for");
        break;
    default:
        Console.WriteLine("Great, you can now start with the application!");
        break;
}

// Example 2

string selectedAction = string.Empty;
do // Code is executed first, condition is checked after
{
    Console.WriteLine("\nChoose the action you want to do: ");
    Console.WriteLine("1. Add employee");
    Console.WriteLine("2. Update employee");
    Console.WriteLine("3. Delete employee");
    Console.WriteLine("99. Exit Application");
    selectedAction = Console.ReadLine();

    switch (selectedAction)
    {
        case "1":
            Console.WriteLine("Adding a new employee");
            break;
        case "2":
            Console.WriteLine("Updating employee");
            break;
        case "3":
            Console.WriteLine("Deleting employee");
            break;
        default:
            Console.WriteLine("Invalid input");
            break;
    }
} while (selectedAction != "99");

Console.WriteLine("Closing Application...");

Console.WriteLine();
Console.WriteLine("Creating a while Loop");
Console.WriteLine("###########################################################################################");
Console.WriteLine();

// Example

Console.WriteLine("Enter a value: ");
int max = int.Parse(Console.ReadLine());

int i = 0;
while (i < max) // Condition is checked before execution
{
    Console.WriteLine(i);
    i++;
}
Console.WriteLine("Loop finished!");

// Nested Loop

i = 0;
int j = 0;

while (i < 10)
{
    while (j < 10)
    {
        Console.WriteLine("i: " + i + " " + "j: " + j);
        j++;
    }
    j = 0;
    i++;
}

// Infinite loop
//while (true)
//    Console.WriteLine(DateTime.Now);

Console.WriteLine();
Console.WriteLine("More Loops");
Console.WriteLine("###########################################################################################");
Console.WriteLine();

int x = 0;
while (x < max) // Condition is checked before execution
{
    Console.WriteLine(x);
    x++;
}
Console.WriteLine($"while loop finished, value is {x}");

// for loop
for (int k = 0; k < max; k++) // Condition is checked after executing loop body
{
    if (k == 5)
    {
        Console.WriteLine("Bingo! " + k + " was found!");
        continue; // Skips remaining body of loop and go to start of the loop
        // break; // Executing of loop will be stopped
    }
    Console.WriteLine(k); // 5 wont be printed to console 
}