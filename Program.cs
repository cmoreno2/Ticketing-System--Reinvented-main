using System.IO;
string file = "TicketingSystem.txt";
string choice;
do
{
    // ask user a question
    Console.WriteLine("1) Read data from file.");
    Console.WriteLine("2) Create file from data.");
    Console.WriteLine("Enter any other key to exit.");
    // input response
    choice = Console.ReadLine();

    if (choice == "1")
    {
        // read data from file
        if (File.Exists(file))
        {
            // read data from file
            StreamReader sr = new StreamReader(file);
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                // convert string to array
                string[] arr = line.Split(',');
                // display array data
                Console.WriteLine("{0},{1},{2},{3},{4},{5},{6}", arr[0], arr[1], arr[2], arr[3], arr[4], arr[5], arr[6]);
            }
            sr.Close();
        }
        else
        {
            Console.WriteLine("File does not exist");
        }
    }
    else if (choice == "2")
    {
            // create file from data
    StreamWriter sw = new StreamWriter(file, append: true);
    for (int i = 0; i < 7; i++)
    {
        Console.WriteLine("Enter Ticket(Y/N)?");
        // input the response
        string resp = Console.ReadLine().ToUpper();
        // if the response is anything other than "Y", stop asking
        if (resp != "Y") { break; }
        Console.WriteLine("Enter Ticket ID");
        int TicketID = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Give a Ticket Summery");
        string? Summery = Console.ReadLine();

        Console.WriteLine("What is current Ticket Status");
        string? Status = Console.ReadLine();
       
        Console.WriteLine("What is the Tickets Priority");
        string? Priority = Console.ReadLine();

        Console.WriteLine("Give Ticket Submitter");
        string? Submitter = Console.ReadLine();

        Console.WriteLine("Who is the Ticket Assigned to");
        string? Assigned = Console.ReadLine();
       
        Console.WriteLine("Who is on Ticket Watch");
        string? Watch = Console.ReadLine();
        sw.WriteLine("{0},{1},{2},{3},{4},{5},{6}", TicketID, Summery, Status, Priority, Submitter, Assigned, Watch);
    }
    sw.Close();
    }
}  while (choice == "1" || choice == "2");
