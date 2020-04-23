using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public class StateExample : MonoBehaviour
{
    void Start()
    {
        SodaMachine sodaMachine = new SodaMachine(10);

        sodaMachine.InsertMoney();
        sodaMachine.PushButton();

        sodaMachine.PushButton();

        sodaMachine.InsertMoney();
        sodaMachine.PushButton();
    }
}
