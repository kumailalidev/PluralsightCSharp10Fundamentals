Console.WriteLine("05. Using Methods in C#");
Console.WriteLine("###########################################################################################\n");

Console.WriteLine("\nCreating and Using Methods");
Console.WriteLine("###########################################################################################\n");

int amount = 1234;
int months = 12;

CalculateYearlyWage(amount, months);

// Method that calculates early wage
static void CalculateYearlyWage(int monthlyWage, int numberOfMonthsWorked)
{
    Console.WriteLine($"Yearly wage: {monthlyWage * numberOfMonthsWorked}");
}