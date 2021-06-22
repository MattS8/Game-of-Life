
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
            this.propertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemView = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemViewGrid = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemNeighborCount = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemViewHeadsUpDisplay = new System.Windows.Forms.ToolStripMenuItem();
            this.universeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nameInputToolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.typeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uiTypeFininite = new System.Windows.Forms.ToolStripMenuItem();
            this.uiTypeTorodial = new System.Windows.Forms.ToolStripMenuItem();
            this.widthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uiXSize = new System.Windows.Forms.ToolStripTextBox();
            this.heightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uiYSize = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.uiUniverseRandomize = new System.Windows.Forms.ToolStripMenuItem();
            this.tooltipMenuItemRandomizeManualSeed = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simulationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeSpeedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uiUniverseToolStrip = new System.Windows.Forms.ToolStrip();
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
            this.toolStripStatusLabelLivingCells = new System.Windows.Forms.ToolStripStatusLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelGraphicsBG = new System.Windows.Forms.Panel();
            this.graphicsPanel1 = new Game_of_Life.GraphicsPanel();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextGridColor = new System.Windows.Forms.ToolStripMenuItem();
            this.contextDeadCellColor = new System.Windows.Forms.ToolStripMenuItem();
            this.contextAliveCellColor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.uiUniverseToolStrip.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panelGraphicsBG.SuspendLayout();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolStripMenuItemView,
            this.simulationToolStripMenuItem,
            this.universeToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1204, 24);
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
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openUniverse_Click);
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
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveUniverse_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveUniverseAs_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // propertiesToolStripMenuItem
            // 
            this.propertiesToolStripMenuItem.Name = "propertiesToolStripMenuItem";
            this.propertiesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.propertiesToolStripMenuItem.Text = "Settings";
            this.propertiesToolStripMenuItem.Click += new System.EventHandler(this.propertiesToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripMenuItemView
            // 
            this.toolStripMenuItemView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemViewGrid,
            this.toolStripMenuItemNeighborCount,
            this.toolStripMenuItemViewHeadsUpDisplay});
            this.toolStripMenuItemView.Name = "toolStripMenuItemView";
            this.toolStripMenuItemView.Size = new System.Drawing.Size(44, 20);
            this.toolStripMenuItemView.Text = "View";
            // 
            // toolStripMenuItemViewGrid
            // 
            this.toolStripMenuItemViewGrid.Name = "toolStripMenuItemViewGrid";
            this.toolStripMenuItemViewGrid.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemViewGrid.Text = "Grid";
            this.toolStripMenuItemViewGrid.Click += new System.EventHandler(this.toolStripMenuItemViewGrid_Click);
            // 
            // toolStripMenuItemNeighborCount
            // 
            this.toolStripMenuItemNeighborCount.Name = "toolStripMenuItemNeighborCount";
            this.toolStripMenuItemNeighborCount.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemNeighborCount.Text = "Neighbor Count";
            this.toolStripMenuItemNeighborCount.Click += new System.EventHandler(this.toolStripMenuItemNeighborCount_Click);
            // 
            // toolStripMenuItemViewHeadsUpDisplay
            // 
            this.toolStripMenuItemViewHeadsUpDisplay.Name = "toolStripMenuItemViewHeadsUpDisplay";
            this.toolStripMenuItemViewHeadsUpDisplay.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemViewHeadsUpDisplay.Text = "Heads Up Display";
            this.toolStripMenuItemViewHeadsUpDisplay.Click += new System.EventHandler(this.toolStripMenuItemViewHeadsUpDisplay_Click);
            // 
            // universeToolStripMenuItem
            // 
            this.universeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.toolStripSeparator9,
            this.uiUniverseRandomize,
            this.tooltipMenuItemRandomizeManualSeed});
            this.universeToolStripMenuItem.Name = "universeToolStripMenuItem";
            this.universeToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.universeToolStripMenuItem.Text = "Universe";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nameToolStripMenuItem,
            this.typeToolStripMenuItem,
            this.widthToolStripMenuItem,
            this.heightToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.optionsToolStripMenuItem.Text = "Properties";
            // 
            // nameToolStripMenuItem
            // 
            this.nameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nameInputToolStripTextBox1});
            this.nameToolStripMenuItem.Name = "nameToolStripMenuItem";
            this.nameToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.nameToolStripMenuItem.Text = "&Name";
            // 
            // nameInputToolStripTextBox1
            // 
            this.nameInputToolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nameInputToolStripTextBox1.Name = "nameInputToolStripTextBox1";
            this.nameInputToolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            this.nameInputToolStripTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameInputToolStripTextBox1_KeyPress);
            // 
            // typeToolStripMenuItem
            // 
            this.typeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uiTypeFininite,
            this.uiTypeTorodial});
            this.typeToolStripMenuItem.Name = "typeToolStripMenuItem";
            this.typeToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.typeToolStripMenuItem.Text = "Type";
            // 
            // uiTypeFininite
            // 
            this.uiTypeFininite.Name = "uiTypeFininite";
            this.uiTypeFininite.Size = new System.Drawing.Size(116, 22);
            this.uiTypeFininite.Text = "Finite";
            this.uiTypeFininite.Click += new System.EventHandler(this.uiTypeFininite_Click);
            // 
            // uiTypeTorodial
            // 
            this.uiTypeTorodial.Name = "uiTypeTorodial";
            this.uiTypeTorodial.Size = new System.Drawing.Size(116, 22);
            this.uiTypeTorodial.Text = "Torodial";
            this.uiTypeTorodial.Click += new System.EventHandler(this.uiTypeTorodial_Click);
            // 
            // widthToolStripMenuItem
            // 
            this.widthToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uiXSize});
            this.widthToolStripMenuItem.Name = "widthToolStripMenuItem";
            this.widthToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
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
            this.heightToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
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
            this.toolStripSeparator9.Size = new System.Drawing.Size(209, 6);
            // 
            // uiUniverseRandomize
            // 
            this.uiUniverseRandomize.Name = "uiUniverseRandomize";
            this.uiUniverseRandomize.Size = new System.Drawing.Size(212, 22);
            this.uiUniverseRandomize.Text = "Randomize";
            this.uiUniverseRandomize.Click += new System.EventHandler(this.uiUniverseRandomize_Click);
            // 
            // tooltipMenuItemRandomizeManualSeed
            // 
            this.tooltipMenuItemRandomizeManualSeed.Name = "tooltipMenuItemRandomizeManualSeed";
            this.tooltipMenuItemRandomizeManualSeed.Size = new System.Drawing.Size(212, 22);
            this.tooltipMenuItemRandomizeManualSeed.Text = "Randomize (Manual Seed)";
            this.tooltipMenuItemRandomizeManualSeed.Click += new System.EventHandler(this.toolStripMenuItemRandomizeManualSeed_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // simulationToolStripMenuItem
            // 
            this.simulationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeSpeedToolStripMenuItem});
            this.simulationToolStripMenuItem.Name = "simulationToolStripMenuItem";
            this.simulationToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.simulationToolStripMenuItem.Text = "Simulation";
            // 
            // changeSpeedToolStripMenuItem
            // 
            this.changeSpeedToolStripMenuItem.Name = "changeSpeedToolStripMenuItem";
            this.changeSpeedToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.changeSpeedToolStripMenuItem.Text = "Change Speed";
            this.changeSpeedToolStripMenuItem.Click += new System.EventHandler(this.changeSpeedToolStripMenuItem_Click);
            // 
            // uiUniverseToolStrip
            // 
            this.uiUniverseToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.uiUniverseToolStrip.Location = new System.Drawing.Point(0, 24);
            this.uiUniverseToolStrip.Name = "uiUniverseToolStrip";
            this.uiUniverseToolStrip.Size = new System.Drawing.Size(1204, 25);
            this.uiUniverseToolStrip.TabIndex = 1;
            this.uiUniverseToolStrip.Text = "toolStrip1";
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
            this.openToolStripButton.Click += new System.EventHandler(this.openUniverse_Click);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveUniverse_Click);
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
            this.toolStripStatusLabelGenerations,
            this.toolStripStatusLabelLivingCells});
            this.statusStrip1.Location = new System.Drawing.Point(0, 823);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1204, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelGenerations
            // 
            this.toolStripStatusLabelGenerations.Name = "toolStripStatusLabelGenerations";
            this.toolStripStatusLabelGenerations.Size = new System.Drawing.Size(90, 17);
            this.toolStripStatusLabelGenerations.Text = "Generations = 0";
            // 
            // toolStripStatusLabelLivingCells
            // 
            this.toolStripStatusLabelLivingCells.Name = "toolStripStatusLabelLivingCells";
            this.toolStripStatusLabelLivingCells.Size = new System.Drawing.Size(87, 17);
            this.toolStripStatusLabelLivingCells.Text = "Living Cells = 0";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panelGraphicsBG
            // 
            this.panelGraphicsBG.Controls.Add(this.graphicsPanel1);
            this.panelGraphicsBG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGraphicsBG.Location = new System.Drawing.Point(0, 49);
            this.panelGraphicsBG.Name = "panelGraphicsBG";
            this.panelGraphicsBG.Padding = new System.Windows.Forms.Padding(15);
            this.panelGraphicsBG.Size = new System.Drawing.Size(1204, 774);
            this.panelGraphicsBG.TabIndex = 4;
            // 
            // graphicsPanel1
            // 
            this.graphicsPanel1.BackColor = System.Drawing.SystemColors.Window;
            this.graphicsPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graphicsPanel1.Location = new System.Drawing.Point(15, 15);
            this.graphicsPanel1.Name = "graphicsPanel1";
            this.graphicsPanel1.Size = new System.Drawing.Size(1174, 744);
            this.graphicsPanel1.TabIndex = 4;
            this.graphicsPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.graphicsPanel1_Paint);
            this.graphicsPanel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.graphicsPanel1_MouseClick);
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextGridColor,
            this.contextDeadCellColor,
            this.contextAliveCellColor});
            this.contextMenu.Name = "contextMenuStrip1";
            this.contextMenu.Size = new System.Drawing.Size(157, 70);
            // 
            // contextGridColor
            // 
            this.contextGridColor.Name = "contextGridColor";
            this.contextGridColor.Size = new System.Drawing.Size(156, 22);
            this.contextGridColor.Text = "Grid Color";
            this.contextGridColor.Click += new System.EventHandler(this.gridColorToolStripMenuItem_Click);
            // 
            // contextDeadCellColor
            // 
            this.contextDeadCellColor.Name = "contextDeadCellColor";
            this.contextDeadCellColor.Size = new System.Drawing.Size(156, 22);
            this.contextDeadCellColor.Text = "Dead Cell Color";
            this.contextDeadCellColor.Click += new System.EventHandler(this.contextDeadCellColor_Click);
            // 
            // contextAliveCellColor
            // 
            this.contextAliveCellColor.Name = "contextAliveCellColor";
            this.contextAliveCellColor.Size = new System.Drawing.Size(156, 22);
            this.contextAliveCellColor.Text = "Alive Cell Color";
            this.contextAliveCellColor.Click += new System.EventHandler(this.contextAliveCellColor_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 845);
            this.Controls.Add(this.panelGraphicsBG);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.uiUniverseToolStrip);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "Game of Life";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.uiUniverseToolStrip.ResumeLayout(false);
            this.uiUniverseToolStrip.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panelGraphicsBG.ResumeLayout(false);
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip uiUniverseToolStrip;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
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
        private System.Windows.Forms.ToolStripMenuItem uiTypeTorodial;
        private System.Windows.Forms.ToolStripMenuItem widthToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox uiXSize;
        private System.Windows.Forms.ToolStripMenuItem heightToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox uiYSize;
        private System.Windows.Forms.ToolStripMenuItem uiUniverseRandomize;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolStripMenuItem propertiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemView;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemViewGrid;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemNeighborCount;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemViewHeadsUpDisplay;
        private System.Windows.Forms.ToolStripMenuItem nameToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelLivingCells;
        private System.Windows.Forms.ToolStripTextBox nameInputToolStripTextBox1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Panel panelGraphicsBG;
        private GraphicsPanel graphicsPanel1;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem contextGridColor;
        private System.Windows.Forms.ToolStripMenuItem contextDeadCellColor;
        private System.Windows.Forms.ToolStripMenuItem contextAliveCellColor;
        private System.Windows.Forms.ToolStripMenuItem tooltipMenuItemRandomizeManualSeed;
        private System.Windows.Forms.ToolStripMenuItem simulationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeSpeedToolStripMenuItem;
    }
}

