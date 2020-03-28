using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurkeyAdapter : IDuck
{
    ITurkey turkey;

    public TurkeyAdapter(ITurkey turkey)
    {
        this.turkey = turkey;
    }

    public void Fly()
    {
        for (int i=0; i<5; i++)
        {
            turkey.Fly();
        }
    }

    public void Quack()
    {
        turkey.Fly();
    }
}