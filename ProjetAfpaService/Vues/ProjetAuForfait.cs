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
using ProjetAfpaService.Methodes;

namespace ProjetAfpaService
{
    public partial class Form1 : Form
    {
        bool clickCreer;
        bool clickModif;
        bool nomIsOk;
        bool dateIsOk;
        bool montantIsOk;
        DateTime dateFin;
        DateTime dateDebut;
        public Form1()
        {
            InitializeComponent();
            this.CancelButton = buttonAnnuler;

        }

        // Controle de la saisie des informations
        #region Gestion de la saisie des informations
        private void textBoxNomProjet_Validating(object sender, CancelEventArgs e)
        {


            if (textBoxNomProjet.Text == string.Empty)
            {
                errorProviderNomProjet.SetError(textBoxNomProjet, "Veuillez entrer un nom de projet");
                textBoxNomProjet.Focus();
                nomIsOk = false;
            }
            else
            {

                errorProviderNomProjet.SetError(textBoxNomProjet, string.Empty);
                nomIsOk = true;
            }

        }
        private void maskedTextBoxDateDebut_Validating(object sender, CancelEventArgs e)
        {


            if (DateTime.TryParse(maskedTextBoxDateDebut.Text, out dateDebut))
            {

                errorProviderDateDebut.SetError(maskedTextBoxDateDebut, string.Empty);
                dateIsOk = true;
            }
            else
            {

                errorProviderDateDebut.SetError(maskedTextBoxDateDebut, "Veuillez entrer une date au format valide");
                dateIsOk = false;
            }

        }

