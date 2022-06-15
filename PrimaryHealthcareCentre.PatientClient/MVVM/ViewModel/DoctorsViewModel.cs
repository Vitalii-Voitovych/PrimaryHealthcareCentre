using Microsoft.EntityFrameworkCore;
using PrimaryHealthcareCentre.Domain.Model;
using PrimaryHealthcareCentre.UIComponent.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace PrimaryHealthcareCentre.PatientClient.MVVM.ViewModel
{
    public class DoctorsViewModel : BaseViewModel
    {
        public DateTime Date { get; set; } 
        public ObservableCollection<Doctor> Doctors { get; }

        public RelayCommand<Doctor> AddReceptionCommand { get; }

        public DoctorsViewModel()
        {
            Db.Doctors.Load();
            Doctors = Db.Doctors.Local.ToObservableCollection();
            AddReceptionCommand = new((doctor) =>
            {
                var reception = new Reception()
                {
                    DoctorId = doctor.DoctorId,
                    PatientId = Patient.PatientId,
                    DateOfReception = Date
                };
            });
        }
    }
}
