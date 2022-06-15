using PrimaryHealthcareCentre.UIComponent.Commands;
using PrimaryHealthcareCentre.UIComponent;
using System.Windows;
using PrimaryHealthcareCentre.Domain;
using PrimaryHealthcareCentre.Domain.Model;
using PrimaryHealthcareCentre.Domain.EF;

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

        private static Doctor? doctor;
        public Doctor? Doctor
        {
            get => doctor;
            set
            {
                doctor = value;
                OnPropertyChanged();
            }
        }
        public PrimaryHealthCentreDbContext Db { get; } = new();

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
