using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignWinPatients.ModelesWin
{
    public class modwinPatient
    {
        public int Patient_ID { get; set; }
        public string NomPatient { get; set; }
        public string PrenomPatient { get; set; }
        public DateTime Date_De_Naissance { get; set; }
        public string Identifiant_ID { get; set; }
    }
}
