using UnityEngine;

public class IteratorExample : MonoBehaviour
{
    void Start()
    {
        MenuItem[] menu = new MenuItem[3];
        menu[0] = new MenuItem("Coke", 100);
        menu[1] = new MenuItem("Snikers", 200);
        menu[2] = new MenuItem("Mars", 180);

        MenuIterator menuIterator = new MenuIterator(menu);

        while (menuIterator.HasNext())
        {
            MenuItem item = menuIterator.Next();
            Debug.Log(item.GetName());
            Debug.Log(item.GetPrice());
        }
    }
}
