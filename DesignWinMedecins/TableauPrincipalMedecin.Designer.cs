
namespace DesignWinMedecins
{
    partial class TableauPrincipalMedecins
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btRDV = new System.Windows.Forms.Button();
            this.btPlanning = new System.Windows.Forms.Button();
            this.btPresences = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btChangerAssociation = new System.Windows.Forms.Button();
            this.btAssocier = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btRDV);
            this.panel1.Controls.Add(this.btPlanning);
            this.panel1.Controls.Add(this.btPresences);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btChangerAssociation);
            this.panel1.Controls.Add(this.btAssocier);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(136, 683);
            this.panel1.TabIndex = 0;
            // 
            // btRDV
            // 
            this.btRDV.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btRDV.Location = new System.Drawing.Point(4, 221);
            this.btRDV.Name = "btRDV";
            this.btRDV.Size = new System.Drawing.Size(119, 88);
            this.btRDV.TabIndex = 6;
            this.btRDV.Text = "Confirmer rendez-vous";
            this.btRDV.UseVisualStyleBackColor = false;
            this.btRDV.Click += new System.EventHandler(this.btRDV_Click);
            // 
            // btPlanning
            // 
            this.btPlanning.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btPlanning.Location = new System.Drawing.Point(4, 127);
            this.btPlanning.Name = "btPlanning";
            this.btPlanning.Size = new System.Drawing.Size(119, 88);
            this.btPlanning.TabIndex = 5;
            this.btPlanning.Text = "Voir planning";
            this.btPlanning.UseVisualStyleBackColor = false;
            this.btPlanning.Click += new System.EventHandler(this.btPlanning_Click);
            // 
            // btPresences
            // 
            this.btPresences.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btPresences.Location = new System.Drawing.Point(4, 325);
            this.btPresences.Name = "btPresences";
            this.btPresences.Size = new System.Drawing.Size(119, 88);
            this.btPresences.TabIndex = 4;
            this.btPresences.Text = "Encoder présences";
            this.btPresences.UseVisualStyleBackColor = false;
            this.btPresences.Click += new System.EventHandler(this.btPresences_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 118);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btChangerAssociation
            // 
            this.btChangerAssociation.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btChangerAssociation.Location = new System.Drawing.Point(3, 511);
            this.btChangerAssociation.Name = "btChangerAssociation";
            this.btChangerAssociation.Size = new System.Drawing.Size(119, 88);
            this.btChangerAssociation.TabIndex = 3;
            this.btChangerAssociation.Text = "Modifier Association maison med/spécialité";
            this.btChangerAssociation.UseVisualStyleBackColor = false;
            this.btChangerAssociation.Click += new System.EventHandler(this.btChangerAssociation_Click);
            // 
            // btAssocier
            // 
            this.btAssocier.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btAssocier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAssocier.Location = new System.Drawing.Point(3, 419);
            this.btAssocier.Name = "btAssocier";
            this.btAssocier.Size = new System.Drawing.Size(119, 86);
            this.btAssocier.TabIndex = 2;
            this.btAssocier.Text = "Associer maison med/specialité";
            this.btAssocier.UseVisualStyleBackColor = false;
            this.btAssocier.Click += new System.EventHandler(this.btAssocier_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(136, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(852, 47);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "MEDICALENDRIER";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(334, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "PORTAIL MEDECIN";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.OrangeRed;
            this.button3.Location = new System.Drawing.Point(801, 1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(46, 41);
            this.button3.TabIndex = 2;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Location = new System.Drawing.Point(136, 43);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(852, 640);
            this.MainPanel.TabIndex = 2;
            // 
            // TableauPrincipalMedecins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(988, 683);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "TableauPrincipalMedecins";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Portail Patient";
            this.Load += new System.EventHandler(this.TableauPrincipalPatient_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btAssocier;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btChangerAssociation;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btRDV;
        private System.Windows.Forms.Button btPlanning;
        private System.Windows.Forms.Button btPresences;
    }
}