using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProxeExample : MonoBehaviour
{
    void Start()
    {
        Client client = new Client();

        Debug.Log("Client: Executing the client code with a real subject:");
        RealSubject realSubject = new RealSubject();
        client.ClientCode(realSubject);

        Debug.Log("Client: Executing the same client code with a proxy:");
        Proxy proxy = new Proxy(realSubject);
        client.ClientCode(proxy);
    }
}