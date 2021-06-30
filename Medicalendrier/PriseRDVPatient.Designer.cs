
namespace DesignWinPatients
{
    partial class PriseRDVPatient
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btValiderRDV = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxHoraires = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxMedecins = new System.Windows.Forms.ComboBox();
            this.dataGridViewDisponibilites = new System.Windows.Forms.DataGridView();
            this.btValider = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.jour = new System.Windows.Forms.Label();
            this.AnneeTextBox = new System.Windows.Forms.TextBox();
            this.MoisTextBox = new System.Windows.Forms.TextBox();
            this.JourTextBox = new System.Windows.Forms.TextBox();
            this.Specialite = new System.Windows.Forms.ComboBox();
            this.MaisonMed = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ValidationPriseRDV = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisponibilites)).BeginInit();
            this.SuspendLayout();
            // 
            // btValiderRDV
            // 
            this.btValiderRDV.Location = new System.Drawing.Point(314, 408);
            this.btValiderRDV.Name = "btValiderRDV";
            this.btValiderRDV.Size = new System.Drawing.Size(138, 57);
            this.btValiderRDV.TabIndex = 46;
            this.btValiderRDV.Text = "VALIDER";
            this.btValiderRDV.UseVisualStyleBackColor = true;
            this.btValiderRDV.Click += new System.EventHandler(this.btValiderRDV_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(152, 372);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 13);
            this.label7.TabIndex = 45;
            this.label7.Text = "HORAIRES DISPONIBLES";
            // 
            // comboBoxHoraires
            // 
            this.comboBoxHoraires.FormattingEnabled = true;
            this.comboBoxHoraires.Location = new System.Drawing.Point(323, 369);
            this.comboBoxHoraires.Name = "comboBoxHoraires";
            this.comboBoxHoraires.Size = new System.Drawing.Size(141, 21);
            this.comboBoxHoraires.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(152, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "MÉDECINS DISPONIBLES";
            // 
            // comboBoxMedecins
            // 
            this.comboBoxMedecins.FormattingEnabled = true;
            this.comboBoxMedecins.Location = new System.Drawing.Point(323, 321);
            this.comboBoxMedecins.Name = "comboBoxMedecins";
            this.comboBoxMedecins.Size = new System.Drawing.Size(141, 21);
            this.comboBoxMedecins.TabIndex = 42;
            this.comboBoxMedecins.SelectedIndexChanged += new System.EventHandler(this.comboBoxMedecins_SelectedIndexChanged);
            // 
            // dataGridViewDisponibilites
            // 
            this.dataGridViewDisponibilites.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDisponibilites.Location = new System.Drawing.Point(18, 511);
            this.dataGridViewDisponibilites.Name = "dataGridViewDisponibilites";
            this.dataGridViewDisponibilites.Size = new System.Drawing.Size(745, 73);
            this.dataGridViewDisponibilites.TabIndex = 41;
            // 
            // btValider
            // 
            this.btValider.Location = new System.Drawing.Point(314, 240);
            this.btValider.Name = "btValider";
            this.btValider.Size = new System.Drawing.Size(138, 59);
            this.btValider.TabIndex = 40;
            this.btValider.Text = "VALIDER";
            this.btValider.UseVisualStyleBackColor = true;
            this.btValider.Click += new System.EventHandler(this.btValider_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(470, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Année";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(394, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Mois";
            // 
            // jour
            // 
            this.jour.AutoSize = true;
            this.jour.Location = new System.Drawing.Point(311, 82);
            this.jour.Name = "jour";
            this.jour.Size = new System.Drawing.Size(27, 13);
            this.jour.TabIndex = 37;
            this.jour.Text = "Jour";
            // 
            // AnneeTextBox
            // 
            this.AnneeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnneeTextBox.Location = new System.Drawing.Point(473, 98);
            this.AnneeTextBox.Name = "AnneeTextBox";
            this.AnneeTextBox.Size = new System.Drawing.Size(110, 44);
            this.AnneeTextBox.TabIndex = 36;
            // 
            // MoisTextBox
            // 
            this.MoisTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoisTextBox.Location = new System.Drawing.Point(387, 98);
            this.MoisTextBox.Name = "MoisTextBox";
            this.MoisTextBox.Size = new System.Drawing.Size(51, 44);
            this.MoisTextBox.TabIndex = 35;
            // 
            // JourTextBox
            // 
            this.JourTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JourTextBox.Location = new System.Drawing.Point(303, 98);
            this.JourTextBox.Name = "JourTextBox";
            this.JourTextBox.Size = new System.Drawing.Size(51, 44);
            this.JourTextBox.TabIndex = 34;
            // 
            // Specialite
            // 
            this.Specialite.FormattingEnabled = true;
            this.Specialite.Location = new System.Drawing.Point(314, 177);
            this.Specialite.Name = "Specialite";
            this.Specialite.Size = new System.Drawing.Size(163, 21);
            this.Specialite.TabIndex = 33;
            // 
            // MaisonMed
            // 
            this.MaisonMed.FormattingEnabled = true;
            this.MaisonMed.Location = new System.Drawing.Point(314, 35);
            this.MaisonMed.Name = "MaisonMed";
            this.MaisonMed.Size = new System.Drawing.Size(163, 21);
            this.MaisonMed.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "SPECIALITÉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "JOUR DU RDV SOUHAITÉ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "MAISON MEDICALE";
            // 
            // ValidationPriseRDV
            // 
            this.ValidationPriseRDV.AutoSize = true;
            this.ValidationPriseRDV.BackColor = System.Drawing.Color.Transparent;
            this.ValidationPriseRDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValidationPriseRDV.ForeColor = System.Drawing.Color.LimeGreen;
            this.ValidationPriseRDV.Location = new System.Drawing.Point(15, 473);
            this.ValidationPriseRDV.Name = "ValidationPriseRDV";
            this.ValidationPriseRDV.Size = new System.Drawing.Size(0, 16);
            this.ValidationPriseRDV.TabIndex = 47;
            // 
            // PriseRDVPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.Controls.Add(this.ValidationPriseRDV);
            this.Controls.Add(this.btValiderRDV);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxHoraires);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxMedecins);
            this.Controls.Add(this.dataGridViewDisponibilites);
            this.Controls.Add(this.btValider);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.jour);
            this.Controls.Add(this.AnneeTextBox);
            this.Controls.Add(this.MoisTextBox);
            this.Controls.Add(this.JourTextBox);
            this.Controls.Add(this.Specialite);
            this.Controls.Add(this.MaisonMed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PriseRDVPatient";
            this.Size = new System.Drawing.Size(780, 600);
            this.Load += new System.EventHandler(this.PriseRDVPatient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisponibilites)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btValiderRDV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxHoraires;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxMedecins;
        private System.Windows.Forms.DataGridView dataGridViewDisponibilites;
        private System.Windows.Forms.Button btValider;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label jour;
        private System.Windows.Forms.TextBox AnneeTextBox;
        private System.Windows.Forms.TextBox MoisTextBox;
        private System.Windows.Forms.TextBox JourTextBox;
        private System.Windows.Forms.ComboBox Specialite;
        private System.Windows.Forms.ComboBox MaisonMed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ValidationPriseRDV;
    }
}
