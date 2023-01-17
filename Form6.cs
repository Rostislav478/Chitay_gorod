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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "chitayGorodDataSet.ПродажаКниги". При необходимости она может быть перемещена или удалена.
            this.продажаКнигиTableAdapter.Fill(this.chitayGorodDataSet.ПродажаКниги);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "chitayGorodDataSet.Продажи". При необходимости она может быть перемещена или удалена.
            this.продажиTableAdapter.Fill(this.chitayGorodDataSet.Продажи);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form8 frm = new Form8();
            this.Hide();
            frm.Show();
        }
    }
}
