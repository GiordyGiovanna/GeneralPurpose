﻿namespace GestoreCitazioni
{
    partial class Gestore
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnInserisci = new System.Windows.Forms.Button();
            this.dgvCit = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCit)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnInserisci
            // 
            this.BtnInserisci.Location = new System.Drawing.Point(1085, 12);
            this.BtnInserisci.Name = "BtnInserisci";
            this.BtnInserisci.Size = new System.Drawing.Size(150, 46);
            this.BtnInserisci.TabIndex = 0;
            this.BtnInserisci.Text = "Inserisci";
            this.BtnInserisci.UseVisualStyleBackColor = true;
            this.BtnInserisci.Click += new System.EventHandler(this.BtnInserisci_Click);
            // 
            // dgvCit
            // 
            this.dgvCit.AllowUserToAddRows = false;
            this.dgvCit.AllowUserToDeleteRows = false;
            this.dgvCit.AllowUserToOrderColumns = true;
            this.dgvCit.AllowUserToResizeColumns = false;
            this.dgvCit.AllowUserToResizeRows = false;
            this.dgvCit.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvCit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCit.Location = new System.Drawing.Point(12, 12);
            this.dgvCit.Name = "dgvCit";
            this.dgvCit.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCit.RowHeadersVisible = false;
            this.dgvCit.RowHeadersWidth = 82;
            this.dgvCit.RowTemplate.Height = 41;
            this.dgvCit.Size = new System.Drawing.Size(1050, 300);
            this.dgvCit.TabIndex = 1;
            this.dgvCit.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCit_CellContentClick);
            // 
            // Gestore
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1247, 606);
            this.Controls.Add(this.dgvCit);
            this.Controls.Add(this.BtnInserisci);
            this.Name = "Gestore";
            this.Text = "Gestore";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button BtnInserisci;
        private DataGridView dgvCit;
    }
}