using PrimaryHealthcareCentre.UIComponent.Commands;
using PrimaryHealthcareCentre.UIComponent;
using System.Windows;
using PrimaryHealthcareCentre.Domain;
using PrimaryHealthcareCentre.Domain.Model;
using System;

namespace PrimaryHealthcareCentre.DoctorClient.MVVM.ViewModel
{
    public abstract class BaseViewModel : ObservableObject,IBaseControlCommand
    {
        private static object currentView = null!;

        public object CurrentView
        {
            get { return currentView; }
            set 
            { 
                currentView = value;
                OnPropertyChanged();
            }
        }

        private static Patient currentPatient = null!;
        public Patient CurrentPatient
        {
            get => currentPatient;
            set
            {
                currentPatient = value;
                OnPropertyChanged();
            }
        }

        public RelayCommand<Window> CloseCommand { get; }
        public RelayCommand<Window> MinimizeCommand { get; }

        public BaseViewModel()
        {
            CurrentPatient = new Patient("Роман Качмар", "Чоловік", DateTime.Parse("07.11.2002"), "3803233232");
            CloseCommand = new RelayCommand<Window>((window) =>
            {
                window.Close();
            });
            MinimizeCommand = new RelayCommand<Window>((window) =>
            {
                window.WindowState = WindowState.Minimized;
            });
        }
    }
}
