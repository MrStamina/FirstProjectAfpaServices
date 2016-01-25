using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using ProjetAfpaService.Metier;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Windows.Forms;
using ProjetAfpaService.Exceptions;


namespace ProjetAfpaService.Dao
{

    using ProjetAfpaService.Metier;
    
    class DaoProjet
    {
        // pas de constructeurs
        // cette classe n'existe que pour accéder aux données

        public static List<ProjetForfait> Projets;
        ////private static List<Projet> Projet;


        private static List<Client> Clients;
        private static List<Collaborateur> Collaborateurs;
        public static List<Qualification> Qualifications;
     
       
        public static List<Client> GetAllclients()
        {
            using (SqlConnection sqlConnect = GetConnection())
            {
                using (SqlCommand sqlCde = new SqlCommand())
                {
                    sqlCde.Connection = sqlConnect;
                    string strsql = "Select [idClient],[raisonsociale],[adresse1],[adresse2],[cp],[ville],[telephone],[mail] from Client ";
                    try
                    {
                        sqlCde.CommandText = strsql;
                        SqlDataReader sqlRdr = sqlCde.ExecuteReader();
                        Clients = new List<Client>();
                        while (sqlRdr.Read())
                        {
                            Client cli = new Client()
                            {
                                CodeClient = sqlRdr.GetInt32(0),
                                RaisonSociale = sqlRdr.GetString(1),
                                Adresse1 = sqlRdr.GetString(2),
                                Adresse2 = sqlRdr[3].ToString(),
                                CP = sqlRdr.GetString(4),
                                Ville = sqlRdr.GetString(5),
                                Telephone = sqlRdr.GetString(6),
                                Mail = sqlRdr[7].ToString()
                            };
                            Clients.Add(cli);
                        }
                        sqlRdr.Close();
                        return Clients;
                    }
                    catch (Exception ex)
                    {
                        throw new DAOException(ex.Message);
                    }
                }
            }
        }

        public static List<Collaborateur> GetAllCollaborateurs()
        {
            using (SqlConnection sqlConnect = GetConnection())
            {
                using (SqlCommand sqlCde = new SqlCommand())
                {
                    sqlCde.Connection = sqlConnect;
                    string strsql = "Select [idColl],[idQualif],[nomColl],[prenomColl],[dEmbauche],[prJournalier]From Collaborateur";

                    try
                    {
                        sqlCde.CommandText = strsql;
                        SqlDataReader sqlRdr = sqlCde.ExecuteReader();
                        Collaborateurs = new List<Collaborateur>();
                        while (sqlRdr.Read())
                        {

                            Collaborateur colla = new Collaborateur()
                            {
                                CodeColl = sqlRdr.GetInt32(0),
                                LaQualif = new Qualification()
                                {
                                    CodeQualif = (sbyte)sqlRdr.GetByte(1)
                                },
                                Nom = sqlRdr.GetString(2),
                                Prenom = sqlRdr.GetString(3),
                                DEmbauche = sqlRdr.GetDateTime(4),
                                PrJournalier = sqlRdr.GetDecimal(5)
                            };
                            Collaborateurs.Add(colla);
                        }
                        sqlRdr.Close();
                        return Collaborateurs;
                    }
                    catch (Exception ex)
                    {
                        throw new DAOException(ex.Message);
                    }
                }
            }
        }

