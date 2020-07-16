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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void bioDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BioData bd = new BioData();
            bd.ShowDialog();
        }

        private void newDesignationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddDesignation addesign = new AddDesignation();
            addesign.ShowDialog();
        }

        private void sectionedPostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddSectionedpost post = new AddSectionedpost();
            post.ShowDialog();
        }
    }
}
