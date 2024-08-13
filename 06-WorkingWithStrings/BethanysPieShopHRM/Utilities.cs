namespace BethanysPieShopHRM
{
    internal class Utilities
    {
        public static void UsingSimpleStrings()
        {
            string firstName = "Bethany";
            string lastName = "Smith";
            string s;
            s = firstName;
            var userName = "BethanyS";
            userName = userName.ToLower();
            userName = ""; // Identical to string.Empty
        }
    }
}
