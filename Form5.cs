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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "chitayGorodDataSet.Книги". При необходимости она может быть перемещена или удалена.
            this.книгиTableAdapter.Fill(this.chitayGorodDataSet.Книги);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form8 frm = new Form8();
            this.Hide();
            frm.Show();
        }
    }
}
