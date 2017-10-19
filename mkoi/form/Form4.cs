using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mkoi.form
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();

        }

        public void createMatrix(int i, Bitmap processedImage)
        {
            PictureBox[] bit = {pictureBox0, pictureBox1, pictureBox2, pictureBox3,
                               pictureBox4, pictureBox5, pictureBox6, pictureBox7};

            bit[i].Image = processedImage;

        }
    }
}
