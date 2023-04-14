using System.IO;
string file = "TicketingSystem.txt";
string TicketFile = "Ticket.csv";
string EenhancementFile = "Enhancement.csv";
string TaskFile = "Task.csv";
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
        Console.WriteLine("Which Tickets do you want to see? 1.Bugs 2.Enhancements 3.Tasks");
        switch (Convert.ToInt32(Console.ReadLine()))
        {
            case 1:
                readBugDefect(TicketFile);
                break;
            case 2:
                readEnhancement(EenhancementFile);
                break;
            case 3:
                readTask(TaskFile);
                break;
            default:
                Console.WriteLine("Please enter a number 1 - 3");
                break;

        }
        

    }
    else if (choice == "2")
    {
        bool addTicket = false;

        do
        {

            Console.WriteLine("What kind of ticket do you want to add? 1.Bug 2.Enhancements 3.Tasks ");
            string ticketChoice = Console.ReadLine();
            switch (ticketChoice)
            {
                case "1":
                    writeBugDefect(TicketFile);
                    break;
                case "2":
                    writeEnhancement(EenhancementFile);
                    break;
                case "3":
                    writeTask(TaskFile);
                    break;
                default:
                    Console.WriteLine("Number must be 1, 2, or 3");
                    break;
            }
            Console.WriteLine("Add another ticket? (Y/N)");
            string resp = Console.ReadLine();
            if (resp == "Y") 

            { 
                addTicket = true; 
            }
            else if (resp == "N") 
            { 
                addTicket = false; 
            }

        } while (addTicket);
    }
} while (choice == "1" || choice == "2");

static void readBugDefect(string file)

{
    if (File.Exists(file))
    {
        // read data from file
        StreamReader sr = new StreamReader(file);

        while (!sr.EndOfStream)
        {

            string line = sr.ReadLine();
            // convert string to array, splitting it at the comma "," 
            string[] arr = line.Split(',');

            //display array data
            
            Console.WriteLine($"{arr[0]}, {arr[1]}, {arr[2]}, {arr[3]}, {arr[4]}, {arr[5]}, {arr[6]}, {arr[7]}");
        }
        sr.Close();
    }
    else
    {
        Console.WriteLine("File does not exist or nothing in file");
    }
}

static void writeBugDefect(string file)
{
        // create file from data
        StreamWriter sw1 = new StreamWriter(file, append: true);

        Bug t = new Bug();

        sw1.WriteLine($"{t.TicketID},{t.Summery},{t.Status},{t.Priority},{t.Assigned},{t.Watch},{t.Submitter},{t.Severity}");

        sw1.Close();
    }

    static void readEnhancement(string file)
    {
        if (File.Exists(file))
        {
            // read data from file
            StreamReader sr = new StreamReader(file);

            while (!sr.EndOfStream)
            {

                string line = sr.ReadLine();
                // convert string to array, splitting it at the comma "," 

                string[] arr = line.Split(',');

                //display array data
                Console.WriteLine($"{arr[0]}, {arr[1]}, {arr[2]}, {arr[3]}, {arr[4]}, {arr[5]}, {arr[6]}, {arr[7]}, {arr[8]}, {arr[9]}, {arr[10]}");
            }
            sr.Close();
        }
        else
        {
            Console.WriteLine("File does not exist");
        }
    }

    static void writeEnhancement(string file)
    {

        // create file from data
        StreamWriter sw2 = new StreamWriter(file, append: true);

        Enhancement t = new Enhancement();
        
        sw2.WriteLine($"{t.TicketID},{t.Summery},{t.Status},{t.Priority},{t.Assigned},{t.Watch},{t.Submitter},{t.Software},{t.Cost},{t.Reason},{t.Estimate}");

        sw2.Close();
    }

    static void readTask(string file)

    {
        if (File.Exists(file))
        {
            // read data from file
            StreamReader sr = new StreamReader(file);

            while (!sr.EndOfStream)
            {

                string line = sr.ReadLine();
                // convert string to array, splitting it at the comma "," 
                string[] arr = line.Split(',');
 
                //display array data
                Console.WriteLine($"{arr[0]}, {arr[1]}, {arr[2]}, {arr[3]}, {arr[4]}, {arr[5]}, {arr[6]}, {arr[7]}, {arr[8]}");
            }
            sr.Close();
        }
        else
        {
            Console.WriteLine("File does not exist");
        }
    }
    static void writeTask(string file)
    {

        // create file from data
        StreamWriter sw3 = new StreamWriter(file, append: true);

        Task tk = new Task();
        
        sw3.WriteLine($"{tk.TicketID},{tk.Summery},{tk.Status},{tk.Priority},{tk.Assigned},{tk.Watch},{tk.Submitter},{tk.ProjectName},{tk.DueDate}");

        sw3.Close();
    }