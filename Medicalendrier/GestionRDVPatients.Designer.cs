
namespace DesignWinPatients
{
    partial class GestionRDVPatients
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
            this.btDeplacerRDV = new System.Windows.Forms.Button();
            this.btDeleteRDV = new System.Windows.Forms.Button();
            this.textBoxIdentifiant = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewGestionRDV = new System.Windows.Forms.DataGridView();
            this.btValider = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.ValidationGestionRDV = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGestionRDV)).BeginInit();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btDeplacerRDV
            // 
            this.btDeplacerRDV.Location = new System.Drawing.Point(127, 375);
            this.btDeplacerRDV.Name = "btDeplacerRDV";
            this.btDeplacerRDV.Size = new System.Drawing.Size(150, 66);
            this.btDeplacerRDV.TabIndex = 34;
            this.btDeplacerRDV.Text = "Déplacer le rendez-vous";
            this.btDeplacerRDV.UseVisualStyleBackColor = true;
            this.btDeplacerRDV.Click += new System.EventHandler(this.btDeplacerRDV_Click);
            // 
            // btDeleteRDV
            // 
            this.btDeleteRDV.Location = new System.Drawing.Point(367, 375);
            this.btDeleteRDV.Name = "btDeleteRDV";
            this.btDeleteRDV.Size = new System.Drawing.Size(152, 66);
            this.btDeleteRDV.TabIndex = 33;
            this.btDeleteRDV.Text = "Supprimer le rendez-vous";
            this.btDeleteRDV.UseVisualStyleBackColor = true;
            this.btDeleteRDV.Click += new System.EventHandler(this.btDeleteRDV_Click);
            // 
            // textBoxIdentifiant
            // 
            this.textBoxIdentifiant.Location = new System.Drawing.Point(202, 137);
            this.textBoxIdentifiant.Name = "textBoxIdentifiant";
            this.textBoxIdentifiant.Size = new System.Drawing.Size(100, 20);
            this.textBoxIdentifiant.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Entrez l\'identifiant de votre RDV : ";
            // 
            // dataGridViewGestionRDV
            // 
            this.dataGridViewGestionRDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGestionRDV.Location = new System.Drawing.Point(30, 257);
            this.dataGridViewGestionRDV.Name = "dataGridViewGestionRDV";
            this.dataGridViewGestionRDV.Size = new System.Drawing.Size(598, 67);
            this.dataGridViewGestionRDV.TabIndex = 30;
            this.dataGridViewGestionRDV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewGestionRDV_CellContentClick);
            // 
            // btValider
            // 
            this.btValider.Location = new System.Drawing.Point(329, 114);
            this.btValider.Name = "btValider";
            this.btValider.Size = new System.Drawing.Size(138, 59);
            this.btValider.TabIndex = 29;
            this.btValider.Text = "VALIDER";
            this.btValider.UseVisualStyleBackColor = true;
            this.btValider.Click += new System.EventHandler(this.btValider_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.ValidationGestionRDV);
            this.MainPanel.Controls.Add(this.dataGridViewGestionRDV);
            this.MainPanel.Location = new System.Drawing.Point(3, 3);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(656, 548);
            this.MainPanel.TabIndex = 35;
            this.MainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainPanel_Paint);
            // 
            // ValidationGestionRDV
            // 
            this.ValidationGestionRDV.AutoSize = true;
            this.ValidationGestionRDV.BackColor = System.Drawing.Color.Transparent;
            this.ValidationGestionRDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValidationGestionRDV.ForeColor = System.Drawing.Color.LimeGreen;
            this.ValidationGestionRDV.Location = new System.Drawing.Point(47, 214);
            this.ValidationGestionRDV.Name = "ValidationGestionRDV";
            this.ValidationGestionRDV.Size = new System.Drawing.Size(0, 16);
            this.ValidationGestionRDV.TabIndex = 42;
            // 
            // GestionRDVPatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.Controls.Add(this.btDeplacerRDV);
            this.Controls.Add(this.btDeleteRDV);
            this.Controls.Add(this.textBoxIdentifiant);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btValider);
            this.Controls.Add(this.MainPanel);
            this.Name = "GestionRDVPatients";
            this.Size = new System.Drawing.Size(662, 554);
            this.Load += new System.EventHandler(this.GestionRDVPatients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGestionRDV)).EndInit();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btDeplacerRDV;
        private System.Windows.Forms.Button btDeleteRDV;
        private System.Windows.Forms.TextBox textBoxIdentifiant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewGestionRDV;
        private System.Windows.Forms.Button btValider;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label ValidationGestionRDV;
    }
}
