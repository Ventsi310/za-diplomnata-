using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uprrr.View
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void галерияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var gallery = new Gal();
            gallery.Closed += (s, args) => this.Close();
            gallery.Show();
        }

        private void услугиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var uslugi = new Uslugi();
            uslugi.Closed += (s, args) => this.Close();
            uslugi.Show();
        }

        private void gallery2_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
