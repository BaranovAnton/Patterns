using UnityEngine;

public class MenuItem
{
    string name;
    int price;

    public MenuItem(string name, int price)
    {
        this.name = name;
        this.price = price;
    }

    public string GetName()
    {
        return name;
    }

    public int GetPrice()
    {
        return price;
    }
}