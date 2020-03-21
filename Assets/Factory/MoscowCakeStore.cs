
public class MoscowCakeStore : CakeStore
{
    protected override Cake CreateCake(string type)
    {
        if (type.Equals("Chocolate"))
        {
            return new MoscowChocolateCake();
        }
        else if (type.Equals("IceCream"))
        {
            return new MoscowIceCreamCake();
        }
        else if (type.Equals("Coconut"))
        {
            return new MoscowCoconutCake();
        }
        else
        {
            return null;
        }
    }
}