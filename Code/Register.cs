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
    public partial class Register : MetroFramework.Forms.MetroForm
    {
        private OleDbConnection connection = new OleDbConnection();
        public Register()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = F:\Computer Science\Project\Algebraic Calculator - Implmentation\School Update\Algebraic_calculator_v1.0\users.accdb;
                    Persist Security Info = False;";

        }
        private List<TextBox> textBoxes_ = null;

       
        protected override void OnLoad( EventArgs e)
        {
            textBoxes_ = new List<TextBox>();
            textBoxes_.Add(usernameRegister);
            textBoxes_.Add(passwordRegister);
            textBoxes_.Add(passwordRepeat);
            textBoxes_.Add(emailRegister);
            textBoxes_.Add(firstNameReg);
            textBoxes_.Add(secondNameReg);
            // This adds all the textboxes to a list called 'TextBoxes_' which is initialised in this method. 
            usernameRegister.TextChanged += anyTextBox_TextChanged;
            passwordRegister.TextChanged += anyTextBox_TextChanged;
            passwordRepeat.TextChanged += anyTextBox_TextChanged;
            emailRegister.TextChanged += anyTextBox_TextChanged;
            firstNameReg.TextChanged += anyTextBox_TextChanged;
            secondNameReg.TextChanged += anyTextBox_TextChanged;
            // Checks if any text is editted in the register form and gives the event data to anyTextBox_TextChanged

        }

        // Starts an event when a textbox is changed. e.g. text being added written into the text boxes. 
        private void anyTextBox_TextChanged(object sender, EventArgs e)
        {
            
            registerWrite_CheckState();
        }

        private void registerWrite_CheckState()
        {
            // State the boolean to true at the begining to initialise the variable 
            bool state = true;

            foreach (TextBox textBox in textBoxes_)
                if ("".Equals(textBox.Text))
                {
                    // If the text boxes are empty, change this to false.
                    state = false;
                    break;
                }

            registerWrite.Enabled = state;
            // If all the text boxes have text in them, the button enables allowing users to click the register button.
        }

        private void registerWrite_Click(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand(); // Establishes that a command is going to be used, usually a SQL statement.
            command.Connection = connection; // States the command should be associated with the current connection.
            command.CommandText = "select * from userAccount where Username='" + usernameRegister.Text + "'";
            // SQL statement is stated here, used to detect if the username has already been used. 
            // username1 and password1 refer to the text boxes used in the login form.
          

            OleDbDataReader reader = command.ExecuteReader(); // Goes through each record and tries to find appropriate matches with that above SQL.
            int count = 0; // Stores a local variable to this method to allow the use of a loop.
            while (reader.Read())
            {
                count++; // Implements variable count by 1 when a match is found.
            }

            if (count == 1 )
            {
                MetroMessageBox.Show(this, "Username is already used, try another name.", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                // detects if username and passwords have duplicates, will be avoided in registration process to allowevery usernamne to be unique.
                connection.Close();
            }

            else if (passwordRegister.Text == passwordRepeat.Text)
            // Checks if the password repeated and the original matches, as to disallow mistakes to be made when entering the data in the value. 
            {
                if (emailRegister.Text.Contains("@") && emailRegister.Text.Contains("."))
                    // Checks if the email contains the appropriate symbols for a valid email address
                {
                    try
                    {

                        OleDbCommand command1 = new OleDbCommand();
                        command1.Connection = connection;
                        command1.CommandText = "insert into userAccount([Username],[Password],[EmailAddress],[FirstName],[SecondName]) values('" + usernameRegister.Text + "','"
                            + passwordRegister.Text + "','" + emailRegister.Text + "', '" + firstNameReg.Text + "', '" + secondNameReg.Text + "')";
                        command1.ExecuteNonQuery();
                        MetroMessageBox.Show(this, "Account Registered successfully, login now available.", "Account Registered", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                        connection.Close();
                        //This opens the database connection using the OleDb method first stated in 'using...'. 
                        // It then establishes a new command wants to be executed using command, and the command 'text' is an SQL statement that will insert data
                        // into the appropriate collumns within the database, userAccount() refers to the collumns in the table, and 
                        // values() captures the database from the textbox that is being used. 
                        //Finally, the connection is closed as to not damage the database being used. 
                        this.Hide();
                        login loginPage = new login();
                        loginPage.Show();
                    }

                    catch (Exception ex)
                    {
                        MetroMessageBox.Show(this, "Error" + ex, "Error Registering Account", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        connection.Close();
                    }
                }
                else { MessageBox.Show("Email formatted incorrectly... "); }
                // Shows a message if the email is formatted incorrectly, to allow the user to ammend the data to make it appropriate. 
            }
            else
            {
                MetroMessageBox.Show(this, "Ensure your repeated password matches with password", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                connection.Close();
                // shows an error 
            }
            connection.Close();
            
        }

        private void loginScreen_Click(object sender, EventArgs e)
        {
            this.Hide();
            login loginPage = new login();
            loginPage.Show();
        }
    }
}
