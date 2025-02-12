namespace Domain;

public class Appointment
{
    public string Id { get; set; }
    public Patient Patient { get; set; }
    public Doctor Doctor { get; set; }
    public DateTime DateTime { get; set; }
    public AppointmentStatus Status { get; set; }
    public void Cancel()
    {
        Status = AppointmentStatus.Cancelled;
    }
    public void Reschedule(DateTime newDateTime)
    {
        DateTime = newDateTime;
        System.Console.WriteLine($"You are rescheduled your time. New time is {DateTime}");
    }
    public string GetAppointmentInfo()
    {
        switch (Status)
        {
            case AppointmentStatus.Completed:
                return $"Status: {Status}. Doctor: {Doctor}, Patient: {Patient}";
            case AppointmentStatus.Cancelled:
                return "Appointment cancelled";
            case AppointmentStatus.NoShow:
                return "Status no show";
            case AppointmentStatus.Scheduled:
                return $"You're schedules in {DateTime}";
            default:
                return "Error in Appointment Status";
        }
    }
}
