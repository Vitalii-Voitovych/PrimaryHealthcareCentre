﻿using PrimaryHealthcareCentre.Domain.Model;
using System;
using System.Collections.ObjectModel;

namespace PrimaryHealthcareCentre.PatientClient.MVVM.ViewModel
{
    public class DoctorsViewModel
    {
        public ObservableCollection<Doctor> Doctors { get; } = new()
        {
            new Doctor("Качмар Р.Р.","030203023", "Терапевт", "380231323242", 4 , "Травматологія", "10:00:00", "12:00:00"),
            new Doctor("Качмар Р.Р.", "030203023", "Терапевт", "380231323242", 4 , "Травматологія", "10:00:00", "12:00:00"),
            new Doctor("Качмар Р.Р.", "030203023", "Терапевт", "380231323242", 4 , "Травматологія", "10:00:00", "12:00:00"),
            new Doctor("Качмар Р.Р.", "030203023", "Терапевт", "380231323242", 4 , "Травматологія", "10:00:00", "12:00:00"),
            new Doctor("Качмар Р.Р.", "030203023", "Терапевт", "380231323242", 4 , "Травматологія", "10:00:00", "12:00:00"),
            new Doctor("Качмар Р.Р.", "030203023", "Терапевт", "380231323242", 4 , "Травматологія", "10:00:00", "12:00:00"),
            new Doctor("Качмар Р.Р.", "030203023", "Терапевт", "380231323242", 4 , "Травматологія", "10:00:00", "12:00:00"),
            new Doctor("Качмар Р.Р.", "030203023", "Терапевт", "380231323242", 4 , "Травматологія", "10:00:00", "12:00:00"),
            new Doctor("Качмар Р.Р.", "030203023", "Терапевт", "380231323242", 4 , "Травматологія", "10:00:00", "12:00:00"),
        };
    }
}
