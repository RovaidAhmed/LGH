using System;
using System.Windows.Forms;

namespace LGH
{
    public partial class BioData : Form
    {
        DataclassDataContext dc = new DataclassDataContext();

        public static string vname = "";
        public static string vsdwo = " ";
        public static string vsdwo_name = "";
        public static string vDOB = "";
        public static string vDateofSuperannuation = " ";
        public static string vsex = " ";
        public static string vmartialstatus = " ";
        public static string vnextkin = " ";
        public static string vaddress = " ";
        public static string vcnic = " ";
        public static string vcellno = " ";
        public static string vemergencyno = " ";
        public static string vlandline = " ";
        public static string vpassportno = " ";
        public static string vemail = "";
        public static string vdomicile = " ";
        public static string vprc = " ";
        public static string vpersonalno = " ";
        public static string vservicebookno = " ";
        public static string vdateofjoinninggovt = " ";
        public static string vjoinlghk = " ";
        public static string vjoinlghkno = " ";
        public static string vpostedlghkon = " ";
        public static string vstatusbeforejoinlghk = " ";
        public static string vpostedatlghkin = " ";
        public static string vlghkvacantpost = " ";
        public static string vdesignation = " ";
        public static string vcadre = " ";
        public static string vbps = "";







        public BioData()
        {
            InitializeComponent();
        }



        private void BioData_Load(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            //Session for store the Data .
            vname = txtname.Text;
            vsdwo = comboBoxsdwo.Text;
            vsdwo_name = txtsdwo.Text;
            vDOB = dateTimePickerDOB.Text;
            vDateofSuperannuation = dateTimePickerdatesupernnuation.Text;
            vsex = comboboxsex.Text;
            vmartialstatus = comboBoxmartialstatus.Text;
            vnextkin = txtnextkin.Text;
            vaddress = txtaddress.Text;
            vcnic = txtcnic.Text;
            vcellno = txtcellno.Text;
            vemergencyno = txtemergencycontactno.Text;
            vlandline = txtlandlineno.Text;
            vpassportno = txtpassportno.Text;
            vemail = txtemail.Text;
            vdomicile = txtdomicile.Text;
            vprc = txtprc.Text;
            vpersonalno = txtpersonalno.Text;
            vservicebookno = txtservicebookno.Text;
            vdateofjoinninggovt = dateTimePickerjoingovt.Text;
            vjoinlghk = dateTimePickerjoinlghk.Text;
            vjoinlghkno = txtlghkno.Text;
            vpostedlghkon = comboBoxpostedlghkon.Text;
            vstatusbeforejoinlghk = comboBoxbeforejoinlghk.Text;
            vpostedatlghkin = txtlghkin.Text;
            vlghkvacantpost = txtvacantpost.Text;
            vdesignation = txtdesignation.Text;
            vcadre = comboBoxcadre.Text;
            vbps = numericUpDownbps.Value.ToString();


              //Validation
              if (txtname.Text == "" || txtsdwo.Text == "" ||
                txtcnic.Text == "" || txtcellno.Text == "" ||
                txtemail.Text == "" || txtprc.Text == "" ||
                txtdomicile.Text == "" || txtpersonalno.Text == "" ||txtaddress.Text=="")
                
            {
                MessageBox.Show("Kindly Fill the Mendatory Feilds ==>(*) ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

            }

            else
            {
                //open another bio data form
                Other_Info_Biodata oib = new Other_Info_Biodata();
                oib.ShowDialog();
            }

        }






        private void txtcellno_TextChanged(object sender, EventArgs e)
        {

            //Textbox Only Accept Numbers
            if (System.Text.RegularExpressions.Regex.IsMatch(txtcellno.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtcellno.Text = txtcellno.Text.Remove(txtcellno.Text.Length - 1);
            }

        }

        private void txtcnic_TextChanged(object sender, EventArgs e)
        {
            //Textbox Only Accept Numbers
            if (System.Text.RegularExpressions.Regex.IsMatch(txtcnic.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtcnic.Text = txtcnic.Text.Remove(txtcnic.Text.Length - 1);
            }
        }

        private void txtname_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Character Validation(only Character allowed)
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
            }

        }

        private void txtsdwo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Character Validation(only Character allowed)
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
            }
        }
    }
}
