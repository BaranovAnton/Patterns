using UnityEngine;

// Vehicle is controled by a driver
public class ControlByDriver : IControlBehavior
{
    public void Control()
    {
        Debug.Log("I'm controled by a driver");
    }
}
