using Arc_Station_View.Data;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace Arc_Station_View.Windows
{
    public partial class SettingsView : Form
    {
        public SettingsView()
        {
            InitializeComponent();
        }

        private void SettingsView_Load(object sender, EventArgs e)
        {
            txtSQLserver.Text = ConfigurationManager.AppSettings["sql-server"];
            txtSQLuser.Text = ConfigurationManager.AppSettings["sql-user"];
            txtSQLpassword.Text = ConfigurationManager.AppSettings["sql-password"];
            txtSQLdatabase.Text = ConfigurationManager.AppSettings["sql-database"];

            if (ConfigurationManager.AppSettings["showEntriesOnStart"] == "1")
            {
                chkShowEntriesStartup.Checked = true;
            }
            else
            {
                chkShowEntriesStartup.Checked = false;
            }
        }

        private void btnTestDB_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ConfigurationManager.AppSettings["sql-server"] = txtSQLserver.Text;
            ConfigurationManager.AppSettings["sql-user"] = txtSQLuser.Text;
            ConfigurationManager.AppSettings["sql-password"] = txtSQLpassword.Text;
            ConfigurationManager.AppSettings["sql-database"] = txtSQLdatabase.Text;

            if (chkShowEntriesStartup.Checked == false)
            {
                ConfigurationManager.AppSettings["showEntriesOnStart"] = "0";
            }
            else if (chkShowEntriesStartup.Checked == true)
            {
                ConfigurationManager.AppSettings["showEntriesOnStart"] = "1";
            }
            this.Close();
            Settings.LoadSettings();
        }
    }
}
