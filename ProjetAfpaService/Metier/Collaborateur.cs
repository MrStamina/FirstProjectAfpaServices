using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetAfpaService.Metier
{
    class Collaborateur
    {
        public int CodeColl { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DEmbauche { get; set; }
        public decimal PrJournalier { get; set; }
        public Qualification LaQualif { get; set; }

        public Collaborateur(int initCodeColl, string initNom, string initPrenom, DateTime initDembauche, decimal initPrJournalier, Qualification initLaQualif)
        {
            CodeColl = initCodeColl;
            Nom = initNom;
            Prenom = initPrenom;
            DEmbauche = initDembauche;
            PrJournalier = initPrJournalier;
            LaQualif = initLaQualif;
        }

        // On oublie pas le Tostring et Equals

        public override string ToString()
        {
            return "[" + Nom + "," + Prenom + "," + DEmbauche.ToShortDateString() + "," + PrJournalier + "]";
        }
    }
}
