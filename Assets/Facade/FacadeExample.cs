using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FacadeExample : MonoBehaviour
{
    JobPathFacade jobPathFacade = new JobPathFacade("Flat", "My garage", "Private parking", "Traffic", "Ehyyy highway", "Hi Joe", "Otis elevator", "Open space office");

    void Start()
    {
        jobPathFacade.GoToTheOffice();
        jobPathFacade.GoHome();
    }
}