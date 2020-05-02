using UnityEngine;

public class Proxy : ISubjectNew
{
    private RealSubject _realSubject;

    public Proxy(RealSubject realSubject)
    {
        _realSubject = realSubject;
    }

    public void Request()
    {
        if (this.CheckAccess())
        {
            this._realSubject = new RealSubject();
            this._realSubject.Request();

            this.LogAccess();
        }
    }

    public bool CheckAccess()
    {
        Debug.Log("Proxy: Checking access prior to firing a real request");

        return true;
    }

    public void LogAccess()
    {
        Debug.Log("Proxy: Logging the time of request");
    }
}