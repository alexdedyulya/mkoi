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

namespace mkoi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        
        Bitmap defaultImage;
        Bitmap processedImage;
       

        byte[,] defaultImageMatrix;
        byte[,] processedImageMatrix;

        private void OpenButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Open File";
            openFileDialog1.Filter = "jpeg files (*.jpg)|*.jpg| png files (*.png)|*.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                defaultImage = new Bitmap(openFileDialog1.FileName);
                openedPictureBox.Image = defaultImage;
                FillDefaultImageMatrix();
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
                    defaultImageMatrix[x,y] = (byte)(0.3 * pixel.R + 0.6 * pixel.G + 0.1 * pixel.B);
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
            processedImageMatrix = new byte[defaultImageMatrix.GetLength(0), defaultImageMatrix.GetLength(1)]; // по размерностям
            for (int x = 0; x < defaultImageMatrix.GetLength(0); x++)
            {
                for (int y = 0; y < defaultImageMatrix.GetLength(1); y++)
                {
                    double result = 255 * Math.Pow((defaultImageMatrix[x, y]/255.0),value);
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
            double gradValue = 0;
            if (openedPictureBox.Image != null)
            {
            try
            {
                gradValue = Convert.ToDouble(logTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Incorrect Value");
            }
            logConstValue(gradValue);
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
            processedImageMatrix = new byte[defaultImageMatrix.GetLength(0), defaultImageMatrix.GetLength(1)]; // по размерностям
            for (int x = 0; x < defaultImageMatrix.GetLength(0); x++)
            {
                for (int y = 0; y < defaultImageMatrix.GetLength(1); y++)
                {
                    double result = 255.0 * (Math.Log(1+defaultImageMatrix[x,y])/(Math.Log(1+255.0)));
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

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
