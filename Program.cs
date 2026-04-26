
class Program
{

    static void Main()
    {
        ////The user inputs the student's name as well as the marks for all 3 subjects
        Console.Write("Enter student name: "); 
        string name = Console.ReadLine();
        Console.Write("Enter mark for subject 1: ");
        double subject1 = double.Parse(Console.ReadLine()); 
        Console.Write("Enter mark for subject 2: ");
        double subject2 = double.Parse(Console.ReadLine()); 
        Console.Write("Enter mark for subject 3: ");
        double subject3 = double.Parse(Console.ReadLine());

        //skips a line within the console
        Console.WriteLine(); 

        //Displays the student name, calculates the sum of all marks as well as the average
        Console.WriteLine("========== STUDENT RESULTS ========");
        Console.WriteLine("Student name: " + name); 
        Console.WriteLine("Total Marks: " + (subject1 + subject2 + subject3));
        Console.WriteLine("Average Marks: " + ((subject1 + subject2 + subject3) / 3)); 

        //determines whether or not the aforementioned student has passed
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
