class Test
{
    public string Message {get; set;}

    public Test(string message) => this.Message = message;

    public void Show()
    {
        Console.Writeline(Message);
    }
}