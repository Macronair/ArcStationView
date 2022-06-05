using Arc_Station_View.Data;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Arc_Station_View.Windows
{
    public partial class Rc_ViewWindow : Form
    {

        private readonly MainScreen mainscr;

        public Rc_ViewWindow(MainScreen m)
        {
            InitializeComponent();
            this.mainscr = m;
        }

        private void SongView_Load(object sender, EventArgs e)
        {
            var ds = new DataSet();

            Program.LogMessage("Opening record: " + lblArtist.Text + " - " + lblTitle.Text);
            Program.LogMessage("Checking table...");
            foreach (string table in MainScreen.GetTables())
            {
                Program.LogMessage("> Search in: " + table);
            }

            foreach (string table in MainScreen.GetTables())
            {
                //var select = "SELECT Artist,Title,PlayedOn FROM [dbo].[" + table + "] WHERE Artist LIKE '%" + lblArtist.Text + "%' AND Title LIKE '%" + lblTitle.Text + "%'";
                var select = String.Format("SELECT Artist,Title,PlayedOn FROM [dbo].[" + table + "] WHERE Artist = @Artist AND Title = @Title");
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand(select, Database.cn);
                dataAdapter.SelectCommand = cmd;

                cmd.Parameters.AddWithValue("@Artist", lblArtist.Text);
                cmd.Parameters.AddWithValue("@Title", lblTitle.Text);

                dataAdapter.Fill(ds);
            }
            dataSongHistory.ReadOnly = true;
            dataSongHistory.DataSource = ds.Tables[0];
            dataSongHistory.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataSongHistory.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataSongHistory.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            this.dataSongHistory.Sort(this.dataSongHistory.Columns["PlayedOn"], ListSortDirection.Ascending);
        }
    }
}
