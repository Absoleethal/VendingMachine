using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine2
{
    class Snacks : MoneyPool, IProducts
    {
        
        public string Name { get; set; }
        public string Info { get; set; }
        public int Price { get; set; }

        public Snacks()
        {
 
        }
        public Snacks(string Name,string Info,int Price)
        {
            this.Name = Name;
            this.Info = Info;
            this.Price = Price;
        }
        public int Chips(int wallet)
        {
            Console.Clear();
            Snacks chips = new Snacks("Estrella Lättsaltade", "Tunna lättsaltade potatischips. Estrella var först med att lanserade Lättsaltade Potatischips för 60 år sedan, redan 1957!", 23);
            do
            {
                Console.WriteLine($"{chips.Name}\n1.Buy\n2.info\n3.Back");
                char input = GetKey();
                switch (input)
                {
                    case '1':
                        if (chips.Price > wallet)
                        {
                            Console.WriteLine("Sorry but your dont have enough credits please insert more cash");
                            Console.ReadKey();
                            return wallet;
                        }
                        Console.WriteLine($"You pay {chips.Price} - your Wallet is now {wallet - chips.Price}");
                        return wallet - chips.Price;
                        //break;
                    case '2':Console.Clear(); TextColor($"{chips.Info}", ConsoleColor.Cyan);
                        break;
                    case '3':
                        Console.Clear();
                        return wallet;
                    default:
                        break;
                }
            } while (true);
        }
        public int Chocolate(int wallet)
        {
            Console.Clear();
            Snacks choklad = new Snacks("Vego", "chokladkaka med hela hasselnötter är kanske den största och godaste chokladkaka i världen!", 25);
            do
            {
                Console.WriteLine($"{choklad.Name}\n1.Buy\n2.Info\n3.Back");
                char input = GetKey();
                switch (input)
                {
                    case '1':
                        if (choklad.Price > wallet)
                        {
                            Console.WriteLine("Sorry but your dont have enough credits please insert more cash");
                            Console.ReadKey();
                            return wallet;
                        }
                        Console.WriteLine($"You pay {choklad.Price} - your Wallet is now {wallet - choklad.Price}");
                        return wallet - choklad.Price;
                    case '2': Console.Clear(); TextColor($"{choklad.Info}", ConsoleColor.Cyan);
                        break;
                    case '3':
                        Console.Clear();
                        return wallet;
                    default:
                        break;
                }
            } while (true);
        }
        public int Apple(int wallet)
        {
            Console.Clear();
            Snacks apple = new Snacks("Royal Gala", "Gala är en äppelsort vars ursprungsland är Nya Zeeland. Äpplet skal är av en rödgul färg. Äpplet har en mild och söt smak.", 5);
            do
            {
                Console.WriteLine($"{apple.Name}\n1.Buy\n2.Info\n3.Back");
                char input = GetKey();
                switch (input)
                {
                    case '1':
                        if (apple.Price > wallet)
                        {
                            Console.WriteLine("Sorry but your dont have enough credits please insert more cash");
                            Console.ReadKey();
                            return wallet;
                        }
                        Console.WriteLine($"You pay {apple.Price} - your Wallet is now {wallet - apple.Price}");
                        return apple.Price;
                    case '2':  Console.Clear(); TextColor($"{apple.Info}", ConsoleColor.Cyan);
                        break;
                    case '3':
                        Console.Clear();
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
