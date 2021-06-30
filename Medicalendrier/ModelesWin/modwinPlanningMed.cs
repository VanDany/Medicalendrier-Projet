using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignWinPatients
{
    public class modwinPlanningMed
    {
        public int RDV_ID { get; set; }
        public string NomPatient { get; set; }
        public string PrenomPatient { get; set; }
        public string NomMaisonMed { get; set; }
        public string Adresse { get; set; }
        public string Nom_Specialite { get; set; }
        public TimeSpan Heure_Debut { get; set; }
        public TimeSpan Heure_Fin { get; set; }
        public string NomLocal { get; set; }
        public bool Confirmation { get; set; }
    }
}
