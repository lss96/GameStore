using System;
using System.Collections.Generic;


public class Showcase
{
    Game[] games;

    public Showcase(int numberOfSpots)
    {
        games = new Game[numberOfSpots];
    }

    // overloading: having multiple version of a constructor (or method) with different arguments
    public Showcase()
    {
        games = new Game[4];
    }

    public void AddGame(Game game, int position)
    {
        if (IsValidIndex(position))
            games[position] = game;
    }

    public void RemoveGame(int position)
    {
        if (IsValidIndex(position))
            games[position] = null;
    }

    private bool IsValidIndex(int position)
    {
        if (position >= 0 && position < games.Length)
            return true;
        else
        {
            Console.WriteLine("Invalid index!");
            return false;
        }
    }

    public void PrintGamesOnDisplay()
    {
        Console.WriteLine("Games on showcase:");
        for (int i = 0; i < games.Length; i++)
        {
            if (games[i] != null)
                Console.WriteLine(i + ": " + games[i].name + "; " + games[i].price);
        }
    }

    public int NumberOfSpots()
    {
        return games.Length;
    }
}