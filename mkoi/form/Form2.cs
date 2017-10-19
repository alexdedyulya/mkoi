using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using mkoi;
//using System.Web.UI.DataVisualization.Charting;
using System.Windows.Forms.DataVisualization.Charting;

namespace mkoi
{
    public partial class Form2 : Form
    {
        byte[,] defaultImageMatrix;
        byte[,] processedImageMatrix;
        int[] a;

        public Form2(byte[,] defaultImageMatrix, byte[,] processedImageMatrix, int[] a)
        {
            InitializeComponent();
            this.defaultImageMatrix = defaultImageMatrix;
            this.processedImageMatrix = processedImageMatrix;
            this.a = a;
        }

    }
}
