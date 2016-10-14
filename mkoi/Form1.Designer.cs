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
            ((System.ComponentModel.ISupportInitialize)(this.openedPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processedPictureBox)).BeginInit();
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
            this.additionalConstantTextBox.Location = new System.Drawing.Point(607, 61);
            this.additionalConstantTextBox.Name = "additionalConstantTextBox";
            this.additionalConstantTextBox.Size = new System.Drawing.Size(152, 20);
            this.additionalConstantTextBox.TabIndex = 5;
            // 
            // addConstButton
            // 
            this.addConstButton.Location = new System.Drawing.Point(775, 58);
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
            this.exitButton.Location = new System.Drawing.Point(775, 309);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // multiConstButton
            // 
            this.multiConstButton.Location = new System.Drawing.Point(775, 113);
            this.multiConstButton.Name = "multiConstButton";
            this.multiConstButton.Size = new System.Drawing.Size(75, 23);
            this.multiConstButton.TabIndex = 9;
            this.multiConstButton.Text = "Multi Const";
            this.multiConstButton.UseVisualStyleBackColor = true;
            this.multiConstButton.Click += new System.EventHandler(this.multiConstButton_Click);
            // 
            // multiConstTextBox
            // 
            this.multiConstTextBox.Location = new System.Drawing.Point(607, 116);
            this.multiConstTextBox.Name = "multiConstTextBox";
            this.multiConstTextBox.Size = new System.Drawing.Size(152, 20);
            this.multiConstTextBox.TabIndex = 10;
            // 
            // gradTextBox
            // 
            this.gradTextBox.Location = new System.Drawing.Point(607, 165);
            this.gradTextBox.Name = "gradTextBox";
            this.gradTextBox.Size = new System.Drawing.Size(152, 20);
            this.gradTextBox.TabIndex = 11;
            // 
            // gradButton
            // 
            this.gradButton.Location = new System.Drawing.Point(775, 163);
            this.gradButton.Name = "gradButton";
            this.gradButton.Size = new System.Drawing.Size(75, 23);
            this.gradButton.TabIndex = 12;
            this.gradButton.Text = "Grad";
            this.gradButton.UseVisualStyleBackColor = true;
            this.gradButton.Click += new System.EventHandler(this.gradButton_Click);
            // 
            // logButton
            // 
            this.logButton.Location = new System.Drawing.Point(775, 206);
            this.logButton.Name = "logButton";
            this.logButton.Size = new System.Drawing.Size(75, 23);
            this.logButton.TabIndex = 13;
            this.logButton.Text = "Log";
            this.logButton.UseVisualStyleBackColor = true;
            this.logButton.Click += new System.EventHandler(this.logButton_Click);
            // 
            // logTextBox
            // 
            this.logTextBox.Location = new System.Drawing.Point(607, 209);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 344);
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
    }
}