        //Ajouter un projet dans la BDD
        public static bool AddProjet(ProjetForfait pr, out int idProjet)
        {
            using (SqlConnection sqlConnect = GetConnection())
            {
                using (SqlCommand sqlCde = new SqlCommand())
                {
                    sqlCde.Connection = sqlConnect;
                    string strsql = "AddProjet";

                    try
                    {
                        sqlCde.CommandType = CommandType.StoredProcedure;
                        sqlCde.CommandText = strsql;

                        // Ajout des paramètres
                        sqlCde.Parameters.Add(new SqlParameter("@idColl", SqlDbType.Int)).Value = pr.ChefDeProjet.CodeColl;
                        sqlCde.Parameters.Add(new SqlParameter("@IdClient", SqlDbType.Int)).Value = pr.LeClient.CodeClient;
                        sqlCde.Parameters.Add(new SqlParameter("@IdQualif", SqlDbType.TinyInt)).Value = null;
                        sqlCde.Parameters.Add(new SqlParameter("@idtypep", SqlDbType.TinyInt)).Value = 1;
                        sqlCde.Parameters.Add(new SqlParameter("@nomprojet", SqlDbType.VarChar)).Value = pr.NomProjet;
                        sqlCde.Parameters.Add(new SqlParameter("@ddebut", SqlDbType.Date)).Value = pr.DDebut;
                        sqlCde.Parameters.Add(new SqlParameter("@dfin", SqlDbType.Date)).Value = pr.DFin;
                        sqlCde.Parameters.Add(new SqlParameter("@contactclient", SqlDbType.VarChar)).Value = pr.Contact;
                        sqlCde.Parameters.Add(new SqlParameter("@mailcontact", SqlDbType.VarChar)).Value = pr.MailContact;
                        sqlCde.Parameters.Add(new SqlParameter("@tarifjournalier", SqlDbType.Money)).Value = null;
                        sqlCde.Parameters.Add(new SqlParameter("@mtcontrat", SqlDbType.Money)).Value = pr.MontantContrat;
                        sqlCde.Parameters.Add(new SqlParameter("@penaliteOuiNon", SqlDbType.Bit)).Value = pr.PenaliteOuiNon;
                        sqlCde.Parameters.Add(new SqlParameter("@idProjet", SqlDbType.Int)).Direction = ParameterDirection.Output;


                        // Execution de la commande et recup parametre de sortie
                        SqlDataReader sqlRdr = sqlCde.ExecuteReader();
                       idProjet = (int)sqlCde.Parameters["@idProjet"].Value;

                        return true;
                        
                    }
                    catch (Exception ex)
                    {
                        throw new DAOException(ex.Message);
                    }
                }
            }
        }

        //Modifier un projet dans la BB
        public static bool UpdProjet(ProjetForfait pr)
        {
            using (SqlConnection sqlConnect = GetConnection())
            {
                using (SqlCommand sqlCde = new SqlCommand())
                {
                    sqlCde.Connection = sqlConnect;
                    string strsql = "updProjet";

                    try
                    {
                        sqlCde.CommandType = CommandType.StoredProcedure;
                        sqlCde.CommandText = strsql;

                        sqlCde.Parameters.Add(new SqlParameter("@idp", SqlDbType.Int)).Value = pr.CodeProjet;
                        sqlCde.Parameters.Add(new SqlParameter("@vColl", SqlDbType.Int)).Value = pr.ChefDeProjet.CodeColl;
                        sqlCde.Parameters.Add(new SqlParameter("@vClient", SqlDbType.Int)).Value = pr.LeClient.CodeClient;
                        sqlCde.Parameters.Add(new SqlParameter("@vQualif", SqlDbType.TinyInt)).Value = null;
                        sqlCde.Parameters.Add(new SqlParameter("@vtypep", SqlDbType.TinyInt)).Value = 1;
                        sqlCde.Parameters.Add(new SqlParameter("@vnomprojet", SqlDbType.VarChar)).Value = pr.NomProjet;
                        sqlCde.Parameters.Add(new SqlParameter("@vdatedebut", SqlDbType.Date)).Value = pr.DDebut;
                        sqlCde.Parameters.Add(new SqlParameter("@vdatefin", SqlDbType.Date)).Value = pr.DFin;
                        sqlCde.Parameters.Add(new SqlParameter("@vcontactclient", SqlDbType.VarChar)).Value = pr.Contact;
                        sqlCde.Parameters.Add(new SqlParameter("@vmailcontact", SqlDbType.VarChar)).Value = pr.MailContact;
                        sqlCde.Parameters.Add(new SqlParameter("@vtarifjournalier", SqlDbType.Money)).Value = null;
                        sqlCde.Parameters.Add(new SqlParameter("@vmtcontrat", SqlDbType.Money)).Value = pr.MontantContrat;
                        sqlCde.Parameters.Add(new SqlParameter("@vpenaliteOuiNon", SqlDbType.Bit)).Value = pr.PenaliteOuiNon;

                        //Execution de la commande
                        int n = sqlCde.ExecuteNonQuery();
                        if (n == 1)
                            MessageBox.Show("Mise a jour éffectuée");

                        return true;

                    }
                    catch (Exception ex)
                    {
                        throw new DAOException(ex.Message);
                    }
                }
            }
        }
        // Méthode pour supprimer un projet dans la Bdd
        public static bool DelProjet(Projet pr)
        {
            using (SqlConnection sqlConnect = GetConnection())
            {
                using (SqlCommand sqlCde = new SqlCommand())
                {
                    sqlCde.Connection = sqlConnect;
                    string strsql = "DelProjet";

                    try
                    {
                        sqlCde.CommandType = CommandType.StoredProcedure;
                        sqlCde.CommandText = strsql;


                        sqlCde.Parameters.Add(new SqlParameter("@IdProjet", SqlDbType.Int)).Value = pr.CodeProjet;

                        int n = sqlCde.ExecuteNonQuery();
                        if (n == 1)
                            MessageBox.Show("Projet supprimé");
                        return true;
                    }
                    catch (Exception ex)
                    {
                        throw new DAOException(ex.Message);
                    }

                }
            }
        }




