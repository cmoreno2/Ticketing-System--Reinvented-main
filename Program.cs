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
    
    Ticket t = new Ticket();

    sw.WriteLine($"{t.TicketID},{t.Summery},{t.Status},{t.Priority},{t.Assigned},{t.Submitter},{t.Watch}");

    sw.Close();

    }
}  while (choice == "1" || choice == "2");
