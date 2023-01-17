using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace саша1с
{
    public partial class aftor : Form
    {
        public aftor()
        {
            InitializeComponent();
        }

        private void aftor_Load(object sender, EventArgs e)
        {

        }

        private void vhidbtn_Click(object sender, EventArgs e)
        {

        }

        private void entrbtn_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4();
            this.Hide();
            frm.Show();
        }
    }
}