        // Parametrage BDD avec la methode GetallProject
        public static List<ProjetForfait> GetAllProject()
        {
            using (SqlConnection sqlConnect = GetConnection())
            {
                using (SqlCommand sqlCde = new SqlCommand())
                {
                    sqlCde.Connection = sqlConnect;
                    string strsql = "GetAllProjetForfaits";

                    try
                    {
                        sqlCde.CommandType = CommandType.StoredProcedure;
                        sqlCde.CommandText = strsql;
                        SqlDataReader sqlRdr = sqlCde.ExecuteReader();
                        Projets = new List<ProjetForfait>();
                        while (sqlRdr.Read())
                        {
                            
                            ProjetForfait projet = new ProjetForfait()
                            {
                                CodeProjet = sqlRdr.GetInt32(0),
                                NomProjet = sqlRdr.GetString(1),
                                DDebut = sqlRdr.GetDateTime(2),
                                DFin = sqlRdr.GetDateTime(3),
                                Contact = sqlRdr[4].ToString(),
                                MailContact = sqlRdr[5].ToString(),
                                LeClient = new Client()
                                {
                                    CodeClient = sqlRdr.GetInt32(6)
                                },
                                MontantContrat = sqlRdr.GetDecimal(7),
                                ChefDeProjet = new Collaborateur()
                                {
                                    CodeColl = sqlRdr.GetInt32(9)
                                },

                                PenaliteOuiNon = sqlRdr.GetSqlBoolean(8) == true ? Penalite.Oui : Penalite.Non
                            };
                            Projets.Add(projet);
                        }
                        sqlRdr.Close();
                        return Projets;
                    }
                    catch (Exception ex)
                    {
                        throw new DAOException(ex.Message);
                    }

                }
            }

        }

        public static List<Qualification> GetAllQualification()
        {
            return Qualifications;
        }

        // Création d'un méthode pour se connecter a la base de donnée
        public static SqlConnection GetConnection()
        {
            string strConn = "Data Source=(local);" +
                                             "Initial Catalog = GesProjet;" +
                                             "Integrated Security = True;" +
                                             "Connection TimeOut = 10";
                SqlConnection sqlConnect = new SqlConnection(strConn);
            
                try
                {
                    sqlConnect.Open();
                    MessageBox.Show("Connexion établie");
                    return sqlConnect;
                }
                catch(SqlException sql)
                {
                    throw new DAOException("Connexion impossible", sql);
                }
            
        }

        

    }
}
