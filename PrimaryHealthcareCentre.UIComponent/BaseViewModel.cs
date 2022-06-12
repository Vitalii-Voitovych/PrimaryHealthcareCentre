using PrimaryHealthcareCentre.Domain;
using PrimaryHealthcareCentre.UIComponent.Commands;
using System.Windows;

namespace PrimaryHealthcareCentre.UIComponent
{
    public abstract class BaseViewModel : ObservableObject
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
