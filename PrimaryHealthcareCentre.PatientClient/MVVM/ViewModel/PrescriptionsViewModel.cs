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
        public ObservableCollection<List<Prescription>> Prescriptions { get; } = new()
        {
            new List<Prescription>
            {
                new Prescription(){ Patient = new Patient("Качмар Р.Р.", "Чоловіча", new DateTime(2002,11,7), "380923232343"), Preparation = new Preparation("Анальгін", 100.0, 10), Date = DateTime.Now },
                new Prescription(){ Patient = new Patient("Качмар Р.Р.", "Чоловіча", new DateTime(2002,11,7), "380923232343"), Preparation = new Preparation("Анальгін", 100.0, 10), Date = DateTime.Now },
                new Prescription(){ Patient = new Patient("Качмар Р.Р.", "Чоловіча", new DateTime(2002,11,7), "380923232343"), Preparation = new Preparation("Анальгін", 100.0, 10), Date = DateTime.Now },
                new Prescription(){ Patient = new Patient("Качмар Р.Р.", "Чоловіча", new DateTime(2002, 11, 7), "380923232343"), Preparation = new Preparation("Анальгін", 100.0, 10), Date = DateTime.Now },
                new Prescription(){ Patient = new Patient("Качмар Р.Р.", "Чоловіча", new DateTime(2002, 11, 7), "380923232343"), Preparation = new Preparation("Анальгін", 100.0, 10), Date = DateTime.Now },
                new Prescription(){ Patient = new Patient("Качмар Р.Р.", "Чоловіча", new DateTime(2002, 11, 7), "380923232343"), Preparation = new Preparation("Анальгін", 100.0, 10), Date = DateTime.Now },
                new Prescription(){ Patient = new Patient("Качмар Р.Р.", "Чоловіча", new DateTime(2002, 11, 7), "380923232343"), Preparation = new Preparation("Анальгін", 100.0, 10), Date = DateTime.Now },
                new Prescription(){ Patient = new Patient("Качмар Р.Р.", "Чоловіча", new DateTime(2002, 11, 7), "380923232343"), Preparation = new Preparation("Анальгін", 100.0, 10), Date = DateTime.Now },
                new Prescription(){ Patient = new Patient("Качмар Р.Р.", "Чоловіча", new DateTime(2002, 11, 7), "380923232343"), Preparation = new Preparation("Анальгін", 100.0, 10), Date = DateTime.Now },
            },
            new List<Prescription>
            {
                new Prescription(){ Patient = new Patient("Качмар Р.Р.", "Чоловіча", new DateTime(2002,11,7), "380923232343"), Preparation = new Preparation("Анальгін", 100.0, 10), Date = DateTime.Now },
                new Prescription(){ Patient = new Patient("Качмар Р.Р.", "Чоловіча", new DateTime(2002,11,7), "380923232343"), Preparation = new Preparation("Анальгін", 100.0, 10), Date = DateTime.Now },
                new Prescription(){ Patient = new Patient("Качмар Р.Р.", "Чоловіча", new DateTime(2002,11,7), "380923232343"), Preparation = new Preparation("Анальгін", 100.0, 10), Date = DateTime.Now },
                new Prescription(){ Patient = new Patient("Качмар Р.Р.", "Чоловіча", new DateTime(2002, 11, 7), "380923232343"), Preparation = new Preparation("Анальгін", 100.0, 10), Date = DateTime.Now },
                new Prescription(){ Patient = new Patient("Качмар Р.Р.", "Чоловіча", new DateTime(2002, 11, 7), "380923232343"), Preparation = new Preparation("Анальгін", 100.0, 10), Date = DateTime.Now },
                new Prescription(){ Patient = new Patient("Качмар Р.Р.", "Чоловіча", new DateTime(2002, 11, 7), "380923232343"), Preparation = new Preparation("Анальгін", 100.0, 10), Date = DateTime.Now },
                new Prescription(){ Patient = new Patient("Качмар Р.Р.", "Чоловіча", new DateTime(2002, 11, 7), "380923232343"), Preparation = new Preparation("Анальгін", 100.0, 10), Date = DateTime.Now },
                new Prescription(){ Patient = new Patient("Качмар Р.Р.", "Чоловіча", new DateTime(2002, 11, 7), "380923232343"), Preparation = new Preparation("Анальгін", 100.0, 10), Date = DateTime.Now },
                new Prescription(){ Patient = new Patient("Качмар Р.Р.", "Чоловіча", new DateTime(2002, 11, 7), "380923232343"), Preparation = new Preparation("Анальгін", 100.0, 10), Date = DateTime.Now },
            },
            new List<Prescription>
            {
                new Prescription(){ Patient = new Patient("Качмар Р.Р.", "Чоловіча", new DateTime(2002,11,7), "380923232343"), Preparation = new Preparation("Анальгін", 100.0, 10), Date = DateTime.Now },
                new Prescription(){ Patient = new Patient("Качмар Р.Р.", "Чоловіча", new DateTime(2002,11,7), "380923232343"), Preparation = new Preparation("Анальгін", 100.0, 10), Date = DateTime.Now },
                new Prescription(){ Patient = new Patient("Качмар Р.Р.", "Чоловіча", new DateTime(2002,11,7), "380923232343"), Preparation = new Preparation("Анальгін", 100.0, 10), Date = DateTime.Now },
                new Prescription(){ Patient = new Patient("Качмар Р.Р.", "Чоловіча", new DateTime(2002, 11, 7), "380923232343"), Preparation = new Preparation("Анальгін", 100.0, 10), Date = DateTime.Now },
                new Prescription(){ Patient = new Patient("Качмар Р.Р.", "Чоловіча", new DateTime(2002, 11, 7), "380923232343"), Preparation = new Preparation("Анальгін", 100.0, 10), Date = DateTime.Now },
                new Prescription(){ Patient = new Patient("Качмар Р.Р.", "Чоловіча", new DateTime(2002, 11, 7), "380923232343"), Preparation = new Preparation("Анальгін", 100.0, 10), Date = DateTime.Now },
                new Prescription(){ Patient = new Patient("Качмар Р.Р.", "Чоловіча", new DateTime(2002, 11, 7), "380923232343"), Preparation = new Preparation("Анальгін", 100.0, 10), Date = DateTime.Now },
                new Prescription(){ Patient = new Patient("Качмар Р.Р.", "Чоловіча", new DateTime(2002, 11, 7), "380923232343"), Preparation = new Preparation("Анальгін", 100.0, 10), Date = DateTime.Now },
                new Prescription(){ Patient = new Patient("Качмар Р.Р.", "Чоловіча", new DateTime(2002, 11, 7), "380923232343"), Preparation = new Preparation("Анальгін", 100.0, 10), Date = DateTime.Now },
            },
            new List<Prescription>
            {
                new Prescription(){ Patient = new Patient("Качмар Р.Р.", "Чоловіча", new DateTime(2002,11,7), "380923232343"), Preparation = new Preparation("Анальгін", 100.0, 10), Date = DateTime.Now },
                new Prescription(){ Patient = new Patient("Качмар Р.Р.", "Чоловіча", new DateTime(2002,11,7), "380923232343"), Preparation = new Preparation("Анальгін", 100.0, 10), Date = DateTime.Now },
                new Prescription(){ Patient = new Patient("Качмар Р.Р.", "Чоловіча", new DateTime(2002,11,7), "380923232343"), Preparation = new Preparation("Анальгін", 100.0, 10), Date = DateTime.Now },
                new Prescription(){ Patient = new Patient("Качмар Р.Р.", "Чоловіча", new DateTime(2002, 11, 7), "380923232343"), Preparation = new Preparation("Анальгін", 100.0, 10), Date = DateTime.Now },
                new Prescription(){ Patient = new Patient("Качмар Р.Р.", "Чоловіча", new DateTime(2002, 11, 7), "380923232343"), Preparation = new Preparation("Анальгін", 100.0, 10), Date = DateTime.Now },
                new Prescription(){ Patient = new Patient("Качмар Р.Р.", "Чоловіча", new DateTime(2002, 11, 7), "380923232343"), Preparation = new Preparation("Анальгін", 100.0, 10), Date = DateTime.Now },
                new Prescription(){ Patient = new Patient("Качмар Р.Р.", "Чоловіча", new DateTime(2002, 11, 7), "380923232343"), Preparation = new Preparation("Анальгін", 100.0, 10), Date = DateTime.Now },
                new Prescription(){ Patient = new Patient("Качмар Р.Р.", "Чоловіча", new DateTime(2002, 11, 7), "380923232343"), Preparation = new Preparation("Анальгін", 100.0, 10), Date = DateTime.Now },
                new Prescription(){ Patient = new Patient("Качмар Р.Р.", "Чоловіча", new DateTime(2002, 11, 7), "380923232343"), Preparation = new Preparation("Анальгін", 100.0, 10), Date = DateTime.Now },
            },
            new List<Prescription>
            {
                new Prescription(){ Patient = new Patient("Качмар Р.Р.", "Чоловіча", new DateTime(2002,11,7), "380923232343"), Preparation = new Preparation("Анальгін", 100.0, 10), Date = DateTime.Now },
                new Prescription(){ Patient = new Patient("Качмар Р.Р.", "Чоловіча", new DateTime(2002,11,7), "380923232343"), Preparation = new Preparation("Анальгін", 100.0, 10), Date = DateTime.Now },
                new Prescription(){ Patient = new Patient("Качмар Р.Р.", "Чоловіча", new DateTime(2002,11,7), "380923232343"), Preparation = new Preparation("Анальгін", 100.0, 10), Date = DateTime.Now },
                new Prescription(){ Patient = new Patient("Качмар Р.Р.", "Чоловіча", new DateTime(2002, 11, 7), "380923232343"), Preparation = new Preparation("Анальгін", 100.0, 10), Date = DateTime.Now },
                new Prescription(){ Patient = new Patient("Качмар Р.Р.", "Чоловіча", new DateTime(2002, 11, 7), "380923232343"), Preparation = new Preparation("Анальгін", 100.0, 10), Date = DateTime.Now },
                new Prescription(){ Patient = new Patient("Качмар Р.Р.", "Чоловіча", new DateTime(2002, 11, 7), "380923232343"), Preparation = new Preparation("Анальгін", 100.0, 10), Date = DateTime.Now },
                new Prescription(){ Patient = new Patient("Качмар Р.Р.", "Чоловіча", new DateTime(2002, 11, 7), "380923232343"), Preparation = new Preparation("Анальгін", 100.0, 10), Date = DateTime.Now },
                new Prescription(){ Patient = new Patient("Качмар Р.Р.", "Чоловіча", new DateTime(2002, 11, 7), "380923232343"), Preparation = new Preparation("Анальгін", 100.0, 10), Date = DateTime.Now },
                new Prescription(){ Patient = new Patient("Качмар Р.Р.", "Чоловіча", new DateTime(2002, 11, 7), "380923232343"), Preparation = new Preparation("Анальгін", 100.0, 10), Date = DateTime.Now },
            }
        };

        public PrescriptionsViewModel()
        {
            //a.Where(x => x.Patient.FullName == "Качмар Р.Р.").GroupBy(x => x.Date).Select(x => x.ToList());
        }
    }
}
