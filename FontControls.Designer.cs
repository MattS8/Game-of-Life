
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbUniSize = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbUniName = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbBoundaryType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCellCount = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbGen = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbAlive = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CmbDead = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbNeighborFont
            // 
            this.cmbNeighborFont.FormattingEnabled = true;
            this.cmbNeighborFont.Location = new System.Drawing.Point(6, 16);
            this.cmbNeighborFont.Name = "cmbNeighborFont";
            this.cmbNeighborFont.Size = new System.Drawing.Size(121, 21);
            this.cmbNeighborFont.TabIndex = 0;
            this.cmbNeighborFont.Click += new System.EventHandler(this.cmbNeighborFont_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Neighbor Count:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.CmbDead);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cmbAlive);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbUniSize);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbUniName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbBoundaryType);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbCellCount);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbGen);
            this.groupBox1.Location = new System.Drawing.Point(6, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 211);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Heads-Up Display";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(151, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Universe Size:";
            // 
            // cmbUniSize
            // 
            this.cmbUniSize.FormattingEnabled = true;
            this.cmbUniSize.Location = new System.Drawing.Point(154, 87);
            this.cmbUniSize.Name = "cmbUniSize";
            this.cmbUniSize.Size = new System.Drawing.Size(121, 21);
            this.cmbUniSize.TabIndex = 11;
            this.cmbUniSize.Click += new System.EventHandler(this.cmbUniSize_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Universe Name:";
            // 
            // cmbUniName
            // 
            this.cmbUniName.FormattingEnabled = true;
            this.cmbUniName.Location = new System.Drawing.Point(9, 87);
            this.cmbUniName.Name = "cmbUniName";
            this.cmbUniName.Size = new System.Drawing.Size(121, 21);
            this.cmbUniName.TabIndex = 9;
            this.cmbUniName.Click += new System.EventHandler(this.cmbUniName_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(151, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Boundary Type:";
            // 
            // cmbBoundaryType
            // 
            this.cmbBoundaryType.FormattingEnabled = true;
            this.cmbBoundaryType.Location = new System.Drawing.Point(154, 36);
            this.cmbBoundaryType.Name = "cmbBoundaryType";
            this.cmbBoundaryType.Size = new System.Drawing.Size(121, 21);
            this.cmbBoundaryType.TabIndex = 7;
            this.cmbBoundaryType.Click += new System.EventHandler(this.cmbBoundaryType_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cell Count:";
            // 
            // cmbCellCount
            // 
            this.cmbCellCount.FormattingEnabled = true;
            this.cmbCellCount.Location = new System.Drawing.Point(9, 135);
            this.cmbCellCount.Name = "cmbCellCount";
            this.cmbCellCount.Size = new System.Drawing.Size(121, 21);
            this.cmbCellCount.TabIndex = 5;
            this.cmbCellCount.Click += new System.EventHandler(this.cmbCellCount_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Generation:";
            // 
            // cmbGen
            // 
            this.cmbGen.FormattingEnabled = true;
            this.cmbGen.Location = new System.Drawing.Point(9, 36);
            this.cmbGen.Name = "cmbGen";
            this.cmbGen.Size = new System.Drawing.Size(121, 21);
            this.cmbGen.TabIndex = 3;
            this.cmbGen.Click += new System.EventHandler(this.cmbGen_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Alive Cell Count:";
            // 
            // cmbAlive
            // 
            this.cmbAlive.FormattingEnabled = true;
            this.cmbAlive.Location = new System.Drawing.Point(9, 184);
            this.cmbAlive.Name = "cmbAlive";
            this.cmbAlive.Size = new System.Drawing.Size(121, 21);
            this.cmbAlive.TabIndex = 13;
            this.cmbAlive.Click += new System.EventHandler(this.cmbAlive_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(151, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Dead Cell Count:";
            // 
            // CmbDead
            // 
            this.CmbDead.FormattingEnabled = true;
            this.CmbDead.Location = new System.Drawing.Point(154, 184);
            this.CmbDead.Name = "CmbDead";
            this.CmbDead.Size = new System.Drawing.Size(121, 21);
            this.CmbDead.TabIndex = 15;
            this.CmbDead.Click += new System.EventHandler(this.CmbDead_Click);
            // 
            // FontControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbNeighborFont);
            this.Name = "FontControls";
            this.Size = new System.Drawing.Size(345, 312);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbNeighborFont;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbGen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCellCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbBoundaryType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbUniSize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbUniName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CmbDead;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbAlive;
    }
}
