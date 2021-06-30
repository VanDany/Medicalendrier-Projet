
namespace DesignWinMedecins
{
    partial class MenuMedecin
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
            this.button1 = new System.Windows.Forms.Button();
            this.btPlanning = new System.Windows.Forms.Button();
            this.AccueilMedecin = new System.Windows.Forms.Label();
            this.btAnnulerAssociation = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btAssociation = new System.Windows.Forms.Button();
            this.btEncoderPresences = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(289, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(347, 74);
            this.button1.TabIndex = 13;
            this.button1.Text = "Confirmer mes rendez-vous";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btPlanning
            // 
            this.btPlanning.Location = new System.Drawing.Point(67, 369);
            this.btPlanning.Name = "btPlanning";
            this.btPlanning.Size = new System.Drawing.Size(159, 74);
            this.btPlanning.TabIndex = 12;
            this.btPlanning.Text = "Voir mon planning par jour";
            this.btPlanning.UseVisualStyleBackColor = true;
            // 
            // AccueilMedecin
            // 
            this.AccueilMedecin.AutoSize = true;
            this.AccueilMedecin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccueilMedecin.Location = new System.Drawing.Point(24, 56);
            this.AccueilMedecin.Name = "AccueilMedecin";
            this.AccueilMedecin.Size = new System.Drawing.Size(86, 25);
            this.AccueilMedecin.TabIndex = 11;
            this.AccueilMedecin.Text = "Bonjour";
            // 
            // btAnnulerAssociation
            // 
            this.btAnnulerAssociation.Location = new System.Drawing.Point(289, 248);
            this.btAnnulerAssociation.Name = "btAnnulerAssociation";
            this.btAnnulerAssociation.Size = new System.Drawing.Size(347, 85);
            this.btAnnulerAssociation.TabIndex = 10;
            this.btAnnulerAssociation.Text = "Annuler une association spécialité - durée consult - maison médicale";
            this.btAnnulerAssociation.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(66, 248);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(159, 85);
            this.button3.TabIndex = 9;
            this.button3.Text = "Voir mes présences (TODO)";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btAssociation
            // 
            this.btAssociation.Location = new System.Drawing.Point(289, 118);
            this.btAssociation.Name = "btAssociation";
            this.btAssociation.Size = new System.Drawing.Size(347, 85);
            this.btAssociation.TabIndex = 8;
            this.btAssociation.Text = "Associer spécialité - durée consult - maison médicale";
            this.btAssociation.UseVisualStyleBackColor = true;
            // 
            // btEncoderPresences
            // 
            this.btEncoderPresences.Location = new System.Drawing.Point(66, 118);
            this.btEncoderPresences.Name = "btEncoderPresences";
            this.btEncoderPresences.Size = new System.Drawing.Size(159, 85);
            this.btEncoderPresences.TabIndex = 7;
            this.btEncoderPresences.Text = "Encoder mes présences";
            this.btEncoderPresences.UseVisualStyleBackColor = true;
            // 
            // MenuMedecin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btPlanning);
            this.Controls.Add(this.AccueilMedecin);
            this.Controls.Add(this.btAnnulerAssociation);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btAssociation);
            this.Controls.Add(this.btEncoderPresences);
            this.Name = "MenuMedecin";
            this.Size = new System.Drawing.Size(668, 552);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btPlanning;
        private System.Windows.Forms.Label AccueilMedecin;
        private System.Windows.Forms.Button btAnnulerAssociation;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btAssociation;
        private System.Windows.Forms.Button btEncoderPresences;
    }
}
