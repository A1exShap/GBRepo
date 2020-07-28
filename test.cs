class Test : IShow
{
    public string Message {get; private set;}

    public Test(string message) => this.Message = message;

    public void Show()
    {
        Console.Writeline($"This is the legasy messenger: {Message}");
    }
}