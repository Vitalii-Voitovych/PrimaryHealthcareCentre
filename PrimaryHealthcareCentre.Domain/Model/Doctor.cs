namespace PrimaryHealthcareCentre.Domain.Model
{
    public class Doctor
    {
        public int DoctorId { get; set; }
        public string FullName { get; set; }
        public string Specialty { get; set; }
        public string PhoneNumber { get; set; }
        public string? Email { get; set; }
        public int CabinetNumber { get; set; }
        public string Department { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public virtual List<Reception> Receptions { get; set; } = null!;

        public Doctor(string fullName, string specialty, string phoneNumber, int cabinetNumber, string department, string startTime, string endTime)
        {
            if (string.IsNullOrWhiteSpace(fullName))
            {
                throw new ArgumentNullException(nameof(fullName), "Full Name can`t null");
            }
            if (string.IsNullOrWhiteSpace(specialty))
            {
                throw new ArgumentNullException(nameof(specialty), "Specialty can`t null");
            }
            if (string.IsNullOrWhiteSpace(phoneNumber))
            {
                throw new ArgumentNullException(nameof(phoneNumber), "Phone number can`t null");
            }
            if (cabinetNumber <= 0)
            {
                throw new ArgumentException("Cabinet number can`t be less than or equal to 0", nameof(cabinetNumber));
            }
            if (string.IsNullOrWhiteSpace(department))
            {
                throw new ArgumentNullException(nameof(department), "Phone number can`t null");
            }
            FullName = fullName;
            Specialty = specialty;
            PhoneNumber = phoneNumber;
            CabinetNumber = cabinetNumber;
            Department = department;
            StartTime = startTime;
            EndTime = endTime;
        }

        public override string ToString()
        {
            return $"{FullName} {Specialty} {CabinetNumber} {StartTime}-{EndTime}";
        }
    }
}
