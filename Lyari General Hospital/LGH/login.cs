using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace LGH
{
    public partial class login : Form
    {

        public login()
        {
            InitializeComponent();
            
        }

        
        //loginbtn
        private void button1_Click(object sender, EventArgs e)
        {
            //string cs = ConfigurationManager.ConnectionStrings["LGH"].ConnectionString;

            DataclassDataContext dv = new DataclassDataContext();
            var cust = from c in dv.Users
                       where c.Name == txtname.Text &&
                       c.Password == txtpass.Text
                       select c;


            if (cust.Any())
            {
                MessageBox.Show("You are logged in Sucesffuly");
                this.Hide();
                MainForm mf = new MainForm();
                mf.ShowDialog();
            }

            else
            {
                MessageBox.Show("User Username or Password is Incorrect", "Warning",   MessageBoxButtons.OK,  MessageBoxIcon.Error,    MessageBoxDefaultButton.Button1);
                lblerror.Text="Invalid";
            }








        }
    }
}
