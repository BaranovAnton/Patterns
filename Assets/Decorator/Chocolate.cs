using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chocolate : CondimentDecorator
{
    IceCream iceCream;

    public Chocolate(IceCream iceCream)
    {
        this.iceCream = iceCream;
    }

    public override string GetDescription()
    {
        return iceCream.GetDescription() + " Chocolate";
    }

    public override float Cost()
    {
        return 0.2f + iceCream.Cost();
    }
}