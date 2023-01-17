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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Loadcapchaimage();
        }
        int number = 0;

        private void Loadcapchaimage();
        {
            Random r1 = new Random();
            number = r1.Next(100,10000);
            var image = new Bitmap(this.pictureBox1.Width, this.pictureBox1.Height);
            var font = new Font("TimesNewRoman", 25, FontStyle.Bold, GraphicsUnit.Pixel);
            var graphics = Graphics.FromImage(image);
            Graphics.DrawString(number.ToString(), font, Brushes.Green, new Point (0, 0));
            pictureBox1.Image = image;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
    private string text = String.Empty;
}

