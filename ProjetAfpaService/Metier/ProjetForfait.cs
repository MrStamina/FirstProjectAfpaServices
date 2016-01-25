using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetAfpaService.Metier
{
    class ProjetForfait : Projet
    {
        public decimal MontantContrat{ get; set; }
        public Penalite PenaliteOuiNon { get; set; }
        public Collaborateur ChefDeProjet{ get; set; }
        private List<Prevision> previsions;

        
        public ProjetForfait()
        {

        }
        public ProjetForfait(int initCodeProjet, string initNomProjet, DateTime initDdebut, DateTime initDfin, Client initLeCLient, string initContact, string initMailContact, decimal initMontantContrat, bool YesNo, Collaborateur initChefDeProjet, List<Prevision> initPrevisions)
        {
            CodeProjet = initCodeProjet;
            NomProjet = initNomProjet;
            DDebut = initDdebut;
            DFin = initDfin;
            LeClient = initLeCLient;
            Contact = initContact;
            MailContact = initMailContact;
            MontantContrat = initMontantContrat;
            if (YesNo == true)
            {
                PenaliteOuiNon = Penalite.Oui;
            }
            else PenaliteOuiNon = Penalite.Non;
            ChefDeProjet = initChefDeProjet;
            previsions = initPrevisions;
        }

        public ProjetForfait(int initCodeProjet, string initNomProjet, DateTime initDdebut, DateTime initDfin, Client initLeCLient, string initContact, string initMailContact, decimal initMontantContrat, bool YesNo, Collaborateur initChefDeProjet)
        {
            CodeProjet = initCodeProjet;
            NomProjet = initNomProjet;
            DDebut = initDdebut;
            DFin = initDfin;
            LeClient = initLeCLient;
            Contact = initContact;
            MailContact = initMailContact;
            MontantContrat = initMontantContrat;
            if (YesNo == true)
            {
                PenaliteOuiNon = Penalite.Oui;
            }
            else PenaliteOuiNon = Penalite.Non;
            ChefDeProjet = initChefDeProjet;
           

        }

        
        public override string ToString()
        {
            return base.ToString();
        }

        public  List<Prevision> GetAllPrevision()
        {
            return previsions;
        }

        public  bool AddPrevision(Prevision prev)
        {
            previsions.Add(prev);
            return true;
        }
    }
}

