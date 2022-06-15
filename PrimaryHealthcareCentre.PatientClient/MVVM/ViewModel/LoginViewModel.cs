using Microsoft.EntityFrameworkCore;
using PrimaryHealthcareCentre.Domain.Model;
using PrimaryHealthcareCentre.UIComponent.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PrimaryHealthcareCentre.PatientClient.MVVM.ViewModel
{
    public class LoginViewModel : BaseViewModel
    {
        public string FullName { get; set; } = null!;
        public string Gender { get; set; } = null!;
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; } = null!;
        public RelayCommand<Window> LoginCommand { get; }

        public LoginViewModel()
        {
            Db.Patients.Load();
            LoginCommand = new((window) =>
            {
                Patient = Db.Patients.FirstOrDefault(p => p.FullName == FullName &&
                                                          p.Gender == Gender &&
                                                          p.DateOfBirth == DateOfBirth &&
                                                          p.PhoneNumber == PhoneNumber)!;
                if (Patient is null)
                {
                    Patient = new Patient(FullName, Gender, DateOfBirth, PhoneNumber);
                    Db.Patients.Add(Patient);
                    Db.SaveChanges();
                }
                window.DialogResult = true;
                window.Close();
            });
        }
    }
}