        private void maskedTextBoxDateFin_Validating(object sender, CancelEventArgs e)
        {


            if (DateTime.TryParse(maskedTextBoxDateFin.Text, out dateFin))
            {

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

        private void textBoxMailContact_Validated(object sender, EventArgs e)
        {
            textBoxMontantContrat.Focus();
        }

        private void textBoxMontantContrat_Validating(object sender, CancelEventArgs e)
        {


            if (textBoxMontantContrat.Text == string.Empty)
            {
                montantIsOk = false;
                errorProviderMontant.SetError(textBoxMontantContrat, "Veuillez saisir le montant du contrat");

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
        #endregion

        // On lance le databinding au chargement
        private void Form1_Load(object sender, EventArgs e)
        {


            projetForfaitBindingSource.DataSource = DaoProjet.GetAllProject();
            clientBindingSource.DataSource = DaoProjet.GetAllclients();
            collaborateurBindingSource.DataSource = DaoProjet.GetAllCollaborateurs();
            comboBoxNomProjet.SelectedItem = null;
            groupBoxProjet.Visible = false;
            groupBoxForfait.Visible = false;

        }

        // On gère l'evenement du click sur valider
        private void buttonValider_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int codeProjet = random.Next(1, 100);


            if (clickCreer == true)
            {
                if (comboBoxResponsable.SelectedItem != null && comboBoxClient != null && nomIsOk == true && dateIsOk == true && montantIsOk == true)
                {

                    ProjetForfait projet = new ProjetForfait(codeProjet, textBoxNomProjet.Text, dateDebut, dateFin, (Client)comboBoxClient.SelectedItem, textBoxContact.Text, textBoxMailContact.Text, Convert.ToDecimal(textBoxMontantContrat.Text),radioButtonOui.Checked, (Collaborateur)comboBoxResponsable.SelectedItem);
                    const string caption = "Projet enregistré";
                    string message = "Projet" + projet.ToString() + "\n" + "Client" + comboBoxClient.SelectedItem.ToString() + "\n" + textBoxContact.Text + "," + textBoxMailContact.Text + "\n" + "[" + textBoxMontantContrat.Text + "," + "Collaborateur" + comboBoxResponsable.SelectedItem.ToString();
                    MessageBox.Show(message, caption, MessageBoxButtons.OK);
                    DaoProjet.AddProjet(projet);
                    comboBoxNomProjet.Enabled = true;

                    projetForfaitBindingSource.ResumeBinding();
                    comboBoxNomProjet.SelectedItem = null;
                    MethodesUtiles.ChangerEnabledFalse(textBoxNomProjet, maskedTextBoxDateDebut, maskedTextBoxDateFin, comboBoxClient, textBoxContact
                        , textBoxMailContact, comboBoxResponsable, groupBoxPenalites, textBoxMontantContrat, buttonValider);

                    groupBoxForfait.Visible = false;
                    groupBoxProjet.Visible = false;


                }
                else
                    MessageBox.Show("Veuillez selectionner un client et un collaborateur");
            }
            else if (clickModif == true)
            {
                Verif();
                if (comboBoxResponsable.SelectedItem != null && comboBoxClient != null && nomIsOk == true && dateIsOk == true && montantIsOk == true)
                {
                    string message = "Veuillez confirmer la modification";
                    string caption = "Validation de la modification";
                    var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        ProjetForfait projet = new ProjetForfait(codeProjet, textBoxNomProjet.Text, dateDebut, dateFin, (Client)comboBoxClient.SelectedItem, textBoxContact.Text, textBoxMailContact.Text, Convert.ToDecimal(textBoxMontantContrat.Text), radioButtonOui.Checked, (Collaborateur)comboBoxResponsable.SelectedItem);
                        const string caption2 = "Projet enregistré";
                        string message2 = "Projet" + projet.ToString() + "\n" + "Client" + comboBoxClient.SelectedItem.ToString() + "\n" + textBoxContact.Text + "," + textBoxMailContact.Text + "\n" + "[" + textBoxMontantContrat.Text + "," + "Collaborateur" + comboBoxResponsable.SelectedItem.ToString();
                        MessageBox.Show(message2, caption2, MessageBoxButtons.OK);
                        DaoProjet.AddProjet(projet);
                        comboBoxNomProjet.Enabled = true;

                        projetForfaitBindingSource.ResumeBinding();
                        comboBoxNomProjet.SelectedItem = null;
                        MethodesUtiles.ChangerEnabledFalse(textBoxNomProjet, maskedTextBoxDateDebut, maskedTextBoxDateFin, comboBoxClient, textBoxContact
                            , textBoxMailContact, comboBoxResponsable, groupBoxPenalites, textBoxMontantContrat, buttonValider);

                        groupBoxForfait.Visible = false;
                        groupBoxProjet.Visible = false;
                    }
                }
            }
            else
            {
                if (nomIsOk == false)
                {
                    errorProviderNomProjet.SetError(textBoxNomProjet, "Le nom est obligatoire pour créer un projet");
                }
                else if (dateIsOk == false)
                {
                    errorProviderDateDebut.SetError(maskedTextBoxDateDebut, "La saisie des dates est obligatoire");
                    errorProviderDateFin.SetError(maskedTextBoxDateFin, "La saisie des dates est obligatoire");
                }
                else if (montantIsOk == false)
                {
                    errorProviderMontant.SetError(textBoxMontantContrat, "Le montant du contrat est obligatoire pour créer un projet");
                }

            }



        }

        // Gestion du bouton Quitter et du FormClosing
        #region Gestion du bouton Quitter
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
        #endregion

        // Gestion de la combobox Nom projet

        private void comboBoxNomProjet_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProjetForfait projet = (ProjetForfait)comboBoxNomProjet.SelectedItem;
            if (comboBoxNomProjet.SelectedItem != null)
            {

                groupBoxProjet.Visible = true;
                groupBoxForfait.Visible = true;
                MethodesUtiles.ChangerEnabledFalse(textBoxNomProjet, maskedTextBoxDateDebut, maskedTextBoxDateFin, comboBoxClient, textBoxContact
                    , textBoxMailContact, comboBoxResponsable, groupBoxPenalites, textBoxMontantContrat, buttonValider);
                buttonModifier.Enabled = true;
                buttonSupprimer.Enabled = true;
                buttonCreer.Enabled = false;
                if (projet.PenaliteOuiNon == Penalite.Oui)
                {
                    radioButtonOui.Checked = true;
                }
                else
                    radioButtonNon.Checked = true;
            }


        }


        // Méthode pour changer l'Enabled
        #region Méthode pour changer Enable
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

        #endregion


        // Gestion du click sur le bouton modifier
        private void buttonModifier_Click(object sender, EventArgs e)
        {

            ChangerEnabledTrue();
            buttonValider.Enabled = true;
            clickModif = true;
            clickCreer = false;
        }

        // Gestion du click sur le bouton créer

        private void buttonCreer_Click(object sender, EventArgs e)
        {
            InitDatabinding(true);
            groupBoxForfait.Visible = true;
            groupBoxProjet.Visible = true;
            ChangerEnabledTrue();
            buttonModifier.Enabled = false;
            buttonSupprimer.Enabled = false;
            buttonValider.Enabled = true;
            comboBoxNomProjet.Enabled = false;
            buttonCreer.Enabled = false;
            comboBoxClient.SelectedItem = null;
            comboBoxResponsable.SelectedItem = null;
            clickCreer = true;



        }

        // gestion du databinding
        private void InitDatabinding(bool enable)
        {
            if (enable)
            {
                projetForfaitBindingSource.SuspendBinding();
            }
            else if (!enable)
            {
                projetForfaitBindingSource.ResumeBinding();
            }
        }

        // Gestion du bouton annuler


        private void buttonAnnuler_Click(object sender, EventArgs e)
        {

            projetForfaitBindingSource.ResetCurrentItem();
            groupBoxForfait.Visible = false;
            groupBoxProjet.Visible = false;
            comboBoxNomProjet.SelectedItem = null;
            buttonCreer.Enabled = true;

        }

        // Gestion du boutton supprimer
        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            if (comboBoxNomProjet.SelectedIndex >= 0)
            {
                string message = "Etes-vous sûr de vouloir supprimer";
                string caption = "Suppression d'un projet";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    projetForfaitBindingSource.Remove(comboBoxNomProjet.SelectedItem);
                    projetForfaitBindingSource.ResetBindings(true);
                }
            }
            comboBoxNomProjet.SelectedItem = null;
            groupBoxProjet.Visible = false;
            groupBoxForfait.Visible = false;
        }

        private void Verif()
        {
            if (textBoxNomProjet.Text != string.Empty)
            {
                
                nomIsOk = true;
            }
            if (DateTime.TryParse(maskedTextBoxDateDebut.Text, out dateDebut))
            {

                errorProviderDateDebut.SetError(maskedTextBoxDateDebut, string.Empty);
                dateIsOk = true;
            }
           
            if (DateTime.TryParse(maskedTextBoxDateFin.Text, out dateFin))
            {

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
            if (textBoxMontantContrat.Text != string.Empty)
            {
                montantIsOk = true;
                

            }
            else
            {
                if (nomIsOk == false)
                {
                    errorProviderNomProjet.SetError(textBoxNomProjet, "Le nom est obligatoire pour créer un projet");
                }
                else if (dateIsOk == false)
                {
                    errorProviderDateDebut.SetError(maskedTextBoxDateDebut, "La saisie des dates est obligatoire");
                    errorProviderDateFin.SetError(maskedTextBoxDateFin, "La saisie des dates est obligatoire");
                }
                else if (montantIsOk == false)
                {
                    errorProviderMontant.SetError(textBoxMontantContrat, "Le montant du contrat est obligatoire pour créer un projet");
                }

            }
            
        
        }


    }
}
