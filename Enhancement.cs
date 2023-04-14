public class Enhancement : Ticket

{
    public string? Software {get; set;}
    public double Cost {get; set;}
    public string? Reason {get; set;}
    public string? Estimate {get; set;}
    public Enhancement()
    {
        Console.WriteLine("What software is used for the ticket? ");
        Software = Console.ReadLine();

        Console.WriteLine("What is the cost of the ticket? ");
        Cost = Double.Parse(Console.ReadLine());

        Console.WriteLine("What is the reason for this Ticket? ");
        Reason = Console.ReadLine();

        Console.WriteLine("What Estamate is given for this Ticket? ");
        Estimate = Console.ReadLine();
    }

}
