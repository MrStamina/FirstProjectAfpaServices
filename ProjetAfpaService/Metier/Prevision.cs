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


        public Prevision(Qualification initLaQualif, short initNbJours)
        {
            LaQualif = initLaQualif;
            NbJours = initNbJours;
        }
    }
}
