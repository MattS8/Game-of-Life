﻿
namespace Game_of_Life
{
    partial class FontControls
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
            this.cmbNeighborFont = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmbNeighborFont
            // 
            this.cmbNeighborFont.FormattingEnabled = true;
            this.cmbNeighborFont.Location = new System.Drawing.Point(3, 3);
            this.cmbNeighborFont.Name = "cmbNeighborFont";
            this.cmbNeighborFont.Size = new System.Drawing.Size(121, 21);
            this.cmbNeighborFont.TabIndex = 0;
            this.cmbNeighborFont.Click += new System.EventHandler(this.cmbNeighborFont_Click);
            // 
            // FontControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbNeighborFont);
            this.Name = "FontControls";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbNeighborFont;
    }
}
