
public class NewYorkCakeStore : CakeStore
{
    protected override Cake CreateCake(string type)
    {
        if (type.Equals("Chocolate"))
        {
            return new NewYorkChocolateCake();
        }
        else if (type.Equals("IceCream"))
        {
            return new NewYorkIceCreamCake();
        }
        else if (type.Equals("Coconut"))
        {
            return new NewYorkCoconutCake();
        }
        else
        {
            return null;
        }
    }
}