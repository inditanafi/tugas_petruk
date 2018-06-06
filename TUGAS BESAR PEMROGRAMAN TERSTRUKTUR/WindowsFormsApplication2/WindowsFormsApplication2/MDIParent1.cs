using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class MDIParent1 : Form
    {

        public MDIParent1()
        {
            InitializeComponent();
        }

        private void pendudukToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void dataPendudukToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 ss = new Form2();
            //ss.MdiParent = this;
            ss.Show();

        }

        private void dataKartuKeluargaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            datakk ss = new datakk();
            //ss.MdiParent = this;
            ss.Show();
        }

        private void dataMutasiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            datamutasi ss = new datamutasi();
            //ss.MdiParent = this;
            ss.Show();
        }

        private void toolTip_Popup(object sender, PopupEventArgs e)
        {

        }

    }
}
