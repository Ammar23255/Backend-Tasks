//using System;
//using System.Collections.Generic;
//using System.Diagnostics.Contracts;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Task1
//{
//    internal class Savingaccount : Bankaccount
//    {
        
//        private decimal interestRate;
//        public decimal InterestRate
//        {
//            get
//            {
//                return interestRate;
//            }
//            set
//            {
//                if (value < 0 || value > 1)
//                {
//                    Console.WriteLine("the value ,=must be in 0 1 range");
//                    return;
//                }
//                interestRate = value;
//            }
//        }

//        public Savingaccount(decimal balance, decimal interestRate, string accountNumber) : base(balance, accountNumber)
//        {
//            InterestRate = interestRate;
//        }

//        public void addInterest()
//        {
//            var amount = Balance * interestRate;

//            Deposit(amount);

//            Console.WriteLine($"add to the balance{amount} to be {Balance}");


//        }
//    }
//}
