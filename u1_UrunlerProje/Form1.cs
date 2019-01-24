using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace u1_UrunlerProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void küpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKup frmKup = new FrmKup();
            frmKup.ShowDialog();    // showdialog sayesinde :  form açılınca diğerlerinin üzerinde durur.
        }

        private void dörtgenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDortgen frmDortgen = new FrmDortgen();
            frmDortgen.ShowDialog();
        }

        private void silindirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSilindir frmSilindir = new FrmSilindir();
            frmSilindir.ShowDialog();
        }
    }
}
