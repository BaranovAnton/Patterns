using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JobPathFacade
{
    string home;
    string garage;
    string parking;
    string road;
    string highway;
    string office_parking;
    string elevator;
    string office;

    public JobPathFacade(string home, string garage, string parking, string road, string highway, string office_parking, string elevator, string office)
    {
        this.home = home;
        this.garage = garage;
        this.parking = parking;
        this.road = road;
        this.highway = highway;
        this.office_parking = office_parking;
        this.elevator = elevator;
        this.office = office;
    }

    public void GoToTheOffice()
    {
        Debug.Log("Go to the office...");
        Debug.Log(home);
        Debug.Log(garage);
        Debug.Log(parking);
        Debug.Log(road);
        Debug.Log(highway);
        Debug.Log(office_parking);
        Debug.Log(elevator);
        Debug.Log(office);
    }

    public void GoHome()
    {
        Debug.Log("Go home...");
    }
}