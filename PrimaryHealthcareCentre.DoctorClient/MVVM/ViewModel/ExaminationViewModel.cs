using PrimaryHealthcareCentre.Domain.Model;
using PrimaryHealthcareCentre.UIComponent.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimaryHealthcareCentre.DoctorClient.MVVM.ViewModel
{
    public class ExaminationViewModel : BaseViewModel
    {
        public ObservableCollection<Preparation> Preparations { get; }
        public ObservableCollection<Preparation> PatientPreparations { get; } = new()
        {
            new Preparation("Анальгін", 100.10, 10),
        };
        public RelayCommand<Preparation> AddPreparationCommand { get; }
        public RelayCommand<Preparation> RemovePreparationCommand { get; }
        public ExaminationViewModel()
        {
            Preparations = new()
            {
                new Preparation("Анальгін", 100.10, 10),
                new Preparation("Анальгін", 100.10, 10),
                new Preparation("Анальгін", 100.10, 10),
                new Preparation("Анальгін", 100.10, 10),
                new Preparation("Анальгін", 100.10, 10),
                new Preparation("Анальгін", 100.10, 10),
                new Preparation("Анальгін", 100.10, 10),
                new Preparation("Анальгін", 100.10, 10),
                new Preparation("Анальгін", 100.10, 10),
                new Preparation("Анальгін", 100.10, 10),
                new Preparation("Анальгін", 100.10, 10),
            };
            AddPreparationCommand = new RelayCommand<Preparation>((preparation) =>
            {
                PatientPreparations.Add(preparation);
            });
            RemovePreparationCommand = new RelayCommand<Preparation>((preparation) =>
            {
                PatientPreparations.Remove(preparation);
            });
        }
    }
}
