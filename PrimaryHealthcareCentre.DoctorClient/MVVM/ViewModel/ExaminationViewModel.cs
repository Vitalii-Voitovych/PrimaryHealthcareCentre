using Microsoft.EntityFrameworkCore;
using PrimaryHealthcareCentre.Domain.Model;
using PrimaryHealthcareCentre.UIComponent.Commands;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace PrimaryHealthcareCentre.DoctorClient.MVVM.ViewModel
{
    public class ExaminationViewModel : BaseViewModel
    {
        public ObservableCollection<Preparation> Preparations { get; }
        public ObservableCollection<Preparation> PatientPreparations { get; } = new();
        public RelayCommand<Preparation> AddPreparationCommand { get; }
        public RelayCommand<Preparation> RemovePreparationCommand { get; }
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
        }
    }
}
