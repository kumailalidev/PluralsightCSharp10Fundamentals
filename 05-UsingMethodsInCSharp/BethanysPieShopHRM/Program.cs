Console.WriteLine("05. Using Methods in C#");
Console.WriteLine("###########################################################################################\n");

Console.WriteLine("Creating and Using Methods");
Console.WriteLine("###########################################################################################\n");

int amount = 1234;
int months = 12;

int yearlyWage = CalculateYearlyWage(amount, months);

Console.WriteLine($"Yearly wage: {yearlyWage}");

// Method that calculates early wage
static int CalculateYearlyWage(int monthlyWage, int numberOfMonthsWorked)
{
    //Console.WriteLine($"Yearly wage: {monthlyWage * numberOfMonthsWorked}");
    //return monthlyWage * numberOfMonthsWorked;

    if (numberOfMonthsWorked == 12)
        // Add a bonus month
        return monthlyWage * (numberOfMonthsWorked + 1);

    return monthlyWage * numberOfMonthsWorked;
}