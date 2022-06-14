using PrimaryHealthcareCentre.Domain.Model;
using System;
using System.Collections.ObjectModel;

namespace PrimaryHealthcareCentre.PatientClient.MVVM.ViewModel
{
    public class DoctorsViewModel
    {
        public ObservableCollection<Doctor> Doctors { get; }
    }
}
