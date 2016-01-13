using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetAfpaService.Metier
{
    class ProjetRegie : Projet
    { 
        public decimal TarifJournalier { get; set; }
        public Qualification Qualification { get; set; }
    }
}
