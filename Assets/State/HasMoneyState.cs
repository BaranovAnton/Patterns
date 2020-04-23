using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HasMoneyState : IState
{
    SodaMachine sodaMachine;

    public HasMoneyState(SodaMachine _sodaMachine)
    {
        this.sodaMachine = _sodaMachine;
    }

    public void Dispense()
    {
        Debug.Log("No soda dispensed");
    }

    public void EjectMoney()
    {
        Debug.Log("Money returned");
        sodaMachine.SetState(sodaMachine.GetNoMoneyState());
    }

    public void InsertMoney()
    {
        Debug.Log("You can't add more money!");
    }

    public void PushButton()
    {
        Debug.Log("You pushed the button...");
        sodaMachine.SetState(sodaMachine.GetSoldState());
    }
}