﻿
namespace Game_of_Life
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.universeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uiTypeFininite = new System.Windows.Forms.ToolStripMenuItem();
            this.uiTypeInfinite = new System.Windows.Forms.ToolStripMenuItem();
            this.widthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uiXSize = new System.Windows.Forms.ToolStripTextBox();
            this.heightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uiYSize = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.uiUniverseRandomize = new System.Windows.Forms.ToolStripMenuItem();
            this.uiUniverseTypeSelection = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.playPauseButton = new System.Windows.Forms.ToolStripButton();
            this.uiNextFrame = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.slowDownButton = new System.Windows.Forms.ToolStripButton();
            this.speedMultiplier = new System.Windows.Forms.ToolStripLabel();
            this.speedUpButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelGenerations = new System.Windows.Forms.ToolStripStatusLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.graphicsPanel1 = new Game_of_Life.GraphicsPanel();
            this.propertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.uiUniverseTypeSelection.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.universeToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(573, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.propertiesToolStripMenuItem,
            this.toolStripSeparator4,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newUniverse_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(177, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.contentsToolStripMenuItem.Text = "&Contents";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(177, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // universeToolStripMenuItem
            // 
            this.universeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.toolStripSeparator9,
            this.uiUniverseRandomize});
            this.universeToolStripMenuItem.Name = "universeToolStripMenuItem";
            this.universeToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.universeToolStripMenuItem.Text = "Universe";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.typeToolStripMenuItem,
            this.widthToolStripMenuItem,
            this.heightToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.optionsToolStripMenuItem.Text = "Properties";
            // 
            // typeToolStripMenuItem
            // 
            this.typeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uiTypeFininite,
            this.uiTypeInfinite});
            this.typeToolStripMenuItem.Name = "typeToolStripMenuItem";
            this.typeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.typeToolStripMenuItem.Text = "Type";
            // 
            // uiTypeFininite
            // 
            this.uiTypeFininite.Image = global::Game_of_Life.Properties.Resources.aCheckMark;
            this.uiTypeFininite.Name = "uiTypeFininite";
            this.uiTypeFininite.Size = new System.Drawing.Size(111, 22);
            this.uiTypeFininite.Text = "Finite";
            // 
            // uiTypeInfinite
            // 
            this.uiTypeInfinite.Name = "uiTypeInfinite";
            this.uiTypeInfinite.Size = new System.Drawing.Size(111, 22);
            this.uiTypeInfinite.Text = "Infinite";
            // 
            // widthToolStripMenuItem
            // 
            this.widthToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uiXSize});
            this.widthToolStripMenuItem.Name = "widthToolStripMenuItem";
            this.widthToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.widthToolStripMenuItem.Text = "Width";
            this.widthToolStripMenuItem.DropDownOpening += new System.EventHandler(this.widthToolStripMenuItem_DropDownOpening);
            // 
            // uiXSize
            // 
            this.uiXSize.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uiXSize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.uiXSize.MaxLength = 3;
            this.uiXSize.Name = "uiXSize";
            this.uiXSize.Size = new System.Drawing.Size(45, 16);
            this.uiXSize.Tag = "uiWidth";
            this.uiXSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.size_KeyPress);
            // 
            // heightToolStripMenuItem
            // 
            this.heightToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uiYSize});
            this.heightToolStripMenuItem.Name = "heightToolStripMenuItem";
            this.heightToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.heightToolStripMenuItem.Text = "Height";
            this.heightToolStripMenuItem.DropDownOpening += new System.EventHandler(this.heightToolStripMenuItem_DropDownOpening);
            // 
            // uiYSize
            // 
            this.uiYSize.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uiYSize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.uiYSize.MaxLength = 3;
            this.uiYSize.Name = "uiYSize";
            this.uiYSize.Size = new System.Drawing.Size(45, 16);
            this.uiYSize.Tag = "uiHeight";
            this.uiYSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.size_KeyPress);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(177, 6);
            // 
            // uiUniverseRandomize
            // 
            this.uiUniverseRandomize.Name = "uiUniverseRandomize";
            this.uiUniverseRandomize.Size = new System.Drawing.Size(180, 22);
            this.uiUniverseRandomize.Text = "Randomize";
            this.uiUniverseRandomize.Click += new System.EventHandler(this.uiUniverseRandomize_Click);
            // 
            // uiUniverseTypeSelection
            // 
            this.uiUniverseTypeSelection.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.toolStripSeparator6,
            this.playPauseButton,
            this.uiNextFrame,
            this.toolStripSeparator3,
            this.slowDownButton,
            this.speedMultiplier,
            this.speedUpButton,
            this.toolStripSeparator7});
            this.uiUniverseTypeSelection.Location = new System.Drawing.Point(0, 24);
            this.uiUniverseTypeSelection.Name = "uiUniverseTypeSelection";
            this.uiUniverseTypeSelection.Size = new System.Drawing.Size(573, 25);
            this.uiUniverseTypeSelection.TabIndex = 1;
            this.uiUniverseTypeSelection.Text = "toolStrip1";
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.newToolStripButton.Text = "New Universe";
            this.newToolStripButton.Click += new System.EventHandler(this.newUniverse_Click);
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.openToolStripButton.Text = "&Open";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "&Save";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // playPauseButton
            // 
            this.playPauseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.playPauseButton.Image = global::Game_of_Life.Properties.Resources.aPlay;
            this.playPauseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.playPauseButton.Name = "playPauseButton";
            this.playPauseButton.Size = new System.Drawing.Size(23, 22);
            this.playPauseButton.Text = "play / pause";
            this.playPauseButton.ToolTipText = "Play / Pause";
            this.playPauseButton.Click += new System.EventHandler(this.playPauseButton_Click);
            // 
            // uiNextFrame
            // 
            this.uiNextFrame.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.uiNextFrame.Image = global::Game_of_Life.Properties.Resources.aNext;
            this.uiNextFrame.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.uiNextFrame.Name = "uiNextFrame";
            this.uiNextFrame.Size = new System.Drawing.Size(23, 22);
            this.uiNextFrame.Text = "Next";
            this.uiNextFrame.Click += new System.EventHandler(this.uiNextFrame_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // slowDownButton
            // 
            this.slowDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.slowDownButton.Image = global::Game_of_Life.Properties.Resources.aRewind;
            this.slowDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.slowDownButton.Name = "slowDownButton";
            this.slowDownButton.Size = new System.Drawing.Size(23, 22);
            this.slowDownButton.Text = "Slow Down";
            this.slowDownButton.ToolTipText = "Slow Down";
            this.slowDownButton.Click += new System.EventHandler(this.slowDownButton_Click);
            // 
            // speedMultiplier
            // 
            this.speedMultiplier.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.speedMultiplier.Name = "speedMultiplier";
            this.speedMultiplier.Size = new System.Drawing.Size(38, 22);
            this.speedMultiplier.Text = "1.00x";
            // 
            // speedUpButton
            // 
            this.speedUpButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.speedUpButton.Image = global::Game_of_Life.Properties.Resources.aFastForward;
            this.speedUpButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.speedUpButton.Name = "speedUpButton";
            this.speedUpButton.Size = new System.Drawing.Size(23, 22);
            this.speedUpButton.Text = "Speed Up";
            this.speedUpButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.speedUpButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.speedUpButton.Click += new System.EventHandler(this.speedUpButton_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelGenerations});
            this.statusStrip1.Location = new System.Drawing.Point(0, 323);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(573, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelGenerations
            // 
            this.toolStripStatusLabelGenerations.Name = "toolStripStatusLabelGenerations";
            this.toolStripStatusLabelGenerations.Size = new System.Drawing.Size(90, 17);
            this.toolStripStatusLabelGenerations.Text = "Generations = 0";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // graphicsPanel1
            // 
            this.graphicsPanel1.BackColor = System.Drawing.SystemColors.Window;
            this.graphicsPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graphicsPanel1.Location = new System.Drawing.Point(0, 49);
            this.graphicsPanel1.Name = "graphicsPanel1";
            this.graphicsPanel1.Size = new System.Drawing.Size(573, 274);
            this.graphicsPanel1.TabIndex = 3;
            this.graphicsPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.graphicsPanel1_Paint);
            this.graphicsPanel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.graphicsPanel1_MouseClick);
            this.graphicsPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.graphicsPanel1_MouseDown);
            // 
            // propertiesToolStripMenuItem
            // 
            this.propertiesToolStripMenuItem.Name = "propertiesToolStripMenuItem";
            this.propertiesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.propertiesToolStripMenuItem.Text = "Properties";
            this.propertiesToolStripMenuItem.Click += new System.EventHandler(this.propertiesToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(177, 6);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 345);
            this.Controls.Add(this.graphicsPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.uiUniverseTypeSelection);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "Game of Life";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.uiUniverseTypeSelection.ResumeLayout(false);
            this.uiUniverseTypeSelection.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip uiUniverseTypeSelection;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private GraphicsPanel graphicsPanel1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelGenerations;
        private System.Windows.Forms.ToolStripButton playPauseButton;
        private System.Windows.Forms.ToolStripButton slowDownButton;
        private System.Windows.Forms.ToolStripButton speedUpButton;
        private System.Windows.Forms.ToolStripLabel speedMultiplier;
        private System.Windows.Forms.ToolStripMenuItem universeToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton uiNextFrame;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem typeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uiTypeFininite;
        private System.Windows.Forms.ToolStripMenuItem uiTypeInfinite;
        private System.Windows.Forms.ToolStripMenuItem widthToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox uiXSize;
        private System.Windows.Forms.ToolStripMenuItem heightToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox uiYSize;
        private System.Windows.Forms.ToolStripMenuItem uiUniverseRandomize;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolStripMenuItem propertiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    }
}

