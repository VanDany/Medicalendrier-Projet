using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignWinMedecins
{
    public class modwinPresencesMed
    {
        public int Presence_ID { get; set; }
        public int Medecin_ID { get; set; }
        public int Maison_Med_ID { get; set; }
        public DateTime DatePresence { get; set; }
        public TimeSpan Heure_Debut { get; set; }
        public TimeSpan Heure_Fin { get; set; }
    }
}
