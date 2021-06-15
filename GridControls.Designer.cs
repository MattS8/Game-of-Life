
namespace Game_of_Life
{
    partial class GridControls
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
            this.lbGridThickness = new System.Windows.Forms.Label();
            this.cbDisplayGrid = new System.Windows.Forms.CheckBox();
            this.cbDisplaySegmentGridlines = new System.Windows.Forms.CheckBox();
            this.lbSegEvery = new System.Windows.Forms.Label();
            this.txtSegment = new System.Windows.Forms.TextBox();
            this.lbSegLines = new System.Windows.Forms.Label();
            this.lbGridThicknessPx = new System.Windows.Forms.Label();
            this.txtGridLine = new System.Windows.Forms.TextBox();
            this.txtSegThick = new System.Windows.Forms.TextBox();
            this.lbSegThickness = new System.Windows.Forms.Label();
            this.lbSegPx = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbGridThickness
            // 
            this.lbGridThickness.AutoSize = true;
            this.lbGridThickness.Location = new System.Drawing.Point(3, 23);
            this.lbGridThickness.Name = "lbGridThickness";
            this.lbGridThickness.Size = new System.Drawing.Size(101, 13);
            this.lbGridThickness.TabIndex = 1;
            this.lbGridThickness.Text = "Grid Line Thickness";
            // 
            // cbDisplayGrid
            // 
            this.cbDisplayGrid.AutoSize = true;
            this.cbDisplayGrid.Location = new System.Drawing.Point(3, 3);
            this.cbDisplayGrid.Name = "cbDisplayGrid";
            this.cbDisplayGrid.Size = new System.Drawing.Size(103, 17);
            this.cbDisplayGrid.TabIndex = 2;
            this.cbDisplayGrid.Text = "Display Gridlines";
            this.cbDisplayGrid.UseVisualStyleBackColor = true;
            this.cbDisplayGrid.CheckedChanged += new System.EventHandler(this.cbDisplayGrid_CheckedChanged);
            // 
            // cbDisplaySegmentGridlines
            // 
            this.cbDisplaySegmentGridlines.AutoSize = true;
            this.cbDisplaySegmentGridlines.Location = new System.Drawing.Point(166, 3);
            this.cbDisplaySegmentGridlines.Name = "cbDisplaySegmentGridlines";
            this.cbDisplaySegmentGridlines.Size = new System.Drawing.Size(148, 17);
            this.cbDisplaySegmentGridlines.TabIndex = 3;
            this.cbDisplaySegmentGridlines.Text = "Display Segment Gridlines";
            this.cbDisplaySegmentGridlines.UseVisualStyleBackColor = true;
            this.cbDisplaySegmentGridlines.CheckedChanged += new System.EventHandler(this.cbDisplaySegmentGridlines_CheckedChanged);
            // 
            // lbSegEvery
            // 
            this.lbSegEvery.AutoSize = true;
            this.lbSegEvery.Location = new System.Drawing.Point(163, 23);
            this.lbSegEvery.Name = "lbSegEvery";
            this.lbSegEvery.Size = new System.Drawing.Size(79, 13);
            this.lbSegEvery.TabIndex = 5;
            this.lbSegEvery.Text = "Segment Every";
            // 
            // txtSegment
            // 
            this.txtSegment.Location = new System.Drawing.Point(166, 39);
            this.txtSegment.MaxLength = 2;
            this.txtSegment.Name = "txtSegment";
            this.txtSegment.Size = new System.Drawing.Size(34, 20);
            this.txtSegment.TabIndex = 6;
            this.txtSegment.TextChanged += new System.EventHandler(this.txtSegment_TextChanged);
            this.txtSegment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSegment_KeyPress);
            // 
            // lbSegLines
            // 
            this.lbSegLines.AutoSize = true;
            this.lbSegLines.Location = new System.Drawing.Point(204, 43);
            this.lbSegLines.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbSegLines.Name = "lbSegLines";
            this.lbSegLines.Size = new System.Drawing.Size(28, 13);
            this.lbSegLines.TabIndex = 7;
            this.lbSegLines.Text = "lines";
            // 
            // lbGridThicknessPx
            // 
            this.lbGridThicknessPx.AutoSize = true;
            this.lbGridThicknessPx.Location = new System.Drawing.Point(44, 43);
            this.lbGridThicknessPx.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbGridThicknessPx.Name = "lbGridThicknessPx";
            this.lbGridThicknessPx.Size = new System.Drawing.Size(18, 13);
            this.lbGridThicknessPx.TabIndex = 9;
            this.lbGridThicknessPx.Text = "px";
            // 
            // txtGridLine
            // 
            this.txtGridLine.Location = new System.Drawing.Point(6, 39);
            this.txtGridLine.MaxLength = 2;
            this.txtGridLine.Name = "txtGridLine";
            this.txtGridLine.Size = new System.Drawing.Size(34, 20);
            this.txtGridLine.TabIndex = 8;
            this.txtGridLine.TextChanged += new System.EventHandler(this.txtGridLine_TextChanged);
            this.txtGridLine.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGridLine_KeyPress);
            // 
            // txtSegThick
            // 
            this.txtSegThick.Location = new System.Drawing.Point(166, 82);
            this.txtSegThick.MaxLength = 2;
            this.txtSegThick.Name = "txtSegThick";
            this.txtSegThick.Size = new System.Drawing.Size(34, 20);
            this.txtSegThick.TabIndex = 11;
            this.txtSegThick.TextChanged += new System.EventHandler(this.txtSegThick_TextChanged);
            this.txtSegThick.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSegThick_KeyPress);
            // 
            // lbSegThickness
            // 
            this.lbSegThickness.AutoSize = true;
            this.lbSegThickness.Location = new System.Drawing.Point(163, 66);
            this.lbSegThickness.Name = "lbSegThickness";
            this.lbSegThickness.Size = new System.Drawing.Size(124, 13);
            this.lbSegThickness.TabIndex = 10;
            this.lbSegThickness.Text = "Segment Line Thickness";
            // 
            // lbSegPx
            // 
            this.lbSegPx.AutoSize = true;
            this.lbSegPx.Location = new System.Drawing.Point(204, 85);
            this.lbSegPx.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbSegPx.Name = "lbSegPx";
            this.lbSegPx.Size = new System.Drawing.Size(18, 13);
            this.lbSegPx.TabIndex = 12;
            this.lbSegPx.Text = "px";
            // 
            // GridControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lbSegPx);
            this.Controls.Add(this.txtSegThick);
            this.Controls.Add(this.lbSegThickness);
            this.Controls.Add(this.lbGridThicknessPx);
            this.Controls.Add(this.txtGridLine);
            this.Controls.Add(this.lbSegLines);
            this.Controls.Add(this.txtSegment);
            this.Controls.Add(this.lbSegEvery);
            this.Controls.Add(this.cbDisplaySegmentGridlines);
            this.Controls.Add(this.cbDisplayGrid);
            this.Controls.Add(this.lbGridThickness);
            this.Location = new System.Drawing.Point(20, 20);
            this.Name = "GridControls";
            this.Size = new System.Drawing.Size(334, 136);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbGridThickness;
        private System.Windows.Forms.CheckBox cbDisplayGrid;
        private System.Windows.Forms.CheckBox cbDisplaySegmentGridlines;
        private System.Windows.Forms.Label lbSegEvery;
        private System.Windows.Forms.TextBox txtSegment;
        private System.Windows.Forms.Label lbSegLines;
        private System.Windows.Forms.Label lbGridThicknessPx;
        private System.Windows.Forms.TextBox txtGridLine;
        private System.Windows.Forms.TextBox txtSegThick;
        private System.Windows.Forms.Label lbSegThickness;
        private System.Windows.Forms.Label lbSegPx;
    }
}
