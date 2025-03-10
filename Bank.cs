    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace ATM_System
    {
        internal class Bank
        {
            public string  BankName { get; set; }
            public string BranchCode { get; set; }
            public static List<User_Account> user_AccountsinBanks { get; set; } = new List<User_Account>();
        //public static List<ATM_Machine> aTM_Machinest = new List<ATM_Machine>();
        public void AddAcounts(User_Account UserAccount)
            {
                user_AccountsinBanks.Add(UserAccount);
            }   
        //public void AddAaTM_MachinesList(ATM_Machine aTM_Machines)
        //    {
        //    aTM_Machinest.Add(aTM_Machines);
        //    }



        }
    }
