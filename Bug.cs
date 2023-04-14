
public class Bug : Ticket

{
    public string? Severity {get; set;}
    public Bug()
    {
        Console.WriteLine("What is the Severity of the ticket? ");
        Severity = Console.ReadLine();
    }

}
