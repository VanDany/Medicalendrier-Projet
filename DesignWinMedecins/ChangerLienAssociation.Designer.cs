
namespace DesignWinMedecins
{
    partial class ChangerLienAssociation
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
            this.dataGridViewAssociation = new System.Windows.Forms.DataGridView();
            this.btActiverOuDesactiver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAssociation)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAssociation
            // 
            this.dataGridViewAssociation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAssociation.Location = new System.Drawing.Point(12, 33);
            this.dataGridViewAssociation.MultiSelect = false;
            this.dataGridViewAssociation.Name = "dataGridViewAssociation";
            this.dataGridViewAssociation.ReadOnly = true;
            this.dataGridViewAssociation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAssociation.Size = new System.Drawing.Size(776, 270);
            this.dataGridViewAssociation.TabIndex = 15;
            this.dataGridViewAssociation.SelectionChanged += new System.EventHandler(this.dataGridViewAssociation_SelectionChanged);
            // 
            // btActiverOuDesactiver
            // 
            this.btActiverOuDesactiver.Location = new System.Drawing.Point(255, 330);
            this.btActiverOuDesactiver.Name = "btActiverOuDesactiver";
            this.btActiverOuDesactiver.Size = new System.Drawing.Size(267, 73);
            this.btActiverOuDesactiver.TabIndex = 16;
            this.btActiverOuDesactiver.Text = "Activer l\'association sélectionnée";
            this.btActiverOuDesactiver.UseVisualStyleBackColor = true;
            this.btActiverOuDesactiver.Click += new System.EventHandler(this.btActiverOuDesactiver_Click);
            // 
            // ChangerLienAssociation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.Controls.Add(this.btActiverOuDesactiver);
            this.Controls.Add(this.dataGridViewAssociation);
            this.Name = "ChangerLienAssociation";
            this.Size = new System.Drawing.Size(800, 450);
            this.Load += new System.EventHandler(this.ChangerLienAssciation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAssociation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAssociation;
        private System.Windows.Forms.Button btActiverOuDesactiver;
    }
}