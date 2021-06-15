
namespace Game_of_Life
{
    partial class PanelColorsControls
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
            this.lbPanelBG = new System.Windows.Forms.Label();
            this.btnColorPanelBG = new System.Windows.Forms.Button();
            this.lbGridColor = new System.Windows.Forms.Label();
            this.btnGridColor = new System.Windows.Forms.Button();
            this.lbSegColor = new System.Windows.Forms.Label();
            this.btnSegColor = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbAliveCellBG = new System.Windows.Forms.Label();
            this.btnAliveCellBG = new System.Windows.Forms.Button();
            this.lbDeadCellBG = new System.Windows.Forms.Label();
            this.btnDeadCellBG = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbPanelBG
            // 
            this.lbPanelBG.AutoSize = true;
            this.lbPanelBG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPanelBG.Location = new System.Drawing.Point(29, 19);
            this.lbPanelBG.Name = "lbPanelBG";
            this.lbPanelBG.Size = new System.Drawing.Size(108, 15);
            this.lbPanelBG.TabIndex = 1;
            this.lbPanelBG.Text = "Panel Background";
            this.lbPanelBG.Click += new System.EventHandler(this.lbPanelBG_Click);
            // 
            // btnColorPanelBG
            // 
            this.btnColorPanelBG.BackColor = System.Drawing.SystemColors.Window;
            this.btnColorPanelBG.FlatAppearance.BorderSize = 0;
            this.btnColorPanelBG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColorPanelBG.Location = new System.Drawing.Point(6, 19);
            this.btnColorPanelBG.Name = "btnColorPanelBG";
            this.btnColorPanelBG.Size = new System.Drawing.Size(17, 17);
            this.btnColorPanelBG.TabIndex = 0;
            this.btnColorPanelBG.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnColorPanelBG.UseVisualStyleBackColor = false;
            this.btnColorPanelBG.Click += new System.EventHandler(this.btnColorPanelBG_Click);
            // 
            // lbGridColor
            // 
            this.lbGridColor.AutoSize = true;
            this.lbGridColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGridColor.Location = new System.Drawing.Point(29, 20);
            this.lbGridColor.Name = "lbGridColor";
            this.lbGridColor.Size = new System.Drawing.Size(57, 15);
            this.lbGridColor.TabIndex = 3;
            this.lbGridColor.Text = "Grid Line";
            this.lbGridColor.Click += new System.EventHandler(this.lbGridColor_Click);
            // 
            // btnGridColor
            // 
            this.btnGridColor.BackColor = System.Drawing.SystemColors.Window;
            this.btnGridColor.FlatAppearance.BorderSize = 0;
            this.btnGridColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGridColor.Location = new System.Drawing.Point(6, 20);
            this.btnGridColor.Name = "btnGridColor";
            this.btnGridColor.Size = new System.Drawing.Size(17, 17);
            this.btnGridColor.TabIndex = 2;
            this.btnGridColor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGridColor.UseVisualStyleBackColor = false;
            this.btnGridColor.Click += new System.EventHandler(this.btnGridColor_Click);
            // 
            // lbSegColor
            // 
            this.lbSegColor.AutoSize = true;
            this.lbSegColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSegColor.Location = new System.Drawing.Point(123, 20);
            this.lbSegColor.Name = "lbSegColor";
            this.lbSegColor.Size = new System.Drawing.Size(83, 15);
            this.lbSegColor.TabIndex = 5;
            this.lbSegColor.Text = "Grid Segment";
            this.lbSegColor.Click += new System.EventHandler(this.lbSegColor_Click);
            // 
            // btnSegColor
            // 
            this.btnSegColor.BackColor = System.Drawing.SystemColors.Window;
            this.btnSegColor.FlatAppearance.BorderSize = 0;
            this.btnSegColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSegColor.Location = new System.Drawing.Point(100, 20);
            this.btnSegColor.Name = "btnSegColor";
            this.btnSegColor.Size = new System.Drawing.Size(17, 17);
            this.btnSegColor.TabIndex = 4;
            this.btnSegColor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSegColor.UseVisualStyleBackColor = false;
            this.btnSegColor.Click += new System.EventHandler(this.btnSegColor_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbDeadCellBG);
            this.groupBox1.Controls.Add(this.btnDeadCellBG);
            this.groupBox1.Controls.Add(this.lbAliveCellBG);
            this.groupBox1.Controls.Add(this.btnAliveCellBG);
            this.groupBox1.Controls.Add(this.btnColorPanelBG);
            this.groupBox1.Controls.Add(this.lbPanelBG);
            this.groupBox1.Location = new System.Drawing.Point(0, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 98);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Background Colors";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbGridColor);
            this.groupBox2.Controls.Add(this.btnGridColor);
            this.groupBox2.Controls.Add(this.lbSegColor);
            this.groupBox2.Controls.Add(this.btnSegColor);
            this.groupBox2.Location = new System.Drawing.Point(0, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 50);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Grid Colors";
            // 
            // lbAliveCellBG
            // 
            this.lbAliveCellBG.AutoSize = true;
            this.lbAliveCellBG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAliveCellBG.Location = new System.Drawing.Point(29, 44);
            this.lbAliveCellBG.Name = "lbAliveCellBG";
            this.lbAliveCellBG.Size = new System.Drawing.Size(133, 15);
            this.lbAliveCellBG.TabIndex = 7;
            this.lbAliveCellBG.Text = "Cell Background (Alive)";
            this.lbAliveCellBG.Click += new System.EventHandler(this.lbAliveCellBG_Click);
            // 
            // btnAliveCellBG
            // 
            this.btnAliveCellBG.BackColor = System.Drawing.SystemColors.Window;
            this.btnAliveCellBG.FlatAppearance.BorderSize = 0;
            this.btnAliveCellBG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAliveCellBG.Location = new System.Drawing.Point(6, 44);
            this.btnAliveCellBG.Name = "btnAliveCellBG";
            this.btnAliveCellBG.Size = new System.Drawing.Size(17, 17);
            this.btnAliveCellBG.TabIndex = 6;
            this.btnAliveCellBG.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAliveCellBG.UseVisualStyleBackColor = false;
            this.btnAliveCellBG.Click += new System.EventHandler(this.btnAliveCellBG_Click);
            // 
            // lbDeadCellBG
            // 
            this.lbDeadCellBG.AutoSize = true;
            this.lbDeadCellBG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDeadCellBG.Location = new System.Drawing.Point(29, 69);
            this.lbDeadCellBG.Name = "lbDeadCellBG";
            this.lbDeadCellBG.Size = new System.Drawing.Size(138, 15);
            this.lbDeadCellBG.TabIndex = 9;
            this.lbDeadCellBG.Text = "Cell Background (Dead)";
            this.lbDeadCellBG.Click += new System.EventHandler(this.lbDeadCellBG_Click);
            // 
            // btnDeadCellBG
            // 
            this.btnDeadCellBG.BackColor = System.Drawing.SystemColors.Window;
            this.btnDeadCellBG.FlatAppearance.BorderSize = 0;
            this.btnDeadCellBG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeadCellBG.Location = new System.Drawing.Point(6, 69);
            this.btnDeadCellBG.Name = "btnDeadCellBG";
            this.btnDeadCellBG.Size = new System.Drawing.Size(17, 17);
            this.btnDeadCellBG.TabIndex = 8;
            this.btnDeadCellBG.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeadCellBG.UseVisualStyleBackColor = false;
            this.btnDeadCellBG.Click += new System.EventHandler(this.btnDeadCellBG_Click);
            // 
            // PanelProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Location = new System.Drawing.Point(20, 20);
            this.Name = "PanelProperties";
            this.Size = new System.Drawing.Size(338, 173);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbPanelBG;
        private System.Windows.Forms.Button btnColorPanelBG;
        private System.Windows.Forms.Label lbGridColor;
        private System.Windows.Forms.Button btnGridColor;
        private System.Windows.Forms.Label lbSegColor;
        private System.Windows.Forms.Button btnSegColor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbDeadCellBG;
        private System.Windows.Forms.Button btnDeadCellBG;
        private System.Windows.Forms.Label lbAliveCellBG;
        private System.Windows.Forms.Button btnAliveCellBG;
    }
}
