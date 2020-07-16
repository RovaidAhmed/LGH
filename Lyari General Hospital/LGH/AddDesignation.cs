using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LGH
{
    public partial class AddDesignation : Form
    {
        DataclassDataContext dv = new DataclassDataContext();
        public string dateWithFormat = " ";

        public AddDesignation()
        {
            InitializeComponent();
        }

        private void btndesignationadd_Click(object sender, EventArgs e)
        {
          

            if (txtdesignation.Text == "")
            {
                MessageBox.Show("Kindly Filled Properly");

            }
            else
            {
                var check = from c in dv.Designations
                                where 
                             c.Designation_Name.Contains(txtdesignation.Text)
                            select c;

                if (check.Any())
                {
                    MessageBox.Show("This Desination already in Database");
                }
                else
                {
                    //Add in Designation Table

                    Designation d = new Designation
                    {
                        Designation_Name = txtdesignation.Text,
                        Inserted_on = Convert.ToDateTime(dateWithFormat)
                       
                        
                    };
                    dv.Designations.InsertOnSubmit(d);
                    dv.SubmitChanges();
                    MessageBox.Show("Successfully Add New Designation", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    txtdesignation.Text = "";

                  


                    







                }

            }
            
            
        }

        private void txtdesignation_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Character Validation(only Character allowed)
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
            }
        }

        private void AddDesignation_Load(object sender, EventArgs e)
        {

            // will give the date for today
            DateTime date = DateTime.Now;
            dateWithFormat = date.ToLongDateString();

        }
    }
}
