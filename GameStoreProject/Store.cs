using System;
using System.Collections.Generic;


public class Store
{
    public Showcase showcase;

    public Store()
    {
        showcase = new Showcase();
    }

    public void AddNewGame(string name, float price, int position)
    {
        Game newGame = new Game(name, price);
        showcase.AddGame(newGame, position);
    }

    public void SellGame(int position)
    {
        showcase.RemoveGame(position);
    }
}