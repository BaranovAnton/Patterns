using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IObserver
{
    void Update(float dollar, float euro, float ruble);
}