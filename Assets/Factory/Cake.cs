using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Cake
{
    protected string name;
    protected string dough;
    protected List<string> toppings = new List<string>();

    public void Prepare()
    {
        Debug.Log("Preparing " + name);
        Debug.Log("Tossing dough...");
        Debug.Log("Adding toppings: ");
        for (int i = 0; i < toppings.Count; i++)
            Debug.Log(" " + toppings[i]);
    }

    public void Bake()
    {
        Debug.Log("Bake for 30 minutes at 350");
    }

    public void Cut()
    {
        Debug.Log("Cutting the cake into pieces");
    }

    public void Box()
    {
        Debug.Log("Place cake in box");
    }

    public string GetName()
    {
        return name;
    }
}