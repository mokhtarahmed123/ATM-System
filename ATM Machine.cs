namespace ATM_System
{
    internal class ATM_Machine : Bank
    {
        public TransactionType transaction { get; set; }
        public Status status { get; set; }

        public string ATMID { get; set; }
        public string Location { get; set; }
        public double CashAvailable { get; set; }
        public double TransactionLimit { get; set; }
        public static List<ATM_Machine> aTM_MachinesList = new List<ATM_Machine>();
        List<User_Account> user_Accounts = new List<User_Account>();
        public string Proccess(string cardNumber, string Pin, TransactionType Tra, int Amount = 0)
        {
            status = Status.Pending;
            User_Account account = User_Account.user_AccountsList.Find(account => account.CardNumber == cardNumber);

            if (account == null)
            {
                status = Status.Failed;
                Console.WriteLine(status);
                return "Error: Account not found.";
            }
            if (account.Pin != Pin)
            {

                status = Status.Failed;
                Console.WriteLine(status);
                return "Error: Incorrect PIN.";
            }

            //if (Tra == TransactionType.Balance)
            //{
            //    status = Status.Success;
            //    Console.WriteLine(status);
            //    return $"Balance successful! New balance: {account.Balance}";

            //}
            //else if (Tra == TransactionType.Transfer)
            //{
            //    if (account.Balance > Amount)
            //    {
            //        status = Status.Success;
            //        Console.WriteLine(status);
            //        account.Balance -= Amount;
            //        return $"Transfer successful! New balance: {account.Balance}";

            //    }

            //}
            //else if (Tra == TransactionType.Deposit)
            //{
            //    status = Status.Success;
            //    Console.WriteLine(status);
            //    account.Balance += Amount;
            //    return $"Deposit successful! New balance: {account.Balance}";


            //}
            //else if (Tra == TransactionType.Withdrawal)
            //{
            //    if (account.Balance > Amount)
            //    {
            //        status = Status.Success;
            //        Console.WriteLine(status);
            //        account.Balance -= Amount;
            //        return $"Withdrawal successful! New balance: {account.Balance}";


            //    }
            //}
            //else if (Tra == TransactionType.Inquiry)
            //{

            //    status = Status.Success;
            //    Console.WriteLine(status);
            //    return $"Withdrawal successful! New balance: {account.Balance}";



            //}

            switch (Tra)
            {
                case TransactionType.Balance:
                    status = Status.Success;
                    Console.WriteLine(status);
                    return $"Balance successful! New balance: {account.Balance}";

                case TransactionType.Transfer:
                    if (account.Balance > Amount)
                    {
                        status = Status.Success;
                        Console.WriteLine(status);
                        account.Balance -= Amount;
                        return $"Transfer successful! New balance: {account.Balance}";
                    }
                    else
                    {
                        return "return \"Error: Insufficient balance";
                    }
                case TransactionType.Deposit:
                    status = Status.Success;
                    Console.WriteLine(status);
                    account.Balance += Amount;
                    return $"Deposit successful! New balance: {account.Balance}";
                case TransactionType.Withdrawal:
                    if (account.Balance > Amount)
                    {
                        status = Status.Success;
                        Console.WriteLine(status);
                        account.Balance -= Amount;
                        return $"Withdrawal successful! New balance: {account.Balance}";


                    }
                    else
                    {

                        return $"Withdrawal Failed{account.Balance}";

                    }
                case TransactionType.Inquiry:
                    status = Status.Success;
                    Console.WriteLine(status);
                    return $"Withdrawal successful! New balance: {account.Balance}";
                default:
                    return "invalid TransactionType ";

            }

          
        }
        //private List<User_Account> user_Accounts;


    }
}
