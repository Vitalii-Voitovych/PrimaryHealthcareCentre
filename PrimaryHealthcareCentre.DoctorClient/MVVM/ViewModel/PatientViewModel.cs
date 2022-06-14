using PrimaryHealthcareCentre.Domain.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimaryHealthcareCentre.DoctorClient.MVVM.ViewModel
{
    public class PatientViewModel
    {
        public ObservableCollection<Reception> LogOfReception { get; }
        public PatientViewModel()
        {

        }
    }
}
