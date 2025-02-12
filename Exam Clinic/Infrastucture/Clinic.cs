namespace Infrastucture;
using Domain;
public class Clinic
{
    public List<Doctor> Doctors { get; set; }
    public List<Patient> Patients { get; set; }
    public List<Appointment> Appointments { get; set; }
    public Clinic()
    {
        Doctors = new List<Doctor>();
        Patients = new List<Patient>();
        Appointments = new List<Appointment>();
    }
    public void RegisterPatient(Patient patient){
        Patients.Add(patient);
        System.Console.WriteLine("Patien is registered!");
    }
    public void AddDoctor(Doctor doctor){
        Doctors.Add(doctor);
        System.Console.WriteLine("Doctor added!");
    }
    public void CreateAppointment(Patient patient, Doctor doctor){
        Appointment appointment = new Appointment(){Patient = patient, Doctor = doctor};
        Appointments.Add(appointment);
        System.Console.WriteLine("Succesfully created appointment!");
    }
    public List<Doctor> FindDoctorsBySpecialization(Specialization spec){
        List<Doctor> doctors = new List<Doctor>();
        foreach (var item in Doctors)
        {
            if (item.Specialization == spec)
            {
                doctors.Add(item);
            }
        }
        return doctors;
    }
    public List<Appointment> GetPatientAppointments(string patientId){
        List<Appointment> appointments = new List<Appointment>();
        foreach (var item in Appointments)
        {
            if (item.Id == patientId)
            {
                appointments.Add(item);
            }
        }
        return appointments;
    }
    public List<Patient> GetDoctorPatients(string doctorId){
        List<Patient> patients = new List<Patient>();
        foreach (var item in Patients)
        {
            if (item.Id == doctorId)
            {
                patients.Add(item);
            }
        }
        return patients;
    }
    public void CancelAppointment(string appointmentId){
        foreach (var item in Appointments)
        {
            if (item.Id == appointmentId)
            {
                Appointments.Remove(item);
                System.Console.WriteLine("Appointment is cancelled!");
                return;
            }
        }
    }
    public List<MedicalRecord>? GetPatientHistory(string patientId){
        foreach (var item in Patients)
        {
            if (item.Id == patientId)
            {
                return item.MedicalHistory;
            }
        }
        return null;
    }
}
