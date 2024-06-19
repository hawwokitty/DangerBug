namespace DangerBug
{
    internal static class ConsoleLines
    {
        public static void PrintToConsole(this string message)
        {
            Console.WriteLine(message);
        }

        public static string RequestString(this string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }

        public static int RequestInt(this string message)
        {
            Console.WriteLine(message);
            bool IsANumber = false;
            int choice = 0;
            while (!IsANumber)
            {
                IsANumber = int.TryParse(Console.ReadLine(), out choice);
            }
            return choice;
        }

        public static bool RequestBool(this string message)
        {
            string userInput = "";
            bool isBool = false;
            while (userInput.ToLower() != "true" && userInput.ToLower() != "false")
            {
                userInput = "Skriv true/false".RequestString();
                if (userInput == "true") {  isBool = true; }
                else if (userInput == "false") {  isBool = false; }
            }
            return isBool;
        }
    }
}
