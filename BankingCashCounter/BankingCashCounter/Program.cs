using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingCashCounter
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Simulate Banking Cash Counter Program:-");

            Console.WriteLine("Bank Services Are :\n 1. WithdrawMoney\n 2. DepositMoney\n ");

            Cashier cashier = new Cashier();
            Queue queue = new Queue();

            Random random = new Random();
            int user = random.Next(1,5);
            Console.WriteLine(user + " People In Queue ");
            for (int i = 1; i <= user; i++)
            {
                int option = random.Next(1, 3);

                switch (option)
                {
                    case 1:
                        queue.Enqueue(i);
                        cashier.WithdrawMoney();
                        break;
                    case 2:
                        queue.Enqueue(i);
                        cashier.DepositMoney();
                        break;
                    default:
                        Console.WriteLine("Exit");
                        break;
                }

            }
        }
    }
    
}
