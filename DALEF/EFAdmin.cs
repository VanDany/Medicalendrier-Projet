using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALEF
{
    public class EFAdmin
    {
        public void MaisonMed_Add(string pNomMaisonMed, string pAdresse, string pCommune)
        {
            RDVMedicalEntities cx = new RDVMedicalEntities();
            cx.AddMaisonMed(pNomMaisonMed, pAdresse, pCommune);
        }
        public void Local_Add(int pMaisonMedID, string nomLocal)
        {
            RDVMedicalEntities cx = new RDVMedicalEntities();
            cx.AddLocal(pMaisonMedID, nomLocal);
        }
    }
}
