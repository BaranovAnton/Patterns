using UnityEngine;

public class MenuIterator : Iterator
{
    MenuItem[] items;
    int position = 0;

    public MenuIterator(MenuItem[] items)
    {
        this.items = items;
    }

    public bool HasNext()
    {
        if (position >= items.Length || items[position] == null)
            return false;
        else
            return true;
    }

    public MenuItem Next()
    {
        MenuItem menuItem = items[position];
        position++;
        return menuItem;
    }
}
