
namespace Arc_Station_View.Windows.csv
{
    partial class CSVtest
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataCSV = new System.Windows.Forms.DataGridView();
            this.btnLoad = new System.Windows.Forms.Button();
            this.dataCSV2 = new System.Windows.Forms.DataGridView();
            this.btnOldCSV = new System.Windows.Forms.Button();
            this.btnNewCSV = new System.Windows.Forms.Button();
            this.txtOldCSV = new System.Windows.Forms.TextBox();
            this.txtNewCSV = new System.Windows.Forms.TextBox();
            this.lblOldCSV = new System.Windows.Forms.Label();
            this.lblNewCSV = new System.Windows.Forms.Label();
            this.chkOldHeaders = new System.Windows.Forms.CheckBox();
            this.chkNewHeaders = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nmrTotalSongs = new System.Windows.Forms.NumericUpDown();
            this.txtSorting = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLoadNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataCSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataCSV2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrTotalSongs)).BeginInit();
            this.SuspendLayout();
            // 
            // dataCSV
            // 
            this.dataCSV.AllowUserToAddRows = false;
            this.dataCSV.AllowUserToDeleteRows = false;
            this.dataCSV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataCSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCSV.Location = new System.Drawing.Point(1252, 12);
            this.dataCSV.Name = "dataCSV";
            this.dataCSV.ReadOnly = true;
            this.dataCSV.Size = new System.Drawing.Size(26, 27);
            this.dataCSV.TabIndex = 0;
            this.dataCSV.Visible = false;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(1157, 12);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 45);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load chart";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // dataCSV2
            // 
            this.dataCSV2.AllowUserToAddRows = false;
            this.dataCSV2.AllowUserToDeleteRows = false;
            this.dataCSV2.AllowUserToResizeRows = false;
            this.dataCSV2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataCSV2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataCSV2.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataCSV2.Location = new System.Drawing.Point(12, 74);
            this.dataCSV2.Name = "dataCSV2";
            this.dataCSV2.ReadOnly = true;
            this.dataCSV2.RowHeadersVisible = false;
            this.dataCSV2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataCSV2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataCSV2.Size = new System.Drawing.Size(1266, 712);
            this.dataCSV2.TabIndex = 2;
            // 
            // btnOldCSV
            // 
            this.btnOldCSV.Location = new System.Drawing.Point(968, 10);
            this.btnOldCSV.Name = "btnOldCSV";
            this.btnOldCSV.Size = new System.Drawing.Size(75, 23);
            this.btnOldCSV.TabIndex = 3;
            this.btnOldCSV.Text = "Browse...";
            this.btnOldCSV.UseVisualStyleBackColor = true;
            this.btnOldCSV.Click += new System.EventHandler(this.btnOldCSV_Click);
            // 
            // btnNewCSV
            // 
            this.btnNewCSV.Location = new System.Drawing.Point(968, 35);
            this.btnNewCSV.Name = "btnNewCSV";
            this.btnNewCSV.Size = new System.Drawing.Size(75, 23);
            this.btnNewCSV.TabIndex = 4;
            this.btnNewCSV.Text = "Browse...";
            this.btnNewCSV.UseVisualStyleBackColor = true;
            this.btnNewCSV.Click += new System.EventHandler(this.btnNewCSV_Click);
            // 
            // txtOldCSV
            // 
            this.txtOldCSV.Location = new System.Drawing.Point(697, 12);
            this.txtOldCSV.Name = "txtOldCSV";
            this.txtOldCSV.ReadOnly = true;
            this.txtOldCSV.Size = new System.Drawing.Size(265, 20);
            this.txtOldCSV.TabIndex = 5;
            // 
            // txtNewCSV
            // 
            this.txtNewCSV.Location = new System.Drawing.Point(697, 37);
            this.txtNewCSV.Name = "txtNewCSV";
            this.txtNewCSV.ReadOnly = true;
            this.txtNewCSV.Size = new System.Drawing.Size(265, 20);
            this.txtNewCSV.TabIndex = 6;
            // 
            // lblOldCSV
            // 
            this.lblOldCSV.AutoSize = true;
            this.lblOldCSV.Location = new System.Drawing.Point(585, 15);
            this.lblOldCSV.Name = "lblOldCSV";
            this.lblOldCSV.Size = new System.Drawing.Size(106, 13);
            this.lblOldCSV.TabIndex = 7;
            this.lblOldCSV.Text = "Old CSV file location:";
            // 
            // lblNewCSV
            // 
            this.lblNewCSV.AutoSize = true;
            this.lblNewCSV.Location = new System.Drawing.Point(579, 40);
            this.lblNewCSV.Name = "lblNewCSV";
            this.lblNewCSV.Size = new System.Drawing.Size(112, 13);
            this.lblNewCSV.TabIndex = 8;
            this.lblNewCSV.Text = "New CSV file location:";
            // 
            // chkOldHeaders
            // 
            this.chkOldHeaders.AutoSize = true;
            this.chkOldHeaders.Location = new System.Drawing.Point(1049, 14);
            this.chkOldHeaders.Name = "chkOldHeaders";
            this.chkOldHeaders.Size = new System.Drawing.Size(108, 17);
            this.chkOldHeaders.TabIndex = 9;
            this.chkOldHeaders.Text = "Contains headers";
            this.chkOldHeaders.UseVisualStyleBackColor = true;
            // 
            // chkNewHeaders
            // 
            this.chkNewHeaders.AutoSize = true;
            this.chkNewHeaders.Location = new System.Drawing.Point(1049, 39);
            this.chkNewHeaders.Name = "chkNewHeaders";
            this.chkNewHeaders.Size = new System.Drawing.Size(108, 17);
            this.chkNewHeaders.TabIndex = 10;
            this.chkNewHeaders.Text = "Contains headers";
            this.chkNewHeaders.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Total songs:";
            // 
            // nmrTotalSongs
            // 
            this.nmrTotalSongs.Location = new System.Drawing.Point(83, 12);
            this.nmrTotalSongs.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmrTotalSongs.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrTotalSongs.Name = "nmrTotalSongs";
            this.nmrTotalSongs.Size = new System.Drawing.Size(74, 20);
            this.nmrTotalSongs.TabIndex = 12;
            this.nmrTotalSongs.ThousandsSeparator = true;
            this.nmrTotalSongs.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // txtSorting
            // 
            this.txtSorting.FormattingEnabled = true;
            this.txtSorting.Items.AddRange(new object[] {
            "Altijd",
            "Week",
            "Maand",
            "Jaar"});
            this.txtSorting.Location = new System.Drawing.Point(83, 37);
            this.txtSorting.Name = "txtSorting";
            this.txtSorting.Size = new System.Drawing.Size(121, 21);
            this.txtSorting.TabIndex = 13;
            this.txtSorting.Text = "Altijd";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Periode:";
            // 
            // btnLoadNew
            // 
            this.btnLoadNew.Location = new System.Drawing.Point(210, 23);
            this.btnLoadNew.Name = "btnLoadNew";
            this.btnLoadNew.Size = new System.Drawing.Size(75, 23);
            this.btnLoadNew.TabIndex = 15;
            this.btnLoadNew.Text = "Load";
            this.btnLoadNew.UseVisualStyleBackColor = true;
            this.btnLoadNew.Click += new System.EventHandler(this.btnLoadNew_Click);
            // 
            // CSVtest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 798);
            this.Controls.Add(this.btnLoadNew);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSorting);
            this.Controls.Add(this.nmrTotalSongs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkNewHeaders);
            this.Controls.Add(this.chkOldHeaders);
            this.Controls.Add(this.lblNewCSV);
            this.Controls.Add(this.lblOldCSV);
            this.Controls.Add(this.txtNewCSV);
            this.Controls.Add(this.txtOldCSV);
            this.Controls.Add(this.btnNewCSV);
            this.Controls.Add(this.btnOldCSV);
            this.Controls.Add(this.dataCSV2);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dataCSV);
            this.Name = "CSVtest";
            this.Text = "Arc Chart Maker";
            ((System.ComponentModel.ISupportInitialize)(this.dataCSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataCSV2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrTotalSongs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataCSV;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.DataGridView dataCSV2;
        private System.Windows.Forms.Button btnOldCSV;
        private System.Windows.Forms.Button btnNewCSV;
        private System.Windows.Forms.TextBox txtOldCSV;
        private System.Windows.Forms.TextBox txtNewCSV;
        private System.Windows.Forms.Label lblOldCSV;
        private System.Windows.Forms.Label lblNewCSV;
        private System.Windows.Forms.CheckBox chkOldHeaders;
        private System.Windows.Forms.CheckBox chkNewHeaders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nmrTotalSongs;
        private System.Windows.Forms.ComboBox txtSorting;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLoadNew;
    }
}