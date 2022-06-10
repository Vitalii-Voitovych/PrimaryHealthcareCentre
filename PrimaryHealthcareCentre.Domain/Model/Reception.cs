using System;

namespace PrimaryHealthcareCentre.Domain.Model
{
    public class Reception
    {
        public int ReceptionId { get; set; }
        
        public int PatientId { get; set; }
        public virtual Patient Patient { get; set; } = null!;

        public int DoctorId { get; set; }
        public virtual Doctor Doctor { get; set; } = null!;
        public DateTime DateOfReception { get; set; }
        public virtual Examination Examination { get; set; } = null!;
    }
}
