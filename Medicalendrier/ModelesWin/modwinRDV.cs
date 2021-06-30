using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignWinPatients.ModelesWin
{
    public class modwinRDV
    {
        public int RDV_ID { get; set; }
        public int Patient_ID { get; set; }
        public int Recap_ID { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Heure_Debut { get; set; }
        public TimeSpan Heure_Fin { get; set; }
        public int Local_ID { get; set; }
        public bool Confirmation { get; set; }
        public string Identifiant_RDV { get; set; }
    }
}
