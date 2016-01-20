namespace ProjetAfpaService.Vues
{
    partial class FrmPrevisions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridViewPrevisions = new System.Windows.Forms.DataGridView();
            this.laQualifDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.qualificationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nbJoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modifier = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Supprimer = new System.Windows.Forms.DataGridViewButtonColumn();
            this.previsionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxProjet = new System.Windows.Forms.ComboBox();
            this.projetForfaitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelProjet = new System.Windows.Forms.Label();
            this.buttonCreer = new System.Windows.Forms.Button();
            this.groupBoxPrevision = new System.Windows.Forms.GroupBox();
            this.numericUpDownNbJours = new System.Windows.Forms.NumericUpDown();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.buttonValider = new System.Windows.Forms.Button();
            this.comboBoxQualification = new System.Windows.Forms.ComboBox();
            this.buttonQuitter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrevisions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qualificationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.previsionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetForfaitBindingSource)).BeginInit();
            this.groupBoxPrevision.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNbJours)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPrevisions
            // 
            this.dataGridViewPrevisions.AllowUserToAddRows = false;
            this.dataGridViewPrevisions.AllowUserToDeleteRows = false;
            this.dataGridViewPrevisions.AutoGenerateColumns = false;
            this.dataGridViewPrevisions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPrevisions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.laQualifDataGridViewTextBoxColumn,
            this.nbJoursDataGridViewTextBoxColumn,
            this.Modifier,
            this.Supprimer});
            this.dataGridViewPrevisions.DataSource = this.previsionBindingSource;
            this.dataGridViewPrevisions.Location = new System.Drawing.Point(29, 93);
            this.dataGridViewPrevisions.Name = "dataGridViewPrevisions";
            this.dataGridViewPrevisions.ReadOnly = true;
            this.dataGridViewPrevisions.Size = new System.Drawing.Size(611, 142);
            this.dataGridViewPrevisions.TabIndex = 0;
            this.dataGridViewPrevisions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPrevisions_CellContentClick);
            // 
            // laQualifDataGridViewTextBoxColumn
            // 
            this.laQualifDataGridViewTextBoxColumn.DataPropertyName = "LaQualif";
            this.laQualifDataGridViewTextBoxColumn.DataSource = this.qualificationBindingSource;
            this.laQualifDataGridViewTextBoxColumn.DisplayMember = "Libelle";
            this.laQualifDataGridViewTextBoxColumn.HeaderText = "LaQualif";
            this.laQualifDataGridViewTextBoxColumn.Name = "laQualifDataGridViewTextBoxColumn";
            this.laQualifDataGridViewTextBoxColumn.ReadOnly = true;
            this.laQualifDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.laQualifDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.laQualifDataGridViewTextBoxColumn.ValueMember = "Self";
            // 
            // qualificationBindingSource
            // 
            this.qualificationBindingSource.DataSource = typeof(ProjetAfpaService.Metier.Qualification);
            // 
            // nbJoursDataGridViewTextBoxColumn
            // 
            this.nbJoursDataGridViewTextBoxColumn.DataPropertyName = "NbJours";
            this.nbJoursDataGridViewTextBoxColumn.HeaderText = "NbJours";
            this.nbJoursDataGridViewTextBoxColumn.Name = "nbJoursDataGridViewTextBoxColumn";
            this.nbJoursDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Modifier
            // 
            this.Modifier.HeaderText = "";
            this.Modifier.Name = "Modifier";
            this.Modifier.ReadOnly = true;
            this.Modifier.Text = "Modifier";
            this.Modifier.UseColumnTextForButtonValue = true;
            // 
            // Supprimer
            // 
            this.Supprimer.HeaderText = "";
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.ReadOnly = true;
            this.Supprimer.Text = "Supprimer";
            this.Supprimer.UseColumnTextForButtonValue = true;
            // 
            // previsionBindingSource
            // 
            this.previsionBindingSource.DataSource = typeof(ProjetAfpaService.Metier.Prevision);
            // 
            // comboBoxProjet
            // 
            this.comboBoxProjet.DataSource = this.projetForfaitBindingSource;
            this.comboBoxProjet.DisplayMember = "NomProjet";
            this.comboBoxProjet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProjet.FormattingEnabled = true;
            this.comboBoxProjet.Location = new System.Drawing.Point(81, 24);
            this.comboBoxProjet.Name = "comboBoxProjet";
            this.comboBoxProjet.Size = new System.Drawing.Size(117, 21);
            this.comboBoxProjet.TabIndex = 0;
            this.comboBoxProjet.SelectedIndexChanged += new System.EventHandler(this.comboBoxProjet_SelectedIndexChanged);
            // 
            // projetForfaitBindingSource
            // 
            this.projetForfaitBindingSource.DataSource = typeof(ProjetAfpaService.Metier.ProjetForfait);
            // 
            // labelProjet
            // 
            this.labelProjet.Location = new System.Drawing.Point(26, 27);
            this.labelProjet.Name = "labelProjet";
            this.labelProjet.Size = new System.Drawing.Size(49, 21);
            this.labelProjet.TabIndex = 1;
            this.labelProjet.Text = "Projet :";
            this.labelProjet.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // buttonCreer
            // 
            this.buttonCreer.Enabled = false;
            this.buttonCreer.Location = new System.Drawing.Point(29, 256);
            this.buttonCreer.Name = "buttonCreer";
            this.buttonCreer.Size = new System.Drawing.Size(99, 27);
            this.buttonCreer.TabIndex = 2;
            this.buttonCreer.Text = "Creer";
            this.buttonCreer.UseVisualStyleBackColor = true;
            this.buttonCreer.Click += new System.EventHandler(this.buttonCreer_Click);
            // 
            // groupBoxPrevision
            // 
            this.groupBoxPrevision.Controls.Add(this.numericUpDownNbJours);
            this.groupBoxPrevision.Controls.Add(this.buttonAnnuler);
            this.groupBoxPrevision.Controls.Add(this.buttonValider);
            this.groupBoxPrevision.Controls.Add(this.comboBoxQualification);
            this.groupBoxPrevision.Location = new System.Drawing.Point(29, 301);
            this.groupBoxPrevision.Name = "groupBoxPrevision";
            this.groupBoxPrevision.Size = new System.Drawing.Size(318, 114);
            this.groupBoxPrevision.TabIndex = 3;
            this.groupBoxPrevision.TabStop = false;
            this.groupBoxPrevision.Text = "Prévision";
            // 
            // numericUpDownNbJours
            // 
            this.numericUpDownNbJours.Location = new System.Drawing.Point(179, 20);
            this.numericUpDownNbJours.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownNbJours.Name = "numericUpDownNbJours";
            this.numericUpDownNbJours.Size = new System.Drawing.Size(116, 20);
            this.numericUpDownNbJours.TabIndex = 5;
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Location = new System.Drawing.Point(209, 62);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(86, 27);
            this.buttonAnnuler.TabIndex = 4;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // buttonValider
            // 
            this.buttonValider.Location = new System.Drawing.Point(117, 62);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(86, 27);
            this.buttonValider.TabIndex = 3;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // comboBoxQualification
            // 
            this.comboBoxQualification.AutoCompleteCustomSource.AddRange(new string[] {
            "Choisir"});
            this.comboBoxQualification.DataSource = this.qualificationBindingSource;
            this.comboBoxQualification.DisplayMember = "Libelle";
            this.comboBoxQualification.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxQualification.FormattingEnabled = true;
            this.comboBoxQualification.Location = new System.Drawing.Point(23, 19);
            this.comboBoxQualification.Name = "comboBoxQualification";
            this.comboBoxQualification.Size = new System.Drawing.Size(117, 21);
            this.comboBoxQualification.TabIndex = 1;
            // 
            // buttonQuitter
            // 
            this.buttonQuitter.Location = new System.Drawing.Point(541, 21);
            this.buttonQuitter.Name = "buttonQuitter";
            this.buttonQuitter.Size = new System.Drawing.Size(99, 27);
            this.buttonQuitter.TabIndex = 4;
            this.buttonQuitter.Text = "Quitter";
            this.buttonQuitter.UseVisualStyleBackColor = true;
            this.buttonQuitter.Click += new System.EventHandler(this.buttonQuitter_Click);
            // 
            // FrmPrevisions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 495);
            this.ControlBox = false;
            this.Controls.Add(this.buttonQuitter);
            this.Controls.Add(this.groupBoxPrevision);
            this.Controls.Add(this.buttonCreer);
            this.Controls.Add(this.labelProjet);
            this.Controls.Add(this.comboBoxProjet);
            this.Controls.Add(this.dataGridViewPrevisions);
            this.Name = "FrmPrevisions";
            this.Text = "Prevision";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Prevision_FormClosing);
            this.Load += new System.EventHandler(this.Prevision_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrevisions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qualificationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.previsionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetForfaitBindingSource)).EndInit();
            this.groupBoxPrevision.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNbJours)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource previsionBindingSource;
        private System.Windows.Forms.DataGridView dataGridViewPrevisions;
        private System.Windows.Forms.BindingSource qualificationBindingSource;
        private System.Windows.Forms.ComboBox comboBoxProjet;
        private System.Windows.Forms.Label labelProjet;
        private System.Windows.Forms.Button buttonCreer;
        private System.Windows.Forms.GroupBox groupBoxPrevision;
        private System.Windows.Forms.ComboBox comboBoxQualification;
        private System.Windows.Forms.NumericUpDown numericUpDownNbJours;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.BindingSource projetForfaitBindingSource;
        private System.Windows.Forms.Button buttonQuitter;
        private System.Windows.Forms.DataGridViewComboBoxColumn laQualifDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbJoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Modifier;
        private System.Windows.Forms.DataGridViewButtonColumn Supprimer;
    }
}