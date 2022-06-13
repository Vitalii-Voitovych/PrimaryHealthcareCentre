using PrimaryHealthcareCentre.Domain;
using PrimaryHealthcareCentre.UIComponent;
using PrimaryHealthcareCentre.UIComponent.Commands;
using System.Windows;

namespace PrimaryHealthcareCentre.PatientClient.MVVM.ViewModel
{
    public abstract class BaseViewModel : ObservableObject, IBaseControlCommand
    {
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
