using Microsoft.EntityFrameworkCore;
using PrimaryHealthcareCentre.Domain.Model;
using PrimaryHealthcareCentre.UIComponent.Commands;
using System.Collections.ObjectModel;
using System;
using System.Linq;

namespace PrimaryHealthcareCentre.DoctorClient.MVVM.ViewModel
{
    public class ExaminationViewModel : BaseViewModel
    {
        private string resultExamination = null!;
        public string ResultExamination
        {
            get => resultExamination;
            set
            {
                resultExamination = value;
                OnPropertyChanged();
            }
        }
        public ObservableCollection<Preparation> Preparations { get; }
        public ObservableCollection<Preparation> PatientPreparations { get; } = new();
        public RelayCommand<Preparation> AddPreparationCommand { get; }
        public RelayCommand<Preparation> RemovePreparationCommand { get; }
        public RelayCommand EndExaminationCommand { get; }
        public RelayCommand WritePrescription { get; }
        public ExaminationViewModel()
        {
            Db.Preparations.Load();
            Preparations = Db.Preparations.Local.ToObservableCollection();
            AddPreparationCommand = new RelayCommand<Preparation>((preparation) =>
            {
                PatientPreparations.Add(preparation);
            });
            RemovePreparationCommand = new RelayCommand<Preparation>((preparation) =>
            {
                PatientPreparations.Remove(preparation);
            });
            EndExaminationCommand = new(() =>
            {
                var reception = Db.LogOfReception.First(r => r == Reception);
                reception.IsCompleted = true;
                Db.SaveChanges();
                var examination = new Examination()
                {
                    ReceptionId = reception.ReceptionId,
                    Reception = reception,
                    Result = ResultExamination,
                    Date = DateTime.Now,
                };
                Db.Examinations.Add(examination);
                Db.SaveChanges();
                ResultExamination = null!;
                Reception = null!;
            });
            WritePrescription = new(() => 
            {
                if (Reception is not null)
                {
                    DateTime date = DateTime.Now;
                    foreach (Preparation item in PatientPreparations)
                    {
                        var prescription = new Prescription()
                        {
                            PatientId = Reception.PatientId,
                            PreparationId = item.PreparationId,
                            Date = date
                        };
                        Db.Prescriptions.Add(prescription);
                    }
                    Db.SaveChanges();
                    PatientPreparations.Clear();
                }
            });
        }
    }
}
