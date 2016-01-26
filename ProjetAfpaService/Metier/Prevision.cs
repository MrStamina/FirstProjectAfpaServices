using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetAfpaService.Metier
{
    class Prevision
    {
        private sbyte codeQualif;
        private decimal value;
        private int idPrevision;

        public Qualification LaQualif { get; set; }
        public short NbJours { get; set; }
        public int CodePrevision { get; set; }
        public int CodeProjet { get; set; }

        public Prevision()
        {

        }

        public Prevision(int codeProjet, Qualification Qualif, short value, int idPrevision)
        {
            CodeProjet = codeProjet;
            this.LaQualif = Qualif;
            this.NbJours = value;
            this.idPrevision = idPrevision;
        }



        //public Prevision(int initCodeProjet)
        //{
        //    CodeProjet = initCodeProjet;

        //}

        //Equals
        public override bool Equals(object obj)
        {
            return obj is Prevision && CodePrevision == ((Prevision)obj).CodePrevision;
        }
    }
}
