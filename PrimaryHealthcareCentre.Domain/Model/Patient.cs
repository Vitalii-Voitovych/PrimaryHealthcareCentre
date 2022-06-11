using System;
using System.Collections.Generic;

namespace PrimaryHealthcareCentre.Domain.Model
{
    public class Patient
    {
        public int PatientId { get; set; }
        public string FullName { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string PassportNumber{ get; set; }
        public string? WorkPlace { get; set; }
        public virtual MedicalCard MedicalCard { get; set; } = null!;
        public virtual List<Prescription> Prescriptions { get; set; } = null!;

        public Patient(string fullName, string gender, DateTime dateOfBirth, string phoneNumber, string passportNumber)
        {
            if (string.IsNullOrWhiteSpace(fullName))
            {
                throw new ArgumentNullException(nameof(fullName), "Full Name can`t null");
            }
            if (string.IsNullOrWhiteSpace(gender))
            {
                throw new ArgumentNullException(nameof(gender), "Gender can`t null");
            }
            if (dateOfBirth < DateTime.Parse("01.01.1922") || dateOfBirth > DateTime.UtcNow)
            {
                throw new ArgumentException("Date Birth can`t", nameof(dateOfBirth));
            }
            if (string.IsNullOrWhiteSpace(phoneNumber))
            {
                throw new ArgumentNullException(nameof(phoneNumber), "Phone number can`t null");
            }
            if (string.IsNullOrWhiteSpace(passportNumber))
            {
                throw new ArgumentNullException(nameof(passportNumber), "Passport number can`t null");
            }
            FullName = fullName;
            Gender = gender;
            DateOfBirth = dateOfBirth;
            PhoneNumber = phoneNumber;
            PassportNumber = passportNumber;
        }
        public override string ToString()
        {
            return $"{FullName} {Gender} {DateOfBirth}";
        }
    }
}
