
public interface ICommand
{
    void Execute();
    void Undo();
}

public class NoCommand : ICommand
{
    public void Execute() { }
    public void Undo() { }
}