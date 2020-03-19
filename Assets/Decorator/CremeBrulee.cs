using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CremeBrulee : IceCream
{
    public CremeBrulee()
    {
        description = "CremeBrulee IceCream";
    }

    public override float Cost()
    {
        return 0.7f;
    }
}