
class Program
{

    static void Main()
    {
        Console.Write("Enter student name: "); //The user inputs the student name
        string name = Console.ReadLine();
        Console.Write("Enter mark for subject 1: ");
        double subject1 = double.Parse(Console.ReadLine()); //user inputs the marks for the first subject
        Console.Write("Enter mark for subject 2: ");
        double subject2 = double.Parse(Console.ReadLine()); //user inputs the marks for the second subject
        Console.Write("Enter mark for subject 3: ");
        double subject3 = double.Parse(Console.ReadLine()); //user inputs the marks for the third subject


        Console.WriteLine(); //skips a line within the console
        Console.WriteLine("========== STUDENT RESULTS ========");
        Console.WriteLine("Student name: " + name); //displays the students name
        Console.WriteLine("Total Marks: " + (subject1 + subject2 + subject3)); // sums all the marks to get the total
        Console.WriteLine("Average Marks: " + ((subject1 + subject2 + subject3) / 3)); //calculates the average for the marks

        //determines whether or not the student has passed
        if (((subject1 + subject2 + subject3) / 3) > 50)
        {
            Console.WriteLine("Result: PASS");
        }
        else
        {
            Console.WriteLine("Result: FAIL");
        }

        //Determines the current date and time
        DateTime now = DateTime.Now;

        Console.WriteLine("Results Issued at: " + now);
    }


}
