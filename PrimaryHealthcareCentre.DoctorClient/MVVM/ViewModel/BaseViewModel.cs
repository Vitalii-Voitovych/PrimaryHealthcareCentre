﻿using PrimaryHealthcareCentre.UIComponent.Commands;
using PrimaryHealthcareCentre.UIComponent;
using System.Windows;
using PrimaryHealthcareCentre.Domain;

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