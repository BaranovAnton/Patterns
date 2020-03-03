using UnityEngine;

// Vehicle which use ICE
public class MoveByICE : IMoveBehavior
{
    public void Move()
    {
        Debug.Log("For moving I use an internal combustion engine (ICE)");
    }
}