
namespace Game_of_Life
{
    partial class RandomizationControls
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
            this.cbUniverseSeed = new System.Windows.Forms.CheckBox();
            this.numSeed = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numAlive = new System.Windows.Forms.NumericUpDown();
            this.numDead = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numSeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAlive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDead)).BeginInit();
            this.SuspendLayout();
            // 
            // cbUniverseSeed
            // 
            this.cbUniverseSeed.AutoSize = true;
            this.cbUniverseSeed.Location = new System.Drawing.Point(4, 4);
            this.cbUniverseSeed.Name = "cbUniverseSeed";
            this.cbUniverseSeed.Size = new System.Drawing.Size(146, 17);
            this.cbUniverseSeed.TabIndex = 0;
            this.cbUniverseSeed.Text = "Use Randomization Seed";
            this.cbUniverseSeed.UseVisualStyleBackColor = true;
            this.cbUniverseSeed.CheckedChanged += new System.EventHandler(this.cbUniverseSeed_CheckedChanged);
            // 
            // numSeed
            // 
            this.numSeed.Location = new System.Drawing.Point(4, 27);
            this.numSeed.Maximum = new decimal(new int[] {
            1147483647,
            0,
            0,
            0});
            this.numSeed.Name = "numSeed";
            this.numSeed.Size = new System.Drawing.Size(146, 20);
            this.numSeed.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cell Ratio";
            // 
            // numAlive
            // 
            this.numAlive.Location = new System.Drawing.Point(14, 97);
            this.numAlive.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numAlive.Name = "numAlive";
            this.numAlive.Size = new System.Drawing.Size(41, 20);
            this.numAlive.TabIndex = 4;
            this.numAlive.ValueChanged += new System.EventHandler(this.numAlive_ValueChanged);
            // 
            // numDead
            // 
            this.numDead.Location = new System.Drawing.Point(61, 97);
            this.numDead.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numDead.Name = "numDead";
            this.numDead.Size = new System.Drawing.Size(41, 20);
            this.numDead.TabIndex = 5;
            this.numDead.ValueChanged += new System.EventHandler(this.numDead_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Alive";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Dead";
            // 
            // RandomizationControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numDead);
            this.Controls.Add(this.numAlive);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numSeed);
            this.Controls.Add(this.cbUniverseSeed);
            this.Location = new System.Drawing.Point(20, 20);
            this.Name = "RandomizationControls";
            this.Size = new System.Drawing.Size(266, 150);
            ((System.ComponentModel.ISupportInitialize)(this.numSeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAlive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDead)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbUniverseSeed;
        private System.Windows.Forms.NumericUpDown numSeed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numAlive;
        private System.Windows.Forms.NumericUpDown numDead;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
