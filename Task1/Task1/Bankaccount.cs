//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Task1
//{
//    internal class Bankaccount
//    {
//        private decimal balance;


//        public decimal Balance
//        {
//            get { return balance; }
//            set
//            {
//                if (value < 0)
//                {
//                    Console.WriteLine("value cannot be negative");
//                    return;
//                }
//                balance = value;
//            }
//        }
//        public string AccountNumber { get; }

//        public Bankaccount(decimal balance =0, string accountNumber)
//        {
//            Balance = balance;
//            AccountNumber = accountNumber;
//        }

//        public virtual void Deposit(decimal amount)
//        {
//            if (amount <= 0)
//            {
//                Console.WriteLine("the amount must be positove");
//                return;
//            }
//            balance += amount;
//            Console.WriteLine($"account deposite by {amount} , your acc has {balance}");
//        }

//        public virtual void Withdraw(decimal amount)
//        {
//            if (amount <= 0) {
//                Console.WriteLine("the amout must be positive");
//            }

//            if (amount > balance)
//            {
//                Console.WriteLine("the amout not allowed");

//            }
//            balance -= amount;
//            Console.WriteLine($"account balance after withdraw{amount}, is {balance}");


//        }
//    }
//}
