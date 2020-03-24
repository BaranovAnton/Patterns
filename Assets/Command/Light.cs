using UnityEngine;

public class Light 
{
    public void On() 
    {
        Debug.Log("Light On");
    }

    public void Off() 
    {
        Debug.Log("Light Off");
    }
}

public class LightOnCommand : ICommand
{
    Light light;

    public LightOnCommand(Light light)
    {
        this.light = light;
    }

    public void Execute()
    {
        light.On();
    }

    public void Undo()
    {
        light.Off();
    }
}

public class LightOffCommand : ICommand
{
    Light light;

    public LightOffCommand(Light light)
    {
        this.light = light;
    }

    public void Execute()
    {
        light.Off();
    }

    public void Undo()
    {
        light.On();
    }
}