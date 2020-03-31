using UnityEngine;

public class Cocktail : ColdBeverage
{
    public override void AddCondiments()
    {
        Debug.Log("Add some alcohol");
    }

    public override void Mix()
    {
        Debug.Log("Cocktail mixing!");
    }
}
