
namespace DesignWinAdmin
{
    partial class AdminPortail
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
            this.btAjouterMaisonMed = new System.Windows.Forms.Button();
            this.btAjouterLocal = new System.Windows.Forms.Button();
            this.NomTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MaisonsMed = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nomLocalTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CommuneTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AdresseTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ValidationAjout = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btAjouterMaisonMed
            // 
            this.btAjouterMaisonMed.Location = new System.Drawing.Point(51, 219);
            this.btAjouterMaisonMed.Name = "btAjouterMaisonMed";
            this.btAjouterMaisonMed.Size = new System.Drawing.Size(172, 85);
            this.btAjouterMaisonMed.TabIndex = 0;
            this.btAjouterMaisonMed.Text = "AJOUTER";
            this.btAjouterMaisonMed.UseVisualStyleBackColor = true;
            this.btAjouterMaisonMed.Click += new System.EventHandler(this.btAjouterMaisonMed_Click);
            // 
            // btAjouterLocal
            // 
            this.btAjouterLocal.Location = new System.Drawing.Point(65, 175);
            this.btAjouterLocal.Name = "btAjouterLocal";
            this.btAjouterLocal.Size = new System.Drawing.Size(171, 78);
            this.btAjouterLocal.TabIndex = 1;
            this.btAjouterLocal.Text = "AJOUTER";
            this.btAjouterLocal.UseVisualStyleBackColor = true;
            this.btAjouterLocal.Click += new System.EventHandler(this.btAjouterLocal_Click);
            // 
            // NomTextBox
            // 
            this.NomTextBox.Location = new System.Drawing.Point(51, 85);
            this.NomTextBox.Name = "NomTextBox";
            this.NomTextBox.Size = new System.Drawing.Size(172, 20);
            this.NomTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nom";
            // 
            // MaisonsMed
            // 
            this.MaisonsMed.FormattingEnabled = true;
            this.MaisonsMed.Location = new System.Drawing.Point(65, 58);
            this.MaisonsMed.Name = "MaisonsMed";
            this.MaisonsMed.Size = new System.Drawing.Size(171, 21);
            this.MaisonsMed.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nom du local";
            // 
            // nomLocalTextBox
            // 
            this.nomLocalTextBox.Location = new System.Drawing.Point(65, 118);
            this.nomLocalTextBox.Name = "nomLocalTextBox";
            this.nomLocalTextBox.Size = new System.Drawing.Size(171, 20);
            this.nomLocalTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nom maison médicale";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CommuneTextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.AdresseTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.NomTextBox);
            this.groupBox1.Controls.Add(this.btAjouterMaisonMed);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(26, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 321);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ajouter une maison médicale";
            // 
            // CommuneTextBox
            // 
            this.CommuneTextBox.Location = new System.Drawing.Point(51, 191);
            this.CommuneTextBox.Name = "CommuneTextBox";
            this.CommuneTextBox.Size = new System.Drawing.Size(172, 20);
            this.CommuneTextBox.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(103, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Commune";
            // 
            // AdresseTextBox
            // 
            this.AdresseTextBox.Location = new System.Drawing.Point(51, 141);
            this.AdresseTextBox.Name = "AdresseTextBox";
            this.AdresseTextBox.Size = new System.Drawing.Size(172, 20);
            this.AdresseTextBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Adresse";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.MaisonsMed);
            this.groupBox2.Controls.Add(this.btAjouterLocal);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.nomLocalTextBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(418, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(286, 321);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ajouter un local à une maison médicale";
            // 
            // ValidationAjout
            // 
            this.ValidationAjout.AutoSize = true;
            this.ValidationAjout.BackColor = System.Drawing.Color.Transparent;
            this.ValidationAjout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValidationAjout.ForeColor = System.Drawing.Color.LimeGreen;
            this.ValidationAjout.Location = new System.Drawing.Point(263, 401);
            this.ValidationAjout.Name = "ValidationAjout";
            this.ValidationAjout.Size = new System.Drawing.Size(0, 16);
            this.ValidationAjout.TabIndex = 50;
            // 
            // AdminPortail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ValidationAjout);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AdminPortail";
            this.Text = "Portail Admin";
            this.Load += new System.EventHandler(this.AdminPortail_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAjouterMaisonMed;
        private System.Windows.Forms.Button btAjouterLocal;
        private System.Windows.Forms.TextBox NomTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox MaisonsMed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nomLocalTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox CommuneTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AdresseTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ValidationAjout;
    }
}

