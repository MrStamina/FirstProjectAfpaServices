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

namespace ProjetAfpaService.Vues
{
    public partial class Prevision : Form
    {
        public Prevision()
        {
            InitializeComponent();
        }

        // Gestion du chargement des bindings
        private void Prevision_Load(object sender, EventArgs e)
        {
            qualificationBindingSource.DataSource = DaoProjet.GetAllQualification();
            projetForfaitBindingSource.DataSource = DaoProjet.GetAllProject();
            comboBoxProjet.SelectedItem = null;
            groupBoxPrevision.Visible = false;
        }

        //Gestion du selected index
        private void comboBoxProjet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxProjet.SelectedItem != null)
            {
                previsionBindingSource.DataSource = DaoProjet.GetAllProject()[comboBoxProjet.SelectedIndex].GetAllPrevision();
            }
            
        }

        private void buttonCreer_Click(object sender, EventArgs e)
        {
            groupBoxPrevision.Visible = true;
        }
    }
}
