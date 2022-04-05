using System;
using System.Collections.Generic;
using System.Text;

namespace SousVideGuide.Model
{
    public class ProcedureRepository
    {
        static private List<Procedure> procedureList = new List<Procedure>();

        public IEnumerable<Procedure> GetProcedures()
        {
            return procedureList;
        }

        public void CreateProcedure(Procedure procedure)
        {
            procedureList.Add(procedure);
        }
    }
}
