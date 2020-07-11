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
    public partial class Other_Info_Biodata : Form
    {

        DataclassDataContext dv = new DataclassDataContext();
        public Other_Info_Biodata()
        {
            InitializeComponent();
        }

        private void Other_Info_Biodata_Load(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Insert_Data();
        }


        //Insert data 
        public void Insert_Data()
        {
            try
            {
                Bio_Data_Form bdf = new Bio_Data_Form
                {
                    //Date_Of_Joinning=Convert.ToDateTime(dateTimePickerjoingovt.Text)
                    //Get values from BioData Form

                    Name = BioData.vname,
                    SDW_O = BioData.vsdwo,
                    SDW_O_Name = BioData.vsdwo_name,
                    DOB = Convert.ToDateTime(BioData.vDOB),
                    Date_of_Superannuation = Convert.ToDateTime(BioData.vDateofSuperannuation),
                    Sex = BioData.vsex,
                    Martial_Status = BioData.vmartialstatus,
                    Next_Of_Kin = BioData.vnextkin,
                    Permanent_Address = BioData.vaddress,
                    Cnic_No = BioData.vcnic,
                    Cell_No = BioData.vcnic,
                    Emergency_ContactNo = BioData.vemergencyno,
                    Landline_PTCL_No = BioData.vlandline,
                    Passport_No = BioData.vpassportno,
                    Email = BioData.vemail,
                    Domicile = BioData.vdomicile,
                    PRC = BioData.vprc,
                    Personal_No = BioData.vpersonalno,
                    Service_Book_No = BioData.vservicebookno,
                    Date_Of_Joinning = Convert.ToDateTime(BioData.vdateofjoinninggovt),
                    Joinning_at_LGHK = Convert.ToDateTime(BioData.vjoinlghk),
                    Joinning_at_LGHK_no = Convert.ToInt32(BioData.vjoinlghkno),
                    Posted_at_LGHK_On = BioData.vpostedlghkon,
                    Status_Before_Joinning_LGHK = BioData.vstatusbeforejoinlghk,
                    Posted_at_LGHK_In = BioData.vpostedatlghkin,
                    lghk_vacantpost = BioData.vlghkvacantpost,
                    Designation = BioData.vdesignation,
                    Cadre = BioData.vcadre,
                    BPS = Convert.ToInt32(BioData.vbps),
                    Service_Type = comboBoxservicetype.Text,
                    Service_Type_Datetime = Convert.ToDateTime(dateTimePickerservicetype.Text),
                    PM_DC_ = txtpmdcno.Text,
                    Qualification = txtqualification.Text,
                    Any_Other_Qualification = txtotherdiploma.Text,
                    Last_Institute = txtlastinstitute.Text,
                    Date_Last_Promotion = Convert.ToDateTime(dateTimePickerlastpromotion.Text),
                    DOL_Ex_Pak_Leave = Convert.ToDateTime(dateTimePickerpakleave.Text),
                    Remarks = txtremarks.Text




                };

                dv.Bio_Data_Forms.InsertOnSubmit(bdf);
                dv.SubmitChanges();
                MessageBox.Show("Successfully Add New Record", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                BioData b = new BioData();
                b.Hide();

            }
            catch(Exception ex)
            {
                MessageBox.Show("Kindly fill the Form Completely ", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

            }
        }






    }
}
