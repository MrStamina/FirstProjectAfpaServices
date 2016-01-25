using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetAfpaService.Metier
{
    class Prevision
    {
        public Qualification LaQualif { get; set; }
        public short NbJours { get; set; }
        public int CodePrevision { get; set; }
        public int CodeProjet { get; set; }

        public Prevision()
        {

        }
        public Prevision(Qualification initLaQualif, short initNbJours)
        {
            LaQualif = initLaQualif;
            NbJours = initNbJours;
        }

        //Equals
        //public override bool Equals(object obj)
        //{
        //    return other is Prevision && 
        //}
    }
}
