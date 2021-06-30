using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALEF;
using Modeles;

namespace BusinessLayer
{
    public class blAdmin
    {
        public void MaisonMed_Add(modMaisonsMed modMaisonsMed)
        {
            DALEF.EFAdmin oP = new EFAdmin();
            string pNom = modMaisonsMed.Nom;
            string pAdresse = modMaisonsMed.Adresse;
            string pCommune = modMaisonsMed.Commune;
            oP.MaisonMed_Add(pNom, pAdresse, pCommune);
        }

        public void Local_Add(modLocaux modLocaux)
        {
            DALEF.EFAdmin oP = new EFAdmin();
            int pMaisonMedID = modLocaux.Maison_Med_ID;
            string pNomLocal = modLocaux.NomLocal;
            oP.Local_Add(pMaisonMedID, pNomLocal);
        }
    }
}
