using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetAfpaService.Methodes
{
    class MethodesUtiles
    {

        // Méthodes pour passer de Enabled true a false et inversement

        //public static void EnabledChangeToFalse(Control form)
        //{
        //    foreach (Control control in form.Controls)
        //    {
        //        if(control is GroupBox)
        //        {
        //            control.Enabled = false;
        //        }


        //    }
        //}

        //public static void EnabledChangeToTrue(Control form)
        //{
        //    foreach (Control control in form.Controls)
        //    {
        //        control.Enabled = true;
        //    }
        //}

        public static void ChangerEnabledFalse(TextBox txtbox, MaskedTextBox msktxtbox, MaskedTextBox msktxtbox2, ComboBox cbobox,
            TextBox txtbox2, TextBox txtbox3, ComboBox cbobox2, GroupBox grp, TextBox txtbox4, Button butt )
        {
            txtbox.Enabled = false;
            msktxtbox.Enabled = false;
            msktxtbox2.Enabled = false;
            cbobox.Enabled = false;
            txtbox2.Enabled = false;
            txtbox3.Enabled = false;
            cbobox2.Enabled = false;
            grp.Enabled = false;
            txtbox4.Enabled = false;
            butt.Enabled = false;
        }
    }
}
