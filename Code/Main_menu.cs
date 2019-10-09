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
using MetroFramework;

namespace Algebraic_calculator_v0
{
    public partial class Main_menu : MetroFramework.Forms.MetroForm
    {
        
        public login login1;
        private OleDbConnection connection = new OleDbConnection();
        public Main_menu()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = F:\Computer Science\Project\Algebraic Calculator - Implmentation\School Update\Algebraic_calculator_v1.0\users.accdb;
                    Persist Security Info = False;"; // This uses the connection established, and uses the database at the given directory.
        }

        private void Main_menu_Load(object sender, EventArgs e)
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
                loginCheck.Text = "Welcome, " + reader["FirstName"].ToString() + " " + reader["SecondName"].ToString();
            }
        }
        private void calc_main_menu_Click(object sender, EventArgs e)
        {
            calculator calc = new calculator();
            calc.login1 = login1;
            calc.Show();
            calc.Location = this.Location;
        } 
        private void cheat_sheets_main_menu_Click(object sender, EventArgs e)
        {
            cheat_sheets cheat = new cheat_sheets();
            cheat.login1 = login1;
            cheat.Show();
            cheat.Location = this.Location;
        }

        private void questions_main_menu_Click(object sender, EventArgs e)
        {
            questions quest = new questions();
            quest.login1 = login1;
            quest.Show();
            quest.Location = this.Location;
        }

        private void progress_tracker_main_menu_Click(object sender, EventArgs e)
        {
            progress_tracker ptracker = new progress_tracker();
            ptracker.login1 = login1;
            ptracker.Show();
            ptracker.Location = this.Location;
        }

        private void exit_software_Click(object sender, EventArgs e)
        {
            if(connection.State == 0)
            { Application.Exit(); }
            
        }
    }
}
