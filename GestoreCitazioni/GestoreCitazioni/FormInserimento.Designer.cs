﻿namespace GestoreCitazioni
{
    partial class FormInserimento
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
            this.rtbCit = new System.Windows.Forms.RichTextBox();
            this.btnInserisci = new System.Windows.Forms.Button();
            this.txtTit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAutore = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inserisci citazione";
            // 
            // rtbCit
            // 
            this.rtbCit.BackColor = System.Drawing.SystemColors.Menu;
            this.rtbCit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbCit.Location = new System.Drawing.Point(37, 93);
            this.rtbCit.Name = "rtbCit";
            this.rtbCit.Size = new System.Drawing.Size(723, 285);
            this.rtbCit.TabIndex = 1;
            this.rtbCit.Text = "";
            // 
            // btnInserisci
            // 
            this.btnInserisci.Location = new System.Drawing.Point(610, 384);
            this.btnInserisci.Name = "btnInserisci";
            this.btnInserisci.Size = new System.Drawing.Size(150, 46);
            this.btnInserisci.TabIndex = 2;
            this.btnInserisci.Text = "Inserisci";
            this.btnInserisci.UseVisualStyleBackColor = true;
            this.btnInserisci.Click += new System.EventHandler(this.btnInserisci_Click);
            // 
            // txtTit
            // 
            this.txtTit.Location = new System.Drawing.Point(477, 35);
            this.txtTit.Name = "txtTit";
            this.txtTit.Size = new System.Drawing.Size(200, 39);
            this.txtTit.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(391, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Titolo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 398);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Autore:";
            // 
            // txtAutore
            // 
            this.txtAutore.Location = new System.Drawing.Point(134, 398);
            this.txtAutore.Name = "txtAutore";
            this.txtAutore.Size = new System.Drawing.Size(200, 39);
            this.txtAutore.TabIndex = 6;
            // 
            // FormInserimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtAutore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTit);
            this.Controls.Add(this.btnInserisci);
            this.Controls.Add(this.rtbCit);
            this.Controls.Add(this.label1);
            this.Name = "FormInserimento";
            this.Text = "FormInserimento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private RichTextBox rtbCit;
        private Button btnInserisci;
        private TextBox txtTit;
        private Label label2;
        private Label label3;
        private TextBox txtAutore;
    }
}