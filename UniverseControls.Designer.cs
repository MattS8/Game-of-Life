
namespace Game_of_Life
{
    partial class UniverseControls
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numUniHeight = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numUniWidth = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbFinite = new System.Windows.Forms.CheckBox();
            this.cbTorodial = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numUniSimSpeed = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUniHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUniWidth)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUniSimSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numUniHeight);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numUniWidth);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 81);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Universe Size";
            // 
            // numUniHeight
            // 
            this.numUniHeight.Location = new System.Drawing.Point(108, 37);
            this.numUniHeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numUniHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUniHeight.Name = "numUniHeight";
            this.numUniHeight.Size = new System.Drawing.Size(71, 20);
            this.numUniHeight.TabIndex = 3;
            this.numUniHeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Height:";
            // 
            // numUniWidth
            // 
            this.numUniWidth.Location = new System.Drawing.Point(10, 37);
            this.numUniWidth.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numUniWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUniWidth.Name = "numUniWidth";
            this.numUniWidth.Size = new System.Drawing.Size(71, 20);
            this.numUniWidth.TabIndex = 1;
            this.numUniWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Width:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbFinite);
            this.groupBox2.Controls.Add(this.cbTorodial);
            this.groupBox2.Location = new System.Drawing.Point(211, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 57);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Boundary Type";
            // 
            // cbFinite
            // 
            this.cbFinite.AutoSize = true;
            this.cbFinite.Location = new System.Drawing.Point(81, 20);
            this.cbFinite.Name = "cbFinite";
            this.cbFinite.Size = new System.Drawing.Size(51, 17);
            this.cbFinite.TabIndex = 1;
            this.cbFinite.Text = "Finite";
            this.cbFinite.UseVisualStyleBackColor = true;
            this.cbFinite.CheckedChanged += new System.EventHandler(this.cbFinite_CheckedChanged);
            // 
            // cbTorodial
            // 
            this.cbTorodial.AutoSize = true;
            this.cbTorodial.Location = new System.Drawing.Point(11, 20);
            this.cbTorodial.Name = "cbTorodial";
            this.cbTorodial.Size = new System.Drawing.Size(64, 17);
            this.cbTorodial.TabIndex = 0;
            this.cbTorodial.Text = "Torodial";
            this.cbTorodial.UseVisualStyleBackColor = true;
            this.cbTorodial.CheckedChanged += new System.EventHandler(this.cbTorodial_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Simulation Speed:";
            // 
            // numUniSimSpeed
            // 
            this.numUniSimSpeed.Location = new System.Drawing.Point(7, 117);
            this.numUniSimSpeed.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numUniSimSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUniSimSpeed.Name = "numUniSimSpeed";
            this.numUniSimSpeed.Size = new System.Drawing.Size(89, 20);
            this.numUniSimSpeed.TabIndex = 4;
            this.numUniSimSpeed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "ms";
            // 
            // UniverseControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numUniSimSpeed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Location = new System.Drawing.Point(20, 20);
            this.Name = "UniverseControls";
            this.Size = new System.Drawing.Size(469, 200);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUniHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUniWidth)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUniSimSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numUniHeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numUniWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbFinite;
        private System.Windows.Forms.CheckBox cbTorodial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numUniSimSpeed;
        private System.Windows.Forms.Label label4;
    }
}
