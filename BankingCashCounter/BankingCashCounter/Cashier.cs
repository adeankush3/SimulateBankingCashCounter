using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingCashCounter
{
    public class Cashier
    {
        public int TotalAmount = 64000;
        public int Deposit = 0;
        public int WithdrawAmt = 0;

        Queue queue = new Queue();

        public void WithdrawMoney()
        {
            Console.WriteLine("Total Money in your Bank Account : " + TotalAmount);

            Console.WriteLine("Enter Amount for Withdraw Money :\n");
            WithdrawAmt = Convert.ToInt32(Console.ReadLine());

            if (WithdrawAmt > TotalAmount)
            {
                Console.WriteLine("Not Available Money In Your Account");
            }
            else
            {
                TotalAmount -= WithdrawAmt;
                Console.WriteLine(WithdrawAmt + " Collect Your Money \n");
                Console.WriteLine("Your Remaining Balance Is :" + TotalAmount);
            }
            queue.Dequeue();
        }

        public void DepositMoney()
        {
            Console.WriteLine("Total Balance of your account : " + TotalAmount);
            Console.WriteLine("Please Enter Amount for Deposit :\n");
            Deposit = Convert.ToInt32(Console.ReadLine());

            TotalAmount += Deposit;
            Console.WriteLine(Deposit + " Money depositted in your account \n");
            Console.WriteLine("Now Your Curent Balance is :" + TotalAmount);

            queue.Dequeue();

        }
    }
}
