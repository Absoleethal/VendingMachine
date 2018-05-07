using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine2
{
    class Menu
    {
        
        int wallet = 0;
        public void MainMenu()
        {
            Console.Clear();

            do
            {
                Console.Clear();
                Console.WriteLine(@" _______Welcome_to_vending_machine___________ ");
                Console.WriteLine(@"|#############################|##############|");
                Console.WriteLine(@"|#| |Pepsi|  /****\  |~~~~|   |##|1.Snacks|##|");
                Console.WriteLine(@"|#|  |   |   |    |  |~~~~|   |##|2.Drinks|##|");
                Console.WriteLine(@"|#|  |___|   /___ |  |~~~~|   |##|3.Insert|##|");
                Console.WriteLine(@"|#|  / *_\   /.__\|  |/~__\   |##|4.Refund|##|");
                Console.WriteLine(@"|#|  \__//   \__//    \__//   |##|5._Exit_|##|");
                Console.WriteLine(@"|#|==|12|=====|31|====|23|====|##############|");
                Console.WriteLine(@"|#|```````````````````````````|##############|");
                Console.WriteLine(@"|#|   __    |Redbull| //////  |##############|");
                Console.WriteLine(@"|#|  /  \      _      \\\\\\  |#|`````````|##|");
                Console.WriteLine(@"|#|  \___\    |~|     //////  |#| _______ |##|");
                Console.WriteLine(@"|#|  /   \\   |~|    //_|_\\  |#| |1|2|3| |##|");
                Console.WriteLine(@"|#|  \__///   |_|    \\_|_//  |#| |4|5|6| |##|");
                Console.WriteLine(@"|#|===|42|====|11|=====|51|===|#| |7|8|9| |##|");
                Console.WriteLine(@"|#|```````````````````````````|#| ``````` |##|");
                Console.WriteLine(@"|#|   ___    ____    |Apple|  |#|[=======]|##|");
                Console.WriteLine(@"|#|  |   |  |    |            |#|  _   _  |##|");
                Console.WriteLine(@"|#|  |___|  | __ |     __/\   |#| ||| ( ) |##|");
                Console.WriteLine(@"|#|  / __\  |/__\|    / *\    |#| |||  `  |##|");
                Console.WriteLine(@"|#|  \__/_| |\__/|    \__/    |#|  ~      |##|");
                Console.WriteLine(@"|#|==|73|====|81|======|3|====|#|_________|##|");
                Console.WriteLine(@"|#|```````````````````````````|##############|");
                Console.WriteLine(@"|############################################|");
                Console.WriteLine(@"|#|||||||||||||||||||||||||||||####```````###|");
                Console.WriteLine(@"|#|||||||||||Absoleet||||||||||####\|||||/###|");
                Console.WriteLine(@"|############################################|");
                Console.WriteLine(@"\\\\\\\\\\\\\\\\\\\\\\/////////////////////// ");
                Console.WriteLine($" |____You have:{wallet}_Cash____| ");
                MoneyPool C = new MoneyPool();
                char input = GetKey();
                switch (input)
                {
                    case '1':
                        Snacks();
                        break;
                    case '2':
                        Drinks();
                        break;
                    case '3':
                        wallet += C.ash(wallet);
                        break;
                    case '4':
                        C.ashback(wallet);
                        wallet = 0;
                        break;
                    case '5':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("That is not an option");
                        break;
                }
            } while (true);

        }
        public void Snacks()
        {
            Console.Clear();
            Snacks hungry = new Snacks();
          
            do
            {
                Console.WriteLine("1.Chips\n2.Chocolate\n3.Apple\n4.Main Menu");
                char input = GetKey();
                switch (input)
                {
                    case '1': wallet = hungry.Chips(wallet);
                        break;
                    case '2': wallet = hungry.Chocolate(wallet);
                        break;
                    case '3': wallet = hungry.Apple(wallet);
                        break;
                    case '4': return;
                    default:
                        Console.WriteLine("That is not an option");
                        break;
                }
            } while (true);
        }
        public void Drinks()
        {
            Console.Clear();
            Drinks thirst = new Drinks();
            do
            {
                Console.WriteLine("1.Pepsi\n2.Redbull\n3.Juice\n4.Main Menu");
                char input = GetKey();
                switch (input)
                {
                case '1': wallet = thirst.Pepsi(wallet);
                    break;
                case '2': wallet = thirst.Redbull(wallet);
                    break;
                case '3': wallet = thirst.Juice(wallet);
                     break;
                case '4':
                    return;
                default: Console.WriteLine("That is not an option");
                    break;
                }
            } while (true);
        }
       

        public static char GetKey()
        {
            ConsoleKeyInfo userIn = Console.ReadKey(true);
            return userIn.KeyChar;
        }
    }
}
