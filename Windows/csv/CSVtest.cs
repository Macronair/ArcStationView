using Arc_Station_View.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Arc_Station_View.Windows.csv
{
    public partial class CSVtest : Form
    {
        public CSVtest()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            Program.LogMessage("Creating data tables...");
            int row;
            if (chkOldHeaders.Checked)
            {
                row = -1;
            }
            else
            {
                row = 1;
            }

            // Old Table info
            DataTable old_table = new DataTable();
            old_table.Columns.Add("Position");
            old_table.Columns.Add("Identity");
            old_table.Columns.Add("Artist");
            old_table.Columns.Add("Title");
            old_table.Columns.Add("TotalPlayCount");
            old_table.Columns.Add("WeekPlayCount");
            DataRow old_row;

            // New Table info
            var new_table = new DataTable();
            new_table.Columns.Add("Position");
            new_table.Columns.Add("Identity");
            new_table.Columns.Add("Artist");
            new_table.Columns.Add("Title");
            new_table.Columns.Add("TotalPlayCount");
            new_table.Columns.Add("WeekPlayCount");
            new_table.Columns.Add("PreviousPosition");
            DataRow new_row;

            Program.LogMessage("Reading CSV files...");

            // Load old CSV data
            using (var reader = new StreamReader(txtOldCSV.Text))
            {
                Program.LogMessage("=======================|  FIRST CSV FILE  |=======================");
                List<string> Id = new List<string>();
                List<string> Artist = new List<string>();
                List<string> Title = new List<string>();
                List<string> TotalPlayCount = new List<string>();
                List<string> WeekPlayCount = new List<string>();

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split('=');
                    if (row > 0 && row < 51)
                    {
                        Id.Add(values[0]);
                        Artist.Add(values[1]);
                        Title.Add(values[2]);
                        TotalPlayCount.Add(values[3]);
                        WeekPlayCount.Add(values[4]);
                        Program.LogMessage(row + " >> " + values[0] + " - " + values[1] + " - " + values[2] + " - " + values[3] + " - " + values[4]);

                        // Make a new row in the OldTable datatable.
                        old_row = old_table.NewRow();
                        old_row["Position"] = row;
                        old_row["Identity"] = values[0];
                        old_row["Artist"] = values[1];
                        old_row["Title"] = values[2];
                        old_row["TotalPlayCount"] = values[3];
                        old_row["WeekPlayCount"] = values[4];
                        old_table.Rows.Add(old_row);
                    }
                    row++;
                }

                dataCSV.DataSource = old_table;
                Program.LogMessage("=======================|==================|=======================");
            }

            if (chkNewHeaders.Checked)
            {
                row = -1;
            }
            else
            {
                row = 1;
            }

            // Loading new CSV data
            using (var reader = new StreamReader(txtNewCSV.Text))
            {
                Program.LogMessage("=======================|  SECOND CSV FILE  |=======================");
                List<string> Id = new List<string>();
                List<string> Artist = new List<string>();
                List<string> Title = new List<string>();
                List<string> TotalPlayCount = new List<string>();
                List<string> WeekPlayCount = new List<string>();

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split('=');
                    if (row > 0 && row < 51)
                    {
                        //Id.Add(values[0]);
                        //Artist.Add(values[1]);
                        //Title.Add(values[2]);
                        //TotalPlayCount.Add(values[3]);
                        //WeekPlayCount.Add(values[4]);
                        Program.LogMessage(row + " >> " + values[0] + " - " + values[1] + " - " + values[2] + " - " + values[3] + " - " + values[4]);

                        // Make a new row in the OldTable datatable.
                        new_row = new_table.NewRow();
                        new_row["Position"] = row;
                        new_row["Identity"] = values[0];
                        new_row["Artist"] = values[1];
                        new_row["Title"] = values[2];
                        new_row["TotalPlayCount"] = values[3];
                        new_row["WeekPlayCount"] = values[4];

                        foreach (DataGridViewRow datarow in dataCSV.Rows)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkCyan;

                            try
                            {
                                string artist = datarow.Cells[2].Value.ToString();
                                string title = datarow.Cells[3].Value.ToString();

                                new_row["Artist"] = values[1];
                                new_row["Title"] = values[2];

                                string new_artist = values[1];
                                string new_title = values[2];

                                if (artist == values[1] && title == values[2])
                                {
                                    Program.LogMessageLine("Entry also exist in old CSV. Calculating position difference...");
                                    var old_pos = Convert.ToInt32(datarow.Cells[0].Value);
                                    int new_pos = row;
                                    decimal diff = 0;

                                    // When new position is higher
                                    if (new_pos < old_pos)
                                    {
                                        diff = old_pos - new_pos;
                                        new_row["PreviousPosition"] = diff;
                                        Console.WriteLine("DONE! (New = Higher)");
                                        break;
                                    }
                                    // When new position is lover
                                    else if (old_pos < new_pos)
                                    {
                                        diff = old_pos - new_pos;
                                        new_row["PreviousPosition"] = diff;
                                        Console.WriteLine("DONE! (New = Lower)");
                                        break;
                                    }
                                    else
                                    {
                                        new_row["PreviousPosition"] = 0;
                                        Console.WriteLine("DONE! (No change)");
                                        break;
                                    }
                                }


                            }
                            catch (NullReferenceException ex)
                            {

                            }
                            finally
                            {
                                Console.ForegroundColor = ConsoleColor.Gray;
                            }

                            Console.ForegroundColor = ConsoleColor.Gray;
                        }

                        if(Convert.ToString(new_row["PreviousPosition"]) == "")
                        {
                            new_row["PreviousPosition"] = "*";
                        }

                        new_table.Rows.Add(new_row);
                    }

                    row++;
                }

                dataCSV2.DataSource = new_table;
                dataCSV2.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataCSV2.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                Program.LogMessage("=======================|===================|=======================");
                Program.LogMessage("Finished loading CSV files. Results will be opened.");

                foreach (DataGridViewRow datarow2 in dataCSV2.Rows)
                {
                    try
                    {
                        var result = datarow2.Cells[6].Value;
                        if (Convert.ToString(result) == "*")
                        {
                            datarow2.DefaultCellStyle.BackColor = Color.Orange;
                        }
                        else if (Convert.ToInt32(result) > 0)
                        {
                            datarow2.DefaultCellStyle.BackColor = Color.PaleGreen;
                        }
                        else if (Convert.ToInt32(result) < 0)
                        {
                            datarow2.DefaultCellStyle.BackColor = Color.LightCoral;
                        }
                        else if (Convert.ToInt32(result) == 0)
                        {
                            datarow2.DefaultCellStyle.BackColor = Color.LightSkyBlue;
                        }
                    }
                    catch
                    {

                    }

                }
            }

        }

        private void btnOldCSV_Click(object sender, EventArgs e)
        {
            OpenFileDialog oldCSV = new OpenFileDialog
            {
                InitialDirectory = Application.ExecutablePath,
                Title = "Select the old CSV file..",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "CSV Files (*.csv)|*.csv",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (oldCSV.ShowDialog() == DialogResult.OK)
            {
                txtOldCSV.Text = oldCSV.FileName;
            }
        }

        private void btnNewCSV_Click(object sender, EventArgs e)
        {
            OpenFileDialog newCSV = new OpenFileDialog
            {
                InitialDirectory = Application.ExecutablePath,
                Title = "Select the new CSV file..",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "CSV Files (*.csv)|*.csv",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (newCSV.ShowDialog() == DialogResult.OK)
            {
                txtNewCSV.Text = newCSV.FileName;
            }
        }

        private void btnLoadNew_Click(object sender, EventArgs e)
        {
            string artist = "";
            string title = "";
            decimal totalsongs = nmrTotalSongs.Value;
            var select = "";
            if (txtSorting.Text == "Altijd")
            {
                select = "SELECT TOP " + totalsongs + " * FROM TB_PlayCount WHERE NOT Title = '%Arc Spotlight%' ORDER BY TotalPlayCount DESC;";
            }
            else if (txtSorting.Text == "Week")
            {
                select = "SELECT TOP " + totalsongs + " * FROM TB_PlayCount WHERE NOT Title = '%Arc Spotlight%' ORDER BY WeekPlayCount DESC;";
            }
            else if (txtSorting.Text == "Maand")
            {
                select = "SELECT TOP " + totalsongs + " * FROM TB_PlayCount WHERE NOT Title = '%Arc Spotlight%' ORDER BY MonthPlayCount DESC;";
            }
            else if (txtSorting.Text == "Jaar")
            {
                select = "SELECT TOP " + totalsongs + " * FROM TB_PlayCount WHERE NOT Title = '%Arc Spotlight%' ORDER BY YearPlayCount DESC;";
            }

            SqlDataAdapter dataAdapter = new SqlDataAdapter(select, Database.cn);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataCSV2.ReadOnly = true;
            dataCSV2.DataSource = ds.Tables[0];

            dataCSV2.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataCSV2.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataCSV2.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataCSV2.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataCSV2.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
