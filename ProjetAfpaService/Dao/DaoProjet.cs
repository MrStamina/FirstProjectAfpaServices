using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using ProjetAfpaService.Metier;

namespace ProjetAfpaService.Dao
{

    using ProjetAfpaService.Metier;
    
    class DaoProjet
    {
        // pas de constructeurs
        // cette classe n'existe que pour accéder aux données

        private static List<ProjetForfait> Projets;
        //private static List<Projet> Projet;
       

        private static List<Client> Clients;	
        private static List<Collaborateur> Collaborateurs;	
        private static List<Qualification> Qualifications;
       


        public static void Init()
        {
            //InitStatuts();
            Qualifications = new List<Qualification>
            {
                new Qualification(1,"Chef de projet", 800),
                new Qualification(2,"Concepteur Developpeur", 500),
                new Qualification(3,"Développeur", 400),
                new Qualification(4,"Architecte",800)
            };
            Collaborateurs = new List<Collaborateur>
            {
                new Collaborateur(1,"Valentini" , "Alain",new DateTime(2004,9,30), 500, Qualifications[0]),
                new Collaborateur(2,"Laridan" , "Louise",new DateTime(2014,1,15), 250, Qualifications[1]),
                new Collaborateur(3,"Bekchiche" , "Said",new DateTime(2012,9,1), 300, Qualifications[1]),
                new Collaborateur(4,"Paradis" , "Vanessa",new DateTime(2014,10,01), 200, Qualifications[2]),
                new Collaborateur(5,"Pitt" , "Brad",new DateTime(2014,10,01), 200, Qualifications[2]),
                new Collaborateur(6,"Bruel" , "Patrick",new DateTime(2014,9,01), 800, Qualifications[3])
            };
            Clients = new List<Client>
            {
                new Client(1,"Ets les moulins","Avenue du bateau blanc",null,"12345", "Champouxville","1111111111", "contact@lesmoulins.com"),
                new Client(2,"Haribo France","67, Avenue du Capitaine Geze", null, "13013", "Marseille", "0101010101", null)
            };

            Projets = new List<ProjetForfait>
            {
                new ProjetForfait(8520, "Gesbonbon", new DateTime(2015,02,01), new DateTime(2015,05,30),Clients[1],"Catherine Tagada","c.tagada@haribo.fr",100000,Penalite.Oui,Collaborateurs[0],
                     new List<Prevision>
                    {
                        new Prevision(Qualifications[0],36),
                        new Prevision(Qualifications[1],72),
                        new Prevision(Qualifications[2],726)
                    }),
                new ProjetForfait(2003, "SansPrevision", new DateTime(2014,12,15),new DateTime(2014,05,30),Clients[0],"Catherine Tagada","ctagada@haribo.fr",100000,Penalite.Non,Collaborateurs[0])
                //,new ProjetRegie(1001, "Gescom", new DateTime(2014,12,1),new DateTime(2015,03,31),Clients[0], "Catherine Tagada","ctagada@haribo.fr",450,Qualifications[1]),
                //new ProjetRegie(1002, "Gescom", new DateTime(2015,01,5),new DateTime(2015,01,31),Clients[0], "Catherine Tagada","ctagada@haribo.fr",400,Qualifications[2])
            };
        }

        public static List<Client> GetAllclients()
        {
            return Clients;
        }

        public static List<Collaborateur> GetAllCollaborateurs()
        {
            return Collaborateurs;
        }

        public static bool AddProjet(ProjetForfait pr)
        {
            Projets.Add(pr);
            return true;
        }

        public static List<ProjetForfait> GetAllProject()
        {
            return Projets;
        }

        public static List<Qualification> GetAllQualification()
        {
            return Qualifications;
        }

        

        //public static List<Projet> GetAllProject(string typeName)
        //{
        //    return Projet.Where()
        //}

    }
}
