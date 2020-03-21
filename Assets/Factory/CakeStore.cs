
public abstract class CakeStore
{
    public Cake OrderCake(string type)
    {
        Cake cake;

        cake = CreateCake(type);

        cake.Prepare();
        cake.Bake();
        cake.Cut();
        cake.Box();

        return cake;
    }

    protected abstract Cake CreateCake(string type);
}