using UnityEngine;

public abstract class ColdBeverage
{
    public void PrepareRecipe()
    {
        TakeGlass();
        Mix();
        AddCondiments();
        PourInGlass();
        AddIce();
    }

    public abstract void Mix();

    public abstract void AddCondiments();

    public void TakeGlass()
    {
        Debug.Log("I have a nice glass");
    }

    public void PourInGlass()
    {
        Debug.Log("Pouring into glass");
    }

    public virtual void AddIce()    // Method - interceptor
    {
        Debug.Log("Adding ice...");
    }
}