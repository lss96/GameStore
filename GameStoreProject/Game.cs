using System;
using System.Collections.Generic;

public class Game
{
    public string name;
    public float price;
    public Genres genre;
    public List<DLC> dlcs = new List<DLC>();

    public Game(string n, float p, Genres g)
    {
        name = n;
        price = p;
        genre = g;
    }

    public Game(string n, float p)
    {
        name = n;
        price = p;
    }

    public void AddDLC(string name, float price)
    {
        DLC newDLC = new DLC(name, price, this);
        dlcs.Add(newDLC);
    }

    public void PrintDLCs()
    {
        if (dlcs.Count == 0)
        {
            Console.WriteLine("No available DLCs");
        }
        else
        {
            Console.WriteLine("Available DLCs:");
            foreach (DLC dlc in dlcs)
            {
                Console.WriteLine(dlc.name + "; " + dlc.price);
            }
        }
    }
}


public enum Genres
{
    Adventure,
    RPG,
    Puzzle,
    FPS,
    Horror
}