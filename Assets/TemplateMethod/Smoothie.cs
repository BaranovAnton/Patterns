using UnityEngine;

public class Smoothie : ColdBeverage
{
    public override void AddCondiments()
    {
        Debug.Log("Add some fruits");
    }

    public override void Mix()
    {
        Debug.Log("Smoothie mixing!");
    }

    public override void AddIce()
    {
        Debug.Log("No ice");
    }
}
