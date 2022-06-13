using PrimaryHealthcareCentre.UIComponent.Commands;
using System.Windows;

namespace PrimaryHealthcareCentre.UIComponent
{
    public interface IBaseControlCommand
    {
        RelayCommand<Window> CloseCommand { get; }
        RelayCommand<Window> MinimizeCommand { get; }
    }
}
