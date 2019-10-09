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
using MathNet.Symbolics;
using Expr = MathNet.Symbolics.SymbolicExpression;
using MetroFramework;


namespace Algebraic_calculator_v0
{
    public partial class calculator : MetroFramework.Forms.MetroForm
    {
        public login login1;
        static MathNet.Symbolics.SymbolicExpression x = Expr.Variable("x");
        static MathNet.Symbolics.SymbolicExpression y = Expr.Variable("y");
        static MathNet.Symbolics.SymbolicExpression a = Expr.Variable("a");
        

        private OleDbConnection connection = new OleDbConnection();
        public calculator()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = F:\Computer Science\Project\Algebraic Calculator - Implmentation\School Update\Algebraic_calculator_v1.0\users.accdb;
                    Persist Security Info = False;"; // This uses the connection established, and uses the database at the given directory.
        }

        private void back_Click(object sender, EventArgs e)
        {
            // Main_menu main = new Main_menu();
            // main.Show();
            // main.Location = this.Location;
            this.Hide();
        }

        private void calculator_Load(object sender, EventArgs e)
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
                logincheck.Text = "Welcome, " + reader["FirstName"].ToString() + " " + reader["SecondName"].ToString();
            }
        }

        private void enter_btn_Click(object sender, EventArgs e)
        {
            if (CalcInput.Text.Length > 0)
            {
                if (CalcInput.Text.Contains("Expand"))
                {
                    try
                    {
                        CalcInput.Text = CalcInput.Text.Replace("Expand", "");
                        var convert = Infix.ParseOrThrow(CalcInput.Text);
                        var parsedExpression = Algebraic.Expand(convert);
                        MetroMessageBox.Show(this, Infix.Format(parsedExpression), "Answer");
                        CalcInput.Text = CalcInput.Text.Insert(0, "Expand");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error" + ex);
                    }
                }
                else if (CalcInput.Text.Contains("d/dx"))
                {
                    try
                    {
                        CalcInput.Text = CalcInput.Text.Replace("d/dx", "");
                        var convert = Infix.ParseOrThrow(CalcInput.Text);
                        var parsedExpression = Algebraic.Expand(convert);
                        var differentiated = Calculus.Differentiate(Infix.ParseOrThrow("x"), parsedExpression);
                        CalcInput.Text = CalcInput.Text.Insert(0, "d/dx");
                        MetroMessageBox.Show(this, "Using the formula nx^n-1, or pre-determined values \r\n" + "d/dx = " + Infix.Format(differentiated), "Answer");

                    }
                    catch (Exception ex)
                    {
                        MetroMessageBox.Show(this, "Error, ensure you have brackets for each term, and a * between a number and a symbol " + ex, "Error",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    }
                }
                else if (CalcInput.Text.Contains("TrigIden"))
                {
                    try
                    {
                        CalcInput.Text = CalcInput.Text.Replace("TrigIden", "");
                        var convert = Infix.ParseOrThrow(CalcInput.Text);
                        var parsedExpression = Trigonometric.Expand(convert);
                        CalcInput.Text = CalcInput.Text.Insert(0, "TrigIden");
                        MetroMessageBox.Show(this, "Answer \r\n " + Infix.Format(parsedExpression), "Answer", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MetroMessageBox.Show(this, "Error " + ex, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    }
                }
                else if (CalcInput.Text.Contains("TrigContract"))
                {
                    try
                    {
                        CalcInput.Text = CalcInput.Text.Replace("TrigContract", "");
                        var convert = Infix.ParseOrThrow(CalcInput.Text);
                        var parsedExpression = Trigonometric.Contract(convert);
                        CalcInput.Text = CalcInput.Text.Insert(0, "TrigContract");
                        MetroMessageBox.Show(this, "Answer \r\n " + Infix.Format(parsedExpression), "Answer", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MetroMessageBox.Show(this, "Error " + ex, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    }
                }  
                else
                {
                    try
                    {
                        var parsedExpression = Infix.ParseOrThrow(CalcInput.Text);
                        MessageBox.Show(Infix.Format(parsedExpression));

                    }
                    catch (Exception ex)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Error" + ex, "Error");
                    }

                }
            }
            else
            {
                MetroMessageBox.Show(this, "Please enter text before clicking enter...", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

        }


    }
}

