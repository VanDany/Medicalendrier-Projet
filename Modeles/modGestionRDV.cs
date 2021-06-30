using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace Modeles
{
    public class modGestionRDV
    {
        public DateTime Date { get; set; }
        public TimeSpan Heure_Debut { get; set; }
        public TimeSpan Heure_Fin { get; set; }
        public string Nom_Patient { get; set; }
        public string Prenom_Patient { get; set; }
        public string Nom_Maison_Med { get; set; }
        public string Adresse { get; set; }
        public string Nom_Medecin { get; set; }
        public string Prenom_Medecin { get; set; }
        public string Nom_Specialite { get; set; }
        public bool Confirmation { get; set; }
    }
}
