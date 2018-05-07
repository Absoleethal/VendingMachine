using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine2
{
    class MoneyPool
    {
        public int totalMoney { get; set; }

        public MoneyPool()
        {

        }
        public MoneyPool(int totalMoney)
        {
            this.totalMoney = totalMoney;
        }

        public int[] Total = new int[] { 1, 5, 10, 20, 50, 100, 500, 1000 };
        
        public int ash(int moneyInserted)
        {
         
            
            int cashInput = 0;
            int[] userInputCash = new int[8];
            int totalMoney = 0;
            do
            {
                Console.WriteLine($"What currency would you like to add (1,5,10,20,50,100,500,1000): ");
                cashInput = 0;
                try
                {
                    cashInput = (Convert.ToInt32(Console.ReadLine()));
                }
                catch (FormatException)
                {
                    Console.WriteLine("You typed a letter instead of a number, please try again.");
                }
                if ((cashInput != 1) && (cashInput != 5) && (cashInput != 10) && (cashInput != 20) && (cashInput != 50) && (cashInput != 100) && (cashInput != 500) && (cashInput != 1000))
                {
                    Console.WriteLine("That is not an actual coin or note. Please try again.");
                }
            } while ((cashInput != 1) && (cashInput != 5) && (cashInput != 10) && (cashInput != 20) && (cashInput != 50) && (cashInput != 100) && (cashInput != 500) && (cashInput != 1000));
            switch (cashInput)
            {
                case 1:
                    userInputCash[0] += + 1;
                    break;
                case 5:
                    userInputCash[1] += 5;
                    break;
                case 10:
                    userInputCash[2] += 10;
                    break;
                case 20:
                    userInputCash[3] += 20;
                    break;
                case 50:
                    userInputCash[4] += 50;
                    break;
                case 100:
                    userInputCash[5] += 100;
                    break;
                case 500:
                    userInputCash[6] += 500;
                    break;
                case 1000:
                    userInputCash[7] += 1000;
                    break;
                default:
                    break;
            }
            totalMoney = 0;
            for (int i = 0; i <= 7; i++)
            {
                totalMoney += userInputCash[i];
            }
            Console.WriteLine($"You inserted {cashInput} SEK and have now a total of {totalMoney + moneyInserted} SEK");
           
            Console.ReadKey();
            return totalMoney;

        }

        public int ashback(int wallet)
        {

            int change = wallet;

            var Types = new[]
            {
                new {type = "Thousand", name = 1000},
                new {type = "Fivehundred", name = 500},
                new {type = "Onehundred", name = 100},
                new {type = "Fifty", name = 50},
                new {type = "Twenty", name = 20},
                new {type = "Ten", name = 10},
                new {type = "Five", name = 5},
                new {type = "One", name = 1}
            };
            foreach (var bill in Types)
            {
                int count = (int)(change / bill.name);
                change -= count * bill.name;

                Console.WriteLine($"{count} {bill.type}");
            }
            Console.ReadKey();
           return wallet -= wallet;
        }

        public static char GetKey()
        {
            ConsoleKeyInfo userIn = Console.ReadKey(true);
            return userIn.KeyChar;
        }

    }
}
