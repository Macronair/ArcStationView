
namespace Arc_Station_View.Windows
{
    partial class MainScreen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.dataViewer = new System.Windows.Forms.DataGridView();
            this.txtArtist = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblArtist = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tabViews = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dmnRange = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tlblTotal = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tlblSelected = new System.Windows.Forms.ToolStripStatusLabel();
            this.tlblSearch = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.appToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.goToTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goToBottomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiInsertRecord = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditRecord = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeleteRecord = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.cSVTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tstrSettings = new System.Windows.Forms.ToolStripButton();
            this.tstrAdd = new System.Windows.Forms.ToolStripButton();
            this.tstrEdit = new System.Windows.Forms.ToolStripButton();
            this.tstrDelete = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewer)).BeginInit();
            this.tabViews.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataViewer
            // 
            this.dataViewer.AllowUserToAddRows = false;
            this.dataViewer.AllowUserToDeleteRows = false;
            this.dataViewer.AllowUserToResizeRows = false;
            this.dataViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataViewer.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataViewer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataViewer.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataViewer.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataViewer.Location = new System.Drawing.Point(3, 32);
            this.dataViewer.MultiSelect = false;
            this.dataViewer.Name = "dataViewer";
            this.dataViewer.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataViewer.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataViewer.RowHeadersVisible = false;
            this.dataViewer.RowHeadersWidth = 82;
            this.dataViewer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataViewer.ShowCellToolTips = false;
            this.dataViewer.Size = new System.Drawing.Size(1588, 679);
            this.dataViewer.TabIndex = 0;
            this.dataViewer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataViewer_CellClick);
            this.dataViewer.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataViewer_CellMouseDoubleClick);
            this.dataViewer.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataViewer_ColumnHeaderMouseClick);
            this.dataViewer.SelectionChanged += new System.EventHandler(this.dataViewer_SelectionChanged);
            this.dataViewer.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataViewer_MouseClick);
            // 
            // txtArtist
            // 
            this.txtArtist.BackColor = System.Drawing.SystemColors.Window;
            this.txtArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArtist.ForeColor = System.Drawing.Color.Black;
            this.txtArtist.Location = new System.Drawing.Point(54, 6);
            this.txtArtist.Name = "txtArtist";
            this.txtArtist.Size = new System.Drawing.Size(285, 20);
            this.txtArtist.TabIndex = 1;
            this.txtArtist.TextChanged += new System.EventHandler(this.txtArtist_TextChanged);
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.SystemColors.Window;
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.ForeColor = System.Drawing.Color.Black;
            this.txtTitle.Location = new System.Drawing.Point(378, 6);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(285, 20);
            this.txtTitle.TabIndex = 2;
            this.txtTitle.TextChanged += new System.EventHandler(this.txtTitle_TextChanged);
            // 
            // lblArtist
            // 
            this.lblArtist.AutoSize = true;
            this.lblArtist.BackColor = System.Drawing.Color.Transparent;
            this.lblArtist.ForeColor = System.Drawing.Color.Black;
            this.lblArtist.Location = new System.Drawing.Point(12, 9);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(36, 13);
            this.lblArtist.TabIndex = 3;
            this.lblArtist.Text = "Artiest";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(345, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Titel";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(796, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Zoeken";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tabViews
            // 
            this.tabViews.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabViews.Controls.Add(this.tabPage1);
            this.tabViews.Location = new System.Drawing.Point(0, 66);
            this.tabViews.Name = "tabViews";
            this.tabViews.SelectedIndex = 0;
            this.tabViews.Size = new System.Drawing.Size(1602, 743);
            this.tabViews.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tabPage1.Controls.Add(this.dmnRange);
            this.tabPage1.Controls.Add(this.dataViewer);
            this.tabPage1.Controls.Add(this.txtArtist);
            this.tabPage1.Controls.Add(this.btnSearch);
            this.tabPage1.Controls.Add(this.txtTitle);
            this.tabPage1.Controls.Add(this.lblTitle);
            this.tabPage1.Controls.Add(this.lblArtist);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1594, 717);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tracklist";
            // 
            // dmnRange
            // 
            this.dmnRange.BackColor = System.Drawing.SystemColors.Window;
            this.dmnRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dmnRange.FormattingEnabled = true;
            this.dmnRange.Items.AddRange(new object[] {
            "Totaal",
            "Deze week",
            "Deze maand",
            "Dit jaar"});
            this.dmnRange.Location = new System.Drawing.Point(669, 5);
            this.dmnRange.Name = "dmnRange";
            this.dmnRange.Size = new System.Drawing.Size(121, 21);
            this.dmnRange.TabIndex = 8;
            this.dmnRange.Text = "Totaal";
            this.dmnRange.TextChanged += new System.EventHandler(this.dmnRange_TextChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.DimGray;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tlblTotal,
            this.toolStripStatusLabel3,
            this.tlblSelected,
            this.tlblSearch});
            this.statusStrip1.Location = new System.Drawing.Point(0, 812);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1602, 26);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(43, 21);
            this.toolStripStatusLabel1.Text = "Totaal:";
            // 
            // tlblTotal
            // 
            this.tlblTotal.BackColor = System.Drawing.Color.Transparent;
            this.tlblTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlblTotal.ForeColor = System.Drawing.Color.White;
            this.tlblTotal.Name = "tlblTotal";
            this.tlblTotal.Size = new System.Drawing.Size(19, 21);
            this.tlblTotal.Text = "0";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel3.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(85, 21);
            this.toolStripStatusLabel3.Text = "Geselecteerd:";
            // 
            // tlblSelected
            // 
            this.tlblSelected.BackColor = System.Drawing.Color.Transparent;
            this.tlblSelected.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlblSelected.ForeColor = System.Drawing.Color.White;
            this.tlblSelected.Name = "tlblSelected";
            this.tlblSelected.Size = new System.Drawing.Size(19, 21);
            this.tlblSelected.Text = "0";
            // 
            // tlblSearch
            // 
            this.tlblSearch.ForeColor = System.Drawing.Color.Yellow;
            this.tlblSearch.Name = "tlblSearch";
            this.tlblSearch.Size = new System.Drawing.Size(56, 21);
            this.tlblSearch.Text = "Search: - ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.appToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.dataToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1602, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // appToolStripMenuItem
            // 
            this.appToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.appToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.databaseToolStripMenuItem,
            this.toolStripSeparator1,
            this.closeToolStripMenuItem});
            this.appToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.appToolStripMenuItem.Name = "appToolStripMenuItem";
            this.appToolStripMenuItem.Size = new System.Drawing.Size(41, 22);
            this.appToolStripMenuItem.Text = "App";
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("databaseToolStripMenuItem.Image")));
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.databaseToolStripMenuItem.Text = "Settings";
            this.databaseToolStripMenuItem.Click += new System.EventHandler(this.databaseToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(117, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("closeToolStripMenuItem.Image")));
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.toolStripMenuItem1,
            this.goToTopToolStripMenuItem,
            this.goToBottomToolStripMenuItem,
            this.toolStripMenuItem2,
            this.searchToolStripMenuItem});
            this.viewToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("refreshToolStripMenuItem.Image")));
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(143, 6);
            // 
            // goToTopToolStripMenuItem
            // 
            this.goToTopToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("goToTopToolStripMenuItem.Image")));
            this.goToTopToolStripMenuItem.Name = "goToTopToolStripMenuItem";
            this.goToTopToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.goToTopToolStripMenuItem.Text = "Go to top";
            this.goToTopToolStripMenuItem.Click += new System.EventHandler(this.goToTopToolStripMenuItem_Click);
            // 
            // goToBottomToolStripMenuItem
            // 
            this.goToBottomToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("goToBottomToolStripMenuItem.Image")));
            this.goToBottomToolStripMenuItem.Name = "goToBottomToolStripMenuItem";
            this.goToBottomToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.goToBottomToolStripMenuItem.Text = "Go to bottom";
            this.goToBottomToolStripMenuItem.Click += new System.EventHandler(this.goToBottomToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(143, 6);
            this.toolStripMenuItem2.Visible = false;
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Enabled = false;
            this.searchToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("searchToolStripMenuItem.Image")));
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.searchToolStripMenuItem.Text = "Search";
            this.searchToolStripMenuItem.Visible = false;
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiInsertRecord,
            this.tsmiEditRecord,
            this.tsmiDeleteRecord,
            this.toolStripMenuItem3,
            this.cSVTestToolStripMenuItem});
            this.dataToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(43, 22);
            this.dataToolStripMenuItem.Text = "Data";
            // 
            // tsmiInsertRecord
            // 
            this.tsmiInsertRecord.Image = ((System.Drawing.Image)(resources.GetObject("tsmiInsertRecord.Image")));
            this.tsmiInsertRecord.Name = "tsmiInsertRecord";
            this.tsmiInsertRecord.Size = new System.Drawing.Size(144, 22);
            this.tsmiInsertRecord.Text = "Insert record";
            this.tsmiInsertRecord.Click += new System.EventHandler(this.tsmiInsertRecord_Click);
            // 
            // tsmiEditRecord
            // 
            this.tsmiEditRecord.Enabled = false;
            this.tsmiEditRecord.Image = ((System.Drawing.Image)(resources.GetObject("tsmiEditRecord.Image")));
            this.tsmiEditRecord.Name = "tsmiEditRecord";
            this.tsmiEditRecord.Size = new System.Drawing.Size(144, 22);
            this.tsmiEditRecord.Text = "Edit record";
            this.tsmiEditRecord.Click += new System.EventHandler(this.tsmiEditRecord_Click);
            // 
            // tsmiDeleteRecord
            // 
            this.tsmiDeleteRecord.Enabled = false;
            this.tsmiDeleteRecord.Image = ((System.Drawing.Image)(resources.GetObject("tsmiDeleteRecord.Image")));
            this.tsmiDeleteRecord.Name = "tsmiDeleteRecord";
            this.tsmiDeleteRecord.Size = new System.Drawing.Size(144, 22);
            this.tsmiDeleteRecord.Text = "Delete record";
            this.tsmiDeleteRecord.Click += new System.EventHandler(this.tsmiDeleteRecord_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(141, 6);
            // 
            // cSVTestToolStripMenuItem
            // 
            this.cSVTestToolStripMenuItem.Name = "cSVTestToolStripMenuItem";
            this.cSVTestToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.cSVTestToolStripMenuItem.Text = "CSV Test";
            this.cSVTestToolStripMenuItem.Click += new System.EventHandler(this.cSVTestToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstrSettings,
            this.tstrAdd,
            this.tstrEdit,
            this.tstrDelete});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1602, 39);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "Menu";
            // 
            // tstrSettings
            // 
            this.tstrSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tstrSettings.Image = ((System.Drawing.Image)(resources.GetObject("tstrSettings.Image")));
            this.tstrSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstrSettings.Name = "tstrSettings";
            this.tstrSettings.Size = new System.Drawing.Size(36, 36);
            this.tstrSettings.Text = "Settings";
            this.tstrSettings.Click += new System.EventHandler(this.tstrSettings_Click);
            // 
            // tstrAdd
            // 
            this.tstrAdd.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tstrAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tstrAdd.Image = ((System.Drawing.Image)(resources.GetObject("tstrAdd.Image")));
            this.tstrAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstrAdd.Name = "tstrAdd";
            this.tstrAdd.Size = new System.Drawing.Size(65, 36);
            this.tstrAdd.Text = "Add";
            this.tstrAdd.Click += new System.EventHandler(this.tstrAdd_Click);
            // 
            // tstrEdit
            // 
            this.tstrEdit.Enabled = false;
            this.tstrEdit.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tstrEdit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tstrEdit.Image = ((System.Drawing.Image)(resources.GetObject("tstrEdit.Image")));
            this.tstrEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstrEdit.Name = "tstrEdit";
            this.tstrEdit.Size = new System.Drawing.Size(65, 36);
            this.tstrEdit.Text = "Edit";
            this.tstrEdit.Click += new System.EventHandler(this.tstrEdit_Click);
            // 
            // tstrDelete
            // 
            this.tstrDelete.Enabled = false;
            this.tstrDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tstrDelete.Image = ((System.Drawing.Image)(resources.GetObject("tstrDelete.Image")));
            this.tstrDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstrDelete.Name = "tstrDelete";
            this.tstrDelete.Size = new System.Drawing.Size(76, 36);
            this.tstrDelete.Text = "Delete";
            this.tstrDelete.Click += new System.EventHandler(this.tstrDelete_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1602, 838);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tabViews);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name = "MainScreen";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arc Station Viewer";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataViewer)).EndInit();
            this.tabViews.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataViewer;
        private System.Windows.Forms.TextBox txtArtist;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblArtist;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TabControl tabViews;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox dmnRange;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tlblTotal;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel tlblSelected;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem appToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem goToTopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goToBottomToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiInsertRecord;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditRecord;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeleteRecord;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tstrSettings;
        private System.Windows.Forms.ToolStripButton tstrEdit;
        public System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ToolStripButton tstrAdd;
        private System.Windows.Forms.ToolStripButton tstrDelete;
        private System.Windows.Forms.ToolStripStatusLabel tlblSearch;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem cSVTestToolStripMenuItem;
    }
}