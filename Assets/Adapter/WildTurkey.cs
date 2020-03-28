using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WildTurkey : ITurkey
{
    public void Fly()
    {
        Debug.Log("I'm flying a short distance");
    }

    public void Gobble()
    {
        Debug.Log("Gobble gobble");
    }
}