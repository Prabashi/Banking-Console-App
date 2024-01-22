using System;
namespace BankingApp.Utils
{
	public static class PromptUtils
	{
        private static readonly string WelcomeText = "Welcome to AwesomeGIC Bank! What would you like to do?";
        private static readonly string InputTransactionMenuText = "[T] Input transactions";
        private static readonly string InputInterestRuleMenuText = "[I] Define interest rules";
        private static readonly string PrintStatementMenuText = "[P] Print statement";
        private static readonly string QuitText = "[Q] Quit";

        private static readonly string GetInputText = "> ";

        private static readonly string InputTransactionText = "Please enter transaction details in <Date> <Account> <Type> <Amount> format " +
            "\n(or enter blank to go back to main menu):";



        public static void ShowStartMenu()
		{
            Console.WriteLine(WelcomeText);
            Console.WriteLine(InputTransactionMenuText);
            Console.WriteLine(InputInterestRuleMenuText);
            Console.WriteLine(PrintStatementMenuText);
            Console.WriteLine(QuitText);
        }

        public static string? PromptForInput()
        {
            Console.Write(GetInputText);
            string? userInput = Console.ReadLine();

            return userInput;
        }

        public static void ShowInputTransactionPrompt()
        {
            Console.WriteLine(InputTransactionText);
        }
    }
}

