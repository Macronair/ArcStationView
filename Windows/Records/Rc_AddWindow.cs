using Arc_Station_View.Data;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Arc_Station_View.Windows.Records
{
    public partial class Rc_AddWindow : Form
    {
        public Rc_AddWindow()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtArtist.Text == "")
            {
                MessageBox.Show("Field 'Artist' cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtTitle.Text == "")
            {
                MessageBox.Show("Field 'Title' cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string cmdstring = "INSERT INTO [dbo].[TB_PlayCount] (Artist,Title,TotalPlayCount,WeekPlayCount,MonthPlayCount,YearPlayCount,LastPlayed,FirstPlayed) VALUES (@Artist,@Title,@TPC,@WPC,@MPC,@YPC,@LP,@FP)";
                SqlCommand cmd = new SqlCommand(cmdstring, Database.cn);

                using (SqlCommand command = new SqlCommand(cmdstring, Database.cn))
                {
                    command.Parameters.AddWithValue("@Artist", txtArtist.Text);
                    command.Parameters.AddWithValue("@Title", txtTitle.Text);
                    command.Parameters.AddWithValue("@TPC", 0);
                    command.Parameters.AddWithValue("@WPC", 0);
                    command.Parameters.AddWithValue("@MPC", 0);
                    command.Parameters.AddWithValue("@YPC", 0);
                    command.Parameters.AddWithValue("@LP", DateTime.Now);
                    command.Parameters.AddWithValue("@FP", DateTime.Now);

                    Database.cn.Open();
                    command.ExecuteNonQuery();
                }
                this.Close();
            }
        }
    }
}
