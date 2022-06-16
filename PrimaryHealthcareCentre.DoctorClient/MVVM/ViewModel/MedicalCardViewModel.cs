using Microsoft.EntityFrameworkCore;
using PrimaryHealthcareCentre.Domain.Model;
using PrimaryHealthcareCentre.UIComponent.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimaryHealthcareCentre.DoctorClient.MVVM.ViewModel
{
    public class MedicalCardViewModel : BaseViewModel
    {
        private MedicalCard medicalCard = null!;
        public MedicalCard MedicalCard
        {
            get => medicalCard;
            set
            {
                medicalCard = value;
                OnPropertyChanged();
            }
        }

        public string Diagnosis { get; set; } = null!;
        public string MedicalHistory { get; set; } = null!;
        public RelayCommand WriteMedCardCommand { get; }
        public MedicalCardViewModel()
        {
            Db.Patients.Load();
            if (Reception is not null)
            {
                MedicalCard = Db.MedicalCards.FirstOrDefault(m => m.PatientId == Reception.PatientId)!;
                Diagnosis = MedicalCard.Diagnosis;
                MedicalHistory = MedicalCard.MedicalHistory;
            }
            WriteMedCardCommand = new(() =>
            {
                if (Reception is not null)
                {
                    if (MedicalCard is null)
                    {
                        MedicalCard = new()
                        {
                            PatientId = Reception.PatientId,
                            Diagnosis = Diagnosis,
                            MedicalHistory = MedicalHistory,
                            FillingDate = DateTime.Now
                        };
                        Db.MedicalCards.Add(MedicalCard);
                        Db.SaveChanges();
                    }
                    else
                    {
                        MedicalCard.Diagnosis = Diagnosis;
                        MedicalCard.MedicalHistory = MedicalHistory;
                        MedicalCard.FillingDate = DateTime.Now;
                        Db.SaveChanges();
                    }
                }
                MedicalCard = null!;
            });
        }
    }
}
