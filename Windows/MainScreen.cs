using Arc_Station_View.Data;
using Arc_Station_View.Windows.csv;
using Arc_Station_View.Windows.Records;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Arc_Station_View.Windows
{
    public partial class MainScreen : Form
    {

        // 
        string artist;
        string title;
        //private object dataviewer;

        public MainScreen()
        {
            InitializeComponent();
        }

        // Get a list of tables from the database.
        public static List<string> GetTables()
        {
            using (Database.cn)
            {
                if (Database.cn.State == ConnectionState.Closed)
                {
                    Database.OpenConnection();
                }

                DataTable schema = Database.cn.GetSchema("Tables");
                List<string> TableNames = new List<string>();
                foreach (DataRow row in schema.Rows)
                {
                    if (row[2].ToString().Contains("TB_PlayLog"))
                    {
                        TableNames.Add(row[2].ToString());
                    }
                }

                if (Database.cn.State == ConnectionState.Open)
                {
                    Database.CloseConnection();
                }

                return TableNames;
            }
        }

        // This methods can add/edit/delete entries from the database.
        #region Database functions

        private void SettingsDB()
        {
            SettingsView settings = new SettingsView();
            settings.ShowDialog();
        }

        private void AddDB()
        {
            Rc_AddWindow song = new Rc_AddWindow();
            song.ShowDialog();
            btnSearch.PerformClick();
        }

        private void EditDB()
        {
            Rc_ViewWindow song = new Rc_ViewWindow(this);
            song.lblArtist.Text = dataViewer.CurrentRow.Cells[1].Value.ToString();
            song.lblTitle.Text = dataViewer.CurrentRow.Cells[2].Value.ToString();
            song.lblTotalPlays.Text = dataViewer.CurrentRow.Cells[3].Value.ToString();
            song.lblWeekPlays.Text = dataViewer.CurrentRow.Cells[4].Value.ToString();
            song.lblMonthPlays.Text = dataViewer.CurrentRow.Cells[5].Value.ToString();
            song.lblYearPlays.Text = dataViewer.CurrentRow.Cells[6].Value.ToString();
            song.lblFirstPlayed.Text = dataViewer.CurrentRow.Cells[8].Value.ToString();
            song.lblLastPlayed.Text = dataViewer.CurrentRow.Cells[7].Value.ToString();
            song.ShowDialog();
        }

        private void DeleteDB()
        {
            try
            {
                Database.OpenConnection();
                var delete = string.Concat("DELETE FROM TB_PlayCount WHERE Id = ", tlblSelected.Text);
                SqlCommand deletesql = new SqlCommand(delete, Database.cn);
                deletesql.ExecuteNonQuery();

                foreach (string table in GetTables())
                {
                    if (Database.cn.State == ConnectionState.Closed)
                    {
                        Database.OpenConnection();
                    }
                    var delete2 = "DELETE FROM [dbo].[" + table + "] WHERE Artist LIKE '%" + lblArtist.Text + "%' AND Title LIKE '%" + lblTitle.Text + "%'";
                    SqlCommand deletesql2 = new SqlCommand(delete2, Database.cn);
                    deletesql2.ExecuteNonQuery();
                }
                Database.CloseConnection();
                MessageBox.Show("Registratie verwijderd uit database.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while deleting: " + Environment.NewLine + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnSearch.PerformClick();
                tlblSelected.Text = "0";
            }

        }
        #endregion
        // End of DB methods.

        // Method when main window is loading
        private void MainScreen_Load(object sender, EventArgs e)
        {
            var select = "SELECT * FROM TB_PlayCount WHERE Artist LIKE '%" + artist + "%' AND Title LIKE '%" + title + "%'";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(select, Database.cn);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataViewer.ReadOnly = true;
            dataViewer.DataSource = ds.Tables[0];

            dataViewer.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataViewer.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataViewer.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataViewer.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataViewer.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            tlblTotal.Text = dataViewer.RowCount.ToString();

            Program.LogMessage("> Startup complete.");
            Console.WriteLine("---------------------------------------");
            Program.showSplashScreen = false;
        }

        // Search button on.. how obvious.. the search bar.
        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Search task input is also shown in the statusbar.
            tlblSearch.Text = artist + " - " + title;

            // Make search more specific with a time range.
            if (dmnRange.Text == "Totaal")              // Total results. No time range.
            {
                var select = "SELECT * FROM TB_PlayCount WHERE Artist LIKE '%" + artist + "%' AND Title LIKE '%" + title + "%' ORDER BY TotalPlayCount ASC";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(select, Database.cn);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                var ds = new DataSet();
                dataAdapter.Fill(ds);
                dataViewer.ReadOnly = true;
                dataViewer.DataSource = ds.Tables[0];
            }
            else if (dmnRange.Text == "Deze week")       // Results of one week.
            {
                var select = "SELECT * FROM TB_PlayCount WHERE Artist LIKE '%" + artist + "%' AND Title LIKE '%" + title + "%' AND WeekPlayCount > 0 ORDER BY WeekPlayCount DESC";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(select, Database.cn);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                var ds = new DataSet();
                dataAdapter.Fill(ds);
                dataViewer.ReadOnly = true;
                dataViewer.DataSource = ds.Tables[0];
            }
            else if (dmnRange.Text == "Deze maand")     // Results of one month.
            {
                var select = "SELECT * FROM TB_PlayCount WHERE Artist LIKE '%" + artist + "%' AND Title LIKE '%" + title + "%' AND MonthPlayCount > 0 ORDER BY MonthPlayCount DESC";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(select, Database.cn);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                var ds = new DataSet();
                dataAdapter.Fill(ds);
                dataViewer.ReadOnly = true;
                dataViewer.DataSource = ds.Tables[0];
            }
            else if (dmnRange.Text == "Dit jaar")       // Results of one year.
            {
                var select = "SELECT * FROM TB_PlayCount WHERE Artist LIKE '%" + artist + "%' AND Title LIKE '%" + title + "%' AND YearPlayCount > 0 ORDER BY YearPlayCount DESC";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(select, Database.cn);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                var ds = new DataSet();
                dataAdapter.Fill(ds);
                dataViewer.ReadOnly = true;
                dataViewer.DataSource = ds.Tables[0];
            }
        }

        // Double click feature when clicking a record in data grid.
        private void dataViewer_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            EditDB();
        }

        // Real-time search feature
        private void dmnRange_TextChanged(object sender, EventArgs e)
        {
            btnSearch.PerformClick();
        }

        // Gets the selection and shows this in the statusbar
        private void dataViewer_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataViewer.Rows.Count > 0)
            {
                try
                {
                    tlblSelected.Text = dataViewer.CurrentRow.Cells[0].Value.ToString();
                }
                catch (Exception ex)
                {
                    tlblSelected.Text = "0";
                }
            }
            else
            {
                tlblSelected.Text = "0";
            }
        }

        private void tstrEdit_Click(object sender, EventArgs e)
        {
            EditDB();
        }

        private void dataViewer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tstrEdit.Enabled = true;
            tstrDelete.Enabled = true;
            tsmiEditRecord.Enabled = true;
            tsmiDeleteRecord.Enabled = true;
        }

        private void dataViewer_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                tlblSelected.Text = dataViewer.CurrentRow.Cells[0].Value.ToString();
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                tlblSelected.Text = "0";
            }

        }
        private void tstrAdd_Click(object sender, EventArgs e)
        {
            AddDB();
        }

        private void txtArtist_TextChanged(object sender, EventArgs e)
        {
            artist = txtArtist.Text;
            ; btnSearch.PerformClick();
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
            title = txtTitle.Text;
            btnSearch.PerformClick();
        }

        private void tstrDelete_Click(object sender, EventArgs e)
        {
            DeleteDB();
        }

        private void dataViewer_SelectionChanged(object sender, EventArgs e)
        {
            if (dataViewer.Rows.Count == 0)
            {
                tstrEdit.Enabled = false;
                tstrDelete.Enabled = false;
                tsmiEditRecord.Enabled = false;
                tsmiDeleteRecord.Enabled = false;
            }
        }

        private void tsmiInsertRecord_Click(object sender, EventArgs e)
        {
            AddDB();
        }

        private void tsmiEditRecord_Click(object sender, EventArgs e)
        {
            EditDB();
        }

        private void tsmiDeleteRecord_Click(object sender, EventArgs e)
        {
            DeleteDB();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void databaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsDB();
        }

        private void tstrSettings_Click(object sender, EventArgs e)
        {
            SettingsDB();
        }

        private void goToTopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataViewer.FirstDisplayedCell = dataViewer.Rows[0].Cells[0];
            dataViewer.CurrentCell = dataViewer.Rows[0].Cells[0];
        }

        private void goToBottomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                dataViewer.Rows[dataViewer.Rows.Count - 1].Selected = true;
                dataViewer.CurrentCell = dataViewer.Rows[dataViewer.Rows.Count - 1].Cells[1];
            }
            catch (IndexOutOfRangeException)
            { }
            catch (ArgumentOutOfRangeException)
            { }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutView about = new AboutView();
            about.ShowDialog();
        }

        private void cSVTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CSVtest csv = new CSVtest();
            csv.Show();
        }
    }
}
