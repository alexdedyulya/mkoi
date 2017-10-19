using System.Drawing;
namespace mkoi
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.openButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openedPictureBox = new System.Windows.Forms.PictureBox();
            this.processedPictureBox = new System.Windows.Forms.PictureBox();
            this.processButton = new System.Windows.Forms.Button();
            this.additionalConstantTextBox = new System.Windows.Forms.TextBox();
            this.addConstButton = new System.Windows.Forms.Button();
            this.negativButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.multiConstButton = new System.Windows.Forms.Button();
            this.multiConstTextBox = new System.Windows.Forms.TextBox();
            this.gradTextBox = new System.Windows.Forms.TextBox();
            this.gradButton = new System.Windows.Forms.Button();
            this.logButton = new System.Windows.Forms.Button();
            this.logTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gistoButton = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.equalButton = new System.Windows.Forms.Button();
            this.konstraktButton = new System.Windows.Forms.Button();
            this.maxcontrTextBox = new System.Windows.Forms.TextBox();
            this.mincontrTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bitploskButton = new System.Windows.Forms.Button();
            this.obrabotkaButton = new System.Windows.Forms.Button();
            this.obrabtextBox = new System.Windows.Forms.TextBox();
            this.obrGradButton = new System.Windows.Forms.Button();
            this.otsaButton = new System.Windows.Forms.Button();
            this.nizkochastButton = new System.Windows.Forms.Button();
            this.gaussButton = new System.Windows.Forms.Button();
            this.reskoztButton = new System.Windows.Forms.Button();
            this.nerezMaskButton = new System.Windows.Forms.Button();
            this.sizeTextBox = new System.Windows.Forms.TextBox();
            this.medButton = new System.Windows.Forms.Button();
            this.vzvMedButton = new System.Windows.Forms.Button();
            this.MinFButton = new System.Windows.Forms.Button();
            this.MaxFButton = new System.Windows.Forms.Button();
            this.pointButton = new System.Windows.Forms.Button();
            this.pointtextBox = new System.Windows.Forms.TextBox();
            this.liniaButton = new System.Windows.Forms.Button();
            this.robertsButton = new System.Windows.Forms.Button();
            this.previtButton = new System.Windows.Forms.Button();
            this.sobelButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.robertsEdgeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.openedPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processedPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(12, 281);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(75, 23);
            this.openButton.TabIndex = 0;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(236, 281);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // openedPictureBox
            // 
            this.openedPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.openedPictureBox.Location = new System.Drawing.Point(12, 27);
            this.openedPictureBox.Name = "openedPictureBox";
            this.openedPictureBox.Size = new System.Drawing.Size(270, 217);
            this.openedPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.openedPictureBox.TabIndex = 2;
            this.openedPictureBox.TabStop = false;
            // 
            // processedPictureBox
            // 
            this.processedPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.processedPictureBox.Location = new System.Drawing.Point(301, 27);
            this.processedPictureBox.Name = "processedPictureBox";
            this.processedPictureBox.Size = new System.Drawing.Size(287, 217);
            this.processedPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.processedPictureBox.TabIndex = 3;
            this.processedPictureBox.TabStop = false;
            // 
            // processButton
            // 
            this.processButton.Location = new System.Drawing.Point(121, 281);
            this.processButton.Name = "processButton";
            this.processButton.Size = new System.Drawing.Size(75, 23);
            this.processButton.TabIndex = 4;
            this.processButton.Text = "process";
            this.processButton.UseVisualStyleBackColor = true;
            this.processButton.Click += new System.EventHandler(this.processButton_Click);
            // 
            // additionalConstantTextBox
            // 
            this.additionalConstantTextBox.Location = new System.Drawing.Point(607, 27);
            this.additionalConstantTextBox.Name = "additionalConstantTextBox";
            this.additionalConstantTextBox.Size = new System.Drawing.Size(152, 20);
            this.additionalConstantTextBox.TabIndex = 5;
            // 
            // addConstButton
            // 
            this.addConstButton.Location = new System.Drawing.Point(775, 25);
            this.addConstButton.Name = "addConstButton";
            this.addConstButton.Size = new System.Drawing.Size(75, 23);
            this.addConstButton.TabIndex = 6;
            this.addConstButton.Text = "Add Const";
            this.addConstButton.UseVisualStyleBackColor = true;
            this.addConstButton.Click += new System.EventHandler(this.addConstButton_Click);
            // 
            // negativButton
            // 
            this.negativButton.Location = new System.Drawing.Point(344, 281);
            this.negativButton.Name = "negativButton";
            this.negativButton.Size = new System.Drawing.Size(75, 23);
            this.negativButton.TabIndex = 7;
            this.negativButton.Text = "Negativ";
            this.negativButton.UseVisualStyleBackColor = true;
            this.negativButton.Click += new System.EventHandler(this.negativButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(950, 559);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // multiConstButton
            // 
            this.multiConstButton.Location = new System.Drawing.Point(775, 51);
            this.multiConstButton.Name = "multiConstButton";
            this.multiConstButton.Size = new System.Drawing.Size(75, 23);
            this.multiConstButton.TabIndex = 9;
            this.multiConstButton.Text = "Multi Const";
            this.multiConstButton.UseVisualStyleBackColor = true;
            this.multiConstButton.Click += new System.EventHandler(this.multiConstButton_Click);
            // 
            // multiConstTextBox
            // 
            this.multiConstTextBox.Location = new System.Drawing.Point(607, 53);
            this.multiConstTextBox.Name = "multiConstTextBox";
            this.multiConstTextBox.Size = new System.Drawing.Size(152, 20);
            this.multiConstTextBox.TabIndex = 10;
            // 
            // gradTextBox
            // 
            this.gradTextBox.Location = new System.Drawing.Point(607, 79);
            this.gradTextBox.Name = "gradTextBox";
            this.gradTextBox.Size = new System.Drawing.Size(152, 20);
            this.gradTextBox.TabIndex = 11;
            // 
            // gradButton
            // 
            this.gradButton.Location = new System.Drawing.Point(775, 77);
            this.gradButton.Name = "gradButton";
            this.gradButton.Size = new System.Drawing.Size(75, 23);
            this.gradButton.TabIndex = 12;
            this.gradButton.Text = "Grad";
            this.gradButton.UseVisualStyleBackColor = true;
            this.gradButton.Click += new System.EventHandler(this.gradButton_Click);
            // 
            // logButton
            // 
            this.logButton.Location = new System.Drawing.Point(775, 103);
            this.logButton.Name = "logButton";
            this.logButton.Size = new System.Drawing.Size(75, 23);
            this.logButton.TabIndex = 13;
            this.logButton.Text = "Log";
            this.logButton.UseVisualStyleBackColor = true;
            this.logButton.Click += new System.EventHandler(this.logButton_Click);
            // 
            // logTextBox
            // 
            this.logTextBox.Location = new System.Drawing.Point(607, 105);
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.Size = new System.Drawing.Size(152, 20);
            this.logTextBox.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "First Picture Box";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(392, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Second Picture Box";
            // 
            // gistoButton
            // 
            this.gistoButton.Location = new System.Drawing.Point(586, 442);
            this.gistoButton.Name = "gistoButton";
            this.gistoButton.Size = new System.Drawing.Size(75, 23);
            this.gistoButton.TabIndex = 17;
            this.gistoButton.Text = "Gistogramma";
            this.gistoButton.UseVisualStyleBackColor = true;
            this.gistoButton.Click += new System.EventHandler(this.gistoButton_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(29, 345);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Piksel";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(537, 230);
            this.chart1.TabIndex = 18;
            this.chart1.Text = "Gistogramma";
            // 
            // equalButton
            // 
            this.equalButton.Location = new System.Drawing.Point(586, 471);
            this.equalButton.Name = "equalButton";
            this.equalButton.Size = new System.Drawing.Size(75, 23);
            this.equalButton.TabIndex = 20;
            this.equalButton.Text = "Equaliz";
            this.equalButton.UseVisualStyleBackColor = true;
            this.equalButton.Click += new System.EventHandler(this.equalButton_Click);
            // 
            // konstraktButton
            // 
            this.konstraktButton.Location = new System.Drawing.Point(779, 507);
            this.konstraktButton.Name = "konstraktButton";
            this.konstraktButton.Size = new System.Drawing.Size(75, 23);
            this.konstraktButton.TabIndex = 21;
            this.konstraktButton.Text = "Konstrakt";
            this.konstraktButton.UseVisualStyleBackColor = true;
            this.konstraktButton.Click += new System.EventHandler(this.konstraktButton_Click);
            // 
            // maxcontrTextBox
            // 
            this.maxcontrTextBox.Location = new System.Drawing.Point(617, 500);
            this.maxcontrTextBox.Name = "maxcontrTextBox";
            this.maxcontrTextBox.Size = new System.Drawing.Size(152, 20);
            this.maxcontrTextBox.TabIndex = 22;
            // 
            // mincontrTextBox
            // 
            this.mincontrTextBox.Location = new System.Drawing.Point(617, 526);
            this.mincontrTextBox.Name = "mincontrTextBox";
            this.mincontrTextBox.Size = new System.Drawing.Size(152, 20);
            this.mincontrTextBox.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(583, 507);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "MAX:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(583, 533);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "MIN:";
            // 
            // bitploskButton
            // 
            this.bitploskButton.Location = new System.Drawing.Point(586, 549);
            this.bitploskButton.Name = "bitploskButton";
            this.bitploskButton.Size = new System.Drawing.Size(75, 23);
            this.bitploskButton.TabIndex = 26;
            this.bitploskButton.Text = "BitPlosk";
            this.bitploskButton.UseVisualStyleBackColor = true;
            this.bitploskButton.Click += new System.EventHandler(this.bitploskButton_Click);
            // 
            // obrabotkaButton
            // 
            this.obrabotkaButton.Location = new System.Drawing.Point(775, 129);
            this.obrabotkaButton.Name = "obrabotkaButton";
            this.obrabotkaButton.Size = new System.Drawing.Size(75, 23);
            this.obrabotkaButton.TabIndex = 27;
            this.obrabotkaButton.Text = "Obrabotka";
            this.obrabotkaButton.UseVisualStyleBackColor = true;
            this.obrabotkaButton.Click += new System.EventHandler(this.obrabotkaButton_Click);
            // 
            // obrabtextBox
            // 
            this.obrabtextBox.Location = new System.Drawing.Point(607, 131);
            this.obrabtextBox.Name = "obrabtextBox";
            this.obrabtextBox.Size = new System.Drawing.Size(152, 20);
            this.obrabtextBox.TabIndex = 28;
            // 
            // obrGradButton
            // 
            this.obrGradButton.Location = new System.Drawing.Point(607, 157);
            this.obrGradButton.Name = "obrGradButton";
            this.obrGradButton.Size = new System.Drawing.Size(75, 23);
            this.obrGradButton.TabIndex = 29;
            this.obrGradButton.Text = "Obr Grad";
            this.obrGradButton.UseVisualStyleBackColor = true;
            this.obrGradButton.Click += new System.EventHandler(this.obrGradButton_Click);
            // 
            // otsaButton
            // 
            this.otsaButton.Location = new System.Drawing.Point(775, 158);
            this.otsaButton.Name = "otsaButton";
            this.otsaButton.Size = new System.Drawing.Size(75, 23);
            this.otsaButton.TabIndex = 30;
            this.otsaButton.Text = "Otsa";
            this.otsaButton.UseVisualStyleBackColor = true;
            this.otsaButton.Click += new System.EventHandler(this.otsaButton_Click);
            // 
            // nizkochastButton
            // 
            this.nizkochastButton.Location = new System.Drawing.Point(775, 241);
            this.nizkochastButton.Name = "nizkochastButton";
            this.nizkochastButton.Size = new System.Drawing.Size(75, 23);
            this.nizkochastButton.TabIndex = 31;
            this.nizkochastButton.Text = "Nizkochast";
            this.nizkochastButton.UseVisualStyleBackColor = true;
            this.nizkochastButton.Click += new System.EventHandler(this.nizkochastButton_Click);
            // 
            // gaussButton
            // 
            this.gaussButton.Location = new System.Drawing.Point(775, 270);
            this.gaussButton.Name = "gaussButton";
            this.gaussButton.Size = new System.Drawing.Size(75, 23);
            this.gaussButton.TabIndex = 32;
            this.gaussButton.Text = "Gauss";
            this.gaussButton.UseVisualStyleBackColor = true;
            this.gaussButton.Click += new System.EventHandler(this.gaussButton_Click);
            // 
            // reskoztButton
            // 
            this.reskoztButton.Location = new System.Drawing.Point(775, 299);
            this.reskoztButton.Name = "reskoztButton";
            this.reskoztButton.Size = new System.Drawing.Size(75, 23);
            this.reskoztButton.TabIndex = 33;
            this.reskoztButton.Text = "Reskozt";
            this.reskoztButton.UseVisualStyleBackColor = true;
            this.reskoztButton.Click += new System.EventHandler(this.reskoztButton_Click);
            // 
            // nerezMaskButton
            // 
            this.nerezMaskButton.Location = new System.Drawing.Point(775, 328);
            this.nerezMaskButton.Name = "nerezMaskButton";
            this.nerezMaskButton.Size = new System.Drawing.Size(75, 23);
            this.nerezMaskButton.TabIndex = 34;
            this.nerezMaskButton.Text = "NerezMask";
            this.nerezMaskButton.UseVisualStyleBackColor = true;
            this.nerezMaskButton.Click += new System.EventHandler(this.nerezMaskButton_Click);
            // 
            // sizeTextBox
            // 
            this.sizeTextBox.Location = new System.Drawing.Point(607, 244);
            this.sizeTextBox.Name = "sizeTextBox";
            this.sizeTextBox.Size = new System.Drawing.Size(152, 20);
            this.sizeTextBox.TabIndex = 35;
            // 
            // medButton
            // 
            this.medButton.Location = new System.Drawing.Point(775, 357);
            this.medButton.Name = "medButton";
            this.medButton.Size = new System.Drawing.Size(75, 23);
            this.medButton.TabIndex = 36;
            this.medButton.Text = "medButton";
            this.medButton.UseVisualStyleBackColor = true;
            this.medButton.Click += new System.EventHandler(this.medButton_Click);
            // 
            // vzvMedButton
            // 
            this.vzvMedButton.Location = new System.Drawing.Point(775, 386);
            this.vzvMedButton.Name = "vzvMedButton";
            this.vzvMedButton.Size = new System.Drawing.Size(75, 23);
            this.vzvMedButton.TabIndex = 37;
            this.vzvMedButton.Text = "Med+Button";
            this.vzvMedButton.UseVisualStyleBackColor = true;
            this.vzvMedButton.Click += new System.EventHandler(this.vzvMedButton_Click);
            // 
            // MinFButton
            // 
            this.MinFButton.Location = new System.Drawing.Point(694, 270);
            this.MinFButton.Name = "MinFButton";
            this.MinFButton.Size = new System.Drawing.Size(75, 23);
            this.MinFButton.TabIndex = 38;
            this.MinFButton.Text = "MinFilter";
            this.MinFButton.UseVisualStyleBackColor = true;
            this.MinFButton.Click += new System.EventHandler(this.MinFButton_Click);
            // 
            // MaxFButton
            // 
            this.MaxFButton.Location = new System.Drawing.Point(694, 299);
            this.MaxFButton.Name = "MaxFButton";
            this.MaxFButton.Size = new System.Drawing.Size(75, 23);
            this.MaxFButton.TabIndex = 39;
            this.MaxFButton.Text = "MaxFilter";
            this.MaxFButton.UseVisualStyleBackColor = true;
            this.MaxFButton.Click += new System.EventHandler(this.MaxFButton_Click);
            // 
            // pointButton
            // 
            this.pointButton.Location = new System.Drawing.Point(950, 27);
            this.pointButton.Name = "pointButton";
            this.pointButton.Size = new System.Drawing.Size(75, 23);
            this.pointButton.TabIndex = 40;
            this.pointButton.Text = "PointButton";
            this.pointButton.UseVisualStyleBackColor = true;
            this.pointButton.Click += new System.EventHandler(this.pointButton_Click);
            // 
            // pointtextBox
            // 
            this.pointtextBox.Location = new System.Drawing.Point(869, 30);
            this.pointtextBox.Name = "pointtextBox";
            this.pointtextBox.Size = new System.Drawing.Size(75, 20);
            this.pointtextBox.TabIndex = 41;
            // 
            // liniaButton
            // 
            this.liniaButton.Location = new System.Drawing.Point(950, 56);
            this.liniaButton.Name = "liniaButton";
            this.liniaButton.Size = new System.Drawing.Size(75, 23);
            this.liniaButton.TabIndex = 42;
            this.liniaButton.Text = "SdvigButton";
            this.liniaButton.UseVisualStyleBackColor = true;
            this.liniaButton.Click += new System.EventHandler(this.liniaButton_Click);
            // 
            // robertsButton
            // 
            this.robertsButton.Location = new System.Drawing.Point(950, 85);
            this.robertsButton.Name = "robertsButton";
            this.robertsButton.Size = new System.Drawing.Size(75, 23);
            this.robertsButton.TabIndex = 43;
            this.robertsButton.Text = "Roberts";
            this.robertsButton.UseVisualStyleBackColor = true;
            this.robertsButton.Click += new System.EventHandler(this.robertsButton_Click);
            // 
            // previtButton
            // 
            this.previtButton.Location = new System.Drawing.Point(950, 114);
            this.previtButton.Name = "previtButton";
            this.previtButton.Size = new System.Drawing.Size(75, 23);
            this.previtButton.TabIndex = 44;
            this.previtButton.Text = "Previt";
            this.previtButton.UseVisualStyleBackColor = true;
            this.previtButton.Click += new System.EventHandler(this.previtButton_Click);
            // 
            // sobelButton
            // 
            this.sobelButton.Location = new System.Drawing.Point(950, 143);
            this.sobelButton.Name = "sobelButton";
            this.sobelButton.Size = new System.Drawing.Size(75, 23);
            this.sobelButton.TabIndex = 45;
            this.sobelButton.Text = "Sobel";
            this.sobelButton.UseVisualStyleBackColor = true;
            this.sobelButton.Click += new System.EventHandler(this.sobelButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(971, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Edge";
            // 
            // robertsEdgeButton
            // 
            this.robertsEdgeButton.Location = new System.Drawing.Point(950, 194);
            this.robertsEdgeButton.Name = "robertsEdgeButton";
            this.robertsEdgeButton.Size = new System.Drawing.Size(75, 23);
            this.robertsEdgeButton.TabIndex = 47;
            this.robertsEdgeButton.Text = "Robertson";
            this.robertsEdgeButton.UseVisualStyleBackColor = true;
            this.robertsEdgeButton.Click += new System.EventHandler(this.robertsEdgeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 594);
            this.Controls.Add(this.robertsEdgeButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sobelButton);
            this.Controls.Add(this.previtButton);
            this.Controls.Add(this.robertsButton);
            this.Controls.Add(this.liniaButton);
            this.Controls.Add(this.pointtextBox);
            this.Controls.Add(this.pointButton);
            this.Controls.Add(this.MaxFButton);
            this.Controls.Add(this.MinFButton);
            this.Controls.Add(this.vzvMedButton);
            this.Controls.Add(this.medButton);
            this.Controls.Add(this.sizeTextBox);
            this.Controls.Add(this.nerezMaskButton);
            this.Controls.Add(this.reskoztButton);
            this.Controls.Add(this.gaussButton);
            this.Controls.Add(this.nizkochastButton);
            this.Controls.Add(this.otsaButton);
            this.Controls.Add(this.obrGradButton);
            this.Controls.Add(this.obrabtextBox);
            this.Controls.Add(this.obrabotkaButton);
            this.Controls.Add(this.bitploskButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mincontrTextBox);
            this.Controls.Add(this.maxcontrTextBox);
            this.Controls.Add(this.konstraktButton);
            this.Controls.Add(this.equalButton);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.gistoButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logTextBox);
            this.Controls.Add(this.logButton);
            this.Controls.Add(this.gradButton);
            this.Controls.Add(this.gradTextBox);
            this.Controls.Add(this.multiConstTextBox);
            this.Controls.Add(this.multiConstButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.negativButton);
            this.Controls.Add(this.addConstButton);
            this.Controls.Add(this.additionalConstantTextBox);
            this.Controls.Add(this.processButton);
            this.Controls.Add(this.processedPictureBox);
            this.Controls.Add(this.openedPictureBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.openButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.openedPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processedPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox openedPictureBox;
        private System.Windows.Forms.PictureBox processedPictureBox;
        private System.Windows.Forms.Button processButton;
        private System.Windows.Forms.TextBox additionalConstantTextBox;
        private System.Windows.Forms.Button addConstButton;
        private System.Windows.Forms.Button negativButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button multiConstButton;
        private System.Windows.Forms.TextBox multiConstTextBox;
        private System.Windows.Forms.TextBox gradTextBox;
        private System.Windows.Forms.Button gradButton;
        private System.Windows.Forms.Button logButton;
        private System.Windows.Forms.TextBox logTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button gistoButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button equalButton;
        private System.Windows.Forms.Button konstraktButton;
        private System.Windows.Forms.TextBox maxcontrTextBox;
        private System.Windows.Forms.TextBox mincontrTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bitploskButton;
        private System.Windows.Forms.Button obrabotkaButton;
        private System.Windows.Forms.TextBox obrabtextBox;
        private System.Windows.Forms.Button obrGradButton;
        private System.Windows.Forms.Button otsaButton;
        private System.Windows.Forms.Button nizkochastButton;
        private System.Windows.Forms.Button gaussButton;
        private System.Windows.Forms.Button reskoztButton;
        private System.Windows.Forms.Button nerezMaskButton;
        private System.Windows.Forms.TextBox sizeTextBox;
        private System.Windows.Forms.Button medButton;
        private System.Windows.Forms.Button vzvMedButton;
        private System.Windows.Forms.Button MinFButton;
        private System.Windows.Forms.Button MaxFButton;
        private System.Windows.Forms.Button pointButton;
        private System.Windows.Forms.TextBox pointtextBox;
        private System.Windows.Forms.Button liniaButton;
        private System.Windows.Forms.Button robertsButton;
        private System.Windows.Forms.Button previtButton;
        private System.Windows.Forms.Button sobelButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button robertsEdgeButton;
        public Bitmap processedImage;
    }
}

