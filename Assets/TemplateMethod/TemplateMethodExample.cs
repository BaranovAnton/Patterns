using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TemplateMethodExample : MonoBehaviour
{
    Cocktail cocktail = new Cocktail();
    Smoothie smoothie = new Smoothie();

    void Start()
    {
        Debug.Log("Making cocktail...");
        cocktail.PrepareRecipe();

        Debug.Log("Making smoothie...");
        smoothie.PrepareRecipe();
    }
}
