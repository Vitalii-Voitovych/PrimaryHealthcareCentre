using Microsoft.EntityFrameworkCore;
using PrimaryHealthcareCentre.Domain.Model;
using PrimaryHealthcareCentre.UIComponent.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimaryHealthcareCentre.DoctorClient.MVVM.ViewModel
{
    public class PatientViewModel : BaseViewModel
    {
        public ObservableCollection<Reception> Receptions { get; }
        public RelayCommand<Reception> AddCurrentExaminationCommand { get; }
        public PatientViewModel()
        {
            Db.Patients.Load();
            Receptions = new ObservableCollection<Reception>(Db.LogOfReception.Where(r => r.DoctorId == Doctor.DoctorId && r.IsCompleted == false && DateTime.Now.Year == r.DateOfReception.Year &&
                                                                                                                            DateTime.Now.Month == r.DateOfReception.Month &&
                                                                                                                            DateTime.Now.Day == r.DateOfReception.Day));
            AddCurrentExaminationCommand = new((reception) =>
            {
                if (reception is not null)
                {
                    Reception = Db.LogOfReception.First(r => r == reception);
                    Receptions.Remove(reception);
                }
            });
        }
    }
}
