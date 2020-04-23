using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SodaMachine
{
    IState soldOutState;
    IState noMoneyState;
    IState hasMoneyState;
    IState soldState;
    
    IState state;
    int count;

    public SodaMachine(int _count)
    {
        soldOutState = new SoldOutState(this);
        noMoneyState = new NoMoneyState(this);
        hasMoneyState = new HasMoneyState(this);
        soldState = new SoldState(this);

        state = soldOutState;
        count = _count;

        if (count > 0)
            state = noMoneyState;
    }

    public void InsertMoney()
    {
        state.InsertMoney();
    }

    public void EjectMoney()
    {
        state.EjectMoney();
    }

    public void PushButton()
    {
        state.PushButton();
        state.Dispense();
    }

    public void SetState(IState _state)
    {
        this.state = _state;
    }

    public void ReleaseSoda()
    {
        Debug.Log("Soda is ready... almost");
        if (count != 0)
            count--;
    } 

    public int GetCount()
    {
        return count;
    }

    public IState GetNoMoneyState()
    {
        return noMoneyState;
    }

    public IState GetSoldState()
    {
        return soldState;
    }

    public IState GetSoldOutState()
    {
        return soldOutState;
    }

    public IState GetHasMoneyState()
    {
        return hasMoneyState;
    }
}