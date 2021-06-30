
namespace DesignWinMedecins
{
    partial class AssociationMedConsult
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
            this.ComboBoxSpecialite = new System.Windows.Forms.ComboBox();
            this.ComboBoxMaisonMed = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ComboBoxDureeConsult = new System.Windows.Forms.ComboBox();
            this.btAssociation = new System.Windows.Forms.Button();
            this.ValidationAssociation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ComboBoxSpecialite
            // 
            this.ComboBoxSpecialite.FormattingEnabled = true;
            this.ComboBoxSpecialite.Location = new System.Drawing.Point(422, 201);
            this.ComboBoxSpecialite.Name = "ComboBoxSpecialite";
            this.ComboBoxSpecialite.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxSpecialite.TabIndex = 11;
            // 
            // ComboBoxMaisonMed
            // 
            this.ComboBoxMaisonMed.FormattingEnabled = true;
            this.ComboBoxMaisonMed.Location = new System.Drawing.Point(422, 143);
            this.ComboBoxMaisonMed.Name = "ComboBoxMaisonMed";
            this.ComboBoxMaisonMed.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxMaisonMed.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(329, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "SPECIALITE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(291, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "MAISON MEDICALE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "DUREE CONSULTATION";
            // 
            // ComboBoxDureeConsult
            // 
            this.ComboBoxDureeConsult.FormattingEnabled = true;
            this.ComboBoxDureeConsult.Items.AddRange(new object[] {
            "15",
            "30",
            "45",
            "60",
            "75",
            "90",
            "105",
            "120"});
            this.ComboBoxDureeConsult.Location = new System.Drawing.Point(422, 256);
            this.ComboBoxDureeConsult.Name = "ComboBoxDureeConsult";
            this.ComboBoxDureeConsult.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxDureeConsult.TabIndex = 13;
            // 
            // btAssociation
            // 
            this.btAssociation.Location = new System.Drawing.Point(319, 299);
            this.btAssociation.Name = "btAssociation";
            this.btAssociation.Size = new System.Drawing.Size(168, 47);
            this.btAssociation.TabIndex = 15;
            this.btAssociation.Text = "Ajouter association";
            this.btAssociation.UseVisualStyleBackColor = true;
            this.btAssociation.Click += new System.EventHandler(this.btAssociation_Click);
            // 
            // ValidationAssociation
            // 
            this.ValidationAssociation.AutoSize = true;
            this.ValidationAssociation.BackColor = System.Drawing.Color.Transparent;
            this.ValidationAssociation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValidationAssociation.ForeColor = System.Drawing.Color.LimeGreen;
            this.ValidationAssociation.Location = new System.Drawing.Point(102, 380);
            this.ValidationAssociation.Name = "ValidationAssociation";
            this.ValidationAssociation.Size = new System.Drawing.Size(0, 16);
            this.ValidationAssociation.TabIndex = 48;
            // 
            // AssociationMedConsult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.Controls.Add(this.ValidationAssociation);
            this.Controls.Add(this.btAssociation);
            this.Controls.Add(this.ComboBoxDureeConsult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ComboBoxSpecialite);
            this.Controls.Add(this.ComboBoxMaisonMed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AssociationMedConsult";
            this.Size = new System.Drawing.Size(800, 532);
            this.Load += new System.EventHandler(this.AssociationMedConsult_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboBoxSpecialite;
        private System.Windows.Forms.ComboBox ComboBoxMaisonMed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ComboBoxDureeConsult;
        private System.Windows.Forms.Button btAssociation;
        private System.Windows.Forms.Label ValidationAssociation;
    }
}