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
            LogOfReception = new()
            {
                new Reception(){ Patient = new Patient("Роман Качмар", "Чоловік", DateTime.Parse("07.11.2002"), "380924347484", "0023231341"), Doctor = new Doctor("Качмар Р.Р.", "Тепапевт", "380929494394", 4, "Травматологія", "10:00:00", "12:00:00"), DateOfReception = DateTime.Now},
                new Reception(){ Patient = new Patient("Роман Качмар", "Чоловік", DateTime.Parse("07.11.2002"), "380924347484", "0023231341"), Doctor = new Doctor("Качмар Р.Р.", "Тепапевт", "380929494394", 4, "Травматологія", "10:00:00", "12:00:00"), DateOfReception = DateTime.Now},
                new Reception(){ Patient = new Patient("Роман Качмар", "Чоловік", DateTime.Parse("07.11.2002"), "380924347484", "0023231341"), Doctor = new Doctor("Качмар Р.Р.", "Тепапевт", "380929494394", 4, "Травматологія", "10:00:00", "12:00:00"), DateOfReception = DateTime.Now},
                new Reception(){ Patient = new Patient("Роман Качмар", "Чоловік", DateTime.Parse("07.11.2002"), "380924347484", "0023231341"), Doctor = new Doctor("Качмар Р.Р.", "Тепапевт", "380929494394", 4, "Травматологія", "10:00:00", "12:00:00"), DateOfReception = DateTime.Now},
                new Reception(){ Patient = new Patient("Роман Качмар", "Чоловік", DateTime.Parse("07.11.2002"), "380924347484", "0023231341"), Doctor = new Doctor("Качмар Р.Р.", "Тепапевт", "380929494394", 4, "Травматологія", "10:00:00", "12:00:00"), DateOfReception = DateTime.Now},
                new Reception(){ Patient = new Patient("Роман Качмар", "Чоловік", DateTime.Parse("07.11.2002"), "380924347484", "0023231341"), Doctor = new Doctor("Качмар Р.Р.", "Тепапевт", "380929494394", 4, "Травматологія", "10:00:00", "12:00:00"), DateOfReception = DateTime.Now},
                new Reception(){ Patient = new Patient("Роман Качмар", "Чоловік", DateTime.Parse("07.11.2002"), "380924347484", "0023231341"), Doctor = new Doctor("Качмар Р.Р.", "Тепапевт", "380929494394", 4, "Травматологія", "10:00:00", "12:00:00"), DateOfReception = DateTime.Now},
                new Reception(){ Patient = new Patient("Роман Качмар", "Чоловік", DateTime.Parse("07.11.2002"), "380924347484", "0023231341"), Doctor = new Doctor("Качмар Р.Р.", "Тепапевт", "380929494394", 4, "Травматологія", "10:00:00", "12:00:00"), DateOfReception = DateTime.Now},
                new Reception(){ Patient = new Patient("Роман Качмар", "Чоловік", DateTime.Parse("07.11.2002"), "380924347484", "0023231341"), Doctor = new Doctor("Качмар Р.Р.", "Тепапевт", "380929494394", 4, "Травматологія", "10:00:00", "12:00:00"), DateOfReception = DateTime.Now},
                new Reception(){ Patient = new Patient("Роман Качмар", "Чоловік", DateTime.Parse("07.11.2002"), "380924347484", "0023231341"), Doctor = new Doctor("Качмар Р.Р.", "Тепапевт", "380929494394", 4, "Травматологія", "10:00:00", "12:00:00"), DateOfReception = DateTime.Now},
            };
        }
    }
}
