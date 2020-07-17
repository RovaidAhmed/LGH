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

    public partial class AddSectionedpost : Form
    {

        DataclassDataContext dv = new DataclassDataContext();
        public string dateWithFormat = "";
        public AddSectionedpost()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {



            //validation for same designation Insertion samedate and designation_name

            var check = from c1 in dv.Posts
                        where c1.Designation_id == Convert.ToInt32(txtdesignationid.Text)
                        && c1.Inserted_On==Convert.ToDateTime(dateWithFormat)
                        select c1;

            if (check.Any())
            {
                MessageBox.Show("you Already add No.of Post Against this Designation in Recent Time");
                txtpost.Text = "";
            }
            else
            {
                try
                {
                    Post p = new Post
                    {
                        Designation_id = Convert.ToInt32(txtdesignationid.Text),
                        Sectioned_post = Convert.ToInt32(txtpost.Text),
                        Inserted_On = Convert.ToDateTime(dateWithFormat)


                    };
                    dv.Posts.InsertOnSubmit(p);
                    dv.SubmitChanges();
                    MessageBox.Show("No. Of Post Added");
                    txtpost.Text = " ";

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kindly Filled properly ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

                }


            }


        }

        private void AddSectionedpost_Load(object sender, EventArgs e)
        {
            //Comboboxdesignation 
            var a = from c in dv.Designations
                    select c;
            comboBoxDesignation.DataSource = a;
            comboBoxDesignation.DisplayMember = "Designation_Name";
             comboBoxDesignation.ValueMember = "Designation_ID";

            // will give the date for today
            DateTime date = DateTime.Now;
            dateWithFormat = date.ToLongDateString();


        }

        private void comboBoxDesignation_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Show value in textbox on behalf of combobox
            txtdesignationid.Text = comboBoxDesignation.SelectedValue.ToString();
        }

        private void txtpost_TextChanged(object sender, EventArgs e)
        {
            //Textbox Only Accept Numbers
            if (System.Text.RegularExpressions.Regex.IsMatch(txtpost.Text, "[^0-9]"))
            { 
                txtpost.Text = txtpost.Text.Remove(txtpost.Text.Length - 1);
            }

        }
    }
}
