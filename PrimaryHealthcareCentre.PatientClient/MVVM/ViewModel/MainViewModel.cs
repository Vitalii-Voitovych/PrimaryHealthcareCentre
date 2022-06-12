using PrimaryHealthcareCentre.Domain;
using PrimaryHealthcareCentre.UIComponent;
using PrimaryHealthcareCentre.UIComponent.Commands;
using System;

namespace PrimaryHealthcareCentre.PatientClient.MVVM.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        private object currentView = null!;

        public object CurrentView
        {
            get { return currentView; }
            set 
            { 
                currentView = value;
                OnPropertyChanged();
            }
        }
        public HomeViewModel HomeVM { get; }
        public DoctorsViewModel DoctorsVM { get; }
        public MedicalCardViewModel MedicalCardVM { get; }
        public PrescriptionsViewModel PrescriptionsVM { get; }
        public RelayCommand HomeCommand { get; }
        public RelayCommand DoctorsCommand { get; }
        public RelayCommand MedicalCardCommand { get; }
        public RelayCommand PrescriptionsCommand { get; }

        public MainViewModel()
        {
            HomeVM = new();
            DoctorsVM = new();
            MedicalCardVM = new();
            PrescriptionsVM = new();
            CurrentView = HomeVM;
            HomeCommand = new RelayCommand(() => CurrentView = HomeVM);
            DoctorsCommand = new RelayCommand(() => CurrentView = DoctorsVM);
            MedicalCardCommand = new RelayCommand(() => CurrentView = MedicalCardVM);
            PrescriptionsCommand = new RelayCommand(() => CurrentView = PrescriptionsVM);
        }

    }
}
