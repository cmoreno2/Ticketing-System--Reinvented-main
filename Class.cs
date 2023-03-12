class Ticket
{
public int TicketID {get; set;}
public string?  Summery {get; set;}
public string?  Status {get; set;}
public string? Priority {get; set;}
public string? Submitter {get; set;}
public string? Assigned {get; set;}
public string? Watch {get; set;}
public Ticket()
    {
    Console.WriteLine("Enter Ticket ID");
    TicketID = Convert.ToInt32((Console.ReadLine()));

    Console.WriteLine("Give a Ticket Summery");
    Summery = Console.ReadLine();

    Console.WriteLine("What is current Ticket Status");
    Status = Console.ReadLine();
       
    Console.WriteLine("What is the Tickets Priority");
    Priority = Console.ReadLine();

    Console.WriteLine("Give Ticket Submitter");
    Submitter = Console.ReadLine();

    Console.WriteLine("Who is the Ticket Assigned to");
    Assigned = Console.ReadLine();
       
    Console.WriteLine("Who is on Ticket Watch");
    Watch = Console.ReadLine();
    }
}
