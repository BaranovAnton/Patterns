using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecoratorExample : MonoBehaviour
{
    void Start()
    {
        IceCream iceCream = new CremeBrulee();
        Debug.Log(iceCream.GetDescription() + " " + iceCream.Cost());

        iceCream = new Chocolate(iceCream);
        iceCream = new Chocolate(iceCream);
        Debug.Log(iceCream.GetDescription() + " " + iceCream.Cost());
    }
}