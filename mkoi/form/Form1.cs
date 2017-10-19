using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing.Imaging;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using mkoi.form;



namespace mkoi
{
    
    public partial class Form1 : Form
    {

        byte[,] defaultImageMatrix;
        byte[,] processedImageMatrix;

        int[] a;

        
        public Form1()
        {
            InitializeComponent();
            
        }

        

        Bitmap defaultImage;
        //Bitmap processedImage;
       

        

        private void OpenButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Open File";
            openFileDialog1.Filter = "jpeg files (*.jpg)|*.jpg| png files (*.png)|*.png| bmp files (*.bmp)|*.bmp";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                defaultImage = new Bitmap(openFileDialog1.FileName);
                openedPictureBox.Image = defaultImage;
                FillDefaultImageMatrix();
                CopyDefaultToProcessMatrix();
            }
        }

        private void FillDefaultImageMatrix()
        { 
            // срздать матрицу размера изображения
            defaultImageMatrix = new byte[defaultImage.Width, defaultImage.Height];
            // попиксельно перенести цвета в матрицу
            for (int x = 0; x < defaultImage.Width; x++)
            {
                for (int y = 0; y < defaultImage.Height; y++)
                {
                    Color pixel = defaultImage.GetPixel(x, y);
                    defaultImageMatrix[x, y] = (byte)(0.3 * pixel.R + 0.6 * pixel.G + 0.1 * pixel.B);
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (processedPictureBox.Image != null)
            {
                saveFileDialog1.Title = "Save File";
                saveFileDialog1.Filter = "jpeg files (*.jpg)|*.jpg| png files (*.png)|*.png";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    ImageFormat format = ImageFormat.Png;
                    switch (saveFileDialog1.FilterIndex)
                    {
                        case 1:
                            format = ImageFormat.Png;
                            break;
                        case 2:
                            format = ImageFormat.Jpeg;
                            break;
                    }
                    processedImage.Save(saveFileDialog1.FileName, format);
                }
            }
            else
            {
                MessageBox.Show("Second picture Box is empty!");
            }
        }

        private void processButton_Click(object sender, EventArgs e)
        {
            if(openedPictureBox.Image != null)
            {
            // перенесем default matrix processed matrix
            CopyDefaultToProcessMatrix();
            // восстановим из processed matrix - processed image
            CreateProcessImageFromMatrix();
            // итоговое изобрадение (результат записать в processed pictures box)
            //processedPictureBox.Image = processedImage;
            }
            else
            {
                MessageBox.Show("Download picture!");
            }
        }

        private void CopyDefaultToProcessMatrix()
        {
            processedImageMatrix = new byte[defaultImageMatrix.GetLength(0), defaultImageMatrix.GetLength(1)]; // по размерностям
            for (int x = 0; x < defaultImageMatrix.GetLength(0); x++)
            {
                for (int y = 0; y < defaultImageMatrix.GetLength(1); y++)
                {
                    processedImageMatrix[x, y] = defaultImageMatrix[x, y];
                }
            }
        }

        private void CreateProcessImageFromMatrix()
        {
            processedImage = new Bitmap(processedImageMatrix.GetLength(0), processedImageMatrix.GetLength(1));
            for (int x = 0; x < processedImageMatrix.GetLength(0); x++)
            {
                for (int y = 0; y < processedImageMatrix.GetLength(1); y++)
                {
                    Color pixel = Color.FromArgb(processedImageMatrix[x, y], processedImageMatrix[x, y], processedImageMatrix[x, y]);
                    processedImage.SetPixel(x, y, pixel);
                }
            }
            processedPictureBox.Image = processedImage;
        }

        private void addConstButton_Click(object sender, EventArgs e)
        {
            // к default Matrix добавлять константу из addConstTextBox
            // считать из textbox значение
            int additionalValue = 0;
            if (openedPictureBox.Image != null)
            {
            try
            {
                additionalValue = Convert.ToInt32(additionalConstantTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Incorrect Value");
                additionalConstantTextBox.Clear();
                return;
            }
            
            AddValue(additionalValue);
            // восстанавливать Image from Matrix
            CreateProcessImageFromMatrix();
            //рисовать в Picture Box
            //processedPictureBox.Image = processedImage;
            }
            else
            {
                MessageBox.Show("Download picture!");
            }
        }

        private void AddValue(int value)
        {
            processedImageMatrix = new byte[defaultImageMatrix.GetLength(0), defaultImageMatrix.GetLength(1)]; // по размерностям
            for (int x = 0; x < defaultImageMatrix.GetLength(0); x++)
            {
                for (int y = 0; y < defaultImageMatrix.GetLength(1); y++)
                {
                    int result = defaultImageMatrix[x, y] + value;
                    if (result > 255)
                    {
                        result = 255;
                    }
                    else if (result < 0)
                    {
                        result = 0;
                    }
                    processedImageMatrix[x, y] = (byte)result;
                }
            }
        }

        private void negativButton_Click(object sender, EventArgs e)
        {
            if (openedPictureBox.Image != null)
            {
            // перевести dtfault matrix в нешатив
            Negativ();
            //построить изображение
            CreateProcessImageFromMatrix();
            }
            else
            {
                MessageBox.Show("Download picture!");
            }
        }

        private void Negativ()
        {
            processedImageMatrix = new byte[defaultImageMatrix.GetLength(0), defaultImageMatrix.GetLength(1)]; // по размерностям
            for (int x = 0; x < defaultImageMatrix.GetLength(0); x++)
            {
                for (int y = 0; y < defaultImageMatrix.GetLength(1); y++)
                {
                    processedImageMatrix[x, y] = (byte)(255-defaultImageMatrix[x, y]);
                }
            }
        }

        
        private void multiConstButton_Click(object sender, EventArgs e)
        {
            // к default Matrix добавлять константу из multiConstTextBox
            // считать из textbox значение
            double multiValue = 0;
            if (openedPictureBox.Image != null)
            {
            try
            {
                multiValue = Convert.ToDouble(multiConstTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Incorrect Value");
                multiConstTextBox.Clear();
                return;
            }
            multValue(multiValue);
            // восстанавливать Image from Matrix
            CreateProcessImageFromMatrix();
            //рисовать в Picture Box
            //processedPictureBox.Image = processedImage;
            }
            else
            {
                MessageBox.Show("Download picture!");
            }

        }

        private void multValue(double value)
        {
            processedImageMatrix = new byte[defaultImageMatrix.GetLength(0), defaultImageMatrix.GetLength(1)]; // по размерностям
            for (int x = 0; x < defaultImageMatrix.GetLength(0); x++)
            {
                for (int y = 0; y < defaultImageMatrix.GetLength(1); y++)
                {
                    double result = defaultImageMatrix[x, y] * value;
                    if (result > 255)
                    {
                        result = 255;
                    }
                    else if (result < 0)
                    {
                        result = 0;
                    }
                    processedImageMatrix[x, y] = (byte)result;
                }
            }
        }

        private void gradButton_Click(object sender, EventArgs e)
        {
            // к default Matrix добавлять константу из GradTextBox
            // считать из textbox значение
            double gradValue = 0;
            if (openedPictureBox.Image != null)
            {
                try
                {
                    gradValue = Convert.ToDouble(gradTextBox.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Incorrect Value");
                    gradTextBox.Clear();
                    return;
                }
                gradConstValue(gradValue);
                // восстанавливать Image from Matrix
                CreateProcessImageFromMatrix();
                //рисовать в Picture Box
                //processedPictureBox.Image = processedImage;
            }
            else
            {
                MessageBox.Show("Download picture!");
            }
        }

        private void gradConstValue(double value)
        {
            double maxv = max();
            processedImageMatrix = new byte[defaultImageMatrix.GetLength(0), defaultImageMatrix.GetLength(1)]; // по размерностям
            for (int x = 0; x < defaultImageMatrix.GetLength(0); x++)
            {
                for (int y = 0; y < defaultImageMatrix.GetLength(1); y++)
                {
                    double result = 255 * Math.Pow((defaultImageMatrix[x, y]/maxv),value);
                    if (result > 255)
                    {
                        result = 255;
                    }
                    else if (result < 0)
                    {
                        result = 0;
                    }
                    processedImageMatrix[x, y] = (byte)result;
                }
            }
        }


        private void logButton_Click(object sender, EventArgs e)
        {
            // к default Matrix добавлять константу из logTextBox
            // считать из textbox значение
            double logValue = 0;
            if (openedPictureBox.Image != null)
            {
            try
            {
                logValue = Convert.ToDouble(logTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Incorrect Value");
                logTextBox.Clear();
                return;
            }
            logConstValue(logValue);
            // восстанавливать Image from Matrix
            CreateProcessImageFromMatrix();
            //рисовать в Picture Box
            //processedPictureBox.Image = processedImage;
            }
            else
            {
                MessageBox.Show("Download picture!");
            }
        }

        private void logConstValue(double value)
        {
            double maxv = max();
            processedImageMatrix = new byte[defaultImageMatrix.GetLength(0), defaultImageMatrix.GetLength(1)]; // по размерностям
            for (int x = 0; x < defaultImageMatrix.GetLength(0); x++)
            {
                for (int y = 0; y < defaultImageMatrix.GetLength(1); y++)
                {
                    //double result = 255.0 * (Math.Log((1+defaultImageMatrix[x,y]),value)/(Math.Log((1+maxv),value)));
                    double result = 255.0 * (Math.Log((value-1)*defaultImageMatrix[x,y]/maxv+1, value));
                    if (result > 255)
                    {
                        result = 255;
                    }
                    else if (result < 0)
                    {
                        result = 0;
                    }
                    processedImageMatrix[x, y] = (byte)result;
                }
            }
        }

        private double max()
        { 
            double max = 0;
            for (int i = 0; i < defaultImageMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < defaultImageMatrix.GetLength(1); j++)
                {
                    if (defaultImageMatrix[i, j] >= max)
                    {
                        max = defaultImageMatrix[i, j];
                    }
                }
            }
            return max;
        }

        private double min()
        {
            double min=255;
            for (int i = 0; i < defaultImageMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < defaultImageMatrix.GetLength(1); j++)
                {
                    if (defaultImageMatrix[i, j] <= min)
                    {
                        min = defaultImageMatrix[i, j];
                    }
                }
            }
            return min;
        }


        private void gistoButton_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            if (openedPictureBox.Image != null && processedPictureBox != null)
            {
                gisto();
            }
            else
            {
                MessageBox.Show("Download picture!");
            }
        }


        private void gisto()
        {
            a = new int[256];
            for (int i = 0; i < defaultImageMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < defaultImageMatrix.GetLength(1); j++)
                {
                    for (int k = 0; k < 256; k++)
                    {
                        if (processedImageMatrix[i, j] == k)
                        {
                            a[k]++;
                            break;
                        }
                    }
                }
            }
       
            for (int y = 0; y < 256; y ++)
            {
                chart1.Series["Piksel"].Points.AddXY(y, a[y]);
            }
            
        }

        
        private void equalButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (openedPictureBox.Image != null && processedPictureBox != null)
                {

                    equaliz();
                }
                else
                {
                    MessageBox.Show("Download picture!");
                }
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("Сначала сделайте гистограмму");
            }
        }


        public void equaliz()
        {
            int havg = defaultImageMatrix.GetLength(0) * defaultImageMatrix.GetLength(1) / 256;
            int z = 0;
            int h = 0;
            int[] left = new int[256];
            int[] right = new int[256];
            int[] abc = new int[256];


            for (int j = 0; j < 256; j++)
            {
                left[j] = z;
                h += a[j];
                
                while (h > havg)
                {
                    h -= havg;
                    z++;
                }
                right[j] = z;
                abc[j] = (right[j] + left[j])/2;
            }

            for (int i = 0; i < defaultImageMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < defaultImageMatrix.GetLength(1); j++)
                {
                    if (left[processedImageMatrix[i, j]] == right[processedImageMatrix[i, j]])
                    {
                        processedImageMatrix[i, j] = (byte)left[processedImageMatrix[i, j]];
                    }
                    else
                    {
                        processedImageMatrix[i, j] = (byte)abc[processedImageMatrix[i, j]];
                    }
                }
            }

            int[] b = new int[256];
            for (int i = 0; i < defaultImageMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < defaultImageMatrix.GetLength(1); j++)
                {
                    for (int k = 0; k < 256; k++)
                    {
                        if (processedImageMatrix[i, j] == k)
                        {
                            b[k]++;
                            break;
                        }
                    }
                }
            }

            CreateProcessImageFromMatrix();
            Form2 gis = new Form2(defaultImageMatrix, processedImageMatrix, a);

            for (int y = 0; y < 256; y++)
            {
                gis.chart1.Series["Series1"].Points.AddXY(y, b[y]);
            }
            gis.ShowDialog();
        }

        private void CreateProcessImageFromFo3()
        {
            processedImage = new Bitmap(processedImageMatrix.GetLength(0), processedImageMatrix.GetLength(1));
            for (int x = 0; x < processedImageMatrix.GetLength(0); x++)
            {
                for (int y = 0; y < processedImageMatrix.GetLength(1); y++)
                {
                    Color pixel = Color.FromArgb(processedImageMatrix[x, y], processedImageMatrix[x, y], processedImageMatrix[x, y]);
                    processedImage.SetPixel(x, y, pixel);
                }
            }
            Form3 kon = new Form3();
            kon.kontPictureBox.Image = processedImage;
            kon.ShowDialog();
        }

        private void konstraktButton_Click(object sender, EventArgs e)
        {
            if (openedPictureBox.Image != null && processedPictureBox != null)
            {
                double maxvalue;
                double minvalue;
                try
                {
                    maxvalue = Convert.ToDouble(maxcontrTextBox.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Incorrect Value");
                    maxcontrTextBox.Clear();
                    return;
                }

                try
                {
                    minvalue = Convert.ToDouble(mincontrTextBox.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Incorrect Value");
                    mincontrTextBox.Clear();
                    return;
                }

                konstrakt(maxvalue, minvalue);

                CreateProcessImageFromFo3();
            }
            else
            {
                MessageBox.Show("Download picture!");
            }

        }

        private void konstrakt(double maxv, double minv)
        {
            processedImageMatrix = new byte[defaultImageMatrix.GetLength(0), defaultImageMatrix.GetLength(1)]; // по размерностям
            for (int x = 0; x < defaultImageMatrix.GetLength(0); x++)
            {
                for (int y = 0; y < defaultImageMatrix.GetLength(1); y++)
                {
                    
                    double result = 255.0/(maxv-minv)*(defaultImageMatrix[x,y]-minv);
                    if (result > 255)
                    {
                        result = 255;
                    }
                    else if (result < 0)
                    {
                        result = 0;
                    }
                    processedImageMatrix[x, y] = (byte)result;
                }
            }
    
        }

        byte[,] newImageMatrix;

        private void bitploskButton_Click(object sender, EventArgs e)
        {
            if (openedPictureBox.Image != null && processedPictureBox != null)
            {
                newImageMatrix = new byte[processedImageMatrix.GetLength(0), processedImageMatrix.GetLength(1)];
                for (int x = 0; x < processedImageMatrix.GetLength(0); x++)
                {
                    for (int y = 0; y < processedImageMatrix.GetLength(1); y++)
                    {
                        newImageMatrix[x, y] = processedImageMatrix[x, y];
                    }
                }

                Form4 bitp;
                bitp = new Form4();

                for (int i = 0; i < 8; i++)
                {
                    bitplosk();
                    CreateProcessImageFromMatrix();
                    bitp.createMatrix(i, processedImage);

                }
                bitp.ShowDialog();
            }
            else
            {
                MessageBox.Show("Download picture!");
            }
        }

        private void bitplosk()
        {
            processedImageMatrix = new byte[defaultImageMatrix.GetLength(0), defaultImageMatrix.GetLength(1)]; // по размерностям
         
            for (int x = 0; x < defaultImageMatrix.GetLength(0); x++)
            {
                for (int y = 0; y < defaultImageMatrix.GetLength(1); y++)
                {

                    double result = newImageMatrix[x, y]%2;
                    processedImageMatrix[x, y] = (byte)(result*255);
                    newImageMatrix[x, y] /= 2;
                }
            }
        }



        

        private void obrabotkaButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (openedPictureBox.Image != null && processedPictureBox != null)
                {

                    double value;
                    try
                    {
                        value = Convert.ToDouble(obrabtextBox.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Incorrect Value");
                        obrabtextBox.Clear();
                        return;
                    }

                    obrabotka(value);
                    CreateProcessImageFromFo3();
                }
                else
                {
                    MessageBox.Show("Download picture!");
                }
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("Сначала сделайте гистограмму");
            }
            
        }

        private void obrabotka(double value)
        {
            double e = 1e-3;
            double k = defaultImageMatrix.GetLength(0) * defaultImageMatrix.GetLength(1);
            double sum1 = 0;
            double sum2 = 0;
            Boolean n = true;
      
            while(n==true){
            sum1 = 0;
            sum2 = 0;

            for (int x = 0; x <= (int)value; x++)
            {
                sum1 += a[x] / k;
            }

            sum2 = 1 - sum1;
            double m0 = 0;
            for (int i = 0; i <= (int)value; i++)
            {
                m0 += (i * a[i] / k) / sum1;
            }

            double m1 = 0;
            for (int i = (int)value + 1; i < a.Length; i++)
            {
                m1 += (i * a[i] / k) / sum2;
            }
            double g = (m0 + m1) / 2;
            double h = g - value;

            if (Math.Abs(h) > e)
            {
                value = g;
            }
            else
            {
                n = false;
            }
            }


            for (int i = 0; i < defaultImageMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < defaultImageMatrix.GetLength(1); j++)
                {
                        if (processedImageMatrix[i,j] <= value)
                        {
                            processedImageMatrix[i,j] = 0;
                        }
                        else 
                        {
                            processedImageMatrix[i,j] = 255;
                        }
                }
            }

            string sr4 = Convert.ToString(value);
            MessageBox.Show(sr4);
            
        }

        private void obrGradButton_Click(object sender, EventArgs e)
        {
            if (openedPictureBox.Image != null && processedPictureBox != null)
            {

                obrGrad();
                CreateProcessImageFromFo3();
            }
            else
            {
                MessageBox.Show("Download picture!");
            }
            
        }

        private void obrGrad()
        {
            int t;
            byte[,] obrGradImageMatrix = new byte[defaultImageMatrix.GetLength(0), defaultImageMatrix.GetLength(1)];
            byte[,] obrGradImageMatrix1 = new byte[defaultImageMatrix.GetLength(0), defaultImageMatrix.GetLength(1)];
            byte[,] obrGradImageMatrix2 = new byte[defaultImageMatrix.GetLength(0), defaultImageMatrix.GetLength(1)];
            for (int i = 1; i < defaultImageMatrix.GetLength(0)-1; i++)
            {
                for (int j = 1; j < defaultImageMatrix.GetLength(1)-1; j++)
                {
                    obrGradImageMatrix1[i, j] = (byte)(Math.Abs(defaultImageMatrix[i + 1, j] - defaultImageMatrix[i-1,j]));
                    obrGradImageMatrix2[i, j] = (byte)(Math.Abs(defaultImageMatrix[i, j+1] - defaultImageMatrix[i, j-1]));
                    if (obrGradImageMatrix1[i, j] > obrGradImageMatrix2[i, j])
                        obrGradImageMatrix[i, j] = obrGradImageMatrix1[i, j];
                    else
                    {
                        obrGradImageMatrix[i, j] = obrGradImageMatrix2[i, j];
                    }
                }
            }

            int t1 = 0;
            for (int i = 0; i < defaultImageMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < defaultImageMatrix.GetLength(1); j++)
                {
                    t1 += defaultImageMatrix[i, j] * obrGradImageMatrix[i, j];
                }
            }
            int t2 = 0;
            for (int i = 0; i < defaultImageMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < defaultImageMatrix.GetLength(1); j++)
                {
                    t2 += obrGradImageMatrix[i, j];
                }
            }

            t = t1 / t2;
            //string sr4 = Convert.ToString(t);
            //MessageBox.Show(sr4);
            for (int i = 0; i < defaultImageMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < defaultImageMatrix.GetLength(1); j++)
                {
                    if (processedImageMatrix[i, j] <= t)
                    {
                        processedImageMatrix[i, j] = 0;
                    }
                    else
                    {
                        processedImageMatrix[i, j] = 255;
                    }
                }
            }

        }

        private void otsaButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (openedPictureBox.Image != null && processedPictureBox != null)
                {

                    otsaObrabotka();
                    CreateProcessImageFromFo3();
                }
                else
                {
                    MessageBox.Show("Download picture!");
                }
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("Сначала сделайте гистограмму");
            }
            
        }
        
        private void otsaObrabotka()
        {
            double k = defaultImageMatrix.GetLength(0) * defaultImageMatrix.GetLength(1);
            double maxdisp = -1;
            double sum1 = 0;
            double sum2 = 0;
            double m0 = 0;
            double m1 = 0;
            double over0 = 0;
            double over1 = 0;
            double disv = 0;
            int t = 0;


            for (int x = 0; x < a.Length; x++)
            {
                for (int y = 0; y < a.Length; y++)
                {
                    
                    if (y <= x)
                    {
                        sum1 += a[y] / k;
                        over0 += y * a[y] / k;
                    }
                    else
                    {
                        sum2 += a[y] / k;
                        over1 += y * a[y] / k;
                    }
                }
                m0 = over0 / sum1;
                m1 = over1 / sum2;
                disv = sum1*sum2*(Math.Pow(m0-m1,2));
                if (disv > maxdisp)
                {
                    maxdisp = disv;
                    t = x;
                }
                sum1 = 0;
                sum2 = 0;
                over0 = 0;
                over1 = 0;
            }

            string sr4 = Convert.ToString(t);
            MessageBox.Show(sr4);

                for (int i = 0; i < defaultImageMatrix.GetLength(0); i++)
                {
                    for (int j = 0; j < defaultImageMatrix.GetLength(1); j++)
                    {
                        if (processedImageMatrix[i, j] <= t)
                        {
                            processedImageMatrix[i, j] = 0;
                        }
                        else
                        {
                            processedImageMatrix[i, j] = 255;
                        }
                    }
                }
            
        }

        byte[,] new1ImageMatrix;

        private void createFromFo3WithNewMat(byte[,] newmatrix)
        {
            processedImage = new Bitmap(processedImageMatrix.GetLength(0), processedImageMatrix.GetLength(1));
            for (int x = 0; x < processedImageMatrix.GetLength(0); x++)
            {
                for (int y = 0; y < processedImageMatrix.GetLength(1); y++)
                {
                    Color pixel = Color.FromArgb(newmatrix[x, y], newmatrix[x, y], newmatrix[x, y]);
                    processedImage.SetPixel(x, y, pixel);
                }
            }
            Form3 kon = new Form3();
            kon.kontPictureBox.Image = processedImage;
            kon.ShowDialog();
        }

        private void nizkochastButton_Click(object sender, EventArgs e)
        {
            if (openedPictureBox.Image != null && processedPictureBox != null)
            {
                int size = Convert.ToInt32(sizeTextBox.Text);
                new1ImageMatrix = new byte[processedImageMatrix.GetLength(0), processedImageMatrix.GetLength(1)];
                for (int x = 0; x < processedImageMatrix.GetLength(0); x++)
                {
                    for (int y = 0; y < processedImageMatrix.GetLength(1); y++)
                    {
                        new1ImageMatrix[x, y] = defaultImageMatrix[x, y];
                    }
                }
                LPF(size);
                createFromFo3WithNewMat(new1ImageMatrix);
                
            }
            else
            {
                MessageBox.Show("Download picture!");
            }
        }

        private void LPF(int size)
        {
            
            int w = size * size;
            int bound = (size - 1) / 2;
            int result = 0;
            for (int x = bound; x < defaultImageMatrix.GetLength(0) - bound; x++)
            {
                for (int y = bound; y < defaultImageMatrix.GetLength(1) - bound; y++)
                {

                    for (int i = -bound; i <= bound; i++)
                        for (int j = -bound; j <= bound; j++)
                        {
                            result += processedImageMatrix[x + i, y + j];
                        }
                    new1ImageMatrix[x, y] = (byte)(result / w);
                    result = 0;
                }
            }
        }

        byte[,] new2ImageMatrix;

        private void gaussButton_Click(object sender, EventArgs e)
        {
            if (openedPictureBox.Image != null && processedPictureBox != null)
            {
                new2ImageMatrix = new byte[processedImageMatrix.GetLength(0), processedImageMatrix.GetLength(1)];
                for (int x = 0; x < processedImageMatrix.GetLength(0); x++)
                {
                    for (int y = 0; y < processedImageMatrix.GetLength(1); y++)
                    {
                        new1ImageMatrix[x, y] = defaultImageMatrix[x, y];
                    }
                }
                gauss();
                createFromFo3WithNewMat(new2ImageMatrix);

            }
            else
            {
                MessageBox.Show("Download picture!");
            }
        }

        private void gauss()
        {

            double w = 32;
            double a = 4;
            double b = 12;
            for (int x = 0; x < defaultImageMatrix.GetLength(0); x++)
            {
                for (int y = 0; y < defaultImageMatrix.GetLength(1); y++)
                {
                    if (x == 0 || y == 0 || x == defaultImageMatrix.GetLength(0) - 1 || y == defaultImageMatrix.GetLength(1) - 1)
                    {

                    }
                    else
                    {

                        new2ImageMatrix[x, y] = (byte)(1 / w * (processedImageMatrix[x - 1, y - 1] + processedImageMatrix[x, y - 1]*a +
                            processedImageMatrix[x + 1, y - 1] + processedImageMatrix[x - 1, y]*a + processedImageMatrix[x + 1, y]*a +
                            processedImageMatrix[x - 1, y + 1] + processedImageMatrix[x + 1, y + 1] + processedImageMatrix[x, y + 1]*a +
                            processedImageMatrix[x, y]*b));
                    }
                    
                }
            }
            
        }

        private void reskoztButton_Click(object sender, EventArgs e)
        {
            if (openedPictureBox.Image != null && processedPictureBox != null)
            {
                new2ImageMatrix = new byte[processedImageMatrix.GetLength(0), processedImageMatrix.GetLength(1)];
                for (int x = 0; x < processedImageMatrix.GetLength(0); x++)
                {
                    for (int y = 0; y < processedImageMatrix.GetLength(1); y++)
                    {
                        new2ImageMatrix[x, y] = defaultImageMatrix[x, y];
                    }
                }
                reskoztLaplasian();
                createFromFo3WithNewMat(new2ImageMatrix);

            }
            else
            {
                MessageBox.Show("Download picture!");
            }
        }

        private void reskoztLaplasian()
        {

            double w = 1;
            double a = -1;
            double b = 9;
            int bound = (3 - 1) / 2;
            int[,] addpixelmatrix = new int[defaultImageMatrix.GetLength(0), defaultImageMatrix.GetLength(1)];

            for (int x = 0; x < defaultImageMatrix.GetLength(0); x++)
            {
                for (int y = 0; y < defaultImageMatrix.GetLength(1); y++)
                {
                    if (x == 0 || y == 0 || x == defaultImageMatrix.GetLength(0) - 1 || y == defaultImageMatrix.GetLength(1) - 1)
                    {

                    }
                    else
                    {

                        addpixelmatrix[x, y] = (int)(1 / w * (processedImageMatrix[x - 1, y - 1] * a + processedImageMatrix[x, y - 1] * a +
                            processedImageMatrix[x + 1, y - 1] * a + processedImageMatrix[x - 1, y] * a + processedImageMatrix[x + 1, y] * a +
                            processedImageMatrix[x - 1, y + 1] * a + processedImageMatrix[x + 1, y + 1] * a + processedImageMatrix[x, y + 1] * a +
                            processedImageMatrix[x, y] * b));
                    }
                }
            }

            int max = addpixelmatrix.Cast<int>().Max();
            int min = addpixelmatrix.Cast<int>().Min();
            double help = 0;
            for (int x = bound; x < defaultImageMatrix.GetLength(0) - bound; x++)
            {
                for (int y = bound; y < defaultImageMatrix.GetLength(1) - bound; y++)
                {
                    help = (double)255 / (max-min);
                    help *= (addpixelmatrix[x, y] - min);
                    new2ImageMatrix[x, y] = (byte)help;

                }
            }

        }

        private void nerezMaskButton_Click(object sender, EventArgs e)
        {
        if (openedPictureBox.Image != null && processedPictureBox != null)
            {
                new2ImageMatrix = new byte[processedImageMatrix.GetLength(0), processedImageMatrix.GetLength(1)];
                for (int x = 0; x < processedImageMatrix.GetLength(0); x++)
                {
                    for (int y = 0; y < processedImageMatrix.GetLength(1); y++)
                    {
                        new2ImageMatrix[x, y] = defaultImageMatrix[x, y];
                    }
                }
                nerezkmask();
                createFromFo3WithNewMat(new2ImageMatrix);

            }
            else
            {
                MessageBox.Show("Download picture!");
            }
        }

        private void nerezkmask()
        {
            double w = 9;
            double a = -1;
            double b = 9;
            double k = 8;
            int bound = (3 - 1) / 2;
            int[,] addpixelmatrix = new int[defaultImageMatrix.GetLength(0), defaultImageMatrix.GetLength(1)];

            for (int x = 0; x < defaultImageMatrix.GetLength(0); x++)
            {
                for (int y = 0; y < defaultImageMatrix.GetLength(1); y++)
                {
                    if (x == 0 || y == 0 || x == defaultImageMatrix.GetLength(0) - 1 || y == defaultImageMatrix.GetLength(1) - 1)
                    {

                    }
                    else
                    {

                        addpixelmatrix[x, y] = (int)(1 / w * (processedImageMatrix[x - 1, y - 1] * a + processedImageMatrix[x, y - 1] * a +
                            processedImageMatrix[x + 1, y - 1] * a + processedImageMatrix[x - 1, y] * a + processedImageMatrix[x + 1, y] * a +
                            processedImageMatrix[x - 1, y + 1] * a + processedImageMatrix[x + 1, y + 1] * a + processedImageMatrix[x, y + 1] * a +
                            processedImageMatrix[x, y] * (b+k)));
                    }
                }
            }

            int max = addpixelmatrix.Cast<int>().Max();
            int min = addpixelmatrix.Cast<int>().Min();
            double help = 0;
            for (int x = bound; x < defaultImageMatrix.GetLength(0) - bound; x++)
            {
                for (int y = bound; y < defaultImageMatrix.GetLength(1) - bound; y++)
                {
                    help = (double)255 / (max-min);
                    help *= (addpixelmatrix[x, y] - min);
                    //if (help <0)
                    //{
                    //    MessageBox.Show(">255");
                    //}
                    new2ImageMatrix[x, y] = (byte)help;

                }
            }

        }

        private void medButton_Click(object sender, EventArgs e)
        {
            if (openedPictureBox.Image != null && processedPictureBox != null)
            {
                int size = Convert.ToInt32(sizeTextBox.Text);
                new2ImageMatrix = new byte[processedImageMatrix.GetLength(0), processedImageMatrix.GetLength(1)];
                for (int x = 0; x < processedImageMatrix.GetLength(0); x++)
                {
                    for (int y = 0; y < processedImageMatrix.GetLength(1); y++)
                    {
                        new2ImageMatrix[x, y] = defaultImageMatrix[x, y];
                    }
                }
                medianna(size);
                createFromFo3WithNewMat(new2ImageMatrix);
                
            }
            else
            {
                MessageBox.Show("Download picture!");
            }
        }

        private void medianna(int size)
        {
            
            int bound = (size - 1) / 2;
            int[] help = new int[size * size];
            for (int x = bound; x < defaultImageMatrix.GetLength(0) - bound; x++)
            {
                for (int y = bound; y < defaultImageMatrix.GetLength(1) - bound; y++)
                {

                    for (int i = -bound; i <= bound; i++)
                        for (int j = -bound; j <= bound; j++)
                        {
                            help[(i + bound) * size + j + bound] = processedImageMatrix[x + i, y + j];
                        }
                    Array.Sort(help);
                    new2ImageMatrix[x, y] = (byte)help[(size * size - 1) / 2];
                }
            }
            
        }

        private void vzvMedButton_Click(object sender, EventArgs e)
        {
            if (openedPictureBox.Image != null && processedPictureBox != null)
            {
                
                new2ImageMatrix = new byte[processedImageMatrix.GetLength(0), processedImageMatrix.GetLength(1)];
                for (int x = 0; x < processedImageMatrix.GetLength(0); x++)
                {
                    for (int y = 0; y < processedImageMatrix.GetLength(1); y++)
                    {
                        new2ImageMatrix[x, y] = defaultImageMatrix[x, y];
                    }
                }
                vzvmedfilter();
                createFromFo3WithNewMat(new2ImageMatrix);

            }
            else
            {
                MessageBox.Show("Download picture!");
            }
        }

        private void vzvmedfilter()
        {
            int sum = 7;
            int[] help = new int[sum];

            for (int x = 0; x < defaultImageMatrix.GetLength(0); x++)
            {
                for (int y = 0; y < defaultImageMatrix.GetLength(1); y++)
                {
                    if (x == 0 || y == 0 || x == defaultImageMatrix.GetLength(0) - 1 || y == defaultImageMatrix.GetLength(1) - 1)
                    {

                    }
                    else
                    {
                        help[0] = processedImageMatrix[x, y+1];
                        help[1] = processedImageMatrix[x+1, y];
                        help[2] = processedImageMatrix[x, y-1];
                        help[3] = processedImageMatrix[x-1, y];
                        help[4] = processedImageMatrix[x, y];
                        help[5] = processedImageMatrix[x, y];
                        help[6] = processedImageMatrix[x, y];
                        Array.Sort(help);
                        new2ImageMatrix[x, y] = (byte)help[(help.Length-1) / 2];
                    }

                }
            }    
        }

        private void MinFButton_Click(object sender, EventArgs e)
        {
            if (openedPictureBox.Image != null && processedPictureBox != null)
            {
                int size = Convert.ToInt32(sizeTextBox.Text);
                new2ImageMatrix = new byte[processedImageMatrix.GetLength(0), processedImageMatrix.GetLength(1)];
                for (int x = 0; x < processedImageMatrix.GetLength(0); x++)
                {
                    for (int y = 0; y < processedImageMatrix.GetLength(1); y++)
                    {
                        new2ImageMatrix[x, y] = defaultImageMatrix[x, y];
                    }
                }
                minFilter(size);
                createFromFo3WithNewMat(new2ImageMatrix);

            }
            else
            {
                MessageBox.Show("Download picture!");
            }
        }

        private void minFilter(int size)
        {
            int bound = (size - 1) / 2;
            int[] help = new int[size * size];
            for (int x = bound; x < defaultImageMatrix.GetLength(0) - bound; x++)
            {
                for (int y = bound; y < defaultImageMatrix.GetLength(1) - bound; y++)
                {

                    for (int i = -bound; i <= bound; i++)
                        for (int j = -bound; j <= bound; j++)
                        {
                            help[(i + bound) * size + j + bound] = processedImageMatrix[x + i, y + j];
                        }
                    Array.Sort(help);
                    new2ImageMatrix[x, y] = (byte)help[0];
                }
            }
        }

        private void MaxFButton_Click(object sender, EventArgs e)
        {
            if (openedPictureBox.Image != null && processedPictureBox != null)
            {
                int size = Convert.ToInt32(sizeTextBox.Text);
                new2ImageMatrix = new byte[processedImageMatrix.GetLength(0), processedImageMatrix.GetLength(1)];
                for (int x = 0; x < processedImageMatrix.GetLength(0); x++)
                {
                    for (int y = 0; y < processedImageMatrix.GetLength(1); y++)
                    {
                        new2ImageMatrix[x, y] = defaultImageMatrix[x, y];
                    }
                }
                maxFilter(size);
                createFromFo3WithNewMat(new2ImageMatrix);

            }
            else
            {
                MessageBox.Show("Download picture!");
            }
        }

        private void maxFilter(int size)
        {
            int bound = (size - 1) / 2;
            int[] help = new int[size * size];
            for (int x = bound; x < defaultImageMatrix.GetLength(0) - bound; x++)
            {
                for (int y = bound; y < defaultImageMatrix.GetLength(1) - bound; y++)
                {

                    for (int i = -bound; i <= bound; i++)
                        for (int j = -bound; j <= bound; j++)
                        {
                            help[(i + bound) * size + j + bound] = processedImageMatrix[x + i, y + j];
                        }
                    Array.Sort(help);
                    new2ImageMatrix[x, y] = (byte)help[help.Length-1];
                }
            }
        }


        private void pointButton_Click(object sender, EventArgs e)
        {
            new2ImageMatrix = new byte[processedImageMatrix.GetLength(0), processedImageMatrix.GetLength(1)];
            for (int x = 0; x < processedImageMatrix.GetLength(0); x++)
            {
                for (int y = 0; y < processedImageMatrix.GetLength(1); y++)
                {
                    new2ImageMatrix[x, y] = defaultImageMatrix[x, y];
                }
            }

            int[,] window;
                int T = 0;
            try
            {
                T = Convert.ToInt32(pointtextBox.Text);
            }
            catch (Exception ex)
            {
                T = 100;
            }
            const int size = 3;
            window = new int[size, size] { { -1, -1, -1 }, { -1, 8, -1 }, { -1, -1, -1 } };
            int help = 0;
            int bound = (size - 1) / 2;
            for (int x = bound; x < defaultImageMatrix.GetLength(0) - bound; x++)
            {
                for (int y = bound; y < defaultImageMatrix.GetLength(1) - bound; y++)
                {

                    for (int i = -bound; i <= bound; i++)
                        for (int j = -bound; j <= bound; j++)
                        {
                            help+= window[i + bound, j + bound]*defaultImageMatrix[x + i, y + j];
                        }
                    if (Math.Abs(help) > T)
                    {
                        if (Math.Abs(help) > 255) help = 255;
                        //else if (Math.Abs(help) < 0) help = 0;
                        new2ImageMatrix[x, y] = (byte)Math.Abs(help);
                    }
                    else
                        new2ImageMatrix[x, y] = 0;
                    help = 0;
                }
            }
            createFromFo3WithNewMat(new2ImageMatrix);
        }

        private void liniaButton_Click(object sender, EventArgs e)
        {
            new2ImageMatrix = new byte[processedImageMatrix.GetLength(0), processedImageMatrix.GetLength(1)];
            for (int x = 0; x < processedImageMatrix.GetLength(0); x++)
            {
                for (int y = 0; y < processedImageMatrix.GetLength(1); y++)
                {
                    new2ImageMatrix[x, y] = defaultImageMatrix[x, y];
                }
            }

            const int size = 3;
            int [,] window = new int[size, size] { { -1, 0, 0 }, { 0, 1, 0 }, { 0, 0, 0 } };
            int help = 0;
            int bound = (size - 1) / 2;
            

            for (int x = bound; x < defaultImageMatrix.GetLength(0) - bound; x++)
            {
                for (int y = bound; y < defaultImageMatrix.GetLength(1) - bound; y++)
                {

                    for (int i = -bound; i <= bound; i++)
                        for (int j = -bound; j <= bound; j++)
                        {
                            help += window[i + bound, j + bound] * defaultImageMatrix[x + i, y + j];
                        }


                    new2ImageMatrix[x, y] = (byte)Math.Abs(help);
                    help = 0;

                }
            }
            createFromFo3WithNewMat(new2ImageMatrix);
        }

        private void robertsButton_Click(object sender, EventArgs e)
        {
            new2ImageMatrix = new byte[processedImageMatrix.GetLength(0), processedImageMatrix.GetLength(1)];
            for (int x = 0; x < processedImageMatrix.GetLength(0); x++)
            {
                for (int y = 0; y < processedImageMatrix.GetLength(1); y++)
                {
                    new2ImageMatrix[x, y] = defaultImageMatrix[x, y];
                }
            }
            int size = 3;
            int tmp1 = 0;
            int tmp2 = 0;
            int help = 0;
            int bound = (size - 1) / 2;
            for (int x = bound; x < defaultImageMatrix.GetLength(0) - bound; x++)
            {
                for (int y = bound; y < defaultImageMatrix.GetLength(1) - bound; y++)
                {
                    tmp1 = Math.Abs(defaultImageMatrix[x, y] - defaultImageMatrix[x + 1, y + 1]);
                    tmp2 = Math.Abs(defaultImageMatrix[x + 1, y] - defaultImageMatrix[x, y + 1]);
                    help = (int)Math.Sqrt(tmp1 * tmp1 + tmp2 * tmp2);
                    if (help > 255) help = 255;
                    else if (help < 0) help = 0;
                    new2ImageMatrix[x, y] = (byte)help;
                }
            }
            createFromFo3WithNewMat(new2ImageMatrix);
        }

        private void previtButton_Click(object sender, EventArgs e)
        {
            new2ImageMatrix = new byte[processedImageMatrix.GetLength(0), processedImageMatrix.GetLength(1)];
            for (int x = 0; x < processedImageMatrix.GetLength(0); x++)
            {
                for (int y = 0; y < processedImageMatrix.GetLength(1); y++)
                {
                    new2ImageMatrix[x, y] = defaultImageMatrix[x, y];
                }
            }
            int tmp1 = 0;
            int tmp2 = 0;
            const int size = 3;
            int [,] window = new int[size, size] { { 1, 1, 0 }, { 0, 0, 0 }, { 0, -1, -1 } };
            int [,] window1 = new int[size, size] { { 1, 0, 0 }, { 1, 0, -1 }, { 0, 0, -1 } };
            int help = 0;
            int bound = (size - 1) / 2;
            for (int x = bound; x < defaultImageMatrix.GetLength(0) - bound; x++)
            {
                for (int y = bound; y < defaultImageMatrix.GetLength(1) - bound; y++)
                {

                    for (int i = -bound; i <= bound; i++)
                        for (int j = -bound; j <= bound; j++)
                        {
                            tmp1 += window[i + bound, j + bound] * defaultImageMatrix[x + i, y + j];
                            tmp2 += window1[i + bound, j + bound] * defaultImageMatrix[x + i, y + j];
                        }
                    help = (int)Math.Sqrt(tmp1 * tmp1 + tmp2 * tmp2);
                    if (help > 255) help = 255;
                    else if (help < 0) help = 0;
                    new2ImageMatrix[x, y] = (byte)help;
                    tmp1 = 0;
                    tmp2 = 0;
                }
            }
            createFromFo3WithNewMat(new2ImageMatrix);
        }

        private void sobelButton_Click(object sender, EventArgs e)
        {
            new2ImageMatrix = new byte[processedImageMatrix.GetLength(0), processedImageMatrix.GetLength(1)];
            for (int x = 0; x < processedImageMatrix.GetLength(0); x++)
            {
                for (int y = 0; y < processedImageMatrix.GetLength(1); y++)
                {
                    new2ImageMatrix[x, y] = defaultImageMatrix[x, y];
                }
            }
            int tmp1 = 0;
            int tmp2 = 0;
            const int size = 3;
            int [,] window = new int[size, size] { { 2, 1, 0 }, { 0, 0, 0 }, { 0, -1, -2 } };
            int [,] window1 = new int[size, size] { { 2, 0, 0 }, { 1, 0, -1 }, { 0, 0, -2 } };
            int help = 0;
            int bound = (size - 1) / 2;
            for (int x = bound; x < defaultImageMatrix.GetLength(0) - bound; x++)
            {
                for (int y = bound; y < defaultImageMatrix.GetLength(1) - bound; y++)
                {

                    for (int i = -bound; i <= bound; i++)
                        for (int j = -bound; j <= bound; j++)
                        {
                            tmp1 += window[i + bound, j + bound] * defaultImageMatrix[x + i, y + j];
                            tmp2 += window1[i + bound, j + bound] * defaultImageMatrix[x + i, y + j];
                        }
                    help = (int)Math.Sqrt(tmp1 * tmp1 + tmp2 * tmp2);
                    if (help > 255) help = 255;
                    else if (help < 0) help = 0;
                    new2ImageMatrix[x, y] = (byte)help;
                    tmp1 = 0;
                    tmp2 = 0;
                }
            }
            createFromFo3WithNewMat(new2ImageMatrix);
        }

        private void robertsEdgeButton_Click(object sender, EventArgs e)
        {
            new2ImageMatrix = new byte[processedImageMatrix.GetLength(0), processedImageMatrix.GetLength(1)];
            for (int x = 0; x < processedImageMatrix.GetLength(0); x++)
            {
                for (int y = 0; y < processedImageMatrix.GetLength(1); y++)
                {
                    new2ImageMatrix[x, y] = defaultImageMatrix[x, y];
                }
            }
            int tmp1 = 0;
            int tmp2 = 0;
            const int size = 3;
            int [,] window = new int[size, size] { { 1, 1, 1 }, { 1, -2, -1 }, { 1, -1, -1 } };
            int [,] window1 = new int[size, size] { { -1, -1, 1 }, { -1, -2, 1 }, { 1, 1, 1 } };
            int help = 0;
            int bound = (size - 1) / 2;
            for (int x = bound; x < defaultImageMatrix.GetLength(0) - bound; x++)
            {
                for (int y = bound; y < defaultImageMatrix.GetLength(1) - bound; y++)
                {

                    for (int i = -bound; i <= bound; i++)
                        for (int j = -bound; j <= bound; j++)
                        {
                            tmp1 += window[i + bound, j + bound] * defaultImageMatrix[x + i, y + j];
                            tmp2 += window1[i + bound, j + bound] * defaultImageMatrix[x + i, y + j];
                        }
                    help = (int)Math.Sqrt(tmp1 * tmp1 + tmp2 * tmp2);
                    if (help > 255) help = 255;
                    else if (help < 0) help = 0;
                    new2ImageMatrix[x, y] = (byte)help;
                    tmp1 = 0;
                    tmp2 = 0;
                }
            }
            createFromFo3WithNewMat(new2ImageMatrix);
        }

        /*private void kirshaButton_Click(object sender, EventArgs e)
        {
            new2ImageMatrix = new byte[processedImageMatrix.GetLength(0), processedImageMatrix.GetLength(1)];
            for (int x = 0; x < processedImageMatrix.GetLength(0); x++)
            {
                for (int y = 0; y < processedImageMatrix.GetLength(1); y++)
                {
                    new2ImageMatrix[x, y] = defaultImageMatrix[x, y];
                }
            }

            int tmp1 = 0;
            int tmp2 = 0;
            const int size = 3;
            int[,] window = new int[size, size] { { 3, 3, 3 }, { 3, 0, -5 }, { 3, -5, -5 } };
            int[,] window1 = new int[size, size] { { -5, -5, 3 }, { -5, 0, 3 }, { 3, 3, 3 } };
            int help = 0;
            int bound = (size - 1) / 2;
            for (int x = bound; x < defaultImageMatrix.GetLength(0) - bound; x++)
            {
                for (int y = bound; y < defaultImageMatrix.GetLength(1) - bound; y++)
                {

                    for (int i = -bound; i <= bound; i++)
                        for (int j = -bound; j <= bound; j++)
                        {
                            tmp1 += window[i + bound, j + bound] * defaultImageMatrix[x + i, y + j];
                            tmp2 += window1[i + bound, j + bound] * defaultImageMatrix[x + i, y + j];
                        }
                    help = (int)Math.Sqrt(tmp1 * tmp1 + tmp2 * tmp2);
                    if (help > 255) help = 255;
                    else if (help < 0) help = 0;
                    new2ImageMatrix[x, y] = (byte)help;
                    tmp1 = 0;
                    tmp2 = 0;
                }
            }
            createFromFo3WithNewMat(new2ImageMatrix);

        }*/

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }

}
