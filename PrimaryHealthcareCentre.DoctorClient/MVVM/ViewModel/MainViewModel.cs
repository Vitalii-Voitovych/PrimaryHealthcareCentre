using PrimaryHealthcareCentre.DoctorClient.MVVM.View;
using PrimaryHealthcareCentre.UIComponent;
using PrimaryHealthcareCentre.UIComponent.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimaryHealthcareCentre.DoctorClient.MVVM.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        private bool dialogResult;
        public bool DialogResult
        {
            get => dialogResult;
            set
            {
                dialogResult = value;
                OnPropertyChanged();
            }
        }
        public HomeViewModel HomeVM { get; }
        public PatientViewModel PatientVM { get; }
        public ExaminationViewModel ExaminationVM { get; }
        public RelayCommand HomeCommand { get; }
        public RelayCommand PatientCommand { get; }
        public RelayCommand ExaminationCommand { get; }

        public MainViewModel()
        {
            LoginWindow loginWindow = new LoginWindow();
            if (loginWindow.ShowDialog() == false)
            {
                DialogResult = false;
            }
            HomeVM = new();
            PatientVM = new();
            ExaminationVM = new();
            CurrentView = HomeVM;
            HomeCommand = new RelayCommand(() => CurrentView = HomeVM);
            PatientCommand = new RelayCommand(() => CurrentView = PatientVM);
            ExaminationCommand = new RelayCommand(() => CurrentView = ExaminationVM);
        }
    }
}
