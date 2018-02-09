using System;
using System.Collections.Generic;
using System.Text;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();
            store.AddNewGame("Peter Brincks liv i en nødeskal", 15, 0);
            store.AddNewGame("How to Hermansen", 9.9f, 1);
            store.AddNewGame("Bronck for begyndere", 60, 2);
            store.AddNewGame("The Witcher 3", 50, 3);
           
            while (true)
            {
                Console.WriteLine("Insert command (print/add/buy/quit)");
                string command = Console.ReadLine();

                switch (command)
                {
                    case "print":
                        store.showcase.PrintGamesOnDisplay();
                        break;
                    case "quit":
                        return;
                    default:
                        Console.WriteLine("Unknown command");
                        break;
                    case "buy":
                        Console.WriteLine("Which game do you want to buy? [Insert number]");
                        store.showcase.PrintGamesOnDisplay();
                        int index = Convert.ToInt32(Console.ReadLine());
                        if (index >= 0 && index < store.showcase.NumberOfSpots())
                            store.SellGame(index);
                        else
                            Console.WriteLine("Error: invalid index");
                        break;

                }
            }
        }
    }
}
