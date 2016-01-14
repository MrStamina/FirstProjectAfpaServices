using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetAfpaService.Metier
{
    class Client
    {
        public int CodeClient { get; set; }
        public string RaisonSociale { get; set; }
        public string Adresse1 { get; set; }
        public string Adresse2 { get; set; }
        public string CP { get; set; }
        public string Ville { get; set; }
        public string Telephone { get; set; }
        public string Mail { get; set; }

        public Client(int initCodeClient, string initRaisonSociale, string initAdresse1, string initAdresse2, string initCodePostal, string initVille, string initTelephone, string initMail)
        {
            CodeClient = initCodeClient;
            RaisonSociale = initRaisonSociale;
            Adresse1 = initAdresse1;
            Adresse2 = initAdresse2;
            CP = initCodePostal;
            Ville = initVille;
            Telephone = initTelephone;
            Mail = initMail;
        }

        // ToString et Equals

        public override string ToString()
        {
            return "[" + RaisonSociale + "," + Adresse1 + "," + Adresse2 + "," + CP + "," + Telephone +  "]";
        }
    }
}
