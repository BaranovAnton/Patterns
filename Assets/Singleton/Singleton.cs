using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton : MonoBehaviour
{
    private static Singleton instance;

    private Singleton() { }

    public static Singleton Instance()
    {
        if (instance == null)
            instance = new Singleton();

        return instance;
    }
}
