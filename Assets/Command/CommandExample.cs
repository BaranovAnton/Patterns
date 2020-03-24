using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandExample : MonoBehaviour
{
    void Start()
    {
        Device device = new Device();

        Light light = new Light();

        LightOnCommand lightOnCommand = new LightOnCommand(light);
        LightOffCommand lightOffCommand = new LightOffCommand(light);

        device.SetCommand(0, lightOnCommand, lightOffCommand);
        device.OnButtonPressed(0);
        device.OffButtonPressed(0);
        device.UndoButtonPressed();
    }
}
