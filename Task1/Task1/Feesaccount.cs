//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Task1
//{
//    internal class Feesaccount : Bankaccount
//    {
//        private decimal feesAmount;

//        public decimal FeesAmount
//        {
//            get
//            {
//                return feesAmount;
//            }
//            set
//            {
//                if (value < 0)
//                {
//                    Console.WriteLine("fees cant be negative");
//                    return;
//                }
//                feesAmount = value;
//            }
//        }

//        public Feesaccount(decimal balance ,decimal feesAmount, string accountNumber) : base(balance, accountNumber)
//        {
//            FeesAmount= feesAmount;
//        }

//        public override void Withdraw(decimal amount)
//        {
//            decimal totalAmount = amount + feesAmount;
//            if (totalAmount > Balance)
//            {
//                Console.WriteLine("cannt");
//                return;
//            }
//            Withdraw(totalAmount);

//            Console.WriteLine(totalAmount);
//            Withdraw(amount);

//        }
//    }
//}
