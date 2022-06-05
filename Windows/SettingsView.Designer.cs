
namespace Arc_Station_View.Windows
{
    partial class SettingsView
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
            this.txtSQLserver = new System.Windows.Forms.TextBox();
            this.txtSQLuser = new System.Windows.Forms.TextBox();
            this.txtSQLpassword = new System.Windows.Forms.TextBox();
            this.txtSQLdatabase = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnTestDB = new System.Windows.Forms.Button();
            this.chkShowEntriesStartup = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtSQLserver
            // 
            this.txtSQLserver.Location = new System.Drawing.Point(84, 33);
            this.txtSQLserver.Name = "txtSQLserver";
            this.txtSQLserver.Size = new System.Drawing.Size(216, 20);
            this.txtSQLserver.TabIndex = 0;
            // 
            // txtSQLuser
            // 
            this.txtSQLuser.Location = new System.Drawing.Point(84, 57);
            this.txtSQLuser.Name = "txtSQLuser";
            this.txtSQLuser.Size = new System.Drawing.Size(216, 20);
            this.txtSQLuser.TabIndex = 1;
            // 
            // txtSQLpassword
            // 
            this.txtSQLpassword.Location = new System.Drawing.Point(84, 79);
            this.txtSQLpassword.Name = "txtSQLpassword";
            this.txtSQLpassword.PasswordChar = '*';
            this.txtSQLpassword.Size = new System.Drawing.Size(216, 20);
            this.txtSQLpassword.TabIndex = 2;
            this.txtSQLpassword.UseSystemPasswordChar = true;
            // 
            // txtSQLdatabase
            // 
            this.txtSQLdatabase.Location = new System.Drawing.Point(84, 103);
            this.txtSQLdatabase.Name = "txtSQLdatabase";
            this.txtSQLdatabase.Size = new System.Drawing.Size(216, 20);
            this.txtSQLdatabase.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Server:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "User:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Database:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "SQL Server Settings";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(214, 154);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 34);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save and Close";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnTestDB
            // 
            this.btnTestDB.Location = new System.Drawing.Point(237, 125);
            this.btnTestDB.Name = "btnTestDB";
            this.btnTestDB.Size = new System.Drawing.Size(63, 23);
            this.btnTestDB.TabIndex = 10;
            this.btnTestDB.Text = "Test";
            this.btnTestDB.UseVisualStyleBackColor = true;
            this.btnTestDB.Click += new System.EventHandler(this.btnTestDB_Click);
            // 
            // chkShowEntriesStartup
            // 
            this.chkShowEntriesStartup.AutoSize = true;
            this.chkShowEntriesStartup.Checked = true;
            this.chkShowEntriesStartup.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowEntriesStartup.Location = new System.Drawing.Point(12, 129);
            this.chkShowEntriesStartup.Name = "chkShowEntriesStartup";
            this.chkShowEntriesStartup.Size = new System.Drawing.Size(197, 17);
            this.chkShowEntriesStartup.TabIndex = 11;
            this.chkShowEntriesStartup.Text = "Show all database entries on startup";
            this.chkShowEntriesStartup.UseVisualStyleBackColor = true;
            // 
            // SettingsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 198);
            this.Controls.Add(this.chkShowEntriesStartup);
            this.Controls.Add(this.btnTestDB);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSQLdatabase);
            this.Controls.Add(this.txtSQLpassword);
            this.Controls.Add(this.txtSQLuser);
            this.Controls.Add(this.txtSQLserver);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SettingsView";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSQLserver;
        private System.Windows.Forms.TextBox txtSQLuser;
        private System.Windows.Forms.TextBox txtSQLpassword;
        private System.Windows.Forms.TextBox txtSQLdatabase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnTestDB;
        private System.Windows.Forms.CheckBox chkShowEntriesStartup;
    }
}