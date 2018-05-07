using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine2
{
    class Drinks : MoneyPool, IProducts
    {


        
        public string Name { get; set; }
        public string Info { get; set; }
        public int Price { get; set; }

        public Drinks()
        {

        }
        public Drinks(string Name, string Info, int Price)
        {
            this.Name = Name;
            this.Info = Info;
            this.Price = Price;
        }
        public int Pepsi(int wallet)
        {
            Console.Clear();
            Drinks pepsi = new Drinks("Pepsi Cola", "Namnet Pepsi kommer från dyspepsi (ett samlingsnamn för olika magbesvär). Den tillverkas av kolsyrat vatten, färgämnen (E150), socker, fosforsyra, citronsyra, konserveringsmedel (natriumbensoat), och aromämnen.", 12);
            do
            {
                Console.WriteLine($"{pepsi.Name}\n1.Buy\n2.info\n3.Back");
                char input = GetKey();
                switch (input)
                {

                    case '1':
                        if (pepsi.Price > wallet)
                        {
                            Console.WriteLine("Sorry but your dont have enough credits please insert more cash");
                            Console.ReadKey();
                            return wallet;
                        }
                        Console.WriteLine($"You pay {pepsi.Price} - your Wallet is now {wallet - pepsi.Price}");
                        return wallet - pepsi.Price;
                    case '2': Console.Clear(); TextColor($"{pepsi.Info}", ConsoleColor.Cyan);
                        break;
                    case '3': Console.Clear();
                        return wallet -= pepsi.Price;
                    default:
                        break;
                }
            } while (true);
        }
        public int Redbull(int wallet)
        {
            Console.Clear();
            Drinks redbull = new Drinks("Redbull", "Energidrycker som innehåller koffein, taurin, kolhydrater och vitaminer är framtagna i syfte att motverka trötthet i samband med mental eller fysisk ansträngning. Koffein verkar uppiggande och kolhydrater tillför kroppen energi.", 15);
            do
            {
                Console.WriteLine($"{redbull.Name}\n1.Buy\n2.info\n3.Back");
                char input = GetKey();
                switch (input)
                {

                    case '1':
                        if (redbull.Price > wallet)
                        {
                            Console.WriteLine("Sorry but your dont have enough credits please insert more cash");
                            Console.ReadKey();
                            return wallet;
                        }
                        Console.WriteLine($"You pay {redbull.Price} - your Wallet is now {wallet - redbull.Price}");
                        return wallet - redbull.Price;
                    case '2': Console.Clear(); TextColor($"{redbull.Info}", ConsoleColor.Cyan);
                        break;
                    case '3': Console.Clear();
                        return wallet;
                    default:
                        break;
                }
            } while (true);
        }
        public int Juice(int wallet)
        {
            Console.Clear();
            Drinks saft = new Drinks("MER 'Äpple'", "MER är helt utan tillsatta konserveringsmedel och har därför en begränsad hållbarhet när du väl öppnat förpackningen. Den skall avnjutas kall och öppnad förpackning skall förvaras svalt.", 14);
            do
            {
                Console.WriteLine($"{saft.Name}\n1.Buy\n2.info\n3.Back");
                char input = GetKey();
                switch (input)
                {
                    case '1':
                        if (saft.Price > wallet)
                        {
                            Console.WriteLine("Sorry but your dont have enough credits please insert more cash");
                            Console.ReadKey();
                            return wallet;
                        }
                        Console.WriteLine($"You pay {saft.Price} - your Wallet is now {wallet - saft.Price}");
                        return wallet - saft.Price;
                    case '2': Console.Clear(); TextColor($"{saft.Info}", ConsoleColor.Cyan);
                        break;
                    case '3': Console.Clear();
                        return wallet;
                    default:
                        break;
                }
            } while (true);
        }
        public static new char GetKey()
        {
            ConsoleKeyInfo userIn = Console.ReadKey(true);
            return userIn.KeyChar;
        }
        public void TextColor(string text, ConsoleColor color) 
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}
