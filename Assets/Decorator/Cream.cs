using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cream : IceCream
{
    public Cream()
    {
        description = "Cream IceCream";
    }

    public override float Cost()
    {
        return 0.5f;
    }
}