using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Vehicle : MonoBehaviour
{
    IMoveBehavior moveBehavior;
    IControlBehavior controlBehavior;

    public Vehicle() {}

    public abstract void DisplayInfo();

    public void PerformMove ()
    {
        moveBehavior.Move();
    }

    public void PerformControl()
    {
        controlBehavior.Control();
    }
}
