namespace PrimaryHealthcareCentre.Domain.Model
{
    public class Examination
    {
        public int ExaminationId { get; set; }
        
        public int ReceptionId { get; set; }
        public virtual Reception Reception { get; set; } = null!;
        public DateTime Date { get; set; }
    }
}
