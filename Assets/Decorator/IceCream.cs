using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class IceCream
{
    public string description = "Unknown IceCream";

    public virtual string GetDescription()
    {
        return description;
    }

    public abstract float Cost();
}