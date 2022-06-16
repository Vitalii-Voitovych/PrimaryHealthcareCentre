using Microsoft.EntityFrameworkCore;
using PrimaryHealthcareCentre.Domain;
using PrimaryHealthcareCentre.Domain.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace PrimaryHealthcareCentre.PatientClient.MVVM.ViewModel
{
    public class PrescriptionsViewModel : BaseViewModel
    {
        public ObservableCollection<List<Prescription>> Prescriptions { get; }

        public PrescriptionsViewModel()
        {
            Db.Preparations.Load();
            Prescriptions = new (Db.Prescriptions.Where(x => x.Patient.FullName == Patient.FullName).GroupBy(x => x.Date).Select(x => x.ToList()));
        }
    }
}
