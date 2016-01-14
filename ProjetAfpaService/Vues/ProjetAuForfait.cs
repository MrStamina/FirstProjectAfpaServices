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
using System.Text.RegularExpressions;
using ProjetAfpaService.Metier;

namespace ProjetAfpaService
{
    public partial class Form1 : Form
    {
        bool nomProjet;
        bool dateIsOk;
        bool montantIsOk;
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

        private void textBoxContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) & e.KeyChar != (char)Keys.Back & e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true;
            }
        }

        private void textBoxMailContact_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxMailContact.Text != string.Empty)
            {
                if (!Regex.IsMatch(textBoxMailContact.Text, @"^([\w-\.])+@([\w]+\.)([a-zA-Z0-9]{2,4})$"))
                {
                    errorProviderMailAdress.SetError(textBoxMailContact, "Le format de l'adresse mail est incorrect");
                    textBoxMailContact.Focus();
                }
                else
                {
                    errorProviderMailAdress.SetError(textBoxMailContact, string.Empty);
                }
            }
        }

        private void textBoxMontantContrat_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxMontantContrat.Text == string.Empty)
            {
                errorProviderMontant.SetError(textBoxMontantContrat, "Veuillez saisir le montant du contrat");
                montantIsOk = false;
            }
            else
            {
                montantIsOk = true;
                errorProviderMontant.SetError(textBoxMontantContrat, string.Empty);
            }
        }

        private void textBoxMontantContrat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        // On lance le databinding au chargement
        private void Form1_Load(object sender, EventArgs e)
        {
            clientBindingSource.DataSource = DaoProjet.GetAllclients();
            collaborateurBindingSource.DataSource = DaoProjet.GetAllCollaborateurs();
            projetForfaitBindingSource.DataSource = DaoProjet.GetAllProject();
            comboBoxNomProjet.SelectedItem = null;
            groupBoxProjet.Visible = false;
            groupBoxForfait.Visible = false;

        }

        // On gère l'evenement du click sur valider
        private void buttonValider_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int codeProjet = random.Next(1, 100);

            if (nomProjet == true && dateIsOk == true && montantIsOk == true)
            {
                ProjetForfait projet = new ProjetForfait(codeProjet, textBoxNomProjet.Text, dateDebut, dateFin, (Client)comboBoxClient.SelectedItem, textBoxContact.Text, textBoxMailContact.Text, Convert.ToDecimal(textBoxMontantContrat.Text),(Collaborateur)comboBoxResponsable.SelectedItem);
                const string caption = "Projet enregistré";
                string message = "Projet" + projet.ToString() + "\n" + "Client" + comboBoxClient.SelectedItem.ToString() + "\n" + textBoxContact.Text + "," + textBoxMailContact.Text + "\n" + "[" + textBoxMontantContrat.Text + "," + "Collaborateur" + comboBoxResponsable.SelectedItem.ToString();
                MessageBox.Show(message, caption, MessageBoxButtons.OK);
                DaoProjet.AddProjet(projet);
                                    
            }
            else
            {
                if(nomProjet == false)
                {
                    errorProviderNomProjet.SetError(textBoxNomProjet, "Le nom est obligatoire pour créer un projet");
                }
                if (dateIsOk == false)
                {
                    errorProviderDateDebut.SetError(maskedTextBoxDateDebut, "La saisie des dates est obligatoire");
                    errorProviderDateFin.SetError(maskedTextBoxDateFin, "La saisie des dates est obligatoire");
                }
                if(montantIsOk == false)
                {
                    errorProviderMontant.SetError(textBoxMontantContrat, "Le montant du contrat est obligatoire pour créer un projet");
                }
            }

        }

        // Gestion du bouton Quitter et du FormClosing
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

        // Gestion de la combobox Nom projet
        
        private void comboBoxNomProjet_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            groupBoxProjet.Visible = true;
            groupBoxForfait.Visible = true;
            ChangerEnabledFalse();
           
        }

        // Méthode pour changer l'Enabled
        private void ChangerEnabledFalse()
        {
            textBoxNomProjet.Enabled = false;
            maskedTextBoxDateDebut.Enabled = false;
            maskedTextBoxDateFin.Enabled = false;
            comboBoxClient.Enabled = false;
            textBoxContact.Enabled = false;
            textBoxMailContact.Enabled = false;
            comboBoxResponsable.Enabled = false;
            groupBoxPenalites.Enabled = false;
            textBoxMontantContrat.Enabled = false;
            buttonValider.Enabled = false;
        }

        private void ChangerEnabledTrue()
        {
            textBoxNomProjet.Enabled = true;
            maskedTextBoxDateDebut.Enabled = true;
            maskedTextBoxDateFin.Enabled = true;
            comboBoxClient.Enabled = true;
            textBoxContact.Enabled = true;
            textBoxMailContact.Enabled = true;
            comboBoxResponsable.Enabled = true;
            groupBoxPenalites.Enabled = true;
            textBoxMontantContrat.Enabled = true;
            buttonValider.Enabled = false;
        }

        // Gestion du click sur le bouton modifier
        // TODO Pas terminé

        private void buttonModifier_Click(object sender, EventArgs e)
        {
            ChangerEnabledTrue();
            buttonValider.Enabled = true;
        }

        // Gestion du click sur le bouton créer
        private void buttonCreer_Click(object sender, EventArgs e)
        {
            groupBoxForfait.Visible = true;
            groupBoxProjet.Visible = true;
            
        }
    }
}
