using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IState
{
    void InsertMoney();
    void EjectMoney();
    void PushButton();
    void Dispense();
}
