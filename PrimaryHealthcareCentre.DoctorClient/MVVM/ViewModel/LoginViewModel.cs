using Microsoft.EntityFrameworkCore;
using PrimaryHealthcareCentre.Domain.Model;
using PrimaryHealthcareCentre.UIComponent.Commands;
using System;
using System.Linq;
using System.Windows;

namespace PrimaryHealthcareCentre.DoctorClient.MVVM.ViewModel
{
    public class LoginViewModel : BaseViewModel
    {
        public string? FullName { get; set; }
        public string? PhoneNumber { get; set; }
        public RelayCommand<Window> LoginCommand { get; }

        public LoginViewModel()
        {
            Db.Doctors.Load();
            LoginCommand = new RelayCommand<Window>((window) =>
            {
                Doctor = Db.Doctors.FirstOrDefault(d => d.FullName == FullName && d.PhoneNumber == PhoneNumber);
                if (Doctor is not null)
                {
                    window.DialogResult = true;
                    window.Close();
                }
            });
        }
    }
}
