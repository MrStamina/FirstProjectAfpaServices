using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetAfpaService.Metier
{
    class Qualification
    {
        public sbyte CodeQualif { get; set; }
        public string Libelle { get; set; }
        public decimal PvJournee { get; set; }

        public Qualification()
        {

        }
            
        public Qualification(sbyte initCodeQualif, string initLibelle, decimal initPvJournee)
        {
            CodeQualif = initCodeQualif;
            Libelle = initLibelle;
            PvJournee = initPvJournee;
        }


        public Qualification Self
        {
            get { return this; }
        }
        //public override string ToString()
        //{
        //    return 
        //}
        //public override bool Equals(object obj)
        //{
        //    return base.Equals(obj);
        //}
    }
}
