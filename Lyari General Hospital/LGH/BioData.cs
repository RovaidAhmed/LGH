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
    public partial class BioData : Form
    {
        public BioData()
        {
            InitializeComponent();
        }

        private void comboboxsex_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboboxsex.Items.Add("Male");
        }

        private void BioData_Load(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Other_Info_Biodata oib = new Other_Info_Biodata();
            oib.ShowDialog();
        }
    }
}
