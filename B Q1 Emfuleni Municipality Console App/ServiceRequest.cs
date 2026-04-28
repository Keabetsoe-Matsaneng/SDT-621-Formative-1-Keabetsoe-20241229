using System;

public class ServiceRequest
{
    public Resident Resident { get; set; }
    public string RequestType { get; set; }
    public int PriorityLevel { get; set; }
    public int SeverityLevel { get; set; }
    public int EstimatedHours { get; set; }

    public int UrgencyScore { get; set; }
    public int AdjustedResolutionHours { get; set; }   

    public ServiceRequest(Resident resident, string type, int priority, int severity, int hours)
    {
        Resident = resident;
        RequestType = type;
        PriorityLevel = priority;
        SeverityLevel = severity;
        EstimatedHours = hours;
    }
}
