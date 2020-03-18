using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Currency : MonoBehaviour, ISubject
{
    private List<IObserver> observers = new List<IObserver>();
    private float dollar, euro, ruble;

    public void RegisterObserver(IObserver o)
    {
        observers.Add(o);
    }

    public void RemoveObserver(IObserver o)
    {
        int i = observers.IndexOf(o);
        if (i >= 0)
        {
            observers.RemoveAt(i);
        }
    }

    public void NotifyObserver()
    {
        for (int i=0; i<observers.Count; i++)
        {
            IObserver observe = observers[i];
            observe.Update(dollar, euro, ruble);
        }
    }

    public void SetCurrencyRate(float dollar, float euro, float ruble)
    {
        this.dollar = dollar;
        this.euro = euro;
        this.ruble = ruble;
        CurrencyChanged();
    }

    public void CurrencyChanged()
    {
        NotifyObserver();
    }
}
