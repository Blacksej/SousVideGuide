using SousVideGuide.Model;
using System;
using System.Text;
using Xamarin.Forms;

namespace SousVideGuide.ViewModel
{
    public class ProcedureViewModel : BindableObject
    {
        public int StepNumber
        {
            get
            {
                return GetProcedure.StepNumber;
            }
            set
            {
                GetProcedure.StepNumber = value;
                OnPropertyChanged(nameof(StepNumber));
            }
        }

        public string ProcedureDescription
        {
            get
            {
                return GetProcedure.ProcedureDescription;
            }
            set
            {
                GetProcedure.ProcedureDescription = value;
                OnPropertyChanged(nameof(ProcedureDescription));
            }
        }

        public Procedure GetProcedure { get; private set; }

        public ProcedureViewModel(Procedure procedure)
        {
            GetProcedure = procedure;
        }
    }
}
