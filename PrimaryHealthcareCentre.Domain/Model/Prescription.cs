namespace PrimaryHealthcareCentre.Domain.Model
{
    public class Prescription
    {
        public int PrescriptionId { get; set; }
        public int PatientId { get; set; }
        public virtual Patient Patient { get; set; } = null!;

        public int PreparationId { get; set; }
        public virtual Preparation Preparation { get; set; } = null!;
        public DateTime Date { get; set; }
        public override string ToString()
        {
            return $"{Preparation.Name} {Preparation.Weight} {Preparation.QuantityPills}";
        }
    }
}
