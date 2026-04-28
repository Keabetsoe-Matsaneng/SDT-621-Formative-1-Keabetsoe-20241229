using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Welcome to Emfuleni Municipality Service Desk ===");

        Console.Write("How many residents do you want to register? ");
        int residentCount = int.Parse(Console.ReadLine());

        List<Resident> residents = new List<Resident>();

        for (int i = 0; i < residentCount; i++)
        {
            Console.WriteLine("\n--- Resident " + (i + 1) + " ---");

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Address: ");
            string address = Console.ReadLine();

            Console.Write("Account Number: ");
            string acc = Console.ReadLine();

            Console.Write("Monthly Utility Usage (kW or litres): ");
            double usage = double.Parse(Console.ReadLine());

            residents.Add(new Resident(name, address, acc, usage));
        }

        Console.Write("\nHow many service requests do you want to log? ");
        int requestCount = int.Parse(Console.ReadLine());

        List<ServiceRequest> requests = new List<ServiceRequest>();

        for (int i = 0;i < requestCount;i++)
        {
            Console.WriteLine("\n--- Service Request " + (i + 1) + " ---");

            Console.Write("Select resident by number (1 to " + residents.Count + "): ");
            int index = int.Parse(Console.ReadLine()) - 1;

            Console.Write("Request Type (e.g., Water Outage, Burst Pipe): ");
            string type = Console.ReadLine();

            Console.Write("Priority level (1-5): ");
            int priority = int.Parse(Console.ReadLine());

            Console.Write("Severity level (1-10): ");
            int severity = int.Parse(Console.ReadLine());

            Console.Write("Estimate Resolution Hours: ");
            int hours = int.Parse(Console.ReadLine());

            var request = new ServiceRequest(residents[index], type, priority, severity, hours);

            request.UrgencyScore = UtilitiesManager.CalculateUrgency(request);
            request.AdjustedResolutionHours = UtilitiesManager.CalculateAdjustedResolution(request);

            requests.Add(request);

        }

        List<ServiceRequest> processed = new List<ServiceRequest>();


        foreach (var req in requests)
        {
            UtilitiesManager.GenerateReport(req);
            processed.Add(req);
        }

        Console.WriteLine("\n==== FINAL MUNICIPALITY SUMMARY ====");

        ServiceRequest highest = null;

        foreach (var req in processed)
        {
            if (highest == null || req.UrgencyScore > highest.UrgencyScore)
                highest = req;
        }

        if (highest != null)
        {
            Console.WriteLine("Highest Priority Issue:");
            Console.WriteLine($"Resident: {highest.Resident.Name}");
            Console.WriteLine($"Service Type: {highest.RequestType}");
            Console.WriteLine($"Urgency Score: {highest.UrgencyScore}");
            Console.WriteLine($"Adjusted Resolution: {highest.AdjustedResolutionHours} hours");
            Console.WriteLine($"Household Impact Score: {UtilitiesManager.CalculateImpactScore(highest):0.00}");

        }

        Console.WriteLine("\nThank you for using the Emfuleni Municipality Service Desk.");
           
    }
}