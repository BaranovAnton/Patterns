using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrencyDisplay : MonoBehaviour, IObserver, IDisplayElement
{
    private float dollar;
    private float euro;
    private ISubject currencyData;

    public CurrencyDisplay(ISubject currencyData)
    {
        this.currencyData = currencyData;
        currencyData.RegisterObserver(this);
    }

    public void Display()
    {
        Debug.Log("Current currency rate: " + dollar + "$ " + euro + " EU");
    }

    public void UpdateCurrency(float dollar, float euro, float ruble)
    {
        this.dollar = dollar;
        this.euro = euro;
        Display();
    }
}