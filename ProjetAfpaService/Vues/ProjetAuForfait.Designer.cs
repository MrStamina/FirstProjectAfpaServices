namespace ProjetAfpaService
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBoxProjet = new System.Windows.Forms.GroupBox();
            this.maskedTextBoxDateFin = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxDateDebut = new System.Windows.Forms.MaskedTextBox();
            this.labelMailContact = new System.Windows.Forms.Label();
            this.labelContact = new System.Windows.Forms.Label();
            this.labelClient = new System.Windows.Forms.Label();
            this.labelDateFin = new System.Windows.Forms.Label();
            this.labelDateDebut = new System.Windows.Forms.Label();
            this.labelNomProjet = new System.Windows.Forms.Label();
            this.comboBoxClient = new System.Windows.Forms.ComboBox();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxContact = new System.Windows.Forms.TextBox();
            this.textBoxMailContact = new System.Windows.Forms.TextBox();
            this.textBoxNomProjet = new System.Windows.Forms.TextBox();
            this.buttonValider = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBoxForfait = new System.Windows.Forms.GroupBox();
            this.labelResponsable = new System.Windows.Forms.Label();
            this.labelMontantContrat = new System.Windows.Forms.Label();
            this.comboBoxResponsable = new System.Windows.Forms.ComboBox();
            this.collaborateurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxMontantContrat = new System.Windows.Forms.TextBox();
            this.groupBoxPenalites = new System.Windows.Forms.GroupBox();
            this.radioButtonOui = new System.Windows.Forms.RadioButton();
            this.radioButtonNon = new System.Windows.Forms.RadioButton();
            this.buttonQuitter = new System.Windows.Forms.Button();
            this.errorProviderNomProjet = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderDateFin = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderDateDebut = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderMailAdress = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderMontant = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxProjet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.groupBoxForfait.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.collaborateurBindingSource)).BeginInit();
            this.groupBoxPenalites.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNomProjet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDateFin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDateDebut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMailAdress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMontant)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxProjet
            // 
            this.groupBoxProjet.Controls.Add(this.maskedTextBoxDateFin);
            this.groupBoxProjet.Controls.Add(this.maskedTextBoxDateDebut);
            this.groupBoxProjet.Controls.Add(this.labelMailContact);
            this.groupBoxProjet.Controls.Add(this.labelContact);
            this.groupBoxProjet.Controls.Add(this.labelClient);
            this.groupBoxProjet.Controls.Add(this.labelDateFin);
            this.groupBoxProjet.Controls.Add(this.labelDateDebut);
            this.groupBoxProjet.Controls.Add(this.labelNomProjet);
            this.groupBoxProjet.Controls.Add(this.comboBoxClient);
            this.groupBoxProjet.Controls.Add(this.textBoxContact);
            this.groupBoxProjet.Controls.Add(this.textBoxMailContact);
            this.groupBoxProjet.Controls.Add(this.textBoxNomProjet);
            this.groupBoxProjet.Controls.Add(this.buttonValider);
            this.groupBoxProjet.Location = new System.Drawing.Point(12, 47);
            this.groupBoxProjet.Name = "groupBoxProjet";
            this.groupBoxProjet.Size = new System.Drawing.Size(497, 208);
            this.groupBoxProjet.TabIndex = 0;
            this.groupBoxProjet.TabStop = false;
            this.groupBoxProjet.Text = "Projet";
            // 
            // maskedTextBoxDateFin
            // 
            this.maskedTextBoxDateFin.Location = new System.Drawing.Point(157, 93);
            this.maskedTextBoxDateFin.Mask = "00/00/0000";
            this.maskedTextBoxDateFin.Name = "maskedTextBoxDateFin";
            this.maskedTextBoxDateFin.Size = new System.Drawing.Size(146, 20);
            this.maskedTextBoxDateFin.TabIndex = 2;
            this.maskedTextBoxDateFin.ValidatingType = typeof(System.DateTime);
            this.maskedTextBoxDateFin.Validating += new System.ComponentModel.CancelEventHandler(this.maskedTextBoxDateFin_Validating);
            // 
            // maskedTextBoxDateDebut
            // 
            this.maskedTextBoxDateDebut.Location = new System.Drawing.Point(158, 67);
            this.maskedTextBoxDateDebut.Mask = "00/00/0000";
            this.maskedTextBoxDateDebut.Name = "maskedTextBoxDateDebut";
            this.maskedTextBoxDateDebut.Size = new System.Drawing.Size(146, 20);
            this.maskedTextBoxDateDebut.TabIndex = 1;
            this.maskedTextBoxDateDebut.ValidatingType = typeof(System.DateTime);
            this.maskedTextBoxDateDebut.Validating += new System.ComponentModel.CancelEventHandler(this.maskedTextBoxDateDebut_Validating);
            // 
            // labelMailContact
            // 
            this.labelMailContact.Location = new System.Drawing.Point(64, 174);
            this.labelMailContact.Name = "labelMailContact";
            this.labelMailContact.Size = new System.Drawing.Size(88, 17);
            this.labelMailContact.TabIndex = 15;
            this.labelMailContact.Text = "Mail Contact :";
            this.labelMailContact.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelContact
            // 
            this.labelContact.Location = new System.Drawing.Point(64, 148);
            this.labelContact.Name = "labelContact";
            this.labelContact.Size = new System.Drawing.Size(88, 17);
            this.labelContact.TabIndex = 14;
            this.labelContact.Text = "Contact :";
            this.labelContact.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelClient
            // 
            this.labelClient.Location = new System.Drawing.Point(64, 122);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(88, 17);
            this.labelClient.TabIndex = 13;
            this.labelClient.Text = "Client : ";
            this.labelClient.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelDateFin
            // 
            this.labelDateFin.Location = new System.Drawing.Point(64, 96);
            this.labelDateFin.Name = "labelDateFin";
            this.labelDateFin.Size = new System.Drawing.Size(88, 17);
            this.labelDateFin.TabIndex = 12;
            this.labelDateFin.Text = "Date fin :";
            this.labelDateFin.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelDateDebut
            // 
            this.labelDateDebut.Location = new System.Drawing.Point(64, 70);
            this.labelDateDebut.Name = "labelDateDebut";
            this.labelDateDebut.Size = new System.Drawing.Size(88, 17);
            this.labelDateDebut.TabIndex = 11;
            this.labelDateDebut.Text = "Date debut :";
            this.labelDateDebut.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelNomProjet
            // 
            this.labelNomProjet.Location = new System.Drawing.Point(64, 44);
            this.labelNomProjet.Name = "labelNomProjet";
            this.labelNomProjet.Size = new System.Drawing.Size(88, 17);
            this.labelNomProjet.TabIndex = 10;
            this.labelNomProjet.Text = "Nom projet :";
            this.labelNomProjet.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // comboBoxClient
            // 
            this.comboBoxClient.DataSource = this.clientBindingSource;
            this.comboBoxClient.DisplayMember = "RaisonSociale";
            this.comboBoxClient.FormattingEnabled = true;
            this.comboBoxClient.Location = new System.Drawing.Point(158, 119);
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Size = new System.Drawing.Size(145, 21);
            this.comboBoxClient.TabIndex = 3;
            this.comboBoxClient.ValueMember = "CodeClient";
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataSource = typeof(ProjetAfpaService.Metier.Client);
            // 
            // textBoxContact
            // 
            this.textBoxContact.Location = new System.Drawing.Point(158, 145);
            this.textBoxContact.Name = "textBoxContact";
            this.textBoxContact.Size = new System.Drawing.Size(146, 20);
            this.textBoxContact.TabIndex = 4;
            this.textBoxContact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxContact_KeyPress);
            // 
            // textBoxMailContact
            // 
            this.textBoxMailContact.Location = new System.Drawing.Point(158, 171);
            this.textBoxMailContact.Name = "textBoxMailContact";
            this.textBoxMailContact.Size = new System.Drawing.Size(146, 20);
            this.textBoxMailContact.TabIndex = 5;
            this.textBoxMailContact.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxMailContact_Validating);
            // 
            // textBoxNomProjet
            // 
            this.textBoxNomProjet.Location = new System.Drawing.Point(158, 41);
            this.textBoxNomProjet.Name = "textBoxNomProjet";
            this.textBoxNomProjet.Size = new System.Drawing.Size(146, 20);
            this.textBoxNomProjet.TabIndex = 0;
            this.textBoxNomProjet.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxNomProjet_Validating);
            // 
            // buttonValider
            // 
            this.buttonValider.Location = new System.Drawing.Point(351, 32);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(121, 29);
            this.buttonValider.TabIndex = 3;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // groupBoxForfait
            // 
            this.groupBoxForfait.Controls.Add(this.labelResponsable);
            this.groupBoxForfait.Controls.Add(this.labelMontantContrat);
            this.groupBoxForfait.Controls.Add(this.comboBoxResponsable);
            this.groupBoxForfait.Controls.Add(this.textBoxMontantContrat);
            this.groupBoxForfait.Controls.Add(this.groupBoxPenalites);
            this.groupBoxForfait.Location = new System.Drawing.Point(12, 277);
            this.groupBoxForfait.Name = "groupBoxForfait";
            this.groupBoxForfait.Size = new System.Drawing.Size(497, 200);
            this.groupBoxForfait.TabIndex = 1;
            this.groupBoxForfait.TabStop = false;
            this.groupBoxForfait.Text = "Forfait";
            // 
            // labelResponsable
            // 
            this.labelResponsable.Location = new System.Drawing.Point(64, 49);
            this.labelResponsable.Name = "labelResponsable";
            this.labelResponsable.Size = new System.Drawing.Size(88, 17);
            this.labelResponsable.TabIndex = 12;
            this.labelResponsable.Text = "Responsable :";
            this.labelResponsable.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelMontantContrat
            // 
            this.labelMontantContrat.Location = new System.Drawing.Point(64, 22);
            this.labelMontantContrat.Name = "labelMontantContrat";
            this.labelMontantContrat.Size = new System.Drawing.Size(88, 17);
            this.labelMontantContrat.TabIndex = 11;
            this.labelMontantContrat.Text = "Montant contrat :";
            this.labelMontantContrat.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // comboBoxResponsable
            // 
            this.comboBoxResponsable.DataSource = this.collaborateurBindingSource;
            this.comboBoxResponsable.DisplayMember = "Nom";
            this.comboBoxResponsable.FormattingEnabled = true;
            this.comboBoxResponsable.Location = new System.Drawing.Point(159, 45);
            this.comboBoxResponsable.Name = "comboBoxResponsable";
            this.comboBoxResponsable.Size = new System.Drawing.Size(145, 21);
            this.comboBoxResponsable.TabIndex = 7;
            // 
            // collaborateurBindingSource
            // 
            this.collaborateurBindingSource.DataSource = typeof(ProjetAfpaService.Metier.Collaborateur);
            // 
            // textBoxMontantContrat
            // 
            this.textBoxMontantContrat.Location = new System.Drawing.Point(158, 19);
            this.textBoxMontantContrat.Name = "textBoxMontantContrat";
            this.textBoxMontantContrat.Size = new System.Drawing.Size(146, 20);
            this.textBoxMontantContrat.TabIndex = 6;
            this.textBoxMontantContrat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMontantContrat_KeyPress);
            this.textBoxMontantContrat.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxMontantContrat_Validating);
            // 
            // groupBoxPenalites
            // 
            this.groupBoxPenalites.Controls.Add(this.radioButtonOui);
            this.groupBoxPenalites.Controls.Add(this.radioButtonNon);
            this.groupBoxPenalites.Location = new System.Drawing.Point(121, 105);
            this.groupBoxPenalites.Name = "groupBoxPenalites";
            this.groupBoxPenalites.Size = new System.Drawing.Size(183, 76);
            this.groupBoxPenalites.TabIndex = 11;
            this.groupBoxPenalites.TabStop = false;
            this.groupBoxPenalites.Text = "Penalites";
            // 
            // radioButtonOui
            // 
            this.radioButtonOui.AutoSize = true;
            this.radioButtonOui.Location = new System.Drawing.Point(115, 31);
            this.radioButtonOui.Name = "radioButtonOui";
            this.radioButtonOui.Size = new System.Drawing.Size(41, 17);
            this.radioButtonOui.TabIndex = 9;
            this.radioButtonOui.TabStop = true;
            this.radioButtonOui.Text = "Oui";
            this.radioButtonOui.UseVisualStyleBackColor = true;
            // 
            // radioButtonNon
            // 
            this.radioButtonNon.AutoSize = true;
            this.radioButtonNon.Location = new System.Drawing.Point(26, 31);
            this.radioButtonNon.Name = "radioButtonNon";
            this.radioButtonNon.Size = new System.Drawing.Size(45, 17);
            this.radioButtonNon.TabIndex = 8;
            this.radioButtonNon.TabStop = true;
            this.radioButtonNon.Text = "Non";
            this.radioButtonNon.UseVisualStyleBackColor = true;
            // 
            // buttonQuitter
            // 
            this.buttonQuitter.Location = new System.Drawing.Point(363, 12);
            this.buttonQuitter.Name = "buttonQuitter";
            this.buttonQuitter.Size = new System.Drawing.Size(121, 29);
            this.buttonQuitter.TabIndex = 2;
            this.buttonQuitter.Text = "Quitter";
            this.buttonQuitter.UseVisualStyleBackColor = true;
            this.buttonQuitter.Click += new System.EventHandler(this.buttonQuitter_Click);
            // 
            // errorProviderNomProjet
            // 
            this.errorProviderNomProjet.ContainerControl = this;
            // 
            // errorProviderDateFin
            // 
            this.errorProviderDateFin.ContainerControl = this;
            // 
            // errorProviderDateDebut
            // 
            this.errorProviderDateDebut.ContainerControl = this;
            // 
            // errorProviderMailAdress
            // 
            this.errorProviderMailAdress.ContainerControl = this;
            // 
            // errorProviderMontant
            // 
            this.errorProviderMontant.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 489);
            this.ControlBox = false;
            this.Controls.Add(this.buttonQuitter);
            this.Controls.Add(this.groupBoxForfait);
            this.Controls.Add(this.groupBoxProjet);
            this.Name = "Form1";
            this.Text = "Création d\'un projet au forfait";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxProjet.ResumeLayout(false);
            this.groupBoxProjet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.groupBoxForfait.ResumeLayout(false);
            this.groupBoxForfait.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.collaborateurBindingSource)).EndInit();
            this.groupBoxPenalites.ResumeLayout(false);
            this.groupBoxPenalites.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNomProjet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDateFin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDateDebut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMailAdress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMontant)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxProjet;
        private System.Windows.Forms.Label labelMailContact;
        private System.Windows.Forms.Label labelContact;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.Label labelDateFin;
        private System.Windows.Forms.Label labelDateDebut;
        private System.Windows.Forms.Label labelNomProjet;
        private System.Windows.Forms.ComboBox comboBoxClient;
        private System.Windows.Forms.TextBox textBoxContact;
        private System.Windows.Forms.TextBox textBoxMailContact;
        private System.Windows.Forms.TextBox textBoxNomProjet;
        private System.Windows.Forms.Button buttonValider;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBoxForfait;
        private System.Windows.Forms.Label labelResponsable;
        private System.Windows.Forms.Label labelMontantContrat;
        private System.Windows.Forms.ComboBox comboBoxResponsable;
        private System.Windows.Forms.TextBox textBoxMontantContrat;
        private System.Windows.Forms.GroupBox groupBoxPenalites;
        private System.Windows.Forms.RadioButton radioButtonOui;
        private System.Windows.Forms.RadioButton radioButtonNon;
        private System.Windows.Forms.Button buttonQuitter;
        private System.Windows.Forms.ErrorProvider errorProviderNomProjet;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDateFin;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDateDebut;
        private System.Windows.Forms.ErrorProvider errorProviderDateFin;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private System.Windows.Forms.BindingSource collaborateurBindingSource;
        private System.Windows.Forms.ErrorProvider errorProviderDateDebut;
        private System.Windows.Forms.ErrorProvider errorProviderMailAdress;
        private System.Windows.Forms.ErrorProvider errorProviderMontant;
    }
}

