using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactoryExample : MonoBehaviour
{
    void Start()
    {
        CakeStore moscowStore = new MoscowCakeStore();
        Cake moscowCake = moscowStore.OrderCake("Chocolate");

        CakeStore nyStore = new NewYorkCakeStore();
        Cake nyCake = nyStore.OrderCake("Coconut");
    }
}
