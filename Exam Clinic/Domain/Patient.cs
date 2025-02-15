namespace Domain;

public class Patient : Person
{
    public List<MedicalRecord> MedicalHistory { get; set; }
    public BloodType BloodType { get; set; }
    public List<Appointment> Appointments { get; set; }
    public override string GetInfo()
    {
        return $"ID: {Id}. Name: {Name}, Age: {Age}";
    }
    public void AddAppointment(Appointment appointment){
        Appointments.Add(appointment);
    }

}
