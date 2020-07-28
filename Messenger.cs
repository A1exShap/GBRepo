public class Messenger : IShow
{
    public string Message {get; private set;}

    public Messenger(string message) => this.Message = message;

    public void Show()
    {
        Console.Writeline(Message);
    }
}