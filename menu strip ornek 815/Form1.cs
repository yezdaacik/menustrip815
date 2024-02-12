using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menu_strip_ornek_815
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            OgrenciEkle ogrenciEkle = new OgrenciEkle();
            ogrenciEkle.ShowDialog();
        }

        private void cmDuzen_Opening(object sender, CancelEventArgs e)
        {
            rtxtYazi.Cut();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void kalınToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtxtYazi.SelectionFont = new Font(rtxtYazi.Font, FontStyle.Bold);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            rtxtYazi.Font = new Font("Arial Black", 12);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            rtxtYazi.Font = new Font("Arial Black", 15);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            rtxtYazi.Font = new Font("Arial Black", 20);
        }
    }
}
