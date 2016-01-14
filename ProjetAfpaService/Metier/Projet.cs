using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetAfpaService.Metier
{
    abstract class Projet
    {
        public int CodeProjet { get; set; }
        public string NomProjet { get; set; }
        public DateTime DDebut { get; set; }
        public DateTime DFin { get; set; }
        public Client LeClient { get; set; }
        public string Contact { get; set; }
        public string MailContact { get; set; }

        public override string ToString()
        {
            return "[" + CodeProjet + "," + NomProjet + "," + DDebut.ToShortDateString() + "," + DFin.ToShortDateString() + "]" /*+ "," + LeClient + "," + Contact + "," + MailContact*/;
        }

        public override bool Equals(Object other)
        {
            return other is Projet && CodeProjet == ((Projet)other).CodeProjet;
        }

    

    }
}
