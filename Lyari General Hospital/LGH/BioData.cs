using System;
using System.Windows.Forms;

namespace LGH
{
    public partial class BioData : Form
    {
        DataclassDataContext dc = new DataclassDataContext();

        public static string vname = "";
        public static string vsdwo = " ";
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
            vsdwo = txtsdwo.Text;
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


            //open another bio data form
            Other_Info_Biodata oib = new Other_Info_Biodata();
            oib.ShowDialog();
        }







    }
}
