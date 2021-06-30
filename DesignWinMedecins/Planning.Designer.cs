
namespace DesignWinMedecins
{
    partial class Planning
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.jour = new System.Windows.Forms.Label();
            this.AnneeTextBox = new System.Windows.Forms.TextBox();
            this.MoisTextBox = new System.Windows.Forms.TextBox();
            this.JourTextBox = new System.Windows.Forms.TextBox();
            this.dataGridViewPlanning = new System.Windows.Forms.DataGridView();
            this.btValider = new System.Windows.Forms.Button();
            this.ValidationPlanning = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlanning)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Voir mes consultations pour la date du ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(485, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Année";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(409, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Mois";
            // 
            // jour
            // 
            this.jour.AutoSize = true;
            this.jour.Location = new System.Drawing.Point(326, 9);
            this.jour.Name = "jour";
            this.jour.Size = new System.Drawing.Size(27, 13);
            this.jour.TabIndex = 44;
            this.jour.Text = "Jour";
            // 
            // AnneeTextBox
            // 
            this.AnneeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnneeTextBox.Location = new System.Drawing.Point(488, 25);
            this.AnneeTextBox.Name = "AnneeTextBox";
            this.AnneeTextBox.Size = new System.Drawing.Size(117, 44);
            this.AnneeTextBox.TabIndex = 43;
            // 
            // MoisTextBox
            // 
            this.MoisTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoisTextBox.Location = new System.Drawing.Point(402, 25);
            this.MoisTextBox.Name = "MoisTextBox";
            this.MoisTextBox.Size = new System.Drawing.Size(51, 44);
            this.MoisTextBox.TabIndex = 42;
            // 
            // JourTextBox
            // 
            this.JourTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JourTextBox.Location = new System.Drawing.Point(318, 25);
            this.JourTextBox.Name = "JourTextBox";
            this.JourTextBox.Size = new System.Drawing.Size(51, 44);
            this.JourTextBox.TabIndex = 41;
            // 
            // dataGridViewPlanning
            // 
            this.dataGridViewPlanning.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPlanning.Location = new System.Drawing.Point(12, 87);
            this.dataGridViewPlanning.MultiSelect = false;
            this.dataGridViewPlanning.Name = "dataGridViewPlanning";
            this.dataGridViewPlanning.ReadOnly = true;
            this.dataGridViewPlanning.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPlanning.Size = new System.Drawing.Size(776, 245);
            this.dataGridViewPlanning.TabIndex = 47;
            // 
            // btValider
            // 
            this.btValider.Location = new System.Drawing.Point(637, 25);
            this.btValider.Name = "btValider";
            this.btValider.Size = new System.Drawing.Size(141, 44);
            this.btValider.TabIndex = 48;
            this.btValider.Text = "VALIDER";
            this.btValider.UseVisualStyleBackColor = true;
            this.btValider.Click += new System.EventHandler(this.btValider_Click);
            // 
            // ValidationPlanning
            // 
            this.ValidationPlanning.AutoSize = true;
            this.ValidationPlanning.BackColor = System.Drawing.Color.Transparent;
            this.ValidationPlanning.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValidationPlanning.ForeColor = System.Drawing.Color.LimeGreen;
            this.ValidationPlanning.Location = new System.Drawing.Point(260, 378);
            this.ValidationPlanning.Name = "ValidationPlanning";
            this.ValidationPlanning.Size = new System.Drawing.Size(0, 16);
            this.ValidationPlanning.TabIndex = 50;
            // 
            // Planning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.Controls.Add(this.ValidationPlanning);
            this.Controls.Add(this.btValider);
            this.Controls.Add(this.dataGridViewPlanning);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.jour);
            this.Controls.Add(this.AnneeTextBox);
            this.Controls.Add(this.MoisTextBox);
            this.Controls.Add(this.JourTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Planning";
            this.Size = new System.Drawing.Size(800, 450);
            this.Load += new System.EventHandler(this.Planning_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlanning)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label jour;
        private System.Windows.Forms.TextBox AnneeTextBox;
        private System.Windows.Forms.TextBox MoisTextBox;
        private System.Windows.Forms.TextBox JourTextBox;
        private System.Windows.Forms.DataGridView dataGridViewPlanning;
        private System.Windows.Forms.Button btValider;
        private System.Windows.Forms.Label ValidationPlanning;
    }
}