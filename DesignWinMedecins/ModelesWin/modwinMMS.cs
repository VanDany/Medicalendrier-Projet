using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignWinMedecins.ModelesWin
{
    public class modwinMMS
    {
        public int Recap_ID { get; set; }
        public int Medecin_ID { get; set; }
        public int Specialite_ID { get; set; }
        public int Maison_Med_ID { get; set; }
        public int Duree_Consultation { get; set; }
        public bool Verif_Lien { get; set; }
    }
}
