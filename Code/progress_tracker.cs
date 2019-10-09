using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Algebraic_calculator_v0
{
    public partial class progress_tracker : MetroFramework.Forms.MetroForm
    {
        public login login1;   
        private OleDbConnection connection = new OleDbConnection();
        public progress_tracker()
        {
            InitializeComponent();
           
            connection.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = F:\Computer Science\Project\Algebraic Calculator - Implmentation\School Update\Algebraic_calculator_v1.0\users.accdb;
                    Persist Security Info = False;";

        }
        private void progress_tracker_load(object sender, EventArgs e)
        {
            var username = login1.username1.Text;
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "select * from userAccount where Username='" + username + "'";
            OleDbDataReader reader = command.ExecuteReader();
            int count = 0;
            if (reader.Read())
            {
                count++;
                loginCheck1.Text = "Welcome, " + reader["FirstName"].ToString() + " " + reader["SecondName"].ToString();
                connection.Close();
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var username = login1.username1.Text;
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM userAccount INNER JOIN Progress ON userAccount.[ID] = Progress.[User]";
                OleDbDataReader reader = command.ExecuteReader();
                int count = 0;
                if (reader.Read())
                {
                    count++;
                    loginCheck1.Text = "Welcome, " + reader["FirstName"].ToString() + " " + reader["SecondName"].ToString() + reader["Section"].ToString() + reader["Score"].ToString();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
