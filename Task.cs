public class Task : Ticket

{
    public string? ProjectName {get; set;}
    public DateOnly DueDate {get; set;}
    public Task()
    {
        Console.WriteLine("What is the Project Name? ");
        ProjectName = Console.ReadLine();

        Console.WriteLine("What is the Due Date?(yyyy/mm/dd)");
        DueDate = DateOnly.Parse(Console.ReadLine());
    }
}
