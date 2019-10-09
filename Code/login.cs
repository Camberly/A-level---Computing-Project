using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using System.Data.OleDb;


namespace Algebraic_calculator_v0
{
    public partial class login : MetroFramework.Forms.MetroForm
        //declares the form 'login' using the Metroframework library, allowing the form to use the metroframework capabilities
    {   

        public System.Windows.Forms.TextBox username;
        // This declares the username as a public variable, from the username textbox, this allows other aspects of the software to access the username data, allowing 
        // for appropriate data to be accessed in other parts of the software.
        private OleDbConnection connection = new OleDbConnection(); 
        // This line establishes that a database will be used, using this in the partial class allows for
        // the database to be called throughout the entirity of the form.
        public login()
        {
            
            InitializeComponent();
            connection.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0;
            Data Source = F:\Computer Science\Project\Algebraic Calculator - Implmentation\School Update\Algebraic_calculator_v1.0\users.accdb;
                    Persist Security Info = False;";
            // This uses the connection established, and uses the database at the given directory.
            string loginname = username1.Text;
        }

        private void skipButton_Click(object sender, EventArgs e)
        // This is to allow users to skip the login screen if they don't wish to login at the current time
        // but still want to use the appliction 
        {
            username1.Text = username1.Text.Insert(0, "skip");
            password1.Text = password1.Text.Insert(0, "skip");
            //this inserts into the textboxes a 'skip' value, this will allow users to login to an account where statistics are not tracked. 
            connection.Open(); // Opens the connection to the database.
            OleDbCommand command = new OleDbCommand(); // Establishes that a command is going to be used, usually a SQL statement.
            command.Connection = connection; // States the command should be associated with the current connection.
            command.CommandText = "select * from userAccount where Username='" + username1.Text + "'and Password='" + password1.Text + "'";
            // SQL statement is stated here
            // username1 and password1 refer to the text boxes used in the login form.

            OleDbDataReader reader = command.ExecuteReader(); // Goes through each record and tries to find appropriate matches with that above SQL.
            int count = 0; // Stores a local variable to this method to allow the use of a loop.
            while (reader.Read())
            {
                count++; // Implements variable count by 1 when a match is found.
            }
            if (count == 1) // When a match is found,
            {
                MetroMessageBox.Show(this, "Skipping login...", "Skip Successful", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                connection.Close();     // Closes the connection to the database
                connection.Dispose();   // stops using any resources  related to the database. 
                this.Hide(); // Hides the current form
                Main_menu frm = new Main_menu(); // creates a new instance of the main menu form/
                frm.login1 = this; // this passes the data that was typed into username1 to the next form, allowing the username to be accessed from other forms.
                frm.Show(); // Shows the Main_menu form
            }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void registerButton_Click(object sender, EventArgs e) 
            // This is the register button, opens the register form when clicked upon.
        {
            Register registerForm = new Register();
            registerForm.Show();
            this.Hide();
            //This hides the current form, opens the new register form instance. 
        }

        private void signIn_Click(object sender, EventArgs e) 
            // Sign in button, signs users into the software when they click login.
        {
            if (password1.Text.Length > 3)
                // Condition that checks if the password will be valid
            {
                connection.Open(); // Opens the connection to the database.
                OleDbCommand command = new OleDbCommand(); // Establishes that a command is going to be used, usually a SQL statement.
                command.Connection = connection; // States the command should be associated with the current connection.
                command.CommandText = "select * from userAccount where Username='" + username1.Text + "'and Password='" + password1.Text + "'";
                // SQL statement is stated here, Selects all of the data where the username is the same as the username typed in, and the password.
                // username1 and password1 refer to the text boxes used in the login form.

                OleDbDataReader reader = command.ExecuteReader(); // Goes through each record and tries to find appropriate matches with that above SQL.
                int count = 0; // Stores a local variable to this method to allow the use of a loop.
                while (reader.Read())
                {
                    count++; // Implements variable count by 1 when a match is found.
                }
                if (count == 1) // When a match is found,
                {
                    MetroMessageBox.Show(this, "Logging in...", "Login Successful", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                    connection.Close();     // Closes the connection to the database
                    connection.Dispose();   // stops using any resources  related to the database. 
                    this.Hide(); // Hides the current form
                    Main_menu frm = new Main_menu(); // creates a new instance of the main menu form/
                    frm.login1 = this; // this passes the data that was typed into username1 to the next form, allowing the username to be accessed from other forms.
                    frm.Show(); // Shows the Main_menu form
                }
                else
                {
                    MetroMessageBox.Show(this, "Incorrect details", "Login unsuccessful", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    //Tells users when they do not have the correct details
                }
                connection.Close();
                //Closes connection to the database or else there could be issues with corruption when closing as the connection won't be closed. 
            }
            else { MessageBox.Show("Password not long enough to be valid."); }
            // If password is invalid, this message is shown. (Less than 3 characters.)
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            if (connection.State == 0)
            {
                Application.Exit();
            }
            // Exit button checks if the connection state is closed, then closes the software in an appropriate way to close all instances,
            // while ensuring that the connection is closed, preventing any data loss.
        }

       
    }
}
