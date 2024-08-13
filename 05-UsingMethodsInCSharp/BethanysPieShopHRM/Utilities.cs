namespace BethanysPieShopHRM
{
    internal class Utilities
    {
        // Method that calculates early wage
        public static int CalculateYearlyWage(int monthlyWage, int numberOfMonthsWorked)
        {
            //Console.WriteLine($"Yearly wage: {monthlyWage * numberOfMonthsWorked}");
            //return monthlyWage * numberOfMonthsWorked;

            if (numberOfMonthsWorked == 12)
                // Add a bonus month
                return monthlyWage * (numberOfMonthsWorked + 1);

            return monthlyWage * numberOfMonthsWorked;
        }

        // Method Overloading
        public static int CalculateYearlyWage(int monthlyWage, int numberOfMonthsWorked, int bonus)
        {
            Console.WriteLine($"Your yearly wage is: {monthlyWage * numberOfMonthsWorked + bonus}");
            return monthlyWage * numberOfMonthsWorked + bonus;
        }

        // Method Overloading
        public static double CalculateYearlyWage(double monthlyWage, double numberOfMonthsWorked, double bonus)
        {
            Console.WriteLine($"Your yearly wage is: {monthlyWage * numberOfMonthsWorked + bonus}");
            return monthlyWage * numberOfMonthsWorked + bonus;
        }

        // Using optional parameters
        public static int CalculateYearlyWageWithOptional(int monthlyWage, int numberOfMonthsWorked, int bonus = 0)
        {
            Console.WriteLine($"Your yearly wage is: {monthlyWage * numberOfMonthsWorked + bonus}");
            return monthlyWage * numberOfMonthsWorked + bonus;
        }

        public static void UsingOptionalParameters()
        {
            int monthlyWage1 = 1234;
            int months1 = 12;

            int yearlyWageForEmployee1 = CalculateYearlyWageWithOptional(monthlyWage1, months1);
            Console.WriteLine($"Yearly wage for employee 1 (Bethany): {yearlyWageForEmployee1}");
        }

        public static int CalculateYearlyWageWithNamed(int monthlyWage, int numberOfMonthsWorked, int bonus)
        {
            Console.WriteLine($"Your yearly wage is: {monthlyWage * numberOfMonthsWorked + bonus}");
            return monthlyWage * numberOfMonthsWorked + bonus;
        }

        public static void UsingNamedArguments()
        {
            int amount = 1234;
            int months = 12;
            int bonus = 500;

            int yearlyWageForEmployee = CalculateYearlyWageWithOptional(bonus: bonus, monthlyWage: amount, numberOfMonthsWorked: months);

            Console.WriteLine($"Yearly wage for employee (Bethany): {yearlyWageForEmployee}");
        }
    }
}
