using PrimaryHealthcareCentre.Domain;
using PrimaryHealthcareCentre.Domain.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace PrimaryHealthcareCentre.PatientClient.MVVM.ViewModel
{
    public class PrescriptionsViewModel
    {
        public ObservableCollection<List<Prescription>> Prescriptions { get; }

        public PrescriptionsViewModel()
        {
            //a.Where(x => x.Patient.FullName == "Качмар Р.Р.").GroupBy(x => x.Date).Select(x => x.ToList());
        }
    }
}
