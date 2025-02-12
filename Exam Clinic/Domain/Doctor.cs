namespace Domain;

public class Doctor : Person
{
    public Specialization Specialization { get; set; }
    public List<Patient> Patients { get; set; }
    public override string GetInfo()
    {
        foreach (var item in Patients)
        {
            System.Console.WriteLine(item);
        }
        return $"Name: {Name}, Age: {Age}, Specialization: {Specialization}";
    }
    public void AddPatient(Patient patient)
    {
        Patients.Add(patient);
    }
}
