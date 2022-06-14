using PrimaryHealthcareCentre.Domain;
using PrimaryHealthcareCentre.Domain.Model;
using PrimaryHealthcareCentre.UIComponent;
using PrimaryHealthcareCentre.UIComponent.Commands;
using System;
using System.Windows;

namespace PrimaryHealthcareCentre.PatientClient.MVVM.ViewModel
{
    public abstract class BaseViewModel : ObservableObject, IBaseControlCommand
    {
        private static Patient patient = null!;
        public Patient Patient
        {
            get => patient;
            set
            {
                patient = value;
                OnPropertyChanged();
            }
        }
        public RelayCommand<Window> CloseCommand { get; }
        public RelayCommand<Window> MinimizeCommand { get; }

        public BaseViewModel()
        {
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
