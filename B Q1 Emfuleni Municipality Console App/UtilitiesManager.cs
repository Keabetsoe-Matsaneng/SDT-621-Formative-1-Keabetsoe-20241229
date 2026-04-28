using System;

public class UtilitiesManager
{
    public static int CalculateUrgency(ServiceRequest request)
    {
        return request.PriorityLevel * request.SeverityLevel * 8;
    }

    public static int CalculateAdjustedResolution(ServiceRequest request)
    {
        return request.EstimatedHours + (request.PriorityLevel + request.SeverityLevel) / 2;
    }

    public static double CalculateImpactScore(ServiceRequest request)
    {
        return request.Resident.MonthlyUsage * request.PriorityLevel;
    }

    public static void GenerateReport(ServiceRequest request)
    {
        Console.WriteLine("\n--- Service Report ---");
        Console.WriteLine($"Resident: {request.Resident.Name}");
        Console.WriteLine($"Service Type: {request.RequestType}");
        Console.WriteLine($"Urgency Score: {request.UrgencyScore}");
        Console.WriteLine($"Adjusted Resolution: {request.AdjustedResolutionHours} hours");
        Console.WriteLine($"Household Impact Score: {CalculateImpactScore(request): 0.00}");
    }
}