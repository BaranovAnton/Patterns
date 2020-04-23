using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public class SoldOutState : IState
{
    SodaMachine sodaMachine;

    public SoldOutState(SodaMachine _sodaMachine)
    {
        this.sodaMachine = _sodaMachine;
    }

    public void Dispense()
    {
        Debug.Log("No soda");
    }

    public void EjectMoney()
    {
        Debug.Log("No soda");
    }

    public void InsertMoney()
    {
        Debug.Log("No soda");
    }

    public void PushButton()
    {
        Debug.Log("No soda");
    }
}
