
namespace DesignWinMedecins
{
    partial class EncodagePresence
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
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.MaisonMed = new System.Windows.Forms.ComboBox();
            this.Heure_Arrivee = new System.Windows.Forms.ComboBox();
            this.Heure_Depart = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.jour = new System.Windows.Forms.Label();
            this.AnneeTextBox = new System.Windows.Forms.TextBox();
            this.MoisTextBox = new System.Windows.Forms.TextBox();
            this.JourTextBox = new System.Windows.Forms.TextBox();
            this.btValider = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.nbJours = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.checkNbJours = new System.Windows.Forms.CheckBox();
            this.dataGridViewPresences = new System.Windows.Forms.DataGridView();
            this.ValidationPresence = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPresences)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "MAISON MEDICALE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(244, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "DATE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(174, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "HEURE D\'ARRIVEE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(169, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "HEURE DE DÉPART";
            // 
            // MaisonMed
            // 
            this.MaisonMed.FormattingEnabled = true;
            this.MaisonMed.Location = new System.Drawing.Point(305, 100);
            this.MaisonMed.Name = "MaisonMed";
            this.MaisonMed.Size = new System.Drawing.Size(121, 21);
            this.MaisonMed.TabIndex = 6;
            // 
            // Heure_Arrivee
            // 
            this.Heure_Arrivee.FormattingEnabled = true;
            this.Heure_Arrivee.Items.AddRange(new object[] {
            "",
            "08:00",
            "08:15",
            "08:30",
            "08:45",
            "09:00",
            "09:15",
            "09:30",
            "09:45",
            "10:00",
            "10:15",
            "10:30",
            "10:45",
            "11:00",
            "11:15",
            "11:30",
            "11:45",
            "12:00",
            "12:15",
            "12:30",
            "12:45",
            "13:00",
            "13:15",
            "13:30",
            "13:45",
            "14:00",
            "14:15",
            "14:30",
            "14:45",
            "15:00",
            "15:15",
            "15:30",
            "15:45"});
            this.Heure_Arrivee.Location = new System.Drawing.Point(305, 207);
            this.Heure_Arrivee.Name = "Heure_Arrivee";
            this.Heure_Arrivee.Size = new System.Drawing.Size(121, 21);
            this.Heure_Arrivee.TabIndex = 10;
            // 
            // Heure_Depart
            // 
            this.Heure_Depart.FormattingEnabled = true;
            this.Heure_Depart.Items.AddRange(new object[] {
            "",
            "08:15",
            "08:30",
            "08:45",
            "09:00",
            "09:15",
            "09:30",
            "09:45",
            "10:00",
            "10:15",
            "10:30",
            "10:45",
            "11:00",
            "11:15",
            "11:30",
            "11:45",
            "12:00",
            "12:15",
            "12:30",
            "12:45",
            "13:00",
            "13:15",
            "13:30",
            "13:45",
            "14:00",
            "14:15",
            "14:30",
            "14:45",
            "15:00",
            "15:15",
            "15:30",
            "15:45",
            "16:00"});
            this.Heure_Depart.Location = new System.Drawing.Point(305, 257);
            this.Heure_Depart.Name = "Heure_Depart";
            this.Heure_Depart.Size = new System.Drawing.Size(121, 21);
            this.Heure_Depart.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(470, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Année";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(394, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Mois";
            // 
            // jour
            // 
            this.jour.AutoSize = true;
            this.jour.Location = new System.Drawing.Point(311, 142);
            this.jour.Name = "jour";
            this.jour.Size = new System.Drawing.Size(27, 13);
            this.jour.TabIndex = 25;
            this.jour.Text = "Jour";
            // 
            // AnneeTextBox
            // 
            this.AnneeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AnneeTextBox.Location = new System.Drawing.Point(473, 158);
            this.AnneeTextBox.Name = "AnneeTextBox";
            this.AnneeTextBox.Size = new System.Drawing.Size(99, 26);
            this.AnneeTextBox.TabIndex = 24;
            // 
            // MoisTextBox
            // 
            this.MoisTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.MoisTextBox.Location = new System.Drawing.Point(387, 158);
            this.MoisTextBox.Name = "MoisTextBox";
            this.MoisTextBox.Size = new System.Drawing.Size(45, 26);
            this.MoisTextBox.TabIndex = 23;
            // 
            // JourTextBox
            // 
            this.JourTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.JourTextBox.Location = new System.Drawing.Point(303, 158);
            this.JourTextBox.Name = "JourTextBox";
            this.JourTextBox.Size = new System.Drawing.Size(45, 26);
            this.JourTextBox.TabIndex = 22;
            // 
            // btValider
            // 
            this.btValider.Location = new System.Drawing.Point(302, 312);
            this.btValider.Name = "btValider";
            this.btValider.Size = new System.Drawing.Size(139, 51);
            this.btValider.TabIndex = 28;
            this.btValider.Text = "VALIDER";
            this.btValider.UseVisualStyleBackColor = true;
            this.btValider.Click += new System.EventHandler(this.btValider_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(490, 196);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Encoder également les";
            // 
            // nbJours
            // 
            this.nbJours.Location = new System.Drawing.Point(611, 193);
            this.nbJours.Name = "nbJours";
            this.nbJours.Size = new System.Drawing.Size(31, 20);
            this.nbJours.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(648, 196);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "prochains jours";
            // 
            // checkNbJours
            // 
            this.checkNbJours.AutoSize = true;
            this.checkNbJours.Location = new System.Drawing.Point(743, 196);
            this.checkNbJours.Name = "checkNbJours";
            this.checkNbJours.Size = new System.Drawing.Size(15, 14);
            this.checkNbJours.TabIndex = 33;
            this.checkNbJours.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPresences
            // 
            this.dataGridViewPresences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPresences.Location = new System.Drawing.Point(46, 463);
            this.dataGridViewPresences.Name = "dataGridViewPresences";
            this.dataGridViewPresences.Size = new System.Drawing.Size(698, 356);
            this.dataGridViewPresences.TabIndex = 34;
            // 
            // ValidationPresence
            // 
            this.ValidationPresence.AutoSize = true;
            this.ValidationPresence.BackColor = System.Drawing.Color.Transparent;
            this.ValidationPresence.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValidationPresence.ForeColor = System.Drawing.Color.LimeGreen;
            this.ValidationPresence.Location = new System.Drawing.Point(58, 406);
            this.ValidationPresence.Name = "ValidationPresence";
            this.ValidationPresence.Size = new System.Drawing.Size(0, 16);
            this.ValidationPresence.TabIndex = 49;
            // 
            // EncodagePresence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.Controls.Add(this.ValidationPresence);
            this.Controls.Add(this.dataGridViewPresences);
            this.Controls.Add(this.checkNbJours);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.nbJours);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btValider);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.jour);
            this.Controls.Add(this.AnneeTextBox);
            this.Controls.Add(this.MoisTextBox);
            this.Controls.Add(this.JourTextBox);
            this.Controls.Add(this.Heure_Depart);
            this.Controls.Add(this.Heure_Arrivee);
            this.Controls.Add(this.MaisonMed);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "EncodagePresence";
            this.Size = new System.Drawing.Size(800, 851);
            this.Load += new System.EventHandler(this.EncodagePresence_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPresences)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox MaisonMed;
        private System.Windows.Forms.ComboBox Heure_Arrivee;
        private System.Windows.Forms.ComboBox Heure_Depart;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label jour;
        private System.Windows.Forms.TextBox AnneeTextBox;
        private System.Windows.Forms.TextBox MoisTextBox;
        private System.Windows.Forms.TextBox JourTextBox;
        private System.Windows.Forms.Button btValider;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox nbJours;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox checkNbJours;
        private System.Windows.Forms.DataGridView dataGridViewPresences;
        private System.Windows.Forms.Label ValidationPresence;
    }
}