using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjetAfpaService.Dao;
using ProjetAfpaService.Exceptions;
using System.Data.SqlClient;
using System.Data;

namespace ProjetAfpaService.Metier
{
    class ProjetForfait : Projet
    {
        public decimal MontantContrat{ get; set; }
        public Penalite PenaliteOuiNon { get; set; }
        public Collaborateur ChefDeProjet{ get; set; }
        public List<Prevision> previsions;

        
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

        public List<Prevision> GetAllPrevision()
        {
            using (SqlConnection sqlConnect = DaoProjet.GetConnection())
            {
                using (SqlCommand sqlCde = new SqlCommand())
                {
                    sqlCde.Connection = sqlConnect;
                    string strsql = "GetAllPrevisions";

                    try
                    {
                        sqlCde.CommandType = CommandType.StoredProcedure;
                        sqlCde.CommandText = strsql;
                        SqlDataReader sqlRdr = sqlCde.ExecuteReader();
                        previsions = new List<Prevision>();
                        while (sqlRdr.Read())
                        {
                            Prevision previs = new Prevision()
                            {
                                CodePrevision = sqlRdr.GetInt32(0),
                                CodeProjet = sqlRdr.GetInt32(1),
                                NbJours = sqlRdr.GetInt16(3),                         
                                LaQualif = new Qualification()
                                {
                                    CodeQualif = (sbyte)sqlRdr.GetByte(2)
                                },
                            };
                            previsions.Add(previs);
                        }
                        sqlRdr.Close();
                        return previsions;
                    }
                    catch (Exception ex)
                    {
                        throw new DAOException(ex.Message);
                    }
                }
            }
        }
        //TODO Faire le getallQualification, comparer idprojet, Codequalif et faire Form(Mère-Fille), Mettre dans la DAO
        public  bool AddPrevision(Prevision prev)
        {
            previsions.Add(prev);
            return true;
        }
    }
}

