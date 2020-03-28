using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MallardDuck : IDuck
{
    public void Fly()
    {
        Debug.Log("I'm flying");
    }

    public void Quack()
    {
        Debug.Log("Quack");
    }
}