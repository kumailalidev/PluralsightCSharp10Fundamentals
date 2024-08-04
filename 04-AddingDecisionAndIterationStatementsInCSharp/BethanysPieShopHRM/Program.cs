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

Console.WriteLine("Using if Statements");
Console.WriteLine("###########################################################################################");
Console.WriteLine();