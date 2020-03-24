using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Device
{
    ICommand[] onCommands;
    ICommand[] offCommands;
    ICommand undoCommand;

    public Device()
    {
        onCommands = new ICommand[2];
        offCommands = new ICommand[2];

        ICommand noCommand = new NoCommand();
        for (int i=0; i<2; i++)
        {
            onCommands[i] = noCommand;
            offCommands[i] = noCommand;
        }
        undoCommand = noCommand;
    }

    public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
    {
        onCommands[slot] = onCommand;
        offCommands[slot] = offCommand;
    }

    public void OnButtonPressed(int slot)
    {
        onCommands[slot].Execute();
        undoCommand = onCommands[slot];
    }

    public void OffButtonPressed(int slot)
    {
        offCommands[slot].Execute();
        undoCommand = offCommands[slot];
    }

    public void UndoButtonPressed()
    {
        undoCommand.Undo();
    }
}