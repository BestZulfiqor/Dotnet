namespace Domain;

public class MedicalRecord
{
    public string Id { get; set; }
    public DateTime Date { get; set; }
    public string Diagnosis { get; set; }
    public string Treatment { get; set; }
    public string GetSummary(){
        return $"ID: {Id}. Diagnosis: {Diagnosis}, Treatment: {Treatment}, Date: {Date}";
    }
    public MedicalRecord()
    {
        Date = DateTime.Now;
        Id = Guid.NewGuid().ToString();
    }
}
