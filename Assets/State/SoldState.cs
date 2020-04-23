using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldState : IState
{
    SodaMachine sodaMachine;

    public SoldState(SodaMachine _sodaMachine)
    {
        this.sodaMachine = _sodaMachine;
    }

    public void Dispense()
    {
        sodaMachine.ReleaseSoda();
        if (sodaMachine.GetCount() > 0)
        {
            sodaMachine.SetState(sodaMachine.GetNoMoneyState());
        } else
        {
            Debug.Log("No more soda");
            sodaMachine.SetState(sodaMachine.GetSoldOutState());
        }
    }

    public void EjectMoney()
    {
        Debug.Log("Sorry, you already pushed the button");
    }

    public void InsertMoney()
    {
        Debug.Log("Please wait, we're already giving you a soda");
    }

    public void PushButton()
    {
        Debug.Log("Pushing twice doesn't get you another soda");
    }
}
