using UnityEngine;

public class RealSubject : ISubjectNew
{
    public void Request()
    {
        Debug.Log("RealSubject: Handling Request");
    }
}