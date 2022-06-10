using System;

namespace PrimaryHealthcareCentre.Domain.Model
{
    public class Preparation
    {
        public int PreparationId { get; set; }
        public string Name { get; set; } = null!;
        public double Weight { get; set; }
        public int QuantityPills { get; set; }
        public virtual List<Prescription> Prescriptions { get; set; } = null!;

        public Preparation(string name, double weight, int quantityPills)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException(nameof(name), "Full Name can`t null");
            }
            if (weight <= 0.0)
            {
                throw new ArgumentException();
            }
            if (quantityPills <= 0)
            {
                throw new ArgumentException();
            }
            Name = name;
            Weight = weight;
            QuantityPills = quantityPills;
        }
    }
}
