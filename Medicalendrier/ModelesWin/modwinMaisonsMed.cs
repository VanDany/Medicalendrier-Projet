﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignWinPatients.ModelesWin
{
    public class modwinMaisonsMed
    {
        public int ID { get; set; }
        public string Nom { get; set; }
        public string Adresse { get; set; }
        public string Commune { get; set; }
    }
}
