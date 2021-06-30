
namespace DesignWinMedecins
{
    partial class ConfirmerRDV
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
            this.btValider = new System.Windows.Forms.Button();
            this.dataGridViewConfirmation = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConfirmation)).BeginInit();
            this.SuspendLayout();
            // 
            // btValider
            // 
            this.btValider.Location = new System.Drawing.Point(340, 365);
            this.btValider.Name = "btValider";
            this.btValider.Size = new System.Drawing.Size(141, 44);
            this.btValider.TabIndex = 57;
            this.btValider.Text = "VALIDER";
            this.btValider.UseVisualStyleBackColor = true;
            this.btValider.Click += new System.EventHandler(this.btValider_Click);
            // 
            // dataGridViewConfirmation
            // 
            this.dataGridViewConfirmation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConfirmation.Location = new System.Drawing.Point(12, 89);
            this.dataGridViewConfirmation.Name = "dataGridViewConfirmation";
            this.dataGridViewConfirmation.ReadOnly = true;
            this.dataGridViewConfirmation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewConfirmation.Size = new System.Drawing.Size(776, 247);
            this.dataGridViewConfirmation.TabIndex = 56;
            this.dataGridViewConfirmation.SelectionChanged += new System.EventHandler(this.dataGridViewConfirmation_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(513, 20);
            this.label1.TabIndex = 49;
            this.label1.Text = "Cliquer sur les rdv que vous souhaitez accepter, puis appuyer sur valider";
            // 
            // ConfirmerRDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.Controls.Add(this.btValider);
            this.Controls.Add(this.dataGridViewConfirmation);
            this.Controls.Add(this.label1);
            this.Name = "ConfirmerRDV";
            this.Size = new System.Drawing.Size(800, 450);
            this.Load += new System.EventHandler(this.ConfirmerRDV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConfirmation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btValider;
        private System.Windows.Forms.DataGridView dataGridViewConfirmation;
        private System.Windows.Forms.Label label1;
    }
}