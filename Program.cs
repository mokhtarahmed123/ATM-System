namespace ATM_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region User_Account
            User_Account user_Account = new User_Account();
            User_Account user_Account1 = new User_Account();
            User_Account user_Account2 = new User_Account();
            User_Account user_Account3 = new User_Account();
            User_Account user_Account4 = new User_Account();
            user_Account1.CardNumber = "12358004818515"; user_Account1.AccountNumber = "300"; user_Account1.AccountHolderName = "Mohamed Rashed";
            user_Account1.Pin = "300120"; user_Account1.Balance = 30000;
            /////
            user_Account2.CardNumber = "12359994818515"; user_Account2.AccountNumber = "900"; user_Account2.AccountHolderName = "Ahmed Sayed";
            user_Account2.Pin = "600810"; user_Account2.Balance = 260000;
            ////
            user_Account3.CardNumber = "12358111058515"; user_Account3.AccountNumber = "30"; user_Account3.AccountHolderName = "Mostafa  Reda";
            user_Account3.Pin = "132848"; user_Account3.Balance = 160000;
            //////
            user_Account4.CardNumber = "12364884818515"; user_Account4.AccountNumber = "100"; user_Account4.AccountHolderName = "Zaki Rashed";
            user_Account4.Pin = "123456"; user_Account4.Balance = 556;
            User_Account.user_AccountsList.Add(user_Account1);
            User_Account.user_AccountsList.Add(user_Account2);
            User_Account.user_AccountsList.Add(user_Account3);
            User_Account.user_AccountsList.Add(user_Account4);
            Console.WriteLine(User_Account.user_AccountsList.Count);
            #endregion
            #region ATM_Machine
            ATM_Machine aTM_Machine1 = new ATM_Machine();
            aTM_Machine1.ATMID = "1122"; aTM_Machine1.Location = "Cairo "; aTM_Machine1.TransactionLimit = 4000; aTM_Machine1.CashAvailable = 100_000; aTM_Machine1.BankName = "Alahly";aTM_Machine1.BranchCode = "#012";
            ATM_Machine aTM_Machine2 = new ATM_Machine(); 
            aTM_Machine2.ATMID = "5963"; aTM_Machine2.Location = "Giza "; aTM_Machine2.TransactionLimit = 5000; aTM_Machine2.CashAvailable = 200_000; aTM_Machine1.BankName = "Masr"; aTM_Machine1.BranchCode = "#099";
            ATM_Machine aTM_Machine3 = new ATM_Machine();
            aTM_Machine2.ATMID = "6635"; aTM_Machine2.Location = "Alex "; aTM_Machine2.TransactionLimit = 4600; aTM_Machine2.CashAvailable = 1500_000; aTM_Machine1.BankName = "Alex"; aTM_Machine1.BranchCode = "#996";
            ATM_Machine.aTM_MachinesList.Add(aTM_Machine1);
            ATM_Machine.aTM_MachinesList.Add(aTM_Machine2);
            ATM_Machine.aTM_MachinesList.Add(aTM_Machine3);
            Console.WriteLine(ATM_Machine.aTM_MachinesList.Count);
            #endregion
            Bank bank = new Bank();
            bank.AddAcounts(user_Account1);
            bank.AddAcounts(user_Account2);
            bank.AddAcounts(user_Account3);
            bank.AddAcounts(user_Account4);
                
                ATM_Machine aTM_ = new ATM_Machine();
            TransactionType transactionType = TransactionType.Deposit;
          string D =   aTM_.Proccess("123587", "300120", transactionType , 2000); 
            Console.WriteLine(D);
           
            Console.WriteLine("Welcome to the ATM System!");
            Console.Write("Enter your card number: ");
            string cardNumber = Console.ReadLine();

            Console.Write("Enter your PIN: ");
            string pin = Console.ReadLine();

            Console.WriteLine("Select transaction type:");
            Console.WriteLine("1. Withdrawal");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Balance Inquiry");
            Console.WriteLine("4. Transfer");
            Console.Write("Enter your choice (1-4): ");
            string choice = Console.ReadLine();

            int amount = 0;

            switch (choice)
            {
                case "1":
                    transactionType = TransactionType.Withdrawal;
                    Console.Write("Enter amount to withdraw: ");
                    amount = int.Parse(Console.ReadLine());
                    break;
                case "2":
                    transactionType = TransactionType.Deposit;
                    Console.Write("Enter amount to deposit: ");
                    amount = int.Parse(Console.ReadLine());
                    break;
                case "3":
                    transactionType = TransactionType.Balance;
                    break;
                case "4":
                    transactionType = TransactionType.Transfer;
                    Console.Write("Enter amount to transfer: ");
                    amount = int.Parse(Console.ReadLine());
                    break;
                default:
                    Console.WriteLine("Invalid choice. Exiting...");
                    return;
            }

          
            ATM_Machine atm = new ATM_Machine();
            string result = atm.Proccess(cardNumber, pin, transactionType, amount);
            Console.WriteLine(result);
        }
    }
}
