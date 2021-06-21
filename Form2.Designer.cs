
namespace Game_of_Life
{
    partial class Form2
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Panel Defaults", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Window", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("Miscellaneous", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Colors");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Grid");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Fonts");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Randomization");
            this.lwProperties = new System.Windows.Forms.ListView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.grpProperties = new System.Windows.Forms.GroupBox();
            this.btnRestoreDefaults = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lwProperties
            // 
            this.lwProperties.FullRowSelect = true;
            listViewGroup1.Header = "Panel Defaults";
            listViewGroup1.Name = "grpPanel";
            listViewGroup2.Header = "Window";
            listViewGroup2.Name = "grpWindow";
            listViewGroup3.Header = "Miscellaneous";
            listViewGroup3.Name = "grpApplication";
            this.lwProperties.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3});
            this.lwProperties.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lwProperties.HideSelection = false;
            listViewItem1.Group = listViewGroup1;
            listViewItem2.Group = listViewGroup1;
            listViewItem3.Group = listViewGroup1;
            listViewItem4.Group = listViewGroup3;
            this.lwProperties.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4});
            this.lwProperties.Location = new System.Drawing.Point(12, 12);
            this.lwProperties.Name = "lwProperties";
            this.lwProperties.Size = new System.Drawing.Size(121, 426);
            this.lwProperties.TabIndex = 0;
            this.lwProperties.TileSize = new System.Drawing.Size(110, 20);
            this.lwProperties.UseCompatibleStateImageBehavior = false;
            this.lwProperties.View = System.Windows.Forms.View.Tile;
            this.lwProperties.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lwProperties_ItemSelectionChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(713, 415);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(632, 415);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // grpProperties
            // 
            this.grpProperties.Location = new System.Drawing.Point(140, 13);
            this.grpProperties.Name = "grpProperties";
            this.grpProperties.Size = new System.Drawing.Size(648, 396);
            this.grpProperties.TabIndex = 4;
            this.grpProperties.TabStop = false;
            this.grpProperties.Text = "groupBox1";
            // 
            // btnRestoreDefaults
            // 
            this.btnRestoreDefaults.AutoSize = true;
            this.btnRestoreDefaults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestoreDefaults.Location = new System.Drawing.Point(140, 415);
            this.btnRestoreDefaults.Name = "btnRestoreDefaults";
            this.btnRestoreDefaults.Size = new System.Drawing.Size(98, 25);
            this.btnRestoreDefaults.TabIndex = 5;
            this.btnRestoreDefaults.Text = "Restore Defaults";
            this.btnRestoreDefaults.UseVisualStyleBackColor = true;
            this.btnRestoreDefaults.Click += new System.EventHandler(this.btnRestoreDefaults_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRestoreDefaults);
            this.Controls.Add(this.grpProperties);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lwProperties);
            this.Name = "Form2";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lwProperties;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.GroupBox grpProperties;
        private System.Windows.Forms.Button btnRestoreDefaults;
    }
}