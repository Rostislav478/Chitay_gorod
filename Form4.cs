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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            loadcaptachaimage();
        }

        int num = 0;
        private void loadcaptachaimage()
        {
            //throw new NotImplementedException();
            Random r1 = new Random();
            num = r1.Next(1000, 9999);
            var img = new Bitmap(this.pictureBox1.Width, this.pictureBox1.Height);
            var font = new Font("Comic Sans MS", 30, FontStyle.Strikeout, GraphicsUnit.Pixel);
            var graphics = Graphics.FromImage(img);
            graphics.DrawString(num.ToString(), font, Brushes.Orange, new Point(0, 0));
            pictureBox1.Image = img;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadcaptachaimage();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text==num.ToString())
            {
                MessageBox.Show("Капча введена верно");
            }
            else
            {
                MessageBox.Show("Капча введена неверно");
            }
            Form8 frm = new Form8();
            this.Hide();
            frm.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
