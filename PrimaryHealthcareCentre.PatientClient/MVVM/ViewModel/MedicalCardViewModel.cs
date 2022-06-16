using PrimaryHealthcareCentre.Domain.Model;
using System.Linq;

namespace PrimaryHealthcareCentre.PatientClient.MVVM.ViewModel
{
    public class MedicalCardViewModel : BaseViewModel
    {
        private MedicalCard medicalCard = null!;
        public MedicalCard MedicalCard
        {
            get => medicalCard;
            set
            {
                medicalCard = value;
                OnPropertyChanged();
            }
        }
        public MedicalCardViewModel()
        {
            MedicalCard = Db.MedicalCards.FirstOrDefault(m => m.PatientId == Patient.PatientId)!;
        }
    }
}
