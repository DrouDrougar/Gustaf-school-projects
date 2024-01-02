using System.Text.Json;

namespace Bankomat_uppgift
{
    public class Bank : Account
    {
        public static List<Account> Accounts = new List<Account>();
        public static List<Account> savedAccounts;
        public static List<Account> TheBank = new List<Account>();
        public static void Menu()
        {
            Console.WriteLine("if it is the first Launch yes/no");
            string firstTimeLaunchQuestion = Console.ReadLine().ToLower();
            switch (firstTimeLaunchQuestion)
            {
                case "yes":
                    FirstStartLoad();
                    SaveMethod();
                    LoadAccounts();
                    break;
                case "no":
                    LoadAccounts();
                    break;
                default:
                    Console.WriteLine("Error input counted as no Loading program");
                    Thread.Sleep(1000);
                    break;
            }
            while (true)
            {
                Console.Clear();
                //The first user input choice, its made to a string and the cases are based on strings, it uses the ToLower method to make sure that the user input does not suffer caps errors.
                Console.WriteLine("Hello User welcome to the ATM\nSee Account:\nAdd Account:\nRemove Account:\nSee All Accounts:\nExit:");
                string userInput = Console.ReadLine().ToLower();
                switch (userInput)
                {
                    case "see account":
                        //to see a specific account
                        SelectAccount();
                        Console.WriteLine("Gonk");
                        break;
                    case "add account":
                        //adds a account
                        AddAccount();
                        break;
                    case "remove account":
                        //to remove an account
                        RemoveAccount();
                        break;
                    case "see all accounts":
                        //shows all the accounts
                        SeeAllAccounts();
                        Console.ReadLine();
                        break;
                    case "exit":
                        //exits the program
                        SaveMethod();
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Gonk");
                        break;
                }
            }
        }
        public static void SelectAccount()
        {
            //a bool to allow the users to back out to the main menu
            bool back = false;
            while (back == !true)
            {    
                Console.Clear();
                Console.WriteLine("Type in the name of the account you wish to see\nBack: ");
                //prints all account holders names
                foreach (var item in Accounts)
                {
                    Console.WriteLine(item.Name);
                }
                string accountName = Console.ReadLine().ToLower();
                if (accountName == "back")
                {
                    back = true;
                }
                while (back == !true)
                {
                    while (back == !true)
                    {
                        Console.Clear();
                        //finds index of the written in name so that the program can find it and use it to select an account.
                        for (int i = 0; i < Accounts.Count; i++)
                        {
                            //if index of a user name is found it then goes into the if, and it can now use the index to do all the functions like withdrawing and depositing money into an account.
                            if (Accounts[i].Name == accountName)
                            {
                                Console.WriteLine(Accounts[i]);
                                Console.WriteLine("What would you like to do\nDeposit:\nWithdraw\nBack:");
                                string userAccountInput = Console.ReadLine().ToLower();
                                switch (userAccountInput)
                                {
                                    //deposits money into the account
                                    case "deposit":
                                        try
                                        {
                                            Console.WriteLine("how much would you like to deposit?");
                                            int depositSum = int.Parse(Console.ReadLine());
                                            if (depositSum > 0)
                                            {
                                                Accounts[i].Sum = Accounts[i].Sum + depositSum;
                                                Console.WriteLine("the changes in the account have been made \n" + Accounts[i]);
                                                Console.ReadLine();
                                            }
                                            else { Console.WriteLine("Sum deposited can't be less than 1"); }
                                        }
                                        catch
                                        {
                                            Console.WriteLine("error input a sum:");
                                            Thread.Sleep(1000);
                                        }
                                        break;
                                    //withdraw money works like deposit money case but with more user error handling.
                                    case "withdraw":
                                        if (Accounts[i].Sum <= 0)
                                        {
                                            Console.WriteLine("error no cash in account, deposit some");
                                            Thread.Sleep(1500);
                                        }
                                        else
                                        {
                                            //try and catch to see that a int number was added and not a string or other variable.
                                            try
                                            {
                                                Console.WriteLine("How much would you like to withdraw?");
                                                int withdrawSum = int.Parse(Console.ReadLine());
                                                //if to check that there is enough money on the account
                                                if (withdrawSum > Accounts[i].Sum)
                                                {
                                                    Console.WriteLine($"error can't withdraw that much\nYour account only contains: {Accounts[i].Sum}\nTry again with a sum with in your range");
                                                    Thread.Sleep(1500);
                                                }
                                                //otherwise withdraw money
                                                else
                                                {
                                                    Accounts[i].Sum = Accounts[i].Sum - withdrawSum;
                                                    Console.WriteLine("the changes in the account have been made \n" + Accounts[i]);
                                                    Console.ReadLine();
                                                }
                                            }
                                            catch (Exception)
                                            {
                                                Console.WriteLine("error input a sum:");
                                                Thread.Sleep(1000);
                                            }
                                        }
                                        break;
                                    //the back case, it takes you back to the main menu.
                                    case "back":
                                        back = true;
                                        break;
                                }
                            }
                        }
                    }
                }
            }
        }
        //simple method to see all the accounts.
        public static void SeeAllAccounts()
        {
            foreach (Account account in Accounts)
            {
                Console.WriteLine(account);
            }
        }
        public static void FirstStartLoad()
        {
            TheBank.Add(new Account { Name = "The Bank", Sum = 0 });
            //Demo list for first time loading of the program.
            Accounts.Add(new Account { Name = "henrik", Sum = 10004 });
            Accounts.Add(new Account { Name = "sven", Sum = 595493 });
            Accounts.Add(new Account { Name = "patrik", Sum = 59425 });
            Accounts.Add(new Account { Name = "carl", Sum = 25525 });
            Accounts.Add(new Account { Name = "ludwig", Sum = 975453 });
            Accounts.Add(new Account { Name = "emma", Sum = 864343 });
            Accounts.Add(new Account { Name = "erik", Sum = 15000 });
            Accounts.Add(new Account { Name = "wilma", Sum = 157689 });
            Accounts.Add(new Account { Name = "johanna", Sum = 114 });
            Accounts.Add(new Account { Name = "david", Sum = 36737 });
        }
        public static void AddAccount()
        {
            //This method is for adding accounts, since it only has name and sum its not very advanced.
            Console.WriteLine("Insert Account info Below.");
            string newAccountName = Console.ReadLine().ToLower();
            Accounts.Add(new Account { Name = newAccountName, Sum = 0 });
            Console.WriteLine($"The account of {newAccountName} has been added with a sum of = 0\nGo to see accounts to deposit money into the new account.");
            Thread.Sleep(1500);
        }
        public static void RemoveAccount()
        {
            //removal method so that the accounts can be deleted. It now handles stealing of all the accounts money into the banks own pocket. Yay for corruption
            Console.WriteLine("Do you wish to delete an account?\nYes/No:");
            string deleteUserInput = Console.ReadLine().ToLower();
            switch (deleteUserInput)
            {
                case "yes":
                    Console.Clear();
                    foreach (var item in Accounts)
                    {
                        Console.WriteLine(item.Name);
                    }
                    Console.WriteLine("\nType in the name of the account you wish to delete:");
                    string deleteUserInputNameOfAccount = Console.ReadLine().ToLower();
                    int indexOfDelete = Accounts.FindIndex(c => c.Name.Contains(deleteUserInputNameOfAccount));
                    for (int i = 0; i < Accounts.Count; i++)
                    {
                        if (Accounts[i].Name == deleteUserInputNameOfAccount)
                        {
                            Console.WriteLine($"The account of {deleteUserInputNameOfAccount} will be deleted are you sure?\nYes/No:");
                            string areYouSureInput = Console.ReadLine().ToLower();
                            if (areYouSureInput == "yes")
                            {
                                Console.WriteLine($"The account of {deleteUserInputNameOfAccount} Has been deleted.");
                                TheBank[0].Sum = TheBank[0].Sum + Accounts[i].Sum;
                                Accounts.RemoveAt(indexOfDelete);
                                Thread.Sleep(1500);
                            }
                            else
                            {
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine($"{deleteUserInputNameOfAccount} does not exist try again.");
                            Thread.Sleep(1500);
                        }
                    }
                    break;
                case "no":
                    break;
                default:
                    Console.WriteLine($"was not a correct input, try again");
                    Thread.Sleep(1500);
                    break;
            }
        }
        public static void SaveMethod()
        {
            string BankSaveText = JsonSerializer.Serialize(TheBank);
            string AccountListText = JsonSerializer.Serialize(Accounts);
            System.IO.File.WriteAllText("Accounts.Json", AccountListText);
            System.IO.File.WriteAllText("BankSave.Json", BankSaveText);
        }
        public static void LoadAccounts()
        {
            string bankLoadFromFile = System.IO.File.ReadAllText("BankSave.Json");
            string AccountsLoadFromFile = System.IO.File.ReadAllText("Accounts.Json");
            TheBank = JsonSerializer.Deserialize<List<Account>>(bankLoadFromFile) ?? new List<Account>();
            Accounts = JsonSerializer.Deserialize<List<Account>>(AccountsLoadFromFile) ?? new List<Account>();
            //savedAccounts = JsonSerializer.Deserialize<List<Account>>(AccountsLoadFromFile) ?? new List<Account>();
        }
    }
}

