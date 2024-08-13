using BethanysPieShopHRM;

Console.WriteLine("05. Using Methods in C#");
Console.WriteLine("###########################################################################################\n");

Console.WriteLine("Creating and Using Methods");
Console.WriteLine("###########################################################################################\n");

int amount = 1234;
int months = 12;

int yearlyWage = Utilities.CalculateYearlyWage(amount, months);

Console.WriteLine($"Yearly wage: {yearlyWage}");

Console.WriteLine("\nUsing Method Overloading");
Console.WriteLine("###########################################################################################\n");

int bonus = 1000;
Utilities.CalculateYearlyWage(amount, months, bonus);

double amountDouble = 1500.0;
double monthsDouble = 12;
double bonusDouble = 1000;

double yearlyWageWithBonusDouble = Utilities.CalculateYearlyWage(amountDouble, monthsDouble, bonusDouble);

Console.WriteLine("\nUsing Optional Parameters and Named Arguments");
Console.WriteLine("###########################################################################################\n");

Utilities.UsingOptionalParameters();
Utilities.UsingNamedArguments();