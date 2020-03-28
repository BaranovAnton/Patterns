using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdapterExample : MonoBehaviour
{
    void Start()
    {
        MallardDuck duck = new MallardDuck();
        WildTurkey turkey = new WildTurkey();
        IDuck turkeyAdapter = new TurkeyAdapter(turkey);

        turkey.Gobble();
        turkey.Fly();

        TestDuck(duck);
        TestDuck(turkeyAdapter);
    }

    void TestDuck(IDuck duck)
    {
        duck.Quack();
        duck.Fly();
    }
}