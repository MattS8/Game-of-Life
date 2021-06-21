
namespace Game_of_Life
{
    partial class HeadsUpDisplay
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
            this.lbCellCount = new System.Windows.Forms.Label();
            this.lbCurrentGen = new System.Windows.Forms.Label();
            this.lbBoundaryType = new System.Windows.Forms.Label();
            this.lbUnivSize = new System.Windows.Forms.Label();
            this.lbUniverseName = new System.Windows.Forms.Label();
            this.lbAlive = new System.Windows.Forms.Label();
            this.lbDead = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbCellCount
            // 
            this.lbCellCount.AutoSize = true;
            this.lbCellCount.Location = new System.Drawing.Point(3, 43);
            this.lbCellCount.Name = "lbCellCount";
            this.lbCellCount.Size = new System.Drawing.Size(67, 13);
            this.lbCellCount.TabIndex = 0;
            this.lbCellCount.Text = "Cell Count: 0";
            this.lbCellCount.Click += new System.EventHandler(this.PassThrough_Click);
            this.lbCellCount.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.PassThrough_MouseClick);
            // 
            // lbCurrentGen
            // 
            this.lbCurrentGen.AutoSize = true;
            this.lbCurrentGen.BackColor = System.Drawing.Color.Transparent;
            this.lbCurrentGen.Enabled = false;
            this.lbCurrentGen.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbCurrentGen.Location = new System.Drawing.Point(3, 11);
            this.lbCurrentGen.Name = "lbCurrentGen";
            this.lbCurrentGen.Size = new System.Drawing.Size(71, 13);
            this.lbCurrentGen.TabIndex = 1;
            this.lbCurrentGen.Text = "Generation: 0";
            this.lbCurrentGen.Click += new System.EventHandler(this.PassThrough_Click);
            this.lbCurrentGen.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PassThrough_MouseClick);
            // 
            // lbBoundaryType
            // 
            this.lbBoundaryType.AutoSize = true;
            this.lbBoundaryType.Location = new System.Drawing.Point(3, 74);
            this.lbBoundaryType.Name = "lbBoundaryType";
            this.lbBoundaryType.Size = new System.Drawing.Size(123, 13);
            this.lbBoundaryType.TabIndex = 2;
            this.lbBoundaryType.Text = "Boundary Type: Torodial";
            this.lbBoundaryType.Click += new System.EventHandler(this.PassThrough_Click);
            this.lbBoundaryType.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PassThrough_MouseClick);
            // 
            // lbUnivSize
            // 
            this.lbUnivSize.AutoSize = true;
            this.lbUnivSize.Location = new System.Drawing.Point(19, 120);
            this.lbUnivSize.Name = "lbUnivSize";
            this.lbUnivSize.Size = new System.Drawing.Size(113, 13);
            this.lbUnivSize.TabIndex = 6;
            this.lbUnivSize.Text = "Universe Size: 30 x 30";
            this.lbUnivSize.Click += new System.EventHandler(this.PassThrough_Click);
            this.lbUnivSize.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PassThrough_MouseClick);
            // 
            // lbUniverseName
            // 
            this.lbUniverseName.AutoSize = true;
            this.lbUniverseName.Location = new System.Drawing.Point(3, 103);
            this.lbUniverseName.Name = "lbUniverseName";
            this.lbUniverseName.Size = new System.Drawing.Size(154, 13);
            this.lbUniverseName.TabIndex = 7;
            this.lbUniverseName.Text = "Universe Name: \"Some Name\"";
            this.lbUniverseName.Click += new System.EventHandler(this.PassThrough_Click);
            this.lbUniverseName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PassThrough_MouseClick);
            // 
            // lbAlive
            // 
            this.lbAlive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbAlive.AutoSize = true;
            this.lbAlive.Location = new System.Drawing.Point(3, 206);
            this.lbAlive.Name = "lbAlive";
            this.lbAlive.Size = new System.Drawing.Size(36, 13);
            this.lbAlive.TabIndex = 8;
            this.lbAlive.Text = "Alive: ";
            this.lbAlive.Click += new System.EventHandler(this.PassThrough_Click);
            this.lbAlive.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PassThrough_MouseClick);
            // 
            // lbDead
            // 
            this.lbDead.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDead.AutoSize = true;
            this.lbDead.Location = new System.Drawing.Point(3, 228);
            this.lbDead.Name = "lbDead";
            this.lbDead.Size = new System.Drawing.Size(36, 13);
            this.lbDead.TabIndex = 9;
            this.lbDead.Text = "Dead:";
            this.lbDead.Click += new System.EventHandler(this.PassThrough_Click);
            this.lbDead.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PassThrough_MouseClick);
            // 
            // HeadsUpDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.CausesValidation = false;
            this.Controls.Add(this.lbDead);
            this.Controls.Add(this.lbAlive);
            this.Controls.Add(this.lbUniverseName);
            this.Controls.Add(this.lbUnivSize);
            this.Controls.Add(this.lbBoundaryType);
            this.Controls.Add(this.lbCurrentGen);
            this.Controls.Add(this.lbCellCount);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Coral;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "HeadsUpDisplay";
            this.Size = new System.Drawing.Size(160, 265);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PassThrough_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCellCount;
        private System.Windows.Forms.Label lbCurrentGen;
        private System.Windows.Forms.Label lbBoundaryType;
        private System.Windows.Forms.Label lbUnivSize;
        private System.Windows.Forms.Label lbUniverseName;
        private System.Windows.Forms.Label lbAlive;
        private System.Windows.Forms.Label lbDead;
    }
}
