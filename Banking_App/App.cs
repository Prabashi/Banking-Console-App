using System.Diagnostics.CodeAnalysis;
using BankingApp.Controllers;
using static BankingApp.Utils.PromptUtils;

namespace Banking
{
	public class App
	{
        private readonly IBankController bankController;

        public App(IBankController bankController)
		{
            this.bankController = bankController;
        }

        public void Run()
        {
            ShowStartMenu();
            string? selectedMenuItem = PromptForInput();

            if (IsNotNull(selectedMenuItem))
            {
                HandleMenuSelection(selectedMenuItem.ToUpper());
            }
        }

        private void HandleMenuSelection(string selectedMenuItem)
        {
            switch (selectedMenuItem)
            {
                case "T":
                    HandleInputTransaction();
                    break;
                default:
                    break;
            }
        }

        private void HandleInputTransaction()
        {
            ShowInputTransactionPrompt();
            string? transactionInput = PromptForInput();

            if (IsNotNull(transactionInput))
            {
                if (transactionInput.Trim() == "")
                {
                    Run();
                } else
                {
                    // TODO: Implement
                    Console.WriteLine("You have entered: " + transactionInput);
                }
            }

        }

        private static bool IsNotNull([NotNullWhen(true)] string? input)
        {
            return input is not null;
        }
    }
}

