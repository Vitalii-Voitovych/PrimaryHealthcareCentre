using Microsoft.EntityFrameworkCore;
using PrimaryHealthcareCentre.Domain.Model;
using PrimaryHealthcareCentre.UIComponent.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;

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
                if (Date.DayOfWeek == DayOfWeek.Sunday || Date.DayOfWeek == DayOfWeek.Saturday)
                {
                    MessageBox.Show("Не можна записатися у вихіді");
                    return;
                }
                if (TimeOnly.Parse(doctor.StartTime) <= TimeOnly.FromDateTime(Date) && 
                    TimeOnly.Parse(doctor.EndTime) >= TimeOnly.FromDateTime(Date))
                {
                    var reception = new Reception()
                    {
                        DoctorId = doctor.DoctorId,
                        PatientId = Patient.PatientId,
                        DateOfReception = Date,
                        IsCompleted = false
                    };
                    if (Db.LogOfReception.Local.Contains(reception))
                    {
                        MessageBox.Show("Вже є запису на таку годину");
                        return;
                    }
                    Db.LogOfReception.Add(reception);
                    Db.SaveChanges();
                    Date = new();
                }
            });
        }
    }
}
