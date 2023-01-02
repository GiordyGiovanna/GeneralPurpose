namespace GestoreCitazioni
{
    partial class Modify_Detail
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
            this.rtbCit = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbCit
            // 
            this.rtbCit.BackColor = System.Drawing.SystemColors.Control;
            this.rtbCit.Location = new System.Drawing.Point(126, 12);
            this.rtbCit.Name = "rtbCit";
            this.rtbCit.Size = new System.Drawing.Size(932, 440);
            this.rtbCit.TabIndex = 0;
            this.rtbCit.Text = "";
            // 
            // Modify_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 656);
            this.Controls.Add(this.rtbCit);
            this.Name = "Modify_Detail";
            this.Text = "Modify_Detail";
            this.Load += new System.EventHandler(this.Modify_Detail_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox rtbCit;
    }
}