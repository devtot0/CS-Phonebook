// See https://aka.ms/new-console-template for more information

string selectOption = null;
do
{
    Console.WriteLine("=======PHONEBOOK=======");
    Console.WriteLine("1 - Add a contact");
    Console.WriteLine("2 - Display by number");
    Console.WriteLine("3 - Display all contacts");
    Console.WriteLine("4 - Search by name");
    Console.WriteLine("5 - Exit");
    Console.Write(">");
    selectOption = Console.ReadLine();
    if(selectOption == "5")
    {
        Console.WriteLine("Quitting...");
        break;
    }
    switch (selectOption)
    {
        case "5":
            Console.WriteLine("Quitting...");
            break;
    }
} while (true);

