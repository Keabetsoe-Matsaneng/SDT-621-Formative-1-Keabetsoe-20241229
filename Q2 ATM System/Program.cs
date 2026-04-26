class Program
{

    static void Main()
    {
        //Project Title
        Console.WriteLine("========== Simple ATM System ========");

        Console.WriteLine();

        //Takes the user's name and displays it
        Console.Write("Hello Customer, what is your name? ");
        string name = Console.ReadLine();

        Console.WriteLine(name);

        Console.WriteLine();

        Console.WriteLine("WELCOME " + name + "!");

        //Enters both the account and withdrawal balance
        Console.Write("Enter your account balance: ");
        double balance = double.Parse(Console.ReadLine());
        Console.Write("Enter the withdrawal amount: ");
        double withdrawal = double.Parse(Console.ReadLine());

        Console.WriteLine();

        //If statement to ensure that user cannot withdraw more money than they have
        if (withdrawal > balance)
        {
            Console.WriteLine("WITHDRAWAL UNSUCCESSFUL!");
            Console.WriteLine("BALANCE INSUFFICIENT");
        }
        else
        {
            Console.WriteLine("WITHDRAWAL SUCCESSFUL!");
            Console.WriteLine("Updated balance: " + "R" + (balance - withdrawal));
        }

        //Displays the current date
        DateTime now = DateTime.Now;

        Console.WriteLine("Transaction Processed at: " + now);
    }
}