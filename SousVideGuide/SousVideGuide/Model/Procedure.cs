using System;
using System.Collections.Generic;
using System.Text;

namespace SousVideGuide.Model
{
    public class Procedure
    {
        public int StepNumber { get; set; }
        public string ProcedureDescription { get; set; }

        public Procedure(int stepNumber, string procedureDescription)
        {
            StepNumber = stepNumber;
            ProcedureDescription = procedureDescription;
        }
    }
}
