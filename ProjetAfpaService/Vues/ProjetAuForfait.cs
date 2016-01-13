using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetAfpaService.Dao;

namespace ProjetAfpaService
{
    public partial class Form1 : Form
    {
        bool nomProjet;
        bool dateIsOk;
        DateTime dateFin;
        DateTime dateDebut;
        public Form1()
        {
            InitializeComponent();
        }

       // Controle de la saisie des informations
        private void textBoxNomProjet_Validating(object sender, CancelEventArgs e)
        {
            if(textBoxNomProjet.Text == string.Empty)
            {
                errorProviderNomProjet.SetError(textBoxNomProjet, "Veuillez entrer un nom de projet");
                nomProjet = false;
            }
            else
            {
                nomProjet = true;
                errorProviderNomProjet.SetError(textBoxNomProjet, string.Empty);
            }
        }
        private void maskedTextBoxDateDebut_Validating(object sender, CancelEventArgs e)
        {
            if(DateTime.TryParse(maskedTextBoxDateDebut.Text, out dateDebut))
            {
               dateIsOk = true;
               errorProviderDateDebut.SetError(maskedTextBoxDateDebut, string.Empty);
            }
            else
            {
                dateIsOk = false;
                errorProviderDateDebut.SetError(maskedTextBoxDateDebut, "Veuillez entrer une date au format valide");
            }
        }

        private void maskedTextBoxDateFin_Validating(object sender, CancelEventArgs e)
        {
            if (DateTime.TryParse(maskedTextBoxDateFin.Text, out dateFin))
            {
                dateIsOk = true;
                errorProviderDateFin.SetError(maskedTextBoxDateFin, string.Empty);
                if (dateFin <= dateDebut)
                {
                    dateIsOk = false;
                    errorProviderDateFin.SetError(maskedTextBoxDateFin, "Attention la date saisie se situe avant la date de début");
                    maskedTextBoxDateFin.Focus();
                }
                else
                {
                    dateIsOk = true;
                    errorProviderDateFin.SetError(maskedTextBoxDateFin, string.Empty);
                }
            }
            else
            {
                dateIsOk = false;
                errorProviderDateFin.SetError(maskedTextBoxDateFin, " Veuillez entrer une date au format valide");
            }
        }

        // On lance le databinding au chargement
        private void Form1_Load(object sender, EventArgs e)
        {
            clientBindingSource.DataSource = DaoProjet.GetAllclients();
            collaborateurBindingSource.DataSource = DaoProjet.GetAllCollaborateurs();
        }

        // On gère l'evenement du click sur valider
        private void buttonValider_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int codeProjet = random.Next(1, 100);

        }

        // Gestion du bouton Quitter
        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            const string message = "Etes-vous sûr de vouloir quitter ?";
            const string caption = "QUITTER";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
                e.Cancel = true;
        }
    }
}
