using System;
using Domain;
using Infrastucture;

class Program
{
    static void Main(string[] args)
    {
        Patient patient1 = new Patient(){Name = "Ali", Age = 18, BloodType = BloodType.ANegative, Id = "1"};

        Doctor doctor = new Doctor(){Name = "Shoir", Id = "1", Specialization = Specialization.Surgeon};
        Appointment appointment = new Appointment(){Patient = patient1, DateTime = DateTime.Now, Id = "1", Doctor = doctor, Status = AppointmentStatus.Scheduled};
        Clinic clinic = new Clinic(){};
        clinic.AddDoctor(doctor);
        clinic.CreateAppointment(patient1, doctor);
        clinic.CancelAppointment("1");

        System.Console.WriteLine("Вывод докторов по специальности: ");
        foreach (var item in clinic.FindDoctorsBySpecialization(Specialization.Surgeon))
        {
            System.Console.WriteLine($"Name: {item.Name}, Age: {item.Age}, Special: {item.Specialization}");
        };
        clinic.RegisterPatient(patient1);

        System.Console.WriteLine("Вывод пациентов доктора");
        foreach (var item in clinic.GetDoctorPatients("1"))
        {
            System.Console.WriteLine($"Name: {item.Name}, Age: {item.Age}, BloodType: {item.BloodType}");
        };

        System.Console.WriteLine("Patient appointment: ");
        foreach (var item in clinic.GetPatientAppointments("1"))
        {
            System.Console.WriteLine(item);
        }
    }
}