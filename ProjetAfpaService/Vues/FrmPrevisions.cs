using System;
using System.Windows.Forms;
using ProjetAfpaService.Dao;
using ProjetAfpaService.Metier;

namespace ProjetAfpaService.Vues
{
    public partial class FrmPrevisions : Form
    {
        bool buttonValiderModifClick;
       
        public FrmPrevisions()
        {
            InitializeComponent();
        }

        // Gestion du chargement des bindings
        private void Prevision_Load(object sender, EventArgs e)
        {
            
            projetForfaitBindingSource.DataSource = DaoProjet.GetAllProject();
            qualificationBindingSource.DataSource = DaoProjet.GetAllQualification();
            comboBoxProjet.SelectedItem = null;
            groupBoxPrevision.Visible = false;
        }

        //Gestion du selected index
        private void comboBoxProjet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxProjet.SelectedItem != null)
            {
                previsionBindingSource.DataSource = DaoProjet.GetAllProject()[comboBoxProjet.SelectedIndex].GetAllPrevision();
                buttonCreer.Enabled = true;
            }
           

        }

        //Gestion du bouton Creér
        private void buttonCreer_Click(object sender, EventArgs e)
        {
            if (comboBoxProjet.SelectedItem != null)
            {
                groupBoxPrevision.Visible = true;
               
            }
        }

        //Gestion du bouton Annuler
        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            qualificationBindingSource.ResetCurrentItem();
            groupBoxPrevision.Visible = false;
     
           
        }

        #region Gestion du bouton Quitter
        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Prevision_FormClosing(object sender, FormClosingEventArgs e)
        {
            const string message = "Etes-vous sûr de vouloir quitter ?";
            const string caption = "QUITTER";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
                e.Cancel = true;
        }
        #endregion

        private void buttonValider_Click(object sender, EventArgs e)
        {
            if (!buttonValiderModifClick &&comboBoxQualification.SelectedItem != null && numericUpDownNbJours.Value > 0)
            {
                DaoProjet.GetAllProject()[comboBoxProjet.SelectedIndex].AddPrevision(new Prevision((Qualification)comboBoxQualification.SelectedItem, (short)numericUpDownNbJours.Value));
                previsionBindingSource.DataSource = DaoProjet.GetAllProject()[comboBoxProjet.SelectedIndex].GetAllPrevision();
                previsionBindingSource.ResetBindings(true);

            }
            else if(buttonValiderModifClick)
            {
                
                ((Prevision)laQualifDataGridViewTextBoxColumn.DataGridView.CurrentRow.DataBoundItem).LaQualif = (Qualification)comboBoxQualification.SelectedItem;
                Prevision p = (Prevision)dataGridViewPrevisions.CurrentRow.DataBoundItem;
                p.NbJours = Convert.ToInt16(numericUpDownNbJours.Value);
                previsionBindingSource.ResetBindings(true);
                
            }
            groupBoxPrevision.Visible = false;
        }

        #region Gestion du bouton Modifier et Supprimer
        private void dataGridViewPrevisions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.ColumnIndex == dataGridViewPrevisions.Columns["Modifier"].Index && e.RowIndex >=0)
            {
                Prevision p = (Prevision)dataGridViewPrevisions.CurrentRow.DataBoundItem;
                groupBoxPrevision.Visible = true;
                comboBoxQualification.SelectedItem = p.LaQualif;
                numericUpDownNbJours.Value = p.NbJours;
                buttonValiderModifClick = true;
            }
            else if(e.ColumnIndex == dataGridViewPrevisions.Columns["Supprimer"].Index && e.RowIndex >=0)
            {
                string message = "Etes-vous sûr de vouloir supprimer";
                string caption = "Suppression d'une prévision";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {  
                    previsionBindingSource.RemoveAt(dataGridViewPrevisions.CurrentRow.Index);
                    previsionBindingSource.ResetBindings(true);
                }
            }
        }
        #endregion

    }
}
