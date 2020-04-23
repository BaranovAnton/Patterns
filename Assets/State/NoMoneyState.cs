using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoMoneyState : IState
{
    SodaMachine sodaMachine;

    public NoMoneyState(SodaMachine _sodaMachine)
    {
        this.sodaMachine = _sodaMachine;
    }

    public void Dispense()
    {
        Debug.Log("No soda dispensed");
    }

    public void EjectMoney()
    {
        Debug.Log("Sorry, no money for getting back");
    }

    public void InsertMoney()
    {
        Debug.Log("You inserted money");
        sodaMachine.SetState(sodaMachine.GetHasMoneyState());
    }

    public void PushButton()
    {
        Debug.Log("Insert money before");
    }
}
