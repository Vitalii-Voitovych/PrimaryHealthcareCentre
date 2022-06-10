namespace PrimaryHealthcareCentre.Domain.Model
{
    public class MedicalCard
    {
        public int MedicalCardId { get; set; }
        public int PatientId { get; set; }
        public virtual Patient Patient { get; set; } = null!;
        public string Diagnosis { get; set; } = null!;
        public string MedicalHistory { get; set; } = null!;
        public DateTime FillingDate { get; set; }

        public override string ToString()
        {
            return $"{Patient.FullName} {Diagnosis}";
        }
    }
}
