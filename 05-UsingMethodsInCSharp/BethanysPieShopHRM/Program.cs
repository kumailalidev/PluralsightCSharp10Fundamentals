using BethanysPieShopHRM;

Console.WriteLine("05. Using Methods in C#");
Console.WriteLine("###########################################################################################\n");

Console.WriteLine("Creating and Using Methods");
Console.WriteLine("###########################################################################################\n");

int amount = 1234;
int months = 12;

int yearlyWage = Utilities.CalculateYearlyWage(amount, months);

Console.WriteLine($"Yearly wage: {yearlyWage}");
