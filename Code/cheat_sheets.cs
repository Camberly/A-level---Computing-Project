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
    
    public partial class cheat_sheets : MetroFramework.Forms.MetroForm
    {
        public login login1;
        private OleDbConnection connection = new OleDbConnection();
        public cheat_sheets()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = F:\Computer Science\Project\Algebraic Calculator - Implmentation\School Update\Algebraic_calculator_v1.0\users.accdb;
                    Persist Security Info = False;";
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
