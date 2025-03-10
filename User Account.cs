using System.Linq;
using System.Net.NetworkInformation;

namespace ATM_System
{
    public class User_Account 
    {
        public string Pin; 
        public string AccountNumber { get; set; }
        public string AccountHolderName { get; set; }
        public string PIN
        {
            get { return Pin; } 
            set
            {
    
                if (value.Length != 6)
                {
                    throw new ArgumentException("PIN must be exactly 6 digits long.");
                }

                if (!value.All(char.IsDigit))
                {
                    throw new ArgumentException("PIN must contain at least one '0'.");
                }

                Pin = value; 
            }
        }

        public double Balance { get; set; }
        public string cardNumber;
        public string CardNumber
        {
            get { return cardNumber; }
            set
            {
                if (value.Length != 14)
                {
                    throw new ArgumentException("PIN must be exactly 6 digits long.");
                }

                if (!value.All(char.IsDigit))
                {
                    throw new ArgumentException("PIN must contain at least one '0'.");
                }

                Pin = value;
            }
        }
         public  static List<User_Account> user_AccountsList { get; set; }  = new List<User_Account>();

        public override string ToString()
        {
            return $" AccountNumber{AccountNumber} ,  AccountHolderName{AccountHolderName} , Pin {Pin} , Balance{Balance} , CardNumber{CardNumber} ";
        }
  

    }
}
