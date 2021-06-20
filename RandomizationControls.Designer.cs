
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbTimeSeed = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numSeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAlive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDead)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbUniverseSeed
            // 
            this.cbUniverseSeed.AutoSize = true;
            this.cbUniverseSeed.Location = new System.Drawing.Point(13, 19);
            this.cbUniverseSeed.Name = "cbUniverseSeed";
            this.cbUniverseSeed.Size = new System.Drawing.Size(111, 17);
            this.cbUniverseSeed.TabIndex = 0;
            this.cbUniverseSeed.Text = "Use Manual Seed";
            this.cbUniverseSeed.UseVisualStyleBackColor = true;
            this.cbUniverseSeed.CheckedChanged += new System.EventHandler(this.cbUniverseSeed_CheckedChanged);
            // 
            // numSeed
            // 
            this.numSeed.Location = new System.Drawing.Point(6, 95);
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
            this.label1.Location = new System.Drawing.Point(22, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cell Ratio";
            // 
            // numAlive
            // 
            this.numAlive.Location = new System.Drawing.Point(6, 171);
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
            this.numDead.Location = new System.Drawing.Point(53, 171);
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
            this.label2.Location = new System.Drawing.Point(10, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Alive";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Dead";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbTimeSeed);
            this.groupBox1.Controls.Add(this.cbUniverseSeed);
            this.groupBox1.Location = new System.Drawing.Point(6, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 58);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Randomization Methods";
            // 
            // cbTimeSeed
            // 
            this.cbTimeSeed.AutoSize = true;
            this.cbTimeSeed.Location = new System.Drawing.Point(130, 19);
            this.cbTimeSeed.Name = "cbTimeSeed";
            this.cbTimeSeed.Size = new System.Drawing.Size(132, 17);
            this.cbTimeSeed.TabIndex = 1;
            this.cbTimeSeed.Text = "Use Time-Based Seed";
            this.cbTimeSeed.UseVisualStyleBackColor = true;
            this.cbTimeSeed.CheckedChanged += new System.EventHandler(this.cbTimeSeed_CheckChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Manual Seed:";
            // 
            // RandomizationControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.numAlive);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numDead);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numSeed);
            this.Location = new System.Drawing.Point(20, 20);
            this.Name = "RandomizationControls";
            this.Size = new System.Drawing.Size(437, 389);
            ((System.ComponentModel.ISupportInitialize)(this.numSeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAlive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDead)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbTimeSeed;
        private System.Windows.Forms.Label label4;
    }
}
